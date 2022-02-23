package main
import "fmt"

// Stack 
type Stack struct {
    stack []string 
    size int
}

// Push for Stack
func (s *Stack) Push(item string){
    s.stack = append(s.stack, item)
    s.size++
} 

// Pop for Stack
func (s *Stack) Pop() string {
    length := len(s.stack) - 1
    
    toRemove := s.stack[len(s.stack) - 1]
    s.stack = s.stack[:length]
    
    s.size--
    return toRemove
}

// Size of Stack
func (stack *Stack) Len() int {
  return stack.size
}

func InData() {
  
  fmt.Println("First string --> (){}([])") // valid
  firstString := "(){}([])"
  fmt.Println(Algoritm(firstString))
  
  fmt.Println("Second string --> ([()])((") // invalid
  secondString := "([()])(("
  fmt.Println(Algoritm(secondString))
  
  fmt.Println("Third string --> ()){}") // invalid
  thirdString := "()){}"
  fmt.Println(Algoritm(thirdString))
  
  fmt.Println("Fourth string --> ([{}])") // valid
  fourthString := "([{}])"
  fmt.Println(Algoritm(fourthString))
  
  fmt.Println("Fourth string --> (({))}") // invalid
  fifthString := "(({))}"
  fmt.Println(Algoritm(fifthString))
  
}

func Algoritm(brackets string) bool {
    
  fmt.Println("This string with brackets is valid? (true - yes,  false - no)")
  
  counter := 0
  stack := Stack{}
  bracketsKey := map[string]string{
            ")": "(",
            "}": "{",
            "]": "[",
    }

  
  for i:=1; i<len(brackets)+1; i++ {
      
      chareckter := brackets[i-1:i]
      
      if isClosedBracket(chareckter) {
          
          if stack.Len() != 0 {
              
              if bracketsKey[chareckter] != stack.Pop()  {
                  counter++
                  return false
              }
              
          } else {
            return false
          }
          
      } else {
          stack.Push(chareckter)
      }
  }
  
  if stack.Len() == 0 {
      return true
  } 
  
  return false
}

func isClosedBracket(item string) bool {
    
    if (item == ")") || (item == "}") || (item == "]"){
        return true
    }
    
    return false
}


func main() {
    InData()
}
