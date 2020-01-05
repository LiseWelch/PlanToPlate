"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/recipes/add/item").build();

//Disable send button until connection is established
document.getElementById("AddItem").disabled = true;

connection.on("PrintItem", function (message, itemID) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var item = document.createElement("li");
    item.textContent = encodedMsg;
    item.setAttribute("class", "item");
    item.setAttribute("id", itemID);
    document.getElementById("ItemList").appendChild(item);
});

connection.on("DeleteItem", function (itemID) {
    var del = document.getElementById(itemID)
    document.getElementById("ItemList").removeChild(del);
});


connection.start().then(function(){
    document.getElementById("AddItem").disabled = false;
    connection.invoke('getConnectionId')
                .then(function (connectionId) {
                    sessionStorage.setItem('conectionId', connectionId);
                    // Send the connectionId to controller
                }).catch(err => console.error(err.toString()));;
 
}).catch(function (err) {
    return console.error(err.toString());
});

$('.item').click(function(){
        var itemID = this.id;
        var user = sessionStorage.getItem('conectionId');
        connection.invoke("HubDeleteItem", itemID, user).catch(function (err) {
            return console.error(err.toString());
        });
    event.preventDefault();
});

document.getElementById("AddItem").addEventListener("click", function (event) {
    var name = document.getElementById("ItemName").value;
    var amountNum = document.getElementById("AmountNum").value;
    var amountString = document.getElementById("AmountString").value;
    var createdAt = document.getElementById("createdAt").value;
    var user = sessionStorage.getItem('conectionId');
    connection.invoke("AddItem", name, amountNum, amountString, user, createdAt).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

$('.item').hover(
    function(){
        $(this).append($("<span><i> (Click to Delete) </i></span>"));
    }, function () {
        $(this).find("span").last().remove();
    }
);

async function start() {
    try {
        await connection.start();
        console.log("connected");
    } catch (err) {
        console.log(err);
        setTimeout(() => start(), 5000);
    }
};

connection.onclose(async () => {
    await start();
});