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

native test_callback1(Function:func, String:buffer[], maxlength);
native test_callback2(Function:func, String:buffer[], maxlength);

public callback_func1(String:str[])
{
  assert(strcmp(str, "hello world") == 0);
}

public callback_func2(string:str[])
{
  assert(strcmp(str, "testing 1 3") == 0);
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

  new String:buffer[] = "HELLO WORLD";
  test_callback1(callback_func1, buffer, sizeof(buffer));
  test_callback2(callback_func2, buffer, sizeof(buffer));

  test_end(10);
}
