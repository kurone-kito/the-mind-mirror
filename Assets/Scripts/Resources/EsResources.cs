using UdonSharp;

/// <summary>スペイン語テキスト リソース群。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class EsResources : FallbackResources
{
    /// <summary>今後の解説拡充予告のメッセージ。</summary>
    public override string ComingSoon =>
         "¡En el futuro añadiremos más resultados clarividentes!";

    /// <summary>性格の大分類の説明。</summary>
    public override string GeniusDescription =>
        $"Hay tres tipos principales de personalidad humana: “{GeniusTypes[(int)TypeGenius.Authority]}”, “{GeniusTypes[(int)TypeGenius.Economically]}”, y “{GeniusTypes[(int)TypeGenius.Humanely]}”.";

    /// <summary>性格の大分類の見出し。</summary>
    public override string GeniusHeading =>
        "Principales categorías de personalidad";

    /// <summary>性格の大分類の種別ごとの見出し。</summary>
    public override string[] GeniusTypes =>
        new[]
        {
            "Centrados en la autoridad",
            "Centrados en la economía",
            "Centrados en el ser humano",
        };

    /// <summary>性格の大分類の種別ごとの説明。</summary>
    public override string[][] GeniusTypesDescriptions =>
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
