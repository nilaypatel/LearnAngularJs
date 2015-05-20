var expect = chai.expect;

describe('calculator', function () {

    var calculator;

    beforeEach(function() {
        calculator = new Calculator();
    });

    it('adds', function () {
        expect(calculator.add(1,1)).to.equal(2);
    });
});