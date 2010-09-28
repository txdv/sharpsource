/**
 * vim: set ts=4 :
 * =============================================================================
 * SourceMod SharpSource Extension
 * Copyright (C) 2010 Andrius Bentkus LLC.  All rights reserved.
 * =============================================================================
 *
 * This program is free software; you can redistribute it and/or modify it under
 * the terms of the GNU General Public License, version 3.0, as published by the
 * Free Software Foundation.
 * 
 * This program is distributed in the hope that it will be useful, but WITHOUT
 * ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS
 * FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more
 * details.
 *
 * You should have received a copy of the GNU General Public License along with
 * this program.  If not, see <http://www.gnu.org/licenses/>.
 *
 * As a special exception, AlliedModders LLC gives you permission to link the
 * code of this program (as well as its derivative works) to "Half-Life 2," the
 * "Source Engine," the "SourcePawn JIT," and any Game MODs that run on software
 * by the Valve Corporation.  You must obey the GNU General Public License in
 * all respects for all other code used.  Additionally, AlliedModders LLC grants
 * this exception to all derivative works.  AlliedModders LLC defines further
 * exceptions, found in LICENSE.txt (as of this writing, version JULY-31-2007),
 * or <http://www.sourcemod.net/license.php>.
 *
 * Version: $Id$
 */

#include <sourcemod_version.h>
#include "extension.h"

// mono
#include <mono/jit/jit.h>
#include <mono/metadata/object.h>
#include <mono/metadata/environment.h>
#include <mono/metadata/assembly.h>
#include <mono/metadata/debug-helpers.h>
#include <string.h>

//const char *library = "cstrike/addons/sharpmod/sharpmod.dll";
const char *library = "SharpSource.dll";

/**
 * @file extension.cpp
 * @brief Implement extension code here.
 */

SharpSource g_SharpSource;		/**< Global singleton for extension's main interface */
SMEXT_LINK(&g_SharpSource);

bool SharpSource::SDK_OnLoad(char *error, size_t maxlength, bool late)
{
  domain = mono_jit_init(library);
  assembly = mono_domain_assembly_open(domain, library);
  if (!assembly)
  {
    strcpy(error, "Can't find the .NET assembly file in the sharpmod directory");
    return false;
  }

  MonoImage *image = mono_assembly_get_image(assembly);
  if (!image)
  {
    strcpy(error, "Can't load the assembly image");
    return false;
  }

  MonoClass *metamod_class = mono_class_from_name(image, "SharpSource", "MainClass");

  if (!metamod_class)
  {
    strcpy(error, "Can't find the class SharpSource::MainClass in the provided assembly");
    return false;
  }

  MonoMethod *init = mono_class_get_method_from_name(metamod_class, "Init", 1);

  if (!init)
  {
    strcpy(error, "Can't find the method Init in MainClass");
    return false;
  }

  void *args[1];
  args[0] = &g_pSM;
  mono_runtime_invoke(init, NULL, args, NULL);

  return true;
}

void SharpSource::SDK_OnUnload()
{
  mono_jit_cleanup(domain);
}

void SharpSource::SDK_OnAllLoaded() { }

void SharpSource::SDK_OnPauseChange(bool paused) { }

bool SharpSource::QueryRunning(char *error, size_t maxlength) { return true; }


#if defined SMEXT_CONF_METAMOD

bool SharpSource::SDK_OnMetamodLoad(ISmmAPI *ismm, char *error, size_t maxlength, bool late) { return true; }

bool SharpSource::SDK_OnMetamodUnload(char *error, size_t maxlength) { return true; }

bool SharpSource::SDK_OnMetamodPauseChange(bool paused, char *error, size_t maxlength) { return true; }

#endif
