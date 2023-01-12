-- DELETE from USERS where TRUE;
DELETE from POSTS_BT where TRUE;
DELETE from BLOGPOSTS where TRUE;

-- insert into USERS (USER_ID,USERNAME, FIRST_NAME, LAST_NAME, DESCRIPTION)
-- values
--  (1,'LeeBaird','Lee','Baird', 'Hello I am Lee Baird'),
--  (2,'FaithPeck','Faith','Peck', 'Hello I am Faith Peck'),
--  (3,'KitraHoward', 'Kitra','Howard', 'Hello I am Kitra Howard')
--;

insert into POSTS_BT (POST_ID,BODY, LAST_EDITED_AT, AUTHOR_ID)
values
    -- Blogs
    (1,'Slovakia officially the Slovak Republic, is a landlocked country in Central Europe. It is bordered by Poland to the north, Ukraine to the east, Hungary to the south, Austria to the southwest, and the Czech Republic to the northwest. Slovakias mostly mountainous territory spans about 49,000 square kilometres (19,000sqi), with a population of over 5.4 million. The capital and largest city is Bratislava, while the second largest city is Kosice.
The Slavs arrived in the territory of present-day Slovakia in the fifth and sixth centuries. In the seventh century, they played a significant role in the creation of Samos Empire. In the ninth century, they established the Principality of Nitra, which was later conquered by the Principality of Moravia to establish Great Moravia. In the 10th century, after the dissolution of Great Moravia, the territory was integrated into the Principality of Hungary, which then became the Kingdom of Hungary in 1000.[10] In 1241 and 1242, after the Mongol invasion of Europe, much of the territory was destroyed. The area was recovered largely thanks to Bela IV of Hungary, who also settled Germans, leading them to become an important ethnic group in the area, especially in what are today parts of central and eastern Slovakia.[11]
After World War I and the dissolution of the Austro-Hungarian Empire, the state of Czechoslovakia was established. It was the only country in central and eastern Europe to remain a democracy during the interwar period. Nevertheless, local fascist parties gradually came to power in the Slovak lands, and the first Slovak Republic existed during World War II as a partially-recognised client state of Nazi Germany. At the end of World War II, Czechoslovakia was re-established as an independent country. After a coup in 1948, Czechoslovakia came under communist administration, and became a part of the Soviet-led Eastern Bloc. Attempts to liberalise communism in Czechoslovakia culminated in the Prague Spring, which was crushed by the Warsaw Pact invasion of Czechoslovakia in August 1968. In 1989, the Velvet Revolution peacefully ended the Communist rule in Czechoslovakia. Slovakia became an independent state on 1 January 1993 after the peaceful dissolution of Czechoslovakia, sometimes known as the Velvet Divorce.
Slovakia is a developed country with an advanced high-income economy, ranking very high in the Human Development Index. It also performs favourably in measurements of civil liberties, press freedom, internet freedom, democratic governance, and peacefulness. The country maintains a combination of a market economy with a comprehensive social security system, providing citizens with a universal health care, free education, and one of the longest paid parental leaves in the OECD.[12] Slovakia is a member of the European Union, the Eurozone, the Schengen Area, the United Nations, NATO, CERN, the OECD, the WTO, the Council of Europe, the Visegrad Group, and the OSCE. Slovakia is also home to eight UNESCO World Heritage Sites. The worlds largest per-capita car producer, Slovakia manufactured a total of 1.1 million cars in 2019, representing 43% of its total industrial output.[13]'
    , DATE('1999-01-07')
    , '17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (2,'The Battle of the Defile or Battle of the Pass (Arabic: ____ _____, romanized:Waq_at al-Sh_ib) was fought in the Takhtakaracha Pass (in modern Uzbekistan) between a large army of the Umayyad Caliphate and the Turkic Turgesh khaganate over three days in July 731 CE. The Turgesh had been besieging Samarkand and Samarkands commander, Sawra ibn al-Hurr al-Abani, had sent a request for relief to the newly appointed governor of Khurasan, Junayd ibn Abd al-Rahman al-Murri. Junayds 28,000-strong army was attacked by the Turgesh in the pass, and although the Umayyad army managed to extricate itself and reach Samarkand, it suffered enormous casualties; Sawras 12,000 men, who had been commanded to attack the Turgesh from the rear in a relief effort, were almost annihilated.
The battle, for which one of the most detailed accounts of the entire Umayyad era survives in the History of al-Tabari, halted or reversed Muslim expansion into Central Asia for a decade. The losses suffered by the Khurasani army also led to the transfer of reinforcements from the metropolitan regions of the Caliphate, which in the long term weakened the Umayyad regime and helped bring about its collapse twenty years later in the Abbasid Revolution that began in Khurasan.'
    , DATE('2001-01-07')
    , '17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (3,'Artemis 1, officially Artemis I,[6] is an ongoing uncrewed Moon-orbiting mission, the first spaceflight in NASAs Artemis program. It is the first integrated flight test of the Orion spacecraft and Space Launch System rocket.[note 1] Artemis 1 was successfully launched from Kennedy Space Center on 16 November 2022 at 01:47:44_EST (06:47:44_UTC).[7][2][8][9] Its main objective is to test the Orion spacecraft, especially its heat shield,[10] to be used in subsequent Artemis missions that seek to reestablish human presence on the Moon, demonstrate technologies and business approaches needed for future exploration including Mars and pursue scientific studies.[11]
Formerly known as Exploration Mission-1 (EM-1),[12] the mission was renamed following the creation of the Artemis program. The mission lifted off from Launch Complex 39B at the Kennedy Space Center aboard the Space Launch System rocket. The Orion spacecraft has been launched on a mission of between 26 and 42 days,[13] with at least 6 of those days in a distant retrograde orbit around the Moon.[13] After reaching Earth orbit and performing a trans-lunar injection (burn to the Moon), the mission will deploy ten CubeSat satellites. The Orion spacecraft will later enter a distant retrograde orbit for six days. The Orion spacecraft will then return and reenter the Earths atmosphere, with the protection of its heat shield, and splash down in the Pacific Ocean. The mission will certify Orion and the Space Launch System for crewed flights beginning with Artemis 2.[14] After the Artemis 1 mission, Artemis 2 will perform a crewed lunar flyby and Artemis 3 will perform a crewed lunar landing, five decades after the last lunar Apollo mission.'
    , DATE('2022-11-17')
    , '17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (4,'Elizabeth I (7 September 1533_- 24 March 1603)[a] was Queen of England and Ireland from 17 November 1558 until her death in 1603. Elizabeth was the last of the five House of Tudor monarchs and is sometimes referred to as the "Virgin Queen".[1]
Elizabeth was the daughter of Henry VIII and Anne Boleyn, his second wife, who was executed when Elizabeth was two years old. Annes marriage to Henry was annulled, and Elizabeth was declared illegitimate. Her half-brother Edward VI ruled until his death in 1553, bequeathing the crown to Lady Jane Grey and ignoring the claims of his two half-sisters, the Catholic Mary and the younger Elizabeth, in spite of statute law to the contrary. Edwards will was set aside and Mary became queen, deposing Lady Jane Grey. During Marys reign, Elizabeth was imprisoned for nearly a year on suspicion of supporting Protestant rebels.
Upon her half-sisters death in 1558, Elizabeth succeeded to the throne and set out to rule by good counsel.[b] She depended heavily on a group of trusted advisers led by William Cecil, whom she created 1st Baron Burghley. One of her first actions as queen was the establishment of an English Protestant church, of which she became the supreme governor. This Elizabethan Religious Settlement was to evolve into the Church of England. It was expected that Elizabeth would marry and produce an heir; however, despite numerous courtships, she never did. She was eventually succeeded by her first cousin twice removed, James VI of Scotland; this laid the foundation for the Kingdom of Great Britain. She had earlier been reluctantly responsible for the imprisonment and execution of Jamess mother, Mary, Queen of Scots.
In government, Elizabeth was more moderate than her father and half-siblings had been.[3] One of her mottoes was "video et taceo" ("I see and keep silent").[4] In religion, she was relatively tolerant and avoided systematic persecution. After the pope declared her illegitimate in 1570 and released her subjects from obedience to her, several conspiracies threatened her life, all of which were defeated with the help of her ministers secret service, run by Francis Walsingham. Elizabeth was cautious in foreign affairs, manoeuvring between the major powers of France and Spain. She half-heartedly supported a number of ineffective, poorly resourced military campaigns in the Netherlands, France, and Ireland. By the mid-1580s, England could no longer avoid war with Spain.
As she grew older, Elizabeth became celebrated for her virginity. A cult of personality grew around her which was celebrated in the portraits, pageants, and literature of the day. Elizabeths reign became known as the Elizabethan era. The period is famous for the flourishing of English drama, led by playwrights such as William Shakespeare and Christopher Marlowe, and for the prowess of English maritime adventurers such as Francis Drake and Walter Raleigh. Some historians depict Elizabeth as a short-tempered, sometimes indecisive ruler,[5] who enjoyed more than her fair share of luck. Towards the end of her reign, a series of economic and military problems weakened her popularity. Elizabeth is acknowledged as a charismatic performer ("Gloriana") and a dogged survivor ("Good Queen Bess") in an era when government was ramshackle and limited, and when monarchs in neighbouring countries faced internal problems that jeopardised their thrones. After the short reigns of her half-siblings, her 44 years on the throne provided welcome stability for the kingdom and helped to forge a sense of national identity.'
    , DATE('2021-01-07')
    , '17eb989e-9171-4d6a-ab82-04441d410ef7'),
    -- Comments
    (5,'Jokes on you, Ive been using comic mono for quite some time and I love it.', DATE('2010-11-18'),'17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (6,'I am not interested.', DATE('2011-11-19'),'17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (7,'Sargon was Moses . Thats what happen when history lost the count . o 0', DATE('2002-11-19'),'17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (8,'Carl Benjamin is clearly the reincarnation of this guy.', DATE('2003-11-19'),'17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (9,'The most exciting take off to see last night up up and away', DATE('2022-12-19'),'17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (10,'imagine how much rocket progress has got push back through the time especially through the 80s', DATE('2022-12-20'),'17eb989e-9171-4d6a-ab82-04441d410ef7'),
    (11,'Ive waited months for this, and then I miss it when it finally happens.', DATE('2022-12-21'),'17eb989e-9171-4d6a-ab82-04441d410ef7')
;
insert into BLOGPOSTS (POST_ID, TITLE, IS_PUBLISHED)
values
    (1, 'Slovakia', TRUE),
    (2, 'Battle of the Defile', TRUE),
    (3, 'Artemis 1', TRUE),
    (4, 'Elizabeth I', FALSE)
;

insert into COMMENTS (POST_ID, PARENT_POST_ID)
values
    (5,1),
    (6,5),
    (7,2),
    (8,2),
    (9,3),
    (10,9),
    (11,3)
;


