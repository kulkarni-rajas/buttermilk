i=3
f=5
print('Welcome to the Guessing Game! Do You Have What it Takes!?')
while i>=1:
    print(f"You have {i} tries remaining!")
    guess=int(input("Guess: "))
    if guess==f:
        print("You win!")
        break
    i-=1
else: #will be executed if a while loop completes itself without break
    print("Better Luck Next Time!")