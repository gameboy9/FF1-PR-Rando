{pair(I,L) : location(L)} = 1 :- item(I).
{pair(I,L) : item(I)} = 1 :- location(L).

has(I) :- pair(I,L), open(L).

notHas(I) :- item(I), not has(I).

:- item(I), notHas(I).

#show notHas/1.
#show pair/2.

% The bottle is _really_ hard, so leave it vanilla for now.
pair(bottle,caravan).
pair(canoe,lukahn).
pair(airship,desert).
pair(promotion,bahamut).
