//$(document).ready(funtion(){

//    $("#btnGetAllHouses").click(function() {
//        var strURL = "https://localhost:44388/WebAPI/Service/House/GetAllHouses";

//        $.ajax({
//            type: "GET",
//            url: strURL,
//            dataType: "json",
//            success: function (data) {
//                $("#MainPage").text(data);
//            },
//            error: function (req, status, error) {
//                alert("Error: " + req.responseText + " | " + status + " | " + error);
//            }

//        });
//    });
//});


//$(document).ready(function () {

//    $("#btnGetAllHouses").click(function () {
//        var strURL = "https://localhost:44388/WebAPI/Service/House/GetAllHouses";    // URL of the Web Service followed by the name of the Web Method

//        // Make an AJAX request and display the response in the appropriate div.
//        $.ajax({
//            type: "GET",
//            url: strURL,
//            dataType: "json",                               // set the data type expected from the Web API's response.                                 
//            success: function (data) {                      // set callback function used to update the page.
//                $("#MainPage").text(data);                  // JQuery passes the object returned by the Web API to your callback function.
//            },
//            error: function (req, status, error) {          // sets the error callback function used when an error occurs.
//                alert("Error: " + req.responseText + " | " + status + " | " + error);
//            }

//        }); //end of ajax method
//    }); // end of click event
//}); // end of ready method