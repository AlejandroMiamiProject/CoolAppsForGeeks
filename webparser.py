import bs4 as bs
import urllib.request

urls = [line.rstrip('\n') for line in open("websites.txt")]

tags = [line.rstrip('\n') for line in open("tags.txt")]

for url in urls:
   try:
       source = urllib.request.urlopen(url).read()
       soup = bs.BeautifulSoup(source, 'lxml')

       print("Title: " + soup.title.get_text() + " url ||" + url)

       for tag in tags:
           for paragraph in soup.find_all(tag):
               print(paragraph.get_text())

   except:
       pass
