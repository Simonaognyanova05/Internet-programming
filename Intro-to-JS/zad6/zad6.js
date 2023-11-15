let buttonClick = document.getElementById('clicked');
buttonClick.addEventListener('click', (e)=>{
    e.preventDefault();
    window.alert('сигурни ли сте че искате да затворите страницата')
})