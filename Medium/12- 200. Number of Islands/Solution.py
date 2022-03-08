class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        rows,cols=len(grid),len(grid[0])
        
        visited=set()
        islands=0
        
        def bfs(r,c):
            q=collections.deque()
            visited.add((r,c))
            q.append((r,c))
            
            while q:
                row,col=q.popleft()
                #bfs pop the fifo queue 
                #pop only dfs iterative stack lifo 
                directions=[[1,0],[-1,0],[0,1],[0,-1]]
                
                for dr,dc in directions:
                    r,c=row+dr,col+dc
                    if  (r in range(rows) and
                        c in range(cols) and
                        grid[r][c]=="1" and
                        (r,c)not in visited):
                        q.append((r,c))
                        visited.add((r,c))
        
        for r in range(rows):
            for c in range(cols):
                if grid[r][c]=="1" and (r,c) not in visited:
                    bfs(r,c)
                    islands+=1
        
        return islands
                