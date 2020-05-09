# MinecraftOnlinepush
**通过微信推送玩家上线提醒的python脚本~~方便狙击(bushi)~~**  

这个程序使用了C#编写的[MinecraftOutClient](https://github.com/Nsiso/MinecraftOutClient)作为检测在线玩家的部分，我修改了TestClient的部分代码，让python可以和TestClient交互（方便自定义服务器地址）  
不重复造轮子(X)~~其实是不会C#~~，也看不懂[Protocol文档](http://wiki.vg/Protocol)

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