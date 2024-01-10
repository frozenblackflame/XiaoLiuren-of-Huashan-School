namespace 华山派小六壬
{
    public partial class Form1 : Form
    {
        private List<string> buttonValues = new List<string>();
        private List<Button> allButtons = new List<Button>();
        private Dictionary<string, string> textMap = new Dictionary<string, string>
        {
            {"666", "万事都吉祥，如意又荣光，平安加富贵，福喜逢华阳。"},
            {"665", "喜气自然生，是非全消尽，如果待一刻，而为吉上等。"},
            {"664", "欢乐又平安，福气把君劝，虽是月日吉，时莫动身贤。"},
            {"663", "月日逢小吉，迟拖望君记，凡事只宜缓，成全变晚期。"},
            {"662", "知音化诽谎，口舌防无伤，有解也有助，闭口无事张。"},
            {"661", "好事变为凶，此刻没成功，有成也有败，逢中更为重。"},
            {"656", "月祥日缺一，时辰而逢吉，万事能称心，处处都如意。"},
            {"655", "此项算一般，有喜在心间，小事能得顺，大业有缺陷。"},
            {"654", "微喜在家堂，交易乐短长，求借小事可，大事不全当。"},
            {"653", "凡事多变迁，成功化长缓，月日因逢喜，动作因风变。"},
            {"652", "船行在江内，口猜恐漏水，喜气不为吉，好事变成非。"},
            {"651", "欢乐变悲伤，灾危不可当，本是成吉事，此刻成空亡。"},
            {"646", "凡事做神仙，何时来运转，若不逢此日，金鱼上青天。"},
            {"645", "日下喜来临，小事相求亲，交往暂时成，成功在本村。"},
            {"644", "守株呆待兔，出行财少无，安居可得乐，劝君别出屋。"},
            {"643", "出行迟缓归，守家心烦存，口舌继续在，迷迷变返遥。"},
            {"642", "口舌犯量重，在家冷如科，办事少话语，好事化恶凶。"},
            {"641", "井底观明月，见影却无形，凡事成功少，谨守得安宁。"},
            {"636", "久去又回村，喜盼才得今，今天此刻好，逢福赋予君。"},
            {"635", "早望时逢喜，拖线挂草地，摘掉心中乐，刻在微乐吉。"},
            {"634", "多盼得喜来，安居自得彩，凡事迟后成，从堂等花开。"},
            {"633", "故想变幻妄，身披破鱼网，又在密林行，劝君要提防。"},
            {"632", "劝君要少言，小人在身边，忠语变恶意，好事又成晚。"},
            {"631", "月吉不算吉，日却延长期，此刻逢空亡，本项不吉利。"},
            {"626", "喜从怨中来，乐花骂中开，本是富里生，又被恶语埋。"},
            {"625", "此项冬树架，苦落未开花，看看春色动，渐渐发萌芽。"},
            {"624", "时逢融和晴，衰残物再兴，更得微细雨，春色又还生。"},
            {"623", "避怨劝君转，怨气已久患，办事换别时，以防受牵连。"},
            {"622", "一个漏桶悬，挂在门上边，凡是由此过，那有无骂言。"},
            {"621", "口舌又逢凶，灾祸更加重，数日众疑猜，事事全变空。"},
            {"616", "灾散福门开，无边喜气来，目下相逢处，须当得横财。"},
            {"615", "进取逢通归，寒儒衣锦回，何人古此项，凡事任施为。"},
            {"614", "从恶皆消灭，端福然气生，如人行暗夜，时安得天明。"},
            {"613", "服药将身安，缠绵词讼连，百凡宜守旧，作福时拖延。"},
            {"612", "此中多恍惚，交往暗里磨，思深成怨去，笑语变骂舌。"},
            {"611", "心思多不定，求谋未得成，忍耐方为福，闭口免灾星。"},
            {"566", "往事今吉祥，意业如心想，作福保安然，吉利也顺当。"},
            {"565", "昔情得安宁，钱财渐渐兴，进财求望吉，有福亦安平。"},
            {"564", "好德承天佑，门招喜气秀，有人相助力，获福安居守。"},
            {"563", "且吉君子安，勿用小人言，凡事皆当谨，好事牵连晚。"},
            {"562", "喜事逢口舌，成中有曲折，贵人在劝解，怨言水中火。"},
            {"561", "破舟在江河，岸略获宝多，眼望航过取，舱内有灾祸。"},
            {"556", "日出临东瀛，光辉天下明，动用和合吉，百事自然成。"},
            {"555", "根实枝叶茂，林多格式高，经营多得利，兰蕙似蓬蒿。"},
            {"554", "动作因风尘，求谋可托人，若在家安居，事事得称心。"},
            {"553", "微喜迟中生，贵人提荐成，生意将见宜，好事迟缓行。"},
            {"552", "小吉逢诽骂，遇见无吉话，此刻是非多，幼苗见霜花。"},
            {"551", "此项不吉祥，灾危不可挡，凡事最不利，目下有灾殃。"},
            {"546", "大吉家中有，安居福中求，此日堂间喜，切莫远方走。"},
            {"545", "喜气庄中存，欢乐在屯村，小吉为小顺，小事刚见真。"},
            {"544", "此日又逢时，在家无非是，切莫远处行，安居又逢此。"},
            {"543", "心事盼多天，九曲又十弯，何时得吉利，需必等几旦。"},
            {"542", "外出是非多，口舌在此刻，事事不遂心，言语有克破。"},
            {"541", "征马登程处，饥人走远途，前程多阻扼，退后福方无。"},
            {"536", "夙望遥遥乡，久盼远远方，逢此一顺间，速作得吉祥。"},
            {"535", "碌碌若中求，奔走怎得休，今逢一刻喜，急去喜心头。"},
            {"534", "心事盼已久，推云见曰头，吉堂安稳坐，切莫半寸走。"},
            {"533", "求望有多天，往返又变迁，虽得微喜月，变化而牵连。"},
            {"532", "履薄登冰地，危桥得度急，重重忧险过，迟成怨口啼。"},
            {"531", "鸟寻食充饥，鸡进牢笼里，何日得出险，久期不吉利。"},
            {"526", "急急用意求，拨零见清秀，口舌稍减少，时及自无忧。"},
            {"525", "喜事口舌来，因冷花不开，今逢气侯转，速拜见鲜彩。"},
            {"524", "生家观景美，出门遇脏水，欢乐不周合，劝君急堂归。"},
            {"523", "计划好周全，做起成功晚，怨声长不消，成事有化变。"},
            {"522", "口舌处处有，希君莫出走，日时犯最重，良言也为仇。"},
            {"521", "枯木逢霜冻，小舟遇大风，惊心无可望，百事不亨通。"},
            {"516", "高名居禄庆，笼鸟得逃生，出入多财宝，更宜远方行。"},
            {"515", "三姓俱相伴，祥光得共生，更宜分造化，小事自然成。"},
            {"514", "蚌自珠中详，石内玉争光，进财家求望，有祸不成殃。"},
            {"513", "伤心离家走，得吉再回头，掉进陷井里，逃身几日久。"},
            {"512", "尘埋青铜镜，美玉隐泥泞，何日得出生，口舌怨声净。"},
            {"511", "迢遥途中间，云横日坠山，羁心无可托，前后总皆难。"},
            {"466", "当地得高名，福气此地生，安居财禄贵，万事如意兴。"},
            {"465", "财富在本乡，称心而荣光，事事都如意，在家得吉祥。"},
            {"464", "久居安吉乐，出行无欢歌，日吉时安居，窗前观远色。"},
            {"463", "弯月升上天，看物仔细想，朦胧夜间影，知清等明天。"},
            {"462", "好心变歹意，谎舌要提记，成事化计吵，如鸭争闹鸡。"},
            {"461", "单人远意求，不慎陷深沟，因没听劝语，有祸自造成。"},
            {"456", "此项占六和，求财喜气多，远人归家乡，逢喜全家乐。"},
            {"455", "当地求谋生，不必远方行，虽然发小财，日日都兴隆。"},
            {"454", "霖雨滋苗秀，何愁不广收，安身心得乐，家中居无忧。"},
            {"453", "行路推破车，泥泞有陡坡，要它真费力，扔了扔不得。"},
            {"452", "家中遇小财，惹得他人猜，好事口舌中，可能非道来。"},
            {"451", "洗衣在晒凉，没干遇风狂，刮到泥土里，造成一服脏。"},
            {"446", "窗前一盆花，室内出新芽，安居又逢春，温中在萌发。"},
            {"445", "家中忙不休，财产自到手，室内全是宝，劝莫远方游。"},
            {"444", "三项逢大安，何必思出远，安居得顺利，守屋为安闲。"},
            {"443", "院内放见筝，柳树挂线绳，不能上树解，又难硬拉挣。"},
            {"442", "家床在梦中，惊骂吵吓醒，是非远遑有，闭口无事情。"},
            {"441", "闲坐倒杯茶，凉杯遇热炸，烫伤自己手，惹得他人骂。"},
            {"436", "坐屋久盼好，此刻将吉蛟，阴云天缝日，一会不见了。"},
            {"435", "家中思发财，坐等自然来，等了多少日，此刻喜颜开。"},
            {"434", "母鸡一个蛋，几天没出现，只可耐心等，动手有危险。"},
            {"433", "室问当奴人，骂声变吵音，家里苦忙碌，怨气受不尽。"},
            {"432", "家人久怨气，无和温言意，处处犯小语，吵闹长时期。"},
            {"431", "寒窗三冬冷，盆花一枯容，昨夜狂风雪，又遭一窗冰。"},
            {"426", "家中急声无，舌尖见喜富，君在寻找财，欢乐在此处。"},
            {"425", "房内有泼妇，骂消又蛮鲁，只因逢速喜，脸上有笑吐。"},
            {"424", "口舌续在手，在家方为秀，在屋商量事，闹急才能休。"},
            {"423", "坐家心不宁，急声接吵声，多日事不顺，总也不消停。"},
            {"422", "破房又漏屋，凉炕躺病夫，呻吟哀声叫，骂吵变为哭。"},
            {"421", "守业扔受究，钱箱有蛀虫，庄田禾苗好，又遭霜雪冻。"},
            {"416", "圆月升青天，今宵照家园，家家沾德泽，上空净云烟。"},
            {"415", "冬麦又复春，坐地刚湿润，堂中逢吉醒，破屋得新门。"},
            {"414", "枯树又复活，当地现春色，遭风冷冻霜，未动艰难过。"},
            {"413", "外出有小灾，怨骂犯重来，长期不消散，本村受吵害。"},
            {"412", "项中迷漫漫，骂声传无边，情意成怨去，口舌连篇篇。"},
            {"411", "雨中一病鸟，飞爬遇冰雹，艰苦无相助，何日得晴消。"},
            {"366", "远乡作生意，兴隆挂锦衣，虽然出多年，还是称心地。"},
            {"365", "外出行买卖，数日没回来，今有吉利时，欢乐发小财。"},
            {"364", "花儿数日栽，今堂刚见开，守看色更美，移出寒风来。"},
            {"363", "时阴又时晴，时雾云零星，雁秋南方去，明春北回程。"},
            {"362", "病夫愈猜说，好后犯罗嗦，呻吟声声紧，前程有坎坷。"},
            {"361", "漏船行江心，发现浸下沉人虽告利良日，惊惕预防君。"},
            {"356", "远出海捕鱼，满船回岸去，人人在庆贺，多年才成玉。"},
            {"355", "久病刚复康，得需营养补，天天海味美，日日山珍香。"},
            {"354", "多想得财源，守家盼金山，因无差旅费，安居在甲院。"},
            {"353", "乘船游在江，撒下几次网，这次网挂住，不水冰寒凉。"},
            {"352", "多年往一屋，两家总争诉，分开不能分，吵闹在一处。"},
            {"351", "多日积柴草，此时遭火烧，财来如夜露，一晨晒净消。"},
            {"346", "总无行远门，安堂良逢辰，远友来相助，坐床迎贵人。"},
            {"345", "贵人自动来，得喜遇小财，只因身未动，欢乐见异彩。"},
            {"344", "病夫今起床，窗前望春光，院内绿色新，室内盆花香。"},
            {"343", "远行足受伤，回头转归乡，行走痛苦忍，到达深夜堂。"},
            {"342", "此刻别出门，出门遇哑人，病人多作怪，怒气冲在身。"},
            {"341", "多年病在床，医治不复康，今又遇邪鬼，恐怕见阁王。"},
            {"336", "阴雨得晴天，时来有运转，欲盼有几秋，好运在今现。"},
            {"335", "笼鸟得逃生，寻伴找同性，串山又越岭，重回原林中。"},
            {"334", "事事都未成，家中有光明，远望雾茫茫，近看心宽荣。"},
            {"333", "三项逢留连，详看单项筒，求是日未明，凡事只宜缓。"},
            {"332", "鸭落冷井中，打水桶叮咚，寒饥愁游浮，何日出头容。"},
            {"331", "盲人又闹目，旧衣又破处，鱼网破烂孔，乱团又难捕。"},
            {"326", "秋月逢阳春，枯苗见绿新，口舌刚消尽，微喜乐在心。"},
            {"325", "风雨刚停晴，心中喜乐兴，求事多费力，求吉有喜迎。"},
            {"324", "骂嘴在耳边，家中听不见，安乐自无忧，有人登门劝。"},
            {"323", "赤口挑留连，前后有牵连，怨声中求好，还需过几天。"},
            {"322", "久坐监牢中，打骂苦中疼，为人必行善，作恶事事凶。"},
            {"321", "少费计较舌，说话更罗嗦，诸事成功少，处处小人多。"},
            {"316", "金针苦中磨，年月岁日多，今日刚欲成，心中有喜乐。"},
            {"315", "多年连没成，运气即将兴，驱散满天云，迎来方里晴。"},
            {"314", "深冬刚已过，庭中见奇色，因为身没动，才能喜中得。"},
            {"313", "空亡担留连，百事难成全，遥望远方去，运气在何边。"},
            {"312", "劳心事事空，口舌满西东，常忧叹气多，笑语多愁容。"},
            {"311", "福气自来修，运气无根由，多年劳禄成，一事空皆休。"},
            {"266", "金榜留美名，得意享太平，吉祥事事好，六合处处通。"},
            {"265", "衣禄自然来，天才有安排，如意称心乐，远边淡雾开。"},
            {"264", "安居得安宁，喜光照门庭，礼义明迎友，贵人提高升。"},
            {"263", "喜事成功晚，望君记心问，近日事升兴，过去口舌连。"},
            {"262", "口舌又重返，好意落漫怨，不言无事闹，忠言即劝君。"},
            {"261", "事成不遂心，处处有小人，本是春和日，推来寒阴云。"},
            {"256", "遂顺皆如意，前病愈逢喜，吉祥增称心，乐欢加详吉。"},
            {"255", "求财士分量，须有贵人帮，福乐欢在心，如意都顺当。"},
            {"254", "此项福气兴，只因守门庭，有人来相助，坐等自然成。"},
            {"253", "谋事受奔波，处处犯罗嗦，事事不及时，迷雾心思多。"},
            {"252", "好事犯口舌，劝有君少说，本是不为己，情意变仇恶。"},
            {"251", "幼苗遭风霜，重种晚春阳，讽言讥语过，成事化败伤。"},
            {"246", "喜气进高堂，广财迎吉祥，天边口舌散，事事如意昌。"},
            {"245", "远方雾消尽，福气满堂春，希君安床坐，运转自上门。"},
            {"244", "遥村无云烟，劝君庭中安，喜乐事会有，不在远天边。"},
            {"243", "久病愈后患，只待治牵连，疑猜刚守口，守家事缠绵。"},
            {"242", "劝君莫远走，在家也闭口，万事都作怪，千怨家患忧。"},
            {"241", "深秋逢寒雨，冷风透草居，屋破漏水急，凉夜怎能宿。"},
            {"236", "急气远离家，得意逢荣华，虽然志成迟，喜光照容霞。"},
            {"235", "吵嘴出家园，顺心回乡转，如意多年求，吉祥照身边。"},
            {"234", "腿患无法行，进退都不能，求事成功晚，只可守门庭。"},
            {"233", "因鸟半空悬，呼伴喊多年，无人开笼门，怎能回林间。"},
            {"232", "赤口连赤口，事多全忧愁，诽谤嘲讥骂，连连无消头。"},
            {"231", "豆腐掉灰炕，吹打生不净，怨持长久骂，忍耐苦哀声。"},
            {"226", "讽刺击声停，智雨寒刚晴，闭口少言语，笑见喜气迎。"},
            {"225", "口舌刚消闲，乐喜到身边，此刻得小顺，提妨小人嫌。"},
            {"224", "闹吵骂声有，劝群在家守，谦让无是非，安居严闭口。"},
            {"223", "口舌不消散，小人不安闲，谅解方为贵，寡言才为安。"},
            {"222", "三项逢赤口，冯声如水流，希君单项赏，细节而知透。"},
            {"221", "乞丐遭狂犬，喧闹投进险，行处事变空，哭啼受艰难。"},
            {"216", "荒地草锄净，望去一片春，草根继续发，希君要惕警。"},
            {"215", "破网补合好，小喜微量少，打鱼撒几网，看去乱糟糟。"},
            {"214", "久伤刚合口，居养能无忧，痊处有疤痕，以防炎回头。"},
            {"213", "冷雨不停阴，连绵拖沉沉，行走泥泞难，进退两忧闷。"},
            {"212", "空忘伴赤口，哭泣与忧愁，无人来解助，漂泊独自游。"},
            {"211", "狂浪卷小舟，苦海无尽头，劝群积德善，为人要忠厚。"},
            {"166", "更换门庭喜，又逢各事吉，驱散远天云，称心又如意。"},
            {"165", "贵人得相助，出行遇福禄，小人刚安宁，喜气满心处。"},
            {"164", "希君莫远行，等待事自兴，虽然前事愁，今庭得安宁。"},
            {"163", "败祸有余伤，暂时有痛痒，望君稍停动，乱事得安详。"},
            {"162", "有风也有雪，口舌不见缺，诸事难遂心，成功变坏裂。"},
            {"161", "寒风刮冷鸟，烈火烧野草，不吉不顺利，好事变为糟。"},
            {"156", "云散见青天，雨停看远山，风平浪又静，顺利万里船。"},
            {"155", "得志回家中，面色颜光红，枯苗得甘雨，如药辞别冬。"},
            {"154", "独坐喜气堂，坐享友人帮，此刻安居吉，补好前创伤。"},
            {"153", "碌碌不停闲，阴云扔阴暗，无风驱云走，无力拨雾散。"},
            {"152", "破事犯口骂，白露浸幼芽，虽是无大伤，妨寒苗再发。"},
            {"146", "事事都如意，家外迎来喜，此刻福禄多，满堂春大吉。"},
            {"145", "万事如意长，吉利照高堂，荣华称心贵，金银有满仓。"},
            {"144", "劝君守门庭，不用远方行，贵人自来助，喜气满堂迎。"},
            {"143", "事事成全晚，九曲又三弯，郁闷时时有，小事成而变。"},
            {"142", "此项犯口舌，家中闹事多，是非不在远，就在本庄过。"},
            {"141", "病夫家中养，多不复回康，财钱都消散，何时得安详。"},
            {"136", "久盼在心问，今日重回还，喜气满屋乐，福光盈庭欢。"},
            {"135", "冰化逢新春，雪融处处新，福禄迎面来，吉利又顺心。"},
            {"134", "家中忙碌多，事事平常过，吉利家中有，庭院唱喜歌。"},
            {"133", "推车半路上，轮坏不转向，进退都为难，途中而彷徨。"},
            {"132", "有病在途中，忍苦耐艰痛，口舌继续有，事事不由功。"},
            {"131", "枯苗逢冰雪，残冰遇烈阳，事事不称心，不欢不吉详。"},
            {"126", "骂声已消尽，此刻又称心，冬苗逢暖雨，百草到阳春。"},
            {"125", "迷雾刚消散，重见艳阳天，眼望春色美，顺开万里船。"},
            {"124", "家中病夫好，喜气吉祥娇，当地办事吉，守家方为妙。"},
            {"123", "事事成功晚，罗嗦又麻烦，口舌处处有，九曲三声怨。"},
            {"122", "一根独木桥，三人对行吵，互相不退让，各自不谦饶。"},
            {"121", "杯落茶壶上，两者都俱伤，吉利事情少，劝群细推详。"},
            {"116", "行善喜事多，处处有吉色，云消见晴天，吉祥唱欢歌。"},
            {"115", "枯树逢和春，万象吉祥新，求财处处有，办事也顺心。"},
            {"114", "现在无坎坷，只因群积德，为人必须善，慈仁好事多。"},
            {"113", "事难又久长，心闷迷茫茫，出事不如意，无吉没日光。"},
            {"112", "弱苗遭冰霜，病兔逢箭伤，瞎子又闹眼，瘸夫足生疮。"},
            {"111", "谋事最难成，坐家不安宁，病人遇恶鬼，空亡下凶灵。"},
        };

        public Form1()
        {
            InitializeComponent();
            Form2 form2 = new Form2();
            form2.Show();
            allButtons.AddRange(new Button[] { 大安, 留连, 速喜, 空亡, 赤口, 小吉 });
        }

        private void 确认_Click(object sender, EventArgs e)
        {
            string key = string.Join("", buttonValues.Select(b => b == "空亡" ? "1" : b == "赤口" ? "2" : b == "留连" ? "3" : b == "大安" ? "4" : b == "速喜" ? "5" : "6"));
            string value = string.Join("，", buttonValues);
            if (textMap.ContainsKey(key))
            {
                选文.Text = value;
                占文.Text = textMap[key]; // 将对应的文字显示在文本框中
            }
            else
            {
                占文.Text = "未找到对应的文字。";
            }
            确认.Enabled = false; // 禁用确认按钮
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            buttonValues.Add(clickedButton.Text); // 向列表中添加值
            clickedButton.BackColor = Color.LightBlue; // 改变按钮的背景颜色以显示按下状态
            clickedButton.Enabled = false; // 禁用已点击的按钮
            if (buttonValues.Count == 3)
            {
                确认.Enabled = true;
                foreach (Button button in allButtons)
                {
                    button.Enabled = false; // 禁用所有按钮
                }
            }
        }

        private void 重置_Click(object sender, EventArgs e)
        {
            buttonValues.Clear(); // 清空列表
            foreach (Button button in allButtons)
            {
                button.Enabled = true; // 启用所有按钮
                button.BackColor = Color.White; // 恢复按钮的默认背景颜色
            }
            占文.Text = "";
            确认.Enabled = false; // 禁用确认按钮
        }

        private void 随机_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<Button> availableButtons = allButtons.Where(button => button.Enabled).ToList(); // 只选择启用的按钮
            for (int i = 0; i < 3 && availableButtons.Count > 0; i++)
            {
                int index = random.Next(availableButtons.Count);
                Button_Click(availableButtons[index], EventArgs.Empty);
                availableButtons.RemoveAt(index);
                确认_Click(sender, e); // 在随机选择完成后自动点击确认按钮
            }
        }
    }
}
