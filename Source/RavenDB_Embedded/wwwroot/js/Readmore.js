$(document).ready(function () {
    document.body.oncopy = function () {
        var body_element = document.getElementsByTagName('body')[0];
        var selection;
        selection = window.getSelection();
        var pagelink = "<br />Read more at: <a href='" + document.location.href + "'>" + document.location.href + "</a><br />";
        var copytext = selection + pagelink;
        var newdiv = document.createElement('div');
        body_element.appendChild(newdiv);
        newdiv.innerHTML = copytext;
        selection.selectAllChildren(newdiv);
        window.setTimeout(function () {
            body_element.removeChild(newdiv);
        }, 0);
    };
});