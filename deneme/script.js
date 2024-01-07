let loginButton=document.getElementById("show").addEventListener("click",showLoginPage);
let closeButton = document.getElementById("close-btn").addEventListener("click", closeLoginPage);
function showLoginPage(){
    console.log("sa")
    document.getElementById("loginScreen").style.display="block";
    
}
function closeLoginPage() {
    console.log("kapattım");  // Konsola bir mesajı kaydet ("kapattım" bu durumda)
    document.getElementById("loginScreen").style.display = "none";}  // "loginScreen" ID'li öğenin görünürlük stilini "none" olarak ayarla (görünmez hale getir)
