//function scrollToEnd(textarea) {
//    //textarea.scrollTop = textarea.scrollHeight;
//    alert("Sample Text")
//}

export function scrollLogToBottom() {
    logTa = document.getElementById("logTextArea")
    //logTa.scrollTop = logTa.scrollHeight;
    logTa.blur();
    logTa.focus();
}

export function showAlert(message) {
    alert(message);
}