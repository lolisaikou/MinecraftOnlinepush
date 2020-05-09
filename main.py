import os
import subprocess
import requests
from time import sleep

x = 0
### 你需要填写的地方
SCKEY = ''  # 微信推送需要到server酱申请SCKEY：http://sc.ftqq.com/,申请完成后填入这里
serviveip = ''  # 设置需要监控的服务器, 不要把冒号和后面的数字放在这里
serviceprot = ''  # 设置端口, 默认25565, 不要冒号只需要数字
player = ''  # 设置需要检测并推送的玩家
###在引号内输入,如player = 'Zi_Min' 
exe = os.path.dirname(os.path.abspath(__file__)) + '\TestClient.exe'
service = open("service.txt", "w")  # 将服务器地址写入文件供程序调用
service.writelines(serviveip+'\n'+serviceprot)
service.close()
while 1 == 1:
    x = x+1
    print(x)
    print('5分钟后启动')
    print('')
    sleep(300)  # 5分钟启动一次
    subprocess(exe)
    sleep(3)  # 设置延迟
    txt = open('Output.txt', 'r', encoding='utf8')  # 读取程序输出代码
    for line in txt.readlines():
        line = line.strip()
    txt.close()
    while ('\u4e00' <= line <= '\u9fa5'):  # 错误判断
        print(line)
        requests.get(
            'https://sc.ftqq.com/'+str(SCKEY)+'.send?text=出错了！'+str(line))  # 错误推送
        break
    else:
        txt2 = open('Output.txt', 'r')
        lines = txt2.readlines()
        for lines in lines:  # 如果玩家在线，推送信息
            if player in lines:
                print(lines, end='')
                requests.get(
                    'https://sc.ftqq.com/'+str(SCKEY)+'.send?text=' + str(player)+'上线了~')  # 微信推送
        txt2.close()
