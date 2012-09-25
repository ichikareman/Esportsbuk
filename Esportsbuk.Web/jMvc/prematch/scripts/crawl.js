// load('prematch/scripts/crawl.js')

load('steal/rhino/rhino.js')

steal('steal/html/crawl', function(){
  steal.html.crawl("prematch/prematch.html","prematch/out")
});
