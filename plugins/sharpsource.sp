#include <sourcemod>

public Plugin:myinfo =
{
  name = "SharpSource example plugin",
  author = "Andrius Bentkus",
  description = "SharpSource testing suite",
  version = "0.0.1.0",
  url = "no site available"
};

native test_addnative0();
native test_addnative1();
native test_addnative2();
native test_addnative3();
native test_addnative4();
native test_addnative5(i);
native test_addnative6();
native test_addnative7(i);
native test_end(i);

native test_callback(Function:func, String:buffer[], maxlength);

// new Function:callback = GetFunctionByName(GetMyHandle(), "callback_func");
public callback_func(String:str[])
{
  assert(strcmp(str, "hello world") == 0);
}


public OnPluginStart()
{
  assert(test_addnative0() == 0);
  assert(test_addnative1() == 1);
  assert(test_addnative2() == 2);
  assert(test_addnative3() == 3);
  assert(test_addnative4() == 4);
  assert(test_addnative5(42) == 5);
  assert(test_addnative6() == 42);
  new i = 1234;
  assert(test_addnative7(i) == i);
  test_end(7);
  new String:buffer[] = "HELLO WORLD";
  test_callback(callback_func, buffer, sizeof(buffer));
}
