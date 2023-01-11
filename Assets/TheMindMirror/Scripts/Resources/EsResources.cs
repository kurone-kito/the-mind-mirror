using UdonSharp;

/// <summary>スペイン語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class EsResources : FallbackResources
{
    /// <summary>論理思考タイプの見出しメッセージ。</summary>
    public override string BrainDescription =>
        $"Según la persona, pueden dividirse en del tipo “{BrainTypeHeading[(int)TypeBrain.Left]}” o del tipo “{BrainTypeHeading[(int)TypeBrain.Right]}”.";

    /// <summary>論理思考タイプの見出しメッセージ。</summary>
    public override string BrainHeading => "Métodos de reflexión";

    /// <summary>論理思考タイプのタイプ別コピー。</summary>
    public override string[] BrainTypeCopy =>
        new[]
        {
            "Son excelentes en pensamiento <b>lógico</b>.",
            "Son excelentes en el pensamiento <b>intuitivo</b>.",
        };

    /// <summary>論理思考タイプのタイプ別解説。</summary>
    public override string[][] BrainTypeDetails =>
        new[]
        {
            new[]
            {
                "Aunque se les da bien pensar basándose en números y datos, tienden a confundirse en situaciones incoherentes.",
                "Tienden a ceñirse a las pruebas numéricas y no se les da bien trabajar de forma intuitiva.",
            },
            new[]
            {
                "Aunque son <b>buenos en el uso de la imaginación</b>, como en la lluvia de ideas, tienden a ignorar las pruebas y a moverse primero con la intuición.",
                "En <b>situaciones complicadas</b>, son <b>fáciles de dejar de pensar</b>.",
            },
        };

    /// <summary>論理思考タイプのタイプ別名称。</summary>
    public override string[] BrainTypeHeading =>
        new[] { "Pensamiento zurdo", "Pensamiento cerebral derecho" };

    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public override string ComingSoon =>
        "¡En el futuro añadiremos más resultados clarividentes!";

    /// <summary>対話思考タイプの見出しメッセージ。</summary>
    public override string CommunicationDescription =>
        $"Dependiendo de la persona, pueden dividirse en el tipo “{CommunicationTypeHeading[(int)TypeCommunication.Fix]}” o el tipo “{CommunicationTypeHeading[(int)TypeCommunication.Flex]}”.";

    /// <summary>対話思考タイプの見出しメッセージ。</summary>
    public override string CommunicationHeading => "Formas de pensar en el diálogo";

    /// <summary>対話思考タイプのタイプ別コピー。</summary>
    public override string[] CommunicationTypeCopy =>
        new[]
        {
            "Hacen un diálogo que prosigue con una conclusión.",
            "Son buenos concluyendo <b>fluidamente</b>.",
        };

    /// <summary>対話思考タイプのタイプ別解説。</summary>
    public override string[][] CommunicationTypeDetails =>
        new[]
        {
            new[]
            {
                "Tienden a racionalizar y a hacerse entender.",
                "Se sienten aliviados cuando las cosas están claramente definidas, como el tiempo y el lugar, pero tienden a sentirse inquietos cuando las cosas no están claras.",
            },
            new[]
            {
                "También tienden a utilizar el emocionalismo para transmitir su punto de vista.",
                "Pueden manejarse con ambigüedad en términos de tiempo, lugar, etc., pero <b>se sienten limitados cuando se trata de claridad</b>.",
            },
        };

    /// <summary>対話思考タイプのタイプ別名称。</summary>
    public override string[] CommunicationTypeHeading =>
        new[] { "<b>Arreglo</b>: orientado a la clarificación", "<b>Flex</b>: orientado a la liquidez" };

    /// <summary>素質の解説。</summary>
    public override string DetailedGeniusDescription =>
        "Una personalidad más detallada e innata. Se clasifica en 12 tipos.";

    /// <summary>素質の見出し。</summary>
    public override string DetailedGeniusHeading => "Tipo de genio";


    /// <summary>各素質の解説。</summary>
    public override string[][] DetailedGeniusTypeDetails =>
        new[]
        {
            new[]
            {
                "Tienen una filosofía hiperlingüística y una visión del mundo extravagante. Algunos los describen como los sextos sentidos.",
                "Sin embargo, no son muy dinámicos y muchos de ellos se lo guardan en la cabeza.",
                "También es habitual que los tipos sensibles se vayan de viaje sin un plan y pierdan el contacto.",
            },
            new[]
            {
                "Les encanta actuar como bichos raros, sin dejarse contaminar por las ideas de los demás.",
                "Les gusta el individualismo y prefieren trabajar a su ritmo.",
                "Son los mejores actores para interpretar el papel de “idiota bien pensado”.",
            },
            new[]
            {
                "Tienen un temperamento juvenil, siempre como adolescentes, incluso cuando crecen.",
                "Les suele gustar discutir, pero suele ser una larga historia con poca sustancia.",
                "Aunque tienen muchas ganas de estar delante del público, también saben apoyar todo el proceso entre bastidores.",
            },
            new[]
            {
                "Cuando acaban de pensar en algo, son muy trabajadores y están decididos a terminarlo, pero no se les da bien planificar estrategias detalladas.",
                "Suelen ser apacibles, pero no pueden esperar a que ocurran las cosas.",
                $"Las personas “{GeniusTypesName[(int)TypeGenius.Authority]}”, en general, tienen el don de ser capaces de convertir la ansiedad en un motor para la acción, pero son especialmente hábiles en ello.",
                "Pueden memorizar y actuar como si ya supieran algo hace diez años, aunque acaben de aprenderlo por primera vez.",
            },
            new[]
            {
                "Tienen un sentimiento de hermandad con toda la humanidad y poseen cualidades para llevarse bien por igual y de igual a igual.",
                "Pero, por otro lado, como son “igual de amistosos”, siempre harán un cerco, incluso con los miembros de la familia.",
                "Suelen estar bien informados porque tienen muchos contactos.",
            },
            new[]
            {
                "Les gusta fingir que no son buenos en algo, pero quieren sorprender y destacar estando preparados.",
                "Tienden a encargarse de todo, intentando hacerlo por su cuenta.",
            },
            new[]
            {
                "A menudo son tan directos y honestos como un bebé.",
                "Son muy tímidos y se vuelven reticentes cuando se les arroja a un lugar lleno de extraños.",
            },
            new[]
            {
                "Tienen grandes sueños románticos.",
                "Además, al igual que los adultos mayores, tienen una visión a largo plazo de la vida y aptitudes para ser estoicos a corto plazo.",
            },
            new[]
            {
                "Muchas personas tienen un aire de competencia general y autoridad de jefe, como un empleado ejecutivo.",
                "Pueden acostumbrarse a algo más rápido que los demás, aunque no tengan experiencia.",
                "Pero se necesita un esfuerzo varias veces mayor que en otros tipos para convertirse en un experto en su campo. En otras palabras, son más adecuados para generalistas que para expertos.",
            },
            new[]
            {
                "Tienen el espíritu humilde y a la vez imponente de un presidente de empresa.",
                $"Tienen las cualidades cercanas al tipo “{GeniusTypesName[(int)TypeGenius.Authority]}”. Tienen pueden sopesar la autoridad de los demás y ver lo real.",
                "Tienen buen ojo para sopesar la autoridad de los demás y detectar la verdadera, y nunca dejan de perfeccionarse para que su autoridad sea más sólida.",
                "Aunque se les da bien ser héroes anónimos, también les gusta ponerse delante de la gente en el momento oportuno y descremarse.",
            },
            new[]
            {
                "Son como niños y niñas con una naturaleza desafiante, interesados en todas las direcciones.",
                "Muchos de ellos son tan contundentes que ni siquiera se dan cuenta de que han sido golpeados.",
            },
            new[]
            {
                "Aunque tienen una enorme capacidad de concentración, el resto del tiempo son siempre perezosos.",
                "Muchos de ellos tienen una fuerte disposición a hacer lo que haga falta para conseguir lo que quieren y la habilidad de regatear para conseguirlo.",
                "Son buenos negociadores y tienen madera de vendedores.",
            },
        };

    /// <summary>素質の見出し。</summary>
    public override string[] DetailedGeniusTypeName =>
        new[]
        {
            "Tipo el espiritual",
            "Tipo lobo solitario",
            "Tipo primeros adoptantes",
            "Tipo el esforzador",
            "Tipo el saintist",
            "Tipo el perfeccionismo",
            "Tipo el naturalismo",
            "Tipo el romántico",
            "Tipo el sin prisas",
            "Tipo el autoridad",
            "Tipo el Retador",
            "Tipo el Socialice",
        };

    /// <summary>各素質に対する、攻略法の解説。</summary>
    public override string[][] DetailedGeniusTypeStrategy =>
        new[]
        {
            new[]
            {
                "Odian cualquier restricción, esclavitud o regla.",
                "Cuando dicen “¡Entendido!”, tienden a no entender todavía la petición. Así que es buena idea consultarlo con ellos para evitar problemas más adelante.",
                "Si vas a hacer algo con un grupo de personas, lo mejor es ponerlas en situación de que se les pida que sean creativas.",
            },
            new[]
            {
                "No les gusta que los demás les sigan el ritmo, por lo que puede resultar difícil conocerlos a primera vista, pero serán amables con usted una vez que los conozca.",
                "En general, ver a la otra persona con ojos extraños se considera algo malo, pero son excepciones y se pueden utilizar como cumplidos.",
                "Por otro lado, palabras como “impersonal” o “sentido común” pueden ser malas palabras para ellos, así que ten cuidado.",
                "Cuando trabajan en grupo, rinden mejor cuando se les coloca en puestos que les exigen ser creativos.",
            },
            new[]
            {
                "“Es la última noticia” y “Nadie lo sabe todavía” son palabras poderosas para captar su atención.",
                "Por otro lado, las cosas desgastadas o estables pueden desalentar su interés.",
            },
            new[]
            {
                "Por lo general, no es buena idea enfadar a los demás, pero estas personas, de modales normalmente suaves, tienen la forma más espeluznante de enfadarse entre sus muchos tipos de personalidad.",
                "Son adecuados como coordinadores o directores interpersonales. Pero, por otro lado, si les das la responsabilidad de la planificación, producirán una serie de productos efímeros porque cambian sus creaciones con frecuencia debido a la ansiedad.",
                "Cuando se trabaja con ellos, conviene ser frecuente y minucioso en los informes, la comunicación y las consultas.",
            },
            new[]
            {
                "Es tabú intentar engañarles, dejarles fuera, saltarse su turno o hacer cualquier cosa que no sea honorable.",
                "Tienden a pensar que todos los implicados son igualmente responsables y difuminan sus responsabilidades de forma colectiva, por lo que es mejor seguirles la corriente.",
            },
            new[]
            {
                "Les influyen los halagos y el trato VIP.",
                "Les encanta sorprenderte, pero ten en cuenta que se quejarán de haber perdido prestigio si se lo niegas."
            },
            new[]
            {
                "Son fáciles de entender, ya que su personalidad cambia considerablemente antes y después de abrirse.",
                "Si les haces sentir a gusto, es fácil llevarse bien con ellos."
            },
            new[]
            {
                "Cuando les propongas cosas, es más fácil que confíen si antes hablas de los riesgos y los aclaras.",
                "Si les sugieres las cosas con humildad, tienden a influir fácilmente.",
                "Detestan las actitudes intrusivas desde arriba. Pueden llevarse bien con los que no lo son tanto y tienden a estresarte sin ni siquiera saberlo.",
            },
            new[]
            {
                "Pueden hacerlo todo solos, por lo que tienden a ocuparse de todo por su cuenta. Cuando les confíes algo, ten cuidado de no dejarles hacer demasiado.",
            },
            new[]
            {
                "Cuando te presentes a ellos, no seas modesto sobre tus logros. Te tomarán la palabra y no te tendrán en cuenta.",
                "Tienden a hablar de sí mismos durante mucho tiempo, por lo que es muy eficaz dirigir su conversación adecuadamente.",
                "Suelen mostrarse aprensivos en lugares en los que no tienen autoridad, como un evento al que asisten por primera vez. Sin embargo, si les acompaña, le reconocerán como la “autoridad” en la situación y le seguirán.",
                "Evita negarles su experiencia sin rodeos. Aunque su experiencia sea errónea, se enfadarán.",
            },
            new[]
            {
                "Debido a su dureza, puede ser una buena idea confiarles puestos que podrían inquietarles si se dejaran en manos de otros, además de ser vendedores.",
            },
            new[]
            {
                "Es más fácil abrirse a ellos si limitas las formalidades al primer encuentro y creas un ambiente divertido la próxima vez que os veáis.",
                "Son holgazanes, pero cuando están motivados, realizan una enorme cantidad de trabajo. Por eso es fundamental dejarles hacer su trabajo sin indicarles detalladamente cómo hacerlo.",
            },
        };

    /// <summary>素質のキャッチコピー。</summary>
    public override string[] DetailedGeniusTypeSummary =>
        new[]
        {
            "Prefieren vagar sin rumbo y utilizar la intuición aguda y los destellos de inspiración",
            "Las palabras “excéntrico”, o “raro” son un cumplido para ellos. Hacen a su manera como un lobo solitario",
            "Son primeros adopters a los que les encanta lo nuevo y persiguen la frescura cada día",
            "Son impacientes y tienen un fuerte impulso",
            "Son personas que aman a los demás y son personalidades bien informadas",
            "Son severos y testarudos, ¡como un hombre de negocios de primera que no muestra debilidad!",
            "Son tímidos, pero una vez que te acostumbras a ellos, son honestos hasta la exageración",
            "Sin rival en sueños y autodisciplina. Directo a la meta a largo plazo",
            "Equilibrada, capaz y solidaria, una posición heroica",
            "Una persona con talento que sabe dividir los papeles respetando los logros y la experiencia",
            "Son ingenuos y curiosos. No les importa si algo no funciona; seguirán intentándolo",
            "Son buenos negociadores y prefieren la estrategia a corto plazo",
        };


    /// <summary>各素質における、弱点の解説。</summary>
    public override string[][] DetailedGeniusTypeWeakness =>
        new[]
        {
            new[]
            {
                "Tienden a desordenar sus notas, las carpetas de sus escritorios, las habitaciones y todo lo demás si no son conscientes.",
                "Suelen tener un fuerte vínculo entre sus emociones y su rendimiento. En otras palabras, si no están en el estado de ánimo adecuado, no progresarán.",
            },
            new[]
            {
                "Suelen hacerlo a su manera y no son muy ingeniosos.",
                "No les gusta dejarse arrastrar por el ritmo de los demás y pueden imponer su propio ritmo a los demás.",
            },
            new[]
            {
                "Siempre les gustan las cosas nuevas, pero para ellos dejan de serlo cuando ya lo saben todo. Por eso, tienden a aburrirse rápidamente.",
                "Si tienen problemas para empezar, tienden a perder la motivación incluso para las cosas necesarias.",
                "Odian intensamente que se les obligue a actuar o se les enfade delante del público.",
                "Muchas personas dicen que “Schadenfreude, Sentir placer en la miseria de los demás”. Pero ellos son diferentes, y lo odian.",
            },
            new[]
            {
                "Son impacientes y tienden a ponerse nerviosos si no reciben informes detallados de sus progresos.",
                "No se les suelen dar bien los cálculos detallados ni quedarse parados.",
            },
            new[]
            {
                "Tienen un fuerte sentido de la camaradería, por lo que cuando alguien que conocen se mete en problemas, tienden a meterse en problemas con ellos.",
                "Su juicio empieza a debilitarse porque tienden a recoger demasiada información de su entorno.",
            },
            new[]
            {
                "Tienden a ser duros consigo mismos y con los demás y les preocupa demasiado la opinión pública como para emprender acciones desafiantes.",
                "Les influyen los halagos y el trato VIP.",
                "Cuando colaboras con alguien, tomar atajos suele ser malo, pero hacerlo con él te enfadará especialmente.",
            },
            new[]
            {
                "Tienden a limitarse a su esfera de actividad y a permanecer en su caparazón.",
                "Tienden a ser demasiado honestos en sus posiciones de origen, como en las redes sociales, y muchos de ellos se vuelven verbalmente abusivos y excesivamente familiares incluso entre sus amigos.",
                "Una vez que bajan la guardia, pueden confiar demasiado en la otra persona sin necesidad.",
            },
            new[]
            {
                "Son escépticos y tienden a ser lentos a la hora de asumir las cosas.",
                "La reflexión es fundamental, pero para ellos puede conducir al arrepentimiento por exceso.",
            },
            new[]
            {
                "No les gusta disculparse aunque sea por su culpa. Aunque se hayan disculpado, no saben expresarlo muy bien.",
                "Quizá porque pueden hacerlo todo por sí mismos, tienden a sentirse incómodos cuando los demás no pueden, preguntándose por qué ellos no pueden hacer esas cosas.",
                $"Tienden a encargarse de todo en un intento de hacerlo por sí solos y, como resultado, su eficacia disminuye. Lo mismo ocurre con el “{DetailedGeniusTypeName[(int)TypeDetailedGenius.A100]}”, pero como el “{DetailedGeniusTypeName[(int)TypeDetailedGenius.E555]}” tiene la destreza de hacer tanto por su cuenta, a menudo no se da cuenta de que su rendimiento está disminuyendo.",
            },
            new[]
            {
                "Tienden a centrarse en los logros y la autoridad, ya sean propios o ajenos, por lo que tienden a sobrevalorarse.",
                "En general, los comportamientos insensibles y poco amables no son buenos, pero esto les desagrada especialmente.",
            },
            new[]
            {
                "Sus intereses no duran mucho y no suelen ser buenos negociadores a largo plazo.",
                "Suelen cambiar de tema con frecuencia. Pero otros suelen querer prolongar el tema un poco más, por lo que pueden incomodar a los demás.",
            },
            new[]
            {
                "Suelen sentirse incómodos con el ambiente formal y la actitud poco clara.",
                "Tampoco son muy buenos a la hora de producir resultados estables a largo plazo.",
            },
        };

    /// <summary>性格の大分類の説明。</summary>
    public override string GeniusDescription =>
        $"Hay tres tipos principales de personalidad humana: “{GeniusTypesName[(int)TypeGenius.Authority]}”, “{GeniusTypesName[(int)TypeGenius.Economically]}”, y “{GeniusTypesName[(int)TypeGenius.Humanely]}”.";

    /// <summary>性格の大分類の見出し。</summary>
    public override string GeniusHeading =>
        "Principales categorías de personalidad";

    /// <summary>性格の大分類の種別ごとの見出し。</summary>
    public override string[] GeniusTypesName =>
        new[]
        {
            "Centrados en la autoridad",
            "Centrados en la economía",
            "Centrados en el ser humano",
        };

    /// <summary>性格の大分類の種別ごとの説明。</summary>
    public override string[][] GeniusTypesDetails =>
        new[]
        {
            new[]
            {
                "Tienen un ego subyacente <b>por su autoridad</b> y una personalidad que <b>persigue su potencial futuro</b>.",
                $"No pueden escuchar conversaciones largas. En cuanto deciden que algo no es esencial, dejan descaradamente de escuchar la conversación, como jugar con sus teléfonos o dormitar.",
                $"Las personas que coleccionan artículos de marca para vestir a su autoridad suelen tener este tipo de personalidad.",
                "Suelen tener ansiedades vagas y difíciles de concretar y tienden a trasladarlas a su fuerza motriz.",
            },
            new[]
            {
                "Este tipo de personalidad es la que persigue la eficacia, con el ego subyacente de <b>sacar provecho de la propia riqueza</b>.",
                "Suelen estar orientados a las especificaciones y tienden a no respetar las marcas. Sin embargo, algunas personas consideran que las marcas son una especie de especificaciones y les dan importancia.",
                $"<b>No pueden escuchar conversaciones largas</b> muy bien. Así que intentan comprender <b>sólo los puntos principales</b> y tienden a pensar o decir, <b>“en pocas palabras... ”</b>.",
            },
            new[]
            {
                "Persiguen la socialidad con un ego para <b>mejorar su virtud</b>.",
                "Tienden a fijarse en la personalidad en muchas cosas. Por ejemplo, al elegir un producto en una tienda o algo así, tienden a decidir basándose en el carácter del vendedor que en su calidad.",
                $"Suelen <b>ser capaces de escuchar conversaciones largas</b> de principio a fin con una sonrisa. Sin embargo, <b>no siempre entienden lo esencial</b>.",
                "Si sólo vas al grano brevemente, se quedarán con la curiosidad de la introducción, el desarrollo de la historia y no entenderán el resto.",
            },
        };

    /// <summary>性格の大分類の種別ごとの攻略法。</summary>
    public override string[][] GeniusTypesStrategies =>
        new[]
        {
            new[]
            {
                $"Existe una relación como de piedra-papel-tijera entre el tipo “{GeniusTypesName[(int)TypeGenius.Authority]}”, el tipo “{GeniusTypesName[(int)TypeGenius.Economically]}” y el tipo “{GeniusTypesName[(int)TypeGenius.Humanely]}”. Es más fácil hablar con el tipo “{GeniusTypesName[(int)TypeGenius.Humanely]}” que con el tipo “{GeniusTypesName[(int)TypeGenius.Economically]}”.",
                "Cuando te dirijas a alguien para una charla, es más fácil llegar a él si examinas de antemano los puntos esenciales y los explicas haciendo <b>gran hincapié en su impacto</b>.",
                "Tienen el poder de actuar en función de sus inseguridades. Así que <b>el método del palo y la zanahoria</b>, en el que les provocas ansiedad y luego les propones beneficios, es convincente.",
                "Also, if you appeal to them <b>to increase their authority</b>, they are more likely to be influenced.",
            },
            new[]
            {
                $"Existe una relación como de piedra-papel-tijera entre el tipo “{GeniusTypesName[(int)TypeGenius.Authority]}”, el tipo “{GeniusTypesName[(int)TypeGenius.Economically]}” y el tipo “{GeniusTypesName[(int)TypeGenius.Humanely]}”. Es más fácil hablar con el tipo “{GeniusTypesName[(int)TypeGenius.Authority]}” que con el tipo “{GeniusTypesName[(int)TypeGenius.Humanely]}”.",
                "Al darles una charla, es más fácil que la superen si <b>examinamos previamente los puntos esenciales</b> y presentamos brevemente los puntos principales, dejando el resto para preguntas y respuestas o repartiendo material.",
                "Parecen <b>enfadarse mucho</b> cuando <b>escuchan algo que les interesa</b>. Sin embargo, <b>sólo escuchan con seriedad</b> y <b>normalmente no se enfadan</b>, por lo que es esencial soportar el ambiente amargo cuando se habla con ellos.",
                "Son menos alérgicos a hablar de beneficios, así que está bien ir directamente al grano sin soltar prenda. Sin embargo, como suelen ser sagaces con los números, no les convencerás a menos que les aportes un modelo de negocio y pruebas convincentes.",
            },
            new[]
            {
                $"Existe una relación como de piedra-papel-tijera entre el tipo “{GeniusTypesName[(int)TypeGenius.Authority]}”, el tipo “{GeniusTypesName[(int)TypeGenius.Economically]}” y el tipo “{GeniusTypesName[(int)TypeGenius.Humanely]}”. Es más fácil hablar con el tipo “{GeniusTypesName[(int)TypeGenius.Economically]}” que con el tipo “{GeniusTypesName[(int)TypeGenius.Authority]}”.",
                "Cuando hables con ellos, te resultará más fácil entenderles si les explicas la historia <b>en orden</b>, con algunos <b>añadidos redundantes</b> cada vez.",
                "También tienden a escuchar sonriendo aunque no entiendan, por lo que es más conveniente pedir confirmación en los momentos cruciales.",
                "Tienen tendencia a dejarse influir fácilmente cuando se les elogia por su bondad y humanidad. Además, es más fácil persuadirles si se les habla con una causa que no sea por su propio bien, sino por el bien de las personas que les rodean.",
            },
        };

    /// <summary>人生観の解説。</summary>
    public override string LifeBaseDescription =>
        "Las personas también tienen un ego latente con el que nacen, además de las tres personalidades.";

    /// <summary>人生観の見出し。</summary>
    public override string LifeBaseHeading => "Visión de la vida";

    /// <summary>人生観のタイプ別名前一覧。</summary>
    public override string[] LifeBaseTypesName =>
        new[]
        {
            "me gustaría ser yo quien lo experimentara todo.",
            "me gustaría hacerlo inmediatamente cuando pienso.",
            "quisieran ser perfeccionistas.",
            "me gustaría ser honesto conmigo mismo",
            "me gustaría tenerlo todo al alcance de la vista.",
            "me gustaría ser un coleccionista con los pies en la tierra.",
            "le gustaría vivir como miembro de un grupo.",
            "me gustaría aprender de la sabiduría de mis pioneros.",
            "le gustaría ser siempre el líder del grupo.",
            "le gustaría ser un lobo solitario.",
        };

    /// <summary>リスク管理思考タイプの見出しメッセージ。</summary>
    public override string ManagementDescription =>
        $"Dependiendo de la persona, pueden dividirse en el tipo “{ManagementTypeHeading[(int)TypeManagement.Care]}” o el tipo “{ManagementTypeHeading[(int)TypeManagement.Hope]}”.";

    /// <summary>リスク管理思考タイプの見出しメッセージ。</summary>
    public override string ManagementHeading => "Ventajas e inconvenientes";

    /// <summary>リスク管理思考タイプのタイプ別コピー。</summary>
    public override string[] ManagementTypeCopy =>
        new[]
        {
            "Tienen buen ojo para <b>ver los costes y riesgos</b> de las oportunidades.",
            "Tienen un ojo excelente para ver las oportunidades significativas que se esconden detrás de las oportunidades.",
        };

    /// <summary>リスク管理思考タイプのタイプ別解説。</summary>
    public override string[][] ManagementTypeDetails =>
        new[]
        {
            new[]
            {
                "Son pesimistas y tienden a ser personas muy precavidas.",
                "Buscan lo que pueden hacer eliminando lo que no pueden hacer, por lo que, aunque rara vez cometen grandes errores, tienden a perder oportunidades importantes.",
                "Tendemos a darles una impresión negativa, pero muchos pueden ser positivos porque saben afrontar los riesgos una vez que los conocen.",
            },
            new[]
            {
                "También tienden a <b>ser optimistas e imprudentes</b>.",
                "Aunque no tienen miedo al fracaso, cometen un gran error y nunca vuelven a intentarlo.",
                "Tendemos a tener una impresión positiva de ellos, pero <b>no están familiarizados con el riesgo y tienen vagos temores</b> que les llevan a <b>pensar negativamente</b>.",
            },
        };

    /// <summary>リスク管理思考タイプのタイプ別名称。</summary>
    public override string[] ManagementTypeHeading =>
        new[] { "<b>Cuidados</b>: El orientado al riesgo", "<b>Esperanza</b>: la empresa orientada" };

    /// <summary>潜在能力の説明。</summary>
    public override string PotentialDescription =>
        "Las personas tienen potenciales inherentes que pueden ejercer cuando actúan.";

    /// <summary>潜在能力の見出し。</summary>
    public override string PotentialHeading => "Capacidad potencial";

    /// <summary>潜在能力における、各タイプの追加解説。</summary>
    public override string[] PotentialTypeAdditional =>
        new[]
        {
            "También pueden crear de la nada y el potencial de sublimar el trabajo de otros.",
            "Por otro lado, no suelen ser buenos ordenando o desarrollando lo que ya existe.",
            "Este tipo de persona es a la vez un buen conversador y un buen oyente y tiene una capacidad equilibrada para hablar.",
            "Por otra parte, también saben escuchar y averiguar lo que piensa la otra persona.",
            "Sin embargo, no suelen ser buenos creando nuevos equipos o desarrollando y ampliando sus grupos.",
            "Son meticulosos, organizados, atentos y tienen una excelente capacidad de autogestión.",
            "No suelen ser buenos manteniendo grupos, e incluso cuando los crean, tienden a desaparecer espontáneamente.",
        };

    /// <summary>潜在能力における、各タイプの解説。</summary>
    public override string[][] PotentialTypeBase =>
        new[]
        {
            new[]
            {
                "Este tipo de persona posee una excelente capacidad de análisis y aplicación y tiene predisposición a dedicarse a una sola cosa a la vez.",
                "Tienen el poder del arreglo más que el de la originalidad.",
            },
            new[]
            {
                "Este tipo de persona tiene el potencial de perseguir una cosa sin descanso.",
                "También pueden crear algo de la nada y ser sensibles a lo nuevo.",
            },
            new[]
            {
                "Este tipo de persona puede expresarse piensa, de forma no verbal, como un artista.",
            },
            new[]
            {
                "Este tipo de persona puede expresarse activamente a través de las palabras.",
            },
            new[]
            {
                "Este tipo de persona tiene el potencial de ver el significado oculto tras los números.",
                "También intentan hacer las cosas con cuidado.",
            },
            new[]
            {
                "Este tipo de persona tiene potencial para expresar cosas con números y datos.",
            },
            new[]
            {
                "Este tipo de persona sabe escuchar y puede averiguar lo que piensa la otra persona.",
                "Entonces pueden hablar y transmitir sus intenciones a la otra persona.",
            },
            new[]
            {
                "Este tipo de persona es un hablador insistente que prefiere contar una historia a escucharla.",
                $"Además, aquellos cuya personalidad interior es “{DetailedGeniusTypeName[(int)TypeDetailedGenius.E001]}” tienden a ser dictatoriales.",
            },
            new[]
            {
                "Este tipo de persona tiene el potencial de mantener o solidificar interiormente un grupo u organización.",
                "Son personas organizadas, bien planificadas y con una excelente capacidad de autogestión.",
            },
            new[]
            {
                "Este tipo de persona tiene potencial para crear grupos y organizaciones y desarrollarlos hacia el exterior.",
                "También suelen ser personas muy cariñosas.",
            },
        };

    /// <summary>応対思考タイプの見出しメッセージ。</summary>
    public override string ResponseDescription =>
        $"Dependiendo de la persona, pueden dividirse en el tipo “{ResponseTypeHeading[(int)TypeResponse.Action]}” o el tipo “{ResponseTypeHeading[(int)TypeResponse.Mind]}”.";

    /// <summary>応対思考タイプの見出しメッセージ。</summary>
    public override string ResponseHeading => "Idoneidad para el trabajo";

    /// <summary>応対思考タイプのタイプ別コピー。</summary>
    public override string[] ResponseTypeCopy =>
        new[]
        {
            "Se centran en poner la energía en acción y sienten que su lugar está en la vanguardia de lo in situ.",
            "Valoran poner energía en pensar y consideran que desempeñar un papel entre bastidores es valioso.",
        };

    /// <summary>応対思考タイプのタイプ別解説。</summary>
    public override string[][] ResponseTypeDetails =>
        new[]
        {
            new[]
            {
                "Tienden a <b>actuar antes de pensar</b>.",
                "Un grupo de personas con el mismo tipo de personalidad que ellos en proporción dará la impresión de ser inestable pero activo.",
                "Aunque se les dan bien las apariciones en público, a muchos de ellos se les atraganta fácilmente el trabajo entre bastidores, como el trabajo de oficina, las manufacturas o el funcionamiento de las máquinas.",
            },
            new[]
            {
                "Son más del tipo que piensa antes de actuar.",
                "Un grupo con una proporción de su tipo de personas parecerá estancado, pero dará la impresión de tener los pies en la tierra y ser sólido.",
                "Aunque se les da bien el trabajo de oficina, la fabricación y el manejo de máquinas, no se les da bien reunirse en persona, y muchos de ellos se cansan fácilmente de trabajar en público.",
            },
        };

    /// <summary>応対思考タイプのタイプ別名称。</summary>
    public override string[] ResponseTypeHeading =>
        new[] { "Salir en público", "Trabajo entre bastidores" };

    /// <summary>3 種類の素質の名前。</summary>
    public override string[] ThreeTypedGeniusName =>
        new[] { "Interior", "Exterior", "Trabajo" };

    /// <summary>3 種類の素質の各解説。</summary>
    public override string[] ThreeTypedGeniusTypesDescription =>
        new[]
        {
            "la personalidad subyacente",
            "la personalidad que sale cuando no confías en la otra persona",
            "la personalidad cuando estás concentrado o en una emergencia",
        };

    /// <summary>3 種類の素質の解説。</summary>
    public override string[] ThreeTypedGeniusDescription =>
        new[]
        {
            "Una persona tiene 3 de estas personalidades, y la personalidad que emerge varía en función de la situación.",
            $"De ellos, “{ThreeTypedGeniusName[0]} representa la mayor parte de la personalidad de una persona."
        };

    /// <summary>3 種類の素質の見出し。</summary>
    public override string ThreeTypedGeniusHeading => "3 Genios";

    /// <summary>
    /// 空のマインドキューブを挿入した際の、警告メッセージ。
    /// </summary>
    public override string WarnOnInsertTheEmptyMindCube =>
         @"El Cubo de la Mente, utilizado para la clarividencia de su personalidad, está <b>vacío</b>.
Dado que la clarividencia es imposible en este estado, por favor escriba su información en el Escritor Mental de la sala anterior e inténtelo de nuevo.";

    /// <summary>
    /// 無効なマインドキューブを挿入した際の短いエラーメッセージ。
    /// </summary>
    public override string WarnOnInsertTheEmptyMindCubeShort =>
        "Cubo inválido";

    /// <summary>ページ番号のテンプレート。</summary>
    public override string TemplatePages => "Páginas: {0}/{1}";

    /// <summary> 各項目における、攻略法のテンプレート。</summary>
    public override string TemplateStrategy =>
        "Estrategias para el tipo “<b>{0}</b>”";

    /// <summary> 各項目における、弱点のテンプレート。</summary>
    public override string TemplateWeakness =>
        "Debilidades del tipo “<b>{0}</b>”";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public override string TemplateYourType => "Tu {0}";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public override string TemplateYourTypeIs =>
        "¡Tu tipo es“<b>{0}</b>”!";

    /// <summary>言語種別。</summary>
    public override TypeLanguage Type => TypeLanguage.Spanish;
}
