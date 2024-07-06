var form = document.getElementById('myForm');
form.addEventListener( 'submit', function(event){
    var surname = document.getElementById('surname');
    var surname_error = document.getElementById('surname_error');
    surname_error.innerHTML = '';
    var name = document.getElementById('name');
    var name_error = document.getElementById('name_error');
    name_error.innerHTML = '';
    var isOk = true;
if(surname.value.length > 20)
{
    surname_error.textContent = 'Длина имени должна быть не более 20 символов'
    isOk = false;
}
if(!(/^[a-zа-я]{1,20}$/i.test(surname.value)))
{
    surname_error.textContent += ' Используйте только русские и английские буквы';
    isOk = false;
}
if(surname.value === '')
{
    surname_error.textContent = 'Поле не должно быть пустым';
    isOk = false;
}
if(name.value.length > 20)
{
    name_error.textContent = 'Длина имени должна быть не более 20 символов'
    isOk = false;
}
if(!(/^[a-zа-я]{1,20}$/i.test(name.value)))
{
    name_error.textContent += ' Используйте только русские и английские буквы';
    isOk = false;
}
if(name.value === '')
{
    name_error.textContent = 'Поле не должно быть пустым';
    isOk = false;
}
var email = document.getElementById('email');
var email_error = document.getElementById('email_error');
email_error.innerHTML = '';
if(!(/^[^\s@]+@[a-z]{2,5}\.[a-z]{2,3}$/i.test(email.value)))
{
    email_error.textContent = "Неверный формат";
    isOk = false;
}
var number = document.getElementById('number');
var number_error = document.getElementById('number_error');
number_error.innerHTML = '';
if(!(/^\(0\d{2}\)\d{3}-\d{2}-\d{2}$/.test(number.value)))
{
    number_error.textContent = "Неверный формат номера телефона";
    isOk = false;
}
var about = document.getElementById('about');
var about_error = document.getElementById('about_error');
about_error.innerHTML = '';
if(about.value.length > 250)
{
    about_error.textContent = "Размер поля не должен превышать 250 символов"
    isOk = false;
}
if(about.value === '')
{
    about_error.textContent = 'Поле не должно быть пустым';
    isOk = false;
}
var town = document.getElementById('minsk');
var bstu_checkbox = document.getElementById('bstu');
var course3_radio = document.getElementById('course3');
if(!isOk)
{
    event.preventDefault();
}
if(!(town.selected && bstu_checkbox.checked && course3_radio.checked))
{
    var confirmed = confirm('Вы уверены в своем ответе?')
    if(!confirmed)
    {
        event.preventDefault();
    }
}
});