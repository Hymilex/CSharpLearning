## 委托和事件

### 委托

#### 委托是什么

> 委托可以理解为一个函数的包装,使C#中的函数可以当作参数来进行传递。

#### 定义方式

> 定义委托和定义方法的定义类似，只是在前面多了一个delegate关键字。

```c#
/**
* 1.方法的签名必须和委托一致，方法签名包括参数个数、类型和顺序。
* 2.方法的返回类型和委托的返回类型要一致。
*/
public delegate void MyDelegation(dataType param1,dataType param2);
```

#### 委托的使用

```c#
//1.定义委托类型
delegate void MyDelegate(int parm1, int parm2);
public void ExcDelegation()
{ 
    //2.声明委托变量
    MyDelegate md;
    //3.实例化委托变量
    md = new MyDelegate(new DelegationTest().Plus);
    //4.委托类型作为参数传给另一个方法
    MyMethod(md);
    //Console.Read();
}

//该方法的定义必须与委托定义相同
public void Plus(int a, int b)
{
    int sum = a + b;
    Console.WriteLine("{0}+{1}={2}！",a.ToString(),b.ToString(),sum.ToString());
    Console.ReadKey();
}

       
static void MyMethod(MyDelegate mdt)
{
    //5.在方法中调用委托
    mdt(1,2);
    //mdt.Invoke(1,2); 显示调用委托
}

//1.声明委托
delegate void GreetingDelegation(string lang,string name);

public void ExcLang()
{
    //2.定义委托
    GreetingDelegation gd;
    //3.实例化委托
    gd = new GreetingDelegation(new Human().Greeting);
    //4.将委托传给另一个方法
    gd("zh-cn","simon");
    //MyGreeting(gd);
}
//所谓定义的另一个方法
static void MyGreeting(GreetingDelegation GDL)
{
    GDL("en-us","black-giser");
    Console.Read();
}
}
```

#### 委托链

> 换句话说，存在A、B、C三个委托。B、C委托具体的函数方法，要同时将其串接起来的办法就是定义A是个空，然后将A+=B实例化的委托、A+=C实例化的委托。

> 如果要移除对应的委托则使用:-=来进行操作。

> 当然，在使用委托中的方法可以是静态的，不用实例化，如果是动态的就需要实例化。



### 事件

#### 事件是什么

> 存在两类角色事件的发布者和时间的订阅者。事件发布者会**发布消息**，事件订阅者会接收到事件已经发出的通知，并且做出**响应和处理**。

#### 定义事件

```c#
//订阅事件使用 +=
//取消事件订阅 -=
public event EventHandler(委托类型) Birthday(事件名)
```

#### 事件的操作步骤

>1.首先搞清楚你要委托什么玩意，被委托的函数的返回类型和参数传递的类型
>
>2.定义委托和事件:
>
>3.一个事件方法对其进行包装，将实例化后的委托对其传参操作。
>
>4.实例化事件是在订阅时触发。
>
>5.调用包装的方法即可完成事件操作。

```c# 
class BrideGroom{
    public delegate void MarryHandler(string name,...string namen);
    //使用自定义委托类型定义事件
    public event MarryHandler PgOne;
    //
    public void OnMarriage(msg)
    {
        if(PgOne!=null)
        {
            //触发事件
            PgOne(msg);
        }
    }
}
static void Main(string[] args)
{
    BrideGroom bg = new BridGroom();
    bg.PgOne+=new MarryHandler(method);
    bg.OnMarriage(params);
}
```

#### 事件还可以怎么玩

> 在实际开发流程中，使用的多为.NET已经封装好的委托。

```c#
EventHandler 是封装好的委托类型。
public event EventHandler MarryEvent;

public void OnBirthday(string msg)
{
    if(MarryEvent!=null)
    {
        Console.WriteLine("{0}",msg);
        MarryEvent(this,new EventArgs());
    }
}
```

#### 扩展原来的委托，让其更加的强大

> 自定义事件类派生原有的EventArgs，并且使其带有事件数据

```c#
public class MarryEventArgs:EventArgs
{
	public string Message;
	public  MarryEventArgs(string msg)
    {
    	Message = msg;
    }
}
//然后在调用是自定义委托声明

class BrideGroom{
    public delegate void MarryHandler(object sender,MarryEventArgs e);
    //使用自定义委托类型定义事件
    public event MarryHandler PgOne;
    //
    public void OnMarriage(msg)
    {
        if(PgOne!=null)
        {
            //触发事件
            PgOne(this,new MarryEventArgs(msg));
        }
    }
}
static void Main(string[] args)
{
    BrideGroom bg = new BridGroom();
    bg.PgOne+=new MarryHandler(method);
    bg.OnMarriage(params);
}
```

