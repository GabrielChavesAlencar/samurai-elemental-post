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








        };
}
