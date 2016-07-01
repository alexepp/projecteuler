problem1 n = foldl (\x y -> x + y) 0 [x | x <- [1..n-1], x `mod` 3 == 0 || x `mod` 5 == 0]

main :: IO()
main = putStrLn (show (problem1 1000))