type entry struct {
	val int
	min int
}

type MinStack struct {
	stack []entry
}

func Constructor() MinStack {
	return MinStack{}
}

func (s *MinStack) Push(value int) {
	m := value
	if !s.IsEmpty() {
		m = min(value, s.GetMin())
	}
	s.stack = append(s.stack, entry{val: value, min: m})
}

func (s *MinStack) Pop() {
	s.stack = s.stack[:len(s.stack)-1]
}

func (s *MinStack) Top() int {
	return s.stack[len(s.stack)-1].val
}

func (s *MinStack) GetMin() int {
	return s.stack[len(s.stack)-1].min
}

func (s *MinStack) IsEmpty() bool {
	return len(s.stack) == 0
}

/**
 * Your MinStack object will be instantiated and called as such:
 * obj := Constructor();
 * obj.Push(value);
 * obj.Pop();
 * param_3 := obj.Top();
 * param_4 := obj.GetMin();
 */
