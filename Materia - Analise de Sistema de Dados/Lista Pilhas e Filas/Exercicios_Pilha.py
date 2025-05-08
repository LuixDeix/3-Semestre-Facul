def inverter_string(texto):
    pilha = []
    for char in texto:
        pilha.append(char)
    invertida = ""
    while pilha:
        invertida += pilha.pop()

    return invertida

print(inverter_string("Python"))

#-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

def verifica_balanceamento(expressao):
    pilha = []
    aberturas = "({["
    fechamentos = ")}]"

    for char in expressao:
        if char in aberturas:
            pilha.append(char)
        elif char in fechamentos:
            if not pilha:
                return False
            topo = pilha.pop()
            if aberturas.index(topo) != fechamentos.index(char):
                return False
    return len(pilha) == 0

print(verifica_balanceamento("{[()]}"))
print(verifica_balanceamento("{[(])}")) 

#-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

def Decimal_Para_Binario(num):
    if num == 0:
        return "0"

    pilha = [] 

    while num > 0:
        resto = num % 2
        pilha.append(str(resto))
        num = num // 2

    return ''.join(reversed(pilha)) 

#-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
class EditorTexto:
    
    def _init_(self):
        self.texto = ""
        self.pilha_undo = []

    def adicionar_texto(self, novo_texto):
        self.pilha_undo.append(self.texto)
        self.texto += novo_texto
        print(f'Texto atual: "{self.texto}"')

    def desfazer(self):
        if self.pilha_undo:
            self.texto = self.pilha_undo.pop()
            print(f'Desfeito! Texto atual: "{self.texto}"')
        else:
            print("Nada para desfazer.")

    def mostrar_texto(self):
        print(f'Texto atual: "{self.texto}"')

editor = EditorTexto()
editor.adicionar_texto("Olá")
editor.adicionar_texto(" mundo")
editor.desfazer()  
editor.desfazer()  
editor.desfazer()
#-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

class Pos_fixa:
    def _init_(self):
        self.pilha = []

    def avaliar_posfixa(self, expressao):
        tokens = expressao.split()

        for token in tokens:
            try:
                
                numero = float(token)
                self.pilha.append(numero)
            except ValueError:
        
                if len(self.pilha) < 2:
                    print("Erro: pilha não tem operandos suficientes.")
                    return None

                b = self.pilha.pop()
                a = self.pilha.pop()

                if token == '+':
                    resultado = a + b
                elif token == '-':
                    resultado = a - b
                elif token == '*' or token == 'x':
                    resultado = a * b
                elif token == '/':
                    if b == 0:
                        print("Erro: divisão por zero.")
                        return None
                    resultado = a / b
                else:
                    print(f"Erro: operador desconhecido '{token}'")
                    return None

                self.pilha.append(resultado)

        if len(self.pilha) != 1:
            print("Erro: expressão malformada.")
            return None

        return self.pilha.pop()

calc = Pos_fixa()
print(calc.avaliar_posfixa("2 3 +"))
print(calc.avaliar_posfixa("5 1 2 + 4 * + 3 -")) 
print(calc.avaliar_posfixa("2.5 2 *"))
print(calc.avaliar_posfixa("2.3 +"))  