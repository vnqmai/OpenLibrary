$(function () {
  $('#emailLink').on('click', function (event) {
    var ToEmail = 'N8Shop@gmail.com';
    var subject = ten.value;
    var FromEmail = email.value;
    var emailBody = noidung.value;
    window.location = 'mailto:' + ToEmail + '?subject=' + subject + ' ?email:'+FromEmail +'&body=' +  emailBody;
  });
});