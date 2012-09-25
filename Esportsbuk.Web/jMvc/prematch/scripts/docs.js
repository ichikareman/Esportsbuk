//js prematch/scripts/doc.js

load('steal/rhino/rhino.js');
steal("documentjs").then(function(){
	DocumentJS('prematch/prematch.html', {
		markdown : ['prematch']
	});
});