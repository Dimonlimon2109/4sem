const caps = document.querySelectorAll('.cap');
const ball = document.getElementById('ball');
const correct = document.getElementById('correct');
const incorrect = document.getElementById('incorrect');
const resultField = document.getElementById('result');
const refresh = document.getElementById('refresh');
let positionBall;
let score = 0;

resultField.value = 0;

function save(){
    changeBall();
    changeCap();
    return false;
}

function changeBall() {
    let diameter = document.getElementById('diameter').value;
    ball.style.width = diameter + 'px';
    ball.style.height = diameter + 'px';
}

function changeCap() {
    let heightCap = document.getElementById('heightN').value;
    let widthCap = document.getElementById('widthN').value;
    for( i = 0; i < 3; i ++){
        caps[i].style.width = widthCap + 'px';
        caps[i].style.height = heightCap + 'px';
    }
}

refresh.addEventListener('click', function (event) {
    score = 0;
    resultField.value = 0;
})

caps.forEach(cap => {
    cap.addEventListener('click', function(event) {
        caps[positionBall].appendChild(ball);
        this.querySelector('img').style.transform = `translatey(${parseInt(ball.offsetWidth)*(-1) -10 + 'px'})`;
        if(this == caps[positionBall]){
            correct.style.opacity = 1;
            score ++;
        }
        else{
            score --;
            incorrect.style.opacity = 1;
        }
        resultField.value = score;
        caps.forEach(element => {
            element.style.pointerEvents = "none";
        })
        setTimeout(reset, 2000);
    });
});

function reset(){
    correct.style.opacity = 0;
    incorrect.style.opacity = 0;
    caps.forEach(element => {
        element.style.pointerEvents = "auto";
    })
    changePos();
}

function changePos(){
    for(i = 0; i < 3; i ++)
        caps[i].querySelector('img').style.transform = '';
    positionBall = Math.floor(Math.random() * 3);
}

changePos();