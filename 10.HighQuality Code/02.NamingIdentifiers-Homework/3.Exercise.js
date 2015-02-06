function checkIsMozilla() {
  var curentWindow = window;
  var currentBrowserName = currentWindow.navigator.appCodeName;
  var isMozilla = (currentBrowserName == "Mozilla");
	if(isMozilla) {
		alert("Yes"); 
	} else {
		alert("No");  
	}
}