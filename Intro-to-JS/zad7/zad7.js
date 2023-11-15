let user = document.getElementById('username');
let email = document.getElementById('email');
let password = document.getElementById('password');
let button = document.getElementById('click');


button.addEventListener('click', (e) => {
    e.preventDefault()

    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    const passRegex = /[A-z]+[0-9]+/gm;

    const userRegex = /[A-Z][a-z]+[0-9]?/gm;


    if (userRegex.test(user.value)) {
        window.alert('Потребителското име е валидно');
    } else {
        window.alert('Потребителското име не е валидно');

    }
    if (emailRegex.test(email.value)) {
        window.alert('Имейлът е валиден');
    } else {
        window.alert('Имейлът не е валиден');

    }

    if(passRegex.test(password.value)){
        window.alert('Паролата e валидна');

    }else{
        window.alert('Паролата не е валидна');
    }

  
})
