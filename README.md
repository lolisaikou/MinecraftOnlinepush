# MinecraftOnlinepush
**通过微信推送玩家上线提醒的python脚本~~方便狙击(bushi)~~**  

此程序使用了[Nsiso](https://github.com/Nsiso)大佬用C#编写的[MinecraftOutClient](https://github.com/Nsiso/MinecraftOutClient)作为检测检测玩家列表的部分  
我修改了MinecraftOutClient中的示例程序TestClient源码，让python可以和TestClient交互  
python部分会把服务器地址写入文件供C#读取，C#部分会把玩家列表输出供python读取   
不重复造轮子(X)~~其实是不会C#~~，也看不懂[Minecradt Protocol文档](http://wiki.vg/Protocol)  
自学了一周python，写了第一个程序，是个没有碰过编程的小白，如有错误望大佬指点！  
微信推送由[Server酱](http://sc.ftqq.com/)实现，使用前要先申请SCKEY哦！
***
### 使用前注意  
程序每5分钟检测一次服务器玩家列表(可自行定义sleep函数里的数字，单位为秒)  
玩家名字可以为中文（未确认）  
检测到需要提醒的玩家在线或服务器中没有玩家增加五分钟等待时间  
同时只能检测一个玩家(暂时~~不一定会做~~)  
检测玩家的变量不能设为空白(已在脚本中添加提醒,如果为空提示并退出)  
请自行确认服务器地址正确，程序不会报服务器地址错误（其他错误可正常抛出）

***

> 直接使用的方法  
> 1. 到[这里](https://github.com/lolisaikou/MinecraftOnlinepush/releases/)下载我编译好的程序  
> 2. 申请微信推送需要的SCKEY，在[这里](http://sc.ftqq.com/)申请  
> 3. 用你喜欢的编辑器打开main.py把SCKEY、需要监控的服务器地址、端口、玩家id填入相应位置
> 4. 运行main.py就行了  

***

> 自行编译  
> 1. 编译TestClient  
> 2. 然后按照把main.py放在TestClient.exe放在一起  
> 3. 打开main.py把SCKEY、需要监控的服务器地址、端口、玩家id填入相应位置  
> 4. 运行main.py  
***
因为玩家检测的部分是C#写的，所以不能再放在linux服务器上运行，希望有大佬可以用可移植的语言写一个出来  
最后求一个star~
> ### 第一次更新 
> * 检测到玩家在线或服务器无玩家后减缓推送的频率
> * 修改TestClient为Windows应用程序，启动时不会弹出黑框了
> * 修正严重错误