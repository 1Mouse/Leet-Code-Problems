class Solution:
    def numberOfMatches(self, n: int) -> int:
        """
        There are n teams. Each match results in the elimination of
        one team. After n - 1 matches, there is one team left standing;
        it becomes the winner.
	    """
        return n - 1
    
    
    """
    n=14 --> output=13
    n=7  --> output=6
    """