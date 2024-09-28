:- dynamic pos/2.
:- dynamic passageiro/1.
:- dynamic transporte/1.

pos(aviao, aeroporto).

embarcar(Passageiro) :-
    pos(aviao, Local),
    assertz(passageiro(Passageiro)),
    format('Embarcando ~w no avi�o em ~w', [Passageiro, Local]), nl.

desembarcar(Passageiro) :-
    pos(aviao, Local),
    retract(passageiro(Passageiro)),
    format('Desembarcando ~w do avi�o em ~w', [Passageiro, Local]), nl.

transporte(LD) :-
    retract(pos(aviao, LO)),
    asserta(pos(aviao, LD)),
    format('Transporte de ~w para ~w', [LO, LD]), nl.

carrega_banco :-
    exists_file('aviao.bd'), consult('aviao.bd').

salva_banco :-
    tell('aviao.bd'),
    listing(pos),
    listing(passageiro),
    told.

