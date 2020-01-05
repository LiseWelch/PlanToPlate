"use strict";
// var connection = new signalR.HubConnectionBuilder().withUrl("/recipes/add/item").build();

//Disable send button until connection is established
document.getElementById("AddBRecipe").disabled = true;


connection.on("PrintRecipe", function (message, itemID) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = msg;
    var recipe = document.createElement("a");
    recipe.textContent = encodedMsg;
    recipe.setAttribute("class", "recipe B-r");
    recipe.setAttribute("id", itemID);
    var ref = "/recipes/" + itemID;
    recipe.setAttribute("href", ref)
    document.getElementById("bRecipes").appendChild(item);
});


connection.on("DeleteBRecipe", function (itemID) {
    var del = document.getElementById(itemID)
    document.getElementById("bRecipes").removeChild(del);
});


connection.start().then(function () {
    document.getElementById("AddBRecipe").disabled = false;
    connection.invoke('getConnectionId')
        .then(function (connectionId) {
            sessionStorage.setItem('conectionId', connectionId);
            // Send the connectionId to controller
        }).catch(err => console.error(err.toString()));;

}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("AddBRecipe").addEventListener("click", function (event) {
    var recipeID = document.getElementById("breakfast").value;
    var user = sessionStorage.getItem('conectionId');
    var dayID = document.getElementById("dayid").value;
    connection.invoke("AddRecipe", recipeID, user, dayID).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});


$('.recipe').hover(
    function () {
        $(this).append($("<span><i> (Double click to Delete) </i></span>"));
    }, function () {
        $(this).find("span").last().remove();
    }
);

$('.B-r').dblclick(function () {
    var itemID = this.id;
    var user = sessionStorage.getItem('conectionId');
    connection.invoke("HubDeleteBRecipe", itemID, user).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});

$('#AddBRecipe').hover(function () {
    $(this).fadeOut(100);
    $(this).fadeIn(500);
});

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