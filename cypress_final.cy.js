describe('PokerGame_DoblePareja', () => {
    it('Doble Pareja Test',()=>{
        cy.visit(Cypress.env("base_url"));
        cy.get('#CA1_1').type('1'),
        cy.get('#CA1_2').type('CORAZON'),
        cy.get('#CA2_1').type('12'),
        cy.get('#CA2_2').type('COCO'),
        cy.get('#CA3_1').type('5'),
        cy.get('#CA3_2').type('ESPADA'),
        cy.get('#CA4_1').type('12'),
        cy.get('#CA4_2').type('ESPADA'),
        cy.get('#CA5_1').type('5'),
        cy.get('#CA5_2').type('CORAZON'),
        cy.get('#Botoncito').click()
        cy.get('#JuegoRes').should('have.text', 'Jugada: DOBLE PAREJA')       
    })
});

describe('PokerGame_EscaleraReal', () => {
    it('Escalera Real Test',()=>{
        cy.visit(Cypress.env("base_url"));
        cy.get('#CA1_1').type('13'),
        cy.get('#CA1_2').type('ESPADA'),
        cy.get('#CA2_1').type('12'),
        cy.get('#CA2_2').type('ESPADA'),
        cy.get('#CA3_1').type('11'),
        cy.get('#CA3_2').type('ESPADA'),
        cy.get('#CA4_1').type('10'),
        cy.get('#CA4_2').type('ESPADA'),
        cy.get('#CA5_1').type('1'),
        cy.get('#CA5_2').type('ESPADA'),
        cy.get('#Botoncito').click()
        cy.get('#JuegoRes').should('have.text', 'Jugada: ESCALERA REAL')       
    })
});

describe('PokerGame_Poker', () => {
    it('Poker Test',()=>{
        cy.visit(Cypress.env("base_url"));
        cy.get('#CA1_1').type('7'),
        cy.get('#CA1_2').type('ESPADA'),
        cy.get('#CA2_1').type('7'),
        cy.get('#CA2_2').type('CORAZON'),
        cy.get('#CA3_1').type('7'),
        cy.get('#CA3_2').type('COCO'),
        cy.get('#CA4_1').type('7'),
        cy.get('#CA4_2').type('TREBOL'),
        cy.get('#CA5_1').type('13'),
        cy.get('#CA5_2').type('ESPADA'),
        cy.get('#Botoncito').click()
        cy.get('#JuegoRes').should('have.text', 'Jugada: POKER')       
    })
});

describe('PokerGame_Full', () => {
    it('Full Test',()=>{
        cy.visit(Cypress.env("base_url"));
        cy.get('#CA1_1').type('7'),
        cy.get('#CA1_2').type('ESPADA'),
        cy.get('#CA2_1').type('7'),
        cy.get('#CA2_2').type('COCO'),
        cy.get('#CA3_1').type('7'),
        cy.get('#CA3_2').type('TREBOL'),
        cy.get('#CA4_1').type('13'),
        cy.get('#CA4_2').type('TREBOL'),
        cy.get('#CA5_1').type('13'),
        cy.get('#CA5_2').type('ESPADA'),
        cy.get('#Botoncito').click()
        cy.get('#JuegoRes').should('have.text', 'Jugada: FULL')       
    })
});

describe('PokerGame_CartaMayor', () => {
    it('Carta Mayor Test',()=>{
        cy.visit(Cypress.env("base_url"));
        cy.get('#CA1_1').type('7'),
        cy.get('#CA1_2').type('ESPADA'),
        cy.get('#CA2_1').type('2'),
        cy.get('#CA2_2').type('CORAZON'),
        cy.get('#CA3_1').type('8'),
        cy.get('#CA3_2').type('CORAZON'),
        cy.get('#CA4_1').type('1'),
        cy.get('#CA4_2').type('TREBOL'),
        cy.get('#CA5_1').type('13'),
        cy.get('#CA5_2').type('COCO'),
        cy.get('#Botoncito').click()
        cy.get('#JuegoRes').should('have.text', 'Jugada: CARTA MAYOR')       
    })
});