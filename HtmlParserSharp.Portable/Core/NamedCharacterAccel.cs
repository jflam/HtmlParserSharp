﻿/*
 * Copyright 2004-2010 Apple Computer, Inc., Mozilla Foundation, and Opera 
 * Software ASA.
 * 
 * You are granted a license to use, reproduce and create derivative works of 
 * this document.
 */

namespace HtmlParserSharp.Portable.Core
{
	public sealed class NamedCharactersAccel
	{
		internal static readonly int[][] HILO_ACCEL = new int[][] {
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			new int[] { 0, 0, 0, 0, 0, 0, 0, 12386493, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 40174181, 0, 0, 0, 0, 60162966, 0, 0, 0,
					75367550, 0, 0, 0, 82183396, 0, 0, 0, 0, 0, 115148507, 0,
					0, 135989275, 139397199, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 28770743, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					82248935, 0, 0, 0, 0, 0, 115214046, 0, 0, 0, 139528272, 0,
					0, 0, 0, },
			null,
			new int[] { 0, 0, 0, 4980811, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 38470219, 0, 0, 0, 0, 0, 0, 0, 0, 64553944, 0, 0, 0, 0,
					0, 0, 0, 92145022, 0, 0, 0, 0, 0, 0, 0, 0, 139593810, 0, 0,
					0, 0, },
			new int[] { 65536, 0, 0, 0, 0, 0, 0, 0, 13172937, 0, 0, 0, 0, 0, 25297282, 0,
					0, 28901816, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					71500866, 0, 0, 0, 0, 82380008, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, },
			null,
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					94897574, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 2555943, 0, 0, 0, 0, 0, 0, 0, 15532269, 0, 0, 0, 0, 0, 0,
					0, 31785444, 34406924, 0, 0, 0, 0, 0, 40895088, 0, 0, 0,
					60228503, 0, 0, 0, 0, 0, 0, 0, 82445546, 0, 0, 0, 0, 0,
					115279583, 0, 0, 136054812, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 40239718, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 5046349, 0, 0, 10944679, 0, 13238474, 0, 15597806,
					16056565, 0, 20578618, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, },
			null,
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					95225257, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 196610, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 8454273, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 46072511, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 2687016, 0, 0, 0, 0, 0, 13304011, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 31850982, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			null,
			null,
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					34472462, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 95290798, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 5111886, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					34603535, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 105776718, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 8585346, 0, 11075752, 0, 0, 0, 0, 16187638, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 28508594, 0, 0,
					0, 0, 0, 0, 0, 40305255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					95421871, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			null,
			null,
			null,
			new int[] { 0, 0, 0, 5177423, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			null,
			null,
			null,
			null,
			null,
			null,
			new int[] { 327684, 1900571, 2949162, 5374032, 8716420, 0, 11206826,
					12517566, 13435084, 0, 15663343, 16515320, 19988785,
					20644155, 25428355, 27197855, 0, 29163962, 31916519,
					34734609, 36045347, 0, 0, 0, 40436328, 40960625, 41615994,
					46596800, 54264627, 60556184, 64750554, 68879387, 71763012,
					75826303, 77268122, 0, 81462490, 83952875, 92865919,
					96142769, 105973327, 110167691, 0, 116917984, 121833283,
					132253665, 136251421, 140707923, 0, 0, 144574620,
					145361066, },
			new int[] { 393222, 0, 0, 0, 0, 0, 11272364, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 36176423, 38535756, 0, 0, 0, 0, 41681532, 46727880,
					0, 60687261, 0, 0, 71828552, 75891846, 0, 0, 0, 84411650,
					0, 96404924, 0, 0, 0, 117376761, 121898820, 132319203,
					136382496, 0, 0, 0, 0, 0, },
			new int[] { 589831, 1966110, 3276846, 5505107, 8978566, 10420383, 11468973,
					12583104, 13631694, 15139046, 15794416, 16711933, 20054322,
					20840764, 25624965, 27263392, 0, 29360574, 32244200,
					34931219, 36373033, 38601293, 39584348, 0, 40567402,
					41091698, 42205821, 46858954, 54723389, 60818335, 65143773,
					68944924, 71959625, 75957383, 77530268, 80938194, 81593564,
					84739337, 92997002, 96863680, 106235474, 110233234, 0,
					117704448, 122816325, 132515812, 136579106, 140773476,
					142149753, 143001732, 144705695, 145492139, },
			new int[] { 0, 0, 3342387, 0, 9044106, 0, 11534512, 0, 13697233, 0, 0, 0, 0,
					0, 25690504, 0, 0, 0, 0, 0, 36438572, 38732366, 0, 0, 0,
					41157236, 0, 46924492, 54788932, 61080481, 65209315, 0,
					72025163, 0, 0, 0, 0, 85132558, 93062540, 96929223,
					106563158, 0, 0, 118032133, 123012947, 132581351,
					136775717, 140839013, 0, 143067271, 0, 145557677, },
			new int[] { 0, 2162719, 3473460, 5636181, 0, 0, 0, 0, 0, 0, 0, 18809088,
					20185395, 21299519, 0, 0, 0, 29622721, 0, 0, 0, 39256656,
					39649885, 0, 0, 41288309, 42336901, 47448781, 55182149,
					61342629, 65274852, 69010461, 72811596, 76219528, 77726880,
					0, 0, 86967572, 93128077, 97650120, 106628699, 110560915,
					0, 118490890, 123733846, 132646888, 0, 141232230,
					142411898, 0, 144836769, 145688750, },
			new int[] { 655370, 2228258, 3538998, 5701719, 9109643, 10485920, 11600049,
					12648641, 13762770, 15204584, 15859954, 18874656, 20250933,
					21365062, 25756041, 27328929, 28574132, 29688261, 32309741,
					34996758, 36504109, 39322200, 39715422, 39912033, 40632940,
					41353847, 42467975, 47514325, 55247691, 61473705, 65405925,
					69272606, 72877144, 76285068, 77857955, 81003732, 81659102,
					87164208, 93193614, 97715667, 106759772, 110626456,
					114296528, 118687505, 123864929, 132712425, 136906792,
					141297772, 142477438, 143132808, 144902307, 145754288, },
			new int[] { 786443, 0, 0, 0, 9240716, 0, 11665586, 0, 13893843, 0, 0, 0, 0,
					0, 25887114, 0, 0, 0, 0, 0, 36635182, 0, 0, 0, 0, 0,
					42599049, 0, 0, 0, 65733607, 0, 73008217, 0, 77989029, 0,
					81724639, 87295283, 0, 98305492, 107021918, 0, 0, 0, 0, 0,
					137037866, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 3604535, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 27394466, 0,
					29753798, 32571886, 35258903, 0, 0, 0, 0, 0, 0, 0, 0,
					55509836, 61604779, 0, 0, 0, 0, 0, 0, 81790176, 87557429,
					93259151, 98502109, 107152994, 110888601, 0, 119015188,
					124323683, 133498858, 137234476, 0, 0, 143263881, 0,
					145819825, },
			new int[] { 0, 0, 3866680, 6160472, 0, 10616993, 0, 12714178, 0, 0, 0, 0,
					20316470, 0, 0, 27460003, 0, 31261127, 32637426, 35521051,
					0, 0, 0, 39977570, 0, 0, 0, 48366294, 56492880, 62391213,
					0, 69338146, 73073755, 0, 78316711, 0, 0, 0, 93980048,
					98764256, 107218532, 111085213, 114362065, 119736089,
					125241194, 133957622, 0, 0, 0, 143329419, 144967844,
					145885362, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 62456761, 0, 69403683, 73139292, 0,
					78382252, 0, 81855713, 87622969, 0, 98829796, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 48431843, 0, 0, 0, 0, 0, 76416141, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 851981, 0, 4063292, 0, 9306254, 0, 0, 0, 0, 0, 0, 19005729, 0, 0,
					0, 27525540, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 42795659,
					49152740, 56623967, 62587834, 66061292, 69600292, 73401437,
					0, 0, 0, 0, 87950650, 94111131, 99878373, 107546213,
					112002720, 0, 119932708, 125306744, 0, 137496623,
					141363309, 0, 143460492, 0, 0, },
			new int[] { 917518, 0, 0, 0, 9502863, 0, 0, 0, 14155989, 0, 0, 19071267, 0,
					0, 26083724, 0, 0, 0, 32702963, 0, 36700720, 0, 0, 0, 0, 0,
					43057806, 0, 0, 0, 66520049, 0, 0, 0, 78841005, 81069269,
					0, 88147263, 0, 99943925, 107873898, 112068270, 0,
					120063783, 125831033, 0, 137693235, 0, 0, 143526030, 0, 0, },
			new int[] { 983055, 0, 0, 0, 0, 0, 0, 0, 14483673, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 37093937, 0, 0, 0, 0, 0, 44565138, 49349359, 0, 0,
					66651128, 69665831, 73860193, 0, 79561908, 0, 0, 88606018,
					94176669, 0, 0, 0, 0, 120129321, 0, 0, 0, 141494382, 0,
					143591567, 0, 0, },
			new int[] { 1114128, 2293795, 4587583, 8257631, 9633938, 10813603, 11731123,
					12845251, 14680286, 15270121, 15925491, 19661092, 20382007,
					24969543, 26149263, 27656613, 28639669, 31392222, 32768500,
					35586591, 37225015, 39387737, 39780959, 40043107, 40698477,
					41419384, 44696233, 52495090, 57738081, 63439804, 66782202,
					69927976, 73925736, 76809359, 79824063, 81134806, 81921250,
					89785673, 94307742, 100795894, 107939439, 112330415,
					114427602, 120588074, 126158721, 134416381, 137824310,
					141559920, 142542975, 143853712, 145033381, 145950899, },
			new int[] { 1179666, 0, 0, 0, 9699476, 0, 0, 0, 0, 0, 0, 0, 0, 0, 26280336,
					0, 0, 0, 0, 0, 38076985, 0, 0, 0, 0, 0, 45220523, 52560674,
					0, 0, 67175420, 69993516, 0, 0, 79889603, 0, 0, 89916763,
					94373280, 101451267, 108136048, 0, 114493139, 120784689,
					126355334, 134481924, 138414136, 141625457, 142608512, 0,
					0, 0, },
			new int[] { 0, 0, 0, 0, 9896085, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					33292789, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 67830786, 0, 0,
					0, 80020676, 0, 0, 0, 0, 0, 0, 0, 0, 0, 127403913, 0, 0, 0,
					0, 0, 0, 0, },
			new int[] { 1310739, 2359332, 4653127, 0, 0, 0, 12189876, 0, 0, 0, 0, 0, 0,
					0, 26345874, 28246439, 0, 31457760, 0, 35652128, 38142534,
					0, 0, 0, 0, 0, 45351603, 52757283, 57869170, 63636425,
					67961868, 71304237, 73991273, 0, 0, 0, 0, 90309981, 0,
					101910029, 108988019, 114034355, 0, 120850228, 127469465,
					135464965, 138741825, 141690994, 142739585, 143984788, 0,
					0, },
			new int[] { 1441813, 2424869, 4718664, 8388735, 10027160, 10879142, 12255419,
					12976325, 14745825, 15401194, 15991028, 19857709, 20447544,
					25035134, 26542483, 28377520, 28705206, 31588833, 33358333,
					35783201, 38208071, 39453274, 39846496, 40108644, 40764014,
					41484921, 45613749, 53216038, 58196852, 63898572, 68158478,
					71369793, 74253418, 77005973, 80479430, 81265879, 81986787,
					90965347, 94504353, 103679508, 109250176, 114165453,
					114558676, 121243445, 127731610, 135727124, 138807366,
					142018675, 142805123, 144115862, 145098918, 146016436, },
			new int[] { 1572887, 0, 0, 0, 10092698, 0, 12320956, 0, 14811362, 0, 0,
					19923248, 0, 25166207, 26739094, 0, 0, 0, 33423870, 0,
					38273608, 0, 0, 0, 0, 0, 45744825, 0, 58262393, 64095184,
					68355089, 0, 75170926, 0, 80610509, 0, 0, 91817325, 0,
					104203823, 109512324, 0, 0, 121636667, 128059294, 0,
					139069511, 0, 0, 0, 0, 0, },
			new int[] { 1703961, 2490406, 4849737, 0, 10223771, 0, 0, 13107399, 15007971,
					15466732, 0, 0, 20513081, 25231745, 26870169, 0, 0,
					31654371, 34275839, 0, 38404681, 0, 0, 0, 40829551, 0,
					45875899, 53609261, 59900794, 64226259, 68551700, 0, 0, 0,
					80807119, 81331417, 0, 91948410, 94700963, 104465975,
					109643400, 114230991, 114951893, 121702209, 131663779, 0,
					139266123, 0, 0, 144246936, 145295527, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 27132315, 0, 0, 0, 0,
					0, 0, 39518811, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 75302012, 0,
					0, 0, 0, 92079484, 0, 105383483, 109708938, 0, 0, 0, 0, 0,
					0, 0, 0, 144312474, 0, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 46006973, 0, 60031891, 64291797, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 105711177, 0, 0, 0, 0, 131991514, 135923736,
					139331662, 0, 0, 144378011, 0, 146147509, },
			new int[] { 0, 0, 0, 0, 10354845, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 68813847, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 121767746, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 60097429, 0, 0, 0, 0, 77137048, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, },
			new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 0, 0, 64422870, 0, 0, 0, 0, 0, 0, 0, 0, 0,
					0, 0, 0, 0, 0, 132122591, 0, 0, 142084216, 0, 0, 0, 0, }, };

	}

}
