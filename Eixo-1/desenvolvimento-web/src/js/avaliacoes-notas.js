var avaliacoes = ["PROVA 1", "PROVA 2", "TRABALHO FINAL"]
var cont = 0;

var notaAluno= [35, 20, 0.3];
var somaAluno = 0;

for (let x = 0; x < avaliacoes.length; x++) {
    console.log(`A nota para a ${avaliacoes[x]} foi ${notaAluno[x]}`);
    //soma = soma + notaAluno[x];
    somaAluno += notaAluno[x];
}

if (somaAluno >= 60) {
    console.log (`Aluno APROVADO! Nota final foi de ${somaAluno}`);
}
else {
    console.log (`Aluno REPROVADO! Nota final foi de ${somaAluno}`);
}

