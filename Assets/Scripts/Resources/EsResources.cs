using UdonSharp;

/// <summary>スペイン語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class EsResources : FallbackResources
{
    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public override string ComingSoon =>
         "¡En el futuro añadiremos más resultados clarividentes!";

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

    /// <summary>
    /// 空のマインドキューブを挿入した際の、警告メッセージ。
    /// </summary>
    public override string WarnOnInsertTheEmptyMindCube =>
         @"El Cubo de la Mente, utilizado para la clarividencia de su personalidad, está <b>vacío</b>.
Dado que la clarividencia es imposible en este estado, por favor escriba su información en el Escritor Mental de la sala anterior e inténtelo de nuevo.";

    /// <summary>見出しサイズ。</summary>
    public override int SizeHeading => 320;

    /// <summary>ページ番号のテンプレート。</summary>
    public override string TemplatePages => "Páginas: {0}/{1}";

    /// <summary>各項目における、タイプ見出しのテンプレート。</summary>
    public override string TemplateYourTypeIs =>
        "¡Tu tipo es“<b>{0}</b>”!";

    /// <summary>言語種別。</summary>
    public override TypeLanguage Type => TypeLanguage.Spanish;
}
