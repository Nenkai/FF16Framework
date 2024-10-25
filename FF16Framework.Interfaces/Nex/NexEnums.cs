﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF16Framework.Interfaces.Nex;

public enum NexTableIds
{
    scene = 11,
    cameramode = 13,
    charatimeline = 14,
    command = 15,
    action = 16,
    battleai = 23,
    bnpcbase = 26,
    weaponbase = 28,
    squad = 30,
    attackparam = 32,
    signal = 33,
    navpowermovertune = 34,
    motionparam = 35,
    enpcbase = 37,
    gimmickbase = 38,
    actorbase = 40,
    moveparam = 42,
    paramgrow = 45,
    aiaction = 48,
    aitask = 49,
    aiactionselector = 51,
    damagereaction = 58,
    access = 65,
    defaulttalk = 67,
    layoutnamedinstance = 68,
    playermode = 71,
    questasset = 72,
    placement = 73,
    magic = 75,
    weaponattachoffset = 80,
    weaponattachtype = 81,
    collisionmaterial = 82,
    battlecondition = 84,
    gimmicktype = 87,
    footstep = 90,
    item = 95,
    levelcutscene = 96,
    motionlayer = 98,
    ui = 99,
    skeletonparam = 103,
    droptable = 104,
    navbuildparam = 108,
    bgm = 109,
    placename = 110,
    partytalk = 112,
    buff = 115,
    battledirector = 116,
    attackmove = 117,
    followparam = 119,
    ability = 123,
    actorstateset = 124,
    playercommandbuilder = 130,
    hitvfx = 133,
    stagesettype = 135,
    stagesettimeline = 136,
    dialoguecamera = 137,
    fatalattack = 138,
    attackelement = 139,
    mapdirector = 140,
    initability = 144,
    window = 147,
    transition = 148,
    motionlayerset = 150,
    questprogress = 152,
    dialogueeventcondition = 160,
    skillcommandpalette = 161,
    dialogueeventtrigger = 185,
    partparam = 196,
    levelcutscenetimeline = 202,
    questtask = 203,
    zdevtips = 204,
    quest = 207,
    questsequence = 208,
    questtodoaction = 209,
    partymember = 211,
    partyselect = 212,
    eid = 213,
    scenariocutscenetimeline = 214,
    scenariocutscene = 215,
    battlecutscenetimeline = 216,
    battlecutscene = 217,
    questtodo = 221,
    monstat = 223,
    movetype = 224,
    flyparam = 228,
    questchapter = 229,
    worldmapanchor = 230,
    usersituation = 231,
    speaker = 232,
    itemshopbase = 233,
    smithshopbase = 234,
    shopbase = 235,
    shopcamera = 236,
    shoptalk = 237,
    navpowerobstacledat = 239,
    navpenaltymult = 243,
    navpowerlinkdat = 244,
    levelsequence = 245,
    leveleventtimeline = 247,
    levelevent = 248,
    loadingimage = 249,
    stagesetbase = 251,
    motionweapontype = 252,
    stage = 253,
    scenecaption = 256,
    eventaction = 257,
    uipermission = 258,
    characondition = 261,
    usercondition = 262,
    levelsequenceaction = 263,
    eventidlestate = 265,
    face = 266,
    head = 267,
    body = 268,
    camerareset = 269,
    dialogueeventpose = 270,
    collision = 271,
    bgmselect = 272,
    gamemap = 277,
    characollisionshape = 278,
    ztext = 279,
    envvfxset = 280,
    footground = 281,
    guardparam = 282,
    vfxattributeflag = 284,
    bgmmode = 286,
    contentdynamicparam = 288,
    corpsetype = 289,
    corpsestay = 292,
    corpsebase = 293,
    mapchecklist = 297,
    voiceaudiblerange = 298,
    contenttag = 299,
    eqsparam = 300,
    cameraimpactpreset = 301,
    camerashakepreset = 302,
    moviedata = 305,
    normalcameramode = 309,
    contentwall = 310,
    uifontset = 317,
    uicolor = 320,
    partadditionaldataparam = 321,
    partparamset = 322,
    normalcameraparam = 323,
    aicounter = 325,
    customaction = 326,
    playertargetparam = 327,
    astralprojection = 329,
    envvfxconversiontable = 330,
    mapdirectorsequence = 331,
    streamingsettings = 333,
    streamingconfig = 334,
    camerafcurve = 335,
    uisystemparam = 336,
    mainmenucameraparam = 337,
    mapdirectorsequenceset = 341,
    modelvfx = 342,
    padvibration = 343,
    bnpcreactiontype = 345,
    uikeyassign = 348,
    mapdebugminimap = 349,
    directoractorlist = 353,
    directoractorphaseparam = 354,
    behavioract = 357,
    behaviormove = 358,
    behaviormovesequence = 359,
    behaviorwanderingparam = 360,
    behaviorwanderingactset = 361,
    placegroup = 364,
    placeassign = 365,
    uiaddon = 366,
    destructionparam = 367,
    nullactorbase = 368,
    itemrarity = 369,
    equipitem = 370,
    recipe = 374,
    itemcategory = 375,
    itemshopstock = 376,
    stagesetparts = 378,
    stagesetstate = 379,
    stagesetstatetransition = 380,
    battleevent = 381,
    battleeventtimeline = 382,
    graphicsenvironmentparam = 388,
    actionmovetype = 392,
    mseqtag = 393,
    usersituationdebugcategory = 395,
    usersituationdebugreference = 396,
    battletag = 399,
    battledirectordefine = 400,
    behaviordialogueactionset = 401,
    combo = 402,
    usersituationflag = 403,
    mapdirectorcontent = 407,
    mapdirectormodule = 408,
    directormodule = 409,
    cutscenesetupcamerapreset = 410,
    cutscenesetuppcmovepreset = 411,
    uisound = 412,
    behaviorlinkactorset = 413,
    mapdebugminimapnavi = 414,
    attackmovestraight = 416,
    systemparam = 419,
    screeneffectdefine = 423,
    uibuttonguide = 424,
    jingle = 425,
    sidequestbattledirector = 429,
    gimmickitemparam = 430,
    questparalleltodo = 431,
    stageshopbase = 435,
    vfxexternallist = 437,
    gimmickitemdrop = 439,
    gimmicktreasureboxdrop = 440,
    stagesetstateevent = 442,
    doontype = 443,
    gimmickdoortype = 446,
    playercontrol = 449,
    battletalk = 451,
    howto = 452,
    tutorialdirector = 453,
    vfxtable = 454,
    behaviorwaitparam = 456,
    animalbase = 457,
    eventhooktype = 458,
    vacuumedmoveparam = 459,
    aiparam = 460,
    tutorial = 461,
    toolsgamesurveyoccupation = 462,
    toolsgamesurveyobjectives = 463,
    gimmickchangetype = 464,
    gamemapsettings = 469,
    autoplaymainquest = 470,
    jumpparagraphcliplabel = 472,
    directormapobjectlist = 473,
    directorcondition = 474,
    doonmashingtype = 475,
    actionwallmoveparam = 476,
    directormapobjectmonitor = 480,
    directoractormonitor = 481,
    model = 482,
    charatimelinevariation = 483,
    ragdollpartsset = 485,
    ragdollparam = 486,
    cutsceneset = 487,
    summonmode = 488,
    onlinesuiteeventtype = 489,
    seadevent = 491,
    userpermission = 492,
    charapermission = 493,
    emcameraparam = 495,
    specialarea = 497,
    precedepermissiontype = 498,
    controlpermissiontype = 499,
    normalcameraaround = 500,
    navareausageflag = 501,
    navlinkusageflag = 502,
    modelcoordinate = 503,
    battleblockdirector = 505,
    result = 506,
    partyactorsetting = 507,
    partyfollowcondition = 509,
    behaviormoveset = 510,
    navpowerareadat = 511,
    eyecolor = 512,
    skincolor = 513,
    haircolor = 516,
    colorcoordinate = 517,
    envpartsrange = 519,
    envpartsgriddata = 521,
    environmentvibration = 525,
    navbuildareaparam = 527,
    navbuildparkourparam = 529,
    motionblendspace2d = 531,
    deadeffect = 532,
    hitse = 536,
    mseqinput = 537,
    cartcameraparam = 538,
    cartcameramode = 539,
    propbase = 540,
    damagereactionsize = 542,
    damagereactionreplacement = 544,
    navimeshlinkpathparam = 546,
    systemassistdirector = 547,
    destructorparampreset = 548,
    envpartsobjectset = 551,
    mapchecklistelement = 552,
    directorchangebgmparam = 553,
    lockoncameraparam = 556,
    gimmicksituation = 557,
    uifonttype = 558,
    behavioreventactionset = 559,
    summonparts = 560,
    battlemessage = 561,
    animalgroupid = 563,
    collisionlayerpreset = 564,
    partyidleaction = 565,
    behavioreventactionsequence = 566,
    animalmapresidelist = 567,
    maptoanimaltable = 568,
    movespeedtype = 569,
    damagerate = 571,
    battlehudgroup = 572,
    behaviorlinkturnactionsequen = 573,
    bonamiklayer = 574,
    autoplaylayoutreferencer = 575,
    difficultylevel = 577,
    mergegrid = 578,
    tattoo = 580,
    mapdirectorflag = 581,
    behaviormoverailparam = 582,
    battlevoicecategory = 583,
    directoreventtasklist = 584,
    navbuildstagesetparam = 585,
    caption = 587,
    captionfreeword = 589,
    directorforwardmoveparam = 591,
    stagerank = 593,
    behavioridlebreakparam = 594,
    jumpparagraphtype = 595,
    fieldeventdirector = 596,
    title = 598,
    navsystemparam = 599,
    playrank = 600,
    spreaddroptable = 601,
    navrepulsorflag = 602,
    streamingobjectsize = 603,
    spreaddropvfx = 606,
    behaviorcorpsedecorateparam = 607,
    questtype = 608,
    sound = 609,
    summonlight = 611,
    smobdirector = 612,
    footprintset = 613,
    directoruserconditionparam = 615,
    mastsparam = 616,
    systemassisttimertalkitem = 617,
    shotcharge = 619,
    vfxenvattributeset = 620,
    extrudedlayer = 621,
    bnpcextrudedlayer = 622,
    directionalcomboaction = 623,
    motionplaytype = 625,
    achievement = 626,
    datatelemetrystats = 627,
    datatelemetryevent = 628,
    datatelemetryproperty = 629,
    datatelemetrystatsextraction = 630,
    datatelemetrystatsdatatype = 631,
    weaponcollision = 632,
    uipaddefine = 633,
    uikeydefine = 634,
    directorphasetag = 635,
    skill = 636,
    skillcategory = 637,
    gimmickelevatortype = 638,
    behaviorlinkmovetarget = 639,
    accessmessage = 640,
    gimmickaccessmessage = 642,
    behaviorlinkmoveparent = 643,
    uidialog = 644,
    vfxenvspeedtreeset = 645,
    summonpartspattern = 647,
    charatimelinepacklist = 649,
    layoutenpcinstance = 650,
    bahamutcastmegaflare = 653,
    dpscheck = 654,
    behaviorguidanceparam = 657,
    systemassistguidancepermissi = 658,
    buddycommand = 659,
    physicsobjectstomping = 660,
    gamemapmemorycheckpreset = 662,
    destinationmarkerparam = 664,
    optionalfacialmotion = 665,
    cameratransitiontype = 666,
    cameratransition = 667,
    letter = 668,
    systemmove = 672,
    physicsobjectsound = 673,
    collisionmaterialcolor = 674,
    autoattackselect = 675,
    autoattackcombo = 676,
    autoattackpack = 677,
    photocameraparam = 678,
    mainmenutab = 679,
    telemetryobject = 680,
    telemetrystat = 681,
    telemetryevent = 683,
    telemetryobjectset = 684,
    telemetrypropertyvalue = 685,
    uiarray = 686,
    telemetryeventdefinition = 687,
    telemetryproperty = 688,
    telemetrystatextraction = 689,
    emcorrectionparam = 690,
    telemetryachievement = 691,
    cameratransitionspeed = 692,
    debugjumpmarkertype = 693,
    guardresultslowparam = 695,
    guardresult = 696,
    guardreaction = 697,
    behaviorlookatactparam = 698,
    fieldeventtype = 699,
    battlenormalcamera = 700,
    replay = 701,
    globalwind = 702,
    titlecount = 703,
    cameraadjustpriority = 704,
    battletalksequence = 705,
    telemetryeventset = 706,
    resultcompletemessage = 708,
    behavioractormoverparam = 709,
    actorstate = 712,
    jumpparam = 713,
    destructorparam = 715,
    cutsceneconnectcharamovetype = 716,
    speakerset = 718,
    playvfxtriggerset = 719,
    cutsceneconnectfadetype = 720,
    cutsceneconnectfadecurvetype = 721,
    edgeemission = 722,
    cutsceneconnect = 723,
    cutsceneconnectcharamodetype = 725,
    cutsceneconnectcamerapreset = 727,
    attackcharge = 728,
    charatimelinepaccommonexist = 732,
    animalbehaviorparam = 733,
    directorbankitemid = 735,
    directornexscript = 737,
    battlelayoutinfo = 738,
    crystalelements = 739,
    animalbehaviortype = 740,
    partyfollow = 741,
    deadparam = 742,
    useimportantitemstodo = 743,
    cutsceneconnectcharaoffset = 744,
    cutsceneconnectcharatarget = 745,
    simpleeventcommandtype = 746,
    simpleeventpartyvisible = 747,
    simpleeventpartylocationset = 748,
    shoppastsight = 750,
    modelcamera = 751,
    idlecontrol = 753,
    questcutscenetimeline = 755,
    questcutscene = 756,
    mainpartytalksequence = 757,
    questpartytalksequence = 758,
    maindefaulttalksequence = 759,
    questdefaulttalksequence = 760,
    questsimpleeventsequence = 761,
    mainsimpleeventsequence = 762,
    autoattackexeccondition = 763,
    footwetness = 764,
    uifieldmap = 765,
    uifieldmapicon = 766,
    behavioreventidlestateparam = 767,
    icongroup = 768,
    simpleevent = 770,
    simpleeventlocationoffset = 771,
    synopsistimeline = 772,
    synopsis = 773,
    simpleeventemotion = 774,
    partyfollowdistance = 775,
    uihudtype = 776,
    simpleeventvibrateblendtype = 777,
    behavioreventdirector = 778,
    shoptalksequence = 779,
    uiparty = 780,
    simpleeventcommandarglabel = 781,
    mounttype = 782,
    missionbattledirector = 783,
    layoutcutdisappear = 786,
    simpleeventmarkerpoint = 787,
    cutsceneconnectmarkerpoint = 788,
    shopmythril = 789,
    bonamikparam = 790,
    orchestrion = 791,
    partyfollowback = 792,
    leveleventcamera = 793,
    gamepreset = 794,
    areadefine = 795,
    triggereffect = 796,
    lorecommentarymode = 797,
    loredictionary = 799,
    loredictionarycategory = 800,
    loreworldviewnavigation = 803,
    cameraadjustparam = 804,
    behaviordynamicthinkset = 805,
    partyfollowspeed = 806,
    commandactionset = 807,
    simpleeventlightpreset = 808,
    questchara = 809,
    questcharalayout = 810,
    simpleeventchoiceset = 811,
    animpacexistface = 812,
    animpacexisthead = 813,
    layoutsettings = 814,
    vfxenvsplashtable = 815,
    phoenixshiftmove = 816,
    generallipsync = 817,
    simpleeventtype = 818,
    charasituation = 819,
    directorshipswingparameter = 822,
    directormovecustomspeedparam = 823,
    questcharalayoutbnpc = 824,
    questcharalayoutenpc = 825,
    customspeed = 826,
    telemetrynotificationtype = 828,
    simpleeventselect = 829,
    simpleeventsequencerandomset = 830,
    charatimelinepacweaponexist = 831,
    mapdirectorsequenceaction = 832,
    playermovedetectparam = 833,
    simpleeventnpcinvisibletype = 834,
    directorstaticsavelist = 837,
    hitreactionlayer = 838,
    telemetryactivity = 843,
    uipage = 844,
    gamemapprofilingreferencer = 845,
    navbuildimageparam = 846,
    brooch = 847,
    simpleeventchoiceansweropt = 848,
    directorgenerateparam = 850,
    skilluicategory = 851,
    uimenu = 852,
    guidancecameraparam = 853,
    sensor = 854,
    fixedpalettedirector = 855,
    shopfixedpaletteaccess = 856,
    graphicscloudsettings = 857,
    questdiscardlist = 858,
    fixedpalette = 859,
    fixedpalettestage = 860,
    fixedpaletteachievementbonus = 861,
    fixedpalettechainbonus = 862,
    fixedpalettetodo = 863,
    directorgraphicssetting = 864,
    shopfixedpaletteexit = 866,
    shopfixedpalettewarp = 867,
    fixedpalettebonustype = 868,
    fixedpaletterepeatbonus = 869,
    useitem = 870,
    icondiscovery = 871,
    fixedpaletteplayerstatus = 872,
    fixedpaletteattackcategory = 873,
    uireelparam = 874,
    scorebonus = 875,
    simpleeventfadelayertype = 876,
    accessadaptivetrigger = 877,
    famevalueshoptable = 879,
    accessholdparam = 880,
    mapsettings = 883,
    directorbattletargetlist = 884,
    adaptivetrigger = 885,
    collection = 886,
    uibuddyrank = 888,
    fixedpaletteresultrank = 889,
    triggergimmickcamera = 891,
    uifocusinfo = 892,
    directorbattleuiinfo = 893,
    uicharactersicon = 895,
    uicharactersline = 897,
    sevoiceset = 898,
    guarddata = 899,
    telemetryachievementgrade = 900,
    bardssonglist = 902,
    uicharacterslinetype = 903,
    weaponattachsheath = 904,
    bgmmagiparam = 905,
    loredictionaryalias = 910,
    loredictionarylevel = 911,
    loredictionaryrarity = 912,
    loredictionaryexp = 913,
    uicharactersrange = 914,
    talkdelaydefine = 915,
    partyfollowspeedlimit = 916,
    bnpccollisioncheckpreset = 917,
    directorquestmasktag = 919,
    shopquestcounter = 921,
    shopfamevalue = 922,
    shoplore = 923,
    shopchronicle = 924,
    battlescoreattackcategory = 927,
    battlescorebonus = 928,
    uiattributive = 930,
    uimenulayer = 931,
    uiannounce = 932,
    battlescorebonuslevel = 933,
    mapchecklistpartysetting = 934,
    chancedowndamagerate = 935,
    bgmchangedefine = 937,
    layoutmarkersettings = 938,
    layoutrangesettings = 939,
    bnpcmemorycheckpreset = 940,
    enpcmemorycheckpreset = 941,
    uitooltip = 942,
    partyidleactioncooldowngroup = 943,
    simpleeventchoice = 944,
    uigamma = 945,
    directorbattleuitype = 946,
    accessdoorcamera = 948,
    layoutrangedebugcategory = 949,
    loreworldviewnavigationscale = 950,
    debugcharapresetlayout = 951,
    debugcharapresetlayoutmarker = 952,
    loredictionarytag = 953,
    loredictionarypickup = 955,
    layoutcutnamedinstance = 957,
    lorecutmreference = 958,
    lorecutqreference = 959,
    lorequestsequencecondition = 960,
    battlescoreachievedifficulty = 961,
    uisituationmap = 962,
    autoplaygamestate = 964,
    fixedpalettedifficultylevel = 966,
    gimmickcommand = 967,
    rankingtype = 968,
    ranking = 969,
    mergegridspeedtree = 970,
    fieldmapdiscoverymask = 971,
    autoplaysystemparam = 973,
    uifieldmapdiscoverymask = 974,
    areatype = 975,
    itempresettable = 976,
    playerpresettable = 977,
    uisituationmapperiodpickup = 978,
    loredictionarychain = 979,
    partyfollowspeedlimitgroup = 980,
    itemgrade = 981,
    itemset = 982,
    actionlog = 983,
    uijournalseparator = 985,
    gamemapfieldtype = 986,
    scoreattackplayerset = 988,
    scoreattackmode = 989,
    gamemapsafety = 990,
    scoreattack = 991,
    scoreattackitemsetindex = 992,
    battlescoreminus = 993,
    trainingenemy = 994,
    uiphotoevent = 995,
    simpleeventchoiceuitype = 996,
    uisituationmapacttype = 997,
    uicharactersacttype = 998,
    characterskincategory = 999,
    characterskinmodelparam = 1000,
    weaponskincategory = 1001,
    uisituationmapcategory = 1002,
    uisituationmaplargecategory = 1003,
    scoreattacksectionscoreset = 1005,
    behaviorjumpparam = 1006,
    uicharacterslargecategory = 1008,
    dlcitem = 1009,
    seadexternalparameter = 1010,
    uichronicleperiod = 1011,
    uichronicleacttype = 1012,
    fieldmapobelisk = 1013,
    autoplayquestlist = 1014,
    autoplayquestdata = 1015,
    navimageareadat = 1016,
    uisummonaction = 1017,
    dlcentitlement = 1019,
    partylookat = 1020,
    dlcpathlist = 1021,
    layoutpickupinstance = 1022,
    uishophowto = 1025,
    partyidleactionreplacement = 1026,
    accesseffecttrigger = 1027,
    uicharactersperiodpickup = 1028,
    autoplaycustomactiondefine = 1029,
    navbuildmaplayerparam = 1030,
    uisituationmapusageguide = 1031,
    uimainmenumode = 1032,
    scoreattackstagerank = 1033,
    howtoset = 1034,
    talkdistancedelaydefine = 1036,
    loredictionarytagcategory = 1037,
    uisituationmapresourcedefine = 1038,
    autoplaytestcase = 1040,
    uicharactersgroup = 1041,
    soundreverbparam = 1042,
    uimemorandumsearchname = 1043,
    uimainmenuprogress = 1044,
    collisiontracelayer = 1045,
    collisionobjectlayer = 1046,
    uifixedpalettecountdisp = 1047,
    mapfixedcamera = 1048,
    uicredit = 1049,
    autoplaysubquest = 1050,
    toolsfaithmapscapturepreset = 1051,
    uicreditbackgroundimage = 1052,
    partyfollowposition = 1053,
    contentreward = 1054,
    uicreditcutscene = 1055,
    clipuidefine = 1056,
    loresynopsisreference = 1057,
    partywarpposition = 1058,
    directorstagesetlist = 1059,
    enpcdecorateparam = 1060,
    layoutresidentlist = 1061,
    directorstagesetphaseparam = 1062,
    uifieldmapicondefine = 1063,
    autoplaysituationcommand = 1064,
    loreworldviewnavigationcat = 1065,
    mountchocoboweaponattacheid = 1067,
    leviathanrocketlauncher = 1068,
    bnpcparamrate = 1070,
    uipadguide = 1071,
    lightshakingparam = 1072,
    loreworldviewnavistartuptype = 1073,
    ultimamodeshot = 1074,
    uidamagepopup = 1076,
    debugwindowstring = 1077,
    uisituationmapparty = 1078,
    uisituationmapdesign = 1079,
    partyfollowformation = 1080,
    uicharactersobjectiveline = 1081,
    simpleeventuitypeoptionarg = 1084,
    gamemapbuildresult = 1085,
    telemetryarray = 1086,
    telemetryachievementstory = 1087,
    obelisk = 1088,
    simpleeventseadevent = 1089,
    uisituationmapiconparts = 1090,
    simpleeventbgmvolume = 1091,
    weaponscaleparam = 1092,
    uistoreinduction = 1093,
    aiactionselectorcondition = 1094,
    gimmicktreasureboxparam = 1095,
    cutsceneconnectblooddefine = 1096,
    uisituationmapbezierline = 1097,
    preloadhowto = 1098,
    abyssgatedirector = 1099,
    abyssgate = 1100,
    partyobstacle = 1101,
    autoplaypersonalquest = 1102,
    simpleeventlightpresetselect = 1103,
    characterskinid = 1104,
    abysseffect = 1105,
    cutsceneconnectquestseqarg = 1106,
    uichronicleiconparts = 1108,
    uibuddyaction = 1109,
    loredictionaryenemycategory = 1110,
    cutsceneoptimize = 1111,
    layoutstaticlistforcutscene = 1112,
    partyfollowspeedplayer = 1113,
    abyssgateplayerstatus = 1114,
    abyssgaterating = 1115,
    cutsceneoptimizemodel = 1117,
    abyssgateshoplist = 1118,
    patchdlcversion = 1119,
    performancemodesetting = 1122,
    performancemodesettingparam = 1123,
    abyssgatecontentslevel = 1125,
    resultfade = 1126,
    uicharacterslinesetting = 1127,
    uicharacterslinedesign = 1128,
    abyssgatestage = 1129,
    autovfxprofilertestcase = 1131,
    directorfaketargetsettings = 1132,
    abyssgatestagesetsetting = 1133,
    envvoice = 1134,
    uicredittitledlc = 1135,
    uicredittitleoriginal = 1136,
    loreworldviewnavigationstype = 1137,
    uicredittitledlc2 = 1143,
    uicredittitledlc3 = 1144,
    uicredittitledlc2_dlc3 = 1145,
    uicreditpc = 1146,
    directorgenerateheatmap = 1147,
    directorgenerateheatmapinfo = 1148,
    uipadconfigcategory = 1149,
    uipadconfig = 1150,
    uikeyconfig = 1151,
    uiphotomodeparam = 1152,
    abyssgatetimebonus = 1153,
    uilodlevelconfig = 1155,
    battlescoretechnicalbonus = 1157,
    scoreattackversion = 1158,
    uifilepathexchange = 1159,
    telemetryleaderboardversion = 1160,
    abyssboost = 1161,
    abyssboostparam = 1162,
    graqualitypresetsettingparam = 1164,
    uiresolutionconfig = 1165,
    graqualitypreset = 1166,
    dynamicwavesetting = 1167,
    dynamicwaveparam = 1169,
    questreportjump = 1170,
    graclutterquality = 1171,
    graterrainquality = 1172,
    gratexturequality = 1173,
    grawaterquality = 1175,
    grashadowquality = 1176,
    gralevelofdetailquality = 1178,
    uikeyboardlayout = 1179,
    uikeyboardswap = 1180,
    uiabyssboostcategory = 1181,
    gralodocclusioncullingtype = 1182,
    grasrupscalepreset = 1192,
    grasrupscalealgorithm = 1193,
    graqualitypresetsrsettingpar = 1196,
    graqualitypresetsrsetting = 1198,
    graqualitypresetsrtype = 1199,
    grasrframegeneration = 1200,
    uileaderboard = 1201,
    telemetryobjectconverttable = 1202,
    uiframelimitconfig = 1203,
    gramotionblurintensity = 1204,
    graenablessr = 1207,
    graenablebloomeffect = 1208,
    graenableambientocclusion = 1209,
    graenablechromaticaberration = 1210,
    graqualitypresetoverridesetting = 1211,
    graframeraterational = 1212,
    bnpcignorecollision = 1214,
    graenablevignette = 1215,
    uicredithermia = 1216,
    gravariablerateshading = 1218,
    grastreamingcorrectiontype = 1219,
    grasradaptivedr = 1220,
    razerevent = 1222
}