from collections import deque

class Banco:
    def __init__(coisa_linda):
        coisa_linda.clientes = deque()

    def novo_cliente(coisa_linda, nome):
        coisa_linda.clientes.append(nome)
        print(f"{nome} entrou na fila do banco.")

    def atender(coisa_linda):
        if len(coisa_linda.clientes) > 0:
            nome = coisa_linda.clientes.popleft()
            print(f"{nome} foi atendido.")
        else:
            print("Nenhum cliente para atender.")

    def mostrar_fila(coisa_linda):
        if len(coisa_linda.clientes) > 0:
            print("Fila atual:")
            for i, nome in enumerate(coisa_linda.clientes, 1):
                print(f"{i} - {nome}")
        else:
            print("A fila tá vazia.")

fila = Banco()
fila.novo_cliente("Luis")
fila.novo_cliente("Anderson")

fila.mostrar_fila()
fila.atender()

#-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
from collections import deque

def palindromo(palavra):
    palavra = palavra.lower().replace(" ", "") 
    pilha = []
    fila = deque()

    for letra in palavra:
        pilha.append(letra)
        fila.append(letra)

    while pilha and fila:
        if pilha.pop() != fila.popleft():
            return False

    return True

print(palindromo("arara"))      
print(palindromo("radar"))    
print(palindromo("Python"))    
print(palindromo("Ame a ema"))
#-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

class FicaCircular:
    def __init__(Basico, limite):
        Basico.limite = limite
        Basico.fila = [None] * limite
        Basico.inicio = 0
        Basico.fim = 0
        Basico.qtd = 0

    def enfileirar(Basico, valor):
        if Basico.qtd == Basico.limite:
            print("Fila cheia.")
            return
        Basico.fila[Basico.fim] = valor
        Basico.fim = (Basico.fim + 1) % Basico.limite
        Basico.qtd += 1

    def desenfileirar(Basico):
        if Basico.qtd == 0:
            print("Fila vazia.")
            return
        valor = Basico.fila[Basico.inicio]
        Basico.fila[Basico.inicio] = None
        Basico.inicio = (Basico.inicio + 1) % Basico.limite
        Basico.qtd -= 1
        return valor

    def mostrar(Basico):
        print("Fila atual:", Basico.fila)
        print("Início:", Basico.inicio, "| Fim:", Basico.fim)

fila = FicaCircular(2)
fila.enfileirar("X")
fila.enfileirar("Y")
fila.mostrar()

fila.desenfileirar()
fila.enfileirar("Novo")

#-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

from collections import deque

fila = deque()

def adicionar_documento(nome, paginas):
    doc = {"nome": nome, "paginas": paginas}
    fila.append(doc)
    print(f"Adicionado: {doc['nome']} ({doc['paginas']} págs)")

def imprimir_documento():
    if len(fila) == 0:
        print("Nenhum documento para imprimir.")
    else:
        doc = fila.popleft()
        print(f"Imprimindo: {doc['nome']} ({doc['paginas']} págs)")

def mostrar_fila():
    if len(fila) == 0:
        print("Fila de impressão vazia.")
    else:
        print("Documentos na fila:")
        for i, doc in enumerate(fila, 1):
            print(f"{i}. {doc['nome']} - {doc['paginas']} páginas")

adicionar_documento("Resumo", 4)
adicionar_documento("Trabalho", 7)
adicionar_documento("PDF Aula", 2)
mostrar_fila()

imprimir_documento()
imprimir_documento()
mostrar_fila()

#-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

import heapq

class Prioridade:
    def __init__(self):
        self.itens = []
        self.ordem = 0

    def inserir(self, nome, prioridade):
        heapq.heappush(self.itens, (prioridade, self.ordem, nome))
        self.ordem += 1

    def tirar(self):
        if len(self.itens) == 0:
            print("Fila vazia.")
            return None
        tarefa = heapq.heappop(self.itens)
        return tarefa[2]

fila = Prioridade()
fila.inserir("Arrumar a cama", 3)
fila.inserir("Estudar para prova", 1)
fila.inserir("Lavar louça", 2)

print(fila.tirar()) 
print(fila.tirar())  
print(fila.tirar())  
