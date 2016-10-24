
type Customer = {
    Name : string }

type Account = {
    Balance : decimal
    AccountId : System.Guid
    Owner : Customer}

let deposit amount account = 
    {account with Balance = account.Balance + amount}

let withdraw (amount:decimal) account =
    let newBalance = account.Balance - amount
    if (newBalance >= 0M) then
        {account with Balance = newBalance}
    else
        account    
