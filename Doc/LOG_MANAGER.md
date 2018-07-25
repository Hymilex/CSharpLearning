# 日志管理插件介绍



## Log4Net

### 使用方式

​	对Log4net的使用方式分为两步来操作:

​	1.根据开发框架的版本，在

[Log4Net官网]: http://logging.apache.org/log4net/log4net-2.0.8/release/sdk/	"Log4Net"

对源码进行下载。

​	2.根据源码用Visual Studio打开后，选择目标框架和对应的生成路径（在项目属性中进行设置）。

​	3.将编译的生成的Dll引入你要编写的项目中。

​	4.对XML规则进行编写。

​	5.对XML进行解析。

​	6.构造Helper类对不同状态下的日志进行方法重写。

​	7.根据实际情况对Helper类下的静态方法进行调用。

## 参考

### 官网文档

- Log4Net官网 http://logging.apache.org/log4net/log4net-2.0.8/release/sdk/ 

### 博客

- 多文档生成方式 https://blog.csdn.net/jhydn/article/details/54963023

