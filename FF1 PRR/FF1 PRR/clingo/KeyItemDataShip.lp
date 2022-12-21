item(lute).
item(bridge).
item(airship).
item(crown).
item(crystal).
item(jolt_tonic).
item(mystic_key).
item(nitro_powder).
item(canal).
item(star_ruby).
item(rod).
item(canoe).
item(levistone).
item(gear).
item(rats_tail).
item(bottle).
item(oxyale).
item(rosetta_stone).
item(chime).
item(warp_cube).
item(adamantite).
item(excalibur).
item(earth).
item(fire).
item(water).
item(air).
item(promotion).
item(lufienish).

location(sara).
location(king).
location(bikke).
location(marsh).
location(astos).
location(matoya).
location(elf).
location(locked_cornelia).
location(nerrick).
location(vampire).
location(sarda).
location(lukahn).
location(ice).
location(desert).
location(citadel_of_trials).
location(caravan).
location(fairy).
location(mermaids).
location(lefien).
location(waterfall).
location(sky2).
location(smyth).
location(lich).
location(kary).
location(kraken).
location(tiamat).
location(bahamut).
location(dr_unne).

open(king).
open(sara).
open(bikke).
open(marsh).
open(astos) :- has(crown).
open(matoya) :- has(crystal).
open(elf) :- has(jolt_tonic).
open(locked_cornelia) :- has(mystic_key).
open(nerrick) :- has(nitro_powder).
open(vampire) :- has(airship).
open(vampire) :- has(canal).
open(sarda) :- has(airship).
open(sarda) :- has(star_ruby), has(canal).
open(lukahn) :- has(airship), has(earth).
open(lukahn) :- has(canal), has(earth).
open(ice) :- has(canoe).
open(ice) :- has(airship).
open(desert) :- has(canoe), has(levistone).
open(citadel_of_trials) :- has(canoe), has(airship).
open(citadel_of_trials) :- has(canoe), has(canal).
open(caravan) :- has(airship).
open(fairy) :- has(airship), has(bottle).
open(mermaids) :- has(airship), has(oxyale).
open(lefien) :- has(airship), has(lufienish).
open(waterfall) :- has(airship), has(canoe).
open(sky2) :- has(airship), has(chime), has(warp_cube).
open(smyth) :- has(adamantite).
open(lich) :- has(rod), has(airship).
open(lich) :- has(rod), has(canal).
open(kary) :- has(canoe).
open(kary) :- has(airship).
open(kraken) :- has(airship), has(oxyale).
open(tiamat) :- has(airship), has(chime), has(warp_cube).
open(bahamut) :- has(airship), has(rats_tail).
open(dr_unne) :- has(canal), has(rosetta_stone).
open(dr_unne) :- has(airship), has(rosetta_stone).