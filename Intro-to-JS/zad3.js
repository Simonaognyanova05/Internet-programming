let success = 5.60;
let stipendiq;

if (success >= 5.50) {
    stipendiq = 50;
    console.log(`Стипендията на ученика е ${stipendiq} лв`);

} else if (success >= 4.50 && success < 5.50) {
    let dohod = 700;
    let chlenove = 4;

    let dohodNaChlen = dohod / chlenove;

    if (dohodNaChlen <= 650) {
        stipendiq = 32;

        console.log('Стипендията на ученика е 32 лв');

    } else {
        console.log('Ученикът не получава стипендия');
    }
} else {
    console.log('Ученикът не получава стипендия');
}

let zaShestMeseca = stipendiq * 6;
console.log(`Сипендията за 6 месеца е ${zaShestMeseca} лв`);