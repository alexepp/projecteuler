-- from rosettacode.org
fib = 0 : 1 : zipWith (+) fib (tail fib)

problem2 n =
  sum (takeWhile (< n) [x | i <- [1..], let x = (fib !! i), even x])

main :: IO()
main =
  putStrLn (show (problem2 4000000))
