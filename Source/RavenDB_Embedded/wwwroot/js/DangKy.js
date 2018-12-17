$(function () {
  $('#Getemail').on('click', function (event) {
    var ToEmail = 'N8Shop@gmail.com';
    var emailBody = dcemail.value;
    var string;
    window.location = 'mailto:' + ToEmail + '&body=' +  emailBody;
  });
});