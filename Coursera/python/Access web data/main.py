# #1
# import re
# total=0
# fh=open("txt2.txt")
# lines=fh.readlines()
# for line in lines:
#     res=re.findall('[0-9]+',line)
#     for stnom in res:
#         total +=int(stnom)

# print(total)


#2
# import socket

# mysock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
# mysock.connect(('data.pr4e.org', 80))
# cmd = 'GET http://data.pr4e.org/intro-short.txt\n\n'.encode()
# mysock.send(cmd)
# while True:
#     data = mysock.recv(1024)
#     if len(data) < 1:
#         break
#     print(data.decode(),end='')

# mysock.close()

#3
# import urllib.request,urllib.parse,urllib.error
# from bs4 import BeautifulSoup
# total=0
# url=input("enter")
# fh=urllib.request.urlopen(url).read()
# soup=BeautifulSoup(fh,'html.parser')
# tags=soup('span')
# for tag in tags:
#     total+= int(tag.contents[0])

# print(total)


#4
#import urllib.request,urllib.parse,urllib.error
#from bs4 import BeautifulSoup
#url=input("Enter URL")
#fh=urllib.request.urlopen(url).read()
#soup=BeautifulSoup(fh,'html.parser')
#tags=soup('a')
#for tag in tags:
#   print(tag.get('herf',None)) 
#
#

#5
#import urllib.request, urllib.parse, urllib.error
#from bs4 import BeautifulSoup
#u = input('Enter - ')
#count = int(input("Enter count: "))
#position = int(input("Enter position: "))
#for i in range(0,count):
#   html = urllib.request.urlopen(u).read()
#   soup = BeautifulSoup(html, 'html.parser')
#   tags= soup('a')
#   u=tags[position-1].get('href', None)
#print(soup('a')[position-1].contents[0])

#6

#import urllib.request, urllib.parse, urllib.error
#import xml.etree.ElementTree as ET
#url = input('Enter location: ')
#print('Retrieving', url)
#data = urllib.request.urlopen(url).read()
#print('Retrieved', len(data), 'characters')
#tree = ET.fromstring(data)
#counts = tree.findall('.//count')
#counts = [int(item.text) for item in counts]
#print(f'Count: {len(counts)}')
#print(f'Sum: {sum(counts)}')


#7
#import json
#from urllib.request import urlopen
#url = input('Enter location: ')
#print(f'Retrieving {url}')
#data = urlopen(url).read()
#print(f'Retrieved {len(data)} characters')
#js = json.loads(data.decode())
#counts = [ ]
#for comment in js['comments']:
#   counts.append(comment['count'])
#print('Count:', len(counts))
#print('Sum:', sum(counts))


#8
#from urllib.request import urlopen
#from urllib.parse import urlencode
#import json
#
#url = 'http://py4e-data.dr-chuck.net/json?'
#address =  input('Enter location: ')
#parms = {'address':address, 'key':42}
#url += urlencode(parms)
#print(f'Retrieving {url}')
#data = urlopen(url).read().decode()
#js = json.loads(data)
#print(f'Retrieved {len(data)} characters')
#print('Place id', js['results'][0]['place_id'])

