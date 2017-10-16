package main
import "fmt"

func main() {
	var fibbase []int
	fibbase = append(fibbase, 1)
	fibbase = append(fibbase, 2)
	for fibbase[len(fibbase) - 1] < 4000000 {
		fibbase = append(
			fibbase, 
			fibbase[len(fibbase) - 1] + fibbase[len(fibbase) - 2])
	}

	fibbase = fibbase[0:len(fibbase) - 1]

	sum := 0

	for _, element := range fibbase {
		if(element % 2 == 0) {
			sum += element
		}
	}

	fmt.Println(sum)
}
