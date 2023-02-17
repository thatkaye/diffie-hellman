# diffie-hellman

### algorithm
1. choose 2 large prime numbers - ** prime 1 & prime 2**

*_check if inputs are prime numbers_*
```
            int x = 0;
            bool isnum = int.TryParse(num, out x);

            if (!isnum)
                return false;
            else
            {
                int i;

                for (i = 2; i < int.Parse(num); i++)
                {
                    if (int.Parse(num) % i == 0)
                        return false;
                }

                return true;
            }
```

2. choose another number for prime 1 -- **secret 1**

*_check if inputs are numbers_*
```
            int x = 0;
            bool isnum = int.TryParse(num, out x);

            if (!isnum)
                return false;
            else
                return true;
```

3. generate key 1 ```key1 = prime2^(secret1) mod prime1```
*_generating the key makes use of this formula_*
```
            if (b == 1)
                return a;
            else
                return (((long)Math.Pow(a, b)) % P);
```

```
key1 = diffie(int.Parse(prime2tb.Text), int.Parse(secret1tb.Text), int.Parse(prime1tb.Text));
```

4. choose another number for prime 2 -- **secret 2**
5. generate key 1 ```key2 = prime2^(secret2) mod prime1```
```
key2 = diffie(int.Parse(prime2tb.Text), int.Parse(secret2tb.Text), int.Parse(prime1tb.Text));
```

6. generate another key for the generated keys which will be labeled as **secret key**
- secretkey1 = key2^(secret1) mod prime1
```
secretkey1 = diffie(key2, int.Parse(secret1tb.Text), int.Parse(prime1tb.Text));
```

- secretkey2 = key1^(secre2) mod prime1
```
secretkey2 = diffie(key1, int.Parse(secret2tb.Text), int.Parse(prime1tb.Text));
```
7. key exchange is complete

### sample test
![image](https://user-images.githubusercontent.com/52037251/219642084-6b441952-f2b7-46e1-af3c-c533e39eb2d9.png)
