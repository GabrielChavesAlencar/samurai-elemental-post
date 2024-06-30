using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;


public static class Data {

    //public static string CURRENT_LANGUAGE = "br";
    public static CultureInfo currentCulture = CultureInfo.CurrentCulture;
    public static string languageName = currentCulture.Name;
    

    public static string CURRENT_LANGUAGE(){
        if (languageName == "pt-BR"|| languageName == "ru-RU" || languageName == "es-ES" 
            || languageName == "zh-CN" || languageName == "ja-JP" || languageName == "de-DE") { return languageName; }
        return "en-US";
    }

    public static Dictionary<string, Dictionary<string, string>> LOCALIZATION =
        new Dictionary<string, Dictionary<string, string>>()
        {
            { "play_key",new Dictionary<string,string>()
                {
                    {"en-US","Play Game" },
                    {"ru-RU","Играть" },
                    {"ja-JP","ゲームをする" },
                    {"es-ES","Jugar" },
                    {"zh-CN","玩游戏" },
                    {"de-DE","Spiel spielen" },
                    {"pt-BR","Jogar"}
                }
            }
            ,
             { "settings_key",new Dictionary<string,string>()
                {
                    {"en-US","Settings" },
                    {"ru-RU","Настройки" },
                    {"ja-JP","設定" },
                    {"es-ES","Ajustes" },
                    {"zh-CN","设置" },
                    {"de-DE","Einstellungen" },
                    {"pt-BR","Configurações"}
                }
            }
            ,
             { "shop_key",new Dictionary<string,string>()
                {
                    {"en-US","Shop" },
                    {"ru-RU","Магазин" },
                    {"ja-JP","ショップ" },
                    {"es-ES","Tienda" },
                    {"zh-CN","商店" },
                    {"de-DE","Geschäft" },
                    {"pt-BR","Loja"}
                }
            }
             ,
             { "album_key",new Dictionary<string,string>()
                {
                    {"en-US","Album" },
                    {"ru-RU","Альбом" },
                    {"ja-JP","アルバム" },
                    {"es-ES","Álbum" },
                    {"zh-CN","专辑" },
                    {"de-DE","Album" },
                    {"pt-BR","Álbum"}
                }
            }
              ,
             { "credits_key",new Dictionary<string,string>()
                {
                    {"en-US","Credits" },
                    {"ru-RU","Авторы" },
                    {"ja-JP","クレジット" },
                    {"es-ES","Créditos" },
                    {"zh-CN","制作人员" },
                    {"de-DE","Credits" },
                    {"pt-BR","Créditos"}
                }
            }
            ,
             { "exit_key",new Dictionary<string,string>()
                {
                    {"en-US","Exit" },
                    {"ru-RU","Выход" },
                    {"ja-JP","終了" },
                    {"es-ES","Salir" },
                    {"zh-CN","退出" },
                    {"de-DE","Beenden" },
                    {"pt-BR","Sair"}
                }
            }
             ,
             { "back_key",new Dictionary<string,string>()
                {
                    {"en-US","Back" },
                    {"ru-RU","Назад" },
                    {"ja-JP","戻る" },
                    {"es-ES","Volver" },
                    {"zh-CN","返回" },
                    {"de-DE","Zurück" },
                    {"pt-BR","Voltar"}
                }
            }
            ,
             { "team_key",new Dictionary<string,string>()
                {
                    {"en-US","Team" },
                    {"ru-RU","Команда" },
                    {"ja-JP","チーム" },
                    {"es-ES","Equipo" },
                    {"zh-CN","团队" },
                    {"de-DE","Team" },
                    {"pt-BR","Equipe"}
                }
            }
             ,
             { "start_key",new Dictionary<string,string>()
                {
                    {"en-US","Start" },
                    {"ru-RU","Старт" },
                    {"ja-JP","スタート" },
                    {"es-ES","Empezar" },
                    {"zh-CN","开始" },
                    {"de-DE","Starten" },
                    {"pt-BR","Começar"}
                }
            }
              ,
             { "master_key",new Dictionary<string,string>()
                {
                    {"en-US","Master Sound" },
                    {"ru-RU","Основной звук" },
                    {"ja-JP","マスター音量" },
                    {"es-ES","Sonido principal" },
                    {"zh-CN","主音量" },
                    {"de-DE","Master-Sound" },
                    {"pt-BR","Volume Principal"}
                }
            }
            ,
             { "music_key",new Dictionary<string,string>()
                {
                    {"en-US","Music" },
                    {"ru-RU","Музыка" },
                    {"ja-JP","音楽" },
                    {"es-ES","Música" },
                    {"zh-CN","音乐" },
                    {"de-DE","Musik" },
                    {"pt-BR","Música"}
                }
            }
             ,
             { "effects_key",new Dictionary<string,string>()
                {
                    {"en-US","Sound Effects" },
                    {"ru-RU","Звуковые эффекты" },
                    {"ja-JP","効果音" },
                    {"es-ES","Efectos de sonido" },
                    {"zh-CN","音效" },
                    {"de-DE","Soundeffekte" },
                    {"pt-BR","Efeitos Sonoros"}
                }
            }
             ,
             { "buy_key",new Dictionary<string,string>()
                {
                    {"en-US","Buy" },
                    {"ru-RU","Купить" },
                    {"ja-JP","購入する" },
                    {"es-ES","Comprar" },
                    {"zh-CN","购买" },
                    {"de-DE","Kaufen" },
                    {"pt-BR","Comprar"}
                }
            }
            ,
             { "unlock_key",new Dictionary<string,string>()
                {
                    {"en-US","UNLOCK" },
                    {"ru-RU","РАЗБЛОКИРОВАТЬ" },
                    {"ja-JP","アンロックする" },
                    {"es-ES","DESBLOQUEAR" },
                    {"zh-CN","解锁" },
                    {"de-DE","FREISCHALTEN" },
                    {"pt-BR","DESBLOQUEAR"}
                }

            }


            ,
             { "insectspe_key",new Dictionary<string,string>()
                {
                    {"en-US", "" },
                    {"ru-RU","" },
                    {"ja-JP","有効にするには"},
                    {"es-ES","" },
                    {"zh-CN","激活需要" },
                    {"de-DE", " " },
                    {"pt-BR",""}
                }
            }
             ,
             { "insectspe_key2",new Dictionary<string,string>()
                {
                    {"en-US"," insects to activate "},
                    {"ru-RU"," насекомых для активации"},
                    {"ja-JP","匹の昆虫" },
                    {"es-ES"," insectos para activar"},
                    {"zh-CN","个昆虫" },
                    {"de-DE","Insekten zum Aktivieren" },
                    {"pt-BR"," insetos para ativar"}
                }
            }
             ,
             { "feitos_key",new Dictionary<string,string>()
                {
                    {"en-US","Programming, Insect Art and Level Designer" },
                    {"ru-RU"," Программирование, дизайн насекомых и уровней" },
                    {"ja-JP","プログラミング、昆虫アート、レベルデザイナー" },
                    {"es-ES","Programación, arte de insectos y diseñador de niveles" },
                    {"zh-CN","编程、昆虫艺术和关卡设计" },
                    {"de-DE","Programmierung, Insektenkunst und Leveldesign" },
                    {"pt-BR","Programação, Arte de Insetos e Designer de Níveis"}
                }
            }
            ,
             { "background_key",new Dictionary<string,string>()
                {
                    {"en-US","Background" },
                    {"ru-RU","Фон" },
                    {"ja-JP","背景" },
                    {"es-ES","Fondo" },
                    {"zh-CN","背景" },
                    {"de-DE","Hintergrund" },
                    {"pt-BR","Plano de Fundo"}
                }

            }
            ,
             { "msefects_key",new Dictionary<string,string>()
                {
                    {"en-US","Music and sound effects" },
                    {"ru-RU","Музыка и звуковые эффекты" },
                    {"ja-JP","音楽と効果音" },
                    {"es-ES","Música y efectos de sonido" },
                    {"zh-CN","音乐和音效" },
                    {"de-DE","Musik und Soundeffekte" },
                    {"pt-BR","Música e efeitos sonoros"}
                }

            }
             ,
             { "menu_key",new Dictionary<string,string>()
                {
                    {"en-US","Menu" },
                    {"ru-RU","Меню" },
                    {"ja-JP","メニュー" },
                    {"es-ES","Menú" },
                    {"zh-CN","菜单" },
                    {"de-DE","Menü" },
                    {"pt-BR","Menu"}
                }

            }
            ,
             { "pause_key",new Dictionary<string,string>()
                {
                    {"en-US","Paused" },
                    {"ru-RU","Пауза" },
                    {"ja-JP","ポーズ中" },
                    {"es-ES","Pausado" },
                    {"zh-CN","已暂停" },
                    {"de-DE","Pausiert" },
                    {"pt-BR","Pausado"}
                }

            }
            ,
             { "continue_key",new Dictionary<string,string>()
                {
                    {"en-US","Continue" },
                    {"ru-RU","Продолжить" },
                    {"ja-JP","続ける" },
                    {"es-ES","Continuar" },
                    {"zh-CN","继续" },
                    {"de-DE","Fortsetzen" },
                    {"pt-BR","Continuar"}
                }

            }
             ,
             { "playagain_key",new Dictionary<string,string>()
                {
                    {"en-US","Play Again" },
                    {"ru-RU","Играть снова" },
                    {"ja-JP","もう一度プレイ" },
                    {"es-ES","Jugar de nuevo" },
                    {"zh-CN","再玩一次" },
                    {"de-DE","Nochmal spielen" },
                    {"pt-BR","Jogar Novamente"}
                }

            }
              ,
             { "next_key",new Dictionary<string,string>()
                {
                    {"en-US","Next" },
                    {"ru-RU","Далее" },
                    {"ja-JP","次へ" },
                    {"es-ES","Siguiente" },
                    {"zh-CN","下一个" },
                    {"de-DE","Weiter" },
                    {"pt-BR","Próximo"}
                }

            }
             ,
             { "win_key",new Dictionary<string,string>()
                {
                    {"en-US","You Win" },
                    {"ru-RU","Вы победили!" },
                    {"ja-JP","あなたの勝ちです" },
                    {"es-ES","¡Has ganado!" },
                    {"zh-CN","你赢了！" },
                    {"de-DE","Du hast gewonnen!" },
                    {"pt-BR","Você venceu!"}
                }

            }
             ,
             { "lose_key",new Dictionary<string,string>()
                {
                    {"en-US","You Lose" },
                    {"ru-RU","Вы проиграли" },
                    {"ja-JP","負けました" },
                    {"es-ES","Has perdido" },
                    {"zh-CN","你输了" },
                    {"de-DE","Du hast verloren" },
                    {"pt-BR","Você perdeu"}
                }

            }
            ,
             { "level_key",new Dictionary<string,string>()
                {
                    {"en-US","Level: " },
                    {"ru-RU","Уровень: " },
                    {"ja-JP","レベル: " },
                    {"es-ES","Nivel: " },
                    {"zh-CN","等级: " },
                    {"de-DE","Level: " },
                    {"pt-BR","Nível: "}
                }

            }
            ,
             { "post_key",new Dictionary<string,string>()
                {
                    {"en-US","Post-processing" },
                    {"ru-RU","Постобработка" },
                    {"ja-JP","ポストプロセス" },
                    {"es-ES","Postprocesamiento" },
                    {"zh-CN","后期处理" },
                    {"de-DE","Nachbearbeitung" },
                    {"pt-BR","Pós-processamento"}
                }
            }
             ,
             { "restart_key",new Dictionary<string,string>()
                {
                    {"en-US","Restart" },
                    {"ru-RU","Перезапуск" },
                    {"ja-JP","再起動" },
                    {"es-ES","Reiniciar" },
                    {"zh-CN","重新开始" },
                    {"de-DE","Neustart" },
                    {"pt-BR","Reiniciar"}
                }

            }
            ,
             { "press_key",new Dictionary<string,string>()
                {
                    {"en-US","Press" },
                    {"ru-RU","Нажмите" },
                    {"ja-JP","移動するには" },
                    {"es-ES","Presiona" },
                    {"zh-CN","按" },
                    {"de-DE","Drücke" },
                    {"pt-BR","Pressione"}
                }

            }
            ,
             { "or_key",new Dictionary<string,string>()
                {
                    {"en-US","or" },
                    {"ru-RU","или" },
                    {"ja-JP","または" },
                    {"es-ES","o" },
                    {"zh-CN","或" },
                    {"de-DE","oder" },
                    {"pt-BR","ou"}
                }

            }
            ,
             { "tomove_key",new Dictionary<string,string>()
                {
                    {"en-US","to move" },
                    {"ru-RU","чтобы двигаться" },
                    {"ja-JP","を押します" },
                    {"es-ES","para moverte" },
                    {"zh-CN","移动" },
                    {"de-DE","zum Bewegen" },
                    {"pt-BR","para mover"}
                }

            }
            ,
             { "press2_key",new Dictionary<string,string>()
                {
                    {"en-US","Press" },
                    {"ru-RU","Нажмите" },
                    {"ja-JP","" },
                    {"es-ES","Presiona" },
                    {"zh-CN","按下" },
                    {"de-DE","Drücke" },
                    {"pt-BR","Pressione"}
                }

            }
             ,
             { "toatack_key",new Dictionary<string,string>()
                {
                    {"en-US","to attack" },
                    {"ru-RU","чтобы атаковать" },
                    {"ja-JP","キーを押して攻撃する" },
                    {"es-ES","para atacar" },
                    {"zh-CN","攻击" },
                    {"de-DE","zum Angreifen" },
                    {"pt-BR","para atacar"}
                }

            }
            ,
             { "especial_key",new Dictionary<string,string>()
                {
                    {"en-US","to use special move" },
                    {"ru-RU","чтобы использовать спецприем" },
                    {"ja-JP","キーを押して必殺技を使う" },
                    {"es-ES"," para usar movimiento especial" },
                    {"zh-CN","使用特殊技能" },
                    {"de-DE","um Spezialangriff zu verwenden" },
                    {"pt-BR","pra usar golpe especial"}
                }

            }
            ,
             { "absorve_key",new Dictionary<string,string>()
                {
                    {"en-US","to absorb element" },
                    {"ru-RU","чтобы поглотить элемент" },
                    {"ja-JP","キーを押して要素を吸収する" },
                    {"es-ES","para absorber el elemento" },
                    {"zh-CN","吸收元素" },
                    {"de-DE","um das Element zu absorbieren" },
                    {"pt-BR","para absorver o elemento"}
                }

            }
             ,
             { "combine_key",new Dictionary<string,string>()
                {
                    {"en-US","to combine elements" },
                    {"ru-RU","чтобы комбинировать элементы" },
                    {"ja-JP","キーを押して要素を合成する " },
                    {"es-ES","para combinar elementos" },
                    {"zh-CN","合成元素" },
                    {"de-DE","um die Elemente zu kombinieren" },
                    {"pt-BR","pra combinar os elementos"}
                }

            }
            ,
             { "windowed_key",new Dictionary<string,string>()
                {
                    {"en-US","Windowed Mode" },
                    {"ru-RU","Оконный режим" },
                    {"ja-JP","ウィンドウモード" },
                    {"es-ES","Modo ventana" },
                    {"zh-CN","窗口模式" },
                    {"de-DE","Fenstermodus" },
                    {"pt-BR","Modo Janela"}
                }
            }
             ,
             { "resolution_key",new Dictionary<string,string>()
                {
                    {"en-US","Resolution" },
                    {"ru-RU","Разрешение" },
                    {"ja-JP","解像度" },
                    {"es-ES","Resolución" },
                    {"zh-CN","分辨率" },
                    {"de-DE","Auflösung" },
                    {"pt-BR","Resolução"}
                }

            }
             ,
             { "quality_key",new Dictionary<string,string>()
                {
                    {"en-US","Graphics Quality" },
                    {"ru-RU","Качество графики" },
                    {"ja-JP","グラフィック品質" },
                    {"es-ES","Calidad de gráficos" },
                    {"zh-CN","图形质量" },
                    {"de-DE","Grafikqualität" },
                    {"pt-BR","Qualidade Gráfica"}
                }

            }
              ,
             { "lingua_key",new Dictionary<string,string>()
                {
                    {"en-US","English" },
                    {"ru-RU","Русский" },
                    {"ja-JP","日本語" },
                    {"es-ES","Español" },
                    {"zh-CN","中文" },
                    {"de-DE","Deutsch" },
                    {"pt-BR","Português"}
                }

            }
             ,
             { "idioma_key",new Dictionary<string,string>()
                {
                    {"en-US","Language" },
                    {"ru-RU","Язык" },
                    {"ja-JP","言語" },
                    {"es-ES","Idioma" },
                    {"zh-CN","语言" },
                    {"de-DE","Sprache" },
                    {"pt-BR","Idioma"}
                }

            }
            ,
             { "direita_key",new Dictionary<string,string>()
                {
                    {"en-US","right" },
                    {"ru-RU","право" },
                    {"ja-JP","右" },
                    {"es-ES","derecha" },
                    {"zh-CN","右" },
                    {"de-DE","rechts" },
                    {"pt-BR","direita"}
                }
            }
            ,
             { "esquerda_key",new Dictionary<string,string>()
                {
                    {"en-US","left" },
                    {"ru-RU","лево" },
                    {"ja-JP","左" },
                    {"es-ES","izquierda" },
                    {"zh-CN","左" },
                    {"de-DE","links" },
                    {"pt-BR","esquerda  "}
                }
            }
            ,
             { "pulo_key",new Dictionary<string,string>()
                {
                    {"en-US","jump" },
                    {"ru-RU","прыжок" },
                    {"ja-JP","ジャンプ" },
                    {"es-ES","salto" },
                    {"zh-CN","跳跃" },
                    {"de-DE","Sprung" },
                    {"pt-BR","pulo"}
                }
            }
            ,
             { "ataque_key",new Dictionary<string,string>()
                {
                    {"en-US","attack" },
                    {"ru-RU","атака" },
                    {"ja-JP","攻撃" },
                    {"es-ES","ataque" },
                    {"zh-CN","攻击" },
                    {"de-DE","Angriff" },
                    {"pt-BR","ataque"}
                }
            }
            ,
             { "especial2_key",new Dictionary<string,string>()
                {
                    {"en-US","special" },
                    {"ru-RU","специальный" },
                    {"ja-JP","特殊" },
                    {"es-ES","especial" },
                    {"zh-CN","特殊" },
                    {"de-DE","Spezial" },
                    {"pt-BR","especial"}
                }
            }
            ,
             { "coletar_key",new Dictionary<string,string>()
                {
                    {"en-US","collect" },
                    {"ru-RU","собирать" },
                    {"ja-JP","集める" },
                    {"es-ES","recoger" },
                    {"zh-CN","收集" },
                    {"de-DE","sammeln" },
                    {"pt-BR","coletar"}
                }
            }
            ,
             { "combinar_key",new Dictionary<string,string>()
                {
                    {"en-US","combine" },
                    {"ru-RU","комбинировать" },
                    {"ja-JP","組み合わせる" },
                    {"es-ES","combinar" },
                    {"zh-CN","组合" },
                    {"de-DE","kombinieren" },
                    {"pt-BR","combinar"}
                }
            }
            ,
             { "pausar_key",new Dictionary<string,string>()
                {
                    {"en-US","pause" },
                    {"ru-RU","пауза" },
                    {"ja-JP","ポーズ" },
                    {"es-ES","pausa" },
                    {"zh-CN","暂停" },
                    {"de-DE","Pause" },
                    {"pt-BR","pausa"}
                }
            }
            ,
             { "alterar_key",new Dictionary<string,string>()
                {
                    {"en-US","Remap" },
                    {"ru-RU","Переназначить " },
                    {"ja-JP","再割り当て" },
                    {"es-ES","Reasignar" },
                    {"zh-CN","重新映射" },
                    {"de-DE","Neu zuordnen" },
                    {"pt-BR","Redefinir"}
                }
            }
             ,
             { "controles_key",new Dictionary<string,string>()
                {
                    {"en-US","controls" },
                    {"ru-RU","управление " },
                    {"ja-JP","コントロール" },
                    {"es-ES","controles" },
                    {"zh-CN","控制器" },
                    {"de-DE","Steuerung" },
                    {"pt-BR","controles"}
                }
            }
            ,
             { "aperte_umbotao_key",new Dictionary<string,string>()
                {
                    {"en-US","Press a button" },
                    {"ru-RU","Нажмите кнопку " },
                    {"ja-JP","ボタンを押してください" },
                    {"es-ES","Presiona un botón" },
                    {"zh-CN","按一下按钮" },
                    {"de-DE","Drücke eine Taste" },
                    {"pt-BR","Aperte um botão"}
                }
            }
            ,
             { "press_key_loja",new Dictionary<string,string>()
                {
                    {"en-US","Press" },
                    {"ru-RU","Нажмите" },
                    {"ja-JP","アイテムを購入するには" },
                    {"es-ES","Presiona" },
                    {"zh-CN","按" },
                    {"de-DE","Drücke" },
                    {"pt-BR","Pressione"}
                }

            }
             ,
             { "paraComprar_key",new Dictionary<string,string>()
                {
                    {"en-US","to purchase the item." },
                    {"ru-RU",", чтобы купить предмет." },
                    {"ja-JP","を押してください。" },
                    {"es-ES","para comprar el artículo." },
                    {"zh-CN","购买物品。" },
                    {"de-DE",", um den Gegenstand zu kaufen." },
                    {"pt-BR","para comprar o item. "}
                }

            }
             ,
             { "descricao_pocao",new Dictionary<string,string>()
                {
                    {"en-US","A potion that heals half of your maximum health." },
                    {"ru-RU","Зелье, которое восстанавливает половину вашего максимального здоровья." },
                    {"ja-JP","最大体力値の半分を回復するポーション。" },
                    {"es-ES","Una poción que cura la mitad de tu salud máxima." },
                    {"zh-CN","一瓶可以恢复你最大生命值一半的药水。" },
                    {"de-DE","Ein Trank, der die Hälfte deiner maximalen Gesundheit heilt." },
                    {"pt-BR","Uma poção que cura metade da sua vida máxima."}
                }

            }
             ,
             { "paraUsar_key",new Dictionary<string,string>()
                {
                    {"en-US","to use the item." },
                    {"ru-RU",", чтобы использовать предмет." },
                    {"ja-JP","を押してください。" },
                    {"es-ES","para usar el objeto." },
                    {"zh-CN","使用物品。" },
                    {"de-DE",", um den Gegenstand zu benutzen." },
                    {"pt-BR","para usar o item."}
                }

            }
            ,
             { "descricao_pocaoAzul",new Dictionary<string,string>()
                {
                    {"en-US","A potion that temporarily boosts magical powers." },
                    {"ru-RU","Зелье, временно увеличивающее магическую силу." },
                    {"ja-JP","魔法力を一時的に強化するポーション。" },
                    {"es-ES","Una poción que aumenta temporalmente los poderes mágicos." },
                    {"zh-CN","一种暂时增强魔法力量的药剂。" },
                    {"de-DE","Ein Trank, der die magischen Kräfte vorübergehend verstärkt." },
                    {"pt-BR","Uma poção que aumenta temporariamente os poderes mágicos."}
                }

            }
            ,
             { "descricao_armaduraVermelha",new Dictionary<string,string>()
                {
                    {"en-US","The Red Armor, imbued with the experiences of an ancient samurai, increases your maximum health and sword attacks." },
                    {"ru-RU","Красная броня, пропитанная опытом древнего самурая, увеличивает ваше максимальное здоровье и силу атаки мечом." },
                    {"ja-JP","古代の侍の経験が染み込んだ赤い鎧は、最大体力と剣攻撃力を強化する。" },
                    {"es-ES","La Armadura Roja, impregnada con las experiencias de un antiguo samurai, aumenta tu vida máxima y los ataques de espada." },
                    {"zh-CN","这件红色的盔甲，浸透着古代武士的经验，提升你的最大生命值和剑攻击力。" },
                    {"de-DE","Die Rote Rüstung, durchtränkt mit den Erfahrungen eines alten Samurai, erhöht deine maximale Gesundheit und deine Schwertangriffe." },
                    {"pt-BR"," A Armadura Vermelha, imbuída com as experiências de um antigo samurai, aumenta sua vida máxima e os ataques de espada."}
                }

            }
            ,
             { "descricao_armaduraSombras",new Dictionary<string,string>()
                {
                    {"en-US","The Shadow Armor, forged in the Black Forest, boosts player health, physical attack and magic, ensuring a powerful defense." },
                    {"ru-RU","Броня Теней, созданная в Черном Лесу, увеличивает здоровье, физическую атаку и магию игрока, обеспечивая мощную защиту." },
                    {"ja-JP","黒の森で作られた影の鎧は、プレイヤーの体力、物理攻撃、魔法を強化し、強力な防御を提供します。" },
                    {"es-ES","La Armadura de las Sombras, forjada en el Bosque Oscuro, incrementa la salud, el ataque físico y la magia del jugador, ofreciendo una defensa poderosa." },
                    {"zh-CN","由黑森林打造的暗影盔甲，提升玩家的生命值、物理攻击和魔法值，确保强大的防御。" },
                    {"de-DE","Die Schattenrüstung, geschmiedet im Schwarzen Wald, erhöht die Gesundheit, den physischen Angriff und die Magie des Spielers und sorgt für eine starke Verteidigung." },
                    {"pt-BR","A Armadura das Sombras, criada na Floresta Negra, aumenta a saúde, o ataque físico e a magia do jogador, garantindo uma defesa poderosa."}
                }

            }
            ,
             { "descricao_elemento",new Dictionary<string,string>()
                {
                    {"en-US","An element that can be absorbed to use against your enemies." },
                    {"ru-RU","Элемент, который можно поглотить, чтобы использовать против врагов." },
                    {"ja-JP","敵に使えるように吸収できる要素。" },
                    {"es-ES","Un elemento que se puede absorber para usar contra tus enemigos." },
                    {"zh-CN","可以吸收用来对抗敌人的元素。" },
                    {"de-DE","Ein Element, das absorbiert werden kann, um gegen deine Feinde eingesetzt zu werden." },
                    {"pt-BR","Um elemento que pode ser absorvido para usar contra seus inimigos."}
                }

            }
            ,
             { "usaritem_key",new Dictionary<string,string>()
                {
                    {"en-US","Use item" },
                    {"ru-RU","Использовать предмет" },
                    {"ja-JP","アイテムを使う" },
                    {"es-ES","Usar objeto" },
                    {"zh-CN","使用物品" },
                    {"de-DE","Gegenstand verwenden" },
                    {"pt-BR","Usar item"}
                }
            }
            ,
             { "trocaritem_key",new Dictionary<string,string>()
                {
                    {"en-US","Swap item" },
                    {"ru-RU","Поменять предмет" },
                    {"ja-JP","アイテム交換" },
                    {"es-ES","Cambiar objeto" },
                    {"zh-CN","替换物品" },
                    {"de-DE","Gegenstand tauschen" },
                    {"pt-BR","Trocar item"}
                }
            }
            ,
             { "paraTrocar_key",new Dictionary<string,string>()
                {
                    {"en-US","to swap the item" },
                    {"ru-RU","чтобы поменять предмет" },
                    {"ja-JP","アイテムを交換するために" },
                    {"es-ES","para intercambiar el objeto" },
                    {"zh-CN","为了交换物品" },
                    {"de-DE","um das Objekt zu tauschen" },
                    {"pt-BR","para trocar o item"}
                }

            }








        };
}
