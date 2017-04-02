const Calculator = require('../models/Calculator');

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    } ,
    indexPost: (req, res) => {
        let calculatorBody = req.body;

        let calculaorParams = calculatorBody['calculator'];

        let calculator = new Calculator();

        calculator.leftOperand = Number(calculaorParams.leftOperand);
        calculator.operator = calculaorParams.operator;
        calculator.rightOperand = Number(calculaorParams.rightOperand);

        let result = calculator.calculateResult();

        res.render('home/index', {'calculator': calculator, 'result': result});
    }
};