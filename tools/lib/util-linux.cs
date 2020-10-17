# Permission is granted to freely copy and distribute
# this file and modified versions, provided that this
# header is not removed and modified versions are marked
# as such.
#
# Czech translation of util-linux. 
# This file is distributed under the same license as the util-linux package.
#
# Jiří Pavlovský <pavlovsk@ff.cuni.cz>, 1999 - 2001.
# Petr Písař <petr.pisar@atlas.cz>, 2006.
# Vladimír Michl <vladimir.michl@seznam.cz>, 2007
# Petr Písař <petr.pisar@atlas.cz>, 2007, 2008, 2009, 2010, 2011, 2012, 2013.
# Petr Písař <petr.pisar@atlas.cz>, 2014, 2015, 2016, 2017, 2018, 2019, 2020.
#
# eject tool messages merged from eject-2.1.5:
# Jeff Tranter <tranter@pobox.com>, 2005.
# Marek Černocký <marek@manet.cz>, 2006.
#
# bind (mount) → vázané připojení
# boot → spuštění systému
# bootable → zaveditelný/startovací
# bootfile (SGI) → starovací soubor
# deconfigured → odnastavený
# discard (a block) → zahodit
# dispatching mode → režim rozhodování
# (disc) drive → (disková) mechanika
# dump (a partition table as a script) → exportovat
# fatal error → nepřekonatelná chyba
# hush login → tiché přihlášení, (login(8))
# inode → i-uzel (se spojovníkem) XXX: e2fsprogs spojovník nepíše
# disk label → popis disku
# (file system) label → jmenovka
# (SELinux) label → značka
# partition → oddíl
# (GPT) partition label → název oddílu
# personality → charakteristika architektury
# primary group → hlavní skupina
# resource → prostředek
# (file system) signature → vzorec
# swap → odkládací (prostor)
# trim (a file system) → uklidit, zahodit volné bloky
# zone model → model zóny
#
# TODO: Vyvojáři potvrdili, že nová syntaxe proměnných hodnot je malými písmeny
# (HODNOTA → <hodnota>). Překlad bude přizpůsoben.
#
msgid ""
msgstr ""
"Project-Id-Version: util-linux 2.35-rc2\n"
"Report-Msgid-Bugs-To: util-linux@vger.kernel.org\n"
"POT-Creation-Date: 2020-07-23 11:38+0200\n"
"PO-Revision-Date: 2020-01-15 20:59+01:00\n"
"Last-Translator: Petr Písař <petr.pisar@atlas.cz>\n"
"Language-Team: Czech <translation-team-cs@lists.sourceforge.net>\n"
"Language: cs\n"
"MIME-Version: 1.0\n"
"Content-Type: text/plain; charset=UTF-8\n"
"Content-Transfer-Encoding: 8bit\n"
"X-Bugs: Report translation errors to the Language-Team address.\n"
"Plural-Forms: nplurals=3; plural=(n==1) ? 0 : (n>=2 && n<=4) ? 1 : 2;\n"

#: disk-utils/addpart.c:15
#, c-format
msgid " %s <disk device> <partition number> <start> <length>\n"
msgstr " %s <zařízení disku> <číslo oddílu> <začátek> <délka>\n"

#: disk-utils/addpart.c:19
msgid "Tell the kernel about the existence of a specified partition.\n"
msgstr "Řekne jádru o existenci zadaného oddílu.\n"

#: disk-utils/addpart.c:52 disk-utils/blockdev.c:244 disk-utils/delpart.c:52
#: disk-utils/mkfs.bfs.c:127 disk-utils/resizepart.c:96 misc-utils/kill.c:314
#: misc-utils/kill.c:375 misc-utils/rename.c:289 misc-utils/whereis.c:524
#: sys-utils/flock.c:177 sys-utils/ipcrm.c:160 sys-utils/ldattach.c:367
#: sys-utils/renice.c:144 sys-utils/switch_root.c:240 sys-utils/tunelp.c:152
#: term-utils/agetty.c:893 term-utils/agetty.c:894 term-utils/agetty.c:902
#: term-utils/agetty.c:903
msgid "not enough arguments"
msgstr "málo argumentů"

#: disk-utils/addpart.c:57 disk-utils/blockdev.c:293 disk-utils/blockdev.c:437
#: disk-utils/blockdev.c:464 disk-utils/cfdisk.c:2743 disk-utils/delpart.c:58
#: disk-utils/fdformat.c:229 disk-utils/fdisk.c:812 disk-utils/fdisk.c:1143
#: disk-utils/fdisk-list.c:327 disk-utils/fdisk-list.c:368
#: disk-utils/fdisk-list.c:391 disk-utils/fsck.c:1466
#: disk-utils/fsck.cramfs.c:155 disk-utils/fsck.cramfs.c:514
#: disk-utils/isosize.c:53 disk-utils/mkfs.bfs.c:186
#: disk-utils/mkfs.cramfs.c:171 disk-utils/mkfs.cramfs.c:660
#: disk-utils/mkfs.cramfs.c:799 disk-utils/mkfs.minix.c:823
#: disk-utils/mkswap.c:220 disk-utils/mkswap.c:249 disk-utils/partx.c:1021
#: disk-utils/resizepart.c:104 disk-utils/sfdisk.c:378 disk-utils/sfdisk.c:498
#: disk-utils/sfdisk.c:801 disk-utils/sfdisk.c:1082 disk-utils/swaplabel.c:65
#: libfdisk/src/bsd.c:642 login-utils/islocal.c:86 login-utils/last.c:679
#: login-utils/sulogin.c:444 login-utils/sulogin.c:481
#: login-utils/utmpdump.c:134 login-utils/utmpdump.c:354
#: login-utils/utmpdump.c:374 login-utils/vipw.c:261 login-utils/vipw.c:279
#: misc-utils/findmnt.c:1115 misc-utils/logger.c:1241 misc-utils/mcookie.c:119
#: misc-utils/uuidd.c:198 sys-utils/blkdiscard.c:225 sys-utils/blkzone.c:139
#: sys-utils/dmesg.c:530 sys-utils/eject.c:499 sys-utils/eject.c:698
#: sys-utils/fallocate.c:402 sys-utils/fsfreeze.c:116 sys-utils/fstrim.c:103
#: sys-utils/hwclock.c:235 sys-utils/hwclock.c:894 sys-utils/hwclock-rtc.c:138
#: sys-utils/hwclock-rtc.c:403 sys-utils/hwclock-rtc.c:438
#: sys-utils/irq-common.c:214 sys-utils/ldattach.c:391 sys-utils/lscpu.c:536
#: sys-utils/lsmem.c:658 sys-utils/nsenter.c:131 sys-utils/rfkill.c:192
#: sys-utils/rfkill.c:553 sys-utils/rtcwake.c:137 sys-utils/rtcwake.c:292
#: sys-utils/setpriv.c:259 sys-utils/setpriv.c:628 sys-utils/setpriv.c:651
#: sys-utils/swapon.c:374 sys-utils/swapon.c:517 sys-utils/switch_root.c:167
#: sys-utils/unshare.c:112 sys-utils/unshare.c:127 sys-utils/wdctl.c:361
#: sys-utils/zramctl.c:517 term-utils/agetty.c:2961 term-utils/mesg.c:143
#: term-utils/script.c:382 term-utils/scriptlive.c:256
#: term-utils/scriptlive.c:259 term-utils/scriptlive.c:262
#: term-utils/scriptreplay.c:260 term-utils/scriptreplay.c:263
#: term-utils/scriptreplay.c:266 term-utils/scriptreplay.c:269
#: term-utils/wall.c:421 text-utils/colcrt.c:284 text-utils/more.c:460
#: text-utils/rev.c:140 text-utils/ul.c:230
#, c-format
msgid "cannot open %s"
msgstr "%s nelze otevřít"

#: disk-utils/addpart.c:60 disk-utils/delpart.c:61 disk-utils/resizepart.c:101
msgid "invalid partition number argument"
msgstr "neplatný argument čísla oddílu"

#: disk-utils/addpart.c:61
msgid "invalid start argument"
msgstr "neplatný argument začátku"

#: disk-utils/addpart.c:62 disk-utils/resizepart.c:111
msgid "invalid length argument"
msgstr "neplatný argument délky"

#: disk-utils/addpart.c:63
msgid "failed to add partition"
msgstr "oddíl se nepodařilo přidat"

#: disk-utils/blockdev.c:63
msgid "set read-only"
msgstr "nastaví pouze pro čtení"

#: disk-utils/blockdev.c:70
msgid "set read-write"
msgstr "nastaví pro čtení/zápis"

#: disk-utils/blockdev.c:76
msgid "get read-only"
msgstr "zjistí zda je zakázán zápis"

#: disk-utils/blockdev.c:82
msgid "get discard zeroes support status"
msgstr "zjistí podporu zahazování nul"

#: disk-utils/blockdev.c:88
msgid "get logical block (sector) size"
msgstr "zjistí velikost logického bloku (sektoru)"

#: disk-utils/blockdev.c:94
msgid "get physical block (sector) size"
msgstr "zjistí velikost fyzického bloku (sektoru)"

#: disk-utils/blockdev.c:100
msgid "get minimum I/O size"
msgstr "zjistí minimální velikost I/O"

#: disk-utils/blockdev.c:106
msgid "get optimal I/O size"
msgstr "zjistí optimální velikost I/O"

#: disk-utils/blockdev.c:112
msgid "get alignment offset in bytes"
msgstr "zjistí posun pro zarovnání v bajtech"

#: disk-utils/blockdev.c:118
msgid "get max sectors per request"
msgstr "zjistí maximální počet sektorů v požadavku"

#: disk-utils/blockdev.c:124
msgid "get blocksize"
msgstr "zjistí velikost bloku"

#: disk-utils/blockdev.c:131
msgid "set blocksize on file descriptor opening the block device"
msgstr "nastaví velikost bloku na deskriptoru souboru otevírajícího blokové zařízení"

#: disk-utils/blockdev.c:137
msgid "get 32-bit sector count (deprecated, use --getsz)"
msgstr "zjistí počet sektorů jako 32bitové číslo (zastaralé, použijte --getsz)"

#: disk-utils/blockdev.c:143
msgid "get size in bytes"
msgstr "zjistí velikost v bajtech"

#: disk-utils/blockdev.c:150
msgid "set readahead"
msgstr "nastaví dopředné čtení sektorů"

#: disk-utils/blockdev.c:156
msgid "get readahead"
msgstr "zjistí nastavení dopředného čtení sektorů"

#: disk-utils/blockdev.c:163
msgid "set filesystem readahead"
msgstr "nastaví dopředné načítání pro souborový systém"

#: disk-utils/blockdev.c:169
msgid "get filesystem readahead"
msgstr "zjistí nastavení dopředného načítání pro souborový systém"

#: disk-utils/blockdev.c:173
msgid "flush buffers"
msgstr "vyprázdnit buffery"

#: disk-utils/blockdev.c:177
msgid "reread partition table"
msgstr "načte znovu tabulku rozdělení disku"

#: disk-utils/blockdev.c:187
#, c-format
msgid ""
" %1$s [-v|-q] commands devices\n"
" %1$s --report [devices]\n"
" %1$s -h|-V\n"
msgstr ""
" %1$s [-v|-q] příkazy zařízení\n"
" %1$s --report [zařízení]\n"
" %1$s -h|-V\n"

#: disk-utils/blockdev.c:193
msgid "Call block device ioctls from the command line."
msgstr "Zavolá z příkazové řádky IOCTL blokového zařízení."

#: disk-utils/blockdev.c:196
msgid " -q             quiet mode"
msgstr " -q             tichý režim"

#: disk-utils/blockdev.c:197
msgid " -v             verbose mode"
msgstr " -v             upovídaný režim"

#: disk-utils/blockdev.c:198
msgid "     --report   print report for specified (or all) devices"
msgstr "     --report   vypíše hlášení pro zadané (nebo všechna) zařízení"

#: disk-utils/blockdev.c:203
msgid "Available commands:"
msgstr "Dostupné příkazy:"

#: disk-utils/blockdev.c:204
#, c-format
msgid " %-25s get size in 512-byte sectors\n"
msgstr " %-25s vrátí velikost vyjádřenou v 512bajtových sektorech\n"

#: disk-utils/blockdev.c:286 disk-utils/fdformat.c:219
#: disk-utils/fsck.minix.c:1336 disk-utils/isosize.c:155
#: disk-utils/mkfs.bfs.c:175 disk-utils/mkfs.c:110 disk-utils/mkfs.minix.c:812
#: disk-utils/swaplabel.c:180 misc-utils/wipefs.c:778
#: sys-utils/blkdiscard.c:214 sys-utils/blkzone.c:459 sys-utils/tunelp.c:241
#: sys-utils/zramctl.c:713 sys-utils/zramctl.c:739
msgid "no device specified"
msgstr "žádné zařízení nebylo zadáno"

#: disk-utils/blockdev.c:328
msgid "could not get device size"
msgstr "velikost zařízení nebylo možné zjistit"

#: disk-utils/blockdev.c:334
#, c-format
msgid "Unknown command: %s"
msgstr "Neznámý příkaz: %s"

#: disk-utils/blockdev.c:350
#, c-format
msgid "%s requires an argument"
msgstr "přepínač %s vyžaduje argument"

#: disk-utils/blockdev.c:385 disk-utils/blockdev.c:497
#, c-format
msgid "ioctl error on %s"
msgstr "chyba IOCTL na %s"

#: disk-utils/blockdev.c:387
#, c-format
msgid "%s failed.\n"
msgstr "Příkaz „%s“ selhal.\n"

#: disk-utils/blockdev.c:394
#, c-format
msgid "%s succeeded.\n"
msgstr "%s uspěl.\n"

#. TRANSLATORS: Start sector not available. Max. 10 letters.
#: disk-utils/blockdev.c:481
msgid "N/A"
msgstr ""

#: disk-utils/blockdev.c:505
#, c-format
msgid "RO    RA   SSZ   BSZ   StartSec            Size   Device\n"
msgstr "RO    RA   SSZ   BSZ PrvníSekt.        Velikost Zařízení\n"

#: disk-utils/cfdisk.c:191
msgid "Bootable"
msgstr "Zavedit."

#: disk-utils/cfdisk.c:191
msgid "Toggle bootable flag of the current partition"
msgstr "Přepne příznak zaveditelnosti aktuálnímu oddílu"

#: disk-utils/cfdisk.c:192
msgid "Delete"
msgstr "Smazat"

#: disk-utils/cfdisk.c:192
msgid "Delete the current partition"
msgstr "Smaže aktuální oddíl"

#: disk-utils/cfdisk.c:193
msgid "Resize"
msgstr "Změnit velikost"

#: disk-utils/cfdisk.c:193
msgid "Reduce or enlarge the current partition"
msgstr "Zmenší nebo zvětší aktuální oddíl"

#: disk-utils/cfdisk.c:194
msgid "New"
msgstr "Nový"

#: disk-utils/cfdisk.c:194
msgid "Create new partition from free space"
msgstr "Vytvoří nový oddíl ve volném prostoru"

#: disk-utils/cfdisk.c:195
msgid "Quit"
msgstr "Konec"

#: disk-utils/cfdisk.c:195
msgid "Quit program without writing changes"
msgstr "Ukončí program bez uložení změn"

#: disk-utils/cfdisk.c:196 libfdisk/src/bsd.c:439 libfdisk/src/bsd.c:1031
#: libfdisk/src/dos.c:2606 libfdisk/src/gpt.c:3145 libfdisk/src/sgi.c:1164
#: libfdisk/src/sun.c:1136
msgid "Type"
msgstr "Druh"

#: disk-utils/cfdisk.c:196
msgid "Change the partition type"
msgstr "Změní druh oddílu"

#: disk-utils/cfdisk.c:197
msgid "Help"
msgstr "Nápověda"

#: disk-utils/cfdisk.c:197
msgid "Print help screen"
msgstr "Vypíše nápovědu"

#: disk-utils/cfdisk.c:198
msgid "Sort"
msgstr "Seřadit"

#: disk-utils/cfdisk.c:198
msgid "Fix partitions order"
msgstr "Opraví řazení oddílů"

#: disk-utils/cfdisk.c:199
msgid "Write"
msgstr "Uložit"

#: disk-utils/cfdisk.c:199
msgid "Write partition table to disk (this might destroy data)"
msgstr "Uloží tabulku rozdělení disku na disk (může zničit data)"

#: disk-utils/cfdisk.c:200
msgid "Dump"
msgstr "Exportovat"

#: disk-utils/cfdisk.c:200
msgid "Dump partition table to sfdisk compatible script file"
msgstr "Exportuje tabulku rozdělení disku jako skript pro sfdisk"

#: disk-utils/cfdisk.c:645 disk-utils/fdisk.c:465
#, c-format
msgid "internal error: unsupported dialog type %d"
msgstr "vnitřní chyba: nepodporovaný druh dialogu %d"

#: disk-utils/cfdisk.c:1287
#, c-format
msgid "%s (mounted)"
msgstr "%s (připojen)"

#: disk-utils/cfdisk.c:1307
msgid "Partition name:"
msgstr "Název oddílu:"

#: disk-utils/cfdisk.c:1314
msgid "Partition UUID:"
msgstr "UUID oddílu:"

#: disk-utils/cfdisk.c:1326
msgid "Partition type:"
msgstr "Typ oddílu:"

#: disk-utils/cfdisk.c:1333
msgid "Attributes:"
msgstr "Atributy:"

#: disk-utils/cfdisk.c:1357
msgid "Filesystem UUID:"
msgstr "UUID souborového systému:"

#: disk-utils/cfdisk.c:1364
msgid "Filesystem LABEL:"
msgstr "Jmenovka souborového systému:"

#: disk-utils/cfdisk.c:1370
msgid "Filesystem:"
msgstr "Souborový systém:"

#: disk-utils/cfdisk.c:1375
msgid "Mountpoint:"
msgstr "Bod připojení"

#: disk-utils/cfdisk.c:1719
#, c-format
msgid "Disk: %s"
msgstr "Disk: %s"

#: disk-utils/cfdisk.c:1721
#, c-format
msgid "Size: %s, %<PRIu64> bytes, %ju sectors"
msgstr "Velikost: %s, %'<PRIu64> bajtů, %'ju sektorů"

#: disk-utils/cfdisk.c:1724
#, c-format
msgid "Label: %s, identifier: %s"
msgstr "Popis: %s, identifikátor: %s"

#: disk-utils/cfdisk.c:1727
#, c-format
msgid "Label: %s"
msgstr "Popis: %s"

#: disk-utils/cfdisk.c:1878
msgid "May be followed by M for MiB, G for GiB, T for TiB, or S for sectors."
msgstr "Smí být následováno M pro MiB, G pro GiB, T pro TiB nebo S pro sektory."

#: disk-utils/cfdisk.c:1884
msgid "Please, specify size."
msgstr "Prosím, zadejte velikost."

#: disk-utils/cfdisk.c:1906
#, c-format
msgid "Minimum size is %<PRIu64> bytes."
msgstr "Nejmenší velikost je %<PRIu64> bajtů."

#: disk-utils/cfdisk.c:1915
#, c-format
msgid "Maximum size is %<PRIu64> bytes."
msgstr "Největší velikost je %<PRIu64> bajtů."

#: disk-utils/cfdisk.c:1922
msgid "Failed to parse size."
msgstr "Velikost se nezdařilo rozebrat."

#: disk-utils/cfdisk.c:1980
msgid "Select partition type"
msgstr "Vybrat druh oddílu"

#: disk-utils/cfdisk.c:2030 disk-utils/cfdisk.c:2060
msgid "Enter script file name: "
msgstr "Zadejte název souboru pro skript: "

#: disk-utils/cfdisk.c:2031
msgid "The script file will be applied to in-memory partition table."
msgstr "Skript se použije na tabulku rozdělení disku v paměti."

#: disk-utils/cfdisk.c:2040 disk-utils/cfdisk.c:2082
#: disk-utils/fdisk-menu.c:481 disk-utils/fdisk-menu.c:525
#, c-format
msgid "Cannot open %s"
msgstr "Nelze otevřít %s"

#: disk-utils/cfdisk.c:2042 disk-utils/fdisk-menu.c:483
#, c-format
msgid "Failed to parse script file %s"
msgstr "Rozbor souboru se skriptem %s selhal"

#: disk-utils/cfdisk.c:2044 disk-utils/fdisk-menu.c:485
#, c-format
msgid "Failed to apply script %s"
msgstr "Skript %s se nepodařilo použít"

#: disk-utils/cfdisk.c:2061
msgid "The current in-memory partition table will be dumped to the file."
msgstr "Současná tabulka rozdělení disku v paměti bude exportována do souboru."

#: disk-utils/cfdisk.c:2069 disk-utils/fdisk-menu.c:513
msgid "Failed to allocate script handler"
msgstr "Alokace obsluhy skriptu selhala"

#: disk-utils/cfdisk.c:2075
msgid "Failed to read disk layout into script."
msgstr "Načtení rozvržení disku do skriptu selhalo."

#: disk-utils/cfdisk.c:2089
msgid "Disk layout successfully dumped."
msgstr "Rozvržení disku bylo úspěšně vyexportováno."

#: disk-utils/cfdisk.c:2092 disk-utils/fdisk-menu.c:531
#, c-format
msgid "Failed to write script %s"
msgstr "Zápis skriptu %s selhal."

#: disk-utils/cfdisk.c:2128
msgid "Select label type"
msgstr "Vybrat druh popisu"

#: disk-utils/cfdisk.c:2131 disk-utils/fdisk.c:1158 disk-utils/fdisk-menu.c:489
msgid "Device does not contain a recognized partition table."
msgstr "Zařízení neobsahuje známou tabulku rozdělení disku."

#: disk-utils/cfdisk.c:2139
msgid "Select a type to create a new label or press 'L' to load script file."
msgstr "Vyberte druh popisu, který chcete vytvořit, nebo stiskněte „L“, abyste zavedli skript ze souboru."

#: disk-utils/cfdisk.c:2188
msgid "This is cfdisk, a curses-based disk partitioning program."
msgstr "Toto je cfdisk, program pro vytváření oddílů postavený na knihovně curses."

#: disk-utils/cfdisk.c:2189
msgid "It lets you create, delete, and modify partitions on a block device."
msgstr "Umožňuje vytváření, mazání a úpravu oddílů na blokovém zařízení."

#: disk-utils/cfdisk.c:2191
msgid "Command      Meaning"
msgstr "Příkaz      Význam"

#: disk-utils/cfdisk.c:2192
msgid "-------      -------"
msgstr "-------      -------"

#: disk-utils/cfdisk.c:2193
msgid "  b          Toggle bootable flag of the current partition"
msgstr "  b          Přepne aktuálnímu oddílu příznak zaveditelnosti"

#: disk-utils/cfdisk.c:2194
msgid "  d          Delete the current partition"
msgstr "  d          Smaže aktuální oddíl"

#: disk-utils/cfdisk.c:2195
msgid "  h          Print this screen"
msgstr "  h          Vypíše tuto nápovědu"

#: disk-utils/cfdisk.c:2196
msgid "  n          Create new partition from free space"
msgstr "  n          Vytvořit na volném místě nový oddíl"

#: disk-utils/cfdisk.c:2197
msgid "  q          Quit program without writing partition table"
msgstr "  q          Ukončí program bez uložení tabulky rozdělení disku"

#: disk-utils/cfdisk.c:2198
msgid "  s          Fix partitions order (only when in disarray)"
msgstr "  s          Opraví pořadí oddílů (pouze při nepořádku)"

#: disk-utils/cfdisk.c:2199
msgid "  t          Change the partition type"
msgstr "  t          Změní druh oddílu"

#: disk-utils/cfdisk.c:2200
msgid "  u          Dump disk layout to sfdisk compatible script file"
msgstr "  u          Exportuje rozvržení disku jako skript kompatibilní se sfdiskem"

#: disk-utils/cfdisk.c:2201
msgid "  W          Write partition table to disk (you must enter uppercase W);"
msgstr "  W          Uloží tabulku rozdělení disku na disk (musíte zadat velké W)."

#: disk-utils/cfdisk.c:2202
msgid "               since this might destroy data on the disk, you must either"
msgstr "             Jelikož tímto může zničit data na disku, musíte to potvrdit"

#: disk-utils/cfdisk.c:2203
msgid "               confirm or deny the write by entering 'yes' or 'no'"
msgstr "             nebo odmítnout napsáním „yes“ (ano) nebo „no“ (ne)"

#: disk-utils/cfdisk.c:2204
msgid "  x          Display/hide extra information about a partition"
msgstr "  x          Zobrazí/skryje další údaje o oddílu"

#: disk-utils/cfdisk.c:2205
msgid "Up Arrow     Move cursor to the previous partition"
msgstr "Nahoru       Přesune kurzor na předcházející oddíl."

#: disk-utils/cfdisk.c:2206
msgid "Down Arrow   Move cursor to the next partition"
msgstr "Dolů         Přesune kurzor na další oddíl."

#: disk-utils/cfdisk.c:2207
msgid "Left Arrow   Move cursor to the previous menu item"
msgstr "Vlevo        Přesune kurzor na předcházející položku nabídky"

#: disk-utils/cfdisk.c:2208
msgid "Right Arrow  Move cursor to the next menu item"
msgstr "Vpravo       Přesune kurzor na další položku nabídky"

#: disk-utils/cfdisk.c:2210
msgid "Note: All of the commands can be entered with either upper or lower"
msgstr "Poznámka: Všechny příkazy mohou být zadány malými i velkými písmeny"

#: disk-utils/cfdisk.c:2211
msgid "case letters (except for Write)."
msgstr "(s výjimkou zápisu - W)."

#: disk-utils/cfdisk.c:2213
msgid "Use lsblk(8) or partx(8) to see more details about the device."
msgstr "Další podrobnosti o zařízení lze získat nástroji lsblk(8) a partx(8)."

#: disk-utils/cfdisk.c:2223 disk-utils/cfdisk.c:2526
msgid "Press a key to continue."
msgstr "Stiskněte klávesu pro pokračování."

#: disk-utils/cfdisk.c:2309
msgid "Could not toggle the flag."
msgstr "Příznak nebylo možné přepnout."

#: disk-utils/cfdisk.c:2319
#, c-format
msgid "Could not delete partition %zu."
msgstr "Oddíl %zu nebylo možné smazat."

#: disk-utils/cfdisk.c:2321 disk-utils/fdisk-menu.c:662
#, c-format
msgid "Partition %zu has been deleted."
msgstr "Oddíl %zu je smazaný."

#: disk-utils/cfdisk.c:2342
msgid "Partition size: "
msgstr "Velikost oddílu: "

#: disk-utils/cfdisk.c:2383
#, c-format
msgid "Changed type of partition %zu."
msgstr "Druh oddílu %zu byl změněn."

#: disk-utils/cfdisk.c:2385
#, c-format
msgid "The type of partition %zu is unchanged."
msgstr "Typ oddílu %zu je nezměněn."

#: disk-utils/cfdisk.c:2406
msgid "New size: "
msgstr "Nová velikost: "

#: disk-utils/cfdisk.c:2421
#, c-format
msgid "Partition %zu resized."
msgstr "Oddíl č. %zu změnil velikost."

#: disk-utils/cfdisk.c:2439 disk-utils/cfdisk.c:2555 disk-utils/fdisk.c:1140
#: disk-utils/fdisk-menu.c:592
msgid "Device is open in read-only mode."
msgstr "Zařízení otevřeno jen pro čtení."

#: disk-utils/cfdisk.c:2444
msgid "Are you sure you want to write the partition table to disk? "
msgstr "Jste si jisti, že chcete uložit tabulku rozdělení disku na disk? "

#: disk-utils/cfdisk.c:2446
msgid "Type \"yes\" or \"no\", or press ESC to leave this dialog."
msgstr "Napište „ano“ nebo „ne“ nebo stiskněte Esc pro opuštění dialogu."

#: disk-utils/cfdisk.c:2451 login-utils/lslogins.c:218 sys-utils/lscpu.c:1602
#: sys-utils/lscpu.c:1612 sys-utils/lsmem.c:266
msgid "yes"
msgstr "ano"

#: disk-utils/cfdisk.c:2452
msgid "Did not write partition table to disk."
msgstr "Tabulka rozdělení disku nebyla na disk zapsána."

#: disk-utils/cfdisk.c:2457
msgid "Failed to write disklabel."
msgstr "Zápis popisu disku selhal."

#: disk-utils/cfdisk.c:2463 disk-utils/fdisk-menu.c:599
msgid "The partition table has been altered."
msgstr "Tabulka rozdělení disku byla změněna."

#: disk-utils/cfdisk.c:2486 disk-utils/cfdisk.c:2557
msgid "Note that partition table entries are not in disk order now."
msgstr "Vezměte na vědomí, že záznamy tabulky rozdělení disku nejsou nyní seřazeny."

#: disk-utils/cfdisk.c:2523
#, c-format
msgid "Device already contains a %s signature; it will be removed by a write command."
msgstr "Zařízení již obsahuje vzorec %s. Příkazem k zápisu bude odstraněn."

#: disk-utils/cfdisk.c:2534
msgid "failed to create a new disklabel"
msgstr "vytvoření nového popisu disku selhal"

#: disk-utils/cfdisk.c:2542
msgid "failed to read partitions"
msgstr "oddíly se nepodařilo načíst"

#: disk-utils/cfdisk.c:2641
#, c-format
msgid " %1$s [options] <disk>\n"
msgstr " %1$s [přepínače] <disk>\n"

#: disk-utils/cfdisk.c:2644 disk-utils/fdisk.c:857 disk-utils/sfdisk.c:2005
msgid "Display or manipulate a disk partition table.\n"
msgstr "Zobrazí nebo pracuje s tabulkou rozdělení disku.\n"

#: disk-utils/cfdisk.c:2648
#, c-format
msgid " -L, --color[=<when>]     colorize output (%s, %s or %s)\n"
msgstr " -L, --color[=<kdy>]      obarví výstup (%s, %s nebo %s)\n"

#: disk-utils/cfdisk.c:2651
msgid " -z, --zero               start with zeroed partition table\n"
msgstr " -z, --zero               začne s vynulovanou tabulkou rozdělení disku\n"

#: disk-utils/cfdisk.c:2653
#, fuzzy, c-format
msgid "     --lock[=<mode>]      use exclusive device lock (%s, %s or %s)\n"
msgstr "     --color[=<kdy>]       obarví výstup (%s, %s nebo %s)\n"

#: disk-utils/cfdisk.c:2694 disk-utils/fdisk.c:1016 disk-utils/sfdisk.c:2305
#: misc-utils/cal.c:436 sys-utils/dmesg.c:1437 text-utils/hexdump.c:114
msgid "unsupported color mode"
msgstr "nepodporovaný režim barev"

#: disk-utils/cfdisk.c:2721 disk-utils/fdisk.c:951 disk-utils/sfdisk.c:231
msgid "failed to allocate libfdisk context"
msgstr "alokace kontextu libfdisku selhala"

#: disk-utils/delpart.c:15
#, c-format
msgid " %s <disk device> <partition number>\n"
msgstr "%s <zařízení disku> <číslo oddílu>\n"

#: disk-utils/delpart.c:19
msgid "Tell the kernel to forget about a specified partition.\n"
msgstr "Řekne jádru, aby zapomnělo zadaný oddíl.\n"

#: disk-utils/delpart.c:62
msgid "failed to remove partition"
msgstr "oddíl se nepodařilo odstranit"

#: disk-utils/fdformat.c:54
#, c-format
msgid "Formatting ... "
msgstr "Formátuje se… "

#: disk-utils/fdformat.c:69 disk-utils/fdformat.c:139
#, c-format
msgid "done\n"
msgstr "hotovo\n"

#: disk-utils/fdformat.c:81
#, c-format
msgid "Verifying ... "
msgstr "Ověřuje se… "

#: disk-utils/fdformat.c:109
msgid "Read: "
msgstr "Chyba při čtení: "

#: disk-utils/fdformat.c:111
#, c-format
msgid "Problem reading track/head %u/%u, expected %d, read %d\n"
msgstr "Potíže při čtení cylindru/hlavy %u/%u, předpoklad %d, přečteno %d\n"

#: disk-utils/fdformat.c:128
#, c-format
msgid ""
"bad data in track/head %u/%u\n"
"Continuing ... "
msgstr ""
"chybná data v cylindru/hlavě %u/%u\n"
"Pokračuje se…"

#: disk-utils/fdformat.c:146 disk-utils/fsck.minix.c:183
#: disk-utils/swaplabel.c:123 misc-utils/wipefs.c:648 sys-utils/blkdiscard.c:86
#: sys-utils/tunelp.c:95
#, c-format
msgid " %s [options] <device>\n"
msgstr " %s [přepínače] <zařízení>\n"

#: disk-utils/fdformat.c:150
msgid "Do a low-level formatting of a floppy disk.\n"
msgstr "Formátuje disketu na nízké úrovni.\n"

#: disk-utils/fdformat.c:153
msgid " -f, --from <N>    start at the track N (default 0)\n"
msgstr " -f, --from <N>    začne na stopě N (výchozí je 0)\n"

#: disk-utils/fdformat.c:154
msgid " -t, --to <N>      stop at the track N\n"
msgstr " -t, --to <N>      přestane na stopě N\n"

#: disk-utils/fdformat.c:155
msgid ""
" -r, --repair <N>  try to repair tracks failed during\n"
"                     the verification (max N retries)\n"
msgstr ""
" -r, --repair <N>  pokusí se opravit stopy, které neuspěly při\n"
"                   ověřování (nejvýše N pokusů)\n"

#: disk-utils/fdformat.c:157
msgid " -n, --no-verify   disable the verification after the format\n"
msgstr " -n, --no-verify   vypne ověřování po formátování\n"

#: disk-utils/fdformat.c:195
msgid "invalid argument - from"
msgstr "neplatný argument – from"

#: disk-utils/fdformat.c:199
msgid "invalid argument - to"
msgstr "neplatný argument – to"

#: disk-utils/fdformat.c:202
msgid "invalid argument - repair"
msgstr "neplatný argument – repair"

#: disk-utils/fdformat.c:223 disk-utils/fsck.cramfs.c:151
#: disk-utils/mkfs.bfs.c:182 disk-utils/mkfs.cramfs.c:337
#: disk-utils/mkfs.cramfs.c:758 disk-utils/mkfs.cramfs.c:796
#: disk-utils/mkfs.minix.c:820 disk-utils/mkswap.c:246 disk-utils/partx.c:959
#: login-utils/last.c:693 login-utils/utmpdump.c:137 misc-utils/namei.c:135
#: misc-utils/rename.c:120 misc-utils/rename.c:182 sys-utils/blkdiscard.c:228
#: sys-utils/blkzone.c:142 sys-utils/dmesg.c:532 sys-utils/fallocate.c:201
#: sys-utils/fsfreeze.c:119 sys-utils/fstrim.c:75 sys-utils/nsenter.c:166
#: sys-utils/nsenter.c:170 sys-utils/swapon.c:522 sys-utils/switch_root.c:94
#: sys-utils/switch_root.c:137 term-utils/mesg.c:145
#, c-format
msgid "stat of %s failed"
msgstr "volání stat nad %s selhalo"

#: disk-utils/fdformat.c:226 disk-utils/partx.c:1018 misc-utils/lsblk.c:1447
#: sys-utils/blkdiscard.c:230 sys-utils/blkzone.c:144
#: sys-utils/mountpoint.c:107
#, c-format
msgid "%s: not a block device"
msgstr "%s: není blokové zařízení"

#: disk-utils/fdformat.c:231
msgid "could not determine current format type"
msgstr "současný typ formátu nebylo možné určit"

#: disk-utils/fdformat.c:233
#, c-format
msgid "%s-sided, %d tracks, %d sec/track. Total capacity %d kB.\n"
msgstr "stran: %s, stop: %d, sekt/stopu %d. Celková kapacita %'d kB.\n"

#: disk-utils/fdformat.c:234
msgid "Double"
msgstr "2"

#: disk-utils/fdformat.c:234
msgid "Single"
msgstr "1"

#: disk-utils/fdformat.c:241
msgid "user defined start track exceeds the medium specific maximum"
msgstr "počáteční stopa zadaná uživatelem přesahuje hranici média"

#: disk-utils/fdformat.c:243
msgid "user defined end track exceeds the medium specific maximum"
msgstr "koncová stopa zadaná uživatelem přesahuje hranici média"

#: disk-utils/fdformat.c:245
msgid "user defined start track exceeds the user defined end track"
msgstr "počáteční stopa zadaná uživatelem přesahuje uživatelem zadanou koncovou stopu"

#: disk-utils/fdformat.c:253 misc-utils/logger.c:1045
msgid "close failed"
msgstr "uzavření selhalo"

#: disk-utils/fdisk.c:206
#, c-format
msgid "Select (default %c): "
msgstr "Vyberte (výchozí %c): "

#: disk-utils/fdisk.c:211
#, c-format
msgid "Using default response %c."
msgstr "Použije se výchozí odpověď %c."

#: disk-utils/fdisk.c:224 disk-utils/fdisk.c:298 disk-utils/fdisk.c:375
#: libfdisk/src/dos.c:1382 libfdisk/src/gpt.c:2472
msgid "Value out of range."
msgstr "Hodnota je mimo meze."

#: disk-utils/fdisk.c:253
#, c-format
msgid "%s (%s, default %c): "
msgstr "%s (%s, výchozí je %c): "

#: disk-utils/fdisk.c:256 disk-utils/fdisk.c:323
#, c-format
msgid "%s (%s, default %<PRIu64>): "
msgstr "%s (%s, výchozí je %<PRIu64>): "

#: disk-utils/fdisk.c:261
#, c-format
msgid "%s (%c-%c, default %c): "
msgstr "%s (%c-%c, výchozí je %c): "

#: disk-utils/fdisk.c:265 disk-utils/fdisk.c:327
#, c-format
msgid "%s (%<PRIu64>-%<PRIu64>, default %<PRIu64>): "
msgstr "%s (%<PRIu64>-%<PRIu64>, výchozí je %<PRIu64>): "

#: disk-utils/fdisk.c:268
#, c-format
msgid "%s (%c-%c): "
msgstr "%s (%c-%c): "

#: disk-utils/fdisk.c:271 disk-utils/fdisk.c:330
#, c-format
msgid "%s (%<PRIu64>-%<PRIu64>): "
msgstr "%s (%<PRIu64>-%<PRIu64>): "

#: disk-utils/fdisk.c:442 disk-utils/sfdisk.c:205
msgid " [Y]es/[N]o: "
msgstr " [A]no/[N]e: "

#: disk-utils/fdisk.c:486
#, fuzzy
msgid "Hex code or alias (type L to list all): "
msgstr "Šestnáctkový kód (L vypíše všechny kódy):"

#: disk-utils/fdisk.c:487
#, fuzzy
msgid "Partition type or alias (type L to list all): "
msgstr "Typ oddílu (L vypíše všechny typy): "

#: disk-utils/fdisk.c:490
msgid "Hex code (type L to list all codes): "
msgstr "Šestnáctkový kód (L vypíše všechny kódy):"

#: disk-utils/fdisk.c:491
msgid "Partition type (type L to list all types): "
msgstr "Typ oddílu (L vypíše všechny typy): "

#: disk-utils/fdisk.c:510
#, c-format
msgid "Failed to parse '%s' partition type."
msgstr "Nezdařilo se rozebrat typ oddílu „%s“"

#: disk-utils/fdisk.c:601
msgid ""
"\n"
"Aliases:\n"
msgstr ""

#: disk-utils/fdisk.c:627
msgid "DOS Compatibility flag is set (DEPRECATED!)"
msgstr "Příznak kompatibility s DOSem je nastaven (ZASTARALÉ!)"

#: disk-utils/fdisk.c:628
msgid "DOS Compatibility flag is not set"
msgstr "Příznak kompatibility s DOSem není nastaven"

#: disk-utils/fdisk.c:650 disk-utils/fdisk.c:688
#, c-format
msgid "Partition %zu does not exist yet!"
msgstr "Diskový oddíl %zu zatím neexistuje!"

#: disk-utils/fdisk.c:655 disk-utils/fdisk.c:666 libfdisk/src/ask.c:1028
msgid "Unknown"
msgstr "Neznámý"

#: disk-utils/fdisk.c:665
#, c-format
msgid "Changed type of partition '%s' to '%s'."
msgstr "Typ oddílu „%s“ byl změněn na „%s“."

#: disk-utils/fdisk.c:669
#, c-format
msgid "Type of partition %zu is unchanged: %s."
msgstr "Typ oddílu %zu je nezměněn: %s."

#: disk-utils/fdisk.c:765
#, c-format
msgid ""
"\n"
"%s: offset = %<PRIu64>, size = %zu bytes."
msgstr ""
"\n"
"%s: posun = %'<PRIu64>, velikost = %'zu B."

#: disk-utils/fdisk.c:771
msgid "cannot seek"
msgstr "volání seek selhalo"

#: disk-utils/fdisk.c:776
msgid "cannot read"
msgstr "nelze číst"

#: disk-utils/fdisk.c:789 libfdisk/src/bsd.c:258 libfdisk/src/dos.c:968
#: libfdisk/src/gpt.c:2400
msgid "First sector"
msgstr "První sektor"

#: disk-utils/fdisk.c:816
#, c-format
msgid "BLKGETSIZE ioctl failed on %s"
msgstr "volání ioctl BLKGETSIZE nad %s selhalo"

#: disk-utils/fdisk.c:834
#, c-format
msgid "The device contains '%s' signature and it will be removed by a write command. See fdisk(8) man page and --wipe option for more details."
msgstr "Zařízení obsahuje vzorec %s a příkazem k zápisu bude odstraněn. Pro podrobnosti vizte manuál fdisk(8) a přepínač --wipe."

#: disk-utils/fdisk.c:839
#, c-format
msgid "The device contains '%s' signature and it may remain on the device. It is recommended to wipe the device with wipefs(8) or fdisk --wipe, in order to avoid possible collisions."
msgstr "Zařízení obsahuje vzorec „%s“ a možná zůstane na zařízení. Doporučuje se vyčistit zařízení příkazem wipefs(8) nebo fdisk --wipe, aby se předešlo možným kolizím."

#: disk-utils/fdisk.c:852
#, fuzzy, c-format
msgid ""
" %1$s [options] <disk>         change partition table\n"
" %1$s [options] -l [<disk>...] list partition table(s)\n"
msgstr ""
" %1$s [přepínače] <disk>     změní tabulku rozdělení disku\n"
" %1$s [přepínače] -l <disk>  vypíše tabulku(y) rozdělení disku\n"

#: disk-utils/fdisk.c:860
msgid " -b, --sector-size <size>      physical and logical sector size\n"
msgstr " -b, --sector-size <velikost>  velikost fyzického a logického sektoru\n"

#: disk-utils/fdisk.c:861
msgid " -B, --protect-boot            don't erase bootbits when creating a new label\n"
msgstr ""
" -B, --protect-boot            nemaže bity zavaděče, když se vytváří nový\n"
"                               popis disku\n"

#: disk-utils/fdisk.c:862
msgid " -c, --compatibility[=<mode>]  mode is 'dos' or 'nondos' (default)\n"
msgstr " -c, --compatibility[=<režim>] režim „dos“ nebo „nondos“ (výchozí)\n"

#: disk-utils/fdisk.c:864
#, c-format
msgid " -L, --color[=<when>]          colorize output (%s, %s or %s)\n"
msgstr " -L, --color[=<kdy>]           obarví výstup (%s, %s nebo %s)\n"

#: disk-utils/fdisk.c:867
msgid " -l, --list                    display partitions and exit\n"
msgstr " -l, --list                    zobrazí oddíly a skončí\n"

#: disk-utils/fdisk.c:868
#, fuzzy
msgid " -x, --list-details            like --list but with more details\n"
msgstr " -l, --list [<zařízení> …]         vypíše oddíly na každém zařízení\n"

#: disk-utils/fdisk.c:870
#, fuzzy
msgid " -n, --noauto-pt               don't create default partition table on empty devices\n"
msgstr " -P, --partscan                vytvoří loop zařízení rozdělené na oddíly\n"

#: disk-utils/fdisk.c:871
msgid " -o, --output <list>           output columns\n"
msgstr " -o, --output <seznam>         zobrazí sloupce\n"

#: disk-utils/fdisk.c:872
msgid " -t, --type <type>             recognize specified partition table type only\n"
msgstr " -t, --type <typ>              rozpozná jen zadaný typ tabulky rozdělení disku\n"

#: disk-utils/fdisk.c:873
msgid " -u, --units[=<unit>]          display units: 'cylinders' or 'sectors' (default)\n"
msgstr ""
" -u, --units[=<jednotka>]      zobrazuje v jednotkách: „cylinders“ (cylindry)\n"
"                               nebo „sectors“ (sektory, výchozí)\n"

#: disk-utils/fdisk.c:874
msgid " -s, --getsz                   display device size in 512-byte sectors [DEPRECATED]\n"
msgstr ""
" -s, --getsz                   zobrazí velikost zařízení v 512bajtových\n"
"                               sektorech (ZASTARALÉ)\n"

#: disk-utils/fdisk.c:875
msgid "     --bytes                   print SIZE in bytes rather than in human readable format\n"
msgstr ""
"     --bytes                   velikosti vypisuje v bajtech namísto v podobě\n"
"                               vhodné pro člověka\n"

#: disk-utils/fdisk.c:877
#, fuzzy, c-format
msgid "     --lock[=<mode>]           use exclusive device lock (%s, %s or %s)\n"
msgstr "     --color[=<kdy>]       obarví výstup (%s, %s nebo %s)\n"

#: disk-utils/fdisk.c:879
#, c-format
msgid " -w, --wipe <mode>             wipe signatures (%s, %s or %s)\n"
msgstr " -w, --wipe <režim>            vymaže vzorce (%s, %s nebo %s)\n"

#: disk-utils/fdisk.c:881 disk-utils/sfdisk.c:2059
#, c-format
msgid " -W, --wipe-partitions <mode>  wipe signatures from new partitions (%s, %s or %s)\n"
msgstr " -W, --wipe-partitions <kdy>   vymaže vzorce z nových oddílů (%s, %s nebo %s)\n"

#: disk-utils/fdisk.c:884
msgid " -C, --cylinders <number>      specify the number of cylinders\n"
msgstr " -C, --cylinders <počet>       určuje počet cylindrů\n"

#: disk-utils/fdisk.c:885
msgid " -H, --heads <number>          specify the number of heads\n"
msgstr " -H, --heads <počet>           určuje počet hlav\n"

#: disk-utils/fdisk.c:886
msgid " -S, --sectors <number>        specify the number of sectors per track\n"
msgstr " -S, --sectors <počet>         určuje počet sektorů na stopu\n"

#: disk-utils/fdisk.c:961 disk-utils/fdisk.c:963 disk-utils/partx.c:882
msgid "invalid sector size argument"
msgstr "neplatný argument velikosti sektoru"

#: disk-utils/fdisk.c:973
msgid "invalid cylinders argument"
msgstr "neplatný argument cylindrů"

#: disk-utils/fdisk.c:985
msgid "not found DOS label driver"
msgstr "ovladač popisu disku DOS nenalezen"

#: disk-utils/fdisk.c:991
#, c-format
msgid "unknown compatibility mode '%s'"
msgstr "neznámý režim kompatibility „%s"

#: disk-utils/fdisk.c:998
msgid "invalid heads argument"
msgstr "neplatný argument hlav"

#: disk-utils/fdisk.c:1004
msgid "invalid sectors argument"
msgstr "neplatný argument sektorů"

#: disk-utils/fdisk.c:1036
#, c-format
msgid "unsupported disklabel: %s"
msgstr "nepodporovaný popis disku: %s"

#: disk-utils/fdisk.c:1044
msgid "unsupported unit"
msgstr "nepodporovaná jednotka"

#: disk-utils/fdisk.c:1052 disk-utils/fdisk.c:1057 disk-utils/sfdisk.c:2266
#: disk-utils/sfdisk.c:2271
msgid "unsupported wipe mode"
msgstr "nepodporovaný režim výmazu"

#: disk-utils/fdisk.c:1078
msgid "The device properties (sector size and geometry) should be used with one specified device only."
msgstr "Vlastnosti zařízení (velikost sektoru a geometrie) by měly být použity jen s jedním zadaným zařízením."

#: disk-utils/fdisk.c:1109 disk-utils/fdisk.c:1124 disk-utils/fsck.cramfs.c:696
#: disk-utils/mkfs.bfs.c:192 disk-utils/mkfs.cramfs.c:786
#: disk-utils/partx.c:975 disk-utils/raw.c:136 disk-utils/raw.c:149
#: disk-utils/raw.c:161 disk-utils/raw.c:202 misc-utils/cal.c:534
#: misc-utils/findfs.c:58 misc-utils/look.c:149 misc-utils/whereis.c:577
#: misc-utils/whereis.c:588 misc-utils/whereis.c:599 misc-utils/whereis.c:641
#: schedutils/chrt.c:513 schedutils/ionice.c:262 schedutils/taskset.c:188
#: sys-utils/chcpu.c:355 sys-utils/chmem.c:422 sys-utils/dmesg.c:1505
#: sys-utils/ipcmk.c:138 sys-utils/ldattach.c:320 sys-utils/losetup.c:913
#: sys-utils/lscpu.c:2426 sys-utils/lsmem.c:643 sys-utils/mount.c:824
#: sys-utils/mount.c:832 sys-utils/mount.c:879 sys-utils/mount.c:892
#: sys-utils/mount.c:964 sys-utils/mountpoint.c:189 sys-utils/pivot_root.c:71
#: sys-utils/swapoff.c:258 sys-utils/swapon.c:992 sys-utils/switch_root.c:249
#: sys-utils/umount.c:598 term-utils/setterm.c:1197 text-utils/col.c:233
#: text-utils/more.c:2058
msgid "bad usage"
msgstr "chybný způsob použití"

#: disk-utils/fdisk.c:1130
#, c-format
msgid "Welcome to fdisk (%s)."
msgstr "Vítejte v fdisku (%s)."

#: disk-utils/fdisk.c:1132 disk-utils/sfdisk.c:1771
msgid ""
"Changes will remain in memory only, until you decide to write them.\n"
"Be careful before using the write command.\n"
msgstr ""
"Změny zůstanou pouze v paměti, dokud se nerozhodnete je uložit na disk.\n"
"Při použití příkazu zápisu buďte obezřetní.\n"

#: disk-utils/fdisk.c:1164
msgid "A hybrid GPT was detected. You have to sync the hybrid MBR manually (expert command 'M')."
msgstr "Byla nalezena hybridní GPT. Hybridní MBR budete muset synchronizovat ručně (expertní příkaz „M“)."

#: disk-utils/fdisk-list.c:43
#, c-format
msgid "Disklabel type: %s"
msgstr "Typ popisu disku: %s"

#: disk-utils/fdisk-list.c:47
#, c-format
msgid "Disk identifier: %s"
msgstr "Identifikátor disku: %s"

#: disk-utils/fdisk-list.c:61
#, c-format
msgid "Disk %s: %s, %ju bytes, %ju sectors"
msgstr "Disk %s: %s, %'ju bajtů, %'ju sektorů"

#: disk-utils/fdisk-list.c:68
#, c-format
msgid "Disk model: %s"
msgstr "Model disku: %s"

#: disk-utils/fdisk-list.c:71
#, c-format
msgid "Geometry: %d heads, %llu sectors/track, %llu cylinders"
msgstr "Geometrie: hlav: %'d, sektorů na stopu: %'llu, cylindrů: %'llu"

#: disk-utils/fdisk-list.c:76 disk-utils/fdisk-list.c:299
#, c-format
msgid "Units: %s of %d * %ld = %ld bytes"
msgstr "Jednotky: %s po %d * %ld = %'ld bajtech"

#: disk-utils/fdisk-list.c:82 disk-utils/fdisk-list.c:305
#, c-format
msgid "Sector size (logical/physical): %lu bytes / %lu bytes"
msgstr "Velikost sektoru (logického/fyzického): %lu bajtů / %lu bajtů"

#: disk-utils/fdisk-list.c:85
#, c-format
msgid "I/O size (minimum/optimal): %lu bytes / %lu bytes"
msgstr "Velikost I/O (minimální/optimální): %lu bajtů / %lu bajtů"

#: disk-utils/fdisk-list.c:89
#, c-format
msgid "Alignment offset: %lu bytes"
msgstr "Zarovnávací posun: %lu bajtů"

#: disk-utils/fdisk-list.c:120 disk-utils/fdisk-list.c:241
#: disk-utils/fsck.c:1253
msgid "failed to allocate iterator"
msgstr "alokace iterátoru selhala"

#: disk-utils/fdisk-list.c:126 disk-utils/fdisk-list.c:247
#: disk-utils/partx.c:669 login-utils/lslogins.c:1066 misc-utils/fincore.c:356
#: misc-utils/findmnt.c:1634 misc-utils/lsblk.c:2083 misc-utils/lslocks.c:456
#: misc-utils/uuidparse.c:252 misc-utils/wipefs.c:157 sys-utils/losetup.c:325
#: sys-utils/lscpu.c:1674 sys-utils/lscpu.c:1902 sys-utils/lscpu.c:2034
#: sys-utils/lsipc.c:351 sys-utils/prlimit.c:297 sys-utils/rfkill.c:459
#: sys-utils/swapon.c:283 sys-utils/wdctl.c:299 sys-utils/zramctl.c:496
#: text-utils/column.c:209
msgid "failed to allocate output table"
msgstr "výstupní tabulku se nepodařilo alokovat"

#: disk-utils/fdisk-list.c:167 disk-utils/fdisk-list.c:271
#: disk-utils/partx.c:583 login-utils/lslogins.c:1124 misc-utils/fincore.c:123
#: misc-utils/findmnt.c:697 misc-utils/findmnt.c:715 misc-utils/lsblk.c:1078
#: misc-utils/lslocks.c:393 misc-utils/uuidparse.c:154 misc-utils/wipefs.c:224
#: sys-utils/losetup.c:348 sys-utils/losetup.c:377 sys-utils/lscpu.c:1707
#: sys-utils/lscpu.c:1930 sys-utils/lscpu.c:1958 sys-utils/lsipc.c:480
#: sys-utils/lsipc.c:555 sys-utils/lsipc.c:657 sys-utils/lsipc.c:749
#: sys-utils/lsipc.c:910 sys-utils/prlimit.c:229 sys-utils/rfkill.c:376
#: sys-utils/swapon.c:179 sys-utils/wdctl.c:249 sys-utils/zramctl.c:414
#: text-utils/column.c:453 text-utils/column.c:474
msgid "failed to allocate output line"
msgstr "výstupní řádek se nepodařilo alokovat"

#: disk-utils/fdisk-list.c:177 disk-utils/fdisk-list.c:278
#: disk-utils/partx.c:646 login-utils/lslogins.c:1225 misc-utils/fincore.c:159
#: misc-utils/findmnt.c:701 misc-utils/findmnt.c:720 misc-utils/lsblk.c:1119
#: misc-utils/lslocks.c:443 misc-utils/uuidparse.c:239 misc-utils/wipefs.c:264
#: sys-utils/losetup.c:305 sys-utils/lscpu.c:1773 sys-utils/lscpu.c:1938
#: sys-utils/lscpu.c:1962 sys-utils/lscpu.c:1970 sys-utils/lsipc.c:514
#: sys-utils/lsipc.c:639 sys-utils/prlimit.c:261 sys-utils/rfkill.c:404
#: sys-utils/swapon.c:227 sys-utils/wdctl.c:277 sys-utils/zramctl.c:481
#: text-utils/column.c:460
msgid "failed to add output data"
msgstr "přidání výstupních data selhalo"

#: disk-utils/fdisk-list.c:197
#, c-format
msgid "Partition %zu does not start on physical sector boundary."
msgstr "Oddíl %zu nezačíná na hranici fyzického sektoru."

#: disk-utils/fdisk-list.c:205
#, c-format
msgid "Filesystem/RAID signature on partition %zu will be wiped."
msgstr "Vzorec souborového systému / diskového pole bude na oddílu %zu vymazán."

#: disk-utils/fdisk-list.c:214
msgid "Partition table entries are not in disk order."
msgstr "Diskové oddíly jsou chybně seřazeny."

#: disk-utils/fdisk-list.c:233 libfdisk/src/bsd.c:1026 libfdisk/src/dos.c:2600
#: libfdisk/src/gpt.c:3141 libfdisk/src/sgi.c:1158 libfdisk/src/sun.c:1130
msgid "Start"
msgstr "Začátek"

#: disk-utils/fdisk-list.c:233 libfdisk/src/bsd.c:1027 libfdisk/src/dos.c:2601
#: libfdisk/src/gpt.c:3142 libfdisk/src/sgi.c:1159 libfdisk/src/sun.c:1131
msgid "End"
msgstr "Konec"

#: disk-utils/fdisk-list.c:233 libfdisk/src/bsd.c:1028 libfdisk/src/dos.c:2602
#: libfdisk/src/gpt.c:3143 libfdisk/src/sgi.c:1160 libfdisk/src/sun.c:1132
msgid "Sectors"
msgstr "Sektory"

#: disk-utils/fdisk-list.c:233 libfdisk/src/bsd.c:1030 libfdisk/src/dos.c:2604
#: libfdisk/src/gpt.c:3144 libfdisk/src/sgi.c:1162 libfdisk/src/sun.c:1134
msgid "Size"
msgstr "Velikost"

#: disk-utils/fdisk-list.c:293
#, c-format
msgid "Unpartitioned space %s: %s, %ju bytes, %ju sectors"
msgstr "Nerozdělené místo %s: %s, %'ju bajtů, %'ju sektorů"

#: disk-utils/fdisk-list.c:483
#, c-format
msgid "%s unknown column: %s"
msgstr "neznámý sloupec %s: %s"

#: disk-utils/fdisk-menu.c:96
msgid "Generic"
msgstr "Obecné"

#: disk-utils/fdisk-menu.c:97
msgid "delete a partition"
msgstr "smaže oddíl"

#: disk-utils/fdisk-menu.c:98
msgid "list free unpartitioned space"
msgstr "vypíše volné nerozdělené místo"

#: disk-utils/fdisk-menu.c:99
msgid "list known partition types"
msgstr "vypíše známé typy oddílů"

#: disk-utils/fdisk-menu.c:100
msgid "add a new partition"
msgstr "přidá nový oddíl"

#: disk-utils/fdisk-menu.c:101
msgid "print the partition table"
msgstr "zobrazí tabulku rozdělení disku"

#: disk-utils/fdisk-menu.c:102
msgid "change a partition type"
msgstr "změní typ oddílu"

#: disk-utils/fdisk-menu.c:103
msgid "verify the partition table"
msgstr "ověří tabulku rozdělení disku"

#: disk-utils/fdisk-menu.c:104
msgid "print information about a partition"
msgstr "vypíše údaje o oddílu"

#: disk-utils/fdisk-menu.c:106
msgid "print the raw data of the first sector from the device"
msgstr "vypíše surová data z prvního sektoru zařízení"

#: disk-utils/fdisk-menu.c:107
msgid "print the raw data of the disklabel from the device"
msgstr "vypíše surová data tabulky rozdělení disku na zařízení"

#: disk-utils/fdisk-menu.c:108
msgid "fix partitions order"
msgstr "opraví řazení oddílů"

#: disk-utils/fdisk-menu.c:110
msgid "Misc"
msgstr "Ostatní"

#: disk-utils/fdisk-menu.c:111
msgid "print this menu"
msgstr "vypíše tuto nabídku"

#: disk-utils/fdisk-menu.c:112
msgid "change display/entry units"
msgstr "změní jednotky v nichž jsou vypisovány informace"

#: disk-utils/fdisk-menu.c:113
msgid "extra functionality (experts only)"
msgstr "rozšiřující funkce (pouze pro odborníky)"

#: disk-utils/fdisk-menu.c:115
msgid "Script"
msgstr "Skript"

#: disk-utils/fdisk-menu.c:116
msgid "load disk layout from sfdisk script file"
msgstr "zavede rozvržení disku ze souboru se sfdiskovým skriptem"

#: disk-utils/fdisk-menu.c:117
msgid "dump disk layout to sfdisk script file"
msgstr "exportuje rozvržení disku do souboru se sfdiskovým skriptem"

#: disk-utils/fdisk-menu.c:119
msgid "Save & Exit"
msgstr "Uložení a konec"

#: disk-utils/fdisk-menu.c:120
msgid "write table to disk and exit"
msgstr "uloží tabulku rozdělení disku a ukončí program"

#: disk-utils/fdisk-menu.c:121
msgid "write table to disk"
msgstr "uloží tabulku na disk"

#: disk-utils/fdisk-menu.c:122
msgid "quit without saving changes"
msgstr "ukončí program bez uložení změn"

#: disk-utils/fdisk-menu.c:123
msgid "return to main menu"
msgstr "návrat do hlavní nabídky"

#: disk-utils/fdisk-menu.c:125
msgid "return from BSD to DOS"
msgstr "návrat z BSD fo DOS"

#: disk-utils/fdisk-menu.c:127 disk-utils/fdisk-menu.c:226
msgid "return from protective/hybrid MBR to GPT"
msgstr "návrat z ochranné/hybridní MBR do GPT"

#: disk-utils/fdisk-menu.c:138
msgid "Create a new label"
msgstr "Vytvoření nového popisu disku"

#: disk-utils/fdisk-menu.c:139
msgid "create a new empty GPT partition table"
msgstr "vytvoří prázdnou tabulku rozdělení disků typu GPT"

#: disk-utils/fdisk-menu.c:140
msgid "create a new empty SGI (IRIX) partition table"
msgstr "vytvoří prázdnou tabulku rozdělení disků typu SGI (IRIX)"

#: disk-utils/fdisk-menu.c:141
msgid "create a new empty DOS partition table"
msgstr "vytvoří prázdnou tabulku rozdělení disků typu DOS"

#: disk-utils/fdisk-menu.c:142
msgid "create a new empty Sun partition table"
msgstr "vytvoří prázdnou tabulku rozdělení disků typu Sun"

#: disk-utils/fdisk-menu.c:146
msgid "create an IRIX (SGI) partition table"
msgstr "vytvoří tabulku rozdělení disku typu IRIX (SGI)"

#: disk-utils/fdisk-menu.c:155
msgid "Geometry (for the current label)"
msgstr "Geometrie (pro současný popis disku)"

#: disk-utils/fdisk-menu.c:156
msgid "change number of cylinders"
msgstr "změní množství cylindrů"

#: disk-utils/fdisk-menu.c:157
msgid "change number of heads"
msgstr "změní množství hlav"

#: disk-utils/fdisk-menu.c:158
msgid "change number of sectors/track"
msgstr "změní počet sektorů na stopu"

#: disk-utils/fdisk-menu.c:167 include/pt-mbr-partnames.h:98
msgid "GPT"
msgstr "GPT"

#: disk-utils/fdisk-menu.c:168
msgid "change disk GUID"
msgstr "změní GUID disku"

#: disk-utils/fdisk-menu.c:169
msgid "change partition name"
msgstr "změní název oddílu"

#: disk-utils/fdisk-menu.c:170
msgid "change partition UUID"
msgstr "změní UUID oddílu"

#: disk-utils/fdisk-menu.c:171
msgid "change table length"
msgstr "změní délku tabulky"

#: disk-utils/fdisk-menu.c:172
msgid "enter protective/hybrid MBR"
msgstr "vloží ochrannou/hybridní MBR"

#: disk-utils/fdisk-menu.c:175
msgid "toggle the legacy BIOS bootable flag"
msgstr "přepne zastaralý příznak BIOSu „startovací“"

#: disk-utils/fdisk-menu.c:176
msgid "toggle the no block IO protocol flag"
msgstr "přepne příznak „žádný blokový I/O protokol“"

#: disk-utils/fdisk-menu.c:177
msgid "toggle the required partition flag"
msgstr "přepne vyžadovaný příznak oddílu"

#: disk-utils/fdisk-menu.c:178
msgid "toggle the GUID specific bits"
msgstr "přepne bity specifické pro GUID"

#: disk-utils/fdisk-menu.c:188
msgid "Sun"
msgstr "Sun"

#: disk-utils/fdisk-menu.c:189
msgid "toggle the read-only flag"
msgstr "přepne příznak „pouze pro čtení“"

#: disk-utils/fdisk-menu.c:190
msgid "toggle the mountable flag"
msgstr "přepne příznak „připojitelný“"

#: disk-utils/fdisk-menu.c:192
msgid "change number of alternate cylinders"
msgstr "změní množství alternativních cylindrů"

#: disk-utils/fdisk-menu.c:193
msgid "change number of extra sectors per cylinder"
msgstr "změní množství extra sektorů na stopu"

#: disk-utils/fdisk-menu.c:194
msgid "change interleave factor"
msgstr "změní prokládací faktor"

#: disk-utils/fdisk-menu.c:195
msgid "change rotation speed (rpm)"
msgstr "změní rychlost otáčení"

#: disk-utils/fdisk-menu.c:196
msgid "change number of physical cylinders"
msgstr "změní počet fyzických cylindrů"

#: disk-utils/fdisk-menu.c:205
msgid "SGI"
msgstr "SGI"

#: disk-utils/fdisk-menu.c:206
msgid "select bootable partition"
msgstr "nastaví startovací oddíl"

#: disk-utils/fdisk-menu.c:207
msgid "edit bootfile entry"
msgstr "úprava položky startovacího souboru"

#: disk-utils/fdisk-menu.c:208
msgid "select sgi swap partition"
msgstr "nastaví SGI odkládací oddíl"

#: disk-utils/fdisk-menu.c:209
msgid "create SGI info"
msgstr "vytvoří údaje SGI"

#: disk-utils/fdisk-menu.c:218
msgid "DOS (MBR)"
msgstr "DOS (MBR)"

#: disk-utils/fdisk-menu.c:219
msgid "toggle a bootable flag"
msgstr "přepne příznak „startovací“"

#: disk-utils/fdisk-menu.c:220
msgid "edit nested BSD disklabel"
msgstr "upraví vnořený BSD popisu disku"

#: disk-utils/fdisk-menu.c:221
msgid "toggle the dos compatibility flag"
msgstr "přepne příznak kompatibility s DOSem"

#: disk-utils/fdisk-menu.c:223
msgid "move beginning of data in a partition"
msgstr "posune počátek dat v oddílu"

#: disk-utils/fdisk-menu.c:224
msgid "change the disk identifier"
msgstr "změní identifikátor disku"

#: disk-utils/fdisk-menu.c:236
msgid "BSD"
msgstr "BSD"

#: disk-utils/fdisk-menu.c:237
msgid "edit drive data"
msgstr "upraví data na disku"

#: disk-utils/fdisk-menu.c:238
msgid "install bootstrap"
msgstr "nainstaluje zavaděč"

#: disk-utils/fdisk-menu.c:239
msgid "show complete disklabel"
msgstr "zobrazí úplný popis disku"

#: disk-utils/fdisk-menu.c:240
msgid "link BSD partition to non-BSD partition"
msgstr "připojí BSD oddíl na ne-BSD oddíl"

#: disk-utils/fdisk-menu.c:372
#, c-format
msgid ""
"\n"
"Help (expert commands):\n"
msgstr ""
"\n"
"Nápověda (příkazy pro odborníky):\n"

#: disk-utils/fdisk-menu.c:374 disk-utils/sfdisk.c:1435
#, c-format
msgid ""
"\n"
"Help:\n"
msgstr ""
"\n"
"Nápověda:\n"

#: disk-utils/fdisk-menu.c:394
#, c-format
msgid "You're editing nested '%s' partition table, primary partition table is '%s'."
msgstr "Upravujete vnořenou tabulku rozdělení disku „%s“, prvotní tabulka je „%s“."

#: disk-utils/fdisk-menu.c:424
msgid "Expert command (m for help): "
msgstr "Příkaz pro odborníky (m pro nápovědu): "

#: disk-utils/fdisk-menu.c:426
msgid "Command (m for help): "
msgstr "Příkaz (m pro nápovědu): "

#: disk-utils/fdisk-menu.c:436
msgid ""
"\n"
"All unwritten changes will be lost, do you really want to quit? "
msgstr ""
"\n"
"Všechny nezapsané změny budou ztraceny. Opravdu chcete skončit? "

#: disk-utils/fdisk-menu.c:449
#, c-format
msgid "%c: unknown command"
msgstr "%c: příkaz není znám"

#: disk-utils/fdisk-menu.c:474 disk-utils/fdisk-menu.c:507
msgid "Enter script file name"
msgstr "Zadejte název souboru se skriptem"

#: disk-utils/fdisk-menu.c:486
msgid "Resetting fdisk!"
msgstr "Program fdisk se resetuje!"

#: disk-utils/fdisk-menu.c:493
msgid "Script successfully applied."
msgstr "Skript byl úspěšně použit."

#: disk-utils/fdisk-menu.c:519
msgid "Failed to transform disk layout into script"
msgstr "Převod rozvržení disku do skriptu selhalo"

#: disk-utils/fdisk-menu.c:533
msgid "Script successfully saved."
msgstr "Skript úspěšně uložen."

#: disk-utils/fdisk-menu.c:556 disk-utils/sfdisk.c:1661
#, c-format
msgid "Partition #%zu contains a %s signature."
msgstr "Oddíl %zu obsahuje vzorec %s."

#: disk-utils/fdisk-menu.c:559 disk-utils/sfdisk.c:1664
msgid "Do you want to remove the signature?"
msgstr "Chcete vzorec odstranit?"

#: disk-utils/fdisk-menu.c:564 disk-utils/sfdisk.c:1669
msgid "The signature will be removed by a write command."
msgstr "Vzorec bude odstraněn příkazem k zápisu."

#: disk-utils/fdisk-menu.c:597
msgid "failed to write disklabel"
msgstr "zápis popisu disku selhal"

#: disk-utils/fdisk-menu.c:640
msgid "Failed to fix partitions order."
msgstr "Oprava řazení oddílů selhala."

#: disk-utils/fdisk-menu.c:642
msgid "Partitions order fixed."
msgstr "Řazení oddílů opraveno."

#: disk-utils/fdisk-menu.c:660
#, c-format
msgid "Could not delete partition %zu"
msgstr "Oddíl %zu nebylo možné smazat"

#: disk-utils/fdisk-menu.c:689
msgid "Changing display/entry units to cylinders (DEPRECATED!)."
msgstr "Jednotky pro zobrazení/vstup změněny na cylindry (ZASTARALÉ!)."

#: disk-utils/fdisk-menu.c:691
msgid "Changing display/entry units to sectors."
msgstr "Jednotky pro zobrazení/vstup změněny na sektory."

#: disk-utils/fdisk-menu.c:701 disk-utils/fdisk-menu.c:872
msgid "Leaving nested disklabel."
msgstr "Vnořený BSD popis disku ponechán."

#: disk-utils/fdisk-menu.c:738
msgid "New maximum entries"
msgstr "Nové maximum položek"

#: disk-utils/fdisk-menu.c:749
msgid "Entering protective/hybrid MBR disklabel."
msgstr "Vstupuje se do chráněného/hybridního popisu disku MBR."

#: disk-utils/fdisk-menu.c:765
msgid "New UUID (in 8-4-4-4-12 format)"
msgstr "Nové UUID (formát 8-4-4-4-12)"

#: disk-utils/fdisk-menu.c:780
msgid "New name"
msgstr "Nový název"

#: disk-utils/fdisk-menu.c:843
msgid "Entering nested BSD disklabel."
msgstr "Vstupuje se do vnořeného BSD popisu disku."

#: disk-utils/fdisk-menu.c:1041
msgid "Number of cylinders"
msgstr "Počet cylindrů"

#: disk-utils/fdisk-menu.c:1048
msgid "Number of heads"
msgstr "Počet hlav"

#: disk-utils/fdisk-menu.c:1054
msgid "Number of sectors"
msgstr "Počet sektorů"

#: disk-utils/fsck.c:213
#, c-format
msgid "%s is mounted\n"
msgstr "%s je připojeno\n"

#: disk-utils/fsck.c:215
#, c-format
msgid "%s is not mounted\n"
msgstr "%s není připojeno\n"

#: disk-utils/fsck.c:329 disk-utils/fsck.cramfs.c:174
#: disk-utils/fsck.cramfs.c:181 disk-utils/fsck.cramfs.c:237
#: disk-utils/fsck.cramfs.c:258 disk-utils/sfdisk.c:305 libfdisk/src/bsd.c:647
#: login-utils/last.c:208 login-utils/last.c:245 login-utils/sulogin.c:657
#: misc-utils/hardlink.c:290 misc-utils/hardlink.c:292
#: sys-utils/ctrlaltdel.c:44 sys-utils/irq-common.c:220 sys-utils/rfkill.c:213
#: sys-utils/setpriv.c:268 term-utils/setterm.c:746 term-utils/setterm.c:802
#: term-utils/setterm.c:806 term-utils/setterm.c:813
#, c-format
msgid "cannot read %s"
msgstr "z %s nelze číst"

#: disk-utils/fsck.c:331
#, c-format
msgid "parse error: %s"
msgstr "chyba rozebírání: %s"

#: disk-utils/fsck.c:358
#, c-format
msgid "cannot create directory %s"
msgstr "adresář %s nelze vytvořit"

#: disk-utils/fsck.c:371
#, c-format
msgid "Locking disk by %s ... "
msgstr "Zamyká se disk pomocí %s… "

#: disk-utils/fsck.c:382
#, c-format
msgid "(waiting) "
msgstr "(čeká se)"

#. TRANSLATORS: These are followups to "Locking disk...".
#: disk-utils/fsck.c:392
msgid "succeeded"
msgstr "uspělo"

#: disk-utils/fsck.c:392
msgid "failed"
msgstr "selhalo"

#: disk-utils/fsck.c:409
#, c-format
msgid "Unlocking %s.\n"
msgstr "Odemyká se %s.\n"

#: disk-utils/fsck.c:440
#, c-format
msgid "failed to setup description for %s"
msgstr "nastavení popisu u %s selhalo"

#: disk-utils/fsck.c:470 misc-utils/findmnt.c:793 misc-utils/lsblk-mnt.c:17
#: sys-utils/mount.c:95 sys-utils/swapon-common.c:19 sys-utils/umount.c:51
#, c-format
msgid "%s: parse error at line %d -- ignored"
msgstr "%s: chyba rozboru na řádku %d – ignorováno"

#: disk-utils/fsck.c:502 disk-utils/fsck.c:504
#, c-format
msgid "%s: failed to parse fstab"
msgstr "%s: fstab se nepodařilo rozebrat"

#: disk-utils/fsck.c:685 login-utils/login.c:1016 login-utils/sulogin.c:1024
#: login-utils/vipw.c:208 sys-utils/flock.c:348 sys-utils/nsenter.c:182
#: sys-utils/swapon.c:319 sys-utils/unshare.c:242 sys-utils/unshare.c:567
msgid "fork failed"
msgstr "volání fork selhalo"

#: disk-utils/fsck.c:692
#, c-format
msgid "%s: execute failed"
msgstr "%s: spuštění se selhalo"

#: disk-utils/fsck.c:780
msgid "wait: no more child process?!?"
msgstr "wait: Žádní další potomci?!"

#: disk-utils/fsck.c:783 sys-utils/flock.c:366 sys-utils/swapon.c:351
#: sys-utils/unshare.c:594 sys-utils/unshare.c:607
msgid "waitpid failed"
msgstr "volání waitpid selhalo"

#: disk-utils/fsck.c:801
#, c-format
msgid "Warning... %s for device %s exited with signal %d."
msgstr "Varování… %s nad zařízením %s skončil signálem %d."

#: disk-utils/fsck.c:807
#, c-format
msgid "%s %s: status is %x, should never happen."
msgstr "%s %s: status je %x, to by nikdy nemělo přihodit."

#: disk-utils/fsck.c:853
#, c-format
msgid "Finished with %s (exit status %d)\n"
msgstr "%s dokončeno (návratový kód %d)\n"

#: disk-utils/fsck.c:934
#, c-format
msgid "error %d (%m) while executing fsck.%s for %s"
msgstr "chyba %d (%m) při provádění fsck.%s nad %s"

#: disk-utils/fsck.c:1000
msgid ""
"Either all or none of the filesystem types passed to -t must be prefixed\n"
"with 'no' or '!'."
msgstr ""
"Buďto všechny, nebo žádný z typů souborových systémů předaných v -t musí\n"
"být uvedeny s počátečním „no“ nebo „!“."

#: disk-utils/fsck.c:1116
#, c-format
msgid "%s: skipping bad line in /etc/fstab: bind mount with nonzero fsck pass number"
msgstr ""
"%s: přeskakuje se chybný řádek v /etc/fstab: přípojný bod typu bind\n"
"s nenulovým pořadím kontroly"

#: disk-utils/fsck.c:1128
#, c-format
msgid "%s: skipping nonexistent device\n"
msgstr "%s: přeskakuje se neexistující zařízení\n"

#: disk-utils/fsck.c:1133
#, c-format
msgid "%s: nonexistent device (\"nofail\" fstab option may be used to skip this device)\n"
msgstr "%s: neexistující zařízení (zařízení lze vynechat uvedením volby „nofail“ do fstabu)\n"

#: disk-utils/fsck.c:1150
#, c-format
msgid "%s: skipping unknown filesystem type\n"
msgstr "%s: neznámý typ systému souborů bude přeskočen\n"

#: disk-utils/fsck.c:1164
#, c-format
msgid "cannot check %s: fsck.%s not found"
msgstr "%s nelze zkontrolovat: fsck.%s nenalezen"

#: disk-utils/fsck.c:1268
msgid "Checking all file systems.\n"
msgstr "Kontroluji všechny systému souborů.\n"

#: disk-utils/fsck.c:1359
#, c-format
msgid "--waiting-- (pass %d)\n"
msgstr "– čeká se – (průchod %d)\n"

#: disk-utils/fsck.c:1385
#, c-format
msgid " %s [options] -- [fs-options] [<filesystem> ...]\n"
msgstr "%s [přepínače] -- [přepínače_ss] [<souborový_systém>…]\n"

#: disk-utils/fsck.c:1389
msgid "Check and repair a Linux filesystem.\n"
msgstr "Zkontroluje a opraví linuxový souborový systém.\n"

#: disk-utils/fsck.c:1392
msgid " -A         check all filesystems\n"
msgstr " -A         zkontroluje všechny souborové systémy\n"

#: disk-utils/fsck.c:1393
msgid " -C [<fd>]  display progress bar; file descriptor is for GUIs\n"
msgstr " -C [<fd>]  zobrazí ukazatel postupu; deskriptor souboru je pro GUI\n"

#: disk-utils/fsck.c:1394
msgid " -l         lock the device to guarantee exclusive access\n"
msgstr " -l         zamkne zařízení, aby byl zaručen výlučný přístup\n"

#: disk-utils/fsck.c:1395
msgid " -M         do not check mounted filesystems\n"
msgstr " -M         nekontroluje připojené souborové systémy\n"

#: disk-utils/fsck.c:1396
msgid " -N         do not execute, just show what would be done\n"
msgstr " -N         nic nevykoná, pouze zobrazí, co by se udělalo\n"

#: disk-utils/fsck.c:1397
msgid " -P         check filesystems in parallel, including root\n"
msgstr " -P         souborové systémy kontroluje paralelně, včetně kořenového\n"

#: disk-utils/fsck.c:1398
msgid " -R         skip root filesystem; useful only with '-A'\n"
msgstr " -R         vynechá kořenový souborový systém; užitečné je s „-A“\n"

#: disk-utils/fsck.c:1399
msgid ""
" -r [<fd>]  report statistics for each device checked;\n"
"            file descriptor is for GUIs\n"
msgstr ""
" -r [<fd>]  hlásí statistické údaje pro každé kontrolované zařízení;\n"
"            deskriptor souboru je pro grafická rozhraní\n"

#: disk-utils/fsck.c:1401
msgid " -s         serialize the checking operations\n"
msgstr " -s         kontrolní operace vykonává postupně\n"

#: disk-utils/fsck.c:1402
msgid " -T         do not show the title on startup\n"
msgstr " -T         při spuštění nezobrazí nadpis\n"

#: disk-utils/fsck.c:1403
msgid ""
" -t <type>  specify filesystem types to be checked;\n"
"            <type> is allowed to be a comma-separated list\n"
msgstr ""
" -t <typ>   určuje druhy souborových systémů, které se mají zkontrolovat;\n"
"            typ smí být čárkou oddělený seznam\n"

#: disk-utils/fsck.c:1405
msgid " -V         explain what is being done\n"
msgstr " -V         vysvětlí, co se děje\n"

#: disk-utils/fsck.c:1411
msgid "See the specific fsck.* commands for available fs-options."
msgstr "Přepínače souborových systémů naleznete v dokumentaci jednotlivých příkazů fsck.*."

#: disk-utils/fsck.c:1456
msgid "too many devices"
msgstr "příliš mnoho zařízení"

#: disk-utils/fsck.c:1468
msgid "Is /proc mounted?"
msgstr "Je /proc připojeno?"

#: disk-utils/fsck.c:1476
#, c-format
msgid "must be root to scan for matching filesystems: %s"
msgstr "jen root může hledat odpovídající souborové systémy: %s"

#: disk-utils/fsck.c:1480
#, c-format
msgid "couldn't find matching filesystem: %s"
msgstr "nebylo možné nalézt odpovídající systém souborů: %s"

#: disk-utils/fsck.c:1488 disk-utils/fsck.c:1585 misc-utils/kill.c:281
#: sys-utils/eject.c:279
msgid "too many arguments"
msgstr "příliš mnoho argumentů"

#: disk-utils/fsck.c:1543 disk-utils/fsck.c:1546
msgid "invalid argument of -r"
msgstr "neplatný argument přepínače –r"

#: disk-utils/fsck.c:1558
#, c-format
msgid "option '%s' may be specified only once"
msgstr "přepínač „%s“ lze zadat jen jednou"

#: disk-utils/fsck.c:1565 misc-utils/kill.c:327 misc-utils/kill.c:343
#, c-format
msgid "option '%s' requires an argument"
msgstr "přepínač „%s“ vyžaduje argument"

#: disk-utils/fsck.c:1596
#, c-format
msgid "invalid argument of -r: %d"
msgstr "neplatný argument přepínače -r: %d"

#: disk-utils/fsck.c:1639
msgid "the -l option can be used with one device only -- ignore"
msgstr "přepínač -l lze použít pouze s jedním zařízením – ignoruje se"

#: disk-utils/fsck.cramfs.c:111
#, c-format
msgid " %s [options] <file>\n"
msgstr " %s [přepínače] <soubor>\n"

#: disk-utils/fsck.cramfs.c:114
msgid "Check and repair a compressed ROM filesystem.\n"
msgstr "Zkontroluje a opraví komprimovaný souborový systém ROM.\n"

#: disk-utils/fsck.cramfs.c:117
msgid " -a                       for compatibility only, ignored\n"
msgstr " -a                       jen z důvodů kompatibility, ignoruje se\n"

#: disk-utils/fsck.cramfs.c:118
msgid " -v, --verbose            be more verbose\n"
msgstr " -v, --verbose                vypisuje podrobné hlášky\n"

#: disk-utils/fsck.cramfs.c:119
msgid " -y                       for compatibility only, ignored\n"
msgstr " -y                       jen z důvodů kompatibility, ignoruje se\n"

#: disk-utils/fsck.cramfs.c:120
msgid " -b, --blocksize <size>   use this blocksize, defaults to page size\n"
msgstr ""
" -b, --blocksize <velikost>\n"
"                          použije tuto velikost bloku, výchozí je\n"
"                          velikost stránky\n"

#: disk-utils/fsck.cramfs.c:121
msgid "     --extract[=<dir>]    test uncompression, optionally extract into <dir>\n"
msgstr ""
"     --extract[=<adresář>]\n"
"                          vyzkouší dekompresi, volitelně rozbalení do\n"
"                          <adresáře>\n"

#: disk-utils/fsck.cramfs.c:161
#, c-format
msgid "ioctl failed: unable to determine device size: %s"
msgstr "IOCTL selhalo: velikost zařízení není možné určit: %s"

#: disk-utils/fsck.cramfs.c:167
#, c-format
msgid "not a block device or file: %s"
msgstr "není blokovým zařízením ani souborem: %s"

#: disk-utils/fsck.cramfs.c:170 disk-utils/fsck.cramfs.c:206
msgid "file length too short"
msgstr "délka souboru je příliš krátká"

#: disk-utils/fsck.cramfs.c:179 disk-utils/fsck.cramfs.c:234
#: disk-utils/fsck.cramfs.c:254 libfdisk/src/bsd.c:719 libfdisk/src/bsd.c:901
#: login-utils/last.c:203 login-utils/last.c:237 sys-utils/fallocate.c:206
#, c-format
msgid "seek on %s failed"
msgstr "chyba při změně pozice v %s"

#: disk-utils/fsck.cramfs.c:185 disk-utils/fsck.cramfs.c:187
msgid "superblock magic not found"
msgstr "magická značka superbloku nenalezena"

#: disk-utils/fsck.cramfs.c:190
#, c-format
msgid "cramfs endianness is %s\n"
msgstr "endianita cramfs je %s\n"

# endianity is
#: disk-utils/fsck.cramfs.c:191
msgid "big"
msgstr "velká"

# endianity is
#: disk-utils/fsck.cramfs.c:191
msgid "little"
msgstr "malá"

#: disk-utils/fsck.cramfs.c:195
msgid "unsupported filesystem features"
msgstr "nepodporované vlastnosti systému souborů"

#: disk-utils/fsck.cramfs.c:199
#, c-format
msgid "superblock size (%d) too small"
msgstr "velikost superbloku (%d) je příliš malá"

#: disk-utils/fsck.cramfs.c:204
msgid "zero file count"
msgstr "nulový počet souborů"

#: disk-utils/fsck.cramfs.c:208
msgid "file extends past end of filesystem"
msgstr "soubor přesahuje za konec souborového systému"

#: disk-utils/fsck.cramfs.c:210
msgid "old cramfs format"
msgstr "starý formát cramfs"

#: disk-utils/fsck.cramfs.c:219
msgid "unable to test CRC: old cramfs format"
msgstr "CRC není možné zkontrolovat: starý formát cramfs"

# TODO: Pluralize
#: disk-utils/fsck.cramfs.c:239
#, c-format
msgid "failed to read %<PRIu32> bytes from file %s"
msgstr "načtení %<PRIu32> bajtů ze souboru %s selhalo"

#: disk-utils/fsck.cramfs.c:277
msgid "crc error"
msgstr "chyba CRC"

#: disk-utils/fsck.cramfs.c:307 disk-utils/fsck.minix.c:558
msgid "seek failed"
msgstr "chyba při posunu ukazovátka"

#: disk-utils/fsck.cramfs.c:311
msgid "read romfs failed"
msgstr "čtení romfs selhalo"

#: disk-utils/fsck.cramfs.c:343
msgid "root inode is not directory"
msgstr "kořenový i-uzel není adresářem"

#: disk-utils/fsck.cramfs.c:347
#, c-format
msgid "bad root offset (%lu)"
msgstr "chybné umístění kořene (%lu)"

#: disk-utils/fsck.cramfs.c:365
msgid "data block too large"
msgstr "příliš velký datový blok"

#: disk-utils/fsck.cramfs.c:369
#, c-format
msgid "decompression error: %s"
msgstr "chyba dekomprese: %s"

#: disk-utils/fsck.cramfs.c:395
#, c-format
msgid "  hole at %lu (%zu)\n"
msgstr "  díra na %lu (%zu)\n"

#: disk-utils/fsck.cramfs.c:402 disk-utils/fsck.cramfs.c:554
#, c-format
msgid "  uncompressing block at %lu to %lu (%lu)\n"
msgstr "  rozbaluje se blok od %lu do %lu (%lu)\n"

#: disk-utils/fsck.cramfs.c:409
#, c-format
msgid "non-block (%ld) bytes"
msgstr "ne-blokové (%ld) bajty"

#: disk-utils/fsck.cramfs.c:413
#, c-format
msgid "non-size (%ld vs %ld) bytes"
msgstr "ne-velikostní (%ld místo %ld) bajty"

#: disk-utils/fsck.cramfs.c:418 disk-utils/fsck.cramfs.c:520
#: disk-utils/swaplabel.c:109 misc-utils/uuidd.c:369 sys-utils/fallocate.c:414
#: sys-utils/rfkill.c:560 sys-utils/setpriv.c:634 sys-utils/setpriv.c:657
#: sys-utils/swapon.c:392 term-utils/script.c:318 term-utils/ttymsg.c:175
#, c-format
msgid "write failed: %s"
msgstr "volání write selhalo: %s"

#: disk-utils/fsck.cramfs.c:428
#, c-format
msgid "lchown failed: %s"
msgstr "volání lchown selhalo: %s"

#: disk-utils/fsck.cramfs.c:432
#, c-format
msgid "chown failed: %s"
msgstr "volání chown selhalo: %s"

#: disk-utils/fsck.cramfs.c:437
#, c-format
msgid "utimes failed: %s"
msgstr "volání utimes selhalo: %s"

#: disk-utils/fsck.cramfs.c:449
#, c-format
msgid "directory inode has zero offset and non-zero size: %s"
msgstr "i-uzel adresáře má nulovou pozici a nenulovou velikost: %s"

#: disk-utils/fsck.cramfs.c:464
#, c-format
msgid "mkdir failed: %s"
msgstr "volání mkdir selhalo: %s"

#: disk-utils/fsck.cramfs.c:480
msgid "filename length is zero"
msgstr "délka jména souboru je nulová"

#: disk-utils/fsck.cramfs.c:482
msgid "bad filename length"
msgstr "chybná délka jména souboru"

#: disk-utils/fsck.cramfs.c:488
msgid "bad inode offset"
msgstr "chybné umístění i-uzlu"

#: disk-utils/fsck.cramfs.c:503
msgid "file inode has zero offset and non-zero size"
msgstr "i-uzel souboru má nulovou pozici a nenulovou velikost"

#: disk-utils/fsck.cramfs.c:506
msgid "file inode has zero size and non-zero offset"
msgstr "i-uzel souboru má nulovou velikost a nenulovou pozici"

#: disk-utils/fsck.cramfs.c:535
msgid "symbolic link has zero offset"
msgstr "symbolický odkaz má nulovou pozici"

#: disk-utils/fsck.cramfs.c:537
msgid "symbolic link has zero size"
msgstr "symbolický odkaz má nulovou velikost"

#: disk-utils/fsck.cramfs.c:546
#, c-format
msgid "size error in symlink: %s"
msgstr "chyba v symbolickém odkazu: %s"

#: disk-utils/fsck.cramfs.c:560
#, c-format
msgid "symlink failed: %s"
msgstr "volání symlink selhalo: %s"

#: disk-utils/fsck.cramfs.c:573
#, c-format
msgid "special file has non-zero offset: %s"
msgstr "zvláštní soubor má nenulovou pozici: %s"

#: disk-utils/fsck.cramfs.c:583
#, c-format
msgid "fifo has non-zero size: %s"
msgstr "FIFO má nenulovou velikost: %s"

#: disk-utils/fsck.cramfs.c:589
#, c-format
msgid "socket has non-zero size: %s"
msgstr "socket má nenulovou velikost: %s"

#: disk-utils/fsck.cramfs.c:592
#, c-format
msgid "bogus mode: %s (%o)"
msgstr "podivný mód/práva: %s (%o)"

#: disk-utils/fsck.cramfs.c:601
#, c-format
msgid "mknod failed: %s"
msgstr "volání mknod selhalo: %s"

#: disk-utils/fsck.cramfs.c:633
#, c-format
msgid "directory data start (%lu) < sizeof(struct cramfs_super) + start (%zu)"
msgstr "počátek dat adresáře (%lu) < sizeof(struct cramfs_super) + počátek (%zu)"

#: disk-utils/fsck.cramfs.c:637
#, c-format
msgid "directory data end (%lu) != file data start (%lu)"
msgstr "konec dat adresáře (%lu) != počátek dat souboru (%lu)"

#: disk-utils/fsck.cramfs.c:641
msgid "invalid file data offset"
msgstr "chybné umístění dat souboru"

#: disk-utils/fsck.cramfs.c:689 disk-utils/mkfs.cramfs.c:736
msgid "invalid blocksize argument"
msgstr "neplatný argument velikosti bloku"

#: disk-utils/fsck.cramfs.c:712
#, c-format
msgid "%s: OK\n"
msgstr "%s: OK\n"

#: disk-utils/fsck.minix.c:185
msgid "Check the consistency of a Minix filesystem.\n"
msgstr "Zkontroluje souborový systém Minix.\n"

#: disk-utils/fsck.minix.c:187
msgid " -l, --list       list all filenames\n"
msgstr " -l, --list       vypíše všechny názvy souborů\n"

#: disk-utils/fsck.minix.c:188
msgid " -a, --auto       automatic repair\n"
msgstr " -a, --auto       automatická oprava\n"

#: disk-utils/fsck.minix.c:189
msgid " -r, --repair     interactive repair\n"
msgstr " -r, --repair     oprava s účastí uživatele\n"

#: disk-utils/fsck.minix.c:190
msgid " -v, --verbose    be verbose\n"
msgstr " -v, --verbose    podrobný režim\n"

#: disk-utils/fsck.minix.c:191
msgid " -s, --super      output super-block information\n"
msgstr " -s, --super      vypíše údaje ze superbloku\n"

#: disk-utils/fsck.minix.c:192
msgid " -m, --uncleared  activate mode not cleared warnings\n"
msgstr " -m, --uncleared  upozorňuje na nevymazaná přístupová práva\n"

#: disk-utils/fsck.minix.c:193
msgid " -f, --force      force check\n"
msgstr " -f, --force      vynutí kontrolu\n"

#. TRANSLATORS: these yes no questions uses rpmatch(), and should be
#. * translated.
#: disk-utils/fsck.minix.c:252
#, c-format
msgid "%s (y/n)? "
msgstr "%s (a/n)? "

#: disk-utils/fsck.minix.c:252
#, c-format
msgid "%s (n/y)? "
msgstr "%s (n/a)? "

#: disk-utils/fsck.minix.c:269
#, c-format
msgid "y\n"
msgstr "a\n"

#: disk-utils/fsck.minix.c:271
#, c-format
msgid "n\n"
msgstr "n\n"

#: disk-utils/fsck.minix.c:287
#, c-format
msgid "%s is mounted.\t "
msgstr "%s je již připojeno.\t"

#: disk-utils/fsck.minix.c:289
msgid "Do you really want to continue"
msgstr "Chcete opravdu pokračovat"

#: disk-utils/fsck.minix.c:293
#, c-format
msgid "check aborted.\n"
msgstr "prohlídka ukončena.\n"

#: disk-utils/fsck.minix.c:318 disk-utils/fsck.minix.c:339
#, c-format
msgid "Zone nr < FIRSTZONE in file `%s'."
msgstr "Číslo zóny < PRVNÍ_ZÓNA v souboru „%s“."

#: disk-utils/fsck.minix.c:321 disk-utils/fsck.minix.c:342
#, c-format
msgid "Zone nr >= ZONES in file `%s'."
msgstr "Číslo zóny >= počet ZÓN v souboru „%s“."

#: disk-utils/fsck.minix.c:325 disk-utils/fsck.minix.c:346
msgid "Remove block"
msgstr "Odstranit blok"

#: disk-utils/fsck.minix.c:362
#, c-format
msgid "Read error: unable to seek to block in file '%s'\n"
msgstr "Chyba při čtení: nelze se posunout na blok v souboru „%s“\n"

#: disk-utils/fsck.minix.c:368
#, c-format
msgid "Read error: bad block in file '%s'\n"
msgstr "Chyba při čtení: chybný blok v souboru „%s“\n"

#: disk-utils/fsck.minix.c:380
#, c-format
msgid ""
"Internal error: trying to write bad block\n"
"Write request ignored\n"
msgstr ""
"Vnitřní chyba: pokus o zápis chybného bloku.\n"
"Žádost o zápis ignorována.\n"

#: disk-utils/fsck.minix.c:386
msgid "seek failed in write_block"
msgstr "chyba při posunu ukazovátka ve write_block"

#: disk-utils/fsck.minix.c:389
#, c-format
msgid "Write error: bad block in file '%s'\n"
msgstr "Chyba při zápisu: chybný blok v souboru „%s“\n"

#: disk-utils/fsck.minix.c:423
#, c-format
msgid "Warning: block out of range\n"
msgstr "Pozor: blok je mimo rozsah\n"

#: disk-utils/fsck.minix.c:510
msgid "seek failed in write_super_block"
msgstr "chyba při posunu ukazovátka ve write_super_block"

#: disk-utils/fsck.minix.c:512
msgid "unable to write super-block"
msgstr "superblok nelze zapsat"

#: disk-utils/fsck.minix.c:524
msgid "Unable to write inode map"
msgstr "mapu i-uzlů nelze zapsat"

#: disk-utils/fsck.minix.c:527
msgid "Unable to write zone map"
msgstr "mapu zón nelze zapsat"

#: disk-utils/fsck.minix.c:530
msgid "Unable to write inodes"
msgstr "i-uzly nelze zapsat"

#: disk-utils/fsck.minix.c:562
msgid "unable to alloc buffer for superblock"
msgstr "buffer pro superblok nelze alokovat"

#: disk-utils/fsck.minix.c:565
msgid "unable to read super block"
msgstr "superblok nelze číst"

#: disk-utils/fsck.minix.c:587
msgid "bad magic number in super-block"
msgstr "superblok obsahuje chybné magické číslo"

#: disk-utils/fsck.minix.c:589
msgid "Only 1k blocks/zones supported"
msgstr "Podporovány jsou pouze 1kilobajtové bloky/zóny"

#: disk-utils/fsck.minix.c:591
msgid "bad s_ninodes field in super-block"
msgstr "superblok obsahuje chybnou položku s_ninodes"

#: disk-utils/fsck.minix.c:593
msgid "bad s_imap_blocks field in super-block"
msgstr "superblok obsahuje chybnou položku s_imap_blocks"

#: disk-utils/fsck.minix.c:595
msgid "bad s_firstdatazone field in super-block"
msgstr "superblok obsahuje chybnou položku s_firstdatazone"

#: disk-utils/fsck.minix.c:598
msgid "bad s_zmap_blocks field in super-block"
msgstr "superblok obsahuje chybnou položku s_zmap_blocks"

#: disk-utils/fsck.minix.c:614
msgid "Unable to allocate buffer for inode map"
msgstr "Buffer pro mapu i-uzlů nelze alokovat"

#: disk-utils/fsck.minix.c:617
msgid "Unable to allocate buffer for zone map"
msgstr "Buffer pro mapu zón nelze alokovat"

#: disk-utils/fsck.minix.c:620
msgid "Unable to allocate buffer for inodes"
msgstr "Buffer pro i-uzly nelze alokovat"

#: disk-utils/fsck.minix.c:623
msgid "Unable to allocate buffer for inode count"
msgstr "Buffer pro počítadlo i-uzlů nelze alokovat"

#: disk-utils/fsck.minix.c:626
msgid "Unable to allocate buffer for zone count"
msgstr "Buffer pro počítadlo zón nelze alokovat"

#: disk-utils/fsck.minix.c:630
msgid "Unable to read inode map"
msgstr "Mapu i-uzlů nelze číst"

#: disk-utils/fsck.minix.c:634
msgid "Unable to read zone map"
msgstr "Mapu zón nelze číst"

#: disk-utils/fsck.minix.c:638
msgid "Unable to read inodes"
msgstr "I-uzly nelze číst"

#: disk-utils/fsck.minix.c:640
#, c-format
msgid "Warning: Firstzone != Norm_firstzone\n"
msgstr "Varování: Firstzone != Norm_firstzone\n"

#: disk-utils/fsck.minix.c:645
#, c-format
msgid "%ld inodes\n"
msgstr "i-uzlů: %ld\n"

#: disk-utils/fsck.minix.c:646
#, c-format
msgid "%ld blocks\n"
msgstr "bloků: %ld\n"

#: disk-utils/fsck.minix.c:647 disk-utils/mkfs.minix.c:568
#, c-format
msgid "Firstdatazone=%jd (%jd)\n"
msgstr "První_zóna_dat=%jd (%jd)\n"

#: disk-utils/fsck.minix.c:649
#, c-format
msgid "Zonesize=%d\n"
msgstr "Velikost_zóny=%d\n"

#: disk-utils/fsck.minix.c:650
#, c-format
msgid "Maxsize=%zu\n"
msgstr "Maxvelikost=%zu\n"

#: disk-utils/fsck.minix.c:652
#, c-format
msgid "Filesystem state=%d\n"
msgstr "Stav systému souborů=%d\n"

#: disk-utils/fsck.minix.c:653
#, c-format
msgid ""
"namelen=%zd\n"
"\n"
msgstr ""
"namelen=%zd\n"
"\n"

#: disk-utils/fsck.minix.c:668 disk-utils/fsck.minix.c:718
#, c-format
msgid "Inode %d marked unused, but used for file '%s'\n"
msgstr "I-uzel %d je označen jako nepoužívaný, ale je použit pro soubor „%s“\n"

#: disk-utils/fsck.minix.c:671 disk-utils/fsck.minix.c:721
msgid "Mark in use"
msgstr "Označen jako používaný"

#: disk-utils/fsck.minix.c:693 disk-utils/fsck.minix.c:741
#, c-format
msgid "The file `%s' has mode %05o\n"
msgstr "Typ souboru „%s“ je %05o\n"

#: disk-utils/fsck.minix.c:700 disk-utils/fsck.minix.c:747
#, c-format
msgid "Warning: inode count too big.\n"
msgstr "Varování: počet i-uzlů je příliš veliký.\n"

#: disk-utils/fsck.minix.c:759 disk-utils/fsck.minix.c:767
msgid "root inode isn't a directory"
msgstr "root i-uzel není adresářem"

#: disk-utils/fsck.minix.c:779 disk-utils/fsck.minix.c:810
#, c-format
msgid "Block has been used before. Now in file `%s'."
msgstr "Blok byl použit již předtím. Nyní v souboru „%s“."

#: disk-utils/fsck.minix.c:781 disk-utils/fsck.minix.c:812
#: disk-utils/fsck.minix.c:1145 disk-utils/fsck.minix.c:1154
#: disk-utils/fsck.minix.c:1201 disk-utils/fsck.minix.c:1210
msgid "Clear"
msgstr "Smazat"

#: disk-utils/fsck.minix.c:791 disk-utils/fsck.minix.c:822
#, c-format
msgid "Block %d in file `%s' is marked not in use."
msgstr "Blok %d v souboru „%s“ je označen jako nepoužívaný."

#: disk-utils/fsck.minix.c:793 disk-utils/fsck.minix.c:824
msgid "Correct"
msgstr "Opravit"

#: disk-utils/fsck.minix.c:963 disk-utils/fsck.minix.c:1036
#, c-format
msgid "The directory '%s' contains a bad inode number for file '%.*s'."
msgstr "Adresář „%s“ obsahuje pro soubor „%.*s“ chybné číslo i-uzlu."

#: disk-utils/fsck.minix.c:965 disk-utils/fsck.minix.c:1038
msgid " Remove"
msgstr " Odstranit"

#: disk-utils/fsck.minix.c:981 disk-utils/fsck.minix.c:1054
#, c-format
msgid "%s: bad directory: '.' isn't first\n"
msgstr "%s: chybný adresář: „.“ není první\n"

#: disk-utils/fsck.minix.c:990 disk-utils/fsck.minix.c:1063
#, c-format
msgid "%s: bad directory: '..' isn't second\n"
msgstr "%s: chybný adresář: „..“ není druhý\n"

#: disk-utils/fsck.minix.c:1096 disk-utils/fsck.minix.c:1119
msgid "internal error"
msgstr "vnitřní chyba"

#: disk-utils/fsck.minix.c:1099 disk-utils/fsck.minix.c:1122
#, c-format
msgid "%s: bad directory: size < 32"
msgstr "%s: chybný adresář: velikost < 32"

#: disk-utils/fsck.minix.c:1105
#, c-format
msgid "%s: bad directory: invalid i_zone, use --repair to fix\n"
msgstr "%s: chybný adresář: chybná i_zone, na opravu použijte --repair\n"

#: disk-utils/fsck.minix.c:1134
msgid "seek failed in bad_zone"
msgstr "chyba při posunu ukazovátka v bad_zone"

#: disk-utils/fsck.minix.c:1144 disk-utils/fsck.minix.c:1200
#, c-format
msgid "Inode %lu mode not cleared."
msgstr "Mód i-uzlu %lu není smazán."

#: disk-utils/fsck.minix.c:1153 disk-utils/fsck.minix.c:1209
#, c-format
msgid "Inode %lu not used, marked used in the bitmap."
msgstr "I-uzel %lu není používán a v bitmapě označen jako používaný."

#: disk-utils/fsck.minix.c:1159 disk-utils/fsck.minix.c:1215
#, c-format
msgid "Inode %lu used, marked unused in the bitmap."
msgstr "I-uzel %lu je používán a v bitmapě označen jako nepoužívaný."

#: disk-utils/fsck.minix.c:1160 disk-utils/fsck.minix.c:1216
msgid "Set"
msgstr "Nastavit"

#: disk-utils/fsck.minix.c:1164 disk-utils/fsck.minix.c:1220
#, c-format
msgid "Inode %lu (mode = %07o), i_nlinks=%d, counted=%d."
msgstr "I-uzel %lu (mode = %07o), i_nlinks=%d, napočítáno=%d."

#: disk-utils/fsck.minix.c:1167 disk-utils/fsck.minix.c:1223
msgid "Set i_nlinks to count"
msgstr "Nastavit i_nlinks na počet"

#: disk-utils/fsck.minix.c:1179 disk-utils/fsck.minix.c:1235
#, c-format
msgid "Zone %lu: marked in use, no file uses it."
msgstr "Zóna %lu: je označena jako používaná a žádný soubor ji nepoužívá."

#: disk-utils/fsck.minix.c:1181 disk-utils/fsck.minix.c:1237
msgid "Unmark"
msgstr "Odznačit"

#: disk-utils/fsck.minix.c:1186 disk-utils/fsck.minix.c:1242
#, c-format
msgid "Zone %lu: in use, counted=%d\n"
msgstr "Zóna %lu: je používaná, napočítáno=%d\n"

#: disk-utils/fsck.minix.c:1189 disk-utils/fsck.minix.c:1245
#, c-format
msgid "Zone %lu: not in use, counted=%d\n"
msgstr "Zóna %lu: není používaná, napočítáno=%d\n"

#: disk-utils/fsck.minix.c:1295
msgid "bad inode size"
msgstr "chybná velikost i-uzlu"

#: disk-utils/fsck.minix.c:1297
msgid "bad v2 inode size"
msgstr "chybná velikost v2 i-uzlu"

#: disk-utils/fsck.minix.c:1341
msgid "need terminal for interactive repairs"
msgstr "opravy s účastí uživatele vyžadují terminál"

#: disk-utils/fsck.minix.c:1345
#, c-format
msgid "cannot open %s: %s"
msgstr "%s nelze otevřít: %s"

#: disk-utils/fsck.minix.c:1356
#, c-format
msgid "%s is clean, no check.\n"
msgstr "%s je čisté, ověřování vynecháno.\n"

#: disk-utils/fsck.minix.c:1361
#, c-format
msgid "Forcing filesystem check on %s.\n"
msgstr "Kontrola systému souborů na %s vynucena.\n"

#: disk-utils/fsck.minix.c:1363
#, c-format
msgid "Filesystem on %s is dirty, needs checking.\n"
msgstr "Systém souborů na %s je špinavý, je třeba jej zkontrolovat.\n"

#: disk-utils/fsck.minix.c:1395
#, c-format
msgid ""
"\n"
"%6ld inodes used (%ld%%)\n"
msgstr ""
"\n"
"používaných i-uzlů: %6ld (%ld%%)\n"

#: disk-utils/fsck.minix.c:1401
#, c-format
msgid "%6ld zones used (%ld%%)\n"
msgstr "používaných zón: %6ld (%ld%%)\n"

#: disk-utils/fsck.minix.c:1403
#, c-format
msgid ""
"\n"
"%6d regular files\n"
"%6d directories\n"
"%6d character device files\n"
"%6d block device files\n"
"%6d links\n"
"%6d symbolic links\n"
"------\n"
"%6d files\n"
msgstr ""
"\n"
" obyčejných souborů:  %6d\n"
" adresářů:            %6d\n"
" znakových zařízení:  %6d\n"
" blokových zařízení:  %6d\n"
" odkazů:              %6d\n"
" symbolických odkazů: %6d\n"
"------\n"
"souborů:              %6d\n"

#: disk-utils/fsck.minix.c:1417
#, c-format
msgid ""
"----------------------------\n"
"FILE SYSTEM HAS BEEN CHANGED\n"
"----------------------------\n"
msgstr ""
"-------------------------\n"
"SYSTÉM SOUBORŮ BYL ZMĚNĚN\n"
"-------------------------\n"

#: disk-utils/fsck.minix.c:1429 disk-utils/mkfs.minix.c:837
#: disk-utils/mkswap.c:561 disk-utils/partx.c:1068 disk-utils/resizepart.c:115
#: login-utils/utmpdump.c:391 sys-utils/dmesg.c:678 sys-utils/wdctl.c:386
#: sys-utils/wdctl.c:446 term-utils/setterm.c:908 text-utils/pg.c:1259
msgid "write failed"
msgstr "zápis selhal"

#: disk-utils/isosize.c:57
#, c-format
msgid "%s: might not be an ISO filesystem"
msgstr "%s: možná se nejedná o souborový systém ISO9660"

#: disk-utils/isosize.c:62 disk-utils/isosize.c:64
#, c-format
msgid "read error on %s"
msgstr "chyba čtení z %s"

#: disk-utils/isosize.c:75
#, c-format
msgid "sector count: %d, sector size: %d\n"
msgstr "počet sektorů: %d, velikost sektoru: %d\n"

#: disk-utils/isosize.c:99
#, c-format
msgid " %s [options] <iso9660_image_file> ...\n"
msgstr " %s [přepínače] <obraz_iso9660>…\n"

#: disk-utils/isosize.c:103
msgid "Show the length of an ISO-9660 filesystem.\n"
msgstr "Zobrazí délku souborového systému ISO-9660.\n"

#: disk-utils/isosize.c:106
msgid " -d, --divisor=<number>  divide the amount of bytes by <number>\n"
msgstr " -d, --divisor=<číslo>   podělí množství bajtů <číslem>\n"

#: disk-utils/isosize.c:107
msgid " -x, --sectors           show sector count and size\n"
msgstr " -x, --sectors           zobrazí počet a velikost sektorů\n"

#: disk-utils/isosize.c:138
msgid "invalid divisor argument"
msgstr "neplatný argument dělitele"

#: disk-utils/mkfs.bfs.c:74
#, c-format
msgid "Usage: %s [options] device [block-count]\n"
msgstr "Použití: %s [PŘEPÍNAČE] ZAŘÍZENÍ [POČET_BLOKŮ]\n"

#: disk-utils/mkfs.bfs.c:78
msgid "Make an SCO bfs filesystem.\n"
msgstr "Vytvoří souborový systéme SCO bfs.\n"

# FIXME: mkfs.bfs does not call setlocale().
#: disk-utils/mkfs.bfs.c:80
#, c-format
msgid ""
"\n"
"Options:\n"
" -N, --inodes=NUM    specify desired number of inodes\n"
" -V, --vname=NAME    specify volume name\n"
" -F, --fname=NAME    specify file system name\n"
" -v, --verbose       explain what is being done\n"
" -c                  this option is silently ignored\n"
" -l                  this option is silently ignored\n"
msgstr ""
"\n"
"Přepínače:\n"
" -N, --inodes=POČET  určuje požadovaný počet i-uzlů\n"
" -V, --vname=NÁZEV   určuje název svazku\n"
" -F, --fname=NÁZEV   určuje název souborového systému\n"
" -v, --verbose       vysvětluje, co se provádí\n"
" -c                  tento přepínač je tiše ignorován\n"
" -l                  tento přepínač je tiše ignorován\n"

#: disk-utils/mkfs.bfs.c:139
msgid "invalid number of inodes"
msgstr "neplatný počet i-uzlů"

#: disk-utils/mkfs.bfs.c:145
msgid "volume name too long"
msgstr "název svazku je příliš dlouhý"

#: disk-utils/mkfs.bfs.c:152
msgid "fsname name too long"
msgstr "název ss je příliš dlouhý"

#: disk-utils/mkfs.bfs.c:190
msgid "invalid block-count"
msgstr "neplatný počet bloků"

#: disk-utils/mkfs.bfs.c:198
#, c-format
msgid "cannot get size of %s"
msgstr "nelze zjistit velikost %s"

#: disk-utils/mkfs.bfs.c:203
#, c-format
msgid "blocks argument too large, max is %llu"
msgstr "argument počet bloků je příliš veliký, maximum je %llu"

#: disk-utils/mkfs.bfs.c:218
msgid "too many inodes - max is 512"
msgstr "příliš mnoho i-uzlů – maximum je 512"

#: disk-utils/mkfs.bfs.c:228
#, c-format
msgid "not enough space, need at least %llu blocks"
msgstr "nedostatek místa, je třeba alespoň %llu bloků"

#: disk-utils/mkfs.bfs.c:240
#, c-format
msgid "Device: %s\n"
msgstr "Zařízení: %s\n"

#: disk-utils/mkfs.bfs.c:241
#, c-format
msgid "Volume: <%-6s>\n"
msgstr "Svazek: <%-6s>\n"

#: disk-utils/mkfs.bfs.c:242
#, c-format
msgid "FSname: <%-6s>\n"
msgstr "NázevSS: <%-6s>\n"

#: disk-utils/mkfs.bfs.c:243
#, c-format
msgid "BlockSize: %d\n"
msgstr "VelikostBloku: %d\n"

#: disk-utils/mkfs.bfs.c:245
#, c-format
msgid "Inodes: %ld (in 1 block)\n"
msgstr "I-uzlů: %ld (v 1 bloku)\n"

# TODO: Pluralize
#: disk-utils/mkfs.bfs.c:248
#, c-format
msgid "Inodes: %ld (in %llu blocks)\n"
msgstr "I-uzlů: %ld (v %llu blocích)\n"

#: disk-utils/mkfs.bfs.c:250
#, c-format
msgid "Blocks: %llu\n"
msgstr "Bloků: %llu\n"

#: disk-utils/mkfs.bfs.c:251
#, c-format
msgid "Inode end: %d, Data end: %d\n"
msgstr "Konec i-uzlů: %d, Konec dat: %d\n"

#: disk-utils/mkfs.bfs.c:256
msgid "error writing superblock"
msgstr "chyba při zápisu superbloku"

#: disk-utils/mkfs.bfs.c:277
msgid "error writing root inode"
msgstr "chyba při zápisu kořenového i-uzlu"

#: disk-utils/mkfs.bfs.c:282
msgid "error writing inode"
msgstr "chyba při zápisu i-uzlu"

#: disk-utils/mkfs.bfs.c:285
msgid "seek error"
msgstr "volání seek selhalo"

#: disk-utils/mkfs.bfs.c:291
msgid "error writing . entry"
msgstr "chyba při zápisu . položky"

#: disk-utils/mkfs.bfs.c:295
msgid "error writing .. entry"
msgstr "chyba při zápisu .. položky"

#: disk-utils/mkfs.bfs.c:298
#, c-format
msgid "error closing %s"
msgstr "Chyba při zavírání %s"

#: disk-utils/mkfs.c:45
#, c-format
msgid " %s [options] [-t <type>] [fs-options] <device> [<size>]\n"
msgstr " %s [přepínače] [-t <typ>] [přepínače_ss] <zařízení> [<velikost>]\n"

#: disk-utils/mkfs.c:49
msgid "Make a Linux filesystem.\n"
msgstr "Vytvoří linuxový souborový systém.\n"

#: disk-utils/mkfs.c:52
#, c-format
msgid " -t, --type=<type>  filesystem type; when unspecified, ext2 is used\n"
msgstr " -t, --type=<typ>   druh souborového systému; výchozí je ext2\n"

#: disk-utils/mkfs.c:53
#, c-format
msgid "     fs-options     parameters for the real filesystem builder\n"
msgstr "     přepínače_ss   parametry pro vlastního tvůrce souborového systému\n"

#: disk-utils/mkfs.c:54
#, c-format
msgid "     <device>       path to the device to be used\n"
msgstr "     <zařízení>     cesta k zařízení, které se má použít\n"

#: disk-utils/mkfs.c:55
#, c-format
msgid "     <size>         number of blocks to be used on the device\n"
msgstr "     <velikost>     počet bloků, které se mají ze zařízení použít\n"

#: disk-utils/mkfs.c:56
#, c-format
msgid ""
" -V, --verbose      explain what is being done;\n"
"                      specifying -V more than once will cause a dry-run\n"
msgstr ""
" -V, --verbose      vysvětlí prováděné úkony\n"
"                    násobné použití -V způsobí bezzápisový běh\n"

#: disk-utils/mkfs.c:133 include/c.h:254 login-utils/su-common.c:1214
#: login-utils/sulogin.c:793 login-utils/sulogin.c:797 sys-utils/flock.c:123
#: sys-utils/rtcwake.c:621
#, c-format
msgid "failed to execute %s"
msgstr "spuštění %s selhalo"

#: disk-utils/mkfs.cramfs.c:128
#, c-format
msgid " %s [-h] [-v] [-b blksize] [-e edition] [-N endian] [-i file] [-n name] dirname outfile\n"
msgstr ""
" %s [-h] [-v] [-b velikost_bloku] [-e verze] [-N endianita]\n"
"       [-i soubor] [-n název] název_adresáře výstupní_soubor\n"

#: disk-utils/mkfs.cramfs.c:131
msgid "Make compressed ROM file system."
msgstr "Vyrobí komprimovaný souborový systém ROM."

#: disk-utils/mkfs.cramfs.c:133
msgid " -v             be verbose"
msgstr " -v             bude upovídaný"

#: disk-utils/mkfs.cramfs.c:134
msgid " -E             make all warnings errors (non-zero exit status)"
msgstr " -E             všechna varování budou považována za chyby (nenulový návratový kód)"

#: disk-utils/mkfs.cramfs.c:135
msgid " -b blksize     use this blocksize, must equal page size"
msgstr " -b velikost_bloku  použije tuto velikost_bloku, musí být rovna velikosti stránky"

#: disk-utils/mkfs.cramfs.c:136
msgid " -e edition     set edition number (part of fsid)"
msgstr " -e verze       nastaví číslo verze [edice] (součást fsid)"

#: disk-utils/mkfs.cramfs.c:137
#, c-format
msgid " -N endian      set cramfs endianness (%s|%s|%s), default %s\n"
msgstr ""
" -N endianita   vybere endianitu cramfs (%s|%s|%s),\n"
"                výchozí je %s\n"

#: disk-utils/mkfs.cramfs.c:138
msgid " -i file        insert a file image into the filesystem"
msgstr " -i soubor      vloží obraz ze souboru do souborového systému"

#: disk-utils/mkfs.cramfs.c:139
msgid " -n name        set name of cramfs filesystem"
msgstr " -n název       nastaví název souborového systému cramfs"

#: disk-utils/mkfs.cramfs.c:140
#, c-format
msgid " -p             pad by %d bytes for boot code\n"
msgstr " -p             odsadí o %d bytů kvůli kódu zavaděče\n"

#: disk-utils/mkfs.cramfs.c:141
msgid " -s             sort directory entries (old option, ignored)"
msgstr " -s             seřadí položky v adresářích (stará volba, ignorováno)"

#: disk-utils/mkfs.cramfs.c:142
msgid " -z             make explicit holes"
msgstr " -z             vytvoří explicitní díry"

#: disk-utils/mkfs.cramfs.c:143
msgid " dirname        root of the filesystem to be compressed"
msgstr " název_adresáře  kořen souborového systému, který má být zkomprimován"

#: disk-utils/mkfs.cramfs.c:144
msgid " outfile        output file"
msgstr " výstupní_soubor  výstupní soubor"

#: disk-utils/mkfs.cramfs.c:162
#, c-format
msgid "readlink failed: %s"
msgstr "volání readlink selhalo: %s"

#: disk-utils/mkfs.cramfs.c:307
#, c-format
msgid "could not read directory %s"
msgstr "z adresáře %s nelze číst"

#: disk-utils/mkfs.cramfs.c:442
msgid "filesystem too big.  Exiting."
msgstr "Souborový systém je příliš velký. Končí se."

#: disk-utils/mkfs.cramfs.c:601
#, c-format
msgid "AIEEE: block \"compressed\" to > 2*blocklength (%ld)\n"
msgstr "AJAJ: blok „zkomprimováno“ > 2*blocklength (%ld)\n"

#: disk-utils/mkfs.cramfs.c:620
#, c-format
msgid "%6.2f%% (%+ld bytes)\t%s\n"
msgstr "%6.2f%% (%+ld bytů)\t%s\n"

#: disk-utils/mkfs.cramfs.c:665
#, c-format
msgid "cannot close file %s"
msgstr "soubor %s nelze zavřít"

#: disk-utils/mkfs.cramfs.c:742
msgid "invalid edition number argument"
msgstr "neplatný argument čísla edice"

#: disk-utils/mkfs.cramfs.c:752
msgid "invalid endianness given; must be 'big', 'little', or 'host'"
msgstr "zadána neplatná endianita; musí být „big“, „little“ nebo „host“"

#: disk-utils/mkfs.cramfs.c:817
#, c-format
msgid "warning: guestimate of required size (upper bound) is %lldMB, but maximum image size is %uMB.  We might die prematurely."
msgstr "varování: požadovaná velikost (horní hranice) je odhadována na %lld MB, jenže největší velikost obrazu je %u MB. Můžeme zemřít předčasně."

#: disk-utils/mkfs.cramfs.c:841
msgid "ROM image map"
msgstr "Mapa obrazu ROM"

#: disk-utils/mkfs.cramfs.c:853
#, c-format
msgid "Including: %s\n"
msgstr "Zahrnuji: %s\n"

#: disk-utils/mkfs.cramfs.c:859
#, c-format
msgid "Directory data: %zd bytes\n"
msgstr "Adresářová data: %zd bajtů\n"

#: disk-utils/mkfs.cramfs.c:867
#, c-format
msgid "Everything: %zd kilobytes\n"
msgstr "Celkem: %zd kilobajtů\n"

#: disk-utils/mkfs.cramfs.c:872
#, c-format
msgid "Super block: %zd bytes\n"
msgstr "Superblok: %zd bajtů\n"

#: disk-utils/mkfs.cramfs.c:879
#, c-format
msgid "CRC: %x\n"
msgstr "CRC: %x\n"

#: disk-utils/mkfs.cramfs.c:884
#, c-format
msgid "not enough space allocated for ROM image (%lld allocated, %zu used)"
msgstr "pro obraz ROM nepřidělen dostatek prostoru (%lld přiděleno, %zu použito)"

#: disk-utils/mkfs.cramfs.c:890
#, c-format
msgid "ROM image write failed (%zd %zd)"
msgstr "Zápis obrazu ROM selhal (%zd %zd)"

#: disk-utils/mkfs.cramfs.c:893
msgid "ROM image"
msgstr "Obraz ROM"

# TODO: Pluralize
#: disk-utils/mkfs.cramfs.c:902
#, c-format
msgid "warning: filenames truncated to %u bytes."
msgstr "varování: jména souborů zkrácena na %u bajtů."

#: disk-utils/mkfs.cramfs.c:904
msgid "warning: files were skipped due to errors."
msgstr "varování: soubory byly přeskočeny kvůli chybám."

#: disk-utils/mkfs.cramfs.c:906
#, c-format
msgid "warning: file sizes truncated to %luMB (minus 1 byte)."
msgstr "varování: velikosti souboru zkráceny na %'lu MB (mínus 1 bajt)."

# TODO: Pluralize
#: disk-utils/mkfs.cramfs.c:910
#, c-format
msgid "warning: uids truncated to %u bits.  (This may be a security concern.)"
msgstr "varování: UID zkrácena na %u bitů. (Může mít dopad na bezpečnost.)"

# TODO: Pluralize
#: disk-utils/mkfs.cramfs.c:913
#, c-format
msgid "warning: gids truncated to %u bits.  (This may be a security concern.)"
msgstr "varování: GID zkrácena na %u bitů. (Může mít dopad na bezpečnost.)"

# TODO: Pluralize
#: disk-utils/mkfs.cramfs.c:916
#, c-format
msgid ""
"WARNING: device numbers truncated to %u bits.  This almost certainly means\n"
"that some device files will be wrong."
msgstr ""
"VAROVÁNÍ: čísla zařízení zkrácena na %u bitů. Toto jistě znamená, že některé\n"
"soubory zařízení budou špatné."

#: disk-utils/mkfs.minix.c:138
#, c-format
msgid " %s [options] /dev/name [blocks]\n"
msgstr "%s [přepínače] /dev/název [bloky]\n"

#: disk-utils/mkfs.minix.c:140
msgid " -1                      use Minix version 1\n"
msgstr " -1                      použije verzi Minixu 1\n"

#: disk-utils/mkfs.minix.c:141
msgid " -2, -v                  use Minix version 2\n"
msgstr " -2, -v                  použije verzi Minixu 2\n"

#: disk-utils/mkfs.minix.c:142
msgid " -3                      use Minix version 3\n"
msgstr " -3                      použije verzi Minixu 3\n"

#: disk-utils/mkfs.minix.c:143
msgid " -n, --namelength <num>  maximum length of filenames\n"
msgstr ""
" -n, --namelength <číslo>\n"
"                         maximální délka názvů souborů\n"

#: disk-utils/mkfs.minix.c:144
msgid " -i, --inodes <num>      number of inodes for the filesystem\n"
msgstr " -i, --inodes <počet>    počet i-uzlů v souborovém systému\n"

#: disk-utils/mkfs.minix.c:145
msgid " -c, --check             check the device for bad blocks\n"
msgstr " -c, --check             zkontroluje zařízení na vadné bloky\n"

#: disk-utils/mkfs.minix.c:146
msgid " -l, --badblocks <file>  list of bad blocks from file\n"
msgstr ""
" -l, --badblocks <soubor>\n"
"                         soubor se sezname vadných bloků\n"

#: disk-utils/mkfs.minix.c:189
#, c-format
msgid "%s: seek to boot block failed  in write_tables"
msgstr "%s: chyba při přesunu na startovací blok ve write_tables"

#: disk-utils/mkfs.minix.c:192
#, c-format
msgid "%s: unable to clear boot sector"
msgstr "%s: startovací blok nelze smazat"

#: disk-utils/mkfs.minix.c:194
#, c-format
msgid "%s: seek failed in write_tables"
msgstr "%s: chyba při změně pozice ve write_tables"

#: disk-utils/mkfs.minix.c:197
#, c-format
msgid "%s: unable to write super-block"
msgstr "%s: superblok nelze zapsat"

#: disk-utils/mkfs.minix.c:200
#, c-format
msgid "%s: unable to write inode map"
msgstr "%s: mapu i-uzlů nelze zapsat"

#: disk-utils/mkfs.minix.c:203
#, c-format
msgid "%s: unable to write zone map"
msgstr "%s: mapu zón nelze zapsat"

#: disk-utils/mkfs.minix.c:206
#, c-format
msgid "%s: unable to write inodes"
msgstr "%s: i-uzly nelze zapsat"

#: disk-utils/mkfs.minix.c:211
#, c-format
msgid "%s: seek failed in write_block"
msgstr "%s: chyba při změně pozice ve write_block"

#: disk-utils/mkfs.minix.c:214
#, c-format
msgid "%s: write failed in write_block"
msgstr "%s: chyba při zápisu ve write_block"

#: disk-utils/mkfs.minix.c:223 disk-utils/mkfs.minix.c:298
#: disk-utils/mkfs.minix.c:347
#, c-format
msgid "%s: too many bad blocks"
msgstr "%s: příliš mnoho chybných bloků"

#: disk-utils/mkfs.minix.c:231
#, c-format
msgid "%s: not enough good blocks"
msgstr "%s: nedostatek dobrých bloků"

#: disk-utils/mkfs.minix.c:546
#, c-format
msgid ""
"First data block at %jd, which is too far (max %d).\n"
"Try specifying fewer inodes by passing --inodes <num>"
msgstr ""
"První datový blok na %jd, což je příliš daleko (maximum %d).\n"
"Zkuste zadat méně i-uzlů pomocí --inodes <počet>"

#: disk-utils/mkfs.minix.c:566
#, c-format
msgid "%lu inode\n"
msgid_plural "%lu inodes\n"
msgstr[0] "%lu i-uzel\n"
msgstr[1] "%lu i-uzly\n"
msgstr[2] "%lu i-uzlů\n"

#: disk-utils/mkfs.minix.c:567
#, c-format
msgid "%lu block\n"
msgid_plural "%lu blocks\n"
msgstr[0] "%lu blok\n"
msgstr[1] "%lu bloky\n"
msgstr[2] "%lu bloků\n"

#: disk-utils/mkfs.minix.c:570
#, c-format
msgid "Zonesize=%zu\n"
msgstr "Velikost_zóny=%zu\n"

#: disk-utils/mkfs.minix.c:571
#, c-format
msgid ""
"Maxsize=%zu\n"
"\n"
msgstr ""
"Maximální_velikost=%zu\n"
"\n"

#: disk-utils/mkfs.minix.c:584
#, c-format
msgid "%s: seek failed during testing of blocks"
msgstr "%s: chyba při změně pozice v průběhu kontroly bloků"

#: disk-utils/mkfs.minix.c:591
#, c-format
msgid "Weird values in do_check: probably bugs\n"
msgstr "Nesprávné hodnoty v do_check: pravděpodobně chyby\n"

#: disk-utils/mkfs.minix.c:624
#, c-format
msgid "%s: seek failed in check_blocks"
msgstr "%s: chyba při změně pozice v check_blocks"

#: disk-utils/mkfs.minix.c:634
#, c-format
msgid "%s: bad blocks before data-area: cannot make fs"
msgstr "%s: chybné bloky před datovou oblastí: systém souborů nelze vytvořit"

#: disk-utils/mkfs.minix.c:641 disk-utils/mkfs.minix.c:665
#, c-format
msgid "%d bad block\n"
msgid_plural "%d bad blocks\n"
msgstr[0] "%d chybný blok\n"
msgstr[1] "%d chybné bloky\n"
msgstr[2] "%d chybných bloků\n"

#: disk-utils/mkfs.minix.c:650
#, c-format
msgid "%s: can't open file of bad blocks"
msgstr "%s: soubor chybných bloků nelze otevřít"

#: disk-utils/mkfs.minix.c:655
#, c-format
msgid "badblock number input error on line %d\n"
msgstr "chyba vstupu u čísla špatného bloku na řádku %d\n"

#: disk-utils/mkfs.minix.c:656
#, c-format
msgid "%s: cannot read badblocks file"
msgstr "%s: soubor chybných bloků nelze přečíst"

#: disk-utils/mkfs.minix.c:696
#, c-format
msgid "block size smaller than physical sector size of %s"
msgstr "velikost bloku je menší než velikost fyzického sektoru %s"

#: disk-utils/mkfs.minix.c:699
#, c-format
msgid "cannot determine size of %s"
msgstr "nelze zjistit velikost %s"

#: disk-utils/mkfs.minix.c:707
#, c-format
msgid "%s: requested blocks (%llu) exceeds available (%llu) blocks\n"
msgstr "%s: požadované bloky (%'llu) převyšují dostupné bloky (%'llu)\n"

#: disk-utils/mkfs.minix.c:710
#, c-format
msgid "%s: number of blocks too small"
msgstr "%s: počet bloků je příliš malý"

#: disk-utils/mkfs.minix.c:725 disk-utils/mkfs.minix.c:731
#, c-format
msgid "unsupported name length: %d"
msgstr "nepodporovaná délka názvu: %d"

#: disk-utils/mkfs.minix.c:734
#, c-format
msgid "unsupported minix file system version: %d"
msgstr "nepodporovaná verze minixového souborového systému: %d"

#: disk-utils/mkfs.minix.c:771
msgid "-v is ambiguous, use '-2' instead"
msgstr "přepínač -v není jednoznačný, namísto něj použijte „-2“"

#: disk-utils/mkfs.minix.c:782
msgid "failed to parse maximum length of filenames"
msgstr "nezdařilo se rozebrat maximální délku názvů souborů"

#: disk-utils/mkfs.minix.c:786
msgid "failed to parse number of inodes"
msgstr "nezdařilo se rozebrat počet i-uzlů"

#: disk-utils/mkfs.minix.c:809
msgid "failed to parse number of blocks"
msgstr "nezdařilo se rozebrat počet bloků"

#: disk-utils/mkfs.minix.c:817
#, c-format
msgid "%s is mounted; will not make a filesystem here!"
msgstr "%s je připojeno; systém souborů zde vytvářet nebudu!"

#: disk-utils/mkswap.c:81
#, c-format
msgid "Bad user-specified page size %u"
msgstr "Uživatelem zadaná velikost stránky %u je chybná"

#: disk-utils/mkswap.c:84
#, c-format
msgid "Using user-specified page size %d, instead of the system value %d"
msgstr "Použije se zadaná velikost stránky %d místo systémové hodnoty %d"

#: disk-utils/mkswap.c:125
msgid "Label was truncated."
msgstr "Jmenovka byla zkrácena."

#: disk-utils/mkswap.c:133
#, c-format
msgid "no label, "
msgstr "žádná jmenovka, "

#: disk-utils/mkswap.c:141
#, c-format
msgid "no uuid\n"
msgstr "žádné UUID\n"

#: disk-utils/mkswap.c:149
#, c-format
msgid ""
"\n"
"Usage:\n"
" %s [options] device [size]\n"
msgstr ""
"\n"
"Použití:\n"
" %s [přepínače] zařízení [velikost]\n"

#: disk-utils/mkswap.c:154
msgid "Set up a Linux swap area.\n"
msgstr "Vytvoří linuxovou odkládací oblast.\n"

#: disk-utils/mkswap.c:157
#, c-format
msgid ""
"\n"
"Options:\n"
" -c, --check               check bad blocks before creating the swap area\n"
" -f, --force               allow swap size area be larger than device\n"
" -p, --pagesize SIZE       specify page size in bytes\n"
" -L, --label LABEL         specify label\n"
" -v, --swapversion NUM     specify swap-space version number\n"
" -U, --uuid UUID           specify the uuid to use\n"
msgstr ""
"\n"
"Přepínače:\n"
" -c, --check               před vytvořením odkládací oblasti zkontroluje\n"
"                           chybné sektory\n"
" -f, --force               dovolí, aby odkládací oblast byla větší než zařízení\n"
" -p, --pagesize VELIKOST   určí velikost stránky v bajtech\n"
" -L, --label JMENOVKA      určí jmenovku\n"
" -v, --swapversion ČÍSLO   určí číslo verze odkládací oblasti\n"
" -U, --uuid UUID           určí, jaké UUID se má použít\n"

#: disk-utils/mkswap.c:166 disk-utils/sfdisk.c:2048
#, fuzzy, c-format
msgid "     --lock[=<mode>]       use exclusive device lock (%s, %s or %s)\n"
msgstr "     --color[=<kdy>]       obarví výstup (%s, %s nebo %s)\n"

#: disk-utils/mkswap.c:179
#, c-format
msgid "too many bad pages: %lu"
msgstr "příliš mnoho chybných stránek: %lu"

#: disk-utils/mkswap.c:200
msgid "seek failed in check_blocks"
msgstr "chyba při posunu ukazovátka v check_blocks"

#: disk-utils/mkswap.c:208
#, c-format
msgid "%lu bad page\n"
msgid_plural "%lu bad pages\n"
msgstr[0] "%lu chybná stránka\n"
msgstr[1] "%lu chybné stránky\n"
msgstr[2] "%lu chybných stránek\n"

#: disk-utils/mkswap.c:233
msgid "unable to alloc new libblkid probe"
msgstr "nelze alokovat nový test libblkid"

#: disk-utils/mkswap.c:235
msgid "unable to assign device to libblkid probe"
msgstr "zařízení nelze přidat do testu libblkid"

#: disk-utils/mkswap.c:256
#, c-format
msgid "warning: checking bad blocks from swap file is not supported: %s"
msgstr "pozor: kontrola chybných bloků v odkládacím souboru není podporována: %s"

#: disk-utils/mkswap.c:272 disk-utils/mkswap.c:297 disk-utils/mkswap.c:344
msgid "unable to rewind swap-device"
msgstr "odkládací prostor nelze převinout"

#: disk-utils/mkswap.c:300
msgid "unable to erase bootbits sectors"
msgstr "zaváděcí bloky nelze smazat"

#: disk-utils/mkswap.c:316
#, c-format
msgid "%s: warning: wiping old %s signature."
msgstr "%s: pozor: odstraňuje se starý vzorec %s."

#: disk-utils/mkswap.c:321
#, c-format
msgid "%s: warning: don't erase bootbits sectors"
msgstr "%s: varování: nemažte zaváděcí sektory"

# Continuation of previous message
#: disk-utils/mkswap.c:324
#, c-format
msgid "        (%s partition table detected). "
msgstr "        (nalezena tabulka rozdělení disku typu %s). "

# Alternate continuation of previous message
#: disk-utils/mkswap.c:326
#, c-format
msgid "        (compiled without libblkid). "
msgstr "        (přeloženo bez libblkid). "

#: disk-utils/mkswap.c:327
#, c-format
msgid "Use -f to force.\n"
msgstr "Použijte -f k vynucení.\n"

#: disk-utils/mkswap.c:349
#, c-format
msgid "%s: unable to write signature page"
msgstr "%s: stránku se vzorcem nelze zapsat"

#: disk-utils/mkswap.c:394
msgid "parsing page size failed"
msgstr "nepodařilo se rozebrat velikost stránky"

#: disk-utils/mkswap.c:400
msgid "parsing version number failed"
msgstr "nepodařilo se rozebrat číslo verze"

#: disk-utils/mkswap.c:403
#, c-format
msgid "swapspace version %d is not supported"
msgstr "odkládací prostor verze %d není nepodporován"

#: disk-utils/mkswap.c:409
#, c-format
msgid "warning: ignoring -U (UUIDs are unsupported by %s)"
msgstr "pozor: -U se ignoruje (%s nepodporuje UUID)"

#: disk-utils/mkswap.c:436
msgid "only one device argument is currently supported"
msgstr "v současnosti je podporován pouze jeden argument se zařízením"

#: disk-utils/mkswap.c:443
msgid "error: parsing UUID failed"
msgstr "chyba: rozbor UUID selhal"

#: disk-utils/mkswap.c:452
msgid "error: Nowhere to set up swap on?"
msgstr "chyba: Kde se má vytvořit odkládací prostor?"

#: disk-utils/mkswap.c:458
msgid "invalid block count argument"
msgstr "neplatný argument počtu bloků"

#: disk-utils/mkswap.c:467
#, c-format
msgid "error: size %llu KiB is larger than device size %<PRIu64> KiB"
msgstr "chyba: velikost %llu KiB je větší než velikost zařízení %<PRIu64> KiB"

#: disk-utils/mkswap.c:473
#, c-format
msgid "error: swap area needs to be at least %ld KiB"
msgstr "chyba: odkládací prostor potřebuje alespoň %ld KiB"

#: disk-utils/mkswap.c:478
#, c-format
msgid "warning: truncating swap area to %llu KiB"
msgstr "varování: odkládací prostor zkrácen na %llu KiB"

#: disk-utils/mkswap.c:483
#, c-format
msgid "error: %s is mounted; will not make swapspace"
msgstr "chyba: %s je připojeno; odkládací prostor nebude vytvořen."

#: disk-utils/mkswap.c:490 sys-utils/swapon.c:528
#, c-format
msgid "%s: insecure permissions %04o, %04o suggested."
msgstr "%s: přístupová práva %04o nejsou bezpečná, %04o by byla lepší."

#: disk-utils/mkswap.c:494 sys-utils/swapon.c:533
#, c-format
msgid "%s: insecure file owner %d, 0 (root) suggested."
msgstr "%s: vlastník souboru %d není bezpečný, 0 (root) by byl lepší."

#: disk-utils/mkswap.c:509
msgid "Unable to set up swap-space: unreadable"
msgstr "Odkládací prostor nelze nastavit: nečitelné"

#: disk-utils/mkswap.c:514
#, c-format
msgid "Setting up swapspace version %d, size = %s (%<PRIu64> bytes)\n"
msgstr "Vytváří se odkládací prostor verze %d, velikost = %s (%<PRIu64> bajtů)\n"

#: disk-utils/mkswap.c:534
#, c-format
msgid "%s: unable to obtain selinux file label"
msgstr "%s: nelze získat selinuxovou značku souboru"

#: disk-utils/mkswap.c:537
msgid "unable to matchpathcon()"
msgstr "matchpathcon() nelze provést"

#: disk-utils/mkswap.c:540
msgid "unable to create new selinux context"
msgstr "nový kontext selinuxu nelze vytvořit"

#: disk-utils/mkswap.c:542
msgid "couldn't compute selinux context"
msgstr "nedokáži vypočíst kontext selinuxu"

#: disk-utils/mkswap.c:548
#, c-format
msgid "unable to relabel %s to %s"
msgstr "nelze změnit jmenovku z %s na %s"

#: disk-utils/partx.c:86
msgid "partition number"
msgstr "číslo oddílu"

#: disk-utils/partx.c:87
msgid "start of the partition in sectors"
msgstr "začátek oddílu v sektorech"

#: disk-utils/partx.c:88
msgid "end of the partition in sectors"
msgstr "konec oddílu v sektorech"

#: disk-utils/partx.c:89
msgid "number of sectors"
msgstr "počet sektorů"

#: disk-utils/partx.c:90
msgid "human readable size"
msgstr "přehledná velikost"

#: disk-utils/partx.c:91
msgid "partition name"
msgstr "název oddílu"

#: disk-utils/partx.c:92 misc-utils/findmnt.c:108 misc-utils/lsblk.c:176
msgid "partition UUID"
msgstr "UUID oddílu"

#: disk-utils/partx.c:93
msgid "partition table type (dos, gpt, ...)"
msgstr "druh tabulky rozdělení disku (DOS, GPT, …)"

#: disk-utils/partx.c:94 misc-utils/lsblk.c:177
msgid "partition flags"
msgstr "příznaky oddílu"

#: disk-utils/partx.c:95
msgid "partition type (a string, a UUID, or hex)"
msgstr "druh oddílu (řetězec, UUID nebo šestnáctkové číslo)"

#: disk-utils/partx.c:114 sys-utils/losetup.c:534 sys-utils/losetup.c:648
msgid "failed to initialize loopcxt"
msgstr "loopctx se nepodařilo inicializovat"

#: disk-utils/partx.c:118
#, c-format
msgid "%s: failed to find unused loop device"
msgstr "%s: žádné nepoužité loop zařízení nebylo možné najít"

#: disk-utils/partx.c:122
#, c-format
msgid "Trying to use '%s' for the loop device\n"
msgstr "Pro zařízení loop se zkusí použít „%s“\n"

#: disk-utils/partx.c:126
#, c-format
msgid "%s: failed to set backing file"
msgstr "%s: nastavení podkladového souboru selhalo"

#: disk-utils/partx.c:131 sys-utils/losetup.c:581
#, c-format
msgid "%s: failed to set up loop device"
msgstr "%s: zařízení loop se nepodařilo nastavit"

#: disk-utils/partx.c:161 login-utils/lslogins.c:320 misc-utils/fincore.c:92
#: misc-utils/findmnt.c:376 misc-utils/lsblk.c:317 misc-utils/lslocks.c:344
#: misc-utils/uuidparse.c:125 misc-utils/wipefs.c:132 sys-utils/irq-common.c:70
#: sys-utils/losetup.c:112 sys-utils/lscpu.c:241 sys-utils/lscpu.c:256
#: sys-utils/lsipc.c:232 sys-utils/lsmem.c:178 sys-utils/lsns.c:225
#: sys-utils/prlimit.c:277 sys-utils/rfkill.c:159 sys-utils/swapon.c:150
#: sys-utils/wdctl.c:161 sys-utils/zramctl.c:147
#, c-format
msgid "unknown column: %s"
msgstr "neznámý sloupec: %s"

#: disk-utils/partx.c:209
#, c-format
msgid "%s: failed to get partition number"
msgstr "%s: získání čísla oddílu selhalo"

#: disk-utils/partx.c:287 disk-utils/partx.c:325 disk-utils/partx.c:479
#, c-format
msgid "specified range <%d:%d> does not make sense"
msgstr "zadaný rozsah <%d:%d> nedává smysl"

#: disk-utils/partx.c:291
#, c-format
msgid "range recount: max partno=%d, lower=%d, upper=%d\n"
msgstr "přepočet rozsahu: maximální číslo oddílu=%d, dolní=%d, horní=%d\n"

#: disk-utils/partx.c:298
#, c-format
msgid "%s: error deleting partition %d"
msgstr "%s: chyba při mazání oddílu %d"

#: disk-utils/partx.c:300
#, c-format
msgid "%s: error deleting partitions %d-%d"
msgstr "%s: chyba při mazání oddílů %d–%d"

#: disk-utils/partx.c:333
#, c-format
msgid "%s: partition #%d removed\n"
msgstr "%s: oddíl č. %d odstraněn\n"

#: disk-utils/partx.c:339
#, c-format
msgid "%s: partition #%d doesn't exist\n"
msgstr "%s: oddíl č. %d neexistuje\n"

#: disk-utils/partx.c:344
#, c-format
msgid "%s: deleting partition #%d failed"
msgstr "%s: odstranění oddílu č. %d selhalo"

#: disk-utils/partx.c:364
#, c-format
msgid "%s: error adding partition %d"
msgstr "%s: chyba při přidávání oddílu %d"

#: disk-utils/partx.c:366
#, c-format
msgid "%s: error adding partitions %d-%d"
msgstr "%s: chyb při přidávání oddílů %d–%d"

#: disk-utils/partx.c:407 disk-utils/partx.c:515
#, c-format
msgid "%s: partition #%d added\n"
msgstr "%s: přidán oddíl č. %d\n"

#: disk-utils/partx.c:412
#, c-format
msgid "%s: adding partition #%d failed"
msgstr "%s: přidání oddílu č. %d selhalo"

#: disk-utils/partx.c:447
#, c-format
msgid "%s: error updating partition %d"
msgstr "%s: chyba při aktualizaci oddílu %d"

#: disk-utils/partx.c:449
#, c-format
msgid "%s: error updating partitions %d-%d"
msgstr "%s: chyba při aktualizaci oddílů %d–%d"

#: disk-utils/partx.c:488
#, c-format
msgid "%s: no partition #%d"
msgstr "%s: žádný oddíl č. %d"

#: disk-utils/partx.c:509
#, c-format
msgid "%s: partition #%d resized\n"
msgstr "%s: oddíl č. %d změnil velikost\n"

#: disk-utils/partx.c:523
#, c-format
msgid "%s: updating partition #%d failed"
msgstr "%s: aktualizace oddílu č. %d selhala"

#: disk-utils/partx.c:564
#, c-format
msgid "#%2d: %9ju-%9ju (%9ju sector, %6ju MB)\n"
msgid_plural "#%2d: %9ju-%9ju (%9ju sectors, %6ju MB)\n"
msgstr[0] "č. %2d: %9ju–%9ju (%9ju sektor, %6ju MB)\n"
msgstr[1] "č. %2d: %9ju–%9ju (%9ju sektory, %6ju MB)\n"
msgstr[2] "č. %2d: %9ju–%9ju (%9ju sektorů, %6ju MB)\n"

#: disk-utils/partx.c:680 misc-utils/fincore.c:370 misc-utils/findmnt.c:1662
#: misc-utils/lsblk.c:2122 misc-utils/lslocks.c:471 sys-utils/losetup.c:339
#: sys-utils/lscpu.c:1683 sys-utils/lscpu.c:1911 sys-utils/prlimit.c:306
#: sys-utils/rfkill.c:471 sys-utils/swapon.c:292 sys-utils/wdctl.c:310
msgid "failed to allocate output column"
msgstr "výstupní sloupec se nepodařilo alokovat"

#: disk-utils/partx.c:724
#, c-format
msgid "failed to initialize blkid filter for '%s'"
msgstr "filtr blkid pro „%s“ se nepodařilo inicializovat"

#: disk-utils/partx.c:732
#, c-format
msgid "%s: failed to read partition table"
msgstr "%s: tabulku rozdělení disku se nepodařilo načíst"

#: disk-utils/partx.c:738
#, c-format
msgid "%s: partition table type '%s' detected\n"
msgstr "%s: nalezena tabulka rozdělení disku typu „%s“\n"

#: disk-utils/partx.c:742
#, c-format
msgid "%s: partition table with no partitions"
msgstr "%s: tabulka rozdělení disku bez oddílů"

#: disk-utils/partx.c:755
#, c-format
msgid " %s [-a|-d|-s|-u] [--nr <n:m> | <partition>] <disk>\n"
msgstr " %s [-a|-d|-s|-u] [--nr <n:m> | <oddíl>] <disk>\n"

#: disk-utils/partx.c:759
msgid "Tell the kernel about the presence and numbering of partitions.\n"
msgstr "Řekne jádru o existenci a číslování oddílů.\n"

#: disk-utils/partx.c:762
msgid " -a, --add            add specified partitions or all of them\n"
msgstr " -a, --add            přidá zadané nebo všechny oddíly\n"

#: disk-utils/partx.c:763
msgid " -d, --delete         delete specified partitions or all of them\n"
msgstr " -d, --delete         smaže zadané nebo všechny oddíly\n"

#: disk-utils/partx.c:764
msgid " -u, --update         update specified partitions or all of them\n"
msgstr " -u, --update         aktualizuje zadané nebo všechny oddíly\n"

#: disk-utils/partx.c:765
msgid ""
" -s, --show           list partitions\n"
"\n"
msgstr ""
" -s, --show           vypíše oddíly\n"
"\n"

#: disk-utils/partx.c:766 misc-utils/lsblk.c:1780 sys-utils/lsmem.c:515
msgid " -b, --bytes          print SIZE in bytes rather than in human readable format\n"
msgstr ""
" -b, --bytes          velikosti vypisuje v bajtech namísto podobě vhodné\n"
"                      pro člověka\n"

#: disk-utils/partx.c:767
msgid " -g, --noheadings     don't print headings for --show\n"
msgstr " -g, --noheadings     nezobrazuje záhlaví ve výpisu --show\n"

#: disk-utils/partx.c:768
msgid " -n, --nr <n:m>       specify the range of partitions (e.g. --nr 2:4)\n"
msgstr " -n, --nr <m:n>       určuje rozsah oddílů (např. --nr 2:4)\n"

#: disk-utils/partx.c:769 sys-utils/irqtop.c:224 sys-utils/lsirq.c:66
msgid " -o, --output <list>  define which output columns to use\n"
msgstr ""
" -o, --output <seznam>\n"
"                      určuje, které výstupní sloupce se použijí\n"

#: disk-utils/partx.c:770 sys-utils/lsmem.c:518
msgid "     --output-all     output all columns\n"
msgstr "     --output-all     vypíše všechny sloupce\n"

#: disk-utils/partx.c:771 misc-utils/lsblk.c:1776 sys-utils/lsirq.c:64
#: sys-utils/lsmem.c:513
msgid " -P, --pairs          use key=\"value\" output format\n"
msgstr " -P, --pairs          výstup ve formátu klíč=\"hodnota\"\n"

#: disk-utils/partx.c:772 misc-utils/lsblk.c:1791 sys-utils/lsmem.c:519
msgid " -r, --raw            use raw output format\n"
msgstr " -r, --raw            neformátovaný výstup\n"

#: disk-utils/partx.c:773
msgid " -S, --sector-size <num>  overwrite sector size\n"
msgstr " -S, --sector-size <velikost>  přebije velikost sektoru\n"

#: disk-utils/partx.c:774
msgid " -t, --type <type>    specify the partition type\n"
msgstr " -t, --type <druh>    určuje druh oddílu\n"

#: disk-utils/partx.c:775
msgid "     --list-types     list supported partition types and exit\n"
msgstr "     --list-types     vypíše známé typy oddílů a skončí\n"

#: disk-utils/partx.c:776 sys-utils/fallocate.c:101
msgid " -v, --verbose        verbose mode\n"
msgstr " -v, --verbose        podrobný režim\n"

#: disk-utils/partx.c:861
msgid "failed to parse --nr <M-N> range"
msgstr "rozsah --nr <M–N> se nepodařilo rozebrat"

#: disk-utils/partx.c:950
msgid "partition and disk name do not match"
msgstr "tabulka rozdělení disku a název disku si neodpovídají"

#: disk-utils/partx.c:979
msgid "--nr and <partition> are mutually exclusive"
msgstr "argumenty --nr a ODDÍL se vzájemně vylučují"

#: disk-utils/partx.c:998
#, c-format
msgid "partition: %s, disk: %s, lower: %d, upper: %d\n"
msgstr "oddíl: %s, disk %s, dolní: %d: horní: %d\n"

#: disk-utils/partx.c:1010
#, c-format
msgid "%s: cannot delete partitions"
msgstr "%s: oddíly nelze smazat"

#: disk-utils/partx.c:1013
#, c-format
msgid "%s: partitioned loop devices unsupported"
msgstr "%s: zařízení loop rozdělená na oddíly nejsou podporována"

#: disk-utils/partx.c:1030
#, c-format
msgid "%s: failed to initialize blkid prober"
msgstr "%s: nepodařilo inicializovat sondu blkid"

#: disk-utils/raw.c:50
#, c-format
msgid ""
" %1$s %2$srawN <major> <minor>\n"
" %1$s %2$srawN /dev/<blockdevice>\n"
" %1$s -q %2$srawN\n"
" %1$s -qa\n"
msgstr ""
" %1$s %2$srawN <hlavní> <vedlejší>\n"
" %1$s %2$srawN /dev/<blokové_zařízení>\n"
" %1$s -q %2$srawN\n"
" %1$s -qa\n"

#: disk-utils/raw.c:57
msgid "Bind a raw character device to a block device.\n"
msgstr "Napojí syrové znakové zařízení k blokovému zařízení.\n"

#: disk-utils/raw.c:60
msgid " -q, --query    set query mode\n"
msgstr " -q, --query    nastaví dotazovací režim\n"

#: disk-utils/raw.c:61
msgid " -a, --all      query all raw devices\n"
msgstr " -a, --all      dotáže se všech syrových zařízení\n"

#: disk-utils/raw.c:166
#, c-format
msgid "Device '%s' is the control raw device (use raw<N> where <N> is greater than zero)"
msgstr "Zařízení „%s“ je řídicí syrové zařízení (použijte raw<N>, kde <N> je větší než nula)"

#: disk-utils/raw.c:183
#, c-format
msgid "Cannot locate block device '%s'"
msgstr "Blokové zařízení „%s“ nelze nalézt"

#: disk-utils/raw.c:186
#, c-format
msgid "Device '%s' is not a block device"
msgstr "Zařízení „%s“ není blokovým zařízením"

#: disk-utils/raw.c:195 disk-utils/raw.c:198 sys-utils/ipcrm.c:352
#: sys-utils/ipcrm.c:366 sys-utils/ipcrm.c:380
msgid "failed to parse argument"
msgstr "argument se nepodařilo rozebrat"

#: disk-utils/raw.c:216
#, c-format
msgid "Cannot open master raw device '%s'"
msgstr "Hlavní syrové zařízení „%s“ nelze otevřít"

#: disk-utils/raw.c:231
#, c-format
msgid "Cannot locate raw device '%s'"
msgstr "Syrové zařízení „%s“ nelze nalézt"

#: disk-utils/raw.c:234
#, c-format
msgid "Raw device '%s' is not a character dev"
msgstr "Syrové zařízení „%s“ není znakovým zařízením"

#: disk-utils/raw.c:238
#, c-format
msgid "Device '%s' is not a raw dev"
msgstr "Zařízení „%s“ není syrovým zařízením"

#: disk-utils/raw.c:248
msgid "Error querying raw device"
msgstr "Chyba při dotazování se na syrové zařízené"

#: disk-utils/raw.c:257 disk-utils/raw.c:272
#, c-format
msgid "%sraw%d:  bound to major %d, minor %d\n"
msgstr "%sraw%d: napojeno na čísla hlavní %d, vedlejší %d\n"

#: disk-utils/raw.c:271
msgid "Error setting raw device"
msgstr "Chyba při nastavování syrového zařízení"

#: disk-utils/resizepart.c:20
#, c-format
msgid " %s <disk device> <partition number> <length>\n"
msgstr " %s <diskové_zařízení> <číslo_oddílu> <délka>\n"

#: disk-utils/resizepart.c:24
msgid "Tell the kernel about the new size of a partition.\n"
msgstr "Řekne jádru o nové velikosti oddílů.\n"

#: disk-utils/resizepart.c:107
#, c-format
msgid "%s: failed to get start of the partition number %s"
msgstr "%s: získání začátku oddílu číslo %s selhalo"

#: disk-utils/resizepart.c:112
msgid "failed to resize partition"
msgstr "změnit velikost oddílu se nepodařilo"

#: disk-utils/sfdisk.c:239
msgid "failed to allocate nested libfdisk context"
msgstr "alokace vnořeného kontextu libfdisku selhala"

#: disk-utils/sfdisk.c:299
#, c-format
msgid "cannot seek %s"
msgstr "pohyb v %s selhal"

#: disk-utils/sfdisk.c:310 libfdisk/src/bsd.c:724 libfdisk/src/bsd.c:905
#: term-utils/script.c:461
#, c-format
msgid "cannot write %s"
msgstr "%s nelze zapsat"

#: disk-utils/sfdisk.c:317
#, c-format
msgid "%12s (offset %5ju, size %5ju): %s"
msgstr "%12s (posun %5ju, velikost %5ju): %s"

#: disk-utils/sfdisk.c:323
#, c-format
msgid "%s: failed to create a backup"
msgstr "%s: zálohu se nepodařilo vytvořit"

#: disk-utils/sfdisk.c:336
msgid "failed to create a backup file, $HOME undefined"
msgstr "záložní soubor se nepodařilo vytvořit, $HOME není definována"

#: disk-utils/sfdisk.c:362
msgid "Backup files:"
msgstr "Záložní soubory:"

#: disk-utils/sfdisk.c:408
msgid "failed to read new partition from device; ignoring --move-data"
msgstr "načtení tabulky rozdělení disku ze zařízení selhalo, --move-data se ignoruje"

#: disk-utils/sfdisk.c:410
msgid "failed to get size of the new partition; ignoring --move-data"
msgstr "získání velikosti nového oddílu selhalo, --move-data se ignoruje"

#: disk-utils/sfdisk.c:412
msgid "failed to get start of the new partition; ignoring --move-data"
msgstr "získání začátku nového oddílu selhalo, --move-data se ignoruje"

#: disk-utils/sfdisk.c:414
msgid "failed to get size of the old partition; ignoring --move-data"
msgstr "získání velikosti starého oddílu selhalo, --move-data se ignoring"

#: disk-utils/sfdisk.c:416
msgid "failed to get start of the old partition; ignoring --move-data"
msgstr "získání začátku starého oddílu selhalo, --move-data se ignoring"

#: disk-utils/sfdisk.c:418
msgid "start of the partition has not been moved; ignoring --move-data"
msgstr "začátek oddílu nebyl přesunut, --move-date se ignoruje"

#: disk-utils/sfdisk.c:420
msgid "new partition is smaller than original; ignoring --move-data"
msgstr "nový oddíl je menší než původní, --move-data se ignoruje"

#: disk-utils/sfdisk.c:471
msgid "Data move: (--no-act)"
msgstr "Přesun dat: (--no-act)"

#: disk-utils/sfdisk.c:471
msgid "Data move:"
msgstr "Přesun dat:"

#: disk-utils/sfdisk.c:474
#, c-format
msgid " typescript file: %s"
msgstr " soubor se záznamem: %s"

#: disk-utils/sfdisk.c:475
#, c-format
msgid "  start sector: (from/to) %ju / %ju\n"
msgstr "  počáteční sektor: (z/do) %ju / %ju\n"

#: disk-utils/sfdisk.c:476
#, c-format
msgid "  sectors: %ju\n"
msgstr "  sektorů: %ju\n"

#: disk-utils/sfdisk.c:477
#, c-format
msgid "  step size: %zu bytes\n"
msgstr "  velikost kroku: %zu bajtů\n"

#: disk-utils/sfdisk.c:487
msgid "Do you want to move partition data?"
msgstr "Chcete přesunout data oddílu?"

#: disk-utils/sfdisk.c:489 disk-utils/sfdisk.c:1975
msgid "Leaving."
msgstr "Opouští se."

#: disk-utils/sfdisk.c:549
#, c-format
msgid "cannot read at offset: %zu; continue"
msgstr ""

#: disk-utils/sfdisk.c:560
#, c-format
msgid "cannot write at offset: %zu; continue"
msgstr ""

#: disk-utils/sfdisk.c:589
#, c-format
msgid "Moved %ju from %ju sectors (%.3f%%, %.1f MiB/s)."
msgstr "Přesunuto %ju z %ju sektorů (%.3f %%, %.1f MiB/s)."

#: disk-utils/sfdisk.c:594
#, c-format
msgid "Moved %ju from %ju sectors (%.3f%%)."
msgstr "Přesunuto %ju z %ju sektorů (%.3f %%)."

#: disk-utils/sfdisk.c:612
#, fuzzy, c-format
msgid "Moved %ju from %ju sectors (%.0f%%)."
msgstr "Přesunuto %ju z %ju sektorů (%.3f %%)."

#: disk-utils/sfdisk.c:626
msgid "Your data has not been moved (--no-act)."
msgstr "Vaše data nebyla přesunuta (--no-act)."

#: disk-utils/sfdisk.c:628
#, fuzzy, c-format
msgid "%zu I/O errors detected!"
msgstr "Objevena %d chyba."

#: disk-utils/sfdisk.c:631
#, c-format
msgid "%s: failed to move data"
msgstr "%s: přesun dat selhal"

#: disk-utils/sfdisk.c:641
msgid "The partition table is unchanged (--no-act)."
msgstr "Tabulka rozdělení disku je nezměněna (--no-act)."

#: disk-utils/sfdisk.c:649
msgid ""
"\n"
"The partition table has been altered."
msgstr ""
"\n"
"Tabulka rozdělení disku byla změněna."

#: disk-utils/sfdisk.c:724
#, c-format
msgid "unsupported label '%s'"
msgstr "nepodporovaný popis „%s“"

#: disk-utils/sfdisk.c:727
msgid ""
"Id  Name\n"
"\n"
msgstr ""
"Id  Název\n"
"\n"

#: disk-utils/sfdisk.c:754
msgid "unrecognized partition table type"
msgstr "nerozpoznaný typ tabulky rozdělení disku"

#: disk-utils/sfdisk.c:807
#, c-format
msgid "Cannot get size of %s"
msgstr "Nelze zjistit velikost %s"

#: disk-utils/sfdisk.c:844
#, c-format
msgid "total: %ju blocks\n"
msgstr "celkový počet bloků: %'ju\n"

#: disk-utils/sfdisk.c:903 disk-utils/sfdisk.c:981 disk-utils/sfdisk.c:1018
#: disk-utils/sfdisk.c:1043 disk-utils/sfdisk.c:1113 disk-utils/sfdisk.c:1180
#: disk-utils/sfdisk.c:1235 disk-utils/sfdisk.c:1291 disk-utils/sfdisk.c:1344
#: disk-utils/sfdisk.c:1382 disk-utils/sfdisk.c:1718
msgid "no disk device specified"
msgstr "žádné diskové zařízení nebylo zadáno"

#: disk-utils/sfdisk.c:913
msgid "toggle boot flags is unsupported for Hybrid GPT/MBR"
msgstr "přepínání příznaku zaveditelnosti není na hybridním GPT/MBR podporováno"

#: disk-utils/sfdisk.c:918
msgid "cannot switch to PMBR"
msgstr "nelze přepnout do PMBR"

#: disk-utils/sfdisk.c:919
msgid "Activation is unsupported for GPT -- entering nested PMBR."
msgstr "Aktivace není na GPT podporována – vstupuje se do zanořené PMBR."

#: disk-utils/sfdisk.c:922
msgid "toggle boot flags is supported for MBR or PMBR only"
msgstr "přepínání příznaku zaveditelnosti je podporováno jen na MBR a PMBR"

#: disk-utils/sfdisk.c:954 disk-utils/sfdisk.c:997 disk-utils/sfdisk.c:1118
#: disk-utils/sfdisk.c:1185 disk-utils/sfdisk.c:1240 disk-utils/sfdisk.c:1296
#: disk-utils/sfdisk.c:1716 disk-utils/sfdisk.c:2240
msgid "failed to parse partition number"
msgstr "rozbor čísla oddílu selhal"

#: disk-utils/sfdisk.c:959
#, c-format
msgid "%s: partition %d: failed to toggle bootable flag"
msgstr "%s: oddíl %d: přepnutí příznaku zaveditelnosti selhalo"

#: disk-utils/sfdisk.c:992 disk-utils/sfdisk.c:1000
#, c-format
msgid "%s: partition %zu: failed to delete"
msgstr "%s: oddíl %zu: odstraňování selhalo"

#: disk-utils/sfdisk.c:1048
#, c-format
msgid "%s: does not contain a recognized partition table"
msgstr "%s: neobsahuje známou tabulku rozdělení disku"

#: disk-utils/sfdisk.c:1052
msgid "failed to allocate dump struct"
msgstr "alokace exportní struktury selhala"

#: disk-utils/sfdisk.c:1056
#, c-format
msgid "%s: failed to dump partition table"
msgstr "%s: tabulku rozdělení disku se nepodařilo vyexportovat"

#: disk-utils/sfdisk.c:1091
#, c-format
msgid "%s: no partition table found"
msgstr "%s: nalezena žádná tabulka rozdělení disku"

# TODO: Pluralize
#: disk-utils/sfdisk.c:1095
#, c-format
msgid "%s: partition %zu: partition table contains only %zu partitions"
msgstr "%s: oddíl %zu: tabulka rozdělení disku obsahuje jen %zu oddílů"

#: disk-utils/sfdisk.c:1098
#, c-format
msgid "%s: partition %zu: partition is unused"
msgstr "%s: oddíl %zu: oddíl není nevyužit"

#: disk-utils/sfdisk.c:1117 disk-utils/sfdisk.c:1184 disk-utils/sfdisk.c:1239
#: disk-utils/sfdisk.c:1295
msgid "no partition number specified"
msgstr "žádné číslo oddílu nebylo zadáno"

#: disk-utils/sfdisk.c:1123 disk-utils/sfdisk.c:1190 disk-utils/sfdisk.c:1245
#: disk-utils/sfdisk.c:1301 disk-utils/sfdisk.c:1350 disk-utils/sfdisk.c:1384
#: sys-utils/losetup.c:778
msgid "unexpected arguments"
msgstr "neočekávané argumenty"

#: disk-utils/sfdisk.c:1138
#, c-format
msgid "%s: partition %zu: failed to get partition type"
msgstr "%s: oddíl %zu: získání typu oddílu selhalo"

#: disk-utils/sfdisk.c:1160
#, c-format
msgid "failed to parse %s partition type '%s'"
msgstr "nezdařilo se rozebrat typ oddílu %s „%s“"

#: disk-utils/sfdisk.c:1164
#, c-format
msgid "%s: partition %zu: failed to set partition type"
msgstr "%s: oddíl %zu: nastavení typu oddílu selhalo"

#: disk-utils/sfdisk.c:1202
#, c-format
msgid "%s: partition %zu: failed to get partition UUID"
msgstr "%s: oddíl %zu: nepodařilo se získat UUID oddílu"

#: disk-utils/sfdisk.c:1215 disk-utils/sfdisk.c:1270 disk-utils/sfdisk.c:1324
msgid "failed to allocate partition object"
msgstr "alokace objektu oddílu selhala"

#: disk-utils/sfdisk.c:1219
#, c-format
msgid "%s: partition %zu: failed to set partition UUID"
msgstr "%s: oddíl %zu: nepodařilo se nastavit UUID oddílu"

#: disk-utils/sfdisk.c:1257
#, c-format
msgid "%s: partition %zu: failed to get partition name"
msgstr "%s: oddíl %zu: nepodařilo se získat název oddílu"

#: disk-utils/sfdisk.c:1274
#, c-format
msgid "%s: partition %zu: failed to set partition name"
msgstr "%s: oddíl %zu: nepodařilo se nastavit název oddílu"

#: disk-utils/sfdisk.c:1328
#, c-format
msgid "%s: partition %zu: failed to set partition attributes"
msgstr "%s: oddíl %zu: nepodařilo se nastavit atributy oddílu"

#: disk-utils/sfdisk.c:1365
#, fuzzy, c-format
msgid "%s: failed to set disklabel ID"
msgstr "%s: přesun na jmenovku odkládacího prostoru selhal"

#: disk-utils/sfdisk.c:1380
#, fuzzy
msgid "no relocate operation specified"
msgstr "Přepínač --date vyžaduje argument."

#: disk-utils/sfdisk.c:1394
#, fuzzy
msgid "unsupported relocation operation"
msgstr "nepodporovaný formát parametru: %s"

#: disk-utils/sfdisk.c:1439
msgid " Commands:\n"
msgstr " Příkazy:\n"

#: disk-utils/sfdisk.c:1441
msgid "   write    write table to disk and exit\n"
msgstr "   write    uloží tabulku rozdělení disku a skončí\n"

#: disk-utils/sfdisk.c:1442
msgid "   quit     show new situation and wait for user's feedback before write\n"
msgstr "   quit     zobrazí novou situaci a před zápisem počká na potvrzení uživatele\n"

#: disk-utils/sfdisk.c:1443
msgid "   abort    exit sfdisk shell\n"
msgstr "   abort    ukončí příkazové prostředí sfdisku\n"

#: disk-utils/sfdisk.c:1444
msgid "   print    display the partition table\n"
msgstr "   print    zobrazí tabulku rozdělení disku\n"

#: disk-utils/sfdisk.c:1445
msgid "   help     show this help text\n"
msgstr "   help     zobrazí tuto nápovědu\n"

#: disk-utils/sfdisk.c:1447
msgid "   Ctrl-D   the same as 'quit'\n"
msgstr "   Ctrl-D   stejné jako příkaz „quit“\n"

#: disk-utils/sfdisk.c:1451
msgid " Input format:\n"
msgstr " Formát vstupu:\n"

#: disk-utils/sfdisk.c:1453
msgid "   <start>, <size>, <type>, <bootable>\n"
msgstr "   <začátek>, <velikost>, <typ>, <zaveditelný>\n"

#: disk-utils/sfdisk.c:1456
msgid ""
"   <start>  Beginning of the partition in sectors, or bytes if\n"
"            specified in the format <number>{K,M,G,T,P,E,Z,Y}.\n"
"            The default is the first free space.\n"
msgstr ""
"   <začátek>      Začátek oddílu v sektorech. Je-li zadán ve tvaru\n"
"                  <číslo>{K,M,G,T,P,E,Z,Y}, pak se jedná o bajty. Výchozí\n"
"                  je první volné místo.\n"

#: disk-utils/sfdisk.c:1461
msgid ""
"   <size>   Size of the partition in sectors, or bytes if\n"
"            specified in the format <number>{K,M,G,T,P,E,Z,Y}.\n"
"            The default is all available space.\n"
msgstr ""
"   <velikost>     Velikost oddílu v sektorech. Je-li zadána ve tvaru\n"
"                  <číslo>{K,M,G,T,P,E,Z,Y}, pak se jedná o bajty. Výchozí\n"
"                  je veškeré dostupné místo.\n"

#: disk-utils/sfdisk.c:1466
msgid "   <type>   The partition type.  Default is a Linux data partition.\n"
msgstr "   <typ>    Druh oddílu. Výchozí je linuxový datový oddíl.\n"

#: disk-utils/sfdisk.c:1467
#, fuzzy
msgid "            MBR: hex or L,S,Ex,X,U,R,V shortcuts.\n"
msgstr "            MBR: šestnáctkové nebo zkratky L, S, E, X, U, R, V.\n"

#: disk-utils/sfdisk.c:1468
msgid "            GPT: UUID or L,S,H,U,R,V shortcuts.\n"
msgstr "            GPT: UUID nebo zkratky L, S, H, U, R, V.\n"

#: disk-utils/sfdisk.c:1471
msgid "   <bootable>  Use '*' to mark an MBR partition as bootable.\n"
msgstr "   <zaveditelný>  Označte pomocí „*“ MBR oddíl jako zaveditelný.\n"

#: disk-utils/sfdisk.c:1475
msgid " Example:\n"
msgstr " Příklad:\n"

#: disk-utils/sfdisk.c:1477
msgid "   , 4G     Creates a 4GiB partition at default start offset.\n"
msgstr "   , 4G     Vytvoří 4GiB oddíl na výchozí počáteční pozici.\n"

#: disk-utils/sfdisk.c:1509 sys-utils/dmesg.c:1578
msgid "unsupported command"
msgstr "nepodporovaný příkaz"

#: disk-utils/sfdisk.c:1511
#, c-format
msgid "line %d: unsupported command"
msgstr "řádek %d: nepodporovaný příkaz"

#: disk-utils/sfdisk.c:1630
#, c-format
msgid "The device contains '%s' signature and it will be removed by a write command. See sfdisk(8) man page and --wipe option for more details."
msgstr "Zařízení obsahuje vzorec %s a příkazem k zápisu bude odstraněn. Pro podrobnosti vizte manuál sfdisk(8) a přepínač --wipe)."

# The %s is a file system type
#: disk-utils/sfdisk.c:1637
#, c-format
msgid "The device contains '%s' signature and it may remain on the device. It is recommended to wipe the device with wipefs(8) or sfdisk --wipe, in order to avoid possible collisions."
msgstr "Zařízení obsahuje vzorec „%s“ a možná zůstane na zařízení. Doporučuje se vyčistit zařízení příkazem wipefs(8) nebo sfdisk --wipe, aby se předešlo možným kolizím."

#: disk-utils/sfdisk.c:1685
msgid "failed to allocate partition name"
msgstr "název oddílu se nepodařilo alokovat"

#: disk-utils/sfdisk.c:1724
msgid "failed to allocate script handler"
msgstr "alokace obsluhy skriptu selhala"

#: disk-utils/sfdisk.c:1740
#, c-format
msgid "%s: cannot modify partition %d: no partition table was found"
msgstr "%s: oddíl %d nelze změnit: žádná tabulka rozdělení disku nebyl nalezena"

# TOOD: pluralize
#: disk-utils/sfdisk.c:1745
#, c-format
msgid "%s: cannot modify partition %d: partition table contains only %zu partitions"
msgstr "%s: oddíl %d nelze změnit: tabulka rozdělení disku obsahuje pouze %zu oddílů"

#: disk-utils/sfdisk.c:1751
#, c-format
msgid "warning: %s: partition %d is not defined yet"
msgstr "pozor: %s: oddíl %d není ještě definován"

#: disk-utils/sfdisk.c:1769
#, c-format
msgid ""
"\n"
"Welcome to sfdisk (%s)."
msgstr ""
"\n"
"Vítejte v sfdisku (%s)."

#: disk-utils/sfdisk.c:1777
msgid "Checking that no-one is using this disk right now ..."
msgstr "Ověřuje se, zda tento disk není právě používán…"

#: disk-utils/sfdisk.c:1780
msgid ""
" FAILED\n"
"\n"
msgstr ""
" SELHALO\n"
"\n"

#: disk-utils/sfdisk.c:1783
msgid ""
"This disk is currently in use - repartitioning is probably a bad idea.\n"
"Umount all file systems, and swapoff all swap partitions on this disk.\n"
"Use the --no-reread flag to suppress this check.\n"
msgstr ""
"Tento disk je právě používán - vytváření oddílů není dobrým\n"
"nápadem. Odpojte všechny systémy souborů a pomocí swapoff deaktivujte\n"
"všechny odkládací prostory na tomto disku. K potlačení této kontroly můžete\n"
"použít přepínač --no-reread.\n"

#: disk-utils/sfdisk.c:1788
msgid "Use the --force flag to overrule all checks."
msgstr "Použijte přepínač --force k potlačení veškerých kontrol."

#: disk-utils/sfdisk.c:1790
msgid ""
" OK\n"
"\n"
msgstr ""
" OK\n"
"\n"

#: disk-utils/sfdisk.c:1799
msgid ""
"\n"
"Old situation:"
msgstr ""
"\n"
"Stará situace:"

#: disk-utils/sfdisk.c:1812
#, fuzzy
msgid "failed to set script header"
msgstr "alokace obsluhy skriptu selhala"

#: disk-utils/sfdisk.c:1817
#, c-format
msgid ""
"\n"
"sfdisk is going to create a new '%s' disk label.\n"
"Use 'label: <name>' before you define a first partition\n"
"to override the default."
msgstr ""
"\n"
"sfdisk hodlá vytvořit nový „%s“ popis disku.\n"
"Dříve než vytvoříte první oddíl, můžete výchozí hodnotu změnit pomocí\n"
"„label: <název>“."

#: disk-utils/sfdisk.c:1820
msgid ""
"\n"
"Type 'help' to get more information.\n"
msgstr ""
"\n"
"Více informací získáte napsáním „help“.\n"

#: disk-utils/sfdisk.c:1838
msgid "All partitions used."
msgstr "Všechny oddíly jsou použity."

#: disk-utils/sfdisk.c:1858
#, c-format
msgid "Unknown script header '%s' -- ignore."
msgstr ""

#: disk-utils/sfdisk.c:1874
msgid "Done.\n"
msgstr "Hotovo.\n"

#: disk-utils/sfdisk.c:1886
msgid "Ignoring partition."
msgstr "Oddíl se ignoruje."

#: disk-utils/sfdisk.c:1895 disk-utils/sfdisk.c:1956
msgid "Failed to apply script headers, disk label not created."
msgstr "Hlavičky skriptu ne nepodařilo použít. Popis disku nebyl nevytvořen."

#: disk-utils/sfdisk.c:1916
#, c-format
msgid "Failed to add #%d partition"
msgstr "Oddíl č. %d se nepodařilo přidat"

#: disk-utils/sfdisk.c:1939
msgid "Script header accepted."
msgstr "Hlavička skriptu přijata."

#: disk-utils/sfdisk.c:1963
msgid ""
"\n"
"New situation:"
msgstr ""
"\n"
"Nová situace:"

#: disk-utils/sfdisk.c:1973
msgid "Do you want to write this to disk?"
msgstr "Uložit toto na disk?"

#: disk-utils/sfdisk.c:1986
msgid "Leaving.\n"
msgstr "Opouští se.\n"

#: disk-utils/sfdisk.c:2001
#, c-format
msgid ""
" %1$s [options] <dev> [[-N] <part>]\n"
" %1$s [options] <command>\n"
msgstr ""
" %1$s [přepínače] <zařízení> [[-N] <oddíl>\n"
" %1$s [přepínače] <příkaz>\n"

#: disk-utils/sfdisk.c:2008
msgid " -A, --activate <dev> [<part> ...] list or set bootable (P)MBR partitions\n"
msgstr ""
" -A, --activate <zařízení> [<oddíl> …]\n"
"                                   vypíše nebo nastaví zaveditelné oddíly (P)MBR\n"

#: disk-utils/sfdisk.c:2009
msgid " -d, --dump <dev>                  dump partition table (usable for later input)\n"
msgstr ""
" -d, --dump <zařízení>             exportuje tabulku rozdělení disku\n"
"                                   (použitelné později jako vstup)\n"

#: disk-utils/sfdisk.c:2010
msgid " -J, --json <dev>                  dump partition table in JSON format\n"
msgstr " -J, --json <zařízení>             exportuje tabulku rozdělení disku v JSONu\n"

#: disk-utils/sfdisk.c:2011
msgid " -g, --show-geometry [<dev> ...]   list geometry of all or specified devices\n"
msgstr ""
" -g, --show-geometry [<zařízení> …]\n"
"                                   vypíše geometrii všech nebo zadaných zařízení\n"

#: disk-utils/sfdisk.c:2012
msgid " -l, --list [<dev> ...]            list partitions of each device\n"
msgstr " -l, --list [<zařízení> …]         vypíše oddíly na každém zařízení\n"

#: disk-utils/sfdisk.c:2013
msgid " -F, --list-free [<dev> ...]       list unpartitioned free areas of each device\n"
msgstr " -F, --list-free [<zařízení> …]    vypíše volné oblasti na každém zařízení\n"

#: disk-utils/sfdisk.c:2014
msgid " -r, --reorder <dev>               fix partitions order (by start offset)\n"
msgstr " -r, --reorder <zařízení>          opraví řazení oddílů (podle pozice začátku)\n"

#: disk-utils/sfdisk.c:2015
msgid " -s, --show-size [<dev> ...]       list sizes of all or specified devices\n"
msgstr ""
" -s, --show-size [<zařízení> …]    vypíše velikosti všech nebo zadaných\n"
"                                   zařízení\n"

#: disk-utils/sfdisk.c:2016
msgid " -T, --list-types                  print the recognized types (see -X)\n"
msgstr " -T, --list-types                  vypíše známé typy (vizte -X)\n"

#: disk-utils/sfdisk.c:2017
msgid " -V, --verify [<dev> ...]          test whether partitions seem correct\n"
msgstr " -V, --verify [<zařízení> …]       zkontroluje, zda oddíly vypadají v pořádku\n"

#: disk-utils/sfdisk.c:2018
msgid "     --delete <dev> [<part> ...]   delete all or specified partitions\n"
msgstr ""
"     --delete <zařízení> [<oddíl> …]\n"
"                                   smaže všechny nebo uvedené oddíly\n"

#: disk-utils/sfdisk.c:2021
msgid " --part-label <dev> <part> [<str>] print or change partition label\n"
msgstr ""
" --part-label <zařízení> <oddíl> [<řetězec>]\n"
"                                  vypíše nebo změní název oddílu\n"

#: disk-utils/sfdisk.c:2022
msgid " --part-type <dev> <part> [<type>] print or change partition type\n"
msgstr ""
" --part-type <zařízení> <oddíl> [<typ>]\n"
"                                  vypíše nebo změní typ oddílu\n"

#: disk-utils/sfdisk.c:2023
msgid " --part-uuid <dev> <part> [<uuid>] print or change partition uuid\n"
msgstr ""
" --part-uuid <zařízení> <oddíl> [<UUID>]\n"
"                                  vypíše nebo změní UUID oddílu\n"

#: disk-utils/sfdisk.c:2024
msgid " --part-attrs <dev> <part> [<str>] print or change partition attributes\n"
msgstr ""
" --part-attrs <zařízení> <oddíl> [<řetězec>]\n"
"                                  vypíše nebo změní atributy oddílu\n"

#: disk-utils/sfdisk.c:2027
#, fuzzy
msgid " --disk-id <dev> [<str>]           print or change disk label ID (UUID)\n"
msgstr ""
" --part-label <zařízení> <oddíl> [<řetězec>]\n"
"                                  vypíše nebo změní název oddílu\n"

#: disk-utils/sfdisk.c:2028
#, fuzzy
msgid " --relocate <oper> <dev>           move partition header\n"
msgstr " -l, --list [<zařízení> …]         vypíše oddíly na každém zařízení\n"

#: disk-utils/sfdisk.c:2031
msgid " <dev>                     device (usually disk) path\n"
msgstr " <zařízení>                cesta k zařízení (obvykle k disku)\n"

#: disk-utils/sfdisk.c:2032
msgid " <part>                    partition number\n"
msgstr " <oddíl>                   číslo oddílu\n"

#: disk-utils/sfdisk.c:2033
msgid " <type>                    partition type, GUID for GPT, hex for MBR\n"
msgstr ""
" <typo>                    typ oddílu, GUID pro GPT, šestnáctkové číslo\n"
"                           pro MBR\n"

#: disk-utils/sfdisk.c:2036
msgid " -a, --append              append partitions to existing partition table\n"
msgstr " -a, --append              připojí oddíly k existující tabulce rozdělení disku\n"

#: disk-utils/sfdisk.c:2037
msgid " -b, --backup              backup partition table sectors (see -O)\n"
msgstr " -b, --backup              sektory záložní tabulky rozdělení disku (vize -O)\n"

#: disk-utils/sfdisk.c:2038
msgid "     --bytes               print SIZE in bytes rather than in human readable format\n"
msgstr ""
"     --bytes               velikosti vypisuje v bajtech namísto podobě vhodné\n"
"                           pro člověka\n"

#: disk-utils/sfdisk.c:2039
msgid "     --move-data[=<typescript>] move partition data after relocation (requires -N)\n"
msgstr ""
"     --move-data[=<soubor se záznamem>]\n"
"                                po realokaci přesune data oddílu (vyžaduje -N)\n"

#: disk-utils/sfdisk.c:2040
msgid "     --move-use-fsync      use fsync after each write when move data\n"
msgstr "     --move-use-fsync      při přesunu dat použije fsync za každým zápisem\n"

#: disk-utils/sfdisk.c:2041
msgid " -f, --force               disable all consistency checking\n"
msgstr " -f, --force               vypne veškeré kontroly soudržnosti\n"

#: disk-utils/sfdisk.c:2044
#, c-format
msgid "     --color[=<when>]      colorize output (%s, %s or %s)\n"
msgstr "     --color[=<kdy>]       obarví výstup (%s, %s nebo %s)\n"

#: disk-utils/sfdisk.c:2049
msgid " -N, --partno <num>        specify partition number\n"
msgstr " -N, --partno <číslo>      určuje číslo oddílu\n"

#: disk-utils/sfdisk.c:2050
msgid " -n, --no-act              do everything except write to device\n"
msgstr " -n, --no-act              udělá vše kromě zápisu do zařízení\n"

#: disk-utils/sfdisk.c:2051
msgid "     --no-reread           do not check whether the device is in use\n"
msgstr "     --no-reread           nekontroluje, zda-li se zařízení používá\n"

#: disk-utils/sfdisk.c:2052
msgid "     --no-tell-kernel      do not tell kernel about changes\n"
msgstr "    --no-tell-kernel       neřekne jádru o změnách\n"

#: disk-utils/sfdisk.c:2053
msgid " -O, --backup-file <path>  override default backup file name\n"
msgstr " -O, --backup-file <cesta> přebije výchozí název záložního souboru\n"

#: disk-utils/sfdisk.c:2054
msgid " -o, --output <list>       output columns\n"
msgstr " -o, --output <seznam>     zobrazí zadané sloupce\n"

#: disk-utils/sfdisk.c:2055
msgid " -q, --quiet               suppress extra info messages\n"
msgstr " -q, --quiet               potlačí informační hlášky\n"

#: disk-utils/sfdisk.c:2057
#, c-format
msgid " -w, --wipe <mode>         wipe signatures (%s, %s or %s)\n"
msgstr " -w, --wipe <režim>        vymaže vzorce (%s, %s nebo %s)\n"

#: disk-utils/sfdisk.c:2060
msgid " -X, --label <name>        specify label type (dos, gpt, ...)\n"
msgstr " -X, --label <název>       určuje název typu (dos, gpt, …)\n"

#: disk-utils/sfdisk.c:2061
msgid " -Y, --label-nested <name> specify nested label type (dos, bsd)\n"
msgstr ""
" -Y, --label-nested <název>\n"
"                           určuje typ vnořeného popisu (dos, bsd)\n"

#: disk-utils/sfdisk.c:2063
msgid " -G, --show-pt-geometry    deprecated, alias to --show-geometry\n"
msgstr " -G, --show-pt-geometry    zastaralé, stejné jako --show-geometry\n"

#: disk-utils/sfdisk.c:2064
msgid " -L, --Linux               deprecated, only for backward compatibility\n"
msgstr " -L, --Linux               zastaralé, pouze pro zpětnou kompatibilitu\n"

#: disk-utils/sfdisk.c:2065
msgid " -u, --unit S              deprecated, only sector unit is supported\n"
msgstr " -u, --unit S              zastaralé, podporované jednotky jsou pouze sektory\n"

#: disk-utils/sfdisk.c:2194
#, c-format
msgid "%s is deprecated in favour of --part-type"
msgstr "%s byl nahrazen přepínačem --part-type"

#: disk-utils/sfdisk.c:2199
msgid "--id is deprecated in favour of --part-type"
msgstr "--id byl nahrazen přepínačem --part-type"

#: disk-utils/sfdisk.c:2215
msgid "--show-pt-geometry is no more implemented. Using --show-geometry."
msgstr "--show-pt-geometry již není implementováno. Použijte --show-geometry."

#: disk-utils/sfdisk.c:2227
msgid "--Linux option is unnecessary and deprecated"
msgstr "přepínač --Linux je zastaralý a již není třeba"

#: disk-utils/sfdisk.c:2256
#, c-format
msgid "unsupported unit '%c'"
msgstr "nepodporovaná jednotka „%c“"

#: disk-utils/sfdisk.c:2351
msgid "--movedata requires -N"
msgstr "přepínač --movedata vyžaduje přepínač -N"

#: disk-utils/swaplabel.c:74
#, c-format
msgid "failed to parse UUID: %s"
msgstr "UUID se nezdařilo rozebrat: %s"

#: disk-utils/swaplabel.c:78
#, c-format
msgid "%s: failed to seek to swap UUID"
msgstr "%s: přesun na UUID odkládacího prostoru selhal"

#: disk-utils/swaplabel.c:82
#, c-format
msgid "%s: failed to write UUID"
msgstr "%s: zápis UUID se nezdařil"

#: disk-utils/swaplabel.c:93
#, c-format
msgid "%s: failed to seek to swap label "
msgstr "%s: přesun na jmenovku odkládacího prostoru selhal"

#: disk-utils/swaplabel.c:100
#, c-format
msgid "label is too long. Truncating it to '%s'"
msgstr "jmenovka je příliš dlouhá. Zkrácena na „%s“"

#: disk-utils/swaplabel.c:103
#, c-format
msgid "%s: failed to write label"
msgstr "%s: chyba při zápisu jmenovky"

#: disk-utils/swaplabel.c:127
msgid "Display or change the label or UUID of a swap area.\n"
msgstr "Zobrazí nebo změní jmenovku nebo UUID odkládací oblasti.\n"

#: disk-utils/swaplabel.c:130
msgid ""
" -L, --label <label> specify a new label\n"
" -U, --uuid <uuid>   specify a new uuid\n"
msgstr ""
" -L, --label <jmenovka> určuje novou jmenovku\n"
" -U, --uuid <UUID>      určuje nové UUID\n"

#: disk-utils/swaplabel.c:171
msgid "ignore -U (UUIDs are unsupported)"
msgstr "ignoruje se -U (UUID není podporováno)"

#: include/c.h:245
#, c-format
msgid "Try '%s --help' for more information.\n"
msgstr "Více informací získáte příkazem „%s --help“.\n"

#: include/c.h:349
msgid ""
"\n"
"Usage:\n"
msgstr ""
"\n"
"Použití:\n"

#: include/c.h:350
msgid ""
"\n"
"Options:\n"
msgstr ""
"\n"
"Přepínače:\n"

#: include/c.h:351
msgid ""
"\n"
"Functions:\n"
msgstr ""
"\n"
"Funkce:\n"

#: include/c.h:352
msgid ""
"\n"
"Commands:\n"
msgstr ""
"\n"
"Příkazy:\n"

#: include/c.h:353
#, fuzzy
msgid ""
"\n"
"Arguments:\n"
msgstr "chybné argumenty"

#: include/c.h:354
msgid ""
"\n"
"Available output columns:\n"
msgstr ""
"\n"
"Dostupné sloupce pro výstup:\n"

#: include/c.h:357
msgid "display this help"
msgstr "zobrazí tuto nápovědu"

#: include/c.h:358
msgid "display version"
msgstr "zobrazí verzi"

#: include/c.h:368
#, c-format
msgid ""
" %s arguments may be followed by the suffixes for\n"
"   GiB, TiB, PiB, EiB, ZiB, and YiB (the \"iB\" is optional)\n"
msgstr ""

#: include/c.h:371
#, c-format
msgid ""
"\n"
"For more details see %s.\n"
msgstr ""
"\n"
"Podrobnosti naleznete v %s.\n"

#: include/c.h:373
#, c-format
msgid "%s from %s\n"
msgstr "%s z %s\n"

#: include/closestream.h:70 include/closestream.h:72 login-utils/vipw.c:276
#: login-utils/vipw.c:295 sys-utils/rtcwake.c:304 term-utils/setterm.c:833
#: text-utils/col.c:160
msgid "write error"
msgstr "chyba při zápisu"

#: include/colors.h:27
msgid "colors are enabled by default"
msgstr "barvy jsou ve výchozím nastavení zapnuty"

#: include/colors.h:29
msgid "colors are disabled by default"
msgstr "barvy jsou ve výchozím nastavení vypnuty"

#: include/env.h:18 lib/pager.c:153 login-utils/login.c:1102
#: login-utils/login.c:1106 term-utils/agetty.c:1203
#, c-format
msgid "failed to set the %s environment variable"
msgstr "nepodařilo se nastavit proměnnou prostředí %s"

#: include/optutils.h:85
#, c-format
msgid "%s: mutually exclusive arguments:"
msgstr "%s: vzájemně se vylučující argumenty:"

#: include/pt-gpt-partnames.h:16
msgid "EFI System"
msgstr "Systém EFI"

#: include/pt-gpt-partnames.h:18
msgid "MBR partition scheme"
msgstr "Schéma oddílů MBR"

#: include/pt-gpt-partnames.h:19
msgid "Intel Fast Flash"
msgstr "Rychlá flash Intelu"

#: include/pt-gpt-partnames.h:22
msgid "BIOS boot"
msgstr "Startovací oddíl BIOSu"

#: include/pt-gpt-partnames.h:25
msgid "Sony boot partition"
msgstr "Startovací oddíl Sony"

#: include/pt-gpt-partnames.h:26
msgid "Lenovo boot partition"
msgstr "Startovací oddíl Lenova"

#: include/pt-gpt-partnames.h:29
msgid "PowerPC PReP boot"
msgstr "PowerPC PReP Boot"

#: include/pt-gpt-partnames.h:32
msgid "ONIE boot"
msgstr "Startovací oddíl ONIE"

#: include/pt-gpt-partnames.h:33
msgid "ONIE config"
msgstr "Konfigurační oddíl ONIE"

#: include/pt-gpt-partnames.h:36
msgid "Microsoft reserved"
msgstr "Vyhrazeno pro Microsoft"

#: include/pt-gpt-partnames.h:37
msgid "Microsoft basic data"
msgstr "Základní data Microsoftu"

#: include/pt-gpt-partnames.h:38
msgid "Microsoft LDM metadata"
msgstr "LDM metadata Microsoftu"

#: include/pt-gpt-partnames.h:39
msgid "Microsoft LDM data"
msgstr "LDM data Microsoftu"

#: include/pt-gpt-partnames.h:40
msgid "Windows recovery environment"
msgstr "Prostředí obnovy Windows"

#: include/pt-gpt-partnames.h:41
msgid "IBM General Parallel Fs"
msgstr "Obecný paralelní systém IBM"

# Proper name of LVM-like technology
#: include/pt-gpt-partnames.h:42
msgid "Microsoft Storage Spaces"
msgstr "Storage Spaces Microsoftu"

#: include/pt-gpt-partnames.h:45
msgid "HP-UX data"
msgstr "Data systému HP-UX"

#: include/pt-gpt-partnames.h:46
msgid "HP-UX service"
msgstr "Služba systému HP-UX"

#: include/pt-gpt-partnames.h:49 libfdisk/src/sgi.c:60 libfdisk/src/sun.c:51
msgid "Linux swap"
msgstr "Linux swap"

#: include/pt-gpt-partnames.h:50
msgid "Linux filesystem"
msgstr "Souborový systém Linuxu"

#: include/pt-gpt-partnames.h:51
msgid "Linux server data"
msgstr "Serverová data Linuxu"

#: include/pt-gpt-partnames.h:52
msgid "Linux root (x86)"
msgstr "Kořen Linuxu (x86)"

#: include/pt-gpt-partnames.h:53
msgid "Linux root (ARM)"
msgstr "Kořen Linuxu (ARM)"

#: include/pt-gpt-partnames.h:54
msgid "Linux root (x86-64)"
msgstr "Kořen Linuxu (x86-64)"

#: include/pt-gpt-partnames.h:55
msgid "Linux root (ARM-64)"
msgstr "Kořen Linuxu (ARM-64)"

# ??? Typo?
#: include/pt-gpt-partnames.h:56
#, fuzzy
msgid "Linux root (IA-64)"
msgstr "Kořen Linuxu (IA-64)"

#: include/pt-gpt-partnames.h:57
msgid "Linux reserved"
msgstr "Vyhrazeno Linuxu"

#: include/pt-gpt-partnames.h:58
msgid "Linux home"
msgstr "Domovské adresáře Linuxu"

#: include/pt-gpt-partnames.h:59 libfdisk/src/sgi.c:63
msgid "Linux RAID"
msgstr "Linux RAID"

#: include/pt-gpt-partnames.h:60 include/pt-mbr-partnames.h:61
#: libfdisk/src/sgi.c:62 libfdisk/src/sun.c:53
msgid "Linux LVM"
msgstr "Linux LVM"

#: include/pt-gpt-partnames.h:61
#, fuzzy
msgid "Linux variable data"
msgstr "Serverová data Linuxu"

#: include/pt-gpt-partnames.h:62
#, fuzzy
msgid "Linux temporary data"
msgstr "Serverová data Linuxu"

#: include/pt-gpt-partnames.h:63
#, fuzzy
msgid "Linux root verity (x86)"
msgstr "Kořen Linuxu (x86)"

#: include/pt-gpt-partnames.h:64
#, fuzzy
msgid "Linux root verity (ARM)"
msgstr "Kořen Linuxu (ARM)"

#: include/pt-gpt-partnames.h:65
#, fuzzy
msgid "Linux root verity (x86-64)"
msgstr "Kořen Linuxu (x86-64)"

#: include/pt-gpt-partnames.h:66
#, fuzzy
msgid "Linux root verity (ARM-64)"
msgstr "Kořen Linuxu (ARM-64)"

# ??? Typo?
#: include/pt-gpt-partnames.h:67
#, fuzzy
msgid "Linux root verity (IA-64)"
msgstr "Kořen Linuxu (IA-64)"

#: include/pt-gpt-partnames.h:73 include/pt-mbr-partnames.h:95
msgid "Linux extended boot"
msgstr "Linux rozšířený zaveditelný"

#: include/pt-gpt-partnames.h:76
msgid "FreeBSD data"
msgstr "Data FreeBSD"

#: include/pt-gpt-partnames.h:77
msgid "FreeBSD boot"
msgstr "Startovací oddíl FreeBSD"

#: include/pt-gpt-partnames.h:78
msgid "FreeBSD swap"
msgstr "Odkládací oddíl FreeBSD"

#: include/pt-gpt-partnames.h:79
msgid "FreeBSD UFS"
msgstr "UFS FreeBSD"

#: include/pt-gpt-partnames.h:80
msgid "FreeBSD ZFS"
msgstr "ZFS FreeBSD"

#: include/pt-gpt-partnames.h:81
msgid "FreeBSD Vinum"
msgstr "Vinum FreeBSD"

#: include/pt-gpt-partnames.h:84
msgid "Apple HFS/HFS+"
msgstr "HFS/HFS+ Applu"

#: include/pt-gpt-partnames.h:85
msgid "Apple APFS"
msgstr "APFS Applu"

#: include/pt-gpt-partnames.h:86
msgid "Apple UFS"
msgstr "UFS Applu"

#: include/pt-gpt-partnames.h:87
msgid "Apple RAID"
msgstr "RAID Applu"

#: include/pt-gpt-partnames.h:88
msgid "Apple RAID offline"
msgstr "Odpojený RAID Applu"

#: include/pt-gpt-partnames.h:89
msgid "Apple boot"
msgstr "Startovací oddíl Applu"

#: include/pt-gpt-partnames.h:90
msgid "Apple label"
msgstr "Popis Applu"

#: include/pt-gpt-partnames.h:91
msgid "Apple TV recovery"
msgstr "Obnova televize Applu"

#: include/pt-gpt-partnames.h:92
msgid "Apple Core storage"
msgstr "Úložiště jádra Applu"

#: include/pt-gpt-partnames.h:95 include/pt-mbr-partnames.h:77
msgid "Solaris boot"
msgstr "Zavaděč Solarisu"

#: include/pt-gpt-partnames.h:96
msgid "Solaris root"
msgstr "Kořenový systém Solarisu"

#: include/pt-gpt-partnames.h:98
msgid "Solaris /usr & Apple ZFS"
msgstr "/usr Solarisu a ZFS Applu"

#: include/pt-gpt-partnames.h:99
msgid "Solaris swap"
msgstr "Odkládací oddíl Solarisu"

#: include/pt-gpt-partnames.h:100
msgid "Solaris backup"
msgstr "Záloha Solarisu"

#: include/pt-gpt-partnames.h:101
msgid "Solaris /var"
msgstr "/var Solarisu"

#: include/pt-gpt-partnames.h:102
msgid "Solaris /home"
msgstr "/home Solarisu"

#: include/pt-gpt-partnames.h:103
msgid "Solaris alternate sector"
msgstr "Náhradní sektor Solarisu"

#: include/pt-gpt-partnames.h:104
msgid "Solaris reserved 1"
msgstr "Vyhrazeno pro Solaris (1)"

#: include/pt-gpt-partnames.h:105
msgid "Solaris reserved 2"
msgstr "Vyhrazeno pro Solaris (2)"

#: include/pt-gpt-partnames.h:106
msgid "Solaris reserved 3"
msgstr "Vyhrazeno pro Solaris (3)"

#: include/pt-gpt-partnames.h:107
msgid "Solaris reserved 4"
msgstr "Vyhrazeno pro Solaris (4)"

#: include/pt-gpt-partnames.h:108
msgid "Solaris reserved 5"
msgstr "Vyhrazeno pro Solaris (5)"

#: include/pt-gpt-partnames.h:111
msgid "NetBSD swap"
msgstr "Odkládací oddíl NetBSD"

#: include/pt-gpt-partnames.h:112
msgid "NetBSD FFS"
msgstr "FFS NetBSD"

#: include/pt-gpt-partnames.h:113
msgid "NetBSD LFS"
msgstr "LFS NetBSD"

#: include/pt-gpt-partnames.h:114
msgid "NetBSD concatenated"
msgstr "Zřetězené NetBSD"

#: include/pt-gpt-partnames.h:115
msgid "NetBSD encrypted"
msgstr "Šifrované NetBSD"

#: include/pt-gpt-partnames.h:116
msgid "NetBSD RAID"
msgstr "RAID NetBSD"

#: include/pt-gpt-partnames.h:119
msgid "ChromeOS kernel"
msgstr "Jádro ChromeOS"

#: include/pt-gpt-partnames.h:120
msgid "ChromeOS root fs"
msgstr "Kořenový systém ChromeOS"

#: include/pt-gpt-partnames.h:121
msgid "ChromeOS reserved"
msgstr "Vyhrazeno pro ChromeOS"

#: include/pt-gpt-partnames.h:124
msgid "MidnightBSD data"
msgstr "Data MidnightBSD"

#: include/pt-gpt-partnames.h:125
msgid "MidnightBSD boot"
msgstr "Startovací oddíl MidnightBSD"

#: include/pt-gpt-partnames.h:126
msgid "MidnightBSD swap"
msgstr "Odkládací oddíl MidnightBSD"

#: include/pt-gpt-partnames.h:127
msgid "MidnightBSD UFS"
msgstr "UFS MidnightBSD"

#: include/pt-gpt-partnames.h:128
msgid "MidnightBSD ZFS"
msgstr "ZFS MidnightBSD"

#: include/pt-gpt-partnames.h:129
msgid "MidnightBSD Vinum"
msgstr "Vinum MidnightBSD"

#: include/pt-gpt-partnames.h:132
msgid "Ceph Journal"
msgstr "Žurnál Cephu"

#: include/pt-gpt-partnames.h:133
msgid "Ceph Encrypted Journal"
msgstr "Šifrovaný žurnál Cephu"

#: include/pt-gpt-partnames.h:134
msgid "Ceph OSD"
msgstr "OSD Cephu"

#: include/pt-gpt-partnames.h:135
msgid "Ceph crypt OSD"
msgstr "Šifrovaný OSD Cephu"

#: include/pt-gpt-partnames.h:136
msgid "Ceph disk in creation"
msgstr "Vytváří se cephový disk"

#: include/pt-gpt-partnames.h:137
msgid "Ceph crypt disk in creation"
msgstr "Vytváří se šifrovaný cephový disk"

#: include/pt-gpt-partnames.h:140 include/pt-mbr-partnames.h:104
msgid "VMware VMFS"
msgstr "VMware VMFS"

#: include/pt-gpt-partnames.h:141
msgid "VMware Diagnostic"
msgstr "Diagnostika VMware"

#: include/pt-gpt-partnames.h:142
msgid "VMware Virtual SAN"
msgstr "Virtuální SAN VMware"

#: include/pt-gpt-partnames.h:143
msgid "VMware Virsto"
msgstr "VMware Virsto"

#: include/pt-gpt-partnames.h:144
msgid "VMware Reserved"
msgstr "Vyhrazeno pro VMware"

#: include/pt-gpt-partnames.h:147
msgid "OpenBSD data"
msgstr "Data OpenBSD"

#: include/pt-gpt-partnames.h:150
msgid "QNX6 file system"
msgstr "Souborový systém QNX6"

#: include/pt-gpt-partnames.h:153
msgid "Plan 9 partition"
msgstr "Oddíl Plan 9"

#: include/pt-gpt-partnames.h:156
msgid "HiFive Unleashed FSBL"
msgstr "FSBL HiFive Unleashed"

#: include/pt-gpt-partnames.h:157
msgid "HiFive Unleashed BBL"
msgstr "BBL HiFive Unleashed"

#: include/pt-mbr-partnames.h:1
msgid "Empty"
msgstr "Prázdný prostor"

#: include/pt-mbr-partnames.h:2
msgid "FAT12"
msgstr "FAT12"

#: include/pt-mbr-partnames.h:3
msgid "XENIX root"
msgstr "XENIX root"

#: include/pt-mbr-partnames.h:4
msgid "XENIX usr"
msgstr "XENIX usr"

#: include/pt-mbr-partnames.h:5
msgid "FAT16 <32M"
msgstr "FAT16 <32M"

#: include/pt-mbr-partnames.h:6
msgid "Extended"
msgstr "Rozšířený"

#: include/pt-mbr-partnames.h:7
msgid "FAT16"
msgstr "FAT16"

#: include/pt-mbr-partnames.h:8
msgid "HPFS/NTFS/exFAT"
msgstr "HPFS/NTFS/exFAT"

#: include/pt-mbr-partnames.h:9
msgid "AIX"
msgstr "AIX"

#: include/pt-mbr-partnames.h:10
msgid "AIX bootable"
msgstr "AIX startovací"

#: include/pt-mbr-partnames.h:11
msgid "OS/2 Boot Manager"
msgstr "OS/2 zavaděč"

#: include/pt-mbr-partnames.h:12
msgid "W95 FAT32"
msgstr "W95 FAT32"

#: include/pt-mbr-partnames.h:13
msgid "W95 FAT32 (LBA)"
msgstr "W95 FAT32 (LBA)"

#: include/pt-mbr-partnames.h:14
msgid "W95 FAT16 (LBA)"
msgstr "W95 FAT16 (LBA)"

#: include/pt-mbr-partnames.h:15
msgid "W95 Ext'd (LBA)"
msgstr "W95 Rozš. (LBA)"

#: include/pt-mbr-partnames.h:16
msgid "OPUS"
msgstr "OPUS"

#: include/pt-mbr-partnames.h:17
msgid "Hidden FAT12"
msgstr "Skrytá FAT12"

#: include/pt-mbr-partnames.h:18
msgid "Compaq diagnostics"
msgstr "Compaq diagnostics"

#: include/pt-mbr-partnames.h:19
msgid "Hidden FAT16 <32M"
msgstr "Skrytá FAT16 <32M"

#: include/pt-mbr-partnames.h:20
msgid "Hidden FAT16"
msgstr "Skrytá FAT16"

#: include/pt-mbr-partnames.h:21
msgid "Hidden HPFS/NTFS"
msgstr "Skrytá HPFS/NTFS"

#: include/pt-mbr-partnames.h:22
msgid "AST SmartSleep"
msgstr "AST SmartSleep"

#: include/pt-mbr-partnames.h:23
msgid "Hidden W95 FAT32"
msgstr "Skrytá W95 FAT32"

#: include/pt-mbr-partnames.h:24
msgid "Hidden W95 FAT32 (LBA)"
msgstr "Skrytá W95 FAT32 (LBA)"

#: include/pt-mbr-partnames.h:25
msgid "Hidden W95 FAT16 (LBA)"
msgstr "Skrytá W95 FAT16 (LBA)"

#: include/pt-mbr-partnames.h:26
msgid "NEC DOS"
msgstr "NEC DOS"

#: include/pt-mbr-partnames.h:27
msgid "Hidden NTFS WinRE"
msgstr "Skrytá NTFS WinRE"

#: include/pt-mbr-partnames.h:28
msgid "Plan 9"
msgstr "Plan 9"

#: include/pt-mbr-partnames.h:29
msgid "PartitionMagic recovery"
msgstr "PartitionMagic recovery"

#: include/pt-mbr-partnames.h:30
msgid "Venix 80286"
msgstr "Venix 80286"

#: include/pt-mbr-partnames.h:31
msgid "PPC PReP Boot"
msgstr "PPC PReP Boot"

#: include/pt-mbr-partnames.h:32
msgid "SFS"
msgstr "SFS"

#: include/pt-mbr-partnames.h:33
msgid "QNX4.x"
msgstr "QNX4.x"

#: include/pt-mbr-partnames.h:34
msgid "QNX4.x 2nd part"
msgstr "QNX4.x 2. část"

#: include/pt-mbr-partnames.h:35
msgid "QNX4.x 3rd part"
msgstr "QNX4.x 3. část"

#: include/pt-mbr-partnames.h:36
msgid "OnTrack DM"
msgstr "OnTrack DM"

#: include/pt-mbr-partnames.h:37
msgid "OnTrack DM6 Aux1"
msgstr "OnTrack DM6 Aux1"

#: include/pt-mbr-partnames.h:38
msgid "CP/M"
msgstr "CP/M"

#: include/pt-mbr-partnames.h:39
msgid "OnTrack DM6 Aux3"
msgstr "OnTrack DM6 Aux3"

#: include/pt-mbr-partnames.h:40
msgid "OnTrackDM6"
msgstr "OnTrackDM6"

#: include/pt-mbr-partnames.h:41
msgid "EZ-Drive"
msgstr "EZ-Drive"

#: include/pt-mbr-partnames.h:42
msgid "Golden Bow"
msgstr "Golden Bow"

#: include/pt-mbr-partnames.h:43
msgid "Priam Edisk"
msgstr "Priam Edisk"

#: include/pt-mbr-partnames.h:44 include/pt-mbr-partnames.h:91
#: include/pt-mbr-partnames.h:101 include/pt-mbr-partnames.h:102
msgid "SpeedStor"
msgstr "SpeedStor"

#: include/pt-mbr-partnames.h:45
msgid "GNU HURD or SysV"
msgstr "GNU HURD či SysV"

#: include/pt-mbr-partnames.h:46
msgid "Novell Netware 286"
msgstr "Novell NetWare 286"

#: include/pt-mbr-partnames.h:47
msgid "Novell Netware 386"
msgstr "Novell NetWare 386"

#: include/pt-mbr-partnames.h:48
msgid "DiskSecure Multi-Boot"
msgstr "DiskSecure Multi-Boot"

#: include/pt-mbr-partnames.h:49
msgid "PC/IX"
msgstr "PC/IX"

#: include/pt-mbr-partnames.h:50
msgid "Old Minix"
msgstr "Starý Minix"

#: include/pt-mbr-partnames.h:51
msgid "Minix / old Linux"
msgstr "Minix / starý Linux"

#: include/pt-mbr-partnames.h:52
msgid "Linux swap / Solaris"
msgstr "Linux swap/Solaris"

#: include/pt-mbr-partnames.h:53
msgid "Linux"
msgstr "Linux"

#: include/pt-mbr-partnames.h:54
msgid "OS/2 hidden or Intel hibernation"
msgstr "Skrytý OS/2 nebo hibernace Intelu"

#: include/pt-mbr-partnames.h:57
msgid "Linux extended"
msgstr "Linux rozšířený"

#: include/pt-mbr-partnames.h:58 include/pt-mbr-partnames.h:59
msgid "NTFS volume set"
msgstr "NTFS svazek"

#: include/pt-mbr-partnames.h:60
msgid "Linux plaintext"
msgstr "Linux plaintext"

#: include/pt-mbr-partnames.h:62
msgid "Amoeba"
msgstr "Amoeba"

#: include/pt-mbr-partnames.h:63
msgid "Amoeba BBT"
msgstr "Amoeba BBT"

#: include/pt-mbr-partnames.h:64
msgid "BSD/OS"
msgstr "BSD/OS"

#: include/pt-mbr-partnames.h:65
msgid "IBM Thinkpad hibernation"
msgstr "IBM Thinkpad hibernace"

#: include/pt-mbr-partnames.h:66
msgid "FreeBSD"
msgstr "FreeBSD"

#: include/pt-mbr-partnames.h:67
msgid "OpenBSD"
msgstr "OpenBSD"

#: include/pt-mbr-partnames.h:68
msgid "NeXTSTEP"
msgstr "NeXTSTEP"

#: include/pt-mbr-partnames.h:69
msgid "Darwin UFS"
msgstr "Darwin UFS"

#: include/pt-mbr-partnames.h:70
msgid "NetBSD"
msgstr "NetBSD"

#: include/pt-mbr-partnames.h:71
msgid "Darwin boot"
msgstr "Darwin zaveditelný"

#: include/pt-mbr-partnames.h:72
msgid "HFS / HFS+"
msgstr "HFS/HFS+"

#: include/pt-mbr-partnames.h:73
msgid "BSDI fs"
msgstr "BSDI SS"

#: include/pt-mbr-partnames.h:74
msgid "BSDI swap"
msgstr "BSDI swap"

#: include/pt-mbr-partnames.h:75
msgid "Boot Wizard hidden"
msgstr "Skrytý Boot Wizard"

#: include/pt-mbr-partnames.h:76
msgid "Acronis FAT32 LBA"
msgstr "Acronis FAT32 (LBA)"

#: include/pt-mbr-partnames.h:78
msgid "Solaris"
msgstr "Solaris"

#: include/pt-mbr-partnames.h:79
msgid "DRDOS/sec (FAT-12)"
msgstr "DRDOS/sec (FAT-12)"

#: include/pt-mbr-partnames.h:80
msgid "DRDOS/sec (FAT-16 < 32M)"
msgstr "DRDOS/sec (FAT-16 < 32M)"

#: include/pt-mbr-partnames.h:81
msgid "DRDOS/sec (FAT-16)"
msgstr "DRDOS/sec (FAT-16)"

#: include/pt-mbr-partnames.h:82
msgid "Syrinx"
msgstr "Syrinx"

#: include/pt-mbr-partnames.h:83
msgid "Non-FS data"
msgstr "data mimo SS"

#: include/pt-mbr-partnames.h:84
msgid "CP/M / CTOS / ..."
msgstr "CP/M / CTOS / …"

#: include/pt-mbr-partnames.h:86
msgid "Dell Utility"
msgstr "Dell Utility"

#: include/pt-mbr-partnames.h:87
msgid "BootIt"
msgstr "BootIt"

#: include/pt-mbr-partnames.h:88
msgid "DOS access"
msgstr "DOS access"

#: include/pt-mbr-partnames.h:90
msgid "DOS R/O"
msgstr "DOS pro čtení"

#: include/pt-mbr-partnames.h:97
msgid "BeOS fs"
msgstr "BeOS SS"

#: include/pt-mbr-partnames.h:99
msgid "EFI (FAT-12/16/32)"
msgstr "EFI (FAT-12/16/32)"

#: include/pt-mbr-partnames.h:100
msgid "Linux/PA-RISC boot"
msgstr "zavaděč Linux/PA-RISCu"

#: include/pt-mbr-partnames.h:103
msgid "DOS secondary"
msgstr "DOS sekundární"

#: include/pt-mbr-partnames.h:105
msgid "VMware VMKCORE"
msgstr "VMware VMKCORE"

#: include/pt-mbr-partnames.h:106 libfdisk/src/sun.c:54
msgid "Linux raid autodetect"
msgstr "Linux RAID samorozpoznatelný"

#: include/pt-mbr-partnames.h:109
msgid "LANstep"
msgstr "LANstep"

#: include/pt-mbr-partnames.h:110
msgid "BBT"
msgstr "BBT"

#: lib/blkdev.c:274
#, c-format
msgid "warning: %s is misaligned"
msgstr "pozor: %s není správně zarovnáno"

#: lib/blkdev.c:386
#, fuzzy, c-format
msgid "unsupported lock mode: %s"
msgstr "nepodporovaný režim barev"

#: lib/blkdev.c:396
#, c-format
msgid "%s: %s: device already locked, waiting to get lock ... "
msgstr ""

#: lib/blkdev.c:405
#, fuzzy, c-format
msgid "%s: device already locked"
msgstr "%s je již připojeno"

#: lib/blkdev.c:408
#, fuzzy, c-format
msgid "%s: failed to get lock"
msgstr "zámek se nepodařilo získat"

#: lib/blkdev.c:411
#, fuzzy, c-format
msgid "OK\n"
msgstr "OK"

#: libfdisk/src/ask.c:505 libfdisk/src/ask.c:517
#, c-format
msgid "Selected partition %ju"
msgstr "Vybrán oddíl %ju"

#: libfdisk/src/ask.c:508
msgid "No partition is defined yet!"
msgstr "Ještě nejsou definovány žádné oddíly!"

#: libfdisk/src/ask.c:520
msgid "No free partition available!"
msgstr "Nejsou žádné volné sektory!"

#: libfdisk/src/ask.c:530
msgid "Partition number"
msgstr "Číslo oddílu"

#: libfdisk/src/ask.c:1027
#, c-format
msgid "Created a new partition %d of type '%s' and of size %s."
msgstr "Vytvořen nový oddíl %d typu „%s“ o velikosti %s."

#: libfdisk/src/bsd.c:165
#, c-format
msgid "Partition %zd: has invalid starting sector 0."
msgstr "Diskový oddíl %zd má chybný počáteční sektor 0."

#: libfdisk/src/bsd.c:180
#, c-format
msgid "There is no *BSD partition on %s."
msgstr "Na %s se nenachází žádný *BSD oddíl."

#: libfdisk/src/bsd.c:258 libfdisk/src/dos.c:968
msgid "First cylinder"
msgstr "První cylindr"

#: libfdisk/src/bsd.c:291 libfdisk/src/dos.c:1353
msgid "Last cylinder, +/-cylinders or +/-size{K,M,G,T,P}"
msgstr "Poslední cylindr, +/-cylindrů nebo +/-velikost{K,M,G,T,P}"

#: libfdisk/src/bsd.c:296 libfdisk/src/dos.c:1358 libfdisk/src/gpt.c:2449
msgid "Last sector, +/-sectors or +/-size{K,M,G,T,P}"
msgstr "Poslední sektor, +/-sektorů nebo +/-velikost{K,M,G,T,P}"

#: libfdisk/src/bsd.c:381
#, c-format
msgid "The device %s does not contain BSD disklabel."
msgstr "Zařízení %s neobsahuje žádný BSD popis disku."

#: libfdisk/src/bsd.c:383
msgid "Do you want to create a BSD disklabel?"
msgstr "Chcete vytvořit BSD popis disku?"

#: libfdisk/src/bsd.c:449
msgid "Disk"
msgstr "Disk"

# packname is bsddiskname
#: libfdisk/src/bsd.c:456
msgid "Packname"
msgstr "Název svazku"

#: libfdisk/src/bsd.c:463 libfdisk/src/sun.c:1137
msgid "Flags"
msgstr "Příznaky"

#: libfdisk/src/bsd.c:466
msgid " removable"
msgstr " výměnný"

# ???
#: libfdisk/src/bsd.c:467
msgid " ecc"
msgstr " ecc"

#: libfdisk/src/bsd.c:468
msgid " badsect"
msgstr " chybnýsekt"

#: libfdisk/src/bsd.c:476
msgid "Bytes/Sector"
msgstr "Bajtů/sektor"

#: libfdisk/src/bsd.c:481
msgid "Tracks/Cylinder"
msgstr "Stop/cylindr"

#: libfdisk/src/bsd.c:486
msgid "Sectors/Cylinder"
msgstr "Sektorů/cylindr"

#: libfdisk/src/bsd.c:491 libfdisk/src/bsd.c:1029 libfdisk/src/dos.c:2603
#: libfdisk/src/sgi.c:1161 libfdisk/src/sun.c:203 libfdisk/src/sun.c:1133
msgid "Cylinders"
msgstr "Cylindry"

#: libfdisk/src/bsd.c:496 libfdisk/src/sun.c:783
msgid "Rpm"
msgstr "o/m"

#: libfdisk/src/bsd.c:501 libfdisk/src/sgi.c:291 libfdisk/src/sun.c:803
msgid "Interleave"
msgstr "Prokládání"

#: libfdisk/src/bsd.c:506
msgid "Trackskew"
msgstr "Zakřivení stopy"

#: libfdisk/src/bsd.c:511
msgid "Cylinderskew"
msgstr "Zakřivení cylindru"

#: libfdisk/src/bsd.c:516
msgid "Headswitch"
msgstr "Přesun hlavy"

#: libfdisk/src/bsd.c:521
msgid "Track-to-track seek"
msgstr "Posun stopa-stopa"

#: libfdisk/src/bsd.c:611
msgid "bytes/sector"
msgstr "bajtů/sektor"

#: libfdisk/src/bsd.c:614
msgid "sectors/track"
msgstr "sektorů/stopu"

#: libfdisk/src/bsd.c:615
msgid "tracks/cylinder"
msgstr "stop/cylindr"

#: libfdisk/src/bsd.c:616
msgid "cylinders"
msgstr "cylindry"

#: libfdisk/src/bsd.c:621
msgid "sectors/cylinder"
msgstr "sektorů/cylindr"

#: libfdisk/src/bsd.c:624
msgid "rpm"
msgstr "o/m"

#: libfdisk/src/bsd.c:625
msgid "interleave"
msgstr "prokládání"

#: libfdisk/src/bsd.c:626
msgid "trackskew"
msgstr "zakřivení stopy"

#: libfdisk/src/bsd.c:627
msgid "cylinderskew"
msgstr "zakřivení cylindru"

#: libfdisk/src/bsd.c:629
msgid "headswitch"
msgstr "přesun hlavy"

#: libfdisk/src/bsd.c:630
msgid "track-to-track seek"
msgstr "posun stopa-stopa"

#: libfdisk/src/bsd.c:652
#, c-format
msgid "The bootstrap file %s successfully loaded."
msgstr "Soubor se zavaděčem %s byl úspěšně načten."

#: libfdisk/src/bsd.c:674
#, c-format
msgid "Bootstrap: %1$sboot -> boot%1$s (default %1$s)"
msgstr "Zavaděč: %1$sstart -> start%1$s (výchozí %1$s)"

#: libfdisk/src/bsd.c:705
msgid "Bootstrap overlaps with disklabel!"
msgstr "Zavaděč přesahuje do tabulky rozdělení disku!"

#: libfdisk/src/bsd.c:729
#, c-format
msgid "Bootstrap installed on %s."
msgstr "Zavaděč instalován na %s."

#: libfdisk/src/bsd.c:911
#, c-format
msgid "Disklabel written to %s.  (Don't forget to write the %s disklabel too.)"
msgstr "Popis disku zaps8n do %s. (Nezapomeňte zapsat také popis disku %s.)"

#: libfdisk/src/bsd.c:914
#, c-format
msgid "Disklabel written to %s."
msgstr "Popis disku zapsán do %s."

#: libfdisk/src/bsd.c:920 libfdisk/src/context.c:753
msgid "Syncing disks."
msgstr "Synchronizují se disky."

#: libfdisk/src/bsd.c:961
msgid "BSD label is not nested within a DOS partition."
msgstr "BSD popis disku není zanořen do dosového oddílu."

#: libfdisk/src/bsd.c:989
#, c-format
msgid "BSD partition '%c' linked to DOS partition %zu."
msgstr "BSD oddíl „%c“ propojen na dosový oddíl %zu."

#: libfdisk/src/bsd.c:1025
msgid "Slice"
msgstr "Slice"

# http://people.freebsd.org/~meganm/data/FAQ/FAQ40.html#fsize
#: libfdisk/src/bsd.c:1032
msgid "Fsize"
msgstr "Fragment"

# http://people.freebsd.org/~meganm/data/FAQ/FAQ40.html#bsize
#: libfdisk/src/bsd.c:1033
msgid "Bsize"
msgstr "Blok"

# Cylinders per group
#: libfdisk/src/bsd.c:1034
msgid "Cpg"
msgstr "C/S"

#: libfdisk/src/context.c:743
#, c-format
msgid "%s: fsync device failed"
msgstr "%s: synchronizace zařízení selhala"

#: libfdisk/src/context.c:748
#, c-format
msgid "%s: close device failed"
msgstr "%s: uzavření zařízení selhalo"

#: libfdisk/src/context.c:828
msgid "Calling ioctl() to re-read partition table."
msgstr "Volám ioctl() pro znovunačtení tabulky rozdělení disku."

#: libfdisk/src/context.c:836
msgid "Re-reading the partition table failed."
msgstr "Opětovné načtení tabulky rozdělení disku selhalo."

#: libfdisk/src/context.c:838
msgid "The kernel still uses the old table. The new table will be used at the next reboot or after you run partprobe(8) or partx(8)."
msgstr "Jádro stále používá starou tabulku. Nová tabulka se použije až po příštím restartu nebo po té, co spustíte partprobe(8) nebo partx(8)."

#: libfdisk/src/context.c:928
#, c-format
msgid "Failed to remove partition %zu from system"
msgstr "Ze systému se nepodařilo odstranit oddíl %zu"

#: libfdisk/src/context.c:937
#, c-format
msgid "Failed to update system information about partition %zu"
msgstr "Systémové údaje o oddílu %zu se nepodařilo zaktualizovat"

#: libfdisk/src/context.c:946
#, c-format
msgid "Failed to add partition %zu to system"
msgstr "Do systému se nepodařilo přidat oddíl %zu"

#: libfdisk/src/context.c:952
msgid "The kernel still uses the old partitions. The new table will be used at the next reboot. "
msgstr "Jádro stále používá staré oddíly. Nová tabulka se použije až po příštím restartu. "

#: libfdisk/src/context.c:1163
msgid "cylinder"
msgid_plural "cylinders"
msgstr[0] "cylindr"
msgstr[1] "cylindry"
msgstr[2] "cylindrů"

#: libfdisk/src/context.c:1164
msgid "sector"
msgid_plural "sectors"
msgstr[0] "sektor"
msgstr[1] "sektory"
msgstr[2] "sektorů"

#: libfdisk/src/context.c:1520
msgid "Incomplete geometry setting."
msgstr "Neúplné nastavení geometrie."

#: libfdisk/src/dos.c:225
msgid "All primary partitions have been defined already."
msgstr "Již jsou definovány všechny primární oddíly."

#: libfdisk/src/dos.c:228
msgid "Primary partition not available."
msgstr "Žádný primární oddíl není dostupný."

#: libfdisk/src/dos.c:282
#, c-format
msgid "Failed to read extended partition table (offset=%ju)"
msgstr "Rozšířenou tabulku rozdělení disku se nepodařilo načíst (pozice=%ju)"

#: libfdisk/src/dos.c:352
msgid "You can set geometry from the extra functions menu."
msgstr "Geometrii můžete nastavit z nabídky rozšiřujících funkcí."

#: libfdisk/src/dos.c:355
msgid "DOS-compatible mode is deprecated."
msgstr "Režim kompatibility s DOSem je zastaralý."

#: libfdisk/src/dos.c:359
msgid "The device presents a logical sector size that is smaller than the physical sector size. Aligning to a physical sector (or optimal I/O) size boundary is recommended, or performance may be impacted."
msgstr "Zařízení uvádí, že velikost logického sektoru je menší než velikost sektoru fyzického. Doporučuje se dodržet zarovnání na hranice fyzických sektorů (nebo bloků optimálních pro I/O). V opačném případě může utrpět výkon."

#: libfdisk/src/dos.c:365
msgid "Cylinders as display units are deprecated."
msgstr "Zobrazování hodnot v cylindrech vyšlo z módy."

#: libfdisk/src/dos.c:372
#, c-format
msgid "The size of this disk is %s (%ju bytes). DOS partition table format cannot be used on drives for volumes larger than %lu bytes for %lu-byte sectors. Use GUID partition table format (GPT)."
msgstr "Velikost tohoto disku je %s (%'ju bajtů). Tabulka rozdělení disku typu DOS nemůže být použita na jednotkách svazků větších než %'lu bajtů při %lubajtových sektorech. Použijte tabulku rozdělení disku typu GUID (GPT)."

#: libfdisk/src/dos.c:546
msgid "Bad offset in primary extended partition."
msgstr "Chybný posun v primárním rozšířeném oddílu."

#: libfdisk/src/dos.c:560
#, c-format
msgid "Omitting partitions after #%zu. They will be deleted if you save this partition table."
msgstr "Oddíly po čísle %zu budou vynechány. Pokud tuto tabulku rozdělení disku uložíte, budou ztraceny."

#: libfdisk/src/dos.c:593
#, c-format
msgid "Extra link pointer in partition table %zu."
msgstr "Nadbytečný ukazatel na odkaz v tabulce rozdělení disku %zu."

#: libfdisk/src/dos.c:601
#, c-format
msgid "Ignoring extra data in partition table %zu."
msgstr "Nadbytečná data v tabulce rozdělení disku %zu ignorována."

#: libfdisk/src/dos.c:657
#, c-format
msgid "omitting empty partition (%zu)"
msgstr "vynechávám prázdný oddíl (%zu)"

#: libfdisk/src/dos.c:717
#, c-format
msgid "Created a new DOS disklabel with disk identifier 0x%08x."
msgstr "Vytvořena nová dosová tabulka rozdělení disku s identifikátorem 0x%08x."

#: libfdisk/src/dos.c:740
msgid "Enter the new disk identifier"
msgstr "Zadejte nový identifikátor disku"

#: libfdisk/src/dos.c:749
msgid "Incorrect value."
msgstr "Nesprávná hodnota."

#: libfdisk/src/dos.c:762
#, c-format
msgid "Disk identifier changed from 0x%08x to 0x%08x."
msgstr "Identifikátor disku změněn z 0x%08x na 0x%08x."

#: libfdisk/src/dos.c:864
#, c-format
msgid "Ignoring extra extended partition %zu"
msgstr "Nadbytečný rozšířený oddíl %zu ignorován"

#: libfdisk/src/dos.c:878
#, c-format
msgid "Invalid flag 0x%02x%02x of EBR (for partition %zu) will be corrected by w(rite)."
msgstr "Chybný příznak 0x%02x%02x EBR (pro oddíl %zu) bude opraven zápisem(w)."

#: libfdisk/src/dos.c:955
#, c-format
msgid "Start sector %ju out of range."
msgstr "Začáteční sektoru%ju je mimo meze."

#: libfdisk/src/dos.c:1194 libfdisk/src/gpt.c:2323 libfdisk/src/sgi.c:842
#: libfdisk/src/sun.c:528
#, c-format
msgid "Partition %zu is already defined.  Delete it before re-adding it."
msgstr "Oddíl %zu je již definován. Před opětovným vytvořením jej musíte nejprve smazat."

#: libfdisk/src/dos.c:1209 libfdisk/src/dos.c:1235 libfdisk/src/dos.c:1292
#: libfdisk/src/dos.c:1324 libfdisk/src/gpt.c:2332
msgid "No free sectors available."
msgstr "Nejsou žádné volné sektory."

#: libfdisk/src/dos.c:1260
#, c-format
msgid "Sector %llu is already allocated."
msgstr "Sektor %llu je již alokován."

#: libfdisk/src/dos.c:1479
#, c-format
msgid "Adding logical partition %zu"
msgstr "Přidává se logický oddíl %zu"

#: libfdisk/src/dos.c:1510
#, c-format
msgid "Partition %zu: contains sector 0"
msgstr "Oddíl %zu: obsahuje sektor 0"

#: libfdisk/src/dos.c:1512
#, c-format
msgid "Partition %zu: head %d greater than maximum %d"
msgstr "Oddíl %zu: hlava %d má větší číslo než je maximum %d"

#: libfdisk/src/dos.c:1515
#, c-format
msgid "Partition %zu: sector %d greater than maximum %llu"
msgstr "Oddíl %zu: sektor %d má větší číslo než je maximum %llu"

#: libfdisk/src/dos.c:1518
#, c-format
msgid "Partition %zu: cylinder %d greater than maximum %llu"
msgstr "Oddíl %zu: cylindr %d má větší číslo než je maximum %llu"

#: libfdisk/src/dos.c:1524
#, c-format
msgid "Partition %zu: previous sectors %u disagrees with total %u"
msgstr "Oddíl %zu: předchozí sektory %u nesouhlasí s úhrnem %u"

#: libfdisk/src/dos.c:1577
#, c-format
msgid "Partition %zu: different physical/logical beginnings (non-Linux?): phys=(%d, %d, %d), logical=(%d, %d, %d)"
msgstr "Oddíl %zu: rozdílný fyzický a logický začátek (nelinuxový?): fyzický=(%d, %d, %d), logický=(%d, %d, %d)"

#: libfdisk/src/dos.c:1588
#, c-format
msgid "Partition %zu: different physical/logical endings: phys=(%d, %d, %d), logical=(%d, %d, %d)"
msgstr "Oddíl %zu: rozdílný fyzický a logický konec: fyzický=(%d, %d, %d), logický=(%d, %d, %d)"

#: libfdisk/src/dos.c:1597
#, c-format
msgid "Partition %zu: does not end on cylinder boundary."
msgstr "Oddíl %zu: nekončí na hranici cylindru."

#: libfdisk/src/dos.c:1645
#, c-format
msgid "Partition %zu: bad start-of-data."
msgstr "Oddíl %zu: chybný počátek dat."

#: libfdisk/src/dos.c:1660
#, c-format
msgid "Partition %zu: overlaps partition %zu."
msgstr "Oddíl %zu: přesahuje do oddílu %zu."

#: libfdisk/src/dos.c:1689
#, c-format
msgid "Partition %zu: empty."
msgstr "Oddíl %zu: je prázdný."

#: libfdisk/src/dos.c:1696
#, c-format
msgid "Logical partition %zu: not entirely in partition %zu."
msgstr "Logický oddíl %zu: zasahuje mimo oddíl %zu."

#: libfdisk/src/dos.c:1705 libfdisk/src/gpt.c:2229
msgid "No errors detected."
msgstr "Žádné chyby neobjeveny."

#: libfdisk/src/dos.c:1707
#, c-format
msgid "Total allocated sectors %llu greater than the maximum %llu."
msgstr "Celkový počet alokovaných sektorů %'llu je větší než maximum %'llu."

#: libfdisk/src/dos.c:1710
#, c-format
msgid "Remaining %lld unallocated %ld-byte sectors."
msgstr "Zbývá %'lld nealokovaných %ldbajtových sektorů."

#: libfdisk/src/dos.c:1714 libfdisk/src/gpt.c:2249
#, c-format
msgid "%d error detected."
msgid_plural "%d errors detected."
msgstr[0] "Objevena %d chyba."
msgstr[1] "Objeveny %d chyby."
msgstr[2] "Objeveno %d chyb."

#: libfdisk/src/dos.c:1747
msgid "The maximum number of partitions has been created."
msgstr "Již je vytvořeno maximální množství oddílů."

#: libfdisk/src/dos.c:1780 libfdisk/src/dos.c:1795 libfdisk/src/dos.c:2238
msgid "Extended partition already exists."
msgstr "Rozšířený oddíl již existuje."

#: libfdisk/src/dos.c:1810
msgid "Extended partition does not exists. Failed to add logical partition."
msgstr "Rozšířený oddíl neexistuje. Přidání logického oddílu selhalo."

#: libfdisk/src/dos.c:1862
msgid "All primary partitions are in use."
msgstr "Všechny primární oddíly jsou obsazeny."

#: libfdisk/src/dos.c:1864 libfdisk/src/dos.c:1875
msgid "All space for primary partitions is in use."
msgstr "Veškerý prostor for primární oddíly je již použit."

#. TRANSLATORS: Try to keep this within 80 characters.
#: libfdisk/src/dos.c:1878
msgid "To create more partitions, first replace a primary with an extended partition."
msgstr "Chcete-li více oddílů, nejprve nahraďte primární oddíl oddílem rozšířeným."

#: libfdisk/src/dos.c:1899
msgid "Partition type"
msgstr "Typ oddílu"

# ??? Pluralize?
#: libfdisk/src/dos.c:1903
#, c-format
msgid "%u primary, %d extended, %u free"
msgstr "%u primární, %d rozšířený, %u volný"

#: libfdisk/src/dos.c:1908
msgid "primary"
msgstr "primární"

#: libfdisk/src/dos.c:1910
msgid "extended"
msgstr "rozšířený"

#: libfdisk/src/dos.c:1910
msgid "container for logical partitions"
msgstr "kontejner pro logické oddíly"

#: libfdisk/src/dos.c:1912
msgid "logical"
msgstr "logický"

#: libfdisk/src/dos.c:1912
msgid "numbered from 5"
msgstr "číslováno od 5"

#: libfdisk/src/dos.c:1951
#, c-format
msgid "Invalid partition type `%c'."
msgstr "Chybný typ oddílu „%c“."

#: libfdisk/src/dos.c:1969
#, c-format
msgid "Cannot write sector %jd: seek failed"
msgstr "Sektor %jd nelze zapsat: změna pozice selhala"

#: libfdisk/src/dos.c:2129 libfdisk/src/gpt.c:1248
msgid "Disk identifier"
msgstr "Identifikátor disku"

#: libfdisk/src/dos.c:2243
msgid "Type 0 means free space to many systems. Having partitions of type 0 is probably unwise."
msgstr "Na mnoha systémech typ 0 označuje volný prostor. Mít oddíly typu 0 není moudré."

#: libfdisk/src/dos.c:2248
msgid "Cannot change type of the extended partition which is already used by logical partitions. Delete logical partitions first."
msgstr "Typ rozšířeného oddílu, který se již používá logickým oddílem, nelze změnit. Nejprve smažte logický oddíl."

#: libfdisk/src/dos.c:2434 libfdisk/src/gpt.c:3050
msgid "Nothing to do. Ordering is correct already."
msgstr "Diskové oddíly jsou již seřazeny."

#: libfdisk/src/dos.c:2489
#, c-format
msgid "Partition %zu: no data area."
msgstr "Oddíl %zu: neobsahuje datovou oblast."

#: libfdisk/src/dos.c:2522
msgid "New beginning of data"
msgstr "Nový začátek dat"

#: libfdisk/src/dos.c:2578
#, c-format
msgid "Partition %zu: is an extended partition."
msgstr "Oddíl %zu: je rozšířeným oddílem."

#: libfdisk/src/dos.c:2584
#, c-format
msgid "The bootable flag on partition %zu is enabled now."
msgstr "Příznak zaveditelnosti oddílu %zu je nyní zapnut."

#: libfdisk/src/dos.c:2585
#, c-format
msgid "The bootable flag on partition %zu is disabled now."
msgstr "Příznak zaveditelnosti oddílu %zu je nyní vypnut."

#: libfdisk/src/dos.c:2598 libfdisk/src/gpt.c:3140 libfdisk/src/sgi.c:1157
#: libfdisk/src/sun.c:1129
msgid "Device"
msgstr "Zařízení"

#: libfdisk/src/dos.c:2599 libfdisk/src/sun.c:40
msgid "Boot"
msgstr "Zaveditelný"

#: libfdisk/src/dos.c:2605 libfdisk/src/sgi.c:1163 libfdisk/src/sun.c:1135
msgid "Id"
msgstr "ID"

#: libfdisk/src/dos.c:2609
msgid "Start-C/H/S"
msgstr "Začátek-C/H/S"

#: libfdisk/src/dos.c:2610
msgid "End-C/H/S"
msgstr "Konec-C/H/S"

#: libfdisk/src/dos.c:2611 libfdisk/src/gpt.c:3150 libfdisk/src/sgi.c:1165
msgid "Attrs"
msgstr "Atr"

#: libfdisk/src/gpt.c:682
msgid "failed to allocate GPT header"
msgstr "alokace hlavičky GPT selhala"

#: libfdisk/src/gpt.c:765
msgid "First LBA specified by script is out of range."
msgstr "První adresa LBA uvedená skriptem je mimo rozsah."

#: libfdisk/src/gpt.c:777
msgid "Last LBA specified by script is out of range."
msgstr "Poslední adresa LBA uvedená skriptem je mimo rozsah."

#: libfdisk/src/gpt.c:919
#, c-format
msgid "GPT PMBR size mismatch (%<PRIu64> != %<PRIu64>) will be corrected by write."
msgstr "Velikost GPT PMBR nesouhlasí (%<PRIu64> != %<PRIu64>), bude opravena při zápisu."

#: libfdisk/src/gpt.c:944
msgid "gpt: stat() failed"
msgstr "GPT: volání stat() selhalo"

#: libfdisk/src/gpt.c:954
#, c-format
msgid "gpt: cannot handle files with mode %o"
msgstr "GPT: soubory s módem %o nelze zpracovat"

#: libfdisk/src/gpt.c:1218
msgid "GPT Header"
msgstr "Hlavička GPT"

#: libfdisk/src/gpt.c:1223
msgid "GPT Entries"
msgstr "Záznamy GPT"

#: libfdisk/src/gpt.c:1255
msgid "First LBA"
msgstr "První LBA"

#: libfdisk/src/gpt.c:1260
msgid "Last LBA"
msgstr "Poslední LBA"

#. TRANSLATORS: The LBA (Logical Block Address) of the backup GPT header.
#: libfdisk/src/gpt.c:1266
msgid "Alternative LBA"
msgstr "LBA náhrady"

#. TRANSLATORS: The start of the array of partition entries.
#: libfdisk/src/gpt.c:1272
msgid "Partition entries LBA"
msgstr "LBA záznamů oddílů"

#: libfdisk/src/gpt.c:1277
msgid "Allocated partition entries"
msgstr "Alokované záznamy oddílů"

#: libfdisk/src/gpt.c:1619
msgid "The backup GPT table is corrupt, but the primary appears OK, so that will be used."
msgstr "Záložní tabulka GPT je poškozená, avšak hlavní se zdá být v pořádku, takže ta bude použita."

#: libfdisk/src/gpt.c:1629
msgid "The primary GPT table is corrupt, but the backup appears OK, so that will be used."
msgstr "Hlavní tabulka GPT je poškozená, avšak záložní se zdá být v pořádku, takže ta bude použita."

#: libfdisk/src/gpt.c:1645
#, fuzzy
msgid "The backup GPT table is not on the end of the device."
msgstr "Záložní tabulka GPT není na konci zařízení. Problém bude opraven při zápisu."

#: libfdisk/src/gpt.c:1648
msgid "The backup GPT table is not on the end of the device. This problem will be corrected by write."
msgstr "Záložní tabulka GPT není na konci zařízení. Problém bude opraven při zápisu."

#: libfdisk/src/gpt.c:1652
#, fuzzy
msgid "Failed to recalculate backup GPT table location"
msgstr "výstupní tabulku se nepodařilo alokovat"

#: libfdisk/src/gpt.c:1807
#, c-format
msgid "unsupported GPT attribute bit '%s'"
msgstr "nepodporovaný bit „%s“ atributu GPT"

#: libfdisk/src/gpt.c:1812
#, c-format
msgid "failed to parse GPT attribute string '%s'"
msgstr "nezdařilo se rozebrat řetězec atributů GPT „%s“"

#: libfdisk/src/gpt.c:1912
#, c-format
msgid "Partition UUID changed from %s to %s."
msgstr "UUID oddílu změněno z %s na %s."

#: libfdisk/src/gpt.c:1921
msgid "Failed to translate partition name, name not changed."
msgstr "Název oddílu se nepodařilo přeložit, název nezměněn."

#: libfdisk/src/gpt.c:1923
#, c-format
msgid "Partition name changed from '%s' to '%.*s'."
msgstr "Název oddílu změněn z „%s“ na „%.*s“."

#: libfdisk/src/gpt.c:1952
msgid "The start of the partition understeps FirstUsableLBA."
msgstr "Začátek oddílu nedosahuje FirstUsableLBA (první použitelné LBA)."

#: libfdisk/src/gpt.c:1959
msgid "The end of the partition oversteps LastUsableLBA."
msgstr "Konec oddílu překračuje LastUsableLBA (poslední použitelné LBA)."

#: libfdisk/src/gpt.c:2117
msgid "The device contains hybrid MBR -- writing GPT only."
msgstr "Zařízení obsahuje hybridní MBR – zapisuje se pouze GPT."

#: libfdisk/src/gpt.c:2153
msgid "Disk does not contain a valid backup header."
msgstr "Disk neobsahuje korektní záložní hlavičku."

#: libfdisk/src/gpt.c:2158
msgid "Invalid primary header CRC checksum."
msgstr "Chybný kontrolní součet primární hlavičky."

#: libfdisk/src/gpt.c:2162
msgid "Invalid backup header CRC checksum."
msgstr "Chybný kontrolní součet záložní hlavičky."

#: libfdisk/src/gpt.c:2167
msgid "Invalid partition entry checksum."
msgstr "Chybný kontrolní součet záznamu oddílu."

#: libfdisk/src/gpt.c:2172
msgid "Invalid primary header LBA sanity checks."
msgstr "Kontrola správnosti primární hlavičky LBA neprošla."

#: libfdisk/src/gpt.c:2176
msgid "Invalid backup header LBA sanity checks."
msgstr "Kontrola správnosti záložní hlavičky LBA neprošla."

#: libfdisk/src/gpt.c:2181
msgid "MyLBA mismatch with real position at primary header."
msgstr "MyLBA se neshoduje se skutečnou pozicí v primární hlavičce."

#: libfdisk/src/gpt.c:2185
msgid "MyLBA mismatch with real position at backup header."
msgstr "MyLBA se neshoduje se skutečnou pozicí v záložní hlavičce."

#: libfdisk/src/gpt.c:2190
msgid "Disk is too small to hold all data."
msgstr "Disk je příliš malý, aby udržel všechna data."

#: libfdisk/src/gpt.c:2200
msgid "Primary and backup header mismatch."
msgstr "Primární a záložní hlavička se neshodují."

#: libfdisk/src/gpt.c:2206
#, c-format
msgid "Partition %u overlaps with partition %u."
msgstr "Oddíl %u přesahuje do oddílu %u."

#: libfdisk/src/gpt.c:2213
#, c-format
msgid "Partition %u is too big for the disk."
msgstr "Oddíl %u je pro disk příliš velký."

#: libfdisk/src/gpt.c:2220
#, c-format
msgid "Partition %u ends before it starts."
msgstr "Oddíl %u končí před svým začátkem."

#: libfdisk/src/gpt.c:2230
#, c-format
msgid "Header version: %s"
msgstr "Verze hlavičky: %s"

#: libfdisk/src/gpt.c:2231
#, c-format
msgid "Using %zu out of %zu partitions."
msgstr "Používá se %zu z %zu oddílů."

#: libfdisk/src/gpt.c:2241
#, c-format
msgid "A total of %ju free sectors is available in %u segment."
msgid_plural "A total of %ju free sectors is available in %u segments (the largest is %s)."
msgstr[0] "Celkem %ju volných sektorů je dostupných v %u oblasti."
msgstr[1] "Celkem %ju volných sektorů je dostupných v %u oblastech (největší je %s)."
msgstr[2] "Celkem %ju volných sektorů je dostupných v %u oblastech (největší je %s)."

#: libfdisk/src/gpt.c:2328
msgid "All partitions are already in use."
msgstr "Všechny oddíly se již používají."

#: libfdisk/src/gpt.c:2385 libfdisk/src/gpt.c:2412
#, c-format
msgid "Sector %ju already used."
msgstr "Sektor %ju je již alokován."

#: libfdisk/src/gpt.c:2478
#, c-format
msgid "Could not create partition %zu"
msgstr "Oddíl %zu nebylo možné vytvořit"

#: libfdisk/src/gpt.c:2485
#, c-format
msgid "The last usable GPT sector is %ju, but %ju is requested."
msgstr "Poslední použitelný sektor GPT je %ju, ale požadováno bylo %ju."

#: libfdisk/src/gpt.c:2492
#, c-format
msgid "The first usable GPT sector is %ju, but %ju is requested."
msgstr "První použitelný sektor GPT je %ju, ale požadováno bylo %ju"

#: libfdisk/src/gpt.c:2631
#, c-format
msgid "Created a new GPT disklabel (GUID: %s)."
msgstr "Vytvořena nový popis disku GPT (GUID: %s)."

#: libfdisk/src/gpt.c:2652
msgid "Enter new disk UUID (in 8-4-4-4-12 format)"
msgstr "Zadejte nové UUID disku (formát 8-4-4-4-12)"

#: libfdisk/src/gpt.c:2660
msgid "Failed to parse your UUID."
msgstr "Vaše UUID se nepodařilo rozebrat."

#: libfdisk/src/gpt.c:2674
#, c-format
msgid "Disk identifier changed from %s to %s."
msgstr "Identifikátor disku změněn z %s na %s."

#: libfdisk/src/gpt.c:2694
msgid "Not enough space for new partition table!"
msgstr "Nedostatek místa pro novou tabulku rozdělení disku!"

#: libfdisk/src/gpt.c:2705
#, c-format
msgid "Partition #%zu out of range (minimal start is %<PRIu64> sectors)"
msgstr "Oddíl č. %zu je mimo rozsah (nejmenší počátek je %<PRIu64> sektorů)"

#: libfdisk/src/gpt.c:2710
#, c-format
msgid "Partition #%zu out of range (maximal end is %<PRIu64> sectors)"
msgstr "Oddíl č. %zu je mimo rozsah (nejzazší konec je %<PRIu64> sektorů)"

#: libfdisk/src/gpt.c:2756
msgid "The partition entry size is zero."
msgstr "Velikost záznamu s oddílem je 0."

#: libfdisk/src/gpt.c:2758
#, c-format
msgid "The number of the partition has to be smaller than %zu."
msgstr "Číslo oddílu musí být menší než %zu."

#: libfdisk/src/gpt.c:2782
msgid "Cannot allocate memory!"
msgstr "Paměť nelze alokovat!"

#: libfdisk/src/gpt.c:2811
#, c-format
msgid "Partition table length changed from %<PRIu32> to %<PRIu64>."
msgstr "Délka tabulky rozdělení disku změněna z %<PRIu32> na %<PRIu64>."

#: libfdisk/src/gpt.c:2921
#, c-format
msgid "The attributes on partition %zu changed to 0x%016<PRIx64>."
msgstr "Atributy oddílu %zu se změnily na 0x%016<PRIx64>."

#: libfdisk/src/gpt.c:2971
msgid "Enter GUID specific bit"
msgstr "Zadejte bit specifický pro GUID"

#: libfdisk/src/gpt.c:2986
#, c-format
msgid "failed to toggle unsupported bit %lu"
msgstr "nepodporovaný bit %lu se nepodařilo přepnout"

#: libfdisk/src/gpt.c:2999
#, c-format
msgid "The GUID specific bit %d on partition %zu is enabled now."
msgstr "Bit specifický pro GUID %d na oddílu %zu je nyní nastaven."

#: libfdisk/src/gpt.c:3000
#, c-format
msgid "The GUID specific bit %d on partition %zu is disabled now."
msgstr "Bit specifický pro GUID %d na oddílu %zu je nyní vypnut."

#: libfdisk/src/gpt.c:3004
#, c-format
msgid "The %s flag on partition %zu is enabled now."
msgstr "Příznak %s oddílu %zu je nyní zapnut."

#: libfdisk/src/gpt.c:3005
#, c-format
msgid "The %s flag on partition %zu is disabled now."
msgstr "Příznak %s oddílu %zu je nyní vypnut."

#: libfdisk/src/gpt.c:3147
msgid "Type-UUID"
msgstr "Druh-UUID"

#: libfdisk/src/gpt.c:3148
msgid "UUID"
msgstr "UUID"

#: libfdisk/src/gpt.c:3149 login-utils/chfn.c:156 login-utils/chfn.c:158
#: login-utils/chfn.c:322
msgid "Name"
msgstr "Název"

#: libfdisk/src/partition.c:871
msgid "Free space"
msgstr "Volný prostor"

#: libfdisk/src/partition.c:1295
#, c-format
msgid "Failed to resize partition #%zu."
msgstr "Změnit velikost oddílu č. %zu se nepodařilo."

#: libfdisk/src/parttype.c:288 misc-utils/findmnt.c:662
#: misc-utils/uuidparse.c:199 misc-utils/uuidparse.c:217 schedutils/chrt.c:205
#: schedutils/ionice.c:79 sys-utils/hwclock.c:276
msgid "unknown"
msgstr "neznámý"

#: libfdisk/src/sgi.c:46
msgid "SGI volhdr"
msgstr "Hlavička SGI svazku"

#: libfdisk/src/sgi.c:47
msgid "SGI trkrepl"
msgstr "SGI trkrepl"

#: libfdisk/src/sgi.c:48
msgid "SGI secrepl"
msgstr "SGI secrepl"

#: libfdisk/src/sgi.c:49
msgid "SGI raw"
msgstr "SGI raw"

#: libfdisk/src/sgi.c:50
msgid "SGI bsd"
msgstr "SGI bsd"

#: libfdisk/src/sgi.c:51
msgid "SGI sysv"
msgstr "SGI sysv"

#: libfdisk/src/sgi.c:52
msgid "SGI volume"
msgstr "SGI svazek"

#: libfdisk/src/sgi.c:53
msgid "SGI efs"
msgstr "SGI efs"

#: libfdisk/src/sgi.c:54
msgid "SGI lvol"
msgstr "SGI lvol"

#: libfdisk/src/sgi.c:55
msgid "SGI rlvol"
msgstr "SGI rlvol"

#: libfdisk/src/sgi.c:56
msgid "SGI xfs"
msgstr "SGI XFS"

#: libfdisk/src/sgi.c:57
msgid "SGI xfslog"
msgstr "SGI xfslog"

#: libfdisk/src/sgi.c:58
msgid "SGI xlv"
msgstr "SGI xlv"

#: libfdisk/src/sgi.c:59
msgid "SGI xvm"
msgstr "SGI xvm"

#: libfdisk/src/sgi.c:61 libfdisk/src/sun.c:52
msgid "Linux native"
msgstr "Linux nativní"

#: libfdisk/src/sgi.c:158
msgid "SGI info created on second sector."
msgstr "Údaje SGI vytvořeny na druhém sektoru."

#: libfdisk/src/sgi.c:258
msgid "Detected an SGI disklabel with wrong checksum."
msgstr "Nalezen SGI popis disku s chybným kontrolním součtem."

#: libfdisk/src/sgi.c:281 libfdisk/src/sun.c:793
msgid "Physical cylinders"
msgstr "Fyzické cylindry"

#: libfdisk/src/sgi.c:286 libfdisk/src/sun.c:798
msgid "Extra sects/cyl"
msgstr "Extra sektory/cylindr"

#: libfdisk/src/sgi.c:296
msgid "Bootfile"
msgstr "Startovací soubor"

#: libfdisk/src/sgi.c:394
msgid "Invalid bootfile!  The bootfile must be an absolute non-zero pathname, e.g. \"/unix\" or \"/unix.save\"."
msgstr "Chybný startovací soubor! Startovací soubor musí být absolutní neprázdná cesta, např. „/unix“ či “/unix.save“."

#: libfdisk/src/sgi.c:402
#, c-format
msgid "Name of bootfile is too long: %zu byte maximum."
msgid_plural "Name of bootfile is too long: %zu bytes maximum."
msgstr[0] "Název startovacího souboru je příliš dlouhý: maximum je %zu bajt."
msgstr[1] "Název startovacího souboru je příliš dlouhý: maximum jsou %zu bajty."
msgstr[2] "Název startovacího souboru je příliš dlouhý: maximum je %zu bajtů."

#: libfdisk/src/sgi.c:411
msgid "Bootfile must have a fully qualified pathname."
msgstr "Startovací soubor musí být zadán s celou cestou."

#: libfdisk/src/sgi.c:417
msgid "Be aware that the bootfile is not checked for existence.  SGI's default is \"/unix\", and for backup \"/unix.save\"."
msgstr "Uvědomte si, že existence startovacího souboru není ověřována. Výchozí nastavení SGI je „/unix“ a jako záloha „/unix.save“."

#: libfdisk/src/sgi.c:442
#, c-format
msgid "The current boot file is: %s"
msgstr "Současný startovací soubor je: %s"

#: libfdisk/src/sgi.c:444
msgid "Enter of the new boot file"
msgstr "Zadejte nový startovací soubor"

#: libfdisk/src/sgi.c:449
msgid "Boot file is unchanged."
msgstr "Startovací soubor nebyl změněn."

#: libfdisk/src/sgi.c:460
#, c-format
msgid "Bootfile has been changed to \"%s\"."
msgstr "Startovací soubor byl změněn na „%s“."

#: libfdisk/src/sgi.c:599
msgid "More than one entire disk entry present."
msgstr "Existuje více než jeden záznam přes celý disk."

#: libfdisk/src/sgi.c:606 libfdisk/src/sun.c:467
msgid "No partitions defined."
msgstr "Nejsou definovány žádné oddíly."

#: libfdisk/src/sgi.c:616
msgid "IRIX likes it when partition 11 covers the entire disk."
msgstr "IRIX má rád, když oddíl 11 zaujímá celý disk."

#: libfdisk/src/sgi.c:620
#, c-format
msgid "The entire disk partition should start at block 0, not at block %d."
msgstr "Diskový oddíl zaujímající celý disk by měl začínat blokem 0, nikoliv blokem %d."

#: libfdisk/src/sgi.c:631
msgid "Partition 11 should cover the entire disk."
msgstr "Oddíl 11 by měl zaujímat celý disk."

#: libfdisk/src/sgi.c:655
#, c-format
msgid "Partitions %d and %d overlap by %d sector."
msgid_plural "Partitions %d and %d overlap by %d sectors."
msgstr[0] "Diskové oddíly %d a %d se navzájem překrývají %d sektorem."
msgstr[1] "Diskové oddíly %d a %d se navzájem překrývají %d sektory."
msgstr[2] "Diskové oddíly %d a %d se navzájem překrývají %d sektory."

#: libfdisk/src/sgi.c:666 libfdisk/src/sgi.c:688
#, c-format
msgid "Unused gap of %8u sector: sector %8u"
msgid_plural "Unused gap of %8u sectors: sectors %8u-%u"
msgstr[0] "Nevyužívaný prostor o velikosti %'8u sektoru: sektor %8u"
msgstr[1] "Nevyužívaný prostor o velikosti %'8u sektorů: sektory %8u-%u"
msgstr[2] "Nevyužívaný prostor o velikosti %'8u sektorů: sektory %8u-%u"

#: libfdisk/src/sgi.c:701
msgid "The boot partition does not exist."
msgstr "Startovací oddíl neexistuje."

#: libfdisk/src/sgi.c:705
msgid "The swap partition does not exist."
msgstr "Diskový oddíl pro odkládací prostor neexistuje."

#: libfdisk/src/sgi.c:709
msgid "The swap partition has no swap type."
msgstr "Diskový oddíl pro odkládací prostor nemá zadán typ."

#: libfdisk/src/sgi.c:712
msgid "You have chosen an unusual bootfile name."
msgstr "Vybrali jste si neobvyklý název pro startovací soubor."

#: libfdisk/src/sgi.c:762
msgid "Partition overlap on the disk."
msgstr "Překryv oddílů na disku."

#: libfdisk/src/sgi.c:847
msgid "Attempting to generate entire disk entry automatically."
msgstr "Pokouším se automaticky vytvořit položku pro celý disk."

#: libfdisk/src/sgi.c:852
msgid "The entire disk is already covered with partitions."
msgstr "Diskové oddíly již zabírají celý prostor disky."

#: libfdisk/src/sgi.c:856
msgid "You got a partition overlap on the disk. Fix it first!"
msgstr "Diskové oddíly se překrývají. Nejprve to opravte!"

#: libfdisk/src/sgi.c:878 libfdisk/src/sun.c:563
#, c-format
msgid "First %s"
msgstr "První %s"

#: libfdisk/src/sgi.c:902 libfdisk/src/sgi.c:953
msgid "It is highly recommended that the eleventh partition covers the entire disk and is of type 'SGI volume'."
msgstr "Doporučuje se, aby jedenáctý oddíl zaujímal celý prostor disku a byl typu „SGI svazek“"

#: libfdisk/src/sgi.c:917
#, c-format
msgid "Last %s or +%s or +size{K,M,G,T,P}"
msgstr "Poslední %s, +%s nebo +velikost{K,M,G,T,P}"

#: libfdisk/src/sgi.c:989 libfdisk/src/sun.c:248
#, c-format
msgid "BLKGETSIZE ioctl failed on %s. Using geometry cylinder value of %llu. This value may be truncated for devices > 33.8 GB."
msgstr "ioctl BLKGETSIZE selhalo na %s. Pro geometrii se použije %llu cylindrů. Tato hodnota může být zkrácena pro zařízení > 33,8 GB."

#: libfdisk/src/sgi.c:1055
msgid "Created a new SGI disklabel."
msgstr "Vytvořen nový Sun popis disku."

#: libfdisk/src/sgi.c:1074
msgid "Sorry, only for non-empty partitions you can change the tag."
msgstr "Je nám líto, značku lze změnit jen u neprázdných oddílů."

#: libfdisk/src/sgi.c:1080
msgid "Consider leaving partition 9 as volume header (0), and partition 11 as entire volume (6), as IRIX expects it."
msgstr "Zvažte, zda by nebylo vhodné ponechat oddíl 9 jako hlavičku svazku (0) a oddíl 11 jako celý svazek (6), neboť IRIX to očekává."

#: libfdisk/src/sgi.c:1089
msgid "It is highly recommended that the partition at offset 0 is of type \"SGI volhdr\", the IRIX system will rely on it to retrieve from its directory standalone tools like sash and fx. Only the \"SGI volume\" entire disk section may violate this. Are you sure about tagging this partition differently?"
msgstr "Doporučuje se, aby oddíl začínající na pozici 0 byl typu „SGI volhdr“.  IRIX jej používá k přístupu k nástrojům jako je sash a fx. Výjimkou je pouze „SGI svazek“ zaujímající celý disk. Jste si jisti, že tento oddíl chcete označit jinak?"

#: libfdisk/src/sun.c:39
msgid "Unassigned"
msgstr "Nepřiřazeno"

#: libfdisk/src/sun.c:41
msgid "SunOS root"
msgstr "SunOS root"

#: libfdisk/src/sun.c:42
msgid "SunOS swap"
msgstr "SunOS swap"

#: libfdisk/src/sun.c:43
msgid "SunOS usr"
msgstr "SunOS usr"

#: libfdisk/src/sun.c:44
msgid "Whole disk"
msgstr "Celý disk"

#: libfdisk/src/sun.c:45
msgid "SunOS stand"
msgstr "SunOS stand"

#: libfdisk/src/sun.c:46
msgid "SunOS var"
msgstr "SunOS var"

#: libfdisk/src/sun.c:47
msgid "SunOS home"
msgstr "SunOS home"

#: libfdisk/src/sun.c:48
msgid "SunOS alt sectors"
msgstr "Náhr. sektory SunOS"

#: libfdisk/src/sun.c:49
msgid "SunOS cachefs"
msgstr "SunOS cachefs"

#: libfdisk/src/sun.c:50
msgid "SunOS reserved"
msgstr "Vyhrazeno pro SunOS"

#: libfdisk/src/sun.c:86
#, c-format
msgid "%#zu: start cylinder overflows Sun label limits"
msgstr "%#zu: počáteční cylindr přesahuje možnosti popisu disku Sun"

#: libfdisk/src/sun.c:89
#, c-format
msgid "%#zu: number of sectors overflow Sun label limits"
msgstr "%#zu: počet sektorů přesahuje možnosti popisu disku Sun"

#: libfdisk/src/sun.c:136
msgid "Detected sun disklabel with wrong checksum. Probably you'll have to set all the values, e.g. heads, sectors, cylinders and partitions or force a fresh label (s command in main menu)"
msgstr "Nalezen Sun popis disku s chybných kontrolním součtem. Pravděpodobně budete muset nastavit všechny hodnoty jako hlavy, sektory, cylindry a oddíly, nebo vytvořit novou tabulku (příkaz „s“ v hlavní nabídce)"

#: libfdisk/src/sun.c:153
#, c-format
msgid "Detected sun disklabel with wrong version [%d]."
msgstr "Nalezen sunovský popis disku s chybnou verzí [%d]."

#: libfdisk/src/sun.c:158
#, c-format
msgid "Detected sun disklabel with wrong vtoc.sanity [0x%08x]."
msgstr "Nalezen sunovský popis disku s chybným „vtoc.sanity“ [0x%08x]."

#: libfdisk/src/sun.c:163
#, c-format
msgid "Detected sun disklabel with wrong vtoc.nparts [%u]."
msgstr "Nalezen sunovský popis disku s chybným vtoc.nparts [%u]."

#: libfdisk/src/sun.c:168
msgid "Warning: Wrong values need to be fixed up and will be corrected by w(rite)"
msgstr "Pozor: Chybné hodnoty musí být opraveny a bude tak učiněno při zápisu (w)"

#: libfdisk/src/sun.c:193
msgid "Heads"
msgstr "Hlavy"

#: libfdisk/src/sun.c:198
msgid "Sectors/track"
msgstr "Sektorů/stopu"

#: libfdisk/src/sun.c:301
msgid "Created a new Sun disklabel."
msgstr "Vytvořen nový Sun popis disku."

#: libfdisk/src/sun.c:425
#, c-format
msgid "Partition %u doesn't end on cylinder boundary."
msgstr "Oddíl %u nekončí na hranici cylindru."

#: libfdisk/src/sun.c:444
#, c-format
msgid "Partition %u overlaps with others in sectors %u-%u."
msgstr "Oddíl %u přesahuje do jiných v sektorech %u–%u."

#: libfdisk/src/sun.c:472
#, c-format
msgid "Unused gap - sectors 0-%u."
msgstr "Nevyužívaný prostor - sektory 0-%u."

#: libfdisk/src/sun.c:474 libfdisk/src/sun.c:480
#, c-format
msgid "Unused gap - sectors %u-%u."
msgstr "Nevyužívaný prostor - sektory %u-%u."

#: libfdisk/src/sun.c:542
msgid "Other partitions already cover the whole disk. Delete some/shrink them before retry."
msgstr "Jiné oddíly již zaujímají celý disk. Smažte/zmenšete nějaké a zkuste to znovu."

#: libfdisk/src/sun.c:559
msgid "It is highly recommended that the third partition covers the whole disk and is of type `Whole disk'"
msgstr "Velmi se doporučuje, aby třetí oddíl zaujímal celý prostor disku a byl typu „Celý disk“"

#: libfdisk/src/sun.c:601
#, c-format
msgid "Aligning the first sector from %u to %u to be on cylinder boundary."
msgstr "Zarovnává se první sektor z %u na %u, aby se nacházel na hranici cylindru."

#: libfdisk/src/sun.c:629
#, c-format
msgid "Sector %d is already allocated"
msgstr "Sektor %d je již alokován"

#: libfdisk/src/sun.c:658
#, c-format
msgid "Last %s or +/-%s or +/-size{K,M,G,T,P}"
msgstr "Poslední %s, +/-%s nebo +/-velikost{K,M,G,T,P}"

#: libfdisk/src/sun.c:706
#, c-format
msgid ""
"You haven't covered the whole disk with the 3rd partition, but your value\n"
"%lu %s covers some other partition. Your entry has been changed\n"
"to %lu %s"
msgstr ""
"Třetí oddíl nezabírá celý disk, ale vaše hodnota %lu %s\n"
"zasahuje jiné oddíly. Vaše údaje byly změněny na %lu %s"

# TODO: Pluralize
#: libfdisk/src/sun.c:749
#, c-format
msgid "If you want to maintain SunOS/Solaris compatibility, consider leaving this partition as Whole disk (5), starting at 0, with %u sectors"
msgstr "Pokud chcete zachovat kompatibilitu se SunOS/Solarisem, zvažte ponechání tohoto oddílu jako Celého disku (5), začínajícího na 0, o délce %u sektorů"

#: libfdisk/src/sun.c:773
msgid "Label ID"
msgstr "ID popisu"

#: libfdisk/src/sun.c:778
msgid "Volume ID"
msgstr "ID svazku"

#: libfdisk/src/sun.c:788
msgid "Alternate cylinders"
msgstr "Alternativní cylindry"

#: libfdisk/src/sun.c:894
msgid "Number of alternate cylinders"
msgstr "Počet alternativních cylindrů"

#: libfdisk/src/sun.c:919
msgid "Extra sectors per cylinder"
msgstr "Extra sektory na cylindr"

#: libfdisk/src/sun.c:943
msgid "Interleave factor"
msgstr "Interleave faktor"

#: libfdisk/src/sun.c:967
msgid "Rotation speed (rpm)"
msgstr "Rychlost otáčení (otm)"

#: libfdisk/src/sun.c:991
msgid "Number of physical cylinders"
msgstr "Počet fyzických cylindrů"

#: libfdisk/src/sun.c:1056
msgid ""
"Consider leaving partition 3 as Whole disk (5),\n"
"as SunOS/Solaris expects it and even Linux likes it.\n"
msgstr ""
"Zvažte zda by nebylo vhodné ponechat oddíl 3 jako Celý disk (5),\n"
"neboť SunOS/Solaris to očekává a i Linux tomu dává přednost.\n"

#: libfdisk/src/sun.c:1067
msgid ""
"It is highly recommended that the partition at offset 0\n"
"is UFS, EXT2FS filesystem or SunOS swap. Putting Linux swap\n"
"there may destroy your partition table and bootblock.\n"
"Are you sure you want to tag the partition as Linux swap?"
msgstr ""
"Doporučuje se, aby oddíl začínající na posunu 0 byl typu\n"
"UFS, EXT2FS či SunOS swap. Vytvoření odkládacího prostoru pro Linux\n"
"na tomto místě by mohlo zničit tabulku rozdělení disku a startovací blok.\n"
"Jste si jisti, že chcete tento oddíl označit jako odkládací prostor pro\n"
"Linux?"

#: libmount/src/context.c:2761
#, c-format
msgid "operation failed: %m"
msgstr "operace selhala: %m"

#: libmount/src/context_mount.c:1638
#, c-format
msgid "WARNING: failed to apply propagation flags"
msgstr "POZOR: příznaky propagace se nepodařilo nastavit"

#: libmount/src/context_mount.c:1648
#, fuzzy, c-format
msgid "WARNING: source write-protected, mounted read-only"
msgstr "POZOR: zařízení je chráněno proti zápisu, připojeno pouze pro čtení"

#: libmount/src/context_mount.c:1662
#, c-format
msgid "operation permitted for root only"
msgstr "operace je dovolena pouze superuživateli"

#: libmount/src/context_mount.c:1666
#, c-format
msgid "%s is already mounted"
msgstr "%s je již připojeno"

#: libmount/src/context_mount.c:1672
#, c-format
msgid "can't find in %s"
msgstr "v %s nelze nalézt"

#: libmount/src/context_mount.c:1675
#, c-format
msgid "can't find mount point in %s"
msgstr "bod připojení nelze v %s nalézt"

#: libmount/src/context_mount.c:1678
#, c-format
msgid "can't find mount source %s in %s"
msgstr "zdroj připojení %s nelze v %s nalézt"

#: libmount/src/context_mount.c:1683
#, c-format
msgid "more filesystems detected on %s; use -t <type> or wipefs(8)"
msgstr "na %s objeveno více souborových systémů, použijte -t <druh> nebo wipefs(8)"

#: libmount/src/context_mount.c:1688
#, c-format
msgid "failed to determine filesystem type"
msgstr "nepodařilo se určit druh souborového systému"

#: libmount/src/context_mount.c:1689
#, c-format
msgid "no filesystem type specified"
msgstr "nezadán druh souborového systému"

#: libmount/src/context_mount.c:1696
#, c-format
msgid "can't find %s"
msgstr "%s nelze nalézt"

#: libmount/src/context_mount.c:1698
#, c-format
msgid "no mount source specified"
msgstr "nezadán žádný zdroj připojení"

#: libmount/src/context_mount.c:1704
#, c-format
msgid "failed to parse mount options: %m"
msgstr "nezdařilo se rozebrat volby připojení: %m"

#: libmount/src/context_mount.c:1705
#, c-format
msgid "failed to parse mount options"
msgstr "nezdařilo se rozebrat volby připojení"

#: libmount/src/context_mount.c:1709
#, c-format
msgid "failed to setup loop device for %s"
msgstr "nepodařilo se nastavit loop zařízení pro %s"

#: libmount/src/context_mount.c:1713
#, c-format
msgid "overlapping loop device exists for %s"
msgstr "pro %s existuje překrývající se loop zařízení"

#: libmount/src/context_mount.c:1717 libmount/src/context_umount.c:1263
#, c-format
msgid "locking failed"
msgstr "uzamčení selhalo"

#: libmount/src/context_mount.c:1721 libmount/src/context_umount.c:1269
#: sys-utils/umount.c:249 sys-utils/umount.c:265
#, c-format
msgid "failed to switch namespace"
msgstr "přepnutí jmenného prostoru selhalo"

#: libmount/src/context_mount.c:1724
#, c-format
msgid "mount failed: %m"
msgstr "připojení selhalo: %m"

#: libmount/src/context_mount.c:1734
#, c-format
msgid "filesystem was mounted, but failed to update userspace mount table"
msgstr "souborový systém byl připojen, ale aktualizace tabulky připojení v uživatelském prostoru selhala"

#: libmount/src/context_mount.c:1740
#, c-format
msgid "filesystem was mounted, but failed to switch namespace back"
msgstr "souborový systém byl připojen, ale přepnutí jmenného prostoru zpět selhalo"

#: libmount/src/context_mount.c:1747
#, c-format
msgid "filesystem was mounted, but any subsequent operation failed: %m"
msgstr "souborový systém byl připojen, ale jakákoliv následující operace selhala: %m"

#: libmount/src/context_mount.c:1765 libmount/src/context_mount.c:1810
#, c-format
msgid "mount point is not a directory"
msgstr "přípojný bod není adresářem"

#: libmount/src/context_mount.c:1767 login-utils/newgrp.c:226
#, c-format
msgid "permission denied"
msgstr "povolení zamítnuto"

#: libmount/src/context_mount.c:1769
#, c-format
msgid "must be superuser to use mount"
msgstr "mount může používat pouze superuživatel"

#: libmount/src/context_mount.c:1776
#, c-format
msgid "mount point is busy"
msgstr "bod připojení se používá"

#: libmount/src/context_mount.c:1783
#, c-format
msgid "%s already mounted on %s"
msgstr "%s je již připojeno na %s"

#: libmount/src/context_mount.c:1787
#, c-format
msgid "%s already mounted or mount point busy"
msgstr "%s je již připojeno či bod připojení je zaneprázdněn"

#: libmount/src/context_mount.c:1792
#, c-format
msgid "mount point does not exist"
msgstr "přípojný bod neexistuje"

#: libmount/src/context_mount.c:1795
#, c-format
msgid "mount point is a symbolic link to nowhere"
msgstr "přípojný bod je symbolickým odkazem, jenž nikam nevede"

#: libmount/src/context_mount.c:1800
#, c-format
msgid "special device %s does not exist"
msgstr "zvláštní zařízení %s neexistuje"

#: libmount/src/context_mount.c:1803 libmount/src/context_mount.c:1819
#: libmount/src/context_mount.c:1903 libmount/src/context_mount.c:1926
#, c-format
msgid "mount(2) system call failed: %m"
msgstr "volání mount(2) selhalo: %m"

#: libmount/src/context_mount.c:1815
#, c-format
msgid "special device %s does not exist (a path prefix is not a directory)"
msgstr "zvláštní zařízení %s neexistuje (název cesty nezačíná adresářem)"

#: libmount/src/context_mount.c:1827
#, c-format
msgid "mount point not mounted or bad option"
msgstr "přípojný bod není připojen či chybný přepínač"

#: libmount/src/context_mount.c:1829
#, c-format
msgid "not mount point or bad option"
msgstr "není bodem připojení či chybný přepínač"

#: libmount/src/context_mount.c:1832
#, c-format
msgid "bad option; moving a mount residing under a shared mount is unsupported"
msgstr "špatný přepínač, přesun přípojného bodu zpod sdíleného bodu není podporováno"

#: libmount/src/context_mount.c:1836
#, c-format
msgid "bad option; for several filesystems (e.g. nfs, cifs) you might need a /sbin/mount.<type> helper program"
msgstr "špatný přepínač, pro většinou souborových systému (např. nfs, cifs) budete potřebovat pomocný program /sbin/mount.<TYP>"

#: libmount/src/context_mount.c:1840
#, c-format
msgid "wrong fs type, bad option, bad superblock on %s, missing codepage or helper program, or other error"
msgstr "chybný typ souborového systému, chybný přepínač, chybný superblok na %s, chybí kódová stránka nebo pomocný program nebo jiná chyba"

#: libmount/src/context_mount.c:1847
#, c-format
msgid "mount table full"
msgstr "tabulka připojení je plná"

#: libmount/src/context_mount.c:1852
#, c-format
msgid "can't read superblock on %s"
msgstr "superblok na %s nelze přečíst"

#: libmount/src/context_mount.c:1859
#, c-format
msgid "unknown filesystem type '%s'"
msgstr "neznámý typ systému souborů „%s“"

#: libmount/src/context_mount.c:1862
#, c-format
msgid "unknown filesystem type"
msgstr "neznámý typ systému souborů"

#: libmount/src/context_mount.c:1871
#, c-format
msgid "%s is not a block device, and stat(2) fails?"
msgstr "%s není blokovým zařízením a volání stat(2-) selhalo?"

#: libmount/src/context_mount.c:1874
#, c-format
msgid "the kernel does not recognize %s as a block device; maybe \"modprobe driver\" is necessary"
msgstr "jádro nezná %s jako blokové zařízení, možná je třeba „modprobe ovladač“"

#: libmount/src/context_mount.c:1877
#, c-format
msgid "%s is not a block device; try \"-o loop\""
msgstr "%s není blokovým zařízením, zkuste „-o loop“"

#: libmount/src/context_mount.c:1879
#, c-format
msgid "%s is not a block device"
msgstr "%s není blokovým zařízením"

#: libmount/src/context_mount.c:1886
#, c-format
msgid "%s is not a valid block device"
msgstr "%s není platným blokovým zařízením"

#: libmount/src/context_mount.c:1894
#, c-format
msgid "cannot mount %s read-only"
msgstr "%s nelze připojit v režimu pouze pro čtení"

#: libmount/src/context_mount.c:1896
#, c-format
msgid "%s is write-protected but explicit read-write mode requested"
msgstr "%s je chráněno proti zápisu, třebaže byl požadován režim i pro zápis"

#: libmount/src/context_mount.c:1898
#, c-format
msgid "cannot remount %s read-write, is write-protected"
msgstr "%s nelze znovu připojit pro čtení i zápis, protože je chráněno proti zápisu"

#: libmount/src/context_mount.c:1900
#, c-format
msgid "bind %s failed"
msgstr "vázané připojení %s selhalo"

#: libmount/src/context_mount.c:1911
#, c-format
msgid "no medium found on %s"
msgstr "v %s nenalezeno žádné médium"

#: libmount/src/context_mount.c:1918
#, c-format
msgid "cannot mount; probably corrupted filesystem on %s"
msgstr "nelze připojit; asi poškozený systém souborů v „%s“"

#: libmount/src/context_umount.c:1257 libmount/src/context_umount.c:1311
#, c-format
msgid "not mounted"
msgstr "nepřipojeno"

#: libmount/src/context_umount.c:1273
#, c-format
msgid "umount failed: %m"
msgstr "odpojení selhalo: %m"

#: libmount/src/context_umount.c:1282
#, c-format
msgid "filesystem was unmounted, but failed to update userspace mount table"
msgstr "souborový systém byl odpojen, ale aktualizace tabulky připojení v uživatelském prostoru selhala"

#: libmount/src/context_umount.c:1288
#, c-format
msgid "filesystem was unmounted, but failed to switch namespace back"
msgstr "souborový systém byl odpojen, ale přepnutí jmenného prostoru zpět selhala"

#: libmount/src/context_umount.c:1295
#, c-format
msgid "filesystem was unmounted, but any subsequent operation failed: %m"
msgstr "souborový systém byl odpojen, ale jakákoliv následující operace selhala: %m"

#: libmount/src/context_umount.c:1308
#, c-format
msgid "invalid block device"
msgstr "neplatné blokové zařízení"

#: libmount/src/context_umount.c:1314
#, c-format
msgid "can't write superblock"
msgstr "superblok nelze zapsat"

#: libmount/src/context_umount.c:1317
#, c-format
msgid "target is busy"
msgstr "cíl se používá"

#: libmount/src/context_umount.c:1320
#, c-format
msgid "no mount point specified"
msgstr "nezadán žádný bod připojení"

#: libmount/src/context_umount.c:1323
#, c-format
msgid "must be superuser to unmount"
msgstr "musíte být superuživatelem, abyste mohli odpojovat"

#: libmount/src/context_umount.c:1326
#, c-format
msgid "block devices are not permitted on filesystem"
msgstr "bloková zařízení nejsou na systému souborů povolena"

#: libmount/src/context_umount.c:1329
#, c-format
msgid "umount(2) system call failed: %m"
msgstr "volání umount(2) selhalo: %m"

#: lib/pager.c:112
#, c-format
msgid "waitpid failed (%s)"
msgstr "volání waitpid selhalo (%s)"

#: lib/plymouth-ctrl.c:73
msgid "cannot open UNIX socket"
msgstr "nelze otevřít unixový socket"

#: lib/plymouth-ctrl.c:79
msgid "cannot set option for UNIX socket"
msgstr "unixovému socketu nelze změnit nastavení"

#: lib/plymouth-ctrl.c:90
msgid "cannot connect on UNIX socket"
msgstr "k unixovému soketu se nelze připojit"

#: lib/plymouth-ctrl.c:128
#, c-format
msgid "the plymouth request %c is not implemented"
msgstr "požadavek Plymouthu %c není implementován"

#: lib/randutils.c:189
msgid "getrandom() function"
msgstr "funkce getrandom()"

#: lib/randutils.c:202
msgid "libc pseudo-random functions"
msgstr "pseudonáhodné funkce libc"

#: lib/swapprober.c:17 lib/swapprober.c:30
#, c-format
msgid "%s: unable to probe device"
msgstr "%s: zařízení nelze vyzkoušet"

#: lib/swapprober.c:32
#, c-format
msgid "%s: ambiguous probing result; use wipefs(8)"
msgstr "%s: nejednoznačný výsledek zkoušky, použijte wipefs(8)"

#: lib/swapprober.c:34
#, c-format
msgid "%s: not a valid swap partition"
msgstr "%s: není neplatným odkládacím oddílem"

#: lib/swapprober.c:41
#, c-format
msgid "%s: unsupported swap version '%s'"
msgstr "%s: nepodporovaná verze odkládacího prostoru „%s“"

#: lib/timeutils.c:465
msgid "format_iso_time: buffer overflow."
msgstr "format_iso_time: přetečení vyrovnávací paměti."

#: lib/timeutils.c:483 lib/timeutils.c:507
#, c-format
msgid "time %ld is out of range."
msgstr "čas %ld je mimo rozsah."

#: login-utils/chfn.c:96 login-utils/chsh.c:75 login-utils/lslogins.c:1378
#, c-format
msgid " %s [options] [<username>]\n"
msgstr " %s [přepínače] [<uživatel>]\n"

#: login-utils/chfn.c:99
msgid "Change your finger information.\n"
msgstr "Změní finger informace o uživateli.\n"

#: login-utils/chfn.c:102
msgid " -f, --full-name <full-name>  real name\n"
msgstr " -f, --full-name <celé_jméno>  skutečné jméno\n"

#: login-utils/chfn.c:103
msgid " -o, --office <office>        office number\n"
msgstr " -o, --office <kancelář>       číslo kanceláře\n"

#: login-utils/chfn.c:104
msgid " -p, --office-phone <phone>   office phone number\n"
msgstr " -p, --office-phone <telefon>  telefonní číslo do kanceláře\n"

#: login-utils/chfn.c:105
msgid " -h, --home-phone <phone>     home phone number\n"
msgstr " -h, --home-phone <telefon>    telefonní číslo domů\n"

#: login-utils/chfn.c:123
#, c-format
msgid "field %s is too long"
msgstr "položka %s je příliš dlouhá"

#: login-utils/chfn.c:127 login-utils/chsh.c:237
#, c-format
msgid "%s: has illegal characters"
msgstr "%s: má zakázané znaky"

#: login-utils/chfn.c:156 login-utils/chfn.c:162 login-utils/chfn.c:168
#: login-utils/chfn.c:174
#, c-format
msgid "login.defs forbids setting %s"
msgstr "login.defs zakazuje nastavování %s"

#: login-utils/chfn.c:162 login-utils/chfn.c:164 login-utils/chfn.c:324
msgid "Office"
msgstr "Kancelář"

#: login-utils/chfn.c:168 login-utils/chfn.c:170 login-utils/chfn.c:326
msgid "Office Phone"
msgstr "Telefon do práce"

#: login-utils/chfn.c:174 login-utils/chfn.c:176 login-utils/chfn.c:328
msgid "Home Phone"
msgstr "Telefon domů"

#: login-utils/chfn.c:193 login-utils/chsh.c:187
msgid "cannot handle multiple usernames"
msgstr "více uživatelských jmen nelze zpracovat"

#: login-utils/chfn.c:247
msgid "Aborted."
msgstr "Ukončen."

#: login-utils/chfn.c:310
#, c-format
msgid "%s: CHFN_RESTRICT has unexpected value: %s"
msgstr "%s: CHFN_RESTRICT má neočekávanou hodnotu: %s"

#: login-utils/chfn.c:312
#, c-format
msgid "%s: CHFN_RESTRICT does not allow any changes"
msgstr "%s: CHFN_RESTRICT nedovoluje žádné změny"

#: login-utils/chfn.c:394
#, c-format
msgid "Finger information *NOT* changed.  Try again later.\n"
msgstr "Finger informace *NEBYLY* změněny. Zkuste to opět později.\n"

#: login-utils/chfn.c:398
#, c-format
msgid "Finger information changed.\n"
msgstr "Finger informace byly změněny.\n"

#: login-utils/chfn.c:424 login-utils/chsh.c:274
#, c-format
msgid "you (user %d) don't exist."
msgstr "vy (uživatel %d) neexistujete."

#: login-utils/chfn.c:430 login-utils/chsh.c:279 login-utils/libuser.c:59
#, c-format
msgid "user \"%s\" does not exist."
msgstr "uživatel „%s“ neexistuje."

#: login-utils/chfn.c:436 login-utils/chsh.c:285
msgid "can only change local entries"
msgstr "měnit lze pouze místní záznamy"

#: login-utils/chfn.c:449
#, c-format
msgid "%s is not authorized to change the finger info of %s"
msgstr "%s nemá dovoleno měnit finger informace o uživateli %s"

#: login-utils/chfn.c:451 login-utils/chsh.c:301
msgid "Unknown user context"
msgstr "Neznámý kontext uživatele"

#: login-utils/chfn.c:457 login-utils/chsh.c:307
#, c-format
msgid "can't set default context for %s"
msgstr "výchozí kontext pro %s nelze nastavit"

#: login-utils/chfn.c:468
msgid "running UID doesn't match UID of user we're altering, change denied"
msgstr "aktuální UID se neshoduje s UID uživatele, kterého máme změnit, změna zamítnuta"

#: login-utils/chfn.c:472
#, c-format
msgid "Changing finger information for %s.\n"
msgstr "Měním finger informace o uživateli %s.\n"

#: login-utils/chfn.c:486
#, c-format
msgid "Finger information not changed.\n"
msgstr "Finger informace nebyly změněny.\n"

#: login-utils/chsh.c:78
msgid "Change your login shell.\n"
msgstr "Změní váš přihlašovací shell.\n"

#: login-utils/chsh.c:81
msgid " -s, --shell <shell>  specify login shell\n"
msgstr " -s, --shell <shell>  nastaví přihlašovací shell\n"

#: login-utils/chsh.c:82
msgid " -l, --list-shells    print list of shells and exit\n"
msgstr " -l, --list-shells    vypíše seznam shellů a skončí\n"

#: login-utils/chsh.c:231
msgid "shell must be a full path name"
msgstr "shell musí být zadán úplným jménem cesty"

#: login-utils/chsh.c:233
#, c-format
msgid "\"%s\" does not exist"
msgstr "„%s“ neexistuje"

#: login-utils/chsh.c:235
#, c-format
msgid "\"%s\" is not executable"
msgstr "„%s“ není spustitelným souborem"

#: login-utils/chsh.c:241
#, c-format
msgid "Warning: \"%s\" is not listed in %s."
msgstr "Pozor: „%s“ není uveden v %s."

#: login-utils/chsh.c:245 login-utils/chsh.c:249
#, c-format
msgid ""
"\"%s\" is not listed in %s.\n"
"Use %s -l to see list."
msgstr ""
"„%s“ není uveden v %s.\n"
"Seznam lze zobrazit pomocí „%s -l“."

#: login-utils/chsh.c:300
#, c-format
msgid "%s is not authorized to change the shell of %s"
msgstr "%s není oprávněn měnit shell uživatele %s"

#: login-utils/chsh.c:326
msgid "running UID doesn't match UID of user we're altering, shell change denied"
msgstr "aktuální UID se neshoduje s UID uživatele, kterého chceme změnit, změna shellu zamítnuta"

#: login-utils/chsh.c:331
#, c-format
msgid "your shell is not in %s, shell change denied"
msgstr "váš shell není v %s, změna shellu zamítnuta"

#: login-utils/chsh.c:335
#, c-format
msgid "Changing shell for %s.\n"
msgstr "Měním shell pro %s.\n"

#: login-utils/chsh.c:343
msgid "New shell"
msgstr "Nový shell"

#: login-utils/chsh.c:351
msgid "Shell not changed."
msgstr "Shell nebyl změněn."

#: login-utils/chsh.c:356
msgid "Shell *NOT* changed.  Try again later."
msgstr "Shell *NEBYL* změněn. Zkuste to později znovu."

#: login-utils/chsh.c:360
msgid ""
"setpwnam failed\n"
"Shell *NOT* changed.  Try again later."
msgstr ""
"setpwnam selhal\n"
"Shell *NEBYL* změněn. Zkuste to později znovu."

#: login-utils/chsh.c:364
#, c-format
msgid "Shell changed.\n"
msgstr "Shell byl změněn.\n"

#: login-utils/islocal.c:95
#, c-format
msgid "Usage: %s <passwordfile> <username>...\n"
msgstr "Použití: %s <soubor_s_heslem> <uživatel>…\n"

#: login-utils/last.c:169 login-utils/lslogins.c:1369 sys-utils/dmesg.c:1288
#: sys-utils/lsipc.c:282
#, c-format
msgid "unknown time format: %s"
msgstr "neznámý formát času: %s"

#: login-utils/last.c:278 login-utils/last.c:286
#, c-format
msgid "Interrupted %s"
msgstr "Přerušeno %s"

#: login-utils/last.c:443 login-utils/last.c:454 login-utils/last.c:897
msgid "preallocation size exceeded"
msgstr "předalokovaná velikost překročena"

#: login-utils/last.c:573
#, c-format
msgid " %s [options] [<username>...] [<tty>...]\n"
msgstr " %s [přepínače] [<uživatel>…] [<tty>…]\n"

#: login-utils/last.c:576
msgid "Show a listing of last logged in users.\n"
msgstr "Ukáže výpis naposledy přihlášených uživatelů.\n"

#: login-utils/last.c:579
msgid " -<number>            how many lines to show\n"
msgstr " -<počet>             kolik řádků ukáže\n"

#: login-utils/last.c:580
msgid " -a, --hostlast       display hostnames in the last column\n"
msgstr " -a, --hostlast       v posledním sloupci zobrazí název stroje\n"

#: login-utils/last.c:581
msgid " -d, --dns            translate the IP number back into a hostname\n"
msgstr " -d, --dns            překládá IP adresy zpět na název stroje\n"

#: login-utils/last.c:583
#, c-format
msgid " -f, --file <file>    use a specific file instead of %s\n"
msgstr " -f, --file <soubor>  použije zadaný soubor místo %s\n"

#: login-utils/last.c:584
msgid " -F, --fulltimes      print full login and logout times and dates\n"
msgstr " -F, --fulltimes      vypíše celé časy a data přihlášení a odhlášení\n"

#: login-utils/last.c:585
msgid " -i, --ip             display IP numbers in numbers-and-dots notation\n"
msgstr " -i, --ip             vypíše IP adresy v tečkovém formátu\n"

#: login-utils/last.c:586
msgid " -n, --limit <number> how many lines to show\n"
msgstr " -n, --limit <číslo>  kolik řádků ukázat\n"

#: login-utils/last.c:587
msgid " -R, --nohostname     don't display the hostname field\n"
msgstr " -R, --nohostname     nezobrazí položku s názvem stroje\n"

#: login-utils/last.c:588
msgid " -s, --since <time>   display the lines since the specified time\n"
msgstr " -s, --since <čas>    zobrazí řádky od zadaného času\n"

#: login-utils/last.c:589
msgid " -t, --until <time>   display the lines until the specified time\n"
msgstr " -t, --until <čas>    zobrazí řádky do zadaného času vyjma\n"

#: login-utils/last.c:590
msgid " -p, --present <time> display who were present at the specified time\n"
msgstr " -p, --present <čas>  zobrazí, kdo byl v zadaný čas přítomen\n"

#: login-utils/last.c:591
msgid " -w, --fullnames      display full user and domain names\n"
msgstr " -w, --fullnames      zobrazí celá uživatelská jména a názvy domén\n"

#: login-utils/last.c:592
msgid " -x, --system         display system shutdown entries and run level changes\n"
msgstr " -x, --system         zobrazí záznamy s vypnutím systému a změn běhové úrovně\n"

#: login-utils/last.c:593
msgid ""
"     --time-format <format>  show timestamps in the specified <format>:\n"
"                               notime|short|full|iso\n"
msgstr ""
"     --time-format <formát>  zobrazí časové údaje v daném formátu:\n"
"                             notime, short, full, iso\n"
"                             (žádný, krátký, celý, ISO)\n"

#: login-utils/last.c:898
#, c-format
msgid ""
"\n"
"%s begins %s\n"
msgstr ""
"\n"
"%s začíná %s\n"

#: login-utils/last.c:976 term-utils/scriptlive.c:85 term-utils/scriptlive.c:89
#: term-utils/scriptreplay.c:79 term-utils/scriptreplay.c:83
#: text-utils/more.c:280 text-utils/more.c:286
msgid "failed to parse number"
msgstr "číslo se nezdařilo rozebrat"

#: login-utils/last.c:997 login-utils/last.c:1002 login-utils/last.c:1007
#: sys-utils/rtcwake.c:512
#, c-format
msgid "invalid time value \"%s\""
msgstr "chybná hodnota času „%s“"

#: login-utils/libuser.c:29 login-utils/libuser.c:31
msgid "Couldn't drop group privileges"
msgstr "Nebylo možné se zbavit skupinových oprávnění"

#: login-utils/libuser.c:47
#, c-format
msgid "libuser initialization failed: %s."
msgstr "inicializace libuser se nezdařila: %s"

#: login-utils/libuser.c:52
msgid "changing user attribute failed"
msgstr "změna vlastnosti uživatele se nezdařila"

#: login-utils/libuser.c:66
#, c-format
msgid "user attribute not changed: %s"
msgstr "vlastnost uživatele nezměněna: %s"

#: login-utils/login.c:366
#, c-format
msgid "FATAL: can't reopen tty: %m"
msgstr "FATÁLNÍ: TTY nelze znovu otevřít: %m"

#: login-utils/login.c:372
#, c-format
msgid "FATAL: %s is not a terminal"
msgstr "FATÁLNÍ: %s není terminálem"

#: login-utils/login.c:390
#, c-format
msgid "chown (%s, %lu, %lu) failed: %m"
msgstr "volání chown(%s, %lu, %lu) selhalo: %m"

#: login-utils/login.c:394
#, c-format
msgid "chmod (%s, %u) failed: %m"
msgstr "volání chdir(%s, %u) selhalo: %m"

#: login-utils/login.c:455
msgid "FATAL: bad tty"
msgstr "FATÁLNÍ: špatné TTY"

#: login-utils/login.c:473
#, c-format
msgid "FATAL: %s: change permissions failed: %m"
msgstr "FATÁLNÍ: %s: změna přístupových práv selhala: %m"

#: login-utils/login.c:604
#, c-format
msgid "Last login: %.*s "
msgstr "Poslední přihlášení: %.*s "

#: login-utils/login.c:606
#, c-format
msgid "from %.*s\n"
msgstr "z %.*s\n"

#: login-utils/login.c:609
#, c-format
msgid "on %.*s\n"
msgstr "%.*s\n"

#: login-utils/login.c:625
msgid "write lastlog failed"
msgstr "zápis do protokolu přihlášení (lastlog) se nezdařil"

#: login-utils/login.c:716
#, c-format
msgid "DIALUP AT %s BY %s"
msgstr "PŘÍSTUP UŽIVATELE %2$s VYTÁČENOU LINKOU NA TTY %1$s"

#: login-utils/login.c:721
#, c-format
msgid "ROOT LOGIN ON %s FROM %s"
msgstr "PŘIHLÁŠENÍ UŽIVATELE ROOT Z %2$s NA TTY %1$s"

#: login-utils/login.c:724
#, c-format
msgid "ROOT LOGIN ON %s"
msgstr "PŘIHLÁŠENÍ UŽIVATELE ROOT NA TTY %s"

#: login-utils/login.c:727
#, c-format
msgid "LOGIN ON %s BY %s FROM %s"
msgstr "PŘIHLÁŠENÍ UŽIVATELE %2$s Z %3$s NA TTY %1$s"

#: login-utils/login.c:730
#, c-format
msgid "LOGIN ON %s BY %s"
msgstr "PŘIHLÁŠENÍ UŽIVATELE %2$s NA TTY %1$s"

#: login-utils/login.c:764
msgid "login: "
msgstr "Přihlašovací jméno:"

#: login-utils/login.c:795
#, c-format
msgid "PAM failure, aborting: %s"
msgstr "chyba PAM, končí se: %s"

#: login-utils/login.c:796
#, c-format
msgid "Couldn't initialize PAM: %s"
msgstr "PAM nelze inicializovat: %s"

#: login-utils/login.c:866
#, c-format
msgid "FAILED LOGIN %u FROM %s FOR %s, %s"
msgstr "%1$u. CHYBNÉ PŘIHLÁŠENÍ UŽIVATELE %3$s Z %2$s, %4$s"

#: login-utils/login.c:874 login-utils/sulogin.c:1013
#, c-format
msgid ""
"Login incorrect\n"
"\n"
msgstr ""
"Chybné přihlášení\n"
"\n"

#: login-utils/login.c:889
#, c-format
msgid "TOO MANY LOGIN TRIES (%u) FROM %s FOR %s, %s"
msgstr "PŘÍLIŠ MNOHO (%1$u) POKUSŮ UŽIVATELE %3$s O PŘIHLÁŠENÍ Z %2$s, %4$s"

#: login-utils/login.c:895
#, c-format
msgid "FAILED LOGIN SESSION FROM %s FOR %s, %s"
msgstr "NEÚSPĚŠNÉ PŘIHLÁŠENÍ UŽIVATELE %2$s Z %1$s, %3$s"

#: login-utils/login.c:903
#, c-format
msgid ""
"\n"
"Login incorrect\n"
msgstr ""
"\n"
"Chybné přihlášení\n"

#: login-utils/login.c:931 login-utils/login.c:1314 login-utils/login.c:1337
msgid ""
"\n"
"Session setup problem, abort."
msgstr ""
"\n"
"Problém s nastavováním relace. Činnost bude ukončena."

#: login-utils/login.c:932
msgid "NULL user name. Abort."
msgstr "NULLOVÉ jméno uživatele. Přerušuji činnost."

#: login-utils/login.c:1070
#, c-format
msgid "TIOCSCTTY failed: %m"
msgstr "Selhalo TIOCSCTTY: %m"

#: login-utils/login.c:1174
#, c-format
msgid " %s [-p] [-h <host>] [-H] [[-f] <username>]\n"
msgstr "%s [-p] [-h <počítač>] [-H] [-f] [<uživatel>]\n"

#: login-utils/login.c:1176
msgid "Begin a session on the system.\n"
msgstr "Zahájí relaci v systému.\n"

#: login-utils/login.c:1179
msgid " -p             do not destroy the environment"
msgstr " -p             nezničí prostředí"

#: login-utils/login.c:1180
#, fuzzy
msgid " -f             skip a login authentication"
msgstr " -f             přeskočí druhou autentizaci loginu"

#: login-utils/login.c:1181
msgid " -h <host>      hostname to be used for utmp logging"
msgstr " -h <stroj>     zapíše tento název stroje do protokolu utmp"

#: login-utils/login.c:1182
msgid " -H             suppress hostname in the login prompt"
msgstr " -H             potlačí název stroje ve výzvě k přihlášení"

# TODO: pluralize
#: login-utils/login.c:1228
#, c-format
msgid "%s: timed out after %u seconds"
msgstr "%s: vypršel časový limit %u sekund"

#: login-utils/login.c:1255
#, c-format
msgid "login: -h is for superuser only\n"
msgstr "login: přepínač -h může použít pouze superuživatel\n"

#: login-utils/login.c:1315
#, c-format
msgid "Invalid user name \"%s\". Abort."
msgstr "Neplatné jméno uživatele „%s“. Přerušuji činnost."

#: login-utils/login.c:1336
#, c-format
msgid "groups initialization failed: %m"
msgstr "inicializace skupin se nezdařila: %m"

#: login-utils/login.c:1361 sys-utils/mount.c:57 sys-utils/umount.c:122
msgid "setgid() failed"
msgstr "volání setgid() selhalo"

#: login-utils/login.c:1391
#, c-format
msgid "You have new mail.\n"
msgstr "Máte novou poštu.\n"

#: login-utils/login.c:1393
#, c-format
msgid "You have mail.\n"
msgstr "Máte starou poštu.\n"

#: login-utils/login.c:1407 sys-utils/mount.c:60 sys-utils/umount.c:125
msgid "setuid() failed"
msgstr "volání setuid() selhalo"

#: login-utils/login.c:1413 login-utils/sulogin.c:731
#, c-format
msgid "%s: change directory failed"
msgstr "%s: nepodařilo se změnit adresář"

#: login-utils/login.c:1420 login-utils/sulogin.c:732
#, c-format
msgid "Logging in with home = \"/\".\n"
msgstr "Přihlašuji s domácím adresářem nastaveným na „/“.\n"

#: login-utils/login.c:1446
msgid "couldn't exec shell script"
msgstr "shellový skript nelze spustit"

#: login-utils/login.c:1448
msgid "no shell"
msgstr "Žádný shell"

#: login-utils/logindefs.c:216
#, c-format
msgid "%s: %s contains invalid numerical value: %s"
msgstr "%s: %s obsahuje neplatnou číselnou hodnotu: %s"

#: login-utils/logindefs.c:266
#, fuzzy, c-format
msgid "Error reading login.defs: %s"
msgstr "chyba při čtení %s"

#: login-utils/logindefs.c:333 login-utils/logindefs.c:353
#: login-utils/logindefs.c:379
#, fuzzy, c-format
msgid "couldn't fetch %s: %s"
msgstr "%s nebylo možné otevřít: %s\n"

#: login-utils/logindefs.c:537
msgid "hush login status: restore original IDs failed"
msgstr "stav tichého přihlášení: obnovení původních ID selhalo"

#: login-utils/lslogins.c:217 sys-utils/lscpu.c:1602 sys-utils/lscpu.c:1612
#: sys-utils/lsmem.c:266
msgid "no"
msgstr "ne"

#: login-utils/lslogins.c:226 misc-utils/lsblk.c:189
msgid "user name"
msgstr "uživatelské jméno"

#: login-utils/lslogins.c:226
msgid "Username"
msgstr "Uživatelské jméno"

#: login-utils/lslogins.c:227 sys-utils/renice.c:54
msgid "user ID"
msgstr "ID uživatele"

#: login-utils/lslogins.c:228
msgid "password not required"
msgstr "heslo není vyžadováno"

#: login-utils/lslogins.c:228
msgid "Password not required"
msgstr "Heslo není vyžadováno"

#: login-utils/lslogins.c:229
msgid "login by password disabled"
msgstr "přihlášení heslem je zakázáno"

#: login-utils/lslogins.c:229
msgid "Login by password disabled"
msgstr "Přihlášení heslem je zakázáno"

#: login-utils/lslogins.c:230
msgid "password defined, but locked"
msgstr "heslo je definováno, ale zamknuto"

#: login-utils/lslogins.c:230
msgid "Password is locked"
msgstr "Heslo je zamknuto"

#: login-utils/lslogins.c:231
msgid "password encryption method"
msgstr "způsob šifrování hesla"

#: login-utils/lslogins.c:231
msgid "Password encryption method"
msgstr "Způsob šifrování hesla"

#: login-utils/lslogins.c:232
msgid "log in disabled by nologin(8) or pam_nologin(8)"
msgstr "přihlášení zakázáno pomocí nologin(8) nebo pam_nologin(8)"

#: login-utils/lslogins.c:232
msgid "No login"
msgstr "Nepřihlašovat"

#: login-utils/lslogins.c:233
msgid "primary group name"
msgstr "název hlavní skupiny"

#: login-utils/lslogins.c:233
msgid "Primary group"
msgstr "Hlavní skupina"

#: login-utils/lslogins.c:234
msgid "primary group ID"
msgstr "ID hlavní skupiny"

#: login-utils/lslogins.c:235
msgid "supplementary group names"
msgstr "názvy doplňkových skupin"

#: login-utils/lslogins.c:235
msgid "Supplementary groups"
msgstr "Doplňkové skupiny"

#: login-utils/lslogins.c:236
msgid "supplementary group IDs"
msgstr "ID doplňkových skupiny"

#: login-utils/lslogins.c:236
msgid "Supplementary group IDs"
msgstr "ID doplňkových skupiny"

#: login-utils/lslogins.c:237
msgid "home directory"
msgstr "domovský adresář"

#: login-utils/lslogins.c:237
msgid "Home directory"
msgstr "Domovský adresář"

#: login-utils/lslogins.c:238
msgid "login shell"
msgstr "přihlašovací shell"

#: login-utils/lslogins.c:238
msgid "Shell"
msgstr "Shell"

#: login-utils/lslogins.c:239
msgid "full user name"
msgstr "celé jméno uživatele"

#: login-utils/lslogins.c:239
msgid "Gecos field"
msgstr "Položka gecos"

#: login-utils/lslogins.c:240
msgid "date of last login"
msgstr "datum posledního přihlášení"

#: login-utils/lslogins.c:240
msgid "Last login"
msgstr "Poslední přihlášení"

#: login-utils/lslogins.c:241
msgid "last tty used"
msgstr "naposledy použité TTY"

#: login-utils/lslogins.c:241
msgid "Last terminal"
msgstr "Poslední terminál"

#: login-utils/lslogins.c:242
msgid "hostname during the last session"
msgstr "název stroje během poslední relace"

#: login-utils/lslogins.c:242
msgid "Last hostname"
msgstr "Poslední název stroje"

#: login-utils/lslogins.c:243
msgid "date of last failed login"
msgstr "datum posledního chybného přihlášení"

#: login-utils/lslogins.c:243
msgid "Failed login"
msgstr "Chybné přihlášení"

#: login-utils/lslogins.c:244
msgid "where did the login fail?"
msgstr "kde přihlášení selhalo?"

#: login-utils/lslogins.c:244
msgid "Failed login terminal"
msgstr "Terminál chybného přihlášení"

#: login-utils/lslogins.c:245
msgid "user's hush settings"
msgstr "uživatelské nastavení ztišení"

#: login-utils/lslogins.c:245
msgid "Hushed"
msgstr "Ztišeno"

#: login-utils/lslogins.c:246
msgid "days user is warned of password expiration"
msgstr "počet dnů, po který upozorňovat uživatele na vypršení hesla"

#: login-utils/lslogins.c:246
msgid "Password expiration warn interval"
msgstr "Interval upozornění na vypršení hesla"

#: login-utils/lslogins.c:247
msgid "password expiration date"
msgstr "datum vypršení hesla"

#: login-utils/lslogins.c:247
msgid "Password expiration"
msgstr "Vypršení hesla"

#: login-utils/lslogins.c:248
msgid "date of last password change"
msgstr "datum poslední změny hesla"

#: login-utils/lslogins.c:248
msgid "Password changed"
msgstr "Heslo změněno"

#: login-utils/lslogins.c:249
msgid "number of days required between changes"
msgstr "počet dnů požadovaných mezi změnami"

#: login-utils/lslogins.c:249
msgid "Minimum change time"
msgstr "Minimální odstup změny"

#: login-utils/lslogins.c:250
msgid "max number of days a password may remain unchanged"
msgstr "maximální počet dnů, po které heslo smí zůstat nezměněné"

#: login-utils/lslogins.c:250
msgid "Maximum change time"
msgstr "Maximální odstup změny"

#: login-utils/lslogins.c:251
msgid "the user's security context"
msgstr "bezpečnostní kontext uživatele"

#: login-utils/lslogins.c:251
msgid "Selinux context"
msgstr "Selinuxový kontext"

#: login-utils/lslogins.c:252
msgid "number of processes run by the user"
msgstr "počet procesů spuštěných uživatelem"

#: login-utils/lslogins.c:252
msgid "Running processes"
msgstr "Spuštěné procesy"

# TODO: Plural
#: login-utils/lslogins.c:301 misc-utils/findmnt.c:136 misc-utils/lsblk.c:229
#: sys-utils/lsipc.c:204 sys-utils/lsmem.c:145
#, c-format
msgid "too many columns specified, the limit is %zu columns"
msgstr "zadáno příliš mnoho sloupců, omezení je %zu sloupců"

#: login-utils/lslogins.c:355 sys-utils/lsipc.c:467
msgid "unsupported time type"
msgstr "nepodporovaný typ času"

#: login-utils/lslogins.c:359
msgid "failed to compose time string"
msgstr "nezdařilo sestavit řetězec s časem"

#: login-utils/lslogins.c:759
msgid "failed to get supplementary groups"
msgstr "získání doplňkových skupin selhalo"

#: login-utils/lslogins.c:1045
#, c-format
msgid "cannot found '%s'"
msgstr "„%s“ nelze nalézt"

#: login-utils/lslogins.c:1221
msgid "internal error: unknown column"
msgstr "vnitřní chyba: neznámý sloupec"

#: login-utils/lslogins.c:1318
#, c-format
msgid ""
"\n"
"Last logs:\n"
msgstr ""
"\n"
"Poslední protokoly:\n"

#: login-utils/lslogins.c:1381
msgid "Display information about known users in the system.\n"
msgstr "Zobrazí údaje o známých uživatelích v systému.\n"

#: login-utils/lslogins.c:1384
msgid " -a, --acc-expiration     display info about passwords expiration\n"
msgstr " -a, --acc-expiration     zobrazí údaje o platnosti hesla\n"

#: login-utils/lslogins.c:1385
msgid " -c, --colon-separate     display data in a format similar to /etc/passwd\n"
msgstr " -c, --colon-separate     zobrazí údaje ve tvaru podobném /etc/passwd\n"

#: login-utils/lslogins.c:1386 sys-utils/lsipc.c:310
msgid " -e, --export             display in an export-able output format\n"
msgstr " -e, --export             zobrazí výstup v exportovatelném tvaru\n"

#: login-utils/lslogins.c:1387
msgid " -f, --failed             display data about the users' last failed logins\n"
msgstr " -f, --failed             zobrazí údaje o posledním chybném přihlášení uživatelů\n"

#: login-utils/lslogins.c:1388
msgid " -G, --supp-groups        display information about groups\n"
msgstr " -G, --supp-groups        zobrazí údaje o skupinách\n"

#: login-utils/lslogins.c:1389
msgid " -g, --groups=<groups>    display users belonging to a group in <groups>\n"
msgstr " -g, --groups=<skupiny>   zobrazí uživatele náležící do nějaké ze <skupin>\n"

#: login-utils/lslogins.c:1390
msgid " -L, --last               show info about the users' last login sessions\n"
msgstr " -L, --last               zobrazí poslední přihlašovací relace uživatelů\n"

#: login-utils/lslogins.c:1391
msgid " -l, --logins=<logins>    display only users from <logins>\n"
msgstr " -l, --logins=<jména>     zobrazí pouze uživatele s přihlašovacími <jmény>\n"

#: login-utils/lslogins.c:1392 sys-utils/lsipc.c:312
msgid " -n, --newline            display each piece of information on a new line\n"
msgstr " -n, --newline            zobrazí každý údaj na samostatném řádku\n"

#: login-utils/lslogins.c:1393 sys-utils/lsipc.c:305
msgid "     --noheadings         don't print headings\n"
msgstr "     --noheadings         nevypisuje záhlaví\n"

#: login-utils/lslogins.c:1394 sys-utils/lsipc.c:306
msgid "     --notruncate         don't truncate output\n"
msgstr "    --notruncate          nezkracuje výstup\n"

#: login-utils/lslogins.c:1395 sys-utils/lsipc.c:314
msgid " -o, --output[=<list>]    define the columns to output\n"
msgstr " -o, --output[=<seznam>]  určuje, které výstupní sloupce se použijí\n"

#: login-utils/lslogins.c:1396
msgid "     --output-all         output all columns\n"
msgstr "     --output-all         vypíše všechny sloupce\n"

# FIXME: Remove trailing period
#: login-utils/lslogins.c:1397
msgid " -p, --pwd                display information related to login by password.\n"
msgstr " -p, --pwd                zobrazí údaje související s přihlášením heslem\n"

#: login-utils/lslogins.c:1398 sys-utils/lsipc.c:316
msgid " -r, --raw                display in raw mode\n"
msgstr " -r, --raw                zobrazí v neopracované podobě\n"

#: login-utils/lslogins.c:1399
msgid " -s, --system-accs        display system accounts\n"
msgstr " -s, --system-accs        zobrazí systémové účty\n"

#: login-utils/lslogins.c:1400 sys-utils/lsipc.c:307
msgid "     --time-format=<type> display dates in short, full or iso format\n"
msgstr ""
"     --time-format=<formát>  zobrazí časové údaje podle daného formátu:\n"
"                             short (krátký), full (celý), iso (ISO)\n"

#: login-utils/lslogins.c:1401
msgid " -u, --user-accs          display user accounts\n"
msgstr " -u, --user-accs          zobrazí uživatelské účty\n"

#: login-utils/lslogins.c:1402
msgid " -Z, --context            display SELinux contexts\n"
msgstr " -Z, --context            zobrazí selinuxové kontexty\n"

#: login-utils/lslogins.c:1403
msgid " -z, --print0             delimit user entries with a nul character\n"
msgstr " -z, --print0             oddělí záznamy s uživateli nulovým znakem\n"

#: login-utils/lslogins.c:1404
msgid "     --wtmp-file <path>   set an alternate path for wtmp\n"
msgstr "     --wtmp-file <cesta>  nastaví jinou cestu k wtmp\n"

#: login-utils/lslogins.c:1405
msgid "     --btmp-file <path>   set an alternate path for btmp\n"
msgstr "     --btmp-file <cesta>  nastaví jinou cestu k btmp\n"

#: login-utils/lslogins.c:1406
#, fuzzy
msgid "     --lastlog <path>     set an alternate path for lastlog\n"
msgstr "     --wtmp-file <cesta>  nastaví jinou cestu k wtmp\n"

#: login-utils/lslogins.c:1595
msgid "failed to request selinux state"
msgstr "nepodařilo se vyžádat stav SELinuxu"

#: login-utils/lslogins.c:1609 login-utils/lslogins.c:1614
msgid "Only one user may be specified. Use -l for multiple users."
msgstr "Lze zadat pouze jednoho uživatele. Pro více uživatelů použijte -l."

#: login-utils/newgrp.c:49 login-utils/newgrp.c:55
msgid "could not set terminal attributes"
msgstr "nebylo možné nastavit vlastnosti terminálu"

#: login-utils/newgrp.c:57
msgid "getline() failed"
msgstr "funkce getline() selhala"

#: login-utils/newgrp.c:150
msgid "Password: "
msgstr "Heslo: "

#: login-utils/newgrp.c:160 login-utils/sulogin.c:997
msgid "crypt failed"
msgstr "volání crypt selhalo"

#: login-utils/newgrp.c:173
#, c-format
msgid " %s <group>\n"
msgstr " %s <skupina>\n"

#: login-utils/newgrp.c:176
msgid "Log in to a new group.\n"
msgstr "Přihlásí do nové skupiny.\n"

#: login-utils/newgrp.c:212
msgid "who are you?"
msgstr "Kdo jste?"

#: login-utils/newgrp.c:216 login-utils/newgrp.c:228 sys-utils/nsenter.c:482
#: sys-utils/unshare.c:663 text-utils/more.c:1256
msgid "setgid failed"
msgstr "volání setgid selhalo"

#: login-utils/newgrp.c:221 login-utils/newgrp.c:223
msgid "no such group"
msgstr "žádná taková skupina neexistuje"

#: login-utils/newgrp.c:232 sys-utils/nsenter.c:484 sys-utils/unshare.c:666
#: text-utils/more.c:1254
msgid "setuid failed"
msgstr "volání setuid selhalo"

#: login-utils/nologin.c:27 misc-utils/lslocks.c:528 misc-utils/mcookie.c:83
#: misc-utils/uuidd.c:62 misc-utils/uuidgen.c:26 sys-utils/dmesg.c:269
#: sys-utils/ipcmk.c:67 sys-utils/irqtop.c:217 sys-utils/lscpu.c:2261
#: sys-utils/lsipc.c:291 sys-utils/lsirq.c:57 sys-utils/lsmem.c:506
#: sys-utils/readprofile.c:104 sys-utils/rtcwake.c:99
#: term-utils/scriptlive.c:57 term-utils/scriptreplay.c:46
#: term-utils/setterm.c:381 text-utils/line.c:31
#, c-format
msgid " %s [options]\n"
msgstr " %s [přepínač]\n"

#: login-utils/nologin.c:30
msgid "Politely refuse a login.\n"
msgstr "Zdvořile odmítne přihlášení.\n"

#: login-utils/nologin.c:33
msgid " -c, --command <command>  does nothing (for compatibility with su -c)\n"
msgstr " -c  --command <příkaz>   nedělá nic (kvůli kompatibilitě s su -c)\n"

#: login-utils/nologin.c:113
#, c-format
msgid "This account is currently not available.\n"
msgstr "Tento účet není nyní dostupný.\n"

#: login-utils/su-common.c:227
msgid " (core dumped)"
msgstr " (výpis paměti uložen)"

#: login-utils/su-common.c:349
msgid "failed to modify environment"
msgstr "nepodařilo se změnit prostředí"

#: login-utils/su-common.c:385
msgid "may not be used by non-root users"
msgstr "nelze použít nesuperuživatelem"

#: login-utils/su-common.c:409
msgid "authentication failed"
msgstr "autentizace selhala"

#: login-utils/su-common.c:422
#, c-format
msgid "cannot open session: %s"
msgstr "relaci nelze otevřít: %s"

#: login-utils/su-common.c:441
msgid "cannot block signals"
msgstr "signály nelze zablokovat"

#: login-utils/su-common.c:458
msgid "cannot initialize signal mask for session"
msgstr "nelze inicializovat masku signálů pro relaci"

#: login-utils/su-common.c:466
msgid "cannot initialize signal mask"
msgstr "nelze inicializovat masku signálů"

#: login-utils/su-common.c:476
msgid "cannot set signal handler for session"
msgstr "obsluhu signálu pro relaci nelze nastavit"

#: login-utils/su-common.c:484 misc-utils/uuidd.c:401 sys-utils/lscpu.c:889
msgid "cannot set signal handler"
msgstr "obsluhu signálu nelze nastavit"

#: login-utils/su-common.c:492
msgid "cannot set signal mask"
msgstr "masku signálů nelze nastavit"

#: login-utils/su-common.c:517 term-utils/script.c:949
#: term-utils/scriptlive.c:296
msgid "failed to create pseudo-terminal"
msgstr "vytvoření pseudoterminálu selhalo"

#: login-utils/su-common.c:529 term-utils/script.c:959
#: term-utils/scriptlive.c:303
msgid "cannot create child process"
msgstr "nelze vytvořit proces pro potomka"

#: login-utils/su-common.c:548
#, c-format
msgid "cannot change directory to %s"
msgstr "nelze přejít do adresáře %s"

#: login-utils/su-common.c:575 term-utils/scriptlive.c:352
#, c-format
msgid ""
"\n"
"Session terminated, killing shell..."
msgstr ""
"\n"
"Relace ukončena, shell bude zabit…"

#: login-utils/su-common.c:586
#, c-format
msgid " ...killed.\n"
msgstr " …zabit.\n"

#: login-utils/su-common.c:683
msgid "failed to set the PATH environment variable"
msgstr "nepodařilo se nastavit proměnnou prostředí PATH"

#: login-utils/su-common.c:760
msgid "cannot set groups"
msgstr "skupiny nelze nastavit"

#: login-utils/su-common.c:766
#, c-format
msgid "failed to establish user credentials: %s"
msgstr "nezdařilo se získat oprávnění uživatele: %s"

#: login-utils/su-common.c:776 sys-utils/eject.c:660
msgid "cannot set group id"
msgstr "číslo skupiny (GID) nelze nastavit"

#: login-utils/su-common.c:778 sys-utils/eject.c:663
msgid "cannot set user id"
msgstr "číslo uživatele (UID) nelze nastavit"

#: login-utils/su-common.c:846
msgid " -m, -p, --preserve-environment      do not reset environment variables\n"
msgstr " -m, -p, --preserve-environment      neresetuje proměnné prostředí\n"

#: login-utils/su-common.c:847
msgid " -w, --whitelist-environment <list>  don't reset specified variables\n"
msgstr " -w, --whitelist-environment <seznam> neresetuje zadané proměnné\n"

#: login-utils/su-common.c:850
msgid " -g, --group <group>             specify the primary group\n"
msgstr " -g, --group <skupina>           určuje hlavní skupinu\n"

#: login-utils/su-common.c:851
msgid " -G, --supp-group <group>        specify a supplemental group\n"
msgstr " -G, --supp-group <skupina>      určuje doplňkovou skupinu\n"

#: login-utils/su-common.c:854
msgid " -, -l, --login                  make the shell a login shell\n"
msgstr " -, -l, --login                  učiní shell přihlašovacím shellem\n"

#: login-utils/su-common.c:855
msgid " -c, --command <command>         pass a single command to the shell with -c\n"
msgstr " -c  --command <příkaz>          předá jediný příkaz shellu přes -c\n"

#: login-utils/su-common.c:856
msgid ""
" --session-command <command>     pass a single command to the shell with -c\n"
"                                   and do not create a new session\n"
msgstr ""
" --session-command <příkaz>      předá jediný příkaz shellu přes -c\n"
"                                 a nevytvoří novou relaci\n"

#: login-utils/su-common.c:858
msgid " -f, --fast                      pass -f to the shell (for csh or tcsh)\n"
msgstr " -f, --fast                      předá shellu -f (pro csh nebo tcsh)\n"

#: login-utils/su-common.c:859
msgid " -s, --shell <shell>             run <shell> if /etc/shells allows it\n"
msgstr " -s, --shell <shell>             spustí <shell>, pokud jej /etc/shells dovoluje\n"

#: login-utils/su-common.c:860
msgid " -P, --pty                       create a new pseudo-terminal\n"
msgstr " -P, --pty                       vytvoří nový pseudoterminál\n"

#: login-utils/su-common.c:870
#, c-format
msgid ""
" %1$s [options] -u <user> [[--] <command>]\n"
" %1$s [options] [-] [<user> [<argument>...]]\n"
msgstr ""
" %1$s [přepínače] -u <uživatel> [[--] <příkaz>]\n"
" %1$s [přepínače] [-] [<uživatel> [<argument>…]]\n"

#: login-utils/su-common.c:875
msgid ""
"Run <command> with the effective user ID and group ID of <user>.  If -u is\n"
"not given, fall back to su(1)-compatible semantics and execute standard shell.\n"
"The options -c, -f, -l, and -s are mutually exclusive with -u.\n"
msgstr ""
"Spustí <příkaz> s efektivním ID <uživatele> a jeho skupiny. Není-li zadáno -u,\n"
"přejde se do režimu kompatibilního s su(1) a spustí standardní shell.\n"
"Přepínače -c, -f, -l a -s se vzájemně vylučují s přepínačem -u.\n"

#: login-utils/su-common.c:880
msgid " -u, --user <user>               username\n"
msgstr " -u, --user <uživatel>           jméno uživatele\n"

#: login-utils/su-common.c:891
#, c-format
msgid " %s [options] [-] [<user> [<argument>...]]\n"
msgstr " %s [přepínače] [-] [<uživatel> [argument…]]\n"

#: login-utils/su-common.c:895
msgid ""
"Change the effective user ID and group ID to that of <user>.\n"
"A mere - implies -l.  If <user> is not given, root is assumed.\n"
msgstr ""
"Změní efektivní ID uživatele a skupiny na ID daného <uživatele>.\n"
"Samotné „-“ znamená též „-l“. Není-li <uživatel> zadán, předpokládá se root.\n"

#: login-utils/su-common.c:943
#, c-format
msgid "specifying more than %d supplemental group is not possible"
msgid_plural "specifying more than %d supplemental groups is not possible"
msgstr[0] "nelze zadat více jak %d doplňkovou skupinu"
msgstr[1] "nelze zadat více jak %d doplňkové skupiny"
msgstr[2] "nelze zadat více jak %d doplňkových skupin"

#: login-utils/su-common.c:949
#, c-format
msgid "group %s does not exist"
msgstr "skupina %s neexistuje"

#: login-utils/su-common.c:1058
msgid "--pty is not supported for your system"
msgstr "přepínač --pty není na vašem systému podporován"

#: login-utils/su-common.c:1092
msgid "ignoring --preserve-environment, it's mutually exclusive with --login"
msgstr "ignoruje se --preserve-environment, vzájemně se vylučuje s přepínačem --login"

#: login-utils/su-common.c:1106
msgid "options --{shell,fast,command,session-command,login} and --user are mutually exclusive"
msgstr "přepínače --{shell,fast,command,session-command,login} a --user se vzájemně vylučují"

#: login-utils/su-common.c:1109
msgid "no command was specified"
msgstr "nezadán žádný příkaz"

#: login-utils/su-common.c:1121
msgid "only root can specify alternative groups"
msgstr "pouze superuživatel může určit náhradní skupiny"

#: login-utils/su-common.c:1132
#, c-format
msgid "user %s does not exist or the user entry does not contain all the required fields"
msgstr "uživatel %s neexistuje nebo záznam s uživatelem neobsahuje všechny potřebné položky"

#: login-utils/su-common.c:1167
#, c-format
msgid "using restricted shell %s"
msgstr "použije se omezený shell %s"

#: login-utils/su-common.c:1186
msgid "failed to allocate pty handler"
msgstr "alokace deskriptoru PTY selhala"

#: login-utils/su-common.c:1208
#, c-format
msgid "warning: cannot change directory to %s"
msgstr "pozor: nelze přejít do adresáře %s"

#: login-utils/sulogin.c:130
msgid "tcgetattr failed"
msgstr "funkce tcgetattr selhala"

#: login-utils/sulogin.c:208
msgid "tcsetattr failed"
msgstr "funkce tcsetattr selhala"

#: login-utils/sulogin.c:470
#, c-format
msgid "%s: no entry for root\n"
msgstr "%s: root nemá žádný záznam\n"

#: login-utils/sulogin.c:497
#, c-format
msgid "%s: no entry for root"
msgstr "%s: root nemá žádný záznam"

#: login-utils/sulogin.c:502
#, c-format
msgid "%s: root password garbled"
msgstr "%s: heslo uživatele root je poškozeno"

#: login-utils/sulogin.c:531
#, c-format
msgid ""
"\n"
"Cannot open access to console, the root account is locked.\n"
"See sulogin(8) man page for more details.\n"
"\n"
"Press Enter to continue.\n"
msgstr ""
"\n"
"Přístup ke konzole nelze získat, účet roota je uzamčen.\n"
"Podrobnosti naleznete v manuálové stránce sulogin(8).\n"
"\n"
"Pro pokračování stiskněte Enter.\n"

#: login-utils/sulogin.c:537
#, c-format
msgid "Give root password for login: "
msgstr "Pro přihlášení je třeba zadat heslo uživatele root: "

#: login-utils/sulogin.c:539
#, c-format
msgid "Press Enter for login: "
msgstr "Pro přihlášení stiskněte Enter: "

#: login-utils/sulogin.c:542
#, c-format
msgid "Give root password for maintenance\n"
msgstr "Pro zahájení údržby je třeba zadat heslo uživatele root\n"

#: login-utils/sulogin.c:544
#, c-format
msgid "Press Enter for maintenance\n"
msgstr "Pro zahájení údržby stiskněte Enter\n"

#: login-utils/sulogin.c:545
#, c-format
msgid "(or press Control-D to continue): "
msgstr "(nebo stiskněte Control-D, abyste pokračovali): "

#: login-utils/sulogin.c:735
msgid "change directory to system root failed"
msgstr "nepodařilo se přejít do kořenového adresáře"

#: login-utils/sulogin.c:784
msgid "setexeccon failed"
msgstr "funkce setexeccon selhala"

#: login-utils/sulogin.c:805
#, c-format
msgid " %s [options] [tty device]\n"
msgstr " %s [přepínače] <zařízení TTY>\n"

#: login-utils/sulogin.c:808
msgid "Single-user login.\n"
msgstr "Přihlášení v režimu jediného uživatele.\n"

#: login-utils/sulogin.c:811
msgid ""
" -p, --login-shell        start a login shell\n"
" -t, --timeout <seconds>  max time to wait for a password (default: no limit)\n"
" -e, --force              examine password files directly if getpwnam(3) fails\n"
msgstr ""
" -p, --login-shell        spustí login shell\n"
" -t, --timeout <sekundy>  maximální doba čekání na heslo (výchozí: žádný limit)\n"
" -e, --force              selže-li getpwnam(3), prozkoumá soubory s hesly přímo\n"

#: login-utils/sulogin.c:867 misc-utils/findmnt.c:1498 sys-utils/wdctl.c:640
#: term-utils/agetty.c:843 term-utils/wall.c:218
msgid "invalid timeout argument"
msgstr "neplatný argument přepínače --timeout"

#: login-utils/sulogin.c:886
msgid "only superuser can run this program"
msgstr "tento program může spouštět jen superuživatel"

#: login-utils/sulogin.c:929
msgid "cannot open console"
msgstr "nelze otevřít konzolu"

#: login-utils/sulogin.c:936
msgid "cannot open password database"
msgstr "databázi s hesly nelze otevřít"

#: login-utils/sulogin.c:1010
#, c-format
msgid ""
"cannot execute su shell\n"
"\n"
msgstr ""
"shell superuživatele nelze spustit\n"
"\n"

#: login-utils/sulogin.c:1017
msgid ""
"Timed out\n"
"\n"
msgstr ""
"Čas vypršel\n"
"\n"

#: login-utils/sulogin.c:1049
msgid ""
"cannot wait on su shell\n"
"\n"
msgstr ""
"nelze čekat na dokončení shellu superuživatele\n"
"\n"

#: login-utils/utmpdump.c:173
#, c-format
msgid "%s: cannot get file position"
msgstr "%s: pozici v souboru nelze zjistit"

#: login-utils/utmpdump.c:177
#, c-format
msgid "%s: cannot add inotify watch."
msgstr "%s: nelze přidat sledování pomocí inotify."

#: login-utils/utmpdump.c:186
#, c-format
msgid "%s: cannot read inotify events"
msgstr "%s: události inotify nelze přečíst"

#: login-utils/utmpdump.c:246 login-utils/utmpdump.c:251
msgid "Extraneous newline in file. Exiting."
msgstr "V souboru je přebytečný nový řádek. Končí se."

#: login-utils/utmpdump.c:305
#, c-format
msgid " %s [options] [filename]\n"
msgstr " %s [přepínače] [název_souboru]\n"

#: login-utils/utmpdump.c:308
msgid "Dump UTMP and WTMP files in raw format.\n"
msgstr "Vypíše soubory UTMP a WTMP v nezpracovaném formátu.\n"

#: login-utils/utmpdump.c:311
msgid " -f, --follow         output appended data as the file grows\n"
msgstr " -f, --follow         vypisuje data přidávaná to souboru\n"

#: login-utils/utmpdump.c:312
msgid " -r, --reverse        write back dumped data into utmp file\n"
msgstr " -r, --reverse        zapíše výpis zpět do utmp souboru\n"

#: login-utils/utmpdump.c:313
msgid " -o, --output <file>  write to file instead of standard output\n"
msgstr " -o, --output <soubor>                      zapíše do souboru místo na standardní výstup\n"

#: login-utils/utmpdump.c:377
msgid "following standard input is unsupported"
msgstr "sledování standardního vstupu není podporováno"

#: login-utils/utmpdump.c:383
#, c-format
msgid "Utmp undump of %s\n"
msgstr "Zpětný zápis utmp výpisu %s\n"

#: login-utils/utmpdump.c:386
#, c-format
msgid "Utmp dump of %s\n"
msgstr "Utmp výpis %s\n"

#: login-utils/vipw.c:145
msgid "can't open temporary file"
msgstr "dočasný soubor nelze otevřít"

#: login-utils/vipw.c:161
#, c-format
msgid "%s: create a link to %s failed"
msgstr "%s: nelze vytvořit odkaz na %s"

#: login-utils/vipw.c:168
#, c-format
msgid "Can't get context for %s"
msgstr "Nelze zjistit kontext pro %s"

#: login-utils/vipw.c:174
#, c-format
msgid "Can't set context for %s"
msgstr "Nelze nastavit kontext pro %s"

#: login-utils/vipw.c:239
#, c-format
msgid "%s unchanged"
msgstr "%s nezměněno"

#: login-utils/vipw.c:257
msgid "cannot get lock"
msgstr "zámek nelze získat"

#: login-utils/vipw.c:284
msgid "no changes made"
msgstr "neprovedeny žádné změny"

#: login-utils/vipw.c:293
msgid "cannot chmod file"
msgstr "souboru nelze změnit práva"

#: login-utils/vipw.c:308
msgid "Edit the password or group file.\n"
msgstr "Edituje soubor s hesly nebo skupinami.\n"

#: login-utils/vipw.c:360
msgid "You are using shadow groups on this system.\n"
msgstr "Tento systém používá stínové skupiny.\n"

#: login-utils/vipw.c:361
msgid "You are using shadow passwords on this system.\n"
msgstr "Tento systém používá stínová hesla.\n"

#. TRANSLATORS: this program uses for y and n rpmatch(3),
#. * which means they can be translated.
#: login-utils/vipw.c:365
#, c-format
msgid "Would you like to edit %s now [y/n]? "
msgstr "Chcete teď editovat soubor %s [a/n]? "

#: misc-utils/blkid.c:70
#, c-format
msgid ""
" %s --label <label> | --uuid <uuid>\n"
"\n"
msgstr ""
" %s --label <jmenovka> | --uuid <UUID>\n"
"\n"

#: misc-utils/blkid.c:71
#, c-format
msgid ""
" %s [--cache-file <file>] [-ghlLv] [--output <format>] [--match-tag <tag>] \n"
"       [--match-token <token>] [<dev> ...]\n"
"\n"
msgstr ""
" %s [--cache-file <soubor>] [-ghlLv] [--output <formát>] [--match-tag <značka>] \n"
"       [--match-token <token>] [<zařízení> …]\n"
"\n"

#: misc-utils/blkid.c:73
#, c-format
msgid ""
" %s -p [--match-tag <tag>] [--offset <offset>] [--size <size>] \n"
"       [--output <format>] <dev> ...\n"
"\n"
msgstr ""
" %s -p [--match-tag <značka>] [--offset <posun>] [--size <velikost>] \n"
"       [--output <formát>] <zařízení> …\n"
"\n"

#: misc-utils/blkid.c:75
#, c-format
msgid " %s -i [--match-tag <tag>] [--output <format>] <dev> ...\n"
msgstr " %s -i [--match-tag <značka>] [--output <formát>] <zařízení> …\n"

#: misc-utils/blkid.c:77
msgid ""
" -c, --cache-file <file>    read from <file> instead of reading from the default\n"
"                              cache file (-c /dev/null means no cache)\n"
msgstr ""
" -c, --cache-file <soubor>  čte ze <souboru> místo z výchozího souboru s keší\n"
"                            (-c /dev/null znamená žádnou keš)\n"

#: misc-utils/blkid.c:79
msgid " -d, --no-encoding          don't encode non-printing characters\n"
msgstr " -d, --no-encoding          nekóduje netisknutelné znaky\n"

#: misc-utils/blkid.c:80
msgid " -g, --garbage-collect      garbage collect the blkid cache\n"
msgstr " -g, --garbage-collect      uklidí keš identifikátorů blokových zařízení\n"

#: misc-utils/blkid.c:81
msgid ""
" -o, --output <format>      output format; can be one of:\n"
"                              value, device, export or full; (default: full)\n"
msgstr ""
" -o, --output <formát>      výstupní formát, jeden z:\n"
"                            value (hodnota), device (zařízení), export nebo\n"
"                            full (plný); (výchozí je full)\n"

#: misc-utils/blkid.c:83
msgid " -k, --list-filesystems     list all known filesystems/RAIDs and exit\n"
msgstr ""
" -k, --list-filesystems     vypíše všechny známé souborové systémy a disková\n"
"                            pole a skončí\n"

#: misc-utils/blkid.c:84
msgid " -s, --match-tag <tag>      show specified tag(s) (default show all tags)\n"
msgstr " -s, --match-tag <značka>   ukáže zadané značky (výchozí je všechny značky)\n"

#: misc-utils/blkid.c:85
msgid " -t, --match-token <token>  find device with a specific token (NAME=value pair)\n"
msgstr ""
" -t, --match-token <token>  najde zařízení se zadaným tokenem (dvojice\n"
"                            NÁZEV=hodnota)\n"

#: misc-utils/blkid.c:86
msgid " -l, --list-one             look up only first device with token specified by -t\n"
msgstr " -l, --list-one             vyhledá pouze první zařízení s tokenem uvedeným v -t\n"

#: misc-utils/blkid.c:87
msgid " -L, --label <label>        convert LABEL to device name\n"
msgstr " -L, --label <jmenovka>     převede jmenovku na název zařízení\n"

#: misc-utils/blkid.c:88
msgid " -U, --uuid <uuid>          convert UUID to device name\n"
msgstr " -U, --uuid <UUID>          převede UUID na název zařízení\n"

#: misc-utils/blkid.c:90
msgid "Low-level probing options:\n"
msgstr "Přepínače nízkoúrovňových zkoušek:\n"

#: misc-utils/blkid.c:91
msgid " -p, --probe                low-level superblocks probing (bypass cache)\n"
msgstr " -p, --probe                nízkoúrovňové testy superbloků (obejde keš)\n"

#: misc-utils/blkid.c:92
msgid " -i, --info                 gather information about I/O limits\n"
msgstr " -i, --info                 posbírá údaje o omezeních I/O\n"

#: misc-utils/blkid.c:93
msgid " -S, --size <size>          overwrite device size\n"
msgstr " -S, --size <velikost>      přepíše velikost zařízení\n"

#: misc-utils/blkid.c:94
msgid " -O, --offset <offset>      probe at the given offset\n"
msgstr " -O, --offset <posun>       zkouší na zadané pozici\n"

#: misc-utils/blkid.c:95
msgid " -u, --usages <list>        filter by \"usage\" (e.g. -u filesystem,raid)\n"
msgstr " -u, --usages <seznam>      omezí podle „použití“ (např. -u filesystem,raid)\n"

#: misc-utils/blkid.c:96
msgid " -n, --match-types <list>   filter by filesystem type (e.g. -n vfat,ext3)\n"
msgstr ""
" -n, --match-types <seznam>\n"
"                            omezí druhu souborového systému (např. -n vfat,ext3)\n"

#: misc-utils/blkid.c:97
msgid " -D, --no-part-details      don't print info from partition table\n"
msgstr " -D, --no-part-details      nevypisuje údaje z tabulky rozdělení disku\n"

#: misc-utils/blkid.c:103
msgid "<size> and <offset>"
msgstr ""

#: misc-utils/blkid.c:105
#, fuzzy
msgid " <dev> specify device(s) to probe (default: all devices)\n"
msgstr " <zařízení>                 určuje zkoušené zařízení (výchozí: všechna zařízení)\n"

#: misc-utils/blkid.c:237
msgid "(mounted, mtpt unknown)"
msgstr "(připojeno, bod připojení neznám)"

#: misc-utils/blkid.c:239
msgid "(in use)"
msgstr "(používá se)"

#: misc-utils/blkid.c:241
msgid "(not mounted)"
msgstr "(nepřipojeno)"

#: misc-utils/blkid.c:509 misc-utils/blkid.c:515
#, c-format
msgid "error: %s"
msgstr "chyba: %s"

#: misc-utils/blkid.c:558
#, c-format
msgid "%s: ambivalent result (probably more filesystems on the device, use wipefs(8) to see more details)"
msgstr "%s: rozporuplné výsledky (snad více souborových systému na zařízení, pro podrobnosti použijte wipefs(8))"

#: misc-utils/blkid.c:604
#, c-format
msgid "unknown keyword in -u <list> argument: '%s'"
msgstr "neznámé klíčové slovo v argument -u <seznam>: „%s“"

#: misc-utils/blkid.c:621
msgid "error: -u <list> argument is empty"
msgstr "chyba: argument -u <seznam> je prázdný"

#: misc-utils/blkid.c:770
#, c-format
msgid "unsupported output format %s"
msgstr "nepodporovaný formát výstupu %s"

#: misc-utils/blkid.c:773 misc-utils/wipefs.c:748
msgid "invalid offset argument"
msgstr "neplatný argument přepínače --offset"

#: misc-utils/blkid.c:780
msgid "Too many tags specified"
msgstr "Zadáno příliš mnoho značek"

#: misc-utils/blkid.c:786
msgid "invalid size argument"
msgstr "neplatný argument velikosti"

#: misc-utils/blkid.c:790
msgid "Can only search for one NAME=value pair"
msgstr "Hledat lze pouze jednu dvojici NÁZEV=hodnota"

#: misc-utils/blkid.c:797
msgid "-t needs NAME=value pair"
msgstr "přepínač -t potřebuje dvojici NÁZEV=hodnota"

#: misc-utils/blkid.c:803
#, c-format
msgid "%s from %s  (libblkid %s, %s)\n"
msgstr "%s z %s (libblkid %s, %s)\n"

#: misc-utils/blkid.c:849
msgid "The low-level probing mode does not support 'list' output format"
msgstr "Nízkoúrovňový zkušební režim nepodporuje výstupní formát „list“"

#: misc-utils/blkid.c:862
msgid "The low-level probing mode requires a device"
msgstr "Nízkoúrovňový zkušební režim vyžaduje zařízení"

#: misc-utils/blkid.c:912
msgid "The lookup option requires a search type specified using -t"
msgstr "Volba vyhledání vyžaduje druh k hledání zadaný pomocí přepínače -t"

#: misc-utils/cal.c:418
msgid "invalid month argument"
msgstr "neplatný argument měsíce"

#: misc-utils/cal.c:426
msgid "invalid week argument"
msgstr "neplatný argument týdne"

#: misc-utils/cal.c:428
msgid "illegal week value: use 1-54"
msgstr "zakázaná hodnota pro týden: použijte 1–54"

#: misc-utils/cal.c:480
#, c-format
msgid "failed to parse timestamp or unknown month name: %s"
msgstr "nezdařilo se rozebrat časový údaj nebo neznámý název měsíce: %s"

#: misc-utils/cal.c:489
msgid "illegal day value"
msgstr "zakázaná hodnota pro den"

#: misc-utils/cal.c:491 misc-utils/cal.c:515
#, c-format
msgid "illegal day value: use 1-%d"
msgstr "zakázaná hodnota pro den: použijte 1–%d"

#: misc-utils/cal.c:495 misc-utils/cal.c:503
msgid "illegal month value: use 1-12"
msgstr "zakázaná hodnota pro měsíc: použijte 1–12"

#: misc-utils/cal.c:499
#, c-format
msgid "unknown month name: %s"
msgstr "neznámý název měsíce: %s"

#: misc-utils/cal.c:506 misc-utils/cal.c:510
msgid "illegal year value"
msgstr "zakázaná hodnota pro rok"

#: misc-utils/cal.c:508
msgid "illegal year value: use positive integer"
msgstr "zakázaná hodnota pro rok: použijte kladné celé číslo"

#: misc-utils/cal.c:544 misc-utils/cal.c:557
#, c-format
msgid "illegal week value: year %d doesn't have week %d"
msgstr "zakázaná hodnota pro týden: rok %d nemá týden %d"

#: misc-utils/cal.c:1283
#, c-format
msgid " %s [options] [[[day] month] year]\n"
msgstr " %s [přepínače] [[[den] měsíc] rok]\n"

#: misc-utils/cal.c:1284
#, c-format
msgid " %s [options] <timestamp|monthname>\n"
msgstr " %s [přepínače] <časový_údaj|název_měsíce>\n"

#: misc-utils/cal.c:1287
msgid "Display a calendar, or some part of it.\n"
msgstr "Zobrazí kalendář nebo jeho část.\n"

#: misc-utils/cal.c:1288
msgid "Without any arguments, display the current month.\n"
msgstr "Bez argumentů zobrazí současný měsíc.\n"

#: misc-utils/cal.c:1291
msgid " -1, --one             show only a single month (default)\n"
msgstr " -1, --one             zobrazí pouze jeden měsíc (výchozí)\n"

#: misc-utils/cal.c:1292
msgid " -3, --three           show three months spanning the date\n"
msgstr " -3, --three           zobrazí tři měsíce\n"

#: misc-utils/cal.c:1293
msgid " -n, --months <num>    show num months starting with date's month\n"
msgstr " -n, --month <počet>   zobrazí počet měsíců počínaje zadaným datem\n"

#: misc-utils/cal.c:1294
msgid " -S, --span            span the date when displaying multiple months\n"
msgstr " -S, --span            při více měsících zobrazí okolí\n"

#: misc-utils/cal.c:1295
msgid " -s, --sunday          Sunday as first day of week\n"
msgstr " -s, --sunday          neděle jako první den týdne\n"

#: misc-utils/cal.c:1296
msgid " -m, --monday          Monday as first day of week\n"
msgstr " -m, --monday          pondělí jako první den týdne\n"

#: misc-utils/cal.c:1297
msgid " -j, --julian          use day-of-year for all calendars\n"
msgstr " -j, --julian          vypíše den v roce ve všech kalendářích\n"

#: misc-utils/cal.c:1298
msgid "     --reform <val>    Gregorian reform date (1752|gregorian|iso|julian)\n"
msgstr ""
"     --reform <hodnota>\n"
"                      Datum gregoriánské reformy (1752|gregorian|iso|julian)\n"

#: misc-utils/cal.c:1299
msgid "     --iso             alias for --reform=iso\n"
msgstr "     --iso             stejné jako --reform=iso\n"

#: misc-utils/cal.c:1300
msgid " -y, --year            show the whole year\n"
msgstr " -y, --year            zobrazí celý rok\n"

#: misc-utils/cal.c:1301
msgid " -Y, --twelve          show the next twelve months\n"
msgstr " -T, --twelve          zobrazí dalších dvanáct měsíců\n"

#: misc-utils/cal.c:1302
msgid " -w, --week[=<num>]    show US or ISO-8601 week numbers\n"
msgstr " -w, --week[=<číslo>]  zobrazí americká nebo ISO-8601 čísla týdnů\n"

#: misc-utils/cal.c:1303
#, fuzzy
msgid " -v, --vertical        show day vertically instead of line\n"
msgstr " -y, --physical          vypíše fyzické identifikátory namísto logických\n"

#: misc-utils/cal.c:1305
#, c-format
msgid "     --color[=<when>]  colorize messages (%s, %s or %s)\n"
msgstr "     --color[=<kdy>]   obarví zprávy (%s, %s nebo %s)\n"

#: misc-utils/fincore.c:61
msgid "file data resident in memory in pages"
msgstr "data souborů nacházející se v paměti ve stránkách"

#: misc-utils/fincore.c:62
msgid "file data resident in memory in bytes"
msgstr "data souborů nacházející se v paměti v bajtech"

#: misc-utils/fincore.c:63
msgid "size of the file"
msgstr "velikost souboru"

#: misc-utils/fincore.c:64
msgid "file name"
msgstr "název souboru"

#: misc-utils/fincore.c:174
#, c-format
msgid "failed to do mincore: %s"
msgstr "volání mincore selhalo: %s"

#: misc-utils/fincore.c:210
#, c-format
msgid "failed to do mmap: %s"
msgstr "volání mmap selhalo: %s"

#: misc-utils/fincore.c:236
#, c-format
msgid "failed to open: %s"
msgstr "nepodařilo se otevřít: %s"

#: misc-utils/fincore.c:241
#, c-format
msgid "failed to do fstat: %s"
msgstr "volání fstat selhalo: %s"

#: misc-utils/fincore.c:262
#, c-format
msgid " %s [options] file...\n"
msgstr " %s [přepínače] [soubor…]\n"

#: misc-utils/fincore.c:265
msgid " -J, --json            use JSON output format\n"
msgstr " -J, --json            výstup formátuje do JSONu\n"

#: misc-utils/fincore.c:266
msgid " -b, --bytes           print sizes in bytes rather than in human readable format\n"
msgstr ""
" -b, --bytes           velikosti vypisuje v bajtech namísto v podobě\n"
"                       vhodné pro člověka\n"

#: misc-utils/fincore.c:267
msgid " -n, --noheadings      don't print headings\n"
msgstr " -n, --noheadings      nevypíše záhlaví\n"

#: misc-utils/fincore.c:268
msgid " -o, --output <list>   output columns\n"
msgstr ""
" -o, --output <seznam>\n"
"                       zobrazí zadané sloupce\n"

#: misc-utils/fincore.c:269
msgid " -r, --raw             use raw output format\n"
msgstr " -r, --raw             neformátovaný výstup\n"

#: misc-utils/fincore.c:338 sys-utils/losetup.c:820
msgid "no file specified"
msgstr "nezadán žádný soubor"

#: misc-utils/findfs.c:28
#, c-format
msgid " %s [options] {LABEL,UUID,PARTUUID,PARTLABEL}=<value>\n"
msgstr " %s [přepínače] {LABEL,UUID,PARTUUID,PARTLABEL}=<hodnota>\n"

#: misc-utils/findfs.c:32
msgid "Find a filesystem by label or UUID.\n"
msgstr "Najde systému souborů podle názvu nebo UUID.\n"

#: misc-utils/findfs.c:74
#, c-format
msgid "unable to resolve '%s'"
msgstr "„%s“ nelze přeložit"

#: misc-utils/findmnt.c:99
msgid "source device"
msgstr "zdrojové zařízení"

#: misc-utils/findmnt.c:100
msgid "mountpoint"
msgstr "bod připojení"

#: misc-utils/findmnt.c:101 misc-utils/lsblk.c:161
msgid "filesystem type"
msgstr "druh systému souborů"

#: misc-utils/findmnt.c:102
msgid "all mount options"
msgstr "všechny volby připojení"

#: misc-utils/findmnt.c:103
msgid "VFS specific mount options"
msgstr "volby připojení určené pro virtuální souborový systém"

#: misc-utils/findmnt.c:104
msgid "FS specific mount options"
msgstr "volby připojení určené pro souborový systém"

#: misc-utils/findmnt.c:105
msgid "filesystem label"
msgstr "jmenovka souborového systému"

#: misc-utils/findmnt.c:106 misc-utils/lsblk.c:168
msgid "filesystem UUID"
msgstr "UUID souborového systému"

#: misc-utils/findmnt.c:107
msgid "partition label"
msgstr "jmenovka oddílu"

#: misc-utils/findmnt.c:109 misc-utils/lsblk.c:157
msgid "major:minor device number"
msgstr "hlavní:vedlejší číslo zařízení"

#: misc-utils/findmnt.c:110
msgid "action detected by --poll"
msgstr "akce zachycené pomocí --poll"

#: misc-utils/findmnt.c:111
msgid "old mount options saved by --poll"
msgstr "staré volby připojení uložené pomocí --poll"

#: misc-utils/findmnt.c:112
msgid "old mountpoint saved by --poll"
msgstr "starý bod připojení uložený pomocí --poll"

#: misc-utils/findmnt.c:113 misc-utils/lsblk.c:160
msgid "filesystem size"
msgstr "velikost systému souborů"

#: misc-utils/findmnt.c:114 misc-utils/lsblk.c:159
msgid "filesystem size available"
msgstr "velikost souborového systému je známa"

#: misc-utils/findmnt.c:115 misc-utils/lsblk.c:162
msgid "filesystem size used"
msgstr "použito z velikosti souborového systému"

#: misc-utils/findmnt.c:116 misc-utils/lsblk.c:163
msgid "filesystem use percentage"
msgstr "využití souborového systému v procentech"

#: misc-utils/findmnt.c:117
msgid "filesystem root"
msgstr "kořen souborového systému"

#: misc-utils/findmnt.c:118
msgid "task ID"
msgstr "ID úlohy"

# Název akce
#: misc-utils/findmnt.c:119
msgid "mount ID"
msgstr "ID připojení"

#: misc-utils/findmnt.c:120
msgid "optional mount fields"
msgstr "volitelné položky připojení"

#: misc-utils/findmnt.c:121
msgid "VFS propagation flags"
msgstr "příznaky propagace VFS"

#: misc-utils/findmnt.c:122
msgid "dump(8) period in days [fstab only]"
msgstr "perioda volání dump(8) ve dnech [pouze fstab]"

#: misc-utils/findmnt.c:123
msgid "pass number on parallel fsck(8) [fstab only]"
msgstr "číslo průchodu při paralelním fsck(8) [pouze fstab]"

#: misc-utils/findmnt.c:333
#, c-format
msgid "unknown action: %s"
msgstr "neznámá akce: %s"

# Název akce
#: misc-utils/findmnt.c:650
msgid "mount"
msgstr "připojení"

# Název akce
#: misc-utils/findmnt.c:653
msgid "umount"
msgstr "odpojení"

# Název akce
#: misc-utils/findmnt.c:656
msgid "remount"
msgstr "přepojení"

# Název akce
#: misc-utils/findmnt.c:659
msgid "move"
msgstr "přesun"

#: misc-utils/findmnt.c:823 misc-utils/findmnt.c:1093 sys-utils/eject.c:717
#: sys-utils/mount.c:369
msgid "failed to initialize libmount table"
msgstr "tabulku libmountu se nepodařilo inicializovat"

#: misc-utils/findmnt.c:850 text-utils/hexdump-parse.c:84
#, c-format
msgid "can't read %s"
msgstr "z %s nelze číst"

#: misc-utils/findmnt.c:1033 misc-utils/findmnt.c:1099
#: misc-utils/findmnt-verify.c:95 misc-utils/findmnt-verify.c:487
#: sys-utils/fstrim.c:287 sys-utils/mount.c:127 sys-utils/mount.c:175
#: sys-utils/mount.c:242 sys-utils/swapoff.c:63 sys-utils/swapoff.c:173
#: sys-utils/swapon.c:247 sys-utils/swapon.c:277 sys-utils/swapon.c:736
#: sys-utils/umount.c:187
msgid "failed to initialize libmount iterator"
msgstr "iterátor libmountu se nepodařilo inicializovat"

#: misc-utils/findmnt.c:1105
msgid "failed to initialize libmount tabdiff"
msgstr "tabdiff libmountu se nepodařilo inicializovat"

#: misc-utils/findmnt.c:1133 misc-utils/kill.c:407
msgid "poll() failed"
msgstr "volání poll() selhalo"

#: misc-utils/findmnt.c:1208
#, c-format
msgid ""
" %1$s [options]\n"
" %1$s [options] <device> | <mountpoint>\n"
" %1$s [options] <device> <mountpoint>\n"
" %1$s [options] [--source <device>] [--target <path> | --mountpoint <dir>]\n"
msgstr ""
" %1$s [volby]\n"
" %1$s [volby] <zařízení> | <bod_připojení>\n"
" %1$s [volby] <zařízení> <bod_připojení>\n"
" %1$s [volby] [--source <zařízení>] [--target <cesta> | --mountpoint <adresář>]\n"

#: misc-utils/findmnt.c:1215
msgid "Find a (mounted) filesystem.\n"
msgstr "Najde (připojený) souborový systém.\n"

#: misc-utils/findmnt.c:1218
msgid " -s, --fstab            search in static table of filesystems\n"
msgstr " -s, --fstab            hledá ve statické tabulce souborových systémů\n"

#: misc-utils/findmnt.c:1219
msgid ""
" -m, --mtab             search in table of mounted filesystems\n"
"                          (includes user space mount options)\n"
msgstr ""
" -m, --mtab             hledá v tabulce připojených souborových systémů\n"
"                        (zahrnuje volby připojení z uživatelského prostoru)\n"

#: misc-utils/findmnt.c:1221
msgid ""
" -k, --kernel           search in kernel table of mounted\n"
"                          filesystems (default)\n"
msgstr ""
" -k, --kernel           hledá v jaderné tabulce připojených souborových\n"
"                        systémů (výchozí)\n"

#: misc-utils/findmnt.c:1224
msgid " -p, --poll[=<list>]    monitor changes in table of mounted filesystems\n"
msgstr " -p, --poll[=<seznam>]  sleduje změny v tabulce připojených systémů\n"

#: misc-utils/findmnt.c:1225
msgid " -w, --timeout <num>    upper limit in milliseconds that --poll will block\n"
msgstr ""
" -w, --timeout <počet>  horní hranice v milisekundách, po kterou bude --poll\n"
"                        blokovat\n"

#: misc-utils/findmnt.c:1228
msgid " -A, --all              disable all built-in filters, print all filesystems\n"
msgstr ""
" -A, --all              zakáže všechny vestavěné filtry, vypíše všechny\n"
"                        souborové systémy\n"

#: misc-utils/findmnt.c:1229
msgid " -a, --ascii            use ASCII chars for tree formatting\n"
msgstr " -a, --ascii            strom vykreslí ze znaků ASCII\n"

#: misc-utils/findmnt.c:1230
msgid " -b, --bytes            print sizes in bytes rather than in human readable format\n"
msgstr ""
" -b, --bytes            velikosti vypisuje v bajtech namísto v podobě\n"
"                        vhodné pro člověka\n"

#: misc-utils/findmnt.c:1231
msgid " -C, --nocanonicalize   don't canonicalize when comparing paths\n"
msgstr " -C, --nocanonicalize   nenormalizuje cesty, když je porovnává\n"

#: misc-utils/findmnt.c:1232
msgid " -c, --canonicalize     canonicalize printed paths\n"
msgstr " -c, --canonicalize     normalizuje vypisované cesty\n"

#: misc-utils/findmnt.c:1233
msgid " -D, --df               imitate the output of df(1)\n"
msgstr " -D, --df               napodobí výstup df(1)\n"

#: misc-utils/findmnt.c:1234
msgid " -d, --direction <word> direction of search, 'forward' or 'backward'\n"
msgstr ""
" -d, --direction <směr> směr vyhledávání, „forward“ (vpřed) nebo\n"
"                        „backward“ (zpět)\n"

#: misc-utils/findmnt.c:1235
msgid ""
" -e, --evaluate         convert tags (LABEL,UUID,PARTUUID,PARTLABEL) \n"
"                          to device names\n"
msgstr ""
" -e, --evaluate         převede značky (LABEL, UUID, PARTUUID, PARTLABEL)\n"
"                        na názvy zařízení\n"

#: misc-utils/findmnt.c:1237
msgid " -F, --tab-file <path>  alternative file for -s, -m or -k options\n"
msgstr " -F, --tab-file <cesta> jiný soubor pro přepínače -s, -m a -k\n"

#: misc-utils/findmnt.c:1238
msgid " -f, --first-only       print the first found filesystem only\n"
msgstr " -f, --first-only       vypíše pouze první nalezený souborový systém\n"

#: misc-utils/findmnt.c:1239
msgid " -i, --invert           invert the sense of matching\n"
msgstr " -i, --invert           obrátí význam hledání shody\n"

#: misc-utils/findmnt.c:1240 misc-utils/lslocks.c:535 sys-utils/lsns.c:905
#: sys-utils/rfkill.c:581
msgid " -J, --json             use JSON output format\n"
msgstr " -J, --json             výstup formátuje do JSONu\n"

#: misc-utils/findmnt.c:1241 sys-utils/lsns.c:906
msgid " -l, --list             use list format output\n"
msgstr " -l, --list             výstup formátuje jako seznam\n"

#: misc-utils/findmnt.c:1242
msgid " -N, --task <tid>       use alternative namespace (/proc/<tid>/mountinfo file)\n"
msgstr ""
" -N, --task <TID>       použije jiný jmenný prostor (soubor\n"
"                        /proc/<TID>/mountinfo)\n"

#: misc-utils/findmnt.c:1243
msgid " -n, --noheadings       don't print column headings\n"
msgstr " -n, --noheadings       nevypíše záhlaví sloupců\n"

#: misc-utils/findmnt.c:1244
msgid " -O, --options <list>   limit the set of filesystems by mount options\n"
msgstr " -O, --options <seznam> omezí množinu souborových systémů podle voleb připojení\n"

#: misc-utils/findmnt.c:1245
msgid " -o, --output <list>    the output columns to be shown\n"
msgstr " -o, --output <seznam>  zobrazí dané sloupce\n"

#: misc-utils/findmnt.c:1246
msgid "     --output-all       output all available columns\n"
msgstr "     --output-all       vypíše všechny dostupné sloupce\n"

#: misc-utils/findmnt.c:1247
msgid " -P, --pairs            use key=\"value\" output format\n"
msgstr " -P, --pairs            výstup ve formátu klíč=\"hodnota\"\n"

#: misc-utils/findmnt.c:1248
msgid "     --pseudo           print only pseudo-filesystems\n"
msgstr "     --pseudo           vypíše více pseudosouborové systémy\n"

#: misc-utils/findmnt.c:1249
msgid " -R, --submounts        print all submounts for the matching filesystems\n"
msgstr ""
" -R, --submounts        vypíše všechna podřízená připojení\n"
"                        v odpovídajících souborových systémech\n"

#: misc-utils/findmnt.c:1250
msgid " -r, --raw              use raw output format\n"
msgstr " -r, --raw              neformátovaný výstup\n"

#: misc-utils/findmnt.c:1251
msgid "     --real             print only real filesystems\n"
msgstr "     --real             vypíše pouze skutečné souborové systémy\n"

#: misc-utils/findmnt.c:1252
msgid ""
" -S, --source <string>  the device to mount (by name, maj:min, \n"
"                          LABEL=, UUID=, PARTUUID=, PARTLABEL=)\n"
msgstr ""
" -S, --source <řetězec> zařízení k připojení (podle názvu,\n"
"                        hlavního_čísla:vedlejšího_čísla, \n"
"                        LABEL=, UUID=, PARTUUID=, PARTLABEL=)\n"

#: misc-utils/findmnt.c:1254
msgid " -T, --target <path>    the path to the filesystem to use\n"
msgstr " -T, --target <cesta>   použije souborový systém na uvedené cestě\n"

# FIXME: typo "is possible"
#: misc-utils/findmnt.c:1255
msgid "     --tree             enable tree format output is possible\n"
msgstr "     --tree             výstup formátuje jako strom, je-li možno\n"

#: misc-utils/findmnt.c:1256
msgid " -M, --mountpoint <dir> the mountpoint directory\n"
msgstr ""
" -M, --mountpoint <adresář>\n"
"                        adresář bodu připojení\n"

#: misc-utils/findmnt.c:1257
msgid " -t, --types <list>     limit the set of filesystems by FS types\n"
msgstr " -t, --types <seznam>   omezí množinu souborových systémů podle jejich druhu\n"

#: misc-utils/findmnt.c:1258
msgid " -U, --uniq             ignore filesystems with duplicate target\n"
msgstr " -U, --uniq             ignoruje souborové systémy s opakujícím se cílem\n"

#: misc-utils/findmnt.c:1259 misc-utils/lslocks.c:542 sys-utils/lsns.c:912
msgid " -u, --notruncate       don't truncate text in columns\n"
msgstr " -u, --notruncate       ve sloupcích nezkracuje text\n"

#: misc-utils/findmnt.c:1260
msgid " -v, --nofsroot         don't print [/dir] for bind or btrfs mounts\n"
msgstr " -v, --nofsroot         u vázaných a btrfs připojení nevypisuje [/adr]\n"

#: misc-utils/findmnt.c:1263
msgid " -x, --verify           verify mount table content (default is fstab)\n"
msgstr " -x, --verify           ověří obsah tabulky připojení (výchozí je fstab)\n"

#: misc-utils/findmnt.c:1264
msgid "     --verbose          print more details\n"
msgstr "     --verbose          vypíše více podrobností\n"

#: misc-utils/findmnt.c:1399
#, c-format
msgid "unknown direction '%s'"
msgstr "neznámý směr „%s"

#: misc-utils/findmnt.c:1475
msgid "invalid TID argument"
msgstr "neplatný argument přepínače --task"

#: misc-utils/findmnt.c:1554
msgid "--poll accepts only one file, but more specified by --tab-file"
msgstr "přepínač --poll přijímá pouze jeden soubor, ale bylo jich zadáno více skrze přepínač --tab-file"

#: misc-utils/findmnt.c:1558
msgid "options --target and --source can't be used together with command line element that is not an option"
msgstr "volby --target a --source nemohou být použity společně s prvkem příkazového řádku, který není volbou"

#: misc-utils/findmnt.c:1611 sys-utils/fstrim.c:267
msgid "failed to initialize libmount cache"
msgstr "pomocnou paměť libmountu se nepodařilo inicializovat"

#: misc-utils/findmnt.c:1655
#, c-format
msgid "%s column is requested, but --poll is not enabled"
msgstr "Požadován je sloupce %s, ale --poll není zapnuto"

#: misc-utils/findmnt-verify.c:119
msgid "target specified more than once"
msgstr "cíl zadán více než jednou"

#: misc-utils/findmnt-verify.c:121
#, c-format
msgid "wrong order: %s specified before %s"
msgstr "chybné pořadí: %s zadáno před %s"

#: misc-utils/findmnt-verify.c:135
msgid "undefined target (fs_file)"
msgstr "nedefinovaný cíl (fs_file)"

#: misc-utils/findmnt-verify.c:142
#, c-format
msgid "non-canonical target path (real: %s)"
msgstr "nekanonická cesta k cíli (skutečná: %s)"

#: misc-utils/findmnt-verify.c:147
#, c-format
msgid "unreachable on boot required target: %m"
msgstr "nedostupný cíl potřebný pro spuštění systému: %m"

#: misc-utils/findmnt-verify.c:149
#, c-format
msgid "unreachable target: %m"
msgstr "nedostupný cíl: %m"

#: misc-utils/findmnt-verify.c:153
msgid "target is not a directory"
msgstr "cíl není adresářem"

#: misc-utils/findmnt-verify.c:155
msgid "target exists"
msgstr "cíl existuje"

#: misc-utils/findmnt-verify.c:167
#, c-format
msgid "unreachable on boot required source: %s=%s"
msgstr "nedostupný zdroj potřebný pro spuštění systému: %s=%s"

#: misc-utils/findmnt-verify.c:169
#, c-format
msgid "unreachable: %s=%s"
msgstr "nedostupné: %s=%s"

#: misc-utils/findmnt-verify.c:171
#, c-format
msgid "%s=%s translated to %s"
msgstr "%s=%s přeloženo na %s"

#: misc-utils/findmnt-verify.c:192
msgid "undefined source (fs_spec)"
msgstr "nedefinovaný zdroj (fs_spec)"

#: misc-utils/findmnt-verify.c:201
#, c-format
msgid "unsupported source tag: %s"
msgstr "nepodporovaná značka cíle: %s"

#: misc-utils/findmnt-verify.c:208
#, c-format
msgid "do not check %s source (pseudo/net)"
msgstr "nekontroluje zdroj %s (pseudo/síť)"

#: misc-utils/findmnt-verify.c:211
#, c-format
msgid "unreachable source: %s: %m"
msgstr "nedostupný zdroj: %s: %m"

#: misc-utils/findmnt-verify.c:214
#, c-format
msgid "non-bind mount source %s is a directory or regular file"
msgstr "zdroj nevázaného připojení %s je adresář nebo běžný soubor"

#: misc-utils/findmnt-verify.c:217
#, c-format
msgid "source %s is not a block device"
msgstr "zdroj %s není blokovým zařízením"

#: misc-utils/findmnt-verify.c:219
#, c-format
msgid "source %s exists"
msgstr "zdroj %s existuje"

#: misc-utils/findmnt-verify.c:232
#, c-format
msgid "VFS options: %s"
msgstr "přepínače VFS: %s"

#: misc-utils/findmnt-verify.c:236
#, c-format
msgid "FS options: %s"
msgstr "přepínače FS: %s"

#: misc-utils/findmnt-verify.c:240
#, c-format
msgid "userspace options: %s"
msgstr "přepínače uživatelského prostoru: %s"

#: misc-utils/findmnt-verify.c:254
#, c-format
msgid "unsupported swaparea discard policy: %s"
msgstr "nepodporovaná politika zahazování pro odkládací oblast: %s"

#: misc-utils/findmnt-verify.c:262
msgid "failed to parse swaparea priority option"
msgstr "volbu priority odkládací oblasti se nezdařilo rozebrat"

#: misc-utils/findmnt-verify.c:398
#, c-format
msgid "do not check %s FS type (pseudo/net)"
msgstr "nekontroluje druh systém souborů %s (pseudo/síť)"

#: misc-utils/findmnt-verify.c:408
msgid "\"none\" FS type is recommended for bind or move oprations only"
msgstr "druh souborového syst=mu „none“ je doporučen jen pro operace vázání a přesunu"

#: misc-utils/findmnt-verify.c:418
#, c-format
msgid "%s seems unsupported by the current kernel"
msgstr "zdá se, že současné jádro nepodporuje %s"

#: misc-utils/findmnt-verify.c:424 misc-utils/findmnt-verify.c:425
msgid "cannot detect on-disk filesystem type"
msgstr "nelze určit typ systému souborů na disku"

#: misc-utils/findmnt-verify.c:433
#, c-format
msgid "%s does not match with on-disk %s"
msgstr "%s se neshoduje s %s na disku"

#: misc-utils/findmnt-verify.c:436
#, c-format
msgid "on-disk %s seems unsupported by the current kernel"
msgstr "zdá se, že současné jádro nepodporuje %s na disku"

#: misc-utils/findmnt-verify.c:438
#, c-format
msgid "FS type is %s"
msgstr "Druh souborového systému je %s"

#: misc-utils/findmnt-verify.c:450
#, c-format
msgid "recommended root FS passno is 1 (current is %d)"
msgstr "doporučené pořadí kontroly souborového systému je 1 (současné je %d)"

#: misc-utils/findmnt-verify.c:519
#, c-format
msgid "%d parse error"
msgid_plural "%d parse errors"
msgstr[0] "%d chyba rozebírání"
msgstr[1] "%d chyby rozebírání"
msgstr[2] "%d chyb rozebírání"

#: misc-utils/findmnt-verify.c:520
#, c-format
msgid ", %d error"
msgid_plural ", %d errors"
msgstr[0] ", %d chyba"
msgstr[1] ", %d chyby"
msgstr[2] ", %d chyb"

#: misc-utils/findmnt-verify.c:521
#, c-format
msgid ", %d warning"
msgid_plural ", %d warnings"
msgstr[0] ", %d varování"
msgstr[1] ", %d varování"
msgstr[2] ", %d varování"

#: misc-utils/findmnt-verify.c:524
#, c-format
msgid "Success, no errors or warnings detected\n"
msgstr "Úspěch, nenalezeny žádné chyby nebo varování\n"

#: misc-utils/getopt.c:302
msgid "empty long option after -l or --long argument"
msgstr "prázdná dlouhá volba po přepínači -l či --long"

#: misc-utils/getopt.c:323
msgid "unknown shell after -s or --shell argument"
msgstr "neznámý shell po přepínači -s či --shell"

#: misc-utils/getopt.c:330
#, c-format
msgid ""
" %1$s <optstring> <parameters>\n"
" %1$s [options] [--] <optstring> <parameters>\n"
" %1$s [options] -o|--options <optstring> [options] [--] <parameters>\n"
msgstr ""
" %1$s <řetězec_s_volbami> <parametry>\n"
" %1$s [přepínače] [--] <řetězec_s_volbami> <parametry>\n"
" %1$s [přepínače] -o|--options <řetězec_s_volbami> [přepínače] [--] <parametry>\n"

#: misc-utils/getopt.c:336
msgid "Parse command options.\n"
msgstr "Rozebere volby příkazu.\n"

#: misc-utils/getopt.c:339
msgid " -a, --alternative             allow long options starting with single -\n"
msgstr " -a, --alternative             přijímá dlouhé volby začínající jedním -\n"

#: misc-utils/getopt.c:340
msgid " -l, --longoptions <longopts>  the long options to be recognized\n"
msgstr ""
" -l, --longoptions <dlouhé_volby>\n"
"                               rozpoznávané dlouhé volby\n"

#: misc-utils/getopt.c:341
msgid " -n, --name <progname>         the name under which errors are reported\n"
msgstr " -n, --name <název_programu>   název, pod kterým jsou oznamovány chyby\n"

#: misc-utils/getopt.c:342
msgid " -o, --options <optstring>     the short options to be recognized\n"
msgstr " -o, --options <krátké_volby>  rozpoznávané krátké volby\n"

#: misc-utils/getopt.c:343
msgid " -q, --quiet                   disable error reporting by getopt(3)\n"
msgstr " -q, --quiet                   vypne oznamování chyb pomocí getopt(3)\n"

#: misc-utils/getopt.c:344
msgid " -Q, --quiet-output            no normal output\n"
msgstr " -Q, --quiet-output            žádný normální výstup\n"

#: misc-utils/getopt.c:345
msgid " -s, --shell <shell>           set quoting conventions to those of <shell>\n"
msgstr ""
" -s, --shell <shell>           nastaví konvence uzavíraní do uvozovek\n"
"                               podle <shellu>\n"

#: misc-utils/getopt.c:346
msgid " -T, --test                    test for getopt(1) version\n"
msgstr " -T, --test                    testuje verzi getopt(1)\n"

#: misc-utils/getopt.c:347
msgid " -u, --unquoted                do not quote the output\n"
msgstr " -u, --unqoted                 neuzavře výstup do uvozovek\n"

#: misc-utils/getopt.c:396 misc-utils/getopt.c:456
msgid "missing optstring argument"
msgstr "chybí řetězec-s-volbami"

#: misc-utils/getopt.c:451
msgid "internal error, contact the author."
msgstr "Vnitřní chyba, oznamte ji autorovi."

#: misc-utils/hardlink.c:127
#, c-format
msgid "Directories:   %9lld\n"
msgstr "Adresáře:      %9lld\n"

#: misc-utils/hardlink.c:128
#, c-format
msgid "Objects:       %9lld\n"
msgstr "Objekty:       %9lld\n"

#: misc-utils/hardlink.c:129
#, c-format
msgid "Regular files: %9lld\n"
msgstr "Běžné soubory: %9lld\n"

#: misc-utils/hardlink.c:130
#, c-format
msgid "Comparisons:   %9lld\n"
msgstr "Porovnání:     %9lld\n"

#: misc-utils/hardlink.c:132
msgid "Would link:    "
msgstr "Bylo by vytvořeno odkazů: "

#: misc-utils/hardlink.c:133
msgid "Linked:        "
msgstr "Vytvořeno odkazů:         "

#: misc-utils/hardlink.c:135
msgid "Would save:   "
msgstr "Bylo by ušetřeno:         "

#: misc-utils/hardlink.c:136
msgid "Saved:        "
msgstr "Ušetřeno:                 "

#: misc-utils/hardlink.c:142
#, c-format
msgid " %s [options] directory...\n"
msgstr " %s [přepínače] adresář…\n"

#: misc-utils/hardlink.c:145
msgid "Consolidate duplicate files using hardlinks."
msgstr "Konsoliduje zdvojené soubory pomocí pevných odkazů."

#: misc-utils/hardlink.c:148
msgid " -c, --content          compare only contents, ignore permission, etc."
msgstr " -c, --content          porovnává pouze obsah, ignoruje práva atd."

#: misc-utils/hardlink.c:149
msgid " -n, --dry-run          don't actually link anything"
msgstr " -n, --dry-run          ve skutečnosti žádné odkazy nevytvoří"

#: misc-utils/hardlink.c:150
msgid " -v, --verbose          print summary after hardlinking"
msgstr " -v, --verbose          po vytvoření odkazů vypíše souhrn"

#: misc-utils/hardlink.c:151
msgid " -vv                    print every hardlinked file and summary"
msgstr " -vv                    vypíše každý odkázaný soubor a souhrn"

#: misc-utils/hardlink.c:152
msgid " -f, --force            force hardlinking across filesystems"
msgstr " -f, --force            vynutí pevné odkazy mezi souborovými systémy"

#: misc-utils/hardlink.c:153
msgid " -x, --exclude <regex>  exclude files matching pattern"
msgstr " -x, --exclude <regvýr> vynechá soubory odpovídající výrazu"

#: misc-utils/hardlink.c:167
msgid "integer overflow"
msgstr "přetečení celého čísla"

#: misc-utils/hardlink.c:196
#, c-format
msgid "%s is on different filesystem than the rest (use -f option to override)."
msgstr "%s se nachází na jiném systému souborů než zbytek (vynutit lze přepínačem -f)."

#: misc-utils/hardlink.c:306 sys-utils/unshare.c:208 text-utils/more.c:408
#, c-format
msgid "cannot stat %s"
msgstr "o %s nelze získat podrobnosti"

#: misc-utils/hardlink.c:312
#, c-format
msgid "file %s changed underneath us"
msgstr "soubor %s se změnil pod rukama"

#: misc-utils/hardlink.c:332
#, c-format
msgid "failed to hardlink %s to %s (create temporary link as %s failed)"
msgstr "vytvoření pevného odkazu z %s na %s selhalo (vytvoření dočasného odkazu %s selhalo)"

#: misc-utils/hardlink.c:339
#, c-format
msgid "failed to hardlink %s to %s (rename temporary link to %s failed)"
msgstr "vytvoření pevného odkazu z %s na %s selhalo (přejmenování dočasného odkazu na %s selhalo)"

#: misc-utils/hardlink.c:343
#, c-format
msgid "failed to remove temporary link %s"
msgstr "odstranění dočasného odkazu %s selhalo"

# First argument is "Would link" or "Linked".
#: misc-utils/hardlink.c:354
#, c-format
msgid " %s %s to %s\n"
msgstr " %s z %s na %s\n"

#: misc-utils/hardlink.c:355 misc-utils/hardlink.c:361
msgid "Would link"
msgstr "Byl by vytvořen odkaz"

#: misc-utils/hardlink.c:355 misc-utils/hardlink.c:361
msgid "Linked"
msgstr "Vytvořen odkaz"

# First argument is "Would link" or "Linked".
# Second and third ones are file names.
# Fourth one is "would save" or "saved".
#: misc-utils/hardlink.c:360
#, c-format
msgid " %s %s to %s, %s %jd\n"
msgstr " %s z %s to %s, %s %'jd\n"

#: misc-utils/hardlink.c:363
msgid "would save"
msgstr "bylo by ušetřeno"

# FIXME: uloženo or ušetřeno. It depends on the context.
#: misc-utils/hardlink.c:363 text-utils/pg.c:1266
msgid "saved"
msgstr "uloženo"

# TODO: Capitalize
#: misc-utils/hardlink.c:437
msgid "option --exclude not supported (built without pcre2)"
msgstr "přepínač --exclude není podporován (sestaveno bez PCRE2)"

#: misc-utils/hardlink.c:450
msgid "no directory specified"
msgstr "žádný adresář nebyl zadán"

#: misc-utils/hardlink.c:464
#, c-format
msgid "pattern error at offset %d: %s"
msgstr "chyba ve výrazu na pozici %d: %s"

#: misc-utils/hardlink.c:509
#, c-format
msgid "Skipping %s%s\n"
msgstr "%s%s vynechán\n"

#: misc-utils/kill.c:168
#, c-format
msgid "unknown signal %s; valid signals:"
msgstr "neznámý signál %s; platné signály:"

#: misc-utils/kill.c:193
#, c-format
msgid " %s [options] <pid>|<name>...\n"
msgstr " %s [přepínače] <PID>|<název>…\n"

#: misc-utils/kill.c:196
msgid "Forcibly terminate a process.\n"
msgstr "Násilně ukončí proces.\n"

#: misc-utils/kill.c:199
msgid ""
" -a, --all              do not restrict the name-to-pid conversion to processes\n"
"                          with the same uid as the present process\n"
msgstr ""
" -a, --all              neomezuje převod z názvu na PID jen na procesy s UID\n"
"                        shodným se současným procesem\n"

#: misc-utils/kill.c:201
msgid " -s, --signal <signal>  send this <signal> instead of SIGTERM\n"
msgstr " -s, --signal <signál>  zašle tento <signál> místo signálu SIGTERM\n"

#: misc-utils/kill.c:203
msgid " -q, --queue <value>    use sigqueue(2), not kill(2), and pass <value> as data\n"
msgstr ""
" -q, --queue <hodnota>  použije sigqueue(2) místo kill(2) a jako data\n"
"                        předá <hodnotu>\n"

#: misc-utils/kill.c:206
msgid ""
"     --timeout <milliseconds> <follow-up signal>\n"
"                        wait up to timeout and send follow-up signal\n"
msgstr ""
"     --timeout <milisekundy> <následný signál>\n"
"                        počká na vypršení časového limitu a poté zašle\n"
"                        následný signál\n"

#: misc-utils/kill.c:209
msgid " -p, --pid              print pids without signaling them\n"
msgstr " -p, --pid              vypíše čísla procesů, aniž by jim zaslal signál\n"

#: misc-utils/kill.c:210
msgid " -l, --list[=<signal>]  list signal names, or convert a signal number to a name\n"
msgstr ""
" -l, --list[=<signál>]  vypíše seznam názvů signálů, nebo převede číslo\n"
"                        signálu na název\n"

#: misc-utils/kill.c:211
msgid " -L, --table            list signal names and numbers\n"
msgstr " -L, --table            vypíše seznam názvů a čísel signálů\n"

#: misc-utils/kill.c:212
msgid "     --verbose          print pids that will be signaled\n"
msgstr "     --verbose          vypíše čísla PID, kterým bude zaslán signál\n"

#: misc-utils/kill.c:232 term-utils/agetty.c:687
#, c-format
msgid "%s from %s"
msgstr "%s z %s"

#: misc-utils/kill.c:236
msgid " (with: "
msgstr " (s: "

#: misc-utils/kill.c:285 misc-utils/kill.c:294 sys-utils/setpriv.c:451
#: sys-utils/unshare.c:499
#, c-format
msgid "unknown signal: %s"
msgstr "neznámý signál %s"

#: misc-utils/kill.c:305 misc-utils/kill.c:308 misc-utils/kill.c:317
#: misc-utils/kill.c:329 misc-utils/kill.c:372 sys-utils/mountpoint.c:193
#, c-format
msgid "%s and %s are mutually exclusive"
msgstr "%s a %s se vzájemně vylučují"

#: misc-utils/kill.c:332 misc-utils/kill.c:347 sys-utils/eject.c:208
#: sys-utils/eject.c:230 sys-utils/losetup.c:726 sys-utils/tunelp.c:164
#: sys-utils/tunelp.c:171 sys-utils/tunelp.c:178 sys-utils/tunelp.c:185
#: sys-utils/tunelp.c:192 sys-utils/tunelp.c:198 sys-utils/tunelp.c:202
#: sys-utils/tunelp.c:209 term-utils/setterm.c:211 term-utils/setterm.c:214
#: term-utils/setterm.c:233 term-utils/setterm.c:235 term-utils/setterm.c:273
#: term-utils/setterm.c:275 term-utils/setterm.c:291 term-utils/setterm.c:298
#: term-utils/setterm.c:300 term-utils/setterm.c:312 term-utils/setterm.c:314
#: term-utils/setterm.c:323 term-utils/setterm.c:331 term-utils/setterm.c:346
#: term-utils/setterm.c:348 term-utils/setterm.c:360 term-utils/setterm.c:362
#: term-utils/setterm.c:373 term-utils/setterm.c:561 term-utils/setterm.c:566
#: term-utils/setterm.c:571 term-utils/setterm.c:576 term-utils/setterm.c:600
#: term-utils/setterm.c:605 term-utils/setterm.c:610 term-utils/setterm.c:615
#: term-utils/setterm.c:620 term-utils/setterm.c:625 term-utils/setterm.c:634
#: term-utils/setterm.c:669 text-utils/more.c:324
msgid "argument error"
msgstr "chyba argumentu"

#: misc-utils/kill.c:369
#, c-format
msgid "invalid signal name or number: %s"
msgstr "neplatný název nebo číslo signálu: %s"

#: misc-utils/kill.c:395
#, c-format
msgid "pidfd_open() failed: %d"
msgstr "volání pidfd_open() selhalo: %d"

#: misc-utils/kill.c:400 misc-utils/kill.c:414
msgid "pidfd_send_signal() failed"
msgstr "volání pidfd_send_signal() selhalo"

#: misc-utils/kill.c:411
#, c-format
msgid "timeout, sending signal %d to pid %d\n"
msgstr "časový limit vypršel, zasílá se signál %d procesu %d\n"

#: misc-utils/kill.c:426
#, c-format
msgid "sending signal %d to pid %d\n"
msgstr "zasílá se signál %d procesu %d\n"

#: misc-utils/kill.c:444
#, c-format
msgid "sending signal to %s failed"
msgstr "zaslání signálu procesu %s selhalo"

#: misc-utils/kill.c:493
#, c-format
msgid "cannot find process \"%s\""
msgstr "proces „%s“ nelze nalézt"

#: misc-utils/logger.c:228
#, c-format
msgid "unknown facility name: %s"
msgstr "neznámý název oboru (facility): %s"

#: misc-utils/logger.c:234
#, c-format
msgid "unknown priority name: %s"
msgstr "neznámý název priority: %s"

# openlog is function name
#: misc-utils/logger.c:246
#, c-format
msgid "openlog %s: pathname too long"
msgstr "openlog %s: cesta je příliš dlouhá"

# socket is function name
#: misc-utils/logger.c:273
#, c-format
msgid "socket %s"
msgstr "socket %s"

#: misc-utils/logger.c:310
#, c-format
msgid "failed to resolve name %s port %s: %s"
msgstr "nezdařilo se přeložit název %s port %s: %s"

#: misc-utils/logger.c:327
#, c-format
msgid "failed to connect to %s port %s"
msgstr "nezdařilo se připojit k %s port %s"

#: misc-utils/logger.c:375
#, c-format
msgid "maximum input lines (%d) exceeded"
msgstr "maximální vstupní řádky (%d) překročeny"

#: misc-utils/logger.c:528
msgid "send message failed"
msgstr "odeslání zprávy selhalo"

#: misc-utils/logger.c:598
#, c-format
msgid "structured data ID '%s' is not unique"
msgstr "strukturované ID dat „%s“ není jedinečné"

#: misc-utils/logger.c:612
#, c-format
msgid "--sd-id was not specified for --sd-param %s"
msgstr "přepínač --sd-id nebyl zadán spolu s --sd-param %s"

#: misc-utils/logger.c:791
msgid "localtime() failed"
msgstr "funkce localtime() selhala"

#: misc-utils/logger.c:801
#, c-format
msgid "hostname '%s' is too long"
msgstr "název stroje „%s“ je příliš dlouhý"

#: misc-utils/logger.c:807
#, c-format
msgid "tag '%s' is too long"
msgstr "značka „%s“ je příliš dlouhá"

#: misc-utils/logger.c:870
#, c-format
msgid "ignoring unknown option argument: %s"
msgstr "argument neznámého přepínače se ignoruje: %s"

#: misc-utils/logger.c:882
#, c-format
msgid "invalid argument: %s: using automatic errors"
msgstr "neplatný argument: %s: používají se automatické chyby"

#: misc-utils/logger.c:1053
#, c-format
msgid " %s [options] [<message>]\n"
msgstr " %s [přepínače] [<zpráva>]\n"

#: misc-utils/logger.c:1056
msgid "Enter messages into the system log.\n"
msgstr "Vkládá zprávy do systémového protokolu.\n"

#: misc-utils/logger.c:1059
msgid " -i                       log the logger command's PID\n"
msgstr " -i                       zaznamená PID protokolujícího příkazu\n"

#: misc-utils/logger.c:1060
msgid "     --id[=<id>]          log the given <id>, or otherwise the PID\n"
msgstr "     --id[=<ID>]          zaznamená <ID>, jinak PID\n"

#: misc-utils/logger.c:1061
msgid " -f, --file <file>        log the contents of this file\n"
msgstr " -f, --file <soubor>      zaznamená obsah tohoto souboru\n"

#: misc-utils/logger.c:1062
msgid " -e, --skip-empty         do not log empty lines when processing files\n"
msgstr " -e, --skip-empty         při zpracování souborů nezaznamenává prázdné řádku\n"

#: misc-utils/logger.c:1063
msgid "     --no-act             do everything except the write the log\n"
msgstr "     --no-act             udělá vše kromě zápisu protokolu\n"

#: misc-utils/logger.c:1064
msgid " -p, --priority <prio>    mark given message with this priority\n"
msgstr ""
" -p, --priority <priorita>\n"
"                          označí zadanou zprávu touto prioritou\n"

#: misc-utils/logger.c:1065
msgid "     --octet-count        use rfc6587 octet counting\n"
msgstr "     --octet-count        počítá oktety podle RFC 6587\n"

#: misc-utils/logger.c:1066
msgid "     --prio-prefix        look for a prefix on every line read from stdin\n"
msgstr ""
"     --prio-prefix        hledá předponu na každém řádku přečteném ze\n"
"                          standardního vstupu\n"

#: misc-utils/logger.c:1067
msgid " -s, --stderr             output message to standard error as well\n"
msgstr " -s, --stderr             zprávu vypíše rovněž na standardní chybový výstup\n"

#: misc-utils/logger.c:1068
msgid " -S, --size <size>        maximum size for a single message\n"
msgstr " -S, --size <velikost>    maximální velikost jedné zprávy\n"

#: misc-utils/logger.c:1069
msgid " -t, --tag <tag>          mark every line with this tag\n"
msgstr " -t, --tag <značka>       každému řádku přidá tuto značku\n"

#: misc-utils/logger.c:1070
msgid " -n, --server <name>      write to this remote syslog server\n"
msgstr " -n, --server <název>     zapíše do tohoto vzdáleného syslogového serveru\n"

#: misc-utils/logger.c:1071
msgid " -P, --port <port>        use this port for UDP or TCP connection\n"
msgstr " -P, --port <port>        použije tento port pro UDP nebo spojení TCP\n"

#: misc-utils/logger.c:1072
msgid " -T, --tcp                use TCP only\n"
msgstr " -T, --tcp                použije pouze TCP\n"

#: misc-utils/logger.c:1073
msgid " -d, --udp                use UDP only\n"
msgstr " -d, --udp                použije pouze UDP\n"

#: misc-utils/logger.c:1074
msgid "     --rfc3164            use the obsolete BSD syslog protocol\n"
msgstr "     --rfc3164            použije zastaralý protokol BSD syslogu\n"

#: misc-utils/logger.c:1075
msgid ""
"     --rfc5424[=<snip>]   use the syslog protocol (the default for remote);\n"
"                            <snip> can be notime, or notq, and/or nohost\n"
msgstr ""
"     --rfc5424[=<útržek>] použije protokol syslogu (výchozí pro vzdálený cíl),\n"
"                          <útržek> může být „notime“ nebo „notq“ a/nebo „nohost“\n"

#: misc-utils/logger.c:1077
msgid "     --sd-id <id>         rfc5424 structured data ID\n"
msgstr "     --sd-id <ID>         ID dat strukturovaných podle RFC 5424\n"

#: misc-utils/logger.c:1078
msgid "     --sd-param <data>    rfc5424 structured data name=value\n"
msgstr "     --sd-param <data>    strukturovaná data název=hodnota podle RFC 5424\n"

#: misc-utils/logger.c:1079
msgid "     --msgid <msgid>      set rfc5424 message id field\n"
msgstr "     --msgid <ID>         nastaví položku ID zprávy podle RFC 5424\n"

#: misc-utils/logger.c:1080
msgid " -u, --socket <socket>    write to this Unix socket\n"
msgstr " -u, --socket <socket>    zapíše do tohoto unixového socketu\n"

#: misc-utils/logger.c:1081
msgid ""
"     --socket-errors[=<on|off|auto>]\n"
"                          print connection errors when using Unix sockets\n"
msgstr ""
"     --socket-errors[=<on|off|auto>]\n"
"                          vypisuje chyby spojení, používají-li se unixové\n"
"                          sockety\n"

#: misc-utils/logger.c:1084
msgid "     --journald[=<file>]  write journald entry\n"
msgstr ""
"     --journald[=<soubor>]\n"
"                          zapíše záznam journald\n"

#: misc-utils/logger.c:1170
#, c-format
msgid "file %s"
msgstr "soubor %s"

#: misc-utils/logger.c:1185
msgid "failed to parse id"
msgstr "ID se nezdařilo rozebrat"

#: misc-utils/logger.c:1203
msgid "failed to parse message size"
msgstr "velikost zprávy se nezdařilo rozebrat"

#: misc-utils/logger.c:1233
msgid "--msgid cannot contain space"
msgstr "--msgid nemůže obsahovat mezeru"

#: misc-utils/logger.c:1255
#, c-format
msgid "invalid structured data ID: '%s'"
msgstr "neplatné ID strukturovaných data: „%s“"

#: misc-utils/logger.c:1260
#, c-format
msgid "invalid structured data parameter: '%s'"
msgstr "chybný parametr strukturovaných dat: „%s“"

#: misc-utils/logger.c:1275
msgid "--file <file> and <message> are mutually exclusive, message is ignored"
msgstr "--file <soubor> a <zpráva> se vzájemně vylučují, zpráva se ignoruje"

#: misc-utils/logger.c:1282
msgid "journald entry could not be written"
msgstr "záznam journald nebylo možné zapsat"

#: misc-utils/look.c:359
#, c-format
msgid " %s [options] <string> [<file>...]\n"
msgstr " %s [přepínače] <řetězec> [<soubor>…]\n"

#: misc-utils/look.c:362
msgid "Display lines beginning with a specified string.\n"
msgstr "Zobrazí řádky začínající zadaným řetězcem.\n"

#: misc-utils/look.c:365
msgid " -a, --alternative        use the alternative dictionary\n"
msgstr " -a, --alternative        použije náhradní slovník\n"

#: misc-utils/look.c:366
msgid " -d, --alphanum           compare only blanks and alphanumeric characters\n"
msgstr " -d, --alphanum           porovnává pouze bílé a alfanumerické znaky\n"

#: misc-utils/look.c:367
msgid " -f, --ignore-case        ignore case differences when comparing\n"
msgstr " -f, --ignore-case        při porovnávání ignoruje velikost písmen\n"

#: misc-utils/look.c:368
msgid " -t, --terminate <char>   define the string-termination character\n"
msgstr " -t, --terminate <znak>   určuje znak, který ukončuje řetězec\n"

#: misc-utils/lsblk.c:153
msgid "device name"
msgstr "název zařízení"

#: misc-utils/lsblk.c:154
msgid "internal kernel device name"
msgstr "vnitřní jaderný název zařízení"

#: misc-utils/lsblk.c:155
msgid "internal parent kernel device name"
msgstr "vnitřní jaderný název nadřazeného zařízení"

#: misc-utils/lsblk.c:156
msgid "path to the device node"
msgstr "cesta k uzlu se zařízením"

#: misc-utils/lsblk.c:164
msgid "filesystem version"
msgstr "verze systému souborů"

#: misc-utils/lsblk.c:166 sys-utils/zramctl.c:86
msgid "where the device is mounted"
msgstr "kam je zařízení připojeno"

#: misc-utils/lsblk.c:167 misc-utils/wipefs.c:110
msgid "filesystem LABEL"
msgstr "jmenovka souborového systému"

#: misc-utils/lsblk.c:170
msgid "partition table identifier (usually UUID)"
msgstr "identifikátor tabulky rozdělení disku (obvykle UUID)"

#: misc-utils/lsblk.c:171
msgid "partition table type"
msgstr "typ tabulky rozdělení disku"

#: misc-utils/lsblk.c:173
msgid "partition type code or UUID"
msgstr "kód druhu oddílu nebo UUID"

#: misc-utils/lsblk.c:174
msgid "partition type name"
msgstr "název druhu oddílu"

#: misc-utils/lsblk.c:175
msgid "partition LABEL"
msgstr "jmenovka oddílu"

#: misc-utils/lsblk.c:179
msgid "read-ahead of the device"
msgstr "přednačítání ze zařízení"

#: misc-utils/lsblk.c:180 sys-utils/losetup.c:79
msgid "read-only device"
msgstr "zařízení pouze pro čtení"

#: misc-utils/lsblk.c:181
msgid "removable device"
msgstr "výměnné zařízení"

#: misc-utils/lsblk.c:182
msgid "removable or hotplug device (usb, pcmcia, ...)"
msgstr "vyměnitelné nebo za běhu odpojitelné zařízení (USB, PCMCIA, …)"

#: misc-utils/lsblk.c:183
msgid "rotational device"
msgstr "otáčivé zařízení"

#: misc-utils/lsblk.c:184
msgid "adds randomness"
msgstr "přidává náhodnost"

#: misc-utils/lsblk.c:185
msgid "device identifier"
msgstr "identifikátor zařízení"

#: misc-utils/lsblk.c:186
msgid "disk serial number"
msgstr "sériové číslo disku"

#: misc-utils/lsblk.c:187
msgid "size of the device"
msgstr "velikost zařízení"

#: misc-utils/lsblk.c:188
msgid "state of the device"
msgstr "stav zařízení"

#: misc-utils/lsblk.c:190
msgid "group name"
msgstr "název skupiny"

#: misc-utils/lsblk.c:191
msgid "device node permissions"
msgstr "přístupová práva k uzlu zařízení"

#: misc-utils/lsblk.c:192
msgid "alignment offset"
msgstr "posun pro zarovnání"

#: misc-utils/lsblk.c:193
msgid "minimum I/O size"
msgstr "minimální velikost I/O"

#: misc-utils/lsblk.c:194
msgid "optimal I/O size"
msgstr "optimální velikost I/O"

#: misc-utils/lsblk.c:195
msgid "physical sector size"
msgstr "velikost fyzického sektoru"

#: misc-utils/lsblk.c:196
msgid "logical sector size"
msgstr "velikost logického sektoru"

#: misc-utils/lsblk.c:197
msgid "I/O scheduler name"
msgstr "název plánovače I/O"

#: misc-utils/lsblk.c:198
msgid "request queue size"
msgstr "velikost fronty požadavků"

#: misc-utils/lsblk.c:199
msgid "device type"
msgstr "druh zařízení"

#: misc-utils/lsblk.c:200
msgid "discard alignment offset"
msgstr "posun pro zahazovaní (discard)"

#: misc-utils/lsblk.c:201
msgid "discard granularity"
msgstr "stupeň zahazování"

#: misc-utils/lsblk.c:202
msgid "discard max bytes"
msgstr "maximální počet zahoditelných bajtů"

#: misc-utils/lsblk.c:203
msgid "discard zeroes data"
msgstr "zahození nuluje data"

#: misc-utils/lsblk.c:204
msgid "write same max bytes"
msgstr "maximální počet bajtů pro zápis kopií"

#: misc-utils/lsblk.c:205
msgid "unique storage identifier"
msgstr "jedinečný identifikátor úložiště"

#: misc-utils/lsblk.c:206
msgid "Host:Channel:Target:Lun for SCSI"
msgstr "stroj:kanál:cíl:jednotka pro SCSI"

#: misc-utils/lsblk.c:207
msgid "device transport type"
msgstr "druh transportu zařízení"

#: misc-utils/lsblk.c:208
msgid "de-duplicated chain of subsystems"
msgstr "deduplikovaný řetěz podsystémů"

#: misc-utils/lsblk.c:209
msgid "device revision"
msgstr "revize zařízení"

#: misc-utils/lsblk.c:210
msgid "device vendor"
msgstr "prodejce zařízení"

#: misc-utils/lsblk.c:211
msgid "zone model"
msgstr "model zóny"

#: misc-utils/lsblk.c:212
#, fuzzy
msgid "dax-capable device"
msgstr "výměnné zařízení"

#: misc-utils/lsblk.c:1243
msgid "failed to allocate device"
msgstr "alokace zařízení selhala"

#: misc-utils/lsblk.c:1283
msgid "failed to open device directory in sysfs"
msgstr "adresář zařízení v sysfs se nepodařilo otevřít"

#: misc-utils/lsblk.c:1465
#, c-format
msgid "%s: failed to get sysfs name"
msgstr "%s: nepodařilo se získat název v sysfs"

#: misc-utils/lsblk.c:1477
#, c-format
msgid "%s: failed to get whole-disk device number"
msgstr "%s: zjištění čísla zařízení celého disku selhalo"

#: misc-utils/lsblk.c:1550 misc-utils/lsblk.c:1598
msgid "failed to allocate /sys handler"
msgstr "alokace deskriptoru pro /sys selhala"

#: misc-utils/lsblk.c:1658 misc-utils/lsblk.c:1660 misc-utils/lsblk.c:1689
#: misc-utils/lsblk.c:1691
#, c-format
msgid "failed to parse list '%s'"
msgstr "nezdařilo se rozebrat seznam „%s“"

#. TRANSLATORS: The standard value for %d is 256.
#: misc-utils/lsblk.c:1665
#, c-format
msgid "the list of excluded devices is too large (limit is %d devices)"
msgstr "seznam vynechaných zařízení je příliš dlouhý (hranice je %d zařízení)"

#. TRANSLATORS: The standard value for %d is 256.
#: misc-utils/lsblk.c:1696
#, c-format
msgid "the list of included devices is too large (limit is %d devices)"
msgstr "seznam zahrnutých zařízení je příliš dlouhý (hranice je %d zařízení)"

#: misc-utils/lsblk.c:1765 sys-utils/wdctl.c:207
#, c-format
msgid " %s [options] [<device> ...]\n"
msgstr " %s [přepínače] [<zařízení>…]\n"

#: misc-utils/lsblk.c:1768
msgid "List information about block devices.\n"
msgstr "Vypíše údaje o blokovém zařízení.\n"

#: misc-utils/lsblk.c:1771
msgid " -D, --discard        print discard capabilities\n"
msgstr " -D, --discard        popíše schopnost zahazovat data (discard)\n"

#: misc-utils/lsblk.c:1772
msgid " -E, --dedup <column> de-duplicate output by <column>\n"
msgstr " -E, --dedup <sloupec> deduplikuje výstup podle <sloupce>\n"

#: misc-utils/lsblk.c:1773
msgid " -I, --include <list> show only devices with specified major numbers\n"
msgstr ""
" -I, --include <seznam>\n"
"                      zobrazí pouze zařízení se zadanými hlavními čísly\n"

#: misc-utils/lsblk.c:1774 sys-utils/lsirq.c:63 sys-utils/lsmem.c:512
msgid " -J, --json           use JSON output format\n"
msgstr " -J, --json           výstup formátuje do JSONu\n"

#: misc-utils/lsblk.c:1775
msgid " -O, --output-all     output all columns\n"
msgstr " -O, --output-all     vypíše všechny sloupce\n"

#: misc-utils/lsblk.c:1777
msgid " -S, --scsi           output info about SCSI devices\n"
msgstr " -S, --scsi           vypíše údaje o SCSI zařízení\n"

#: misc-utils/lsblk.c:1778
msgid " -T, --tree[=<column>] use tree format output\n"
msgstr " -T, --tree[=<sloupec>]  výstup formátuje jako strom\n"

#: misc-utils/lsblk.c:1779
msgid " -a, --all            print all devices\n"
msgstr " -a, --all            vypíše všechna zařízení\n"

#: misc-utils/lsblk.c:1781
msgid " -d, --nodeps         don't print slaves or holders\n"
msgstr " -d, --nodeps         nevypíše podřízená (slave) a nadřízená (holder) zařízení\n"

#: misc-utils/lsblk.c:1782
msgid " -e, --exclude <list> exclude devices by major number (default: RAM disks)\n"
msgstr ""
" -e, --exclude <seznam>\n"
"                      vynechá zařízení podle hlavního čísla (výchozí: RAM disky)\n"

#: misc-utils/lsblk.c:1783
msgid " -f, --fs             output info about filesystems\n"
msgstr " -f, --fs             vypíše údaje o souborovém systému\n"

#: misc-utils/lsblk.c:1784
msgid " -i, --ascii          use ascii characters only\n"
msgstr " -i, --ascii          použije pouze ASCII znaky\n"

#: misc-utils/lsblk.c:1785
msgid " -l, --list           use list format output\n"
msgstr " -l, --list           výstup formátuje jako seznam\n"

#: misc-utils/lsblk.c:1786
msgid " -M, --merge          group parents of sub-trees (usable for RAIDs, Multi-path)\n"
msgstr " -M, --merge          seskupí rodiče podstromů (vhodné pro RAID a multipath)\n"

#: misc-utils/lsblk.c:1787
msgid " -m, --perms          output info about permissions\n"
msgstr " -m, --perms          vypíše údaje o přístupových právech\n"

#: misc-utils/lsblk.c:1788 sys-utils/lsirq.c:65 sys-utils/lsmem.c:516
msgid " -n, --noheadings     don't print headings\n"
msgstr " -n, --noheadings     nevypíše záhlaví\n"

#: misc-utils/lsblk.c:1789 sys-utils/lsmem.c:517
msgid " -o, --output <list>  output columns\n"
msgstr ""
" -o, --output <seznam>\n"
"                      zobrazí zadané sloupce\n"

#: misc-utils/lsblk.c:1790
msgid " -p, --paths          print complete device path\n"
msgstr " -p, --paths          vypíše celou cestu k zařízení\n"

#: misc-utils/lsblk.c:1792
msgid " -s, --inverse        inverse dependencies\n"
msgstr " -s, --inverse        obrátí závislosti\n"

#: misc-utils/lsblk.c:1793
msgid " -t, --topology       output info about topology\n"
msgstr " -t, --topology       vypíše údaje o topologii\n"

#: misc-utils/lsblk.c:1794
msgid " -z, --zoned          print zone model\n"
msgstr " -z, --zoned          vypíše model zóny\n"

#: misc-utils/lsblk.c:1795
msgid " -x, --sort <column>  sort output by <column>\n"
msgstr " -x, --sort <sloupec> výstup seřadí podle <sloupce>\n"

#: misc-utils/lsblk.c:1796
msgid "     --sysroot <dir>  use specified directory as system root\n"
msgstr "     --sysroot <adresář>  jako kořen systému použije <adresář>\n"

#: misc-utils/lsblk.c:1813
#, c-format
msgid "failed to access sysfs directory: %s"
msgstr "nezdařilo se přistoupit k adresáři v sysfs: %s"

#: misc-utils/lsblk.c:2154
msgid "failed to allocate device tree"
msgstr "alokace stromu zařízení selhala"

#: misc-utils/lslocks.c:73
msgid "command of the process holding the lock"
msgstr "příkaz procesu, který drží zámek"

#: misc-utils/lslocks.c:74
msgid "PID of the process holding the lock"
msgstr "ID procesu, který drží zámek"

#: misc-utils/lslocks.c:75
msgid "kind of lock"
msgstr "druh zámku"

#: misc-utils/lslocks.c:76
msgid "size of the lock"
msgstr "velikost zámku"

#: misc-utils/lslocks.c:77
msgid "lock access mode"
msgstr "přístupový režim k zámku"

#: misc-utils/lslocks.c:78
msgid "mandatory state of the lock: 0 (none), 1 (set)"
msgstr "závaznost zámku: 0 (ne), 1 (nastaveno)"

#: misc-utils/lslocks.c:79
msgid "relative byte offset of the lock"
msgstr "relativní poloha zámku v bajtech"

#: misc-utils/lslocks.c:80
msgid "ending offset of the lock"
msgstr "poloha konce zámku"

#: misc-utils/lslocks.c:81
msgid "path of the locked file"
msgstr "cesta k zamknutému souboru"

#: misc-utils/lslocks.c:82
msgid "PID of the process blocking the lock"
msgstr "ID procesu, který blokuje zámek"

#: misc-utils/lslocks.c:259
msgid "failed to parse ID"
msgstr "ID se nezdařilo rozebrat"

#: misc-utils/lslocks.c:281 sys-utils/nsenter.c:262
msgid "failed to parse pid"
msgstr "PID se nezdařilo rozebrat"

# Unknown command
#: misc-utils/lslocks.c:285
msgid "(unknown)"
msgstr "(neznámý)"

#: misc-utils/lslocks.c:287
msgid "(undefined)"
msgstr "(nedefinováno)"

#: misc-utils/lslocks.c:296
msgid "failed to parse start"
msgstr "začátek se nepodařilo rozebrat"

#: misc-utils/lslocks.c:303
msgid "failed to parse end"
msgstr "konec se nepodařilo rozebrat"

#: misc-utils/lslocks.c:531
msgid "List local system locks.\n"
msgstr "Vypíše zámky na místním systému.\n"

#: misc-utils/lslocks.c:534
msgid " -b, --bytes            print SIZE in bytes rather than in human readable format\n"
msgstr ""
" -b, --bytes            velikosti vypisuje v bajtech namísto v podobě vhodné\n"
"                        pro člověka\n"

#: misc-utils/lslocks.c:536
msgid " -i, --noinaccessible   ignore locks without read permissions\n"
msgstr " -i, --noinaccessible   ignoruje zámky bez práv a ke čtení\n"

#: misc-utils/lslocks.c:537 sys-utils/lsns.c:907 sys-utils/rfkill.c:582
msgid " -n, --noheadings       don't print headings\n"
msgstr " -n, --noheadings       nevypíše záhlaví\n"

#: misc-utils/lslocks.c:538 sys-utils/lsns.c:908 sys-utils/rfkill.c:583
msgid " -o, --output <list>    define which output columns to use\n"
msgstr ""
" -o, --output <seznam>\n"
"                        určuje, které výstupní sloupce se použijí\n"

#: misc-utils/lslocks.c:539 sys-utils/lsns.c:909 sys-utils/rfkill.c:584
msgid "     --output-all       output all columns\n"
msgstr "     --output-all       vypíše všechny sloupce\n"

#: misc-utils/lslocks.c:540
msgid " -p, --pid <pid>        display only locks held by this process\n"
msgstr " -p, --pid <PID>        zobrazí pouze zámky držené tímto procesem\n"

#: misc-utils/lslocks.c:541 sys-utils/lsns.c:911 sys-utils/rfkill.c:585
msgid " -r, --raw              use the raw output format\n"
msgstr " -r, --raw              neformátovaný výstup\n"

#: misc-utils/lslocks.c:606 schedutils/chrt.c:484 schedutils/ionice.c:177
#: schedutils/taskset.c:171 sys-utils/choom.c:102 sys-utils/lsns.c:993
#: sys-utils/prlimit.c:587
msgid "invalid PID argument"
msgstr "neplatný argument přepínače --pid"

#: misc-utils/mcookie.c:86
msgid "Generate magic cookies for xauth.\n"
msgstr "Vyrobí magický cookie pro program xauth.\n"

#: misc-utils/mcookie.c:89
msgid " -f, --file <file>     use file as a cookie seed\n"
msgstr " -f, --file <soubor>   použije soubor jako inicializační vektor pro cookie\n"

#: misc-utils/mcookie.c:90
msgid " -m, --max-size <num>  limit how much is read from seed files\n"
msgstr ""
" -m, --max-size <číslo>\n"
"                       omezí, kolik přečíst z inicializačních souborů\n"

#: misc-utils/mcookie.c:91
msgid " -v, --verbose         explain what is being done\n"
msgstr " -v, --verbose         vysvětlí, co se provádí\n"

#: misc-utils/mcookie.c:97 misc-utils/wipefs.c:671 sys-utils/blkdiscard.c:104
#: sys-utils/fallocate.c:107 sys-utils/fstrim.c:434
msgid "<num>"
msgstr ""

#: misc-utils/mcookie.c:124
#, c-format
msgid "Got %zu byte from %s\n"
msgid_plural "Got %zu bytes from %s\n"
msgstr[0] "Obdržen %zu bajt z %s\n"
msgstr[1] "Obdrženy %zu bahty z %s\n"
msgstr[2] "Obdrženo %zu bajtů z %s\n"

#: misc-utils/mcookie.c:129
#, c-format
msgid "closing %s failed"
msgstr "uzavření %s selhalo"

#: misc-utils/mcookie.c:168 sys-utils/blkdiscard.c:184 sys-utils/fstrim.c:500
#: text-utils/hexdump.c:117
msgid "failed to parse length"
msgstr "nezdařilo se rozebrat délku"

#: misc-utils/mcookie.c:181
msgid "--max-size ignored when used without --file"
msgstr "--max-size se ignoruje, když není použit s --file"

#: misc-utils/mcookie.c:190
#, c-format
msgid "Got %d byte from %s\n"
msgid_plural "Got %d bytes from %s\n"
msgstr[0] "Obdržen %d bajt z %s\n"
msgstr[1] "Obdrženy %d bajty z %s\n"
msgstr[2] "Obdrženo %d bajtů z %s\n"

#: misc-utils/namei.c:90
#, c-format
msgid "failed to read symlink: %s"
msgstr "čtení symbolického odkazu selhalo: %s"

#: misc-utils/namei.c:334
#, c-format
msgid " %s [options] <pathname>...\n"
msgstr " %s [přepínače] <cesta>…\n"

#: misc-utils/namei.c:337
msgid "Follow a pathname until a terminal point is found.\n"
msgstr "Následuje cestu dokud není nalezen konečný bod.\n"

#: misc-utils/namei.c:341
msgid ""
" -x, --mountpoints   show mount point directories with a 'D'\n"
" -m, --modes         show the mode bits of each file\n"
" -o, --owners        show owner and group name of each file\n"
" -l, --long          use a long listing format (-m -o -v) \n"
" -n, --nosymlinks    don't follow symlinks\n"
" -v, --vertical      vertical align of modes and owners\n"
msgstr ""
" -x, --mountpoints   vyznačí adresáře bodů připojení pomocí „D“\n"
" -m, --modes         zobrazí u každého souboru bity práv\n"
" -o, --owners        zobrazí u každého souboru jméno vlastníka a skupiny\n"
" -l, --long          použije dlouhý tvar výpisu (-m -o -v) \n"
" -n, --nosymlinks    nenásleduje symbolické odkazy\n"
" -v, --vertical      svislé zarovnání práv a vlastníků\n"

#: misc-utils/namei.c:408
msgid "pathname argument is missing"
msgstr "argument s názvem cesty chybí"

#: misc-utils/namei.c:414 sys-utils/lsns.c:1070
msgid "failed to allocate UID cache"
msgstr "alokace keš UID selhala"

#: misc-utils/namei.c:417
msgid "failed to allocate GID cache"
msgstr "alokace keš GPT selhala"

#: misc-utils/namei.c:439
#, c-format
msgid "%s: exceeded limit of symlinks"
msgstr "%s: omezení symbolických odkazů překročeno"

#: misc-utils/rename.c:74
#, c-format
msgid "%s: overwrite `%s'? "
msgstr "%s: přepsat „%s“? "

#: misc-utils/rename.c:115 misc-utils/rename.c:177
#, c-format
msgid "%s: not accessible"
msgstr "%s: není přístupný"

#: misc-utils/rename.c:124
#, c-format
msgid "%s: not a symbolic link"
msgstr "%s: není symbolickým odkazem"

#: misc-utils/rename.c:129
#, c-format
msgid "%s: readlink failed"
msgstr "%s: volání readlink selhalo"

#: misc-utils/rename.c:144
#, c-format
msgid "Skipping existing link: `%s' -> `%s'\n"
msgstr "Přeskakuje se existující odkaz: „%s“ → „%s“\n"

#: misc-utils/rename.c:150
#, c-format
msgid "%s: unlink failed"
msgstr "%s: volání unlink selhalo"

#: misc-utils/rename.c:154
#, c-format
msgid "%s: symlinking to %s failed"
msgstr "%s: nebylo možné vytvořit symbolický odkaz na %s"

#: misc-utils/rename.c:197
#, c-format
msgid "Skipping existing file: `%s'\n"
msgstr "Vynechává se existující soubor: „%s“\n"

#: misc-utils/rename.c:201
#, c-format
msgid "%s: rename to %s failed"
msgstr "%s: přejmenování na %s selhalo"

#: misc-utils/rename.c:215
#, c-format
msgid " %s [options] <expression> <replacement> <file>...\n"
msgstr " %s [přepínače] <výraz> <náhrada> <soubor>…\n"

#: misc-utils/rename.c:219
msgid "Rename files.\n"
msgstr "Přejmenuje soubory.\n"

#: misc-utils/rename.c:222
msgid " -v, --verbose       explain what is being done\n"
msgstr " -v, --verbose       vysvětlí, co se provádí\n"

#: misc-utils/rename.c:223
msgid " -s, --symlink       act on the target of symlinks\n"
msgstr " -s, --symlink       pracuje s cílem symbolických odkazů\n"

#: misc-utils/rename.c:224
msgid " -n, --no-act        do not make any changes\n"
msgstr " -n, --no-act        neprovede žádné změny\n"

#: misc-utils/rename.c:225
msgid " -o, --no-overwrite  don't overwrite existing files\n"
msgstr " -o, --no-overwrite  nepřepisuje existující soubory\n"

#: misc-utils/rename.c:226
msgid " -i, --interactive   prompt before overwrite\n"
msgstr " -i, --interactive   před přepsáním se zeptá\n"

#: misc-utils/rename.c:302
msgid "failed to get terminal attributes"
msgstr "nelze zjistit vlastnosti terminálu"

#: misc-utils/uuidd.c:64
msgid "A daemon for generating UUIDs.\n"
msgstr "Démon pro vytváření identifikátorů UUID.\n"

#: misc-utils/uuidd.c:66
msgid " -p, --pid <path>        path to pid file\n"
msgstr " -p, --pid <cesta>       cesta k souboru s PID\n"

#: misc-utils/uuidd.c:67
msgid " -s, --socket <path>     path to socket\n"
msgstr " -s, --socket <cesta>    cesta k socketu\n"

#: misc-utils/uuidd.c:68
msgid " -T, --timeout <sec>     specify inactivity timeout\n"
msgstr " -T, --timeout <sekundy> časový limit nečinnosti\n"

#: misc-utils/uuidd.c:69
msgid " -k, --kill              kill running daemon\n"
msgstr " -k, --kill              zabije běžícího démona\n"

#: misc-utils/uuidd.c:70
msgid " -r, --random            test random-based generation\n"
msgstr " -r, --random            otestuje generování založené na náhodě\n"

#: misc-utils/uuidd.c:71
msgid " -t, --time              test time-based generation\n"
msgstr " -t, --time              otestuje generování založené na čase\n"

#: misc-utils/uuidd.c:72
msgid " -n, --uuids <num>       request number of uuids\n"
msgstr " -n, --uuids <počet>     požaduje počet UUID\n"

#: misc-utils/uuidd.c:73
msgid " -P, --no-pid            do not create pid file\n"
msgstr " -P, --no-pid            nevytvoří soubor s PID\n"

#: misc-utils/uuidd.c:74
msgid " -F, --no-fork           do not daemonize using double-fork\n"
msgstr " -F, --no-fork           nedémonizuje se pomocí dvojitého volání fork\n"

#: misc-utils/uuidd.c:75
msgid " -S, --socket-activation do not create listening socket\n"
msgstr " -S, --socket-activation nevytvoří naslouchací socket\n"

#: misc-utils/uuidd.c:76
msgid " -d, --debug             run in debugging mode\n"
msgstr " -d, --debug             spustí se v ladicím režimu\n"

#: misc-utils/uuidd.c:77
msgid " -q, --quiet             turn on quiet mode\n"
msgstr " -q, --quiet             zapne tichý režim\n"

#: misc-utils/uuidd.c:109
msgid "bad arguments"
msgstr "chybné argumenty"

#: misc-utils/uuidd.c:116
msgid "socket"
msgstr "socket"

#: misc-utils/uuidd.c:127
msgid "connect"
msgstr "připojování"

#: misc-utils/uuidd.c:147
msgid "write"
msgstr "zápis"

#: misc-utils/uuidd.c:155
msgid "read count"
msgstr "načtení počtu"

#: misc-utils/uuidd.c:161
msgid "bad response length"
msgstr "chybná délka odpovědi"

#: misc-utils/uuidd.c:212
#, c-format
msgid "cannot lock %s"
msgstr "%s nelze zamknout"

#: misc-utils/uuidd.c:237
msgid "couldn't create unix stream socket"
msgstr "nebylo možné vytvořit unixový proudový socket"

#: misc-utils/uuidd.c:262
#, c-format
msgid "couldn't bind unix socket %s"
msgstr "nebylo možné přilepit unixový socket %s"

#: misc-utils/uuidd.c:289
msgid "receiving signal failed"
msgstr "příjem signálu selhalo"

#: misc-utils/uuidd.c:304
msgid "timed out"
msgstr "vypršel čas"

#: misc-utils/uuidd.c:339 sys-utils/flock.c:274
msgid "cannot set up timer"
msgstr "časovač nelze nastavit"

#: misc-utils/uuidd.c:347
#, c-format
msgid "uuidd daemon is already running at pid %s"
msgstr "démon uuidd již běží s PID %s"

#: misc-utils/uuidd.c:356
#, c-format
msgid "couldn't listen on unix socket %s"
msgstr "nebylo možné zahájit naslouchání na unixovém socketu %s"

#: misc-utils/uuidd.c:366
#, c-format
msgid "could not truncate file: %s"
msgstr "soubor nebylo možné zkrátit: %s"

#: misc-utils/uuidd.c:380
msgid "sd_listen_fds() failed"
msgstr "volání sd_listen_fds() selhalo"

#: misc-utils/uuidd.c:383
msgid "no file descriptors received, check systemctl status uuidd.socket"
msgstr "žádný deskriptor souboru nebyl přijat, zkontrolujte systemctl status uuidd.socket"

#: misc-utils/uuidd.c:386
msgid "too many file descriptors received, check uuidd.socket"
msgstr "přijato příliš mnoho deskriptorů souborů, zkontrolujte uuidd.socket"

#: misc-utils/uuidd.c:414 text-utils/more.c:1353
msgid "poll failed"
msgstr "volání poll() selhalo"

#: misc-utils/uuidd.c:419
#, c-format
msgid "timeout [%d sec]\n"
msgstr "časový limit [%d sekund]\n"

#: misc-utils/uuidd.c:436 sys-utils/irqtop.c:183 sys-utils/irqtop.c:186
#: sys-utils/irqtop.c:203 term-utils/setterm.c:920 text-utils/column.c:495
#: text-utils/column.c:518
msgid "read failed"
msgstr "volání read selhalo"

#: misc-utils/uuidd.c:438
#, c-format
msgid "error reading from client, len = %d"
msgstr "chyba při čtení z klienta, délka = %d"

#: misc-utils/uuidd.c:447
#, c-format
msgid "operation %d, incoming num = %d\n"
msgstr "operace %d, příchozí počet = %d\n"

#: misc-utils/uuidd.c:450
#, c-format
msgid "operation %d\n"
msgstr "operace %d\n"

#: misc-utils/uuidd.c:466
#, c-format
msgid "Generated time UUID: %s\n"
msgstr "Vygenerované časové UUID: %s\n"

#: misc-utils/uuidd.c:476
#, c-format
msgid "Generated random UUID: %s\n"
msgstr "Vygenerované náhodné UUID: %s\n"

#: misc-utils/uuidd.c:485
#, c-format
msgid "Generated time UUID %s and %d following\n"
msgid_plural "Generated time UUID %s and %d following\n"
msgstr[0] "Vygenerované časové UUID %s a %d následující\n"
msgstr[1] "Vygenerované časové UUID %s a %d následující\n"
msgstr[2] "Vygenerované časové UUID %s a %d následujících\n"

#: misc-utils/uuidd.c:506
#, c-format
msgid "Generated %d UUID:\n"
msgid_plural "Generated %d UUIDs:\n"
msgstr[0] "Vygenerováno %d UUID:\n"
msgstr[1] "Vygenerována %d UUID:\n"
msgstr[2] "Vygenerováno %d UUID:\n"

#: misc-utils/uuidd.c:520
#, c-format
msgid "Invalid operation %d\n"
msgstr "Neplatná operace %d\n"

#: misc-utils/uuidd.c:532
#, c-format
msgid "Unexpected reply length from server %d"
msgstr "Neočekávaná délka odpovědi od serveru %d"

#: misc-utils/uuidd.c:593
msgid "failed to parse --uuids"
msgstr "hodnotu --uuids se nezdařilo rozebrat"

#: misc-utils/uuidd.c:610
msgid "uuidd has been built without support for socket activation"
msgstr "uuidd byl sestaven bez podpory aktivace socketem"

#: misc-utils/uuidd.c:629
msgid "failed to parse --timeout"
msgstr "nezdařilo se rozebrat hodnotu --timeout"

#: misc-utils/uuidd.c:642
#, c-format
msgid "socket name too long: %s"
msgstr "název socketu je příliš dlouhý: %s"

#: misc-utils/uuidd.c:649
msgid "Both --socket-activation and --socket specified. Ignoring --socket."
msgstr "Zadány přepínače --socket-activation i --socket. Ignoruje se --socket."

#: misc-utils/uuidd.c:656 misc-utils/uuidd.c:684
#, c-format
msgid "error calling uuidd daemon (%s)"
msgstr "chyba při volání démona uuidd (%s)"

#: misc-utils/uuidd.c:657 misc-utils/uuidd.c:685
msgid "unexpected error"
msgstr "neočekávaná chyba"

#: misc-utils/uuidd.c:665
#, c-format
msgid "%s and %d subsequent UUID\n"
msgid_plural "%s and %d subsequent UUIDs\n"
msgstr[0] "%s a %d následující UUID\n"
msgstr[1] "%s a %d následující UUID\n"
msgstr[2] "%s a %d následujících UUID\n"

#: misc-utils/uuidd.c:669
#, c-format
msgid "List of UUIDs:\n"
msgstr "Seznam UUID:\n"

#: misc-utils/uuidd.c:701
#, c-format
msgid "couldn't kill uuidd running at pid %d"
msgstr "zabít uuidd běžícího pod PID %d nebylo možné"

#: misc-utils/uuidd.c:706
#, c-format
msgid "Killed uuidd running at pid %d.\n"
msgstr "Démon uuidd běžící pod PID %d byl zabit.\n"

#: misc-utils/uuidgen.c:29
msgid "Create a new UUID value.\n"
msgstr "Vytvoří novou hodnotu UUID.\n"

#: misc-utils/uuidgen.c:32
msgid " -r, --random        generate random-based uuid\n"
msgstr " -r, --random        vytvoří UUID založené na náhodě\n"

#: misc-utils/uuidgen.c:33
msgid " -t, --time          generate time-based uuid\n"
msgstr " -t, --time          vytvoří UUID založené na čase\n"

#: misc-utils/uuidgen.c:34
msgid " -n, --namespace ns  generate hash-based uuid in this namespace\n"
msgstr " -n, --namespace jp  vytvoří UUID založené na otisku v tomto jmenném prostoru\n"

#: misc-utils/uuidgen.c:35
msgid " -N, --name name     generate hash-based uuid from this name\n"
msgstr " -N, --name název    vytvoří UUID založené na otisku tohoto názvu\n"

#: misc-utils/uuidgen.c:36
msgid " -m, --md5           generate md5 hash\n"
msgstr " -m, --md5           vytvoří otisk MD5\n"

#: misc-utils/uuidgen.c:37
msgid " -s, --sha1          generate sha1 hash\n"
msgstr " -s, --sha1          vytvoří otisk SHA1\n"

#: misc-utils/uuidgen.c:38
msgid " -x, --hex           interpret name as hex string\n"
msgstr " -x, --hex           interpretuje název jako šestnáctkový řetězec\n"

#: misc-utils/uuidparse.c:76
msgid "unique identifier"
msgstr "jedinečný identifikátor"

#: misc-utils/uuidparse.c:77
msgid "variant name"
msgstr "název varianty"

#: misc-utils/uuidparse.c:78
msgid "type name"
msgstr "název typu"

#: misc-utils/uuidparse.c:79
msgid "timestamp"
msgstr "časový údaj"

#: misc-utils/uuidparse.c:97
#, c-format
msgid " %s [options] <uuid ...>\n"
msgstr " %s [přepínače] <UUID…>\n"

#: misc-utils/uuidparse.c:100
msgid " -J, --json             use JSON output format"
msgstr " -J, --json             výstup formátuje do JSONu"

#: misc-utils/uuidparse.c:101
msgid " -n, --noheadings       don't print headings"
msgstr " -n, --noheadings       nevypíše záhlaví"

#: misc-utils/uuidparse.c:102
msgid " -o, --output <list>    COLUMNS to display (see below)"
msgstr " -o, --output <seznam>  zobrazí dané sloupce (vizte níže)"

#: misc-utils/uuidparse.c:103
msgid " -r, --raw              use the raw output format"
msgstr " -r, --raw              neformátovaný výstup"

#: misc-utils/uuidparse.c:172 misc-utils/uuidparse.c:191
#: misc-utils/uuidparse.c:222
msgid "invalid"
msgstr "neplatné"

#: misc-utils/uuidparse.c:186
msgid "other"
msgstr "jiné"

#: misc-utils/uuidparse.c:197
msgid "nil"
msgstr "prázdné"

#: misc-utils/uuidparse.c:202
msgid "time-based"
msgstr "založené na čase"

#: misc-utils/uuidparse.c:208
msgid "name-based"
msgstr "založené na názvu"

#: misc-utils/uuidparse.c:211
msgid "random"
msgstr "náhodné"

#: misc-utils/uuidparse.c:214
msgid "sha1-based"
msgstr "založené na SHA1"

#: misc-utils/uuidparse.c:267 misc-utils/wipefs.c:178
#: sys-utils/irq-common.c:123 sys-utils/lscpu.c:2044 sys-utils/lsns.c:807
#: sys-utils/zramctl.c:505
msgid "failed to initialize output column"
msgstr "výstupní sloupec se nepodařilo inicializovat"

#: misc-utils/whereis.c:199
#, c-format
msgid " %s [options] [-BMS <dir>... -f] <name>\n"
msgstr " %s [přepínače] [-BMS <adresář>… -f] <soubor>\n"

#: misc-utils/whereis.c:202
msgid "Locate the binary, source, and manual-page files for a command.\n"
msgstr "Najde umístění binárního, zdrojové a manuálového souboru k příkazu.\n"

#: misc-utils/whereis.c:205
msgid " -b         search only for binaries\n"
msgstr " -b         hledá pouze binární soubory\n"

#: misc-utils/whereis.c:206
msgid " -B <dirs>  define binaries lookup path\n"
msgstr ""
" -B <adresáře>\n"
"            určuje vyhledávácí cestu pro binární soubory\n"

#: misc-utils/whereis.c:207
msgid " -m         search only for manuals and infos\n"
msgstr " -m         hledá pouze manuály a info stránky\n"

#: misc-utils/whereis.c:208
msgid " -M <dirs>  define man and info lookup path\n"
msgstr ""
" -M <adresáře>\n"
"            určuje vyhledávací cestu pro manuálové a info stránky\n"

#: misc-utils/whereis.c:209
msgid " -s         search only for sources\n"
msgstr " -s         hledá pouze zdrojové kódy\n"

#: misc-utils/whereis.c:210
msgid " -S <dirs>  define sources lookup path\n"
msgstr ""
" -S <adresáře>\n"
"            určuje cestu pro hledání zdrojů\n"

#: misc-utils/whereis.c:211
msgid " -f         terminate <dirs> argument list\n"
msgstr " -f         ukončuje seznam <adresářů>\n"

#: misc-utils/whereis.c:212
msgid " -u         search for unusual entries\n"
msgstr " -u         hledá neobvyklé entity\n"

#: misc-utils/whereis.c:213
msgid " -l         output effective lookup paths\n"
msgstr " -l         vypíše výsledné vyhledávácí cesty\n"

#: misc-utils/whereis.c:652
msgid "option -f is missing"
msgstr "chybí přepínač -f"

#: misc-utils/wipefs.c:109
msgid "partition/filesystem UUID"
msgstr "UUID oddílu / souborového systému"

#: misc-utils/wipefs.c:111
msgid "magic string length"
msgstr "délka magického řetězce"

#: misc-utils/wipefs.c:112
msgid "superblok type"
msgstr "druh superbloku"

#: misc-utils/wipefs.c:113
msgid "magic string offset"
msgstr "umístění magického řetězce"

#: misc-utils/wipefs.c:114
msgid "type description"
msgstr "popis druhu"

#: misc-utils/wipefs.c:115
msgid "block device name"
msgstr "název blokového zařízení"

#: misc-utils/wipefs.c:332
msgid "partition-table"
msgstr "tabulka rozdělení disku"

#: misc-utils/wipefs.c:420
#, c-format
msgid "error: %s: probing initialization failed"
msgstr "chyba: %s: inicializace testování se nezdařila"

#: misc-utils/wipefs.c:471
#, c-format
msgid "%s: failed to erase %s magic string at offset 0x%08jx"
msgstr "%s: výmaz magického řetězce %s na pozici 0x%08jx selhal"

#: misc-utils/wipefs.c:477
#, c-format
msgid "%s: %zd byte was erased at offset 0x%08jx (%s): "
msgid_plural "%s: %zd bytes were erased at offset 0x%08jx (%s): "
msgstr[0] "%s: vymazán %zd bajt na pozici 0x%08jx (%s): "
msgstr[1] "%s: vymazány %zd bajty na pozici 0x%08jx (%s): "
msgstr[2] "%s: vymazáno %zd bajtů na pozici 0x%08jx (%s): "

#: misc-utils/wipefs.c:506
#, c-format
msgid "%s: failed to create a signature backup"
msgstr "%s: zálohu vzorce se nepodařilo vytvořit"

#: misc-utils/wipefs.c:532
#, c-format
msgid "%s: calling ioctl to re-read partition table: %m\n"
msgstr "%s: volá se ioctl() pro znovunačtení tabulky rozdělení disku: %m\n"

#: misc-utils/wipefs.c:561
msgid "failed to create a signature backup, $HOME undefined"
msgstr "zálohu vzorce se nepodařilo vytvořit, $HOME není definována"

#: misc-utils/wipefs.c:579
#, c-format
msgid "%s: ignoring nested \"%s\" partition table on non-whole disk device"
msgstr "%s: vnořená tabulka rozdělení disku „%s“ na necelodiskovém zařízení se ignoruje"

#: misc-utils/wipefs.c:608
#, c-format
msgid "%s: offset 0x%jx not found"
msgstr "%s: pozice 0x%jx nenalezena"

#: misc-utils/wipefs.c:613
msgid "Use the --force option to force erase."
msgstr "Použijte přepínač --force k vynucení výmazu."

#: misc-utils/wipefs.c:651
msgid "Wipe signatures from a device."
msgstr "Vymaže vzorce ze zařízení."

#: misc-utils/wipefs.c:654
msgid " -a, --all           wipe all magic strings (BE CAREFUL!)"
msgstr " -a, --all           odstraní všechny magické řetězce (BUĎTE OPATRNÍ!)"

#: misc-utils/wipefs.c:655
msgid " -b, --backup        create a signature backup in $HOME"
msgstr " -b, --backup        vytvoří zálohu vzorce v $HOME"

#: misc-utils/wipefs.c:656
msgid " -f, --force         force erasure"
msgstr " -f, --force         vynutí vymazání"

#: misc-utils/wipefs.c:657
msgid " -i, --noheadings    don't print headings"
msgstr " -i, --noheadings    nevypíše záhlaví"

#: misc-utils/wipefs.c:658
msgid " -J, --json          use JSON output format"
msgstr " -J, --json          výstup formátuje do JSONu"

#: misc-utils/wipefs.c:659
msgid " -n, --no-act        do everything except the actual write() call"
msgstr " -n, --no-act        udělá vše kromě vlastního volání write()"

#: misc-utils/wipefs.c:660
msgid " -o, --offset <num>  offset to erase, in bytes"
msgstr " -o, --offset <číslo>  pozice pro vymazání, v bajtech"

#: misc-utils/wipefs.c:661
msgid " -O, --output <list> COLUMNS to display (see below)"
msgstr " -O, --output <seznam>  zobrazí SLOUPCE (vizte níže)"

#: misc-utils/wipefs.c:662
msgid " -p, --parsable      print out in parsable instead of printable format"
msgstr " -p, --parseble      výpis ve strojově zpracovatelné podobě"

#: misc-utils/wipefs.c:663
msgid " -q, --quiet         suppress output messages"
msgstr " -q, --quiet         potlačí výstupní zprávy"

#: misc-utils/wipefs.c:664
msgid " -t, --types <list>  limit the set of filesystem, RAIDs or partition tables"
msgstr " -t, --types <seznam>  omezí množinu souborových systémů, diskových polí a tabulek rozdělení disku"

#: misc-utils/wipefs.c:666
#, fuzzy, c-format
msgid "     --lock[=<mode>] use exclusive device lock (%s, %s or %s)\n"
msgstr "     --color[=<kdy>]   obarví zprávy (%s, %s nebo %s)\n"

#: misc-utils/wipefs.c:784
msgid "The --backup option is meaningless in this context"
msgstr "V tomto kontextu nemá přepínač --backup smysl."

#: schedutils/chrt.c:135
msgid "Show or change the real-time scheduling attributes of a process.\n"
msgstr "Ukáže nebo změní atributy procesu týkající plánování v reálném čase.\n"

#: schedutils/chrt.c:137
msgid ""
"Set policy:\n"
" chrt [options] <priority> <command> [<arg>...]\n"
" chrt [options] --pid <priority> <pid>\n"
msgstr ""
"Nastaví politiku:\n"
"  chrt [přepínače] <priorita> <příkaz> [<argument>…]\n"
"  chrt [přepínače] --pid <priorita> <PID>\n"

#: schedutils/chrt.c:141
msgid ""
"Get policy:\n"
" chrt [options] -p <pid>\n"
msgstr ""
"Zjistí politiku:\n"
"  chrt [přepínače] -p <PID>\n"

#: schedutils/chrt.c:145
msgid "Policy options:\n"
msgstr "Přepínače politik:\n"

#: schedutils/chrt.c:146
msgid " -b, --batch          set policy to SCHED_BATCH\n"
msgstr " -b, --batch          nastaví politiku na SCHED_BATCH\n"

#: schedutils/chrt.c:147
msgid " -d, --deadline       set policy to SCHED_DEADLINE\n"
msgstr " -d, --deadline       nastaví politiku na SCHED_DEADLINE\n"

#: schedutils/chrt.c:148
msgid " -f, --fifo           set policy to SCHED_FIFO\n"
msgstr " -f, --fifo           nastaví politiku na SCHED_FIFO\n"

#: schedutils/chrt.c:149
msgid " -i, --idle           set policy to SCHED_IDLE\n"
msgstr " -i, --idle           nastaví politiku na SCHED_IDLE\n"

#: schedutils/chrt.c:150
msgid " -o, --other          set policy to SCHED_OTHER\n"
msgstr " -o, --other          nastaví politiku na SCHED_OTHER\n"

#: schedutils/chrt.c:151
msgid " -r, --rr             set policy to SCHED_RR (default)\n"
msgstr " -r, --rr             nastaví politiky na SCHED_RR (výchozí)\n"

#: schedutils/chrt.c:154
msgid "Scheduling options:\n"
msgstr "Přepínače plánování:\n"

#: schedutils/chrt.c:155
msgid " -R, --reset-on-fork       set SCHED_RESET_ON_FORK for FIFO or RR\n"
msgstr " -R, --reset-on-fork       u FIFO nebo RR nastaví SCHED_RESET_ON_FORK\n"

#: schedutils/chrt.c:156
msgid " -T, --sched-runtime <ns>  runtime parameter for DEADLINE\n"
msgstr " -T, --sched-runtime <ns>  parametr délka běhu pro DEADLINE\n"

#: schedutils/chrt.c:157
msgid " -P, --sched-period <ns>   period parameter for DEADLINE\n"
msgstr " -P, --sched-period <ns>   parametr perioda pro DEADLINE\n"

#: schedutils/chrt.c:158
msgid " -D, --sched-deadline <ns> deadline parameter for DEADLINE\n"
msgstr " -D, --sched-deadline <ns> parametr hranice pro DEADLINE\n"

#: schedutils/chrt.c:161
msgid "Other options:\n"
msgstr "Další přepínače:\n"

#: schedutils/chrt.c:162
msgid " -a, --all-tasks      operate on all the tasks (threads) for a given pid\n"
msgstr " -a, --all-tasks      pracuje nad všemi úlohami (vlákny) zadaného PID\n"

#: schedutils/chrt.c:163
msgid " -m, --max            show min and max valid priorities\n"
msgstr " -m, --max            ukáže minimální a maximální platné priority\n"

#: schedutils/chrt.c:164
msgid " -p, --pid            operate on existing given pid\n"
msgstr " -p, --pid            pracuje nad existujícím zadaném PID\n"

#: schedutils/chrt.c:165
msgid " -v, --verbose        display status information\n"
msgstr " -v, --verbose        zobrazí údaje o stavu\n"

#: schedutils/chrt.c:231 schedutils/chrt.c:253
#, c-format
msgid "failed to get pid %d's policy"
msgstr "nepodařilo se získat politiku procesu %d"

#: schedutils/chrt.c:256
#, c-format
msgid "failed to get pid %d's attributes"
msgstr "nepodařilo se získat vlastnosti procesu %d"

#: schedutils/chrt.c:266
#, c-format
msgid "pid %d's new scheduling policy: %s"
msgstr "nová plánovací politika procesu %d: %s"

#: schedutils/chrt.c:268
#, c-format
msgid "pid %d's current scheduling policy: %s"
msgstr "stávající plánovací politika procesu %d: %s"

#: schedutils/chrt.c:275
#, c-format
msgid "pid %d's new scheduling priority: %d\n"
msgstr "nová plánovací priorita procesu %d: %d\n"

#: schedutils/chrt.c:277
#, c-format
msgid "pid %d's current scheduling priority: %d\n"
msgstr "stávající plánovací priorita procesu %d: %d\n"

#: schedutils/chrt.c:282
#, c-format
msgid "pid %d's new runtime/deadline/period parameters: %ju/%ju/%ju\n"
msgstr "nové parametry délka běhu/hranice/perioda pro proces %d: %ju/%ju/%ju\n"

#: schedutils/chrt.c:285
#, c-format
msgid "pid %d's current runtime/deadline/period parameters: %ju/%ju/%ju\n"
msgstr "současné parametry délka běhu/hranice/perioda pro proces %d: %ju/%ju/%ju\n"

#: schedutils/chrt.c:299 schedutils/chrt.c:404
msgid "cannot obtain the list of tasks"
msgstr "nelze získat seznam úloh"

# First argument just completes literal policy name
#: schedutils/chrt.c:333
#, c-format
msgid "%s min/max priority\t: %d/%d\n"
msgstr "min./max. priorita %s\t: %d/%d\n"

#: schedutils/chrt.c:336
#, c-format
msgid "%s not supported?\n"
msgstr "%s není podporována?\n"

#: schedutils/chrt.c:408
#, c-format
msgid "failed to set tid %d's policy"
msgstr "politiku vlákna s TID %d se nepodařilo nastavit"

#: schedutils/chrt.c:413
#, c-format
msgid "failed to set pid %d's policy"
msgstr "politiku procesu %d se nepodařilo nastavit"

#: schedutils/chrt.c:493
msgid "invalid runtime argument"
msgstr "neplatný argument délky běhu"

#: schedutils/chrt.c:496
msgid "invalid period argument"
msgstr "neplatný argument periody"

#: schedutils/chrt.c:499
msgid "invalid deadline argument"
msgstr "neplatný argument hranice"

#: schedutils/chrt.c:524
msgid "invalid priority argument"
msgstr "neplatný argument priority"

#: schedutils/chrt.c:528
msgid "--reset-on-fork option is supported for SCHED_FIFO and SCHED_RR policies only"
msgstr "Přepínač --reset-on-fork je podporován jen u politik SCHED_FIFO a SCHED_RR"

#: schedutils/chrt.c:533
msgid "--sched-{runtime,deadline,period} options are supported for SCHED_DEADLINE only"
msgstr "Přepínače --sched-{runtime,deadline,period} jsou podporovány jen u politiky SCHED_DEADLINE"

#: schedutils/chrt.c:548
msgid "SCHED_DEADLINE is unsupported"
msgstr "SCHED_DEADLINE není podporována"

#: schedutils/chrt.c:555
#, c-format
msgid "unsupported priority value for the policy: %d: see --max for valid range"
msgstr "nepodporovaná hodnota priority pro politiku: %d: pro platný rozsah vizte --max"

#: schedutils/ionice.c:76
msgid "ioprio_get failed"
msgstr "volání ioprio_get selhalo"

#: schedutils/ionice.c:85
#, c-format
msgid "%s: prio %lu\n"
msgstr "%s: priorita %lu\n"

#: schedutils/ionice.c:98
msgid "ioprio_set failed"
msgstr "volání ioprio_set selhalo"

#: schedutils/ionice.c:105
#, c-format
msgid ""
" %1$s [options] -p <pid>...\n"
" %1$s [options] -P <pgid>...\n"
" %1$s [options] -u <uid>...\n"
" %1$s [options] <command>\n"
msgstr ""
" %1$s [přepínače] -p <PID>…\n"
" %1$s [přepínače] -P <PGID>…\n"
" %1$s [přepínače] -u <UID>…\n"
" %1$s [přepínače] <příkaz>\n"

#: schedutils/ionice.c:111
msgid "Show or change the I/O-scheduling class and priority of a process.\n"
msgstr "Ukáže nebo změní plánovací I/O třídu a prioritu procesu.\n"

#: schedutils/ionice.c:114
msgid ""
" -c, --class <class>    name or number of scheduling class,\n"
"                          0: none, 1: realtime, 2: best-effort, 3: idle\n"
msgstr ""
"  -c, --class <třída>   název nebo číslo plánovací třídy\n"
"                        0: none [žádná], 1: realtime [reálný čas],\n"
"                        2: best-effort, 3: idle [zahálení]\n"

#: schedutils/ionice.c:116
msgid ""
" -n, --classdata <num>  priority (0..7) in the specified scheduling class,\n"
"                          only for the realtime and best-effort classes\n"
msgstr ""
"  -n, --classdata <číslo>\n"
"                        priorita (0−7) v zadané plánovací třídě,\n"
"                        pouze pro třídy reálného času a best-effort\n"

#: schedutils/ionice.c:118
msgid " -p, --pid <pid>...     act on these already running processes\n"
msgstr " -p, --pid <PID>…       pracuje nad těmito již běžícími procesy\n"

#: schedutils/ionice.c:119
msgid " -P, --pgid <pgrp>...   act on already running processes in these groups\n"
msgstr " -P, --pgid <PGRP>…     pracuje nad již bežícími procesy v těchto skupinách\n"

#: schedutils/ionice.c:120
msgid " -t, --ignore           ignore failures\n"
msgstr " -t, --ignore           ignoruje selhání\n"

#: schedutils/ionice.c:121
msgid " -u, --uid <uid>...     act on already running processes owned by these users\n"
msgstr ""
" -u, --uid <UID>…       pracuje nad již bežícími procesy vlastněnými těmito\n"
"                        uživateli\n"

#: schedutils/ionice.c:157
msgid "invalid class data argument"
msgstr "neplatný argument dat plánovací třídy"

#: schedutils/ionice.c:163
msgid "invalid class argument"
msgstr "neplatný argument plánovací třídy"

#: schedutils/ionice.c:168
#, c-format
msgid "unknown scheduling class: '%s'"
msgstr "neznámá plánovací třída: „%s“"

#: schedutils/ionice.c:176 schedutils/ionice.c:184 schedutils/ionice.c:192
msgid "can handle only one of pid, pgid or uid at once"
msgstr "lze zpracovat pouze jedno PID, PGID nebo UID"

#: schedutils/ionice.c:185
msgid "invalid PGID argument"
msgstr "neplatný argument PGID"

#: schedutils/ionice.c:193
msgid "invalid UID argument"
msgstr "neplatný argument UID"

#: schedutils/ionice.c:212
msgid "ignoring given class data for none class"
msgstr "u třídy žádná se ignorují zadaná data třídy"

#: schedutils/ionice.c:220
msgid "ignoring given class data for idle class"
msgstr "u třídy zahálení [idle] se ignorují zadaná data třídy"

#: schedutils/ionice.c:225
#, c-format
msgid "unknown prio class %d"
msgstr "neznámá prioritní třída %d"

#: schedutils/taskset.c:52
#, c-format
msgid ""
"Usage: %s [options] [mask | cpu-list] [pid|cmd [args...]]\n"
"\n"
msgstr ""
"Použití: %s [přepínače] [maska | seznam_cpu] [PID | příkaz [argument…]]\n"
"\n"

#: schedutils/taskset.c:56
msgid "Show or change the CPU affinity of a process.\n"
msgstr "Zobrazí nebo změní afinitu procesu k CPU.\n"

#: schedutils/taskset.c:60
#, c-format
msgid ""
"Options:\n"
" -a, --all-tasks         operate on all the tasks (threads) for a given pid\n"
" -p, --pid               operate on existing given pid\n"
" -c, --cpu-list          display and specify cpus in list format\n"
msgstr ""
"Přepínače:\n"
" -a, --all-tasks         pracuje nad všemi úlohami (vlákny) zadaného PID\n"
" -p, --pid               pracuje nad existujícím zadaným PID\n"
" -c, --cpu-list          zobrazí a určí CPU jako seznam\n"

#: schedutils/taskset.c:69
#, c-format
msgid ""
"The default behavior is to run a new command:\n"
"    %1$s 03 sshd -b 1024\n"
"You can retrieve the mask of an existing task:\n"
"    %1$s -p 700\n"
"Or set it:\n"
"    %1$s -p 03 700\n"
"List format uses a comma-separated list instead of a mask:\n"
"    %1$s -pc 0,3,7-11 700\n"
"Ranges in list format can take a stride argument:\n"
"    e.g. 0-31:2 is equivalent to mask 0x55555555\n"
msgstr ""
"Implicitní chování je spuštění nového příkazu:\n"
"    %1$s 03 sshd -b 1024\n"
"Masku existující úlohy lze zjistit takto:\n"
"    %1$s -p 700\n"
"Nebo ji lze nastavit:\n"
"    %1$s -p 03 700\n"
"Zápis ve tvaru seznamu (místo masky) používá jako oddělovač čárku:\n"
"    %1$s -pc 0,3,7-11 700\n"
"Rozsahy v seznamu mohou mít jako argument krok:\n"
"    např. 0-31:2 je shodné s maskou 0x55555555\n"

#: schedutils/taskset.c:91
#, c-format
msgid "pid %d's new affinity list: %s\n"
msgstr "seznam nové afinity procesu %d: %s\n"

#: schedutils/taskset.c:92
#, c-format
msgid "pid %d's current affinity list: %s\n"
msgstr "seznam současné afinity procesu %d: %s\n"

#: schedutils/taskset.c:95
#, c-format
msgid "pid %d's new affinity mask: %s\n"
msgstr "maska nové afinity procesu %d: %s\n"

#: schedutils/taskset.c:96
#, c-format
msgid "pid %d's current affinity mask: %s\n"
msgstr "maska současné afinity procesu %d: %s\n"

#: schedutils/taskset.c:100
msgid "internal error: conversion from cpuset to string failed"
msgstr "vnitřní chyba: převod z cpuset na řetězec selhal"

#: schedutils/taskset.c:109
#, c-format
msgid "failed to set pid %d's affinity"
msgstr "afinitu procesu %d se nepodařilo nastavit"

#: schedutils/taskset.c:110
#, c-format
msgid "failed to get pid %d's affinity"
msgstr "nepodařilo se získat afinitu procesu s PID %d"

#: schedutils/taskset.c:194 sys-utils/chcpu.c:300
msgid "cannot determine NR_CPUS; aborting"
msgstr "nelze zjistit počet CPU, činnost ukončena"

#: schedutils/taskset.c:203 schedutils/taskset.c:216 sys-utils/chcpu.c:307
msgid "cpuset_alloc failed"
msgstr "alokace cpuset_alloc selhala"

#: schedutils/taskset.c:223 sys-utils/chcpu.c:234
#, c-format
msgid "failed to parse CPU list: %s"
msgstr "seznam CPU se nezdařilo rozebrat: %s"

#: schedutils/taskset.c:226
#, c-format
msgid "failed to parse CPU mask: %s"
msgstr "masku CPU se nezdařilo rozebrat: %s"

#: sys-utils/blkdiscard.c:70
#, c-format
msgid "%s: Zero-filled %<PRIu64> bytes from the offset %<PRIu64>\n"
msgstr "%s: %<PRIu64> bajtů od pozice %<PRIu64> zaplněno nulami\n"

#: sys-utils/blkdiscard.c:75
#, c-format
msgid "%s: Discarded %<PRIu64> bytes from the offset %<PRIu64>\n"
msgstr "%s: %<PRIu64> bajtů od pozice %<PRIu64> zahozeno\n"

#: sys-utils/blkdiscard.c:89
msgid "Discard the content of sectors on a device.\n"
msgstr "Zahodí obsah sektorů na zařízení.\n"

#: sys-utils/blkdiscard.c:92
#, fuzzy
msgid " -f, --force         disable all checking\n"
msgstr " -f, --force               vypne veškeré kontroly soudržnosti\n"

#: sys-utils/blkdiscard.c:93
msgid " -o, --offset <num>  offset in bytes to discard from\n"
msgstr ""
" -o, --offset <číslo>\n"
"                     pozice v bajtech, od které zahájit zahazování\n"

#: sys-utils/blkdiscard.c:94
msgid " -l, --length <num>  length of bytes to discard from the offset\n"
msgstr ""
" -l, --length <číslo>\n"
"                     počet bajtů na zahození od dané pozice\n"

#: sys-utils/blkdiscard.c:95
msgid " -p, --step <num>    size of the discard iterations within the offset\n"
msgstr " -p, --step <číslo>  velikost operací zahození uvnitř pozice\n"

#: sys-utils/blkdiscard.c:96
msgid " -s, --secure        perform secure discard\n"
msgstr " -s, --secure        provede bezpečné zahození dat\n"

#: sys-utils/blkdiscard.c:97
msgid " -z, --zeroout       zero-fill rather than discard\n"
msgstr " -z, --zeroout       namísto zahození vyplní nulami\n"

#: sys-utils/blkdiscard.c:98
msgid " -v, --verbose       print aligned length and offset\n"
msgstr " -v, --verbose       vypíše zarovnanou délku a pozici\n"

#: sys-utils/blkdiscard.c:188 sys-utils/fstrim.c:504 sys-utils/losetup.c:706
#: text-utils/hexdump.c:124
msgid "failed to parse offset"
msgstr "nezdařilo se rozebrat začátek oblasti"

#: sys-utils/blkdiscard.c:192
msgid "failed to parse step"
msgstr "krok se nezdařilo rozebrat"

#: sys-utils/blkdiscard.c:219 sys-utils/blkzone.c:463 sys-utils/fallocate.c:379
#: sys-utils/fsfreeze.c:110 sys-utils/fstrim.c:532 sys-utils/umount.c:588
msgid "unexpected number of arguments"
msgstr "neočekávaný počet argumentů"

#: sys-utils/blkdiscard.c:233
#, c-format
msgid "%s: BLKGETSIZE64 ioctl failed"
msgstr "%s: IOCTL volání BLKGETSIZE64 selhalo"

#: sys-utils/blkdiscard.c:235 sys-utils/blkzone.c:150
#, c-format
msgid "%s: BLKSSZGET ioctl failed"
msgstr "%s: IOCTL volání BLKSSZGET selhalo"

#: sys-utils/blkdiscard.c:239
#, c-format
msgid "%s: offset %<PRIu64> is not aligned to sector size %i"
msgstr "%s: začátek %<PRIu64> není zarovnán na velikost sektoru %i"

#: sys-utils/blkdiscard.c:244 sys-utils/blkzone.c:320
#, c-format
msgid "%s: offset is greater than device size"
msgstr "%s: začátek je větší než velikost zařízení"

#: sys-utils/blkdiscard.c:253
#, c-format
msgid "%s: length %<PRIu64> is not aligned to sector size %i"
msgstr "%s: délka %<PRIu64> není zarovnána na velikost sektoru %i"

#: sys-utils/blkdiscard.c:265
#, fuzzy
msgid "This is destructive operation, data will be lost! Use the -f option to override."
msgstr "%s se nachází na jiném systému souborů než zbytek (vynutit lze přepínačem -f)."

#: sys-utils/blkdiscard.c:268
msgid "Operation forced, data will be lost!"
msgstr ""

#: sys-utils/blkdiscard.c:273
#, fuzzy
msgid "failed to probe the device"
msgstr "alokace zařízení selhala"

#: sys-utils/blkdiscard.c:287
#, c-format
msgid "%s: BLKZEROOUT ioctl failed"
msgstr "%s: IOCTL volání BLKZEROOUT selhalo"

#: sys-utils/blkdiscard.c:291
#, c-format
msgid "%s: BLKSECDISCARD ioctl failed"
msgstr "%s: IOCTL volání BLKSECDISCARD selhalo"

#: sys-utils/blkdiscard.c:295
#, c-format
msgid "%s: BLKDISCARD ioctl failed"
msgstr "%s: IOCTL volání BLKDISCARD selhalo"

#: sys-utils/blkzone.c:92
msgid "Report zone information about the given device"
msgstr "Vypíše zónové údaje o zadaném zařízení"

#: sys-utils/blkzone.c:98
msgid "Reset a range of zones."
msgstr "Resetuje rozsah zón."

#: sys-utils/blkzone.c:104
#, fuzzy
msgid "Open a range of zones."
msgstr "Resetuje rozsah zón."

#: sys-utils/blkzone.c:110
#, fuzzy
msgid "Close a range of zones."
msgstr "Resetuje rozsah zón."

#: sys-utils/blkzone.c:116
#, fuzzy
msgid "Set a range of zones to Full."
msgstr "Resetuje rozsah zón."

#: sys-utils/blkzone.c:147
#, c-format
msgid "%s: blkdev_get_sectors ioctl failed"
msgstr "%s: IOCTL volání blkdev_get_sectors selhalo"

#: sys-utils/blkzone.c:227
#, c-format
msgid "%s: offset is greater than or equal to device size"
msgstr "%s: začátek je větší nebo roven velikosti zařízení"

#: sys-utils/blkzone.c:231 sys-utils/blkzone.c:310
#, c-format
msgid "%s: unable to determine zone size"
msgstr "%s: velikost zóny nelze určit"

#: sys-utils/blkzone.c:249
#, c-format
msgid "%s: BLKREPORTZONE ioctl failed"
msgstr "%s: IOCTL volání BLKREPORTZONE selhalo"

#  TODO: Pluralize
#: sys-utils/blkzone.c:252
#, c-format
msgid "Found %d zones from 0x%<PRIx64>\n"
msgstr "Nenalezeno %d zón od 0x%<PRIx64>\n"

#: sys-utils/blkzone.c:278
#, c-format
msgid "  start: 0x%09<PRIx64>, len 0x%06<PRIx64>, wptr 0x%06<PRIx64> reset:%u non-seq:%u, zcond:%2u(%s) [type: %u(%s)]\n"
msgstr "  začátek: 0x%09<PRIx64>, délka 0x%06<PRIx64>, ukazatel zápisu: 0x%06<PRIx64>, reset: %u nesekv.: %u, stav: %2u (%s) [druh: %u (%s)]\n"

#: sys-utils/blkzone.c:315
#, c-format
msgid "%s: offset %<PRIu64> is not aligned to zone size %lu"
msgstr "%s: začátek %<PRIu64> není zarovnán na velikost zóny %lu"

#: sys-utils/blkzone.c:334
#, c-format
msgid "%s: number of sectors %<PRIu64> is not aligned to zone size %lu"
msgstr "%s: počet sektorů %<PRIu64> není zarovnán na velikost zóny %lu"

#: sys-utils/blkzone.c:342
#, fuzzy, c-format
msgid "%s: %s ioctl failed"
msgstr "%s: IOCTL volání FITRIM selhalo"

#: sys-utils/blkzone.c:345
#, fuzzy, c-format
msgid "%s: successful %s of zones in range from %<PRIu64>, to %<PRIu64>"
msgstr "%s: úspěšně resetováno v rozsahu od %<PRIu64> do %<PRIu64>"

#: sys-utils/blkzone.c:360
#, c-format
msgid " %s <command> [options] <device>\n"
msgstr " %s <příkaz> [přepínače] <zařízení>\n"

#: sys-utils/blkzone.c:363
msgid "Run zone command on the given block device.\n"
msgstr "Spustí zónový příkaz na zadaném blokovém zařízení.\n"

#: sys-utils/blkzone.c:370
msgid " -o, --offset <sector>  start sector of zone to act (in 512-byte sectors)\n"
msgstr " -o, --offset <sektor>  pracuje od tohoto sektoru zóny (v 512bajtech sektorech)\n"

#: sys-utils/blkzone.c:371
msgid " -l, --length <sectors> maximum sectors to act (in 512-byte sectors)\n"
msgstr " -l, --length <sektory> zpracuje maximum sektorů (v 512bajtových sektorech)\n"

#: sys-utils/blkzone.c:372
msgid " -c, --count <number>   maximum number of zones\n"
msgstr " -c, --count <počet>    maximální počet zón\n"

#: sys-utils/blkzone.c:373
#, fuzzy
msgid " -f, --force            enforce on block devices used by the system\n"
msgstr " -f, --force            vynutí pevné odkazy mezi souborovými systémy"

#: sys-utils/blkzone.c:374
msgid " -v, --verbose          display more details\n"
msgstr " -v, --verbose          vypisuje více podrobností\n"

#: sys-utils/blkzone.c:379
#, fuzzy
msgid "<sector> and <sectors>"
msgstr "počet sektorů: %d, velikost sektoru: %d\n"

#: sys-utils/blkzone.c:417
#, c-format
msgid "%s is not valid command name"
msgstr "%s není platným názvem příkazu"

#: sys-utils/blkzone.c:429
msgid "failed to parse number of zones"
msgstr "nezdařilo se rozebrat počet zón"

#: sys-utils/blkzone.c:433
msgid "failed to parse number of sectors"
msgstr "nezdařilo se rozebrat počet sektorů"

#: sys-utils/blkzone.c:437
msgid "failed to parse zone offset"
msgstr "nezdařilo se rozebrat začátek zóny"

#: sys-utils/blkzone.c:456 sys-utils/setsid.c:92
msgid "no command specified"
msgstr "nezadán žádný příkaz"

#: sys-utils/chcpu.c:84 sys-utils/chcpu.c:181
#, c-format
msgid "CPU %u does not exist"
msgstr "CPU %u neexistuje"

#: sys-utils/chcpu.c:89
#, c-format
msgid "CPU %u is not hot pluggable"
msgstr "CPU %u není vyměnitelné za běhu"

#: sys-utils/chcpu.c:96
#, c-format
msgid "CPU %u is already enabled\n"
msgstr "CPU %u již je zapnuto\n"

#: sys-utils/chcpu.c:100
#, c-format
msgid "CPU %u is already disabled\n"
msgstr "CPU %u je již vypnuto\n"

#: sys-utils/chcpu.c:108
#, c-format
msgid "CPU %u enable failed (CPU is deconfigured)"
msgstr "Zapnutí CPU %u selhalo (CPU je odnastaveno)"

#: sys-utils/chcpu.c:111
#, c-format
msgid "CPU %u enable failed"
msgstr "Zapnutí CPU %u selhalo"

#: sys-utils/chcpu.c:114
#, c-format
msgid "CPU %u enabled\n"
msgstr "CPU %u zapnuto\n"

#: sys-utils/chcpu.c:117
#, c-format
msgid "CPU %u disable failed (last enabled CPU)"
msgstr "Vypnutí CPU %u selhalo (poslední zapnuté CPU)"

#: sys-utils/chcpu.c:123
#, c-format
msgid "CPU %u disable failed"
msgstr "Vypnutí CPU %u selhalo"

#: sys-utils/chcpu.c:126
#, c-format
msgid "CPU %u disabled\n"
msgstr "CPU %u vypnuto\n"

#: sys-utils/chcpu.c:139
msgid "This system does not support rescanning of CPUs"
msgstr "Tento systém nepodporuje opakované hledání CPU"

#: sys-utils/chcpu.c:142
msgid "Failed to trigger rescan of CPUs"
msgstr "Spuštění hledání CPU selhalo"

#: sys-utils/chcpu.c:144
#, c-format
msgid "Triggered rescan of CPUs\n"
msgstr "Hledání CPU spuštěno\n"

#: sys-utils/chcpu.c:151
msgid "This system does not support setting the dispatching mode of CPUs"
msgstr "Tento systém nepodporuje nastavování režimu rozhodování CPU"

#: sys-utils/chcpu.c:155
msgid "Failed to set horizontal dispatch mode"
msgstr "Selhalo nastavení vodorovného režimu rozhodování"

#: sys-utils/chcpu.c:157
#, c-format
msgid "Successfully set horizontal dispatching mode\n"
msgstr "Vodorovný režim rozhodování úspěšně nastaven\n"

#: sys-utils/chcpu.c:160
msgid "Failed to set vertical dispatch mode"
msgstr "Selhalo nastavení svislého režimu rozhodování"

#: sys-utils/chcpu.c:162
#, c-format
msgid "Successfully set vertical dispatching mode\n"
msgstr "Svislý režim rozhodování úspěšně nastaven\n"

#: sys-utils/chcpu.c:186
#, c-format
msgid "CPU %u is not configurable"
msgstr "CPU %u není nastavitelné"

#: sys-utils/chcpu.c:192
#, c-format
msgid "CPU %u is already configured\n"
msgstr "CPU %u je již nastaveno\n"

#: sys-utils/chcpu.c:196
#, c-format
msgid "CPU %u is already deconfigured\n"
msgstr "CPU %u je již odnastaveno\n"

#: sys-utils/chcpu.c:201
#, c-format
msgid "CPU %u deconfigure failed (CPU is enabled)"
msgstr "Odnastavení CPU %u selhalo (CPU je zapnuto)"

# FIX: configure is a verb, use configuration
#: sys-utils/chcpu.c:208
#, c-format
msgid "CPU %u configure failed"
msgstr "Nastavení CPU %u selhalo"

#: sys-utils/chcpu.c:211
#, c-format
msgid "CPU %u configured\n"
msgstr "CPU %u nastaveno\n"

# FIX: deconfigure is a verb, use deconfiguration
#: sys-utils/chcpu.c:215
#, c-format
msgid "CPU %u deconfigure failed"
msgstr "Odnastavení CPU %u selhalo"

#: sys-utils/chcpu.c:218
#, c-format
msgid "CPU %u deconfigured\n"
msgstr "CPU %u odnastaveno\n"

#: sys-utils/chcpu.c:233
#, c-format
msgid "invalid CPU number in CPU list: %s"
msgstr "neplatné číslo CPU v seznamu CPU: %s"

#: sys-utils/chcpu.c:241 text-utils/col.c:131
#, c-format
msgid ""
"\n"
"Usage:\n"
" %s [options]\n"
msgstr ""
"\n"
"Použití:\n"
" %s [přepínače]\n"

#: sys-utils/chcpu.c:245
msgid "Configure CPUs in a multi-processor system.\n"
msgstr "Nastaví jednotky CPU ve víceprocesorovém systému.\n"

#: sys-utils/chcpu.c:249
msgid ""
" -e, --enable <cpu-list>       enable cpus\n"
" -d, --disable <cpu-list>      disable cpus\n"
" -c, --configure <cpu-list>    configure cpus\n"
" -g, --deconfigure <cpu-list>  deconfigure cpus\n"
" -p, --dispatch <mode>         set dispatching mode\n"
" -r, --rescan                  trigger rescan of cpus\n"
msgstr ""
" -e, --enable <seznam_CPU>       zapne CPU\n"
" -d, --disable <seznam_CPU>      vypne CPU\n"
" -c, --configure <seznam_CPU>    nastaví CPU\n"
" -g, --deconfigure <seznam_cpu>  odnastaví CPU\n"
" -p, --dispatch <režim>          nastaví režim rozhodování\n"
" -r, --rescan                    spustí hledání CPU\n"

#: sys-utils/chcpu.c:296
msgid "failed to initialize sysfs handler"
msgstr "nepodařilo inicializovat deskriptor sysfs"

#: sys-utils/chcpu.c:338
#, c-format
msgid "unsupported argument: %s"
msgstr "nepodporovaný argument: %s"

#: sys-utils/chmem.c:100
#, c-format
msgid "Memory Block %<PRIu64> (0x%016<PRIx64>-0x%016<PRIx64>)"
msgstr "Blok paměti %<PRIu64> (0x%016<PRIx64>–0x%016<PRIx64>)"

#: sys-utils/chmem.c:124 sys-utils/chmem.c:197
msgid "Failed to parse index"
msgstr "Index se nezdařilo rozebrat"

#: sys-utils/chmem.c:151
#, c-format
msgid "%s enable failed\n"
msgstr "Zapnutí %s selhalo\n"

#: sys-utils/chmem.c:153
#, c-format
msgid "%s disable failed\n"
msgstr "Vypnutí %s selhalo\n"

#: sys-utils/chmem.c:156 sys-utils/chmem.c:242
#, c-format
msgid "%s enabled\n"
msgstr "%s zapnuto\n"

#: sys-utils/chmem.c:158 sys-utils/chmem.c:244
#, c-format
msgid "%s disabled\n"
msgstr "%s vypnuto\n"

#: sys-utils/chmem.c:170
#, c-format
msgid "Could only enable %s of memory"
msgstr "Bylo možné zapnout jen %s paměti"

#: sys-utils/chmem.c:172
#, c-format
msgid "Could only disable %s of memory"
msgstr "Bylo možné vypnout jen %s paměti"

#: sys-utils/chmem.c:206
#, c-format
msgid "%s already enabled\n"
msgstr "%s je již zapnuto\n"

#: sys-utils/chmem.c:208
#, c-format
msgid "%s already disabled\n"
msgstr "%s je již vypnuto\n"

#: sys-utils/chmem.c:218
#, c-format
msgid "%s enable failed: Zone mismatch"
msgstr "Zapnutí %s selhalo: neodpovídá zóna"

#: sys-utils/chmem.c:222
#, c-format
msgid "%s disable failed: Zone mismatch"
msgstr "Vypnutí %s selhalo: neodpovídá zóna"

#: sys-utils/chmem.c:237
#, c-format
msgid "%s enable failed"
msgstr "Zapnutí %s selhalo"

#: sys-utils/chmem.c:239
#, c-format
msgid "%s disable failed"
msgstr "Vypnutí %s selhalo"

#: sys-utils/chmem.c:265 sys-utils/lsmem.c:490
#, c-format
msgid "Failed to read %s"
msgstr "%s nebylo možné přečíst"

#: sys-utils/chmem.c:273
msgid "Failed to parse block number"
msgstr "Číslo bloku se nezdařilo rozebrat"

#: sys-utils/chmem.c:278
msgid "Failed to parse size"
msgstr "Velikost se nezdařilo rozebrat"

#: sys-utils/chmem.c:282
#, c-format
msgid "Size must be aligned to memory block size (%s)"
msgstr "Velikost musí být zarovnána na velikost paměťových bloků (%s)"

#: sys-utils/chmem.c:291
msgid "Failed to parse start"
msgstr "Začátek se nezdařilo rozebrat"

#: sys-utils/chmem.c:292
msgid "Failed to parse end"
msgstr "Konec se nezdařilo rozebrat"

#: sys-utils/chmem.c:296
#, c-format
msgid "Invalid start address format: %s"
msgstr "Neplatný formát počáteční adresy: %s"

#: sys-utils/chmem.c:298
#, c-format
msgid "Invalid end address format: %s"
msgstr "Neplatný formát koncové adresy: %s"

#: sys-utils/chmem.c:299
msgid "Failed to parse start address"
msgstr "Počáteční adresu se nezdařilo rozebrat"

#: sys-utils/chmem.c:300
msgid "Failed to parse end address"
msgstr "Koncovou adresu se nezdařilo rozebrat"

#: sys-utils/chmem.c:303
#, c-format
msgid "Start address and (end address + 1) must be aligned to memory block size (%s)"
msgstr "Počáteční adresa a (koncová + 1) musí být zarovnána na velikost paměťového bloku (%s)"

#: sys-utils/chmem.c:317
#, c-format
msgid "Invalid parameter: %s"
msgstr "Neplatný parametr: %s"

#: sys-utils/chmem.c:324
#, c-format
msgid "Invalid range: %s"
msgstr "Neplatný rozsah: %s"

#: sys-utils/chmem.c:333
#, c-format
msgid " %s [options] [SIZE|RANGE|BLOCKRANGE]\n"
msgstr " %s [přepínače] [VELIKOST|ROZSAH|ROZSAH_BLOKŮ]\n"

#: sys-utils/chmem.c:336
msgid "Set a particular size or range of memory online or offline.\n"
msgstr "Označí určitou velikost nebo rozsah paměti jako připojený nebo odpojený.\n"

#: sys-utils/chmem.c:339
msgid " -e, --enable       enable memory\n"
msgstr " -e, --enable       zapne paměť\n"

#: sys-utils/chmem.c:340
msgid " -d, --disable      disable memory\n"
msgstr " -d, --disable      vypne paměť\n"

#: sys-utils/chmem.c:341
msgid " -b, --blocks       use memory blocks\n"
msgstr " -b, --blocks       použije bloky paměti\n"

#: sys-utils/chmem.c:342
msgid " -z, --zone <name>  select memory zone (see below)\n"
msgstr " -z, --zone <název> vybere zónu paměti (vizte níže)\n"

#: sys-utils/chmem.c:343
msgid " -v, --verbose      verbose output\n"
msgstr " -v, --verbose      podrobný výstup\n"

#: sys-utils/chmem.c:346
msgid ""
"\n"
"Supported zones:\n"
msgstr ""
"\n"
"Podporované zóny:\n"

#: sys-utils/chmem.c:387 sys-utils/lscpu.c:1444 sys-utils/lsmem.c:654
#, c-format
msgid "failed to initialize %s handler"
msgstr "nepodařilo inicializovat deskriptor %s"

#: sys-utils/chmem.c:433
msgid "zone ignored, no valid_zones sysfs attribute present"
msgstr "zóna ignorována, chybí sysfs atribut valid_zones"

#: sys-utils/chmem.c:438
#, c-format
msgid "unknown memory zone: %s"
msgstr "neznámá zóna paměti: %s"

#: sys-utils/choom.c:38
#, c-format
msgid ""
" %1$s [options] -p pid\n"
" %1$s [options] -n number -p pid\n"
" %1$s [options] -n number [--] command [args...]]\n"
msgstr ""
" %1$s [přepínače] -p PID\n"
" %1$s [přepínače] -n číslo -p PID\n"
" %1$s [přepínače] -n číslo [--] příkaz [argumenty…]]\n"

#: sys-utils/choom.c:44
msgid "Display and adjust OOM-killer score.\n"
msgstr "Zobrazí a změní skóre zabijáka OOM.\n"

#: sys-utils/choom.c:47
msgid " -n, --adjust <num>     specify the adjust score value\n"
msgstr " -n, --adjust <číslo>   určuje hodnotu úpravy skóre\n"

#: sys-utils/choom.c:48
msgid " -p, --pid <num>        process ID\n"
msgstr " -p, --pid <číslo>      ID procesu\n"

#: sys-utils/choom.c:60
msgid "failed to read OOM score value"
msgstr "nezdařilo se přečíst hodnou skóre OOM"

#: sys-utils/choom.c:70
msgid "failed to read OOM score adjust value"
msgstr "nezdařilo se přečíst hodnotu úpravy skóre OOM"

#: sys-utils/choom.c:105
msgid "invalid adjust argument"
msgstr "neplatný argument přepínače --adjust"

#: sys-utils/choom.c:119 term-utils/mesg.c:177
#, c-format
msgid "invalid argument: %s"
msgstr "neplatný argument: %s"

#: sys-utils/choom.c:123
msgid "no PID or COMMAND specified"
msgstr "nezadán žádný PID ani PŘÍKAZ"

#: sys-utils/choom.c:127
msgid "no OOM score adjust value specified"
msgstr "nezadána žádná hodnota úpravy skóre OOM"

#: sys-utils/choom.c:135
#, c-format
msgid "pid %d's current OOM score: %d\n"
msgstr "stávající OOM skóre procesu %d: %d\n"

#: sys-utils/choom.c:136
#, c-format
msgid "pid %d's current OOM score adjust value: %d\n"
msgstr "stávající hodnota úpravy OOM skóre procesu %d: %d\n"

#: sys-utils/choom.c:143 sys-utils/choom.c:150
msgid "failed to set score adjust value"
msgstr "nezdařilo se nastavit hodnotu úpravy skóre"

#: sys-utils/choom.c:145
#, c-format
msgid "pid %d's OOM score adjust value changed from %d to %d\n"
msgstr "hodnota úpravy OOM skóre procesu %d změněna z %d na %d\n"

#: sys-utils/ctrlaltdel.c:28
#, c-format
msgid " %s hard|soft\n"
msgstr " %s hard|soft\n"

#: sys-utils/ctrlaltdel.c:31
#, c-format
msgid "Set the function of the Ctrl-Alt-Del combination.\n"
msgstr "Nastaví funkci kombinace kláves Ctrl-Alt-Del.\n"

#: sys-utils/ctrlaltdel.c:54
msgid "implicit"
msgstr "výchozí"

#: sys-utils/ctrlaltdel.c:55
#, c-format
msgid "unexpected value in %s: %ju"
msgstr "neočekávaná hodnota v %s: %ju"

#: sys-utils/ctrlaltdel.c:66
msgid "You must be root to set the Ctrl-Alt-Del behavior"
msgstr "Musíte být root, abyste mohli nastavit chování Ctrl-Alt-Del"

#: sys-utils/ctrlaltdel.c:74 sys-utils/ipcrm.c:395 sys-utils/ipcrm.c:418
#, c-format
msgid "unknown argument: %s"
msgstr "neznámý argument: %s"

#: sys-utils/dmesg.c:109
msgid "system is unusable"
msgstr "systém je nepoužitelný"

#: sys-utils/dmesg.c:110
msgid "action must be taken immediately"
msgstr "je třeba okamžité reakce"

#: sys-utils/dmesg.c:111
msgid "critical conditions"
msgstr "kritický stav"

#: sys-utils/dmesg.c:112
msgid "error conditions"
msgstr "chybový stav"

#: sys-utils/dmesg.c:113
msgid "warning conditions"
msgstr "stav stojící za pozornost"

#: sys-utils/dmesg.c:114
msgid "normal but significant condition"
msgstr "běžná, ale významná událost"

#: sys-utils/dmesg.c:115
msgid "informational"
msgstr "informační"

#: sys-utils/dmesg.c:116
msgid "debug-level messages"
msgstr "ladicí zprávy"

#: sys-utils/dmesg.c:130
msgid "kernel messages"
msgstr "jaderné zprávy"

#: sys-utils/dmesg.c:131
msgid "random user-level messages"
msgstr "náhodné uživatelské zprávy"

#: sys-utils/dmesg.c:132
msgid "mail system"
msgstr "poštovní systém"

#: sys-utils/dmesg.c:133
msgid "system daemons"
msgstr "systémoví démoni"

#: sys-utils/dmesg.c:134
msgid "security/authorization messages"
msgstr "bezpečnostní/autorizační zprávy"

#: sys-utils/dmesg.c:135
msgid "messages generated internally by syslogd"
msgstr "zprávy vnitřně vytvořené démonem syslogd"

#: sys-utils/dmesg.c:136
msgid "line printer subsystem"
msgstr "tiskový podsystém"

#: sys-utils/dmesg.c:137
msgid "network news subsystem"
msgstr "podsystém usenetu (news)"

#: sys-utils/dmesg.c:138
msgid "UUCP subsystem"
msgstr "podsystém UUCP"

#: sys-utils/dmesg.c:139
msgid "clock daemon"
msgstr "časový démon"

#: sys-utils/dmesg.c:140
msgid "security/authorization messages (private)"
msgstr "bezpečnostní/autorizační zprávy (soukromé)"

#: sys-utils/dmesg.c:141
msgid "FTP daemon"
msgstr "démon FTP"

#: sys-utils/dmesg.c:272
msgid "Display or control the kernel ring buffer.\n"
msgstr "Zobrazí nebo ovládá kruhový jaderný buffer.\n"

#: sys-utils/dmesg.c:275
msgid " -C, --clear                 clear the kernel ring buffer\n"
msgstr " -C, --clear                 vyprázdní kruhový buffer v jádře\n"

#: sys-utils/dmesg.c:276
msgid " -c, --read-clear            read and clear all messages\n"
msgstr " -c, --read-clear            přečte a vyprázdní zprávy\n"

#: sys-utils/dmesg.c:277
msgid " -D, --console-off           disable printing messages to console\n"
msgstr " -D, --console-off           vypne vypisování zpráv do konzoly\n"

#: sys-utils/dmesg.c:278
msgid " -E, --console-on            enable printing messages to console\n"
msgstr " -E, --console-on            zapne vypisování zpráv do konzoly\n"

#: sys-utils/dmesg.c:279
msgid " -F, --file <file>           use the file instead of the kernel log buffer\n"
msgstr " -F, --file <soubor>         použije zadaný soubor místo jaderného bufferu\n"

#: sys-utils/dmesg.c:280
msgid " -f, --facility <list>       restrict output to defined facilities\n"
msgstr " -f, --facility <seznam>     výstup omezí na zadané obory\n"

#: sys-utils/dmesg.c:281
msgid " -H, --human                 human readable output\n"
msgstr " -H, --human                 výstup čitelný pro lidi\n"

#: sys-utils/dmesg.c:282
msgid " -k, --kernel                display kernel messages\n"
msgstr " -k, --kernel                zobrazí jaderné zprávy\n"

#: sys-utils/dmesg.c:284
#, c-format
msgid " -L, --color[=<when>]        colorize messages (%s, %s or %s)\n"
msgstr " -L, --color[=<kdy>]         obarví zprávy (%s, %s nebo %s)\n"

#: sys-utils/dmesg.c:287
msgid " -l, --level <list>          restrict output to defined levels\n"
msgstr " -l, --level <seznam>        výstup omezí na zadané úrovně\n"

#: sys-utils/dmesg.c:288
msgid " -n, --console-level <level> set level of messages printed to console\n"
msgstr " -n, --console-level <úroveň> nastaví úroveň zpráv vypisovaných do konzoly\n"

#: sys-utils/dmesg.c:289
msgid " -P, --nopager               do not pipe output into a pager\n"
msgstr " -P, --nopager               výstup neodešle rourou do stránkovače\n"

#: sys-utils/dmesg.c:290
msgid " -p, --force-prefix          force timestamp output on each line of multi-line messages\n"
msgstr ""
" -p, --force-prefix          vypíše časový údaj na každém řádku víceřádkové\n"
"                             zprávy\n"

#: sys-utils/dmesg.c:291
msgid " -r, --raw                   print the raw message buffer\n"
msgstr " -r, --raw                   vypíše buffer zpráv v neopracované podobě\n"

#: sys-utils/dmesg.c:292
msgid "     --noescape              don't escape unprintable character\n"
msgstr "     --noescape              neescapuje netisknutelné znaky\n"

#: sys-utils/dmesg.c:293
msgid " -S, --syslog                force to use syslog(2) rather than /dev/kmsg\n"
msgstr " -S, --syslog                vynutí použití syslog(2) místo /dev/kmsg\n"

#: sys-utils/dmesg.c:294
msgid " -s, --buffer-size <size>    buffer size to query the kernel ring buffer\n"
msgstr ""
" -s, --buffer-size <velikost> velikost bufferu, na který se zeptat jaderného\n"
"                              kruhové bufferu\n"

#: sys-utils/dmesg.c:295
msgid " -u, --userspace             display userspace messages\n"
msgstr " -u, --userspace             vypíše zprávy z uživatelského prostoru\n"

#: sys-utils/dmesg.c:296
msgid " -w, --follow                wait for new messages\n"
msgstr " -w, --follow                čeká na nové zprávy\n"

#: sys-utils/dmesg.c:297
#, fuzzy
msgid " -W, --follow-new            wait and print only new messages\n"
msgstr " -w, --follow                čeká na nové zprávy\n"

#: sys-utils/dmesg.c:298
msgid " -x, --decode                decode facility and level to readable string\n"
msgstr " -x, --decode                obory a úrovně převede na čitelné řetězce\n"

#: sys-utils/dmesg.c:299
msgid " -d, --show-delta            show time delta between printed messages\n"
msgstr " -d, --show-delta            ukáže časové rozdíly mezi hláškami\n"

#: sys-utils/dmesg.c:300
msgid " -e, --reltime               show local time and time delta in readable format\n"
msgstr " -e, --reltime               ukáže místní čas a časový rozdíl v čitelné podobě\n"

#: sys-utils/dmesg.c:301
msgid " -T, --ctime                 show human-readable timestamp (may be inaccurate!)\n"
msgstr ""
" -T, --ctime                 ukáže časové údaje v čitelné podobě (může být\n"
"                             nepřesné!)\n"

#: sys-utils/dmesg.c:302
msgid " -t, --notime                don't show any timestamp with messages\n"
msgstr " -t, --notime                neukazuje u zpráv žádní časové údaje\n"

#: sys-utils/dmesg.c:303
msgid ""
"     --time-format <format>  show timestamp using the given format:\n"
"                               [delta|reltime|ctime|notime|iso]\n"
"Suspending/resume will make ctime and iso timestamps inaccurate.\n"
msgstr ""
"     --time-format <formát>  zobrazuje časové údaje v daném formátu:\n"
"                             [delta|reltime|ctime|notime|iso]\n"
"                             (rozdíl, relativní, čitelný, žádný, ISO)\n"
"Uspání/probuzení způsobuje nepřesnosti při formátu ctime a iso.\n"

#: sys-utils/dmesg.c:308
msgid ""
"\n"
"Supported log facilities:\n"
msgstr ""
"\n"
"Podporované obory protokolu:\n"

#: sys-utils/dmesg.c:314
msgid ""
"\n"
"Supported log levels (priorities):\n"
msgstr ""
"\n"
"Podporované úrovně (priority) protokolu:\n"

#: sys-utils/dmesg.c:368
#, c-format
msgid "failed to parse level '%s'"
msgstr "nezdařilo se rozebrat úroveň „%s“"

#: sys-utils/dmesg.c:370
#, c-format
msgid "unknown level '%s'"
msgstr "neznámá úroveň „%s“"

#: sys-utils/dmesg.c:406
#, c-format
msgid "failed to parse facility '%s'"
msgstr "nezdařilo se rozebrat obor „%s“"

#: sys-utils/dmesg.c:408
#, c-format
msgid "unknown facility '%s'"
msgstr "neznámý obor „%s"

#: sys-utils/dmesg.c:536
#, c-format
msgid "cannot mmap: %s"
msgstr "nelze namapovat do paměti: %s"

#: sys-utils/dmesg.c:1463
msgid "invalid buffer size argument"
msgstr "neplatný argument velikosti bufferu"

#: sys-utils/dmesg.c:1527
msgid "--show-delta is ignored when used together with iso8601 time format"
msgstr "přepínač --show-delta se ignoruje, je-li použit formát času ISO 8601"

#: sys-utils/dmesg.c:1550
msgid "--raw can be used together with --level or --facility only when reading messages from /dev/kmsg"
msgstr "--raw lze použít spolu s --level nebo --facility pouze při čtení zpráv z /dev/kmsg"

#: sys-utils/dmesg.c:1565
msgid "read kernel buffer failed"
msgstr "čtení z jaderného bufferu selhalo"

#: sys-utils/dmesg.c:1584
msgid "klogctl failed"
msgstr "volání klogctl selhalo"

#: sys-utils/eject.c:138
#, c-format
msgid " %s [options] [<device>|<mountpoint>]\n"
msgstr " %s [přepínače] [<zařízení>|<bod_připojení>]\n"

#: sys-utils/eject.c:141
msgid "Eject removable media.\n"
msgstr "Vysune výměnné médium.\n"

#: sys-utils/eject.c:144
msgid ""
" -a, --auto <on|off>         turn auto-eject feature on or off\n"
" -c, --changerslot <slot>    switch discs on a CD-ROM changer\n"
" -d, --default               display default device\n"
" -f, --floppy                eject floppy\n"
" -F, --force                 don't care about device type\n"
" -i, --manualeject <on|off>  toggle manual eject protection on/off\n"
" -m, --no-unmount            do not unmount device even if it is mounted\n"
" -M, --no-partitions-unmount do not unmount another partitions\n"
" -n, --noop                  don't eject, just show device found\n"
" -p, --proc                  use /proc/mounts instead of /etc/mtab\n"
" -q, --tape                  eject tape\n"
" -r, --cdrom                 eject CD-ROM\n"
" -s, --scsi                  eject SCSI device\n"
" -t, --trayclose             close tray\n"
" -T, --traytoggle            toggle tray\n"
" -v, --verbose               enable verbose output\n"
" -x, --cdspeed <speed>       set CD-ROM max speed\n"
" -X, --listspeed             list CD-ROM available speeds\n"
msgstr ""
" -a, --auto <on|off>         zapne (on) / vypne (off) automatické vysouvání\n"
" -c, --changerslot <pozice>  vymění disk v CD-ROM měniči\n"
" -d, --default               zobrazí výchozí zařízení\n"
" -f, --floppy                vysune disketu\n"
" -F, --force                 nestará se o typ zařízení\n"
" -i, --manualeject <on|off>  zapne (on) / vypne (off) ochrnu proti ručnímu\n"
"                             vysunutí\n"
" -m, --no-unmount            neodpojí zařízení, i když je připojeno\n"
" -M, --no-partitions-unmount neodpojí další oddíly\n"
" -n, --noop                  nevysunuje, jen ukáže, jestli zařízení existuje\n"
" -p, --proc                  použije /proc/mounts místo /etc/mtab\n"
" -q, --tape                  vysune pásku\n"
" -r, --cdrom                 vysune CD-ROM\n"
" -s, --scsi                  vysune SCSI zařízení\n"
" -t, --trayclose             zavře dvířka\n"
" -T, --traytoggle            změní polohu dvířek\n"
" -v, --verbose               povolí podrobná hlášení\n"
" -x, --cdspeed <rychlost     nastaví nejvyšší rychlost CD-ROM\n"
" -X, --listspeed             vypíše dostupné rychlosti CD-ROM\n"

#: sys-utils/eject.c:167
msgid ""
"\n"
"By default tries -r, -s, -f, and -q in order until success.\n"
msgstr ""
"\n"
"Jako výchozí se zkouší -r, -s, -f a -q v tomto pořadí, dokud neuspěje.\n"

#: sys-utils/eject.c:213
msgid "invalid argument to --changerslot/-c option"
msgstr "neplatný argument přepínače --changerslot/-c"

#: sys-utils/eject.c:217
msgid "invalid argument to --cdspeed/-x option"
msgstr "neplatný argument přepínače --cdspeed/-x"

#: sys-utils/eject.c:325
msgid "CD-ROM auto-eject command failed"
msgstr "příkaz pro automatické vysunutí CD-ROM selhal"

#: sys-utils/eject.c:339
msgid "CD-ROM door lock is not supported"
msgstr "Zamykání dvířek CD-ROM není podporováno"

#: sys-utils/eject.c:341
msgid "other users have the drive open and not CAP_SYS_ADMIN"
msgstr "ostatní uživatelé mají jednotku otevřenou a ne CAP_SYS_ADMIN"

#: sys-utils/eject.c:343
msgid "CD-ROM lock door command failed"
msgstr "příkaz pro zamknutí dvířek CD-ROM selhal"

#: sys-utils/eject.c:348
msgid "CD-Drive may NOT be ejected with device button"
msgstr "Jednotka CD NESMÍ být za pomoci tlačítka vysunována"

#: sys-utils/eject.c:350
msgid "CD-Drive may be ejected with device button"
msgstr "Jednotka CD smí být za pomoci tlačítka vysunována"

#: sys-utils/eject.c:361
msgid "CD-ROM select disc command failed"
msgstr "příkaz pro volbu disku CD-ROM selhal"

#: sys-utils/eject.c:365
msgid "CD-ROM load from slot command failed"
msgstr "příkaz pro načtení CD-ROM ze zásobníku měniče selhal"

#: sys-utils/eject.c:367
msgid "IDE/ATAPI CD-ROM changer not supported by this kernel\n"
msgstr "toto jádro nepodporuje IDE/ATAPI CD-ROM měnič\n"

#: sys-utils/eject.c:385
msgid "CD-ROM tray close command failed"
msgstr "příkaz pro zavření dvířek CD-ROM selhal"

#: sys-utils/eject.c:387
msgid "CD-ROM tray close command not supported by this kernel\n"
msgstr "toto jádro nepodporuje příkaz pro zavření dvířek CD-ROM\n"

#: sys-utils/eject.c:404
msgid "CD-ROM eject unsupported"
msgstr "vysunování CD-ROM není podporováno"

#: sys-utils/eject.c:432 sys-utils/eject.c:455 sys-utils/eject.c:1020
msgid "CD-ROM eject command failed"
msgstr "příkaz pro vysunutí CD-ROM selhal"

#: sys-utils/eject.c:435
msgid "no CD-ROM information available"
msgstr "údaje o CD-ROM nejsou dostupné"

#: sys-utils/eject.c:438
msgid "CD-ROM drive is not ready"
msgstr "jednotka CD-ROM není připravena"

#: sys-utils/eject.c:441
msgid "CD-ROM status command failed"
msgstr "příkaz pro zjištění stavu CD-ROM selhal"

#: sys-utils/eject.c:481
msgid "CD-ROM select speed command failed"
msgstr "příkaz pro volbu rychlosti CD-ROM selhal"

#: sys-utils/eject.c:483
msgid "CD-ROM select speed command not supported by this kernel"
msgstr "toto jádro nepodporuje příkaz pro volbu rychlosti CD-ROM"

#: sys-utils/eject.c:520
#, c-format
msgid "%s: failed to finding CD-ROM name"
msgstr "%s: chyba při vyhledávání názvu CD-ROM"

#: sys-utils/eject.c:535
#, c-format
msgid "%s: failed to read speed"
msgstr "%s: nepodařilo se přečíst rychlost"

#: sys-utils/eject.c:543
msgid "failed to read speed"
msgstr "nepodařilo se přečíst rychlost"

#: sys-utils/eject.c:583
msgid "not an sg device, or old sg driver"
msgstr "není SG zařízením, nebo se jedná o starý SG ovladač"

#: sys-utils/eject.c:655
#, c-format
msgid "%s: unmounting"
msgstr "%s: odpojuje se"

#: sys-utils/eject.c:673
msgid "unable to fork"
msgstr "nelze rozvětvit proces"

#: sys-utils/eject.c:680
#, c-format
msgid "unmount of `%s' did not exit normally"
msgstr "odpojení „%s“ neskončilo normálně"

#: sys-utils/eject.c:683
#, c-format
msgid "unmount of `%s' failed\n"
msgstr "odpojení „%s“ selhalo\n"

#: sys-utils/eject.c:728
msgid "failed to parse mount table"
msgstr "tabulku připojení se nepodařilo rozebrat"

#: sys-utils/eject.c:794 sys-utils/eject.c:896
#, c-format
msgid "%s: mounted on %s"
msgstr "%s: připojeno do %s"

#: sys-utils/eject.c:837
msgid "setting CD-ROM speed to auto"
msgstr "rychlost CD-ROM se nastavuje na automatickou"

#: sys-utils/eject.c:839
#, c-format
msgid "setting CD-ROM speed to %ldX"
msgstr "rychlost CD-ROM se nastavuje na %ld×"

#: sys-utils/eject.c:865
#, c-format
msgid "default device: `%s'"
msgstr "výchozí zařízení: „%s“"

#: sys-utils/eject.c:871
#, c-format
msgid "using default device `%s'"
msgstr "používá se výchozí zařízení „%s“"

#: sys-utils/eject.c:890
#, fuzzy
msgid "unable to find device"
msgstr "%s: zařízení nelze nalézt"

#: sys-utils/eject.c:892
#, c-format
msgid "device name is `%s'"
msgstr "název zařízení je „%s“"

#: sys-utils/eject.c:898 sys-utils/umount.c:343 sys-utils/umount.c:367
#, c-format
msgid "%s: not mounted"
msgstr "%s: nepřipojeno"

#: sys-utils/eject.c:902
#, c-format
msgid "%s: disc device: %s (disk device will be used for eject)"
msgstr "%s: zařízení disku: %s (zařízení disku se použije pro vysunutí)"

#: sys-utils/eject.c:910
#, c-format
msgid "%s: not found mountpoint or device with the given name"
msgstr "%s: nebyl nalezen bod připojení nebo zařízení se zadaným jménem"

#: sys-utils/eject.c:913
#, c-format
msgid "%s: is whole-disk device"
msgstr "%s: jedná se o zařízení přes celý disk"

#: sys-utils/eject.c:917
#, c-format
msgid "%s: is not hot-pluggable device"
msgstr "%s: není zařízením, které lze za běhu zapojit"

#: sys-utils/eject.c:921
#, c-format
msgid "device is `%s'"
msgstr "zařízení je „%s“"

#: sys-utils/eject.c:922
msgid "exiting due to -n/--noop option"
msgstr "končí se na základě volby -n/--noop"

#: sys-utils/eject.c:936
#, c-format
msgid "%s: enabling auto-eject mode"
msgstr "%s: povoluje režim automatického vysunutí"

#: sys-utils/eject.c:938
#, c-format
msgid "%s: disabling auto-eject mode"
msgstr "%s: zakazuje se režim automatického vysunutí"

#: sys-utils/eject.c:946
#, c-format
msgid "%s: closing tray"
msgstr "%s: zavírají se dvířka"

#: sys-utils/eject.c:955
#, c-format
msgid "%s: toggling tray"
msgstr "%s: dvířka se přesunují"

#: sys-utils/eject.c:964
#, c-format
msgid "%s: listing CD-ROM speed"
msgstr "%s: vypisují se rychlosti CD-ROM"

#: sys-utils/eject.c:990
#, c-format
msgid "error: %s: device in use"
msgstr "chyba: %s: zařízení se právě používá"

#: sys-utils/eject.c:1001
#, c-format
msgid "%s: selecting CD-ROM disc #%ld"
msgstr "%s: volí se CD-ROM disk č. %ld"

#: sys-utils/eject.c:1017
#, c-format
msgid "%s: trying to eject using CD-ROM eject command"
msgstr "%s: zkouší se vysunout s použitím příkazu pro vysunutí CD-ROM"

#: sys-utils/eject.c:1019
msgid "CD-ROM eject command succeeded"
msgstr "příkaz pro vysunutí CD-ROM uspěl"

#: sys-utils/eject.c:1024
#, c-format
msgid "%s: trying to eject using SCSI commands"
msgstr "%s: zkouší se vysunout s použitím příkazů SCSI"

#: sys-utils/eject.c:1026
msgid "SCSI eject succeeded"
msgstr "příkaz SCSI pro vysunutí uspěl"

#: sys-utils/eject.c:1027
msgid "SCSI eject failed"
msgstr "příkaz SCSI pro vysunutí selhal"

#: sys-utils/eject.c:1031
#, c-format
msgid "%s: trying to eject using floppy eject command"
msgstr "%s: zkouší se vysunout s použitím příkazu pro vysunutí diskety"

#: sys-utils/eject.c:1033
msgid "floppy eject command succeeded"
msgstr "příkaz pro vysunutí diskety uspěl"

#: sys-utils/eject.c:1034
msgid "floppy eject command failed"
msgstr "příkaz pro vysunutí diskety selhal"

#: sys-utils/eject.c:1038
#, c-format
msgid "%s: trying to eject using tape offline command"
msgstr "%s: zkouší se vysunout s použitím příkazu pro odpojení pásky"

#: sys-utils/eject.c:1040
msgid "tape offline command succeeded"
msgstr "příkaz pro odpojení pásky uspěl"

#: sys-utils/eject.c:1041
msgid "tape offline command failed"
msgstr "příkaz pro odpojení pásky selhal"

#: sys-utils/eject.c:1045
msgid "unable to eject"
msgstr "nelze vysunout"

#: sys-utils/fallocate.c:84
#, c-format
msgid " %s [options] <filename>\n"
msgstr " %s [přepínače] <název_souboru>\n"

#: sys-utils/fallocate.c:87
msgid "Preallocate space to, or deallocate space from a file.\n"
msgstr "Rezervuje nebo ruší rezervaci místa v souboru.\n"

#: sys-utils/fallocate.c:90
msgid " -c, --collapse-range remove a range from the file\n"
msgstr " -c, --collapse-range odstraní rozsah ze souboru\n"

#: sys-utils/fallocate.c:91
msgid " -d, --dig-holes      detect zeroes and replace with holes\n"
msgstr " -d, --dig-holes      nalezne nuly a nahradí je dírami\n"

#: sys-utils/fallocate.c:92
msgid " -i, --insert-range   insert a hole at range, shifting existing data\n"
msgstr " -i, --insert-range   vloží díru do rozsahu, existující data posune\n"

#: sys-utils/fallocate.c:93
msgid " -l, --length <num>   length for range operations, in bytes\n"
msgstr " -l, --length <číslo> délka rozsahových operací v bajtech\n"

#: sys-utils/fallocate.c:94
msgid " -n, --keep-size      maintain the apparent size of the file\n"
msgstr " -n, --keep-size      udržuje zdánlivou velikost souboru\n"

#: sys-utils/fallocate.c:95
msgid " -o, --offset <num>   offset for range operations, in bytes\n"
msgstr " -o, --offset <číslo> pozice pro rozsahové operace v bajtech\n"

#: sys-utils/fallocate.c:96
msgid " -p, --punch-hole     replace a range with a hole (implies -n)\n"
msgstr " -p, --punch-hole     nahradí rozsah dírou (znamená -n)\n"

#: sys-utils/fallocate.c:97
msgid " -z, --zero-range     zero and ensure allocation of a range\n"
msgstr " -z, --zero-range     vynuluje a zajistí alokaci rozsahu\n"

#: sys-utils/fallocate.c:99
msgid " -x, --posix          use posix_fallocate(3) instead of fallocate(2)\n"
msgstr " -x, --posix          použije posix_fallocate(3) namísto fallocate(2)\n"

#: sys-utils/fallocate.c:139
msgid "fallocate failed: keep size mode is unsupported"
msgstr "volání fallocate selhalo: režim neměnné velikosti není podporován"

#: sys-utils/fallocate.c:140 sys-utils/fallocate.c:149
msgid "fallocate failed"
msgstr "volání fallocate selhalo"

#: sys-utils/fallocate.c:237
#, c-format
msgid "%s: read failed"
msgstr "%s: volání read selhalo"

#: sys-utils/fallocate.c:278
#, c-format
msgid "%s: %s (%ju bytes) converted to sparse holes.\n"
msgstr "%s: %s (%ju bajtů) převedeno na řídké díry.\n"

#: sys-utils/fallocate.c:358
msgid "posix_fallocate support is not compiled"
msgstr "podpora pro posix_fallocate není zakompilována"

#: sys-utils/fallocate.c:374 sys-utils/fsfreeze.c:106
msgid "no filename specified"
msgstr "nezadán název souboru"

#: sys-utils/fallocate.c:386 sys-utils/fallocate.c:392
msgid "invalid length value specified"
msgstr "zadána neplatná hodnota délky"

#: sys-utils/fallocate.c:390
msgid "no length argument specified"
msgstr "nezadán argument s délkou"

#: sys-utils/fallocate.c:395
msgid "invalid offset value specified"
msgstr "zadána neplatná hodnota pozice"

#: sys-utils/flock.c:53
#, c-format
msgid ""
" %1$s [options] <file>|<directory> <command> [<argument>...]\n"
" %1$s [options] <file>|<directory> -c <command>\n"
" %1$s [options] <file descriptor number>\n"
msgstr ""
" %1$s [přepínače] <soubor>|<adresář> <příkaz> [<argument>…]\n"
" %1$s [přepínače] <soubor>|<adresář> -c <příkaz>\n"
" %1$s [přepínače] <číslo deskriptoru souboru>\n"

#: sys-utils/flock.c:59
msgid "Manage file locks from shell scripts.\n"
msgstr "Spravuje zámky souborů z shellových skriptů.\n"

#: sys-utils/flock.c:62
msgid " -s, --shared             get a shared lock\n"
msgstr " -s, --shared             získá sdílený zámek\n"

#: sys-utils/flock.c:63
msgid " -x, --exclusive          get an exclusive lock (default)\n"
msgstr " -x, --exclusive          získá výlučný zámek (výchozí)\n"

#: sys-utils/flock.c:64
msgid " -u, --unlock             remove a lock\n"
msgstr " -u, --unlock             odstraní zámek\n"

#: sys-utils/flock.c:65
msgid " -n, --nonblock           fail rather than wait\n"
msgstr " -n, --nonblock           místo čekání selže\n"

#: sys-utils/flock.c:66
msgid " -w, --timeout <secs>     wait for a limited amount of time\n"
msgstr " -w, --timeout <sekundy>  čeká nejvýše zadanou dobu\n"

#: sys-utils/flock.c:67
msgid " -E, --conflict-exit-code <number>  exit code after conflict or timeout\n"
msgstr ""
" -E, --conflict-exit-code <číslo>   návratový kód při konfliktu nebo\n"
"                                    vypršení časového limitu\n"

#: sys-utils/flock.c:68
msgid " -o, --close              close file descriptor before running command\n"
msgstr ""
" -o, --close              před spuštěním příkazu uzavře deskriptor\n"
"                          souboru\n"

#: sys-utils/flock.c:69
msgid " -c, --command <command>  run a single command string through the shell\n"
msgstr " -c, --command <příkaz>   spustí řetězec jako jediný příkaz shellu\n"

#: sys-utils/flock.c:70
msgid " -F, --no-fork            execute command without forking\n"
msgstr " -F, --no-fork            vykoná příkaz bez volání fork\n"

#: sys-utils/flock.c:71
msgid "     --verbose            increase verbosity\n"
msgstr "     --verbose            zvýší podrobnost hlášek\n"

#: sys-utils/flock.c:108
#, c-format
msgid "cannot open lock file %s"
msgstr "soubor zámku %s nelze otevřít"

#: sys-utils/flock.c:210
msgid "invalid timeout value"
msgstr "chybná hodnota časového limitu"

#: sys-utils/flock.c:214
msgid "invalid exit code"
msgstr "neplatné návratový kód"

#: sys-utils/flock.c:231
msgid "the --no-fork and --close options are incompatible"
msgstr "přepínače --no-fork a --close se vylučují"

#: sys-utils/flock.c:239
#, c-format
msgid "%s requires exactly one command argument"
msgstr "přepínač %s vyžaduje přesně jeden příkazový argument"

#: sys-utils/flock.c:257
msgid "bad file descriptor"
msgstr "špatný deskriptor souboru"

#: sys-utils/flock.c:260
msgid "requires file descriptor, file or directory"
msgstr "vyžaduje deskriptor souboru, soubor nebo adresář"

#: sys-utils/flock.c:284
msgid "failed to get lock"
msgstr "zámek se nepodařilo získat"

#: sys-utils/flock.c:291
msgid "timeout while waiting to get lock"
msgstr "během čekání na zámek vypršel časový limit"

#: sys-utils/flock.c:332
#, c-format
msgid "%s: getting lock took %ld.%06ld seconds\n"
msgstr "%s: získání zámku trvalo %ld,%06ld sekundy\n"

#: sys-utils/flock.c:343
#, c-format
msgid "%s: executing %s\n"
msgstr "%s: spuštění %s\n"

#: sys-utils/fsfreeze.c:41
#, c-format
msgid " %s [options] <mountpoint>\n"
msgstr " %s [přepínače] <bod_připojení>\n"

#: sys-utils/fsfreeze.c:44
msgid "Suspend access to a filesystem.\n"
msgstr "Pozastaví přístup na souborový systém.\n"

#: sys-utils/fsfreeze.c:47
msgid " -f, --freeze      freeze the filesystem\n"
msgstr " -f, --freeze      zmrazí systém souborů\n"

#: sys-utils/fsfreeze.c:48
msgid " -u, --unfreeze    unfreeze the filesystem\n"
msgstr " -u, --unfreeze    rozmrazí systém souborů\n"

#: sys-utils/fsfreeze.c:104
msgid "neither --freeze or --unfreeze specified"
msgstr "nezadáno ani --freeze ani --unfreeze"

#: sys-utils/fsfreeze.c:124
#, c-format
msgid "%s: is not a directory"
msgstr "%s: není adresářem"

#: sys-utils/fsfreeze.c:131
#, c-format
msgid "%s: freeze failed"
msgstr "%s: zmrazení se nezdařilo"

#: sys-utils/fsfreeze.c:137
#, c-format
msgid "%s: unfreeze failed"
msgstr "%s: rozmrazení se nezdařilo"

#: sys-utils/fstrim.c:80
#, c-format
msgid "%s: not a directory"
msgstr "%s: není adresářem"

#: sys-utils/fstrim.c:94
#, c-format
msgid "cannot get realpath: %s"
msgstr "reálnou cestu nelze zjistit: %s"

#: sys-utils/fstrim.c:110
#, c-format
msgid "%s: 0 B (dry run) trimmed on %s\n"
msgstr "%s: zahozeno 0 B (zkušební režim) v %s\n"

#: sys-utils/fstrim.c:112
#, c-format
msgid "%s: 0 B (dry run) trimmed\n"
msgstr "%s: 0 B (zkušební režim) zahozeno\n"

#: sys-utils/fstrim.c:129
#, c-format
msgid "%s: FITRIM ioctl failed"
msgstr "%s: IOCTL volání FITRIM selhalo"

#. TRANSLATORS: The standard value here is a very large number.
#: sys-utils/fstrim.c:139
#, c-format
msgid "%s: %s (%<PRIu64> bytes) trimmed on %s\n"
msgstr "%s: %s (%'<PRIu64> bajtů) zahozeno v %s\n"

#. TRANSLATORS: The standard value here is a very large number.
#: sys-utils/fstrim.c:143
#, c-format
msgid "%s: %s (%<PRIu64> bytes) trimmed\n"
msgstr "%s: %s (%'<PRIu64> bajtů) zahozeno\n"

#: sys-utils/fstrim.c:249 sys-utils/lsns.c:1079 sys-utils/swapon.c:732
#: sys-utils/umount.c:259
#, c-format
msgid "failed to parse %s"
msgstr "%s se nezdařilo rozebrat"

#: sys-utils/fstrim.c:275
msgid "failed to allocate FS handler"
msgstr "alokace deskriptoru souborového systému selhala"

#: sys-utils/fstrim.c:363 sys-utils/fstrim.c:544
#, c-format
msgid "%s: the discard operation is not supported"
msgstr "%s: operace zahození (discard) není podporována"

#: sys-utils/fstrim.c:414
#, c-format
msgid " %s [options] <mount point>\n"
msgstr " %s [přepínače] <bod_připojení>\n"

#: sys-utils/fstrim.c:417
msgid "Discard unused blocks on a mounted filesystem.\n"
msgstr "Zahodí nepoužívané bloky připojeného souborového systému.\n"

#: sys-utils/fstrim.c:420
#, fuzzy
msgid " -a, --all                trim mounted filesystems\n"
msgstr " -a, --all               odpojí všechny souborové systémy\n"

#: sys-utils/fstrim.c:421
#, fuzzy
msgid " -A, --fstab              trim filesystems from /etc/fstab\n"
msgstr ""
" -A, --fstab         uklidí všechny podporované připojené souborové systémy\n"
"                     v /etc/fstab\n"

#: sys-utils/fstrim.c:422
#, fuzzy
msgid " -I, --listed-in <list>   trim filesystems listed in specified files\n"
msgstr " -w, --whitelist-environment <seznam> neresetuje zadané proměnné\n"

#: sys-utils/fstrim.c:423
#, fuzzy
msgid " -o, --offset <num>       the offset in bytes to start discarding from\n"
msgstr ""
" -o, --offset <číslo>\n"
"                     pozice v bajtech, od které zahájit zahazování\n"

#: sys-utils/fstrim.c:424
#, fuzzy
msgid " -l, --length <num>       the number of bytes to discard\n"
msgstr ""
" -l, --length <číslo>\n"
"                     počet bajtů na zahození\n"

#: sys-utils/fstrim.c:425
#, fuzzy
msgid " -m, --minimum <num>      the minimum extent length to discard\n"
msgstr ""
" -m, --minimum <číslo>\n"
"                     nejmenší délka rozsahu na zahození\n"

#: sys-utils/fstrim.c:426
#, fuzzy
msgid " -v, --verbose            print number of discarded bytes\n"
msgstr " -v, --verbose       vypíše počet zahozených bajtů\n"

#: sys-utils/fstrim.c:427
#, fuzzy
msgid "     --quiet-unsupported  suppress error messages if trim unsupported\n"
msgstr "     --quiet         potlačí chybová hlášení zahození\n"

#: sys-utils/fstrim.c:428
#, fuzzy
msgid " -n, --dry-run            does everything, but trim\n"
msgstr " -n, --dry-run       provede vše až na úklid\n"

#: sys-utils/fstrim.c:508
msgid "failed to parse minimum extent length"
msgstr "nezdařilo se rozebrat délku nejmenšího rozsahu"

#: sys-utils/fstrim.c:527
msgid "no mountpoint specified"
msgstr "nezadán žádný bod připojení"

#: sys-utils/hwclock.c:211
#, c-format
msgid "Assuming hardware clock is kept in %s time.\n"
msgstr "Předpokládám, že hodiny reálného času jsou nastaveny na %s čas.\n"

#: sys-utils/hwclock.c:212 sys-utils/hwclock.c:276
msgid "UTC"
msgstr "UTC"

#: sys-utils/hwclock.c:212 sys-utils/hwclock.c:275
msgid "local"
msgstr "místní"

#: sys-utils/hwclock.c:262
msgid ""
"Warning: unrecognized third line in adjtime file\n"
"(Expected: `UTC' or `LOCAL' or nothing.)"
msgstr ""
"Varování: neznámý formát třetího řádku v souboru adjtime\n"
"(Očekáváno: „UTC“ nebo „LOCAL“ nebo nic.)"

#: sys-utils/hwclock.c:269
#, c-format
msgid "Last drift adjustment done at %ld seconds after 1969\n"
msgstr "Poslední oprava posunu proběhla %ld sekund od roku 1969.\n"

#: sys-utils/hwclock.c:271
#, c-format
msgid "Last calibration done at %ld seconds after 1969\n"
msgstr "Poslední kalibrace proběhla %ld sekund od roku 1969.\n"

#: sys-utils/hwclock.c:273
#, c-format
msgid "Hardware clock is on %s time\n"
msgstr "Hodiny reálného času jsou nastaveny na %s čas.\n"

#: sys-utils/hwclock.c:300
#, c-format
msgid "Waiting for clock tick...\n"
msgstr "čekám na tik hodin…\n"

#: sys-utils/hwclock.c:306
#, c-format
msgid "...synchronization failed\n"
msgstr "…synchronizace se nezdařila\n"

#: sys-utils/hwclock.c:308
#, c-format
msgid "...got clock tick\n"
msgstr "…hodiny tikly\n"

#: sys-utils/hwclock.c:349
#, c-format
msgid "Invalid values in hardware clock: %4d/%.2d/%.2d %.2d:%.2d:%.2d\n"
msgstr "Hodiny reálného času obsahují chybné hodnoty: %4d/%.2d/%.2d %.2d:%.2d:%.2d\n"

#: sys-utils/hwclock.c:357
#, c-format
msgid "Hw clock time : %4d/%.2d/%.2d %.2d:%.2d:%.2d = %ld seconds since 1969\n"
msgstr "Hodiny reálného času: %4d/%.2d/%.2d %.2d:%.2d:%.2d = %ld sekund od roku 1969\n"

#: sys-utils/hwclock.c:384
#, c-format
msgid "Time read from Hardware Clock: %4d/%.2d/%.2d %02d:%02d:%02d\n"
msgstr "Hodiny reálného času ukazují %4d/%.2d/%.2d %02d:%02d:%02d\n"

#: sys-utils/hwclock.c:411
#, c-format
msgid "Setting Hardware Clock to %.2d:%.2d:%.2d = %ld seconds since 1969\n"
msgstr "Nastavuji hodiny reálného času na %.2d:%.2d:%.2d = %ld sekund od roku 1969\n"

#: sys-utils/hwclock.c:447
#, c-format
msgid "RTC type: '%s'\n"
msgstr "Druh RTC: „%s“\n"

#: sys-utils/hwclock.c:547
#, c-format
msgid "Using delay: %.6f seconds\n"
msgstr "Použije se zpoždění: %.6f sekundy\n"

#: sys-utils/hwclock.c:566
#, c-format
msgid "time jumped backward %.6f seconds to %ld.%06ld - retargeting\n"
msgstr "čas skočil zpět o %.6f sekund na %ld,%06ld – znovu se zaměřuje\n"

#: sys-utils/hwclock.c:588
#, c-format
msgid "missed it - %ld.%06ld is too far past %ld.%06ld (%.6f > %.6f)\n"
msgstr "vedle – %ld.%06ld je příliš daleko za %ld,%06ld (%.6f > %.6f)\n"

#: sys-utils/hwclock.c:615
#, c-format
msgid ""
"%ld.%06ld is close enough to %ld.%06ld (%.6f < %.6f)\n"
"Set RTC to %ld (%ld + %d; refsystime = %ld.%06ld)\n"
msgstr ""
"%ld,%06ld je dost blízko k %ld,%06ld (%.6f < %.6f)\n"
"Nastavit RTC na %ld (%ld + %d; refsystime = %ld,%06ld)\n"

#: sys-utils/hwclock.c:701
#, fuzzy
msgid "Calling settimeofday(NULL, 0) to lock the warp_clock function."
msgstr "Volá se settimeofday(NULL, 0), aby se zamkla urychlující funkce (warp)."

#: sys-utils/hwclock.c:704
#, fuzzy, c-format
msgid "Calling settimeofday(NULL, %d) to set the kernel timezone.\n"
msgstr "Volá se settimeofday(NULL, 0), aby se zamkla urychlující funkce (warp)."

#: sys-utils/hwclock.c:708
#, fuzzy, c-format
msgid "Calling settimeofday(NULL, %d) to warp System time, set PCIL and the kernel tz.\n"
msgstr "Volá se settimeofday(NULL, %d), aby se nestavilo persistent_clock_is_local.\n"

#: sys-utils/hwclock.c:713
#, fuzzy, c-format
msgid "Calling settimeofday(%ld.%06ld, NULL) to set the System time.\n"
msgstr "Volá se settimeofday(%ld.%06ld, %d)\n"

#: sys-utils/hwclock.c:735
msgid "settimeofday() failed"
msgstr "volání settimeofday() selhalo"

#: sys-utils/hwclock.c:759
#, c-format
msgid "Not adjusting drift factor because the --update-drift option was not used.\n"
msgstr "Míra posunu se neopraví, protože přepínač --update-drift nebyl použit.\n"

#: sys-utils/hwclock.c:763
#, c-format
msgid ""
"Not adjusting drift factor because last calibration time is zero,\n"
"so history is bad and calibration startover is necessary.\n"
msgstr ""
"Míra posunu se neopraví, protože čas poslední kalibrace je nula, takže\n"
"historie je nepoužitelná a je nutné provézt kalibraci znovu.\n"

#: sys-utils/hwclock.c:769
#, c-format
msgid "Not adjusting drift factor because it has been less than four hours since the last calibration.\n"
msgstr "Míra posunu se neopraví, protože od poslední kalibrace ještě neuplynuly čtyři hodiny.\n"

#: sys-utils/hwclock.c:807
#, c-format
msgid ""
"Clock drift factor was calculated as %f seconds/day.\n"
"It is far too much. Resetting to zero.\n"
msgstr ""
"Systematický posun hodin byl vypočten na %f sekund/den.\n"
"To je příliš mnoho. Nastavuje na nulu.\n"

#: sys-utils/hwclock.c:814
#, c-format
msgid ""
"Clock drifted %f seconds in the past %f seconds\n"
"in spite of a drift factor of %f seconds/day.\n"
"Adjusting drift factor by %f seconds/day\n"
msgstr ""
"Hodiny se za posledních %2$f sekund rozešly o %1$f sekund,\n"
"přestože míra posunu je nastavena na %3$f sekund/den.\n"
"Míra posunu se opravuje na %4$f sekund/den.\n"

#: sys-utils/hwclock.c:858
#, c-format
msgid "Time since last adjustment is %ld second\n"
msgid_plural "Time since last adjustment is %ld seconds\n"
msgstr[0] "Doba od poslední opravy je %ld sekunda\n"
msgstr[1] "Doba od poslední opravy je %ld sekundy\n"
msgstr[2] "Doba od poslední opravy je %ld sekund\n"

#: sys-utils/hwclock.c:862
#, c-format
msgid "Calculated Hardware Clock drift is %ld.%06ld seconds\n"
msgstr "Vypočtený systematický posun hardwarových hodin je %ld,%06ld sekund\n"

#: sys-utils/hwclock.c:887
#, c-format
msgid ""
"New %s data:\n"
"%s"
msgstr ""
"Nová data %s:\n"
"%s"

#: sys-utils/hwclock.c:899
#, c-format
msgid "cannot update %s"
msgstr "%s nelze aktualizovat"

#: sys-utils/hwclock.c:935
#, c-format
msgid "Not setting clock because last adjustment time is zero, so history is bad.\n"
msgstr "Hodiny nebudou nastaveny, protože čas posledního posunu je nula, takže historie je nepoužitelná.\n"

#: sys-utils/hwclock.c:939
#, c-format
msgid "Not setting clock because drift factor %f is far too high.\n"
msgstr "Hodiny nebudou nastaveny, protože činitel rozchodu %f je příliš vysoký.\n"

#: sys-utils/hwclock.c:969
#, c-format
msgid "No usable clock interface found.\n"
msgstr "Nebylo nalezeno žádné použitelné rozhraní k hodinám.\n"

#: sys-utils/hwclock.c:971
msgid "Cannot access the Hardware Clock via any known method."
msgstr "Žádným ze známých způsobů nelze přistoupit k hodinám reálného času."

#: sys-utils/hwclock.c:975
msgid "Use the --verbose option to see the details of our search for an access method."
msgstr "Pro zjištění podrobností o přístupových metodách použijte přepínač --verbose."

#: sys-utils/hwclock.c:1025
#, c-format
msgid "Target date:   %ld\n"
msgstr "Cílové datum:  %ld\n"

#: sys-utils/hwclock.c:1026
#, c-format
msgid "Predicted RTC: %ld\n"
msgstr "Předpokládaný čas v RTC: %ld\n"

#: sys-utils/hwclock.c:1056
msgid "RTC read returned an invalid value."
msgstr "Čtení RTC vrátilo neplatnou hodnotu."

#: sys-utils/hwclock.c:1086
#, c-format
msgid "Needed adjustment is less than one second, so not setting clock.\n"
msgstr "Potřebná oprava je menší než 1 sekunda, proto hodiny nenastavuji.\n"

#: sys-utils/hwclock.c:1123
msgid "unable to read the RTC epoch."
msgstr "nelze přečíst epochu hodin RTC."

#: sys-utils/hwclock.c:1125
#, c-format
msgid "The RTC epoch is set to %lu.\n"
msgstr "Epocha hodin RTC je nastavena na %lu.\n"

#: sys-utils/hwclock.c:1128
msgid "--epoch is required for --setepoch."
msgstr "pro přepínač --setepoch je vyžadován --epoch."

#: sys-utils/hwclock.c:1131
msgid "unable to set the RTC epoch."
msgstr "epochu hodin RTC nelze nastavit."

#: sys-utils/hwclock.c:1145
#, c-format
msgid " %s [function] [option...]\n"
msgstr " %s [funkce] [přepínač…]\n"

#: sys-utils/hwclock.c:1148
msgid "Time clocks utility."
msgstr "Nástroj pro hodiny a čas."

#: sys-utils/hwclock.c:1151
msgid " -r, --show           display the RTC time"
msgstr " -r, --show           zobrazí čas v RTC"

#: sys-utils/hwclock.c:1152
msgid "     --get            display drift corrected RTC time"
msgstr "     --get            zobrazí čas v RTC opravený o systematický posun"

#: sys-utils/hwclock.c:1153
msgid "     --set            set the RTC according to --date"
msgstr "     --set            nastaví RTC podle --date"

#: sys-utils/hwclock.c:1154
msgid " -s, --hctosys        set the system time from the RTC"
msgstr " -s, --hctosys        nastaví systémový čas podle hodin RTC"

#: sys-utils/hwclock.c:1155
msgid " -w, --systohc        set the RTC from the system time"
msgstr " -w, --systohc        nastaví hodiny RTC podle systémového času"

#: sys-utils/hwclock.c:1156
msgid "     --systz          send timescale configurations to the kernel"
msgstr "     --systz          odešle do jádra konfiguraci časové zóny"

#: sys-utils/hwclock.c:1157
msgid " -a, --adjust         adjust the RTC to account for systematic drift"
msgstr " -a, --adjust         opraví RTC o systematický posun"

#: sys-utils/hwclock.c:1159
msgid "     --getepoch       display the RTC epoch"
msgstr "     --getepoch       zobrazí epochu hodin RTC"

#: sys-utils/hwclock.c:1160
msgid "     --setepoch       set the RTC epoch according to --epoch"
msgstr "     --setepoch       nastaví epochu hodin RTC podle --epoch"

#: sys-utils/hwclock.c:1162
msgid "     --predict        predict the drifted RTC time according to --date"
msgstr "     --predict        předpoví posunutý čas v RTC podle --date"

#: sys-utils/hwclock.c:1164
msgid " -u, --utc            the RTC timescale is UTC"
msgstr " -u, --utc            hodiny RTC běží v UTC"

#: sys-utils/hwclock.c:1165
msgid " -l, --localtime      the RTC timescale is Local"
msgstr " -l, --localtime      hodiny RTC běží v místní časové zóně"

#: sys-utils/hwclock.c:1168
#, c-format
msgid " -f, --rtc <file>     use an alternate file to %1$s\n"
msgstr " -f, --rtc <soubor>   použije zadaný soubor místo %1$s\n"

#: sys-utils/hwclock.c:1171
#, c-format
msgid "     --directisa      use the ISA bus instead of %1$s access\n"
msgstr "     --directisa      použije sběrnici ISA namísto přístupu %1$s\n"

#: sys-utils/hwclock.c:1172
msgid "     --date <time>    date/time input for --set and --predict"
msgstr "     --date <čas>     vstup času/data pro --set a --predict"

#: sys-utils/hwclock.c:1173
msgid "     --delay <sec>    delay used when set new RTC time"
msgstr "     --delay <sekundy>  zpoždění při nastavování nového času RTC"

#: sys-utils/hwclock.c:1175
msgid "     --epoch <year>   epoch input for --setepoch"
msgstr "     --epoch <rok>    určuje epochu pro --setepoch"

#: sys-utils/hwclock.c:1177
msgid "     --update-drift   update the RTC drift factor"
msgstr "     --update-drift   aktualizuje činitel systematického posunu hodin RTC"

#: sys-utils/hwclock.c:1179
#, c-format
msgid "     --noadjfile      do not use %1$s\n"
msgstr "     --noadjfile      nepoužije %1$s\n"

#: sys-utils/hwclock.c:1181
#, c-format
msgid "     --adjfile <file> use an alternate file to %1$s\n"
msgstr ""
"     --adjfile <soubor>\n"
"                      použije zadaný soubor místo %1$s\n"

#: sys-utils/hwclock.c:1182
msgid "     --test           dry run; implies --verbose"
msgstr "     --test           nic nenastaví, zapne --verbose"

#: sys-utils/hwclock.c:1183
msgid " -v, --verbose        display more details"
msgstr " -v, --verbose        vypisuje více podrobností"

#: sys-utils/hwclock.c:1279
msgid "Unable to connect to audit system"
msgstr "Nelze se připojit ke kontrolnímu systému"

#: sys-utils/hwclock.c:1303
msgid "use --verbose, --debug has been deprecated."
msgstr "použije --verbose, přepínač --debug je zastaralý."

#: sys-utils/hwclock.c:1405
#, c-format
msgid "%d too many arguments given"
msgstr "%d příliš mnoho argumentů zadáno"

#: sys-utils/hwclock.c:1413
msgid "--update-drift requires --set or --systohc"
msgstr "přepínač --update-drift vyžaduje --set nebo --systohc"

#: sys-utils/hwclock.c:1418
msgid "With --noadjfile, you must specify either --utc or --localtime"
msgstr "Současně s --noadjfile musíte použít buď --utc, nebo --localtime"

#: sys-utils/hwclock.c:1425
msgid "--date is required for --set or --predict"
msgstr "pro přepínače --set nebo --predict je vyžadován --date"

#: sys-utils/hwclock.c:1442
#, c-format
msgid "invalid date '%s'"
msgstr "neplatné datum „%s“"

#: sys-utils/hwclock.c:1456
#, c-format
msgid "System Time: %ld.%06ld\n"
msgstr "Systémový čas: %ld,%06ld\n"

#: sys-utils/hwclock.c:1472
msgid "Test mode: nothing was changed."
msgstr "Zkušební režim: nice nebylo nezměněno."

#: sys-utils/hwclock-cmos.c:360
msgid "ISA port access is not implemented"
msgstr "přístup k portu ISA není implementován"

#: sys-utils/hwclock-cmos.c:362
msgid "iopl() port access failed"
msgstr "přístup k portu pomocí iopl() selhal"

#: sys-utils/hwclock-cmos.c:373
msgid "Using direct ISA access to the clock"
msgstr "K hodinám se přistoupí přímo přes sběrnici ISA"

#: sys-utils/hwclock-rtc.c:131
#, c-format
msgid "Trying to open: %s\n"
msgstr "Zkouší se otevřít: %s\n"

#: sys-utils/hwclock-rtc.c:156 sys-utils/hwclock-rtc.c:259
msgid "cannot open rtc device"
msgstr "zařízení RTC nelze otevřít"

#: sys-utils/hwclock-rtc.c:192
#, c-format
msgid "ioctl(%s) to %s to read the time failed"
msgstr "čas se pomocí volání ioctl(%s) nad %s nepodařilo zjistit"

#: sys-utils/hwclock-rtc.c:220
#, c-format
msgid "Waiting in loop for time from %s to change\n"
msgstr "Čekám ve smyčce na změnu času z %s\n"

#: sys-utils/hwclock-rtc.c:239
msgid "Timed out waiting for time change."
msgstr "V časovém limitu se nepodařilo změnit čas."

#: sys-utils/hwclock-rtc.c:287
#, c-format
msgid "select() to %s to wait for clock tick timed out"
msgstr "pomocí volání select() nad %s se nebylo možné tiku hodin dočkat"

#: sys-utils/hwclock-rtc.c:290
#, c-format
msgid "select() to %s to wait for clock tick failed"
msgstr "Čekání na tik hodin pomocí select() nad %s selhal"

#: sys-utils/hwclock-rtc.c:295
#, c-format
msgid "ioctl() to %s to turn off update interrupts failed"
msgstr "Obnovovací přerušení nelze vypnout - volání ioctl() pro %s selhalo"

#: sys-utils/hwclock-rtc.c:301
#, c-format
msgid "ioctl(%d, RTC_UIE_ON, 0) to %s failed"
msgstr "volání ioctl(%d, RTC_UIE_ON, 0) nad %s selhalo"

#: sys-utils/hwclock-rtc.c:353
#, c-format
msgid "ioctl(%s) to %s to set the time failed"
msgstr "Nastavení času pomocí volání ioctl(%s) nad %s selhalo"

#: sys-utils/hwclock-rtc.c:359
#, c-format
msgid "ioctl(%s) was successful.\n"
msgstr "Volání ioctl(%s) bylo úspěšné.\n"

#: sys-utils/hwclock-rtc.c:375
msgid "Using the rtc interface to the clock."
msgstr "U hodin se použije rozhraní RTC."

#: sys-utils/hwclock-rtc.c:408
#, c-format
msgid "ioctl(%d, RTC_EPOCH_READ, epoch_p) to %s failed"
msgstr "volání ioctl(%d, RTC_EPOCH_READ, epoch_p) nad %s selhalo"

#: sys-utils/hwclock-rtc.c:414
#, c-format
msgid "ioctl(%d, RTC_EPOCH_READ, epoch_p) to %s succeeded.\n"
msgstr "Volání ioctl(%d, RTC_EPOCH_READ, epoch_p) nad %s uspělo.\n"

#: sys-utils/hwclock-rtc.c:432
#, c-format
msgid "invalid epoch '%s'."
msgstr "neplatná epocha „%s“."

#: sys-utils/hwclock-rtc.c:443
#, c-format
msgid "ioctl(%d, RTC_EPOCH_SET, %lu) to %s failed"
msgstr "volání ioctl(%d, RTC_EPOCH_SET, %lu) nad %s selhalo"

#: sys-utils/hwclock-rtc.c:449
#, c-format
msgid "ioctl(%d, RTC_EPOCH_SET, %lu) to %s succeeded.\n"
msgstr "Volání ioctl(%d, RTC_EPOCH_SET, %lu) nad %s uspělo.\n"

#: sys-utils/ipcmk.c:70
msgid "Create various IPC resources.\n"
msgstr "Vytvoří rozličné zdroje IPC.\n"

#: sys-utils/ipcmk.c:73
msgid " -M, --shmem <size>       create shared memory segment of size <size>\n"
msgstr " -M, --shmem <velikost>   vytvoří sdílený paměťový segment o dané <velikosti>\n"

#: sys-utils/ipcmk.c:74
msgid " -S, --semaphore <number> create semaphore array with <number> elements\n"
msgstr " -S, --semaphore <počet>  vytvoří pole semaforu s <počtem> prvků\n"

#: sys-utils/ipcmk.c:75
msgid " -Q, --queue              create message queue\n"
msgstr " -Q, --queue              vytvoří frontu zpráv\n"

#: sys-utils/ipcmk.c:76
msgid " -p, --mode <mode>        permission for the resource (default is 0644)\n"
msgstr " -p, --mode <mód>         práva pro zdroj (výchozí jsou 0644)\n"

#: sys-utils/ipcmk.c:82 sys-utils/zramctl.c:565
#, fuzzy
msgid "<size>"
msgstr "velikost"

#: sys-utils/ipcmk.c:114 sys-utils/losetup.c:731 sys-utils/zramctl.c:650
msgid "failed to parse size"
msgstr "velikost se nezdařilo rozebrat"

#: sys-utils/ipcmk.c:121
msgid "failed to parse elements"
msgstr "elementy se nepodařilo rozebrat"

#: sys-utils/ipcmk.c:144
msgid "create share memory failed"
msgstr "nepodařilo se vytvořit sdílenou paměť"

#: sys-utils/ipcmk.c:146
#, c-format
msgid "Shared memory id: %d\n"
msgstr "ID sdílené paměti: %d\n"

#: sys-utils/ipcmk.c:152
msgid "create message queue failed"
msgstr "nepodařilo se vytvořit frontu zpráv"

#: sys-utils/ipcmk.c:154
#, c-format
msgid "Message queue id: %d\n"
msgstr "ID fronty zpráv: %d\n"

#: sys-utils/ipcmk.c:160
msgid "create semaphore failed"
msgstr "nepodařilo se vytvořit semafor"

#: sys-utils/ipcmk.c:162
#, c-format
msgid "Semaphore id: %d\n"
msgstr "ID semaforu: %d\n"

#: sys-utils/ipcrm.c:51
#, c-format
msgid ""
" %1$s [options]\n"
" %1$s shm|msg|sem <id>...\n"
msgstr ""
" %1$s [přepínače]\n"
" %1$s shm|msg|sem <ID>…\n"

#: sys-utils/ipcrm.c:55
msgid "Remove certain IPC resources.\n"
msgstr "Odstraní určité IPC zdroje.\n"

#: sys-utils/ipcrm.c:58
msgid " -m, --shmem-id <id>        remove shared memory segment by id\n"
msgstr " -m, --shmem-id <ID>        odstraní sdílený paměťový segment podle ID\n"

#: sys-utils/ipcrm.c:59
msgid " -M, --shmem-key <key>      remove shared memory segment by key\n"
msgstr " -M, --shmem-key <klíč>     odstraní sdílený paměťový segment podle klíče\n"

#: sys-utils/ipcrm.c:60
msgid " -q, --queue-id <id>        remove message queue by id\n"
msgstr " -q, --queue-id <ID>        odstraní frontu zpráv podle ID\n"

#: sys-utils/ipcrm.c:61
msgid " -Q, --queue-key <key>      remove message queue by key\n"
msgstr " -Q, --queue-key <klíč>     odstraní frontu zpráv podle klíče\n"

#: sys-utils/ipcrm.c:62
msgid " -s, --semaphore-id <id>    remove semaphore by id\n"
msgstr " -s, --semaphore-id <ID>    odstraní semafor podle ID\n"

#: sys-utils/ipcrm.c:63
msgid " -S, --semaphore-key <key>  remove semaphore by key\n"
msgstr " -S, --semaphore-key <klíč> odstraní semafor podle klíče\n"

#: sys-utils/ipcrm.c:64
msgid " -a, --all[=shm|msg|sem]    remove all (in the specified category)\n"
msgstr " -a, --all[=<shm|msg|sem>]  odstraní vše (segment, frontu zpráv, semafor)\n"

#: sys-utils/ipcrm.c:65
msgid " -v, --verbose              explain what is being done\n"
msgstr " -v, --verbose              vysvětlí, co se děje\n"

#: sys-utils/ipcrm.c:86
#, c-format
msgid "removing shared memory segment id `%d'\n"
msgstr "odstraňuje se segmentu sdílené paměti s ID „%d“\n"

#: sys-utils/ipcrm.c:91
#, c-format
msgid "removing message queue id `%d'\n"
msgstr "odstraňuje se fronta zpráv s ID „%d“\n"

#: sys-utils/ipcrm.c:96
#, c-format
msgid "removing semaphore id `%d'\n"
msgstr "odstraňuje se semafor s ID „%d“\n"

#: sys-utils/ipcrm.c:108 sys-utils/ipcrm.c:222
msgid "permission denied for key"
msgstr "pro daný klíč přístup odmítnut"

#: sys-utils/ipcrm.c:108
msgid "permission denied for id"
msgstr "pro dané id přístup odmítnut"

#: sys-utils/ipcrm.c:111 sys-utils/ipcrm.c:228
msgid "invalid key"
msgstr "neplatný klíč"

#: sys-utils/ipcrm.c:111
msgid "invalid id"
msgstr "neplatné id"

#: sys-utils/ipcrm.c:114 sys-utils/ipcrm.c:225
msgid "already removed key"
msgstr "již odstraněný klíč"

#: sys-utils/ipcrm.c:114
msgid "already removed id"
msgstr "již odstraněné ID"

#: sys-utils/ipcrm.c:117 sys-utils/ipcrm.c:231
msgid "key failed"
msgstr "klíč selhal"

#: sys-utils/ipcrm.c:117
msgid "id failed"
msgstr "ID selhalo"

#: sys-utils/ipcrm.c:134
#, c-format
msgid "invalid id: %s"
msgstr "neplatné ID: %s"

#: sys-utils/ipcrm.c:167
#, c-format
msgid "resource(s) deleted\n"
msgstr "prostředky smazány\n"

#: sys-utils/ipcrm.c:200
#, c-format
msgid "illegal key (%s)"
msgstr "nedovolený klíč (%s)"

#: sys-utils/ipcrm.c:256
msgid "kernel not configured for shared memory"
msgstr "jádro nepodporuje sdílenou paměť"

#: sys-utils/ipcrm.c:269
msgid "kernel not configured for semaphores"
msgstr "jádro nepodporuje semafory"

#: sys-utils/ipcrm.c:290
msgid "kernel not configured for message queues"
msgstr "jádro nepodporuje fronty zpráv"

#: sys-utils/ipcs.c:60
#, c-format
msgid ""
" %1$s [resource-option...] [output-option]\n"
" %1$s -m|-q|-s -i <id>\n"
msgstr ""
" %1$s [přepínač_prostředku…] [přepínač_výstupu]\n"
" %1$s -m|-q|-s -i <ID>\n"

#: sys-utils/ipcs.c:64 sys-utils/lsipc.c:294
msgid "Show information on IPC facilities.\n"
msgstr "Poskytuje informace o prostředcích IPC.\n"

#: sys-utils/ipcs.c:67
msgid " -i, --id <id>  print details on resource identified by <id>\n"
msgstr " -i, --id <ID>  zobrazí podrobnosti o prostředku určeném dle ID\n"

#: sys-utils/ipcs.c:71 sys-utils/lsipc.c:297
msgid "Resource options:\n"
msgstr "Přepínače prostředků:\n"

#: sys-utils/ipcs.c:72 sys-utils/lsipc.c:298
msgid " -m, --shmems      shared memory segments\n"
msgstr " -m, --shmems      sdílené segmenty paměti\n"

#: sys-utils/ipcs.c:73 sys-utils/lsipc.c:299
msgid " -q, --queues      message queues\n"
msgstr " -q, --queues      fronty zpráv\n"

#: sys-utils/ipcs.c:74 sys-utils/lsipc.c:300
msgid " -s, --semaphores  semaphores\n"
msgstr " -s, --semaphores  semafory\n"

#: sys-utils/ipcs.c:75
msgid " -a, --all         all (default)\n"
msgstr " -a, --all         vše (výchozí)\n"

#: sys-utils/ipcs.c:78
msgid "Output options:\n"
msgstr "Přepínače výstupu:\n"

#: sys-utils/ipcs.c:79
msgid " -t, --time        show attach, detach and change times\n"
msgstr " -t, --time        zobrazí časy připojení, odpojení a změny\n"

#: sys-utils/ipcs.c:80
msgid " -p, --pid         show PIDs of creator and last operator\n"
msgstr " -p, --pid         zobrazí PID tvůrce a poslední operátora\n"

#: sys-utils/ipcs.c:81
msgid " -c, --creator     show creator and owner\n"
msgstr " -c, --creator     zobrazí tvůrce a vlastníka\n"

#: sys-utils/ipcs.c:82
msgid " -l, --limits      show resource limits\n"
msgstr " -l, --limits      zobrazí omezení zdrojů\n"

#: sys-utils/ipcs.c:83
msgid " -u, --summary     show status summary\n"
msgstr " -u, --summary     zobrazí souhrn stavů\n"

#: sys-utils/ipcs.c:84
msgid "     --human       show sizes in human-readable format\n"
msgstr "     --human       velikosti zobrazí v podobě čitelné pro člověka\n"

#: sys-utils/ipcs.c:85
msgid " -b, --bytes       show sizes in bytes\n"
msgstr " -b, --bytes       velikosti zobrazí v bajtech\n"

#: sys-utils/ipcs.c:171
msgid "when using an ID, a single resource must be specified"
msgstr "je-li použito ID, musí být určen jediný prostředek"

#: sys-utils/ipcs.c:211
#, c-format
msgid "unable to fetch shared memory limits\n"
msgstr "omezení pro sdílenou paměť nelze získat\n"

#: sys-utils/ipcs.c:214
#, c-format
msgid "------ Shared Memory Limits --------\n"
msgstr "------ Omezení pro sdílenou paměť --------\n"

#: sys-utils/ipcs.c:215
#, c-format
msgid "max number of segments = %ju\n"
msgstr "maximální počet segmentů = %ju\n"

#: sys-utils/ipcs.c:217
msgid "max seg size"
msgstr "maximální velikost segmentu"

#: sys-utils/ipcs.c:225
msgid "max total shared memory"
msgstr "celkové maximum pro sdílenou paměť"

#: sys-utils/ipcs.c:227
msgid "min seg size"
msgstr "minimální velikost segmentu"

#: sys-utils/ipcs.c:239
#, c-format
msgid "kernel not configured for shared memory\n"
msgstr "jádro nepodporuje sdílenou paměť\n"

#: sys-utils/ipcs.c:243
#, c-format
msgid "------ Shared Memory Status --------\n"
msgstr "------ Stav sdílené paměti --------\n"

#. TRANSLATORS: This output format is maintained for backward
#. compatibility as ipcs is used in scripts. For consistency
#. with the rest, the translated form can follow this model:
#. *
#. "segments allocated = %d\n"
#. "pages allocated = %ld\n"
#. "pages resident = %ld\n"
#. "pages swapped = %ld\n"
#. "swap performance = %ld attempts, %ld successes\n"
#.
#: sys-utils/ipcs.c:255
#, c-format
msgid ""
"segments allocated %d\n"
"pages allocated %ld\n"
"pages resident  %ld\n"
"pages swapped   %ld\n"
"Swap performance: %ld attempts\t %ld successes\n"
msgstr ""
"alokováno segmentů   %d\n"
"alokováno stránek    %ld\n"
"rezidentních stránek %ld\n"
"odložených stránek   %ld\n"
"účinnost odkládání:  %ld pokusů\t %ld úspěšných\n"

#: sys-utils/ipcs.c:272
#, c-format
msgid "------ Shared Memory Segment Creators/Owners --------\n"
msgstr "------ Tvůrci/vlastníci segmentů sdílené paměti ------\n"

#: sys-utils/ipcs.c:274 sys-utils/ipcs.c:280 sys-utils/ipcs.c:287
#: sys-utils/ipcs.c:293
msgid "shmid"
msgstr "shmid"

#: sys-utils/ipcs.c:274 sys-utils/ipcs.c:293 sys-utils/ipcs.c:398
#: sys-utils/ipcs.c:413 sys-utils/ipcs.c:500 sys-utils/ipcs.c:518
msgid "perms"
msgstr "práva"

#: sys-utils/ipcs.c:274 sys-utils/ipcs.c:398 sys-utils/ipcs.c:500
msgid "cuid"
msgstr "cuid"

#: sys-utils/ipcs.c:274 sys-utils/ipcs.c:398 sys-utils/ipcs.c:500
msgid "cgid"
msgstr "cgid"

#: sys-utils/ipcs.c:274 sys-utils/ipcs.c:398 sys-utils/ipcs.c:500
msgid "uid"
msgstr "uid"

#: sys-utils/ipcs.c:274 sys-utils/ipcs.c:398 sys-utils/ipcs.c:500
msgid "gid"
msgstr "gid"

#: sys-utils/ipcs.c:278
#, c-format
msgid "------ Shared Memory Attach/Detach/Change Times --------\n"
msgstr "------ Časy připojení/odpojení/změny pro sdílenou paměť --------\n"

#: sys-utils/ipcs.c:280 sys-utils/ipcs.c:287 sys-utils/ipcs.c:293
#: sys-utils/ipcs.c:404 sys-utils/ipcs.c:413 sys-utils/ipcs.c:506
#: sys-utils/ipcs.c:512 sys-utils/ipcs.c:518
msgid "owner"
msgstr "vlastník"

#: sys-utils/ipcs.c:280
msgid "attached"
msgstr "připojení"

#: sys-utils/ipcs.c:280
msgid "detached"
msgstr "odpojení"

#: sys-utils/ipcs.c:281
msgid "changed"
msgstr "změna"

#: sys-utils/ipcs.c:285
#, c-format
msgid "------ Shared Memory Creator/Last-op PIDs --------\n"
msgstr "------ Tvůrce sdílené paměti/PID poslední operace --------\n"

#: sys-utils/ipcs.c:287
msgid "cpid"
msgstr "cpid"

#: sys-utils/ipcs.c:287
msgid "lpid"
msgstr "lpid"

#: sys-utils/ipcs.c:291
#, c-format
msgid "------ Shared Memory Segments --------\n"
msgstr "------ Segmenty sdílené paměti --------\n"

#: sys-utils/ipcs.c:293 sys-utils/ipcs.c:413 sys-utils/ipcs.c:518
msgid "key"
msgstr "klíč"

#: sys-utils/ipcs.c:294 sys-utils/ipcs.c:519
msgid "size"
msgstr "velikost"

#: sys-utils/ipcs.c:294 sys-utils/prlimit.c:75 sys-utils/prlimit.c:76
#: sys-utils/prlimit.c:78 sys-utils/prlimit.c:79 sys-utils/prlimit.c:81
#: sys-utils/prlimit.c:82 sys-utils/prlimit.c:86 sys-utils/prlimit.c:90
msgid "bytes"
msgstr "bajty"

#: sys-utils/ipcs.c:295
msgid "nattch"
msgstr "nattch"

#: sys-utils/ipcs.c:295
msgid "status"
msgstr "stav"

#: sys-utils/ipcs.c:319 sys-utils/ipcs.c:321 sys-utils/ipcs.c:323
#: sys-utils/ipcs.c:436 sys-utils/ipcs.c:438 sys-utils/ipcs.c:543
#: sys-utils/ipcs.c:545 sys-utils/ipcs.c:547 sys-utils/ipcs.c:600
#: sys-utils/ipcs.c:602 sys-utils/ipcs.c:631 sys-utils/ipcs.c:633
#: sys-utils/ipcs.c:635 sys-utils/ipcs.c:659
msgid "Not set"
msgstr "Nenastaveno"

#: sys-utils/ipcs.c:349 sys-utils/lsipc.c:997 sys-utils/lsipc.c:1003
msgid "dest"
msgstr "cíl"

#: sys-utils/ipcs.c:350 sys-utils/lsipc.c:998 sys-utils/lsipc.c:1011
msgid "locked"
msgstr "zamčeno"

#: sys-utils/ipcs.c:369
#, c-format
msgid "unable to fetch semaphore limits\n"
msgstr "omezení pro semafory se nepodařilo získat\n"

#: sys-utils/ipcs.c:372
#, c-format
msgid "------ Semaphore Limits --------\n"
msgstr "------Omezení pro semafory --------\n"

#: sys-utils/ipcs.c:373
#, c-format
msgid "max number of arrays = %d\n"
msgstr "maximální počet polí = %d\n"

#: sys-utils/ipcs.c:374
#, c-format
msgid "max semaphores per array = %d\n"
msgstr "maximální počet semaforů v poli = %d\n"

#: sys-utils/ipcs.c:375
#, c-format
msgid "max semaphores system wide = %d\n"
msgstr "celkový maximální počet semaforů = %d\n"

#: sys-utils/ipcs.c:376
#, c-format
msgid "max ops per semop call = %d\n"
msgstr "maximální počet operací na jedno semop volání = %d\n"

#: sys-utils/ipcs.c:377
#, c-format
msgid "semaphore max value = %u\n"
msgstr "maximální hodnota semaforu = %u\n"

#: sys-utils/ipcs.c:386
#, c-format
msgid "kernel not configured for semaphores\n"
msgstr "jádro nepodporuje semafory\n"

#: sys-utils/ipcs.c:389
#, c-format
msgid "------ Semaphore Status --------\n"
msgstr "------ Stav semaforu --------\n"

#: sys-utils/ipcs.c:390
#, c-format
msgid "used arrays = %d\n"
msgstr "použitá pole = %d\n"

#: sys-utils/ipcs.c:391
#, c-format
msgid "allocated semaphores = %d\n"
msgstr "alokované semafory = %d\n"

#: sys-utils/ipcs.c:396
#, c-format
msgid "------ Semaphore Arrays Creators/Owners --------\n"
msgstr "------ Tvůrci/vlastníci polí semaforů --------\n"

#: sys-utils/ipcs.c:398 sys-utils/ipcs.c:404 sys-utils/ipcs.c:413
msgid "semid"
msgstr "semid"

#: sys-utils/ipcs.c:402
#, c-format
msgid "------ Semaphore Operation/Change Times --------\n"
msgstr "------ Časy operace/změny semaforu --------\n"

#: sys-utils/ipcs.c:404
msgid "last-op"
msgstr "poslední operace"

#: sys-utils/ipcs.c:404
msgid "last-changed"
msgstr "poslední změna"

#: sys-utils/ipcs.c:411
#, c-format
msgid "------ Semaphore Arrays --------\n"
msgstr "------ Pole semaforů --------\n"

#: sys-utils/ipcs.c:413
msgid "nsems"
msgstr "nsems"

#: sys-utils/ipcs.c:470
#, c-format
msgid "unable to fetch message limits\n"
msgstr "omezení zpráv se nepodařilo získat\n"

#: sys-utils/ipcs.c:473
#, c-format
msgid "------ Messages Limits --------\n"
msgstr "------ Omezení zpráv --------\n"

#: sys-utils/ipcs.c:474
#, c-format
msgid "max queues system wide = %d\n"
msgstr "celkový maximální počet front = %d\n"

#: sys-utils/ipcs.c:476
msgid "max size of message"
msgstr "maximální velikost zprávy"

#: sys-utils/ipcs.c:478
msgid "default max size of queue"
msgstr "výchozí maximální velikost fronty"

#: sys-utils/ipcs.c:485
#, c-format
msgid "kernel not configured for message queues\n"
msgstr "jádro nepodporuje fronty zpráv\n"

#: sys-utils/ipcs.c:488
#, c-format
msgid "------ Messages Status --------\n"
msgstr "------ Stav zpráv --------\n"

#: sys-utils/ipcs.c:490
#, c-format
msgid "allocated queues = %d\n"
msgstr "alokované fronty = %d\n"

#: sys-utils/ipcs.c:491
#, c-format
msgid "used headers = %d\n"
msgstr "použité hlavičky = %d\n"

#: sys-utils/ipcs.c:493
msgid "used space"
msgstr "použitý prostor"

#: sys-utils/ipcs.c:494
msgid " bytes\n"
msgstr " B\n"

#: sys-utils/ipcs.c:498
#, c-format
msgid "------ Message Queues Creators/Owners --------\n"
msgstr "------ Tvůrci/vlastníci front zpráv --------\n"

#: sys-utils/ipcs.c:500 sys-utils/ipcs.c:506 sys-utils/ipcs.c:512
#: sys-utils/ipcs.c:518
msgid "msqid"
msgstr "msqid"

#: sys-utils/ipcs.c:504
#, c-format
msgid "------ Message Queues Send/Recv/Change Times --------\n"
msgstr "------ Časy odeslání.příchodu/změny pro fronty zpráv --------\n"

#: sys-utils/ipcs.c:506
msgid "send"
msgstr "odeslání"

#: sys-utils/ipcs.c:506
msgid "recv"
msgstr "příjem"

#: sys-utils/ipcs.c:506
msgid "change"
msgstr "změna"

#: sys-utils/ipcs.c:510
#, c-format
msgid "------ Message Queues PIDs --------\n"
msgstr "------ PID pro fronty zpráv --------\n"

#: sys-utils/ipcs.c:512
msgid "lspid"
msgstr "lspid"

#: sys-utils/ipcs.c:512
msgid "lrpid"
msgstr "lrpid"

#: sys-utils/ipcs.c:516
#, c-format
msgid "------ Message Queues --------\n"
msgstr "------ Fronty zpráv --------\n"

#: sys-utils/ipcs.c:519
msgid "used-bytes"
msgstr "užité bajty"

#: sys-utils/ipcs.c:520
msgid "messages"
msgstr "zprávy"

#: sys-utils/ipcs.c:584 sys-utils/ipcs.c:614 sys-utils/ipcs.c:647
#: sys-utils/lsipc.c:547 sys-utils/lsipc.c:739 sys-utils/lsipc.c:899
#, c-format
msgid "id %d not found"
msgstr "identifikátor %d nenalezen"

#: sys-utils/ipcs.c:588
#, c-format
msgid ""
"\n"
"Shared memory Segment shmid=%d\n"
msgstr ""
"\n"
"shmid segmentu sdílené paměti = %d\n"

#: sys-utils/ipcs.c:589
#, c-format
msgid "uid=%u\tgid=%u\tcuid=%u\tcgid=%u\n"
msgstr "uid=%u\tgid=%u\tcuid=%u\tcgid=%u\n"

#: sys-utils/ipcs.c:592
#, c-format
msgid "mode=%#o\taccess_perms=%#o\n"
msgstr "mód=%#o\tpřístupová práva=%#o\n"

#: sys-utils/ipcs.c:594
msgid "size="
msgstr "velikost="

#: sys-utils/ipcs.c:594
msgid "bytes="
msgstr "bajty="

#: sys-utils/ipcs.c:596
#, c-format
msgid "lpid=%u\tcpid=%u\tnattch=%jd\n"
msgstr "lpid=%u\tcpid=%u\tnattch=%jd\n"

#: sys-utils/ipcs.c:599
#, c-format
msgid "att_time=%-26.24s\n"
msgstr "připoj_čas=%-26.24s\n"

#: sys-utils/ipcs.c:601
#, c-format
msgid "det_time=%-26.24s\n"
msgstr "odpoj_čas=%-26.24s\n"

#: sys-utils/ipcs.c:603 sys-utils/ipcs.c:634
#, c-format
msgid "change_time=%-26.24s\n"
msgstr "čas_změny=%-26.24s\n"

#: sys-utils/ipcs.c:618
#, c-format
msgid ""
"\n"
"Message Queue msqid=%d\n"
msgstr ""
"\n"
"msgid fronty zpráv=%d\n"

#: sys-utils/ipcs.c:619
#, c-format
msgid "uid=%u\tgid=%u\tcuid=%u\tcgid=%u\tmode=%#o\n"
msgstr "uid=%u\tgid=%u\tcuid=%u\tcgid=%u\tmód=%#o\n"

#: sys-utils/ipcs.c:623
msgid "csize="
msgstr "csize="

#: sys-utils/ipcs.c:623
msgid "cbytes="
msgstr "cbytes="

#: sys-utils/ipcs.c:625
msgid "qsize="
msgstr "qsize="

#: sys-utils/ipcs.c:625
msgid "qbytes="
msgstr "qbytes="

#: sys-utils/ipcs.c:630
#, c-format
msgid "send_time=%-26.24s\n"
msgstr "čas odeslání=%-26.24s\n"

#: sys-utils/ipcs.c:632
#, c-format
msgid "rcv_time=%-26.24s\n"
msgstr "čas příjmu=%-26.24s\n"

#: sys-utils/ipcs.c:651
#, c-format
msgid ""
"\n"
"Semaphore Array semid=%d\n"
msgstr ""
"\n"
"semid pole semaforů = %d\n"

#: sys-utils/ipcs.c:652
#, c-format
msgid "uid=%u\t gid=%u\t cuid=%u\t cgid=%u\n"
msgstr "uid=%u\t gid=%u\t cuid=%u\t cgid=%u\n"

#: sys-utils/ipcs.c:655
#, c-format
msgid "mode=%#o, access_perms=%#o\n"
msgstr "mód=%#o, přístupová práva=%#o\n"

#: sys-utils/ipcs.c:657
#, c-format
msgid "nsems = %ju\n"
msgstr "nsems = %ju\n"

#: sys-utils/ipcs.c:658
#, c-format
msgid "otime = %-26.24s\n"
msgstr "čas poslední operace = %-26.24s\n"

#: sys-utils/ipcs.c:660
#, c-format
msgid "ctime = %-26.24s\n"
msgstr "čas změny = %-26.24s\n"

#: sys-utils/ipcs.c:663
msgid "semnum"
msgstr "semnum"

#: sys-utils/ipcs.c:663
msgid "value"
msgstr "hodnota"

#: sys-utils/ipcs.c:663
msgid "ncount"
msgstr "ncount"

#: sys-utils/ipcs.c:663
msgid "zcount"
msgstr "zcount"

#: sys-utils/ipcs.c:663
msgid "pid"
msgstr "pid"

#: sys-utils/ipcutils.c:232 sys-utils/ipcutils.c:236 sys-utils/ipcutils.c:240
#: sys-utils/ipcutils.c:244
#, c-format
msgid "%s failed"
msgstr "Příkaz %s selhal"

#: sys-utils/ipcutils.c:505
#, c-format
msgid "%s (bytes) = "
msgstr "%s (bajty) = "

#: sys-utils/ipcutils.c:507
#, c-format
msgid "%s (kbytes) = "
msgstr "%s (kilobajty) = "

#: sys-utils/irq-common.c:53 sys-utils/irq-common.c:114
#, fuzzy
msgid "interrupts"
msgstr "Přerušeno %s"

#: sys-utils/irq-common.c:54
#, fuzzy
msgid "total count"
msgstr "načtení počtu"

#: sys-utils/irq-common.c:55
#, fuzzy
msgid "delta count"
msgstr "načtení počtu"

#: sys-utils/irq-common.c:56
#, fuzzy
msgid "name"
msgstr "Nový název"

#: sys-utils/irq-common.c:106 sys-utils/lsmem.c:689 sys-utils/lsns.c:782
msgid "failed to initialize output table"
msgstr "výstupní tabulku se nepodařilo inicializovat"

#: sys-utils/irq-common.c:145 sys-utils/lsns.c:720
msgid "failed to add line to output"
msgstr "přidání řádku na výstup selhalo"

#: sys-utils/irq-common.c:348
#, fuzzy
msgid "unsupported column name to sort output"
msgstr "nepodporovaný režim barev"

#: sys-utils/irqtop.c:114
#, c-format
msgid ""
"irqtop | total: %ld delta: %ld | %s | %s\n"
"\n"
msgstr ""

#: sys-utils/irqtop.c:142
#, fuzzy
msgid "cannot not create timerfd"
msgstr "časovač nelze nastavit"

#: sys-utils/irqtop.c:144
#, fuzzy
msgid "cannot set timerfd"
msgstr "časovač nelze nastavit"

#: sys-utils/irqtop.c:149 sys-utils/irqtop.c:167 sys-utils/irqtop.c:172
#, fuzzy
msgid "epoll_ctl failed"
msgstr "volání poll() selhalo"

#: sys-utils/irqtop.c:152
#, fuzzy
msgid "sigfillset failed"
msgstr "volání select selhalo"

#: sys-utils/irqtop.c:154
#, fuzzy
msgid "sigprocmask failed"
msgstr "volání setgroups selhalo"

#: sys-utils/irqtop.c:162
#, fuzzy
msgid "cannot not create signalfd"
msgstr "signály nelze zablokovat"

#: sys-utils/irqtop.c:220
msgid "Interactive utility to display kernel interrupt information."
msgstr ""

#: sys-utils/irqtop.c:223
#, fuzzy
msgid " -d, --delay <secs>   delay updates\n"
msgstr "     --delay <sekundy>  zpoždění při nastavování nového času RTC"

#: sys-utils/irqtop.c:225 sys-utils/lsirq.c:67
#, fuzzy
msgid " -s, --sort <column>  specify sort column\n"
msgstr " -x, --sort <sloupec> výstup seřadí podle <sloupce>\n"

#: sys-utils/irqtop.c:229
msgid ""
"\n"
"The following interactive key commands are valid:\n"
msgstr ""

#: sys-utils/irqtop.c:230
msgid "  i      sort by IRQ\n"
msgstr ""

#: sys-utils/irqtop.c:231
msgid "  t      sort by TOTAL\n"
msgstr ""

#: sys-utils/irqtop.c:232
msgid "  d      sort by DELTA\n"
msgstr ""

#: sys-utils/irqtop.c:233
msgid "  n      sort by NAME\n"
msgstr ""

#: sys-utils/irqtop.c:234
msgid "  q Q    quit program\n"
msgstr ""

#: sys-utils/irqtop.c:266
#, fuzzy
msgid "failed to parse delay argument"
msgstr "argument se nepodařilo rozebrat"

#: sys-utils/irqtop.c:320
msgid "terminal setting retrieval"
msgstr ""

#: sys-utils/ldattach.c:183
msgid "invalid iflag"
msgstr "neplatný iflag"

#: sys-utils/ldattach.c:199
#, c-format
msgid " %s [options] <ldisc> <device>\n"
msgstr " %s [přepínače] <disciplína_linky> <zařízení>\n"

#: sys-utils/ldattach.c:202
msgid "Attach a line discipline to a serial line.\n"
msgstr "Připojí linkovou disciplínu k sériové lince.\n"

#: sys-utils/ldattach.c:205
msgid " -d, --debug             print verbose messages to stderr\n"
msgstr " -d, --debug             vypisuje podrobné zprávy na chybový výstup\n"

#: sys-utils/ldattach.c:206
msgid " -s, --speed <value>     set serial line speed\n"
msgstr " -s, --speed <hodnota>   nastaví rychlost sériové linky\n"

#: sys-utils/ldattach.c:207
msgid " -c, --intro-command <string> intro sent before ldattach\n"
msgstr ""
" -c, --intro-command <řetězec>\n"
"                         odešle úvodní řetězec před připojením linky\n"

#: sys-utils/ldattach.c:208
msgid " -p, --pause <seconds>   pause between intro and ldattach\n"
msgstr " -p, --pause <sekundy>   pauza mezi úvodním řetězcem a připojením\n"

#: sys-utils/ldattach.c:209
msgid " -7, --sevenbits         set character size to 7 bits\n"
msgstr " -7, --sevenbits         nastaví velikost znaku na 7 bitů\n"

#: sys-utils/ldattach.c:210
msgid " -8, --eightbits         set character size to 8 bits\n"
msgstr " -8, --eightbits         nastaví velikost znaku na 8 bitů\n"

#: sys-utils/ldattach.c:211
msgid " -n, --noparity          set parity to none\n"
msgstr " -n, --noparity          nastaví paritu na žádnou\n"

#: sys-utils/ldattach.c:212
msgid " -e, --evenparity        set parity to even\n"
msgstr " -e, --evenparity        nastaví paritu na sudou\n"

#: sys-utils/ldattach.c:213
msgid " -o, --oddparity         set parity to odd\n"
msgstr " -o, --oddparity         nastaví paritu na lichou\n"

#: sys-utils/ldattach.c:214
msgid " -1, --onestopbit        set stop bits to one\n"
msgstr " -1, --onestopbit        nastaví stop-bity na jeden\n"

#: sys-utils/ldattach.c:215
msgid " -2, --twostopbits       set stop bits to two\n"
msgstr " -2, --twostopbits       nastaví stop-bity na dva\n"

#: sys-utils/ldattach.c:216
msgid " -i, --iflag [-]<iflag>  set input mode flag\n"
msgstr " -i, --iflag [-]<iflag>  nastaví příznak režimu vstupu\n"

#: sys-utils/ldattach.c:221
msgid ""
"\n"
"Known <ldisc> names:\n"
msgstr ""
"\n"
"Známá jména <linkové_disciplíny>:\n"

#: sys-utils/ldattach.c:225
msgid ""
"\n"
"Known <iflag> names:\n"
msgstr ""
"\n"
"Známá jména <iflag>:\n"

#: sys-utils/ldattach.c:343
msgid "invalid speed argument"
msgstr "neplatný argument rychlosti"

#: sys-utils/ldattach.c:346
msgid "invalid pause argument"
msgstr "neplatný argument pauzy"

#: sys-utils/ldattach.c:373
msgid "invalid line discipline argument"
msgstr "neplatný argument disciplíny linky"

#: sys-utils/ldattach.c:393
#, c-format
msgid "%s is not a serial line"
msgstr "%s není sériovou linkou"

#: sys-utils/ldattach.c:400
#, c-format
msgid "cannot get terminal attributes for %s"
msgstr "nelze zjistit vlastnosti terminálu %s"

#: sys-utils/ldattach.c:403
#, c-format
msgid "speed %d unsupported"
msgstr "rychlost %d nepodporována"

#: sys-utils/ldattach.c:452
#, c-format
msgid "cannot set terminal attributes for %s"
msgstr "vlastnosti terminálu %s nelze nastavit"

#: sys-utils/ldattach.c:462
#, c-format
msgid "cannot write intro command to %s"
msgstr "do %s nelze zapsat úvodní příkaz"

#: sys-utils/ldattach.c:472
msgid "cannot set line discipline"
msgstr "disciplínu linky nelze nastavit"

#: sys-utils/ldattach.c:482
msgid "cannot daemonize"
msgstr "nelze se démonizovat"

#: sys-utils/losetup.c:72
msgid "autoclear flag set"
msgstr "příznak automatického úklidu nastaven"

#: sys-utils/losetup.c:73
msgid "device backing file"
msgstr "soubor pod zařízením"

#: sys-utils/losetup.c:74
msgid "backing file inode number"
msgstr "číslo i-uzlu souboru pod zařízením"

#: sys-utils/losetup.c:75
msgid "backing file major:minor device number"
msgstr "hlavní:vedlejší číslo zařízení, kde je podkladový soubor"

#: sys-utils/losetup.c:76
msgid "loop device name"
msgstr "název loop zařízení"

#: sys-utils/losetup.c:77
msgid "offset from the beginning"
msgstr "pozice od začátku"

#: sys-utils/losetup.c:78
msgid "partscan flag set"
msgstr "příznak hledání oddílů nastaven"

#: sys-utils/losetup.c:80
msgid "size limit of the file in bytes"
msgstr "omezení velikosti souboru v bajtech"

#: sys-utils/losetup.c:81
msgid "loop device major:minor number"
msgstr "hlavní:vedlejší číslo loop zařízení"

#: sys-utils/losetup.c:82
msgid "access backing file with direct-io"
msgstr "přistupovat k souboru pod zařízením přímým I/O"

#: sys-utils/losetup.c:83
msgid "logical sector size in bytes"
msgstr "velikost logického sektoru v bajtech"

#: sys-utils/losetup.c:140 sys-utils/losetup.c:151
#, c-format
msgid ", offset %ju"
msgstr ", odsazení %ju"

#: sys-utils/losetup.c:143 sys-utils/losetup.c:154
#, c-format
msgid ", sizelimit %ju"
msgstr ", velikostní limit %ju"

#: sys-utils/losetup.c:162
#, c-format
msgid ", encryption %s (type %u)"
msgstr ", šifrování %s (typ %u)"

#: sys-utils/losetup.c:206
#, c-format
msgid "%s: detach failed"
msgstr "%s: odpojení selhalo"

#: sys-utils/losetup.c:401
#, c-format
msgid ""
" %1$s [options] [<loopdev>]\n"
" %1$s [options] -f | <loopdev> <file>\n"
msgstr ""
" %1$s [přepínače] [<loop_zařízení>]\n"
" %1$s [přepínače] -f | <loop_zařízení> <soubor>\n"

#: sys-utils/losetup.c:406
msgid "Set up and control loop devices.\n"
msgstr "Nastaví a ovládá loop zařízení.\n"

#: sys-utils/losetup.c:410
msgid " -a, --all                     list all used devices\n"
msgstr " -a, --all                     vypíše všechna používaná zařízení\n"

#: sys-utils/losetup.c:411
msgid " -d, --detach <loopdev>...     detach one or more devices\n"
msgstr ""
" -d, --detach <loop_zařízení>…\n"
"                               odpojí jedno nebo více zařízení\n"

#: sys-utils/losetup.c:412
msgid " -D, --detach-all              detach all used devices\n"
msgstr " -D, --detach-all              odpojí všechna používaná zařízení\n"

#: sys-utils/losetup.c:413
msgid " -f, --find                    find first unused device\n"
msgstr " -f, --find                    najde první nepoužité zařízení\n"

#: sys-utils/losetup.c:414
msgid " -c, --set-capacity <loopdev>  resize the device\n"
msgstr ""
" -c, --set-capacity <loop_zařízení>\n"
"                               změní velikost zařízení\n"

#: sys-utils/losetup.c:415
msgid " -j, --associated <file>       list all devices associated with <file>\n"
msgstr " -j, --associated <soubor>     vypíše všechna zařízení spojená se <souborem>\n"

#: sys-utils/losetup.c:416
msgid " -L, --nooverlap               avoid possible conflict between devices\n"
msgstr " -L, --nooverlap               zabrání možným sporům mezi zařízeními\n"

#: sys-utils/losetup.c:420
msgid " -o, --offset <num>            start at offset <num> into file\n"
msgstr " -o, --offset <číslo>          v souboru začne na pozici <číslo>\n"

#: sys-utils/losetup.c:421
msgid "     --sizelimit <num>         device is limited to <num> bytes of the file\n"
msgstr "     --sizelimit <počet>       omezí zařízení na <počet> bajtů souboru\n"

#: sys-utils/losetup.c:422
msgid " -b, --sector-size <num>       set the logical sector size to <num>\n"
msgstr " -b, --sector-size <číslo>     nastaví velikost logického sektoru na <číslo>\n"

#: sys-utils/losetup.c:423
msgid " -P, --partscan                create a partitioned loop device\n"
msgstr " -P, --partscan                vytvoří loop zařízení rozdělené na oddíly\n"

#: sys-utils/losetup.c:424
msgid " -r, --read-only               set up a read-only loop device\n"
msgstr " -r, --read-only               nastaví loop zařízení jen pro čtení\n"

#: sys-utils/losetup.c:425
msgid "     --direct-io[=<on|off>]    open backing file with O_DIRECT\n"
msgstr "     --direct-io[=<on|off>]    otevře soubor pod zařízením s O_DIRECT\n"

#: sys-utils/losetup.c:426
msgid "     --show                    print device name after setup (with -f)\n"
msgstr "     --show                    vypíše název zařízení po nastavení (spolu s -f)\n"

#: sys-utils/losetup.c:427
msgid " -v, --verbose                 verbose mode\n"
msgstr " -v, --verbose                 upovídaný režim\n"

#: sys-utils/losetup.c:431
msgid " -J, --json                    use JSON --list output format\n"
msgstr " -J, --json                    formátuje výstup do JSONu\n"

#: sys-utils/losetup.c:432
msgid " -l, --list                    list info about all or specified (default)\n"
msgstr " -l, --list                    vypíše údaje o všech nebo zadaných (výchozí)\n"

#: sys-utils/losetup.c:433
msgid " -n, --noheadings              don't print headings for --list output\n"
msgstr " -n, --noheadings              nezobrazuje záhlaví ve výpisu --list\n"

#: sys-utils/losetup.c:434
msgid " -O, --output <cols>           specify columns to output for --list\n"
msgstr " -O, --output <sloupce>        určuje sloupce ve výstupu přepínače --list\n"

#: sys-utils/losetup.c:435
msgid "     --output-all              output all columns\n"
msgstr "     --output-all              vypíše všechny sloupce\n"

#: sys-utils/losetup.c:436
msgid "     --raw                     use raw --list output format\n"
msgstr "     --raw                     neformátovaný výstup --list\n"

#: sys-utils/losetup.c:464
#, c-format
msgid "%s: Warning: file is smaller than 512 bytes; the loop device may be useless or invisible for system tools."
msgstr "%s: Pozor: soubor je menší než 512 bajtů, loop zařízení možná bude nepoužitelné nebo neviditelné pro systémové nástroje."

#: sys-utils/losetup.c:468
#, c-format
msgid "%s: Warning: file does not fit into a 512-byte sector; the end of the file will be ignored."
msgstr "%s: Pozor: soubor není zarovnán na 512bajtové sektory, konec souboru bude ignorován."

#: sys-utils/losetup.c:490 sys-utils/losetup.c:542
#, c-format
msgid "%s: overlapping loop device exists"
msgstr "%s: existuje překrývající se loop zařízení"

#: sys-utils/losetup.c:501
#, c-format
msgid "%s: overlapping read-only loop device exists"
msgstr "%s: existuje překrývající se loop zařízení jen pro čtení"

#: sys-utils/losetup.c:508
#, c-format
msgid "%s: overlapping encrypted loop device exists"
msgstr "%s: existuje šifrované loop zařízení"

#: sys-utils/losetup.c:514
#, c-format
msgid "%s: failed to re-use loop device"
msgstr "%s: loop zařízení se nepodařilo znovu použít"

#: sys-utils/losetup.c:520
msgid "failed to inspect loop devices"
msgstr "loop zařízení se nepodařilo prozkoumat"

#: sys-utils/losetup.c:543
#, c-format
msgid "%s: failed to check for conflicting loop devices"
msgstr "%s: nepodařilo zkontrolovat, jestli loop zařízení nejsou ve sporu"

#: sys-utils/losetup.c:555 sys-utils/losetup.c:875
msgid "cannot find an unused loop device"
msgstr "nelze nalézt nepoužité loop zařízení"

#: sys-utils/losetup.c:568
#, c-format
msgid "%s: failed to use backing file"
msgstr "%s: podkladový soubor se nepodařilo použít"

#: sys-utils/losetup.c:661
msgid "failed to parse logical block size"
msgstr "velikost logického bloku se nepodařilo rozebrat"

#: sys-utils/losetup.c:667 sys-utils/losetup.c:677 sys-utils/losetup.c:801
#: sys-utils/losetup.c:815 sys-utils/losetup.c:855
#, c-format
msgid "%s: failed to use device"
msgstr "%s: zařízení nebylo možné použít"

#: sys-utils/losetup.c:812
msgid "no loop device specified"
msgstr "žádné loop zařízení nebylo zadáno"

#: sys-utils/losetup.c:827
#, c-format
msgid "the options %s are allowed during loop device setup only"
msgstr "přepínače %s jsou dovoleny jen při nastavování loop zařízení"

#: sys-utils/losetup.c:832
msgid "the option --offset is not allowed in this context"
msgstr "v tomto kontextu není přepínač --offset dovolen"

#: sys-utils/losetup.c:896
#, c-format
msgid "%s: set capacity failed"
msgstr "%s: nepodařilo se nastavit kapacitu"

#: sys-utils/losetup.c:903
#, c-format
msgid "%s: set direct io failed"
msgstr "%s: nepodařilo se nastavit přímé IO"

#: sys-utils/losetup.c:909
#, c-format
msgid "%s: set logical block size failed"
msgstr "%s: nepodařilo se nastavit velikost logické bloku"

# virtualization type
#: sys-utils/lscpu.c:82
msgid "none"
msgstr "žádná"

# virtualization type
#: sys-utils/lscpu.c:83
msgid "para"
msgstr "paravirtualizace"

# virtualization type
#: sys-utils/lscpu.c:84
msgid "full"
msgstr "plná"

# virtualization type
#: sys-utils/lscpu.c:85
msgid "container"
msgstr "kontejnerová"

# dispatching mode
#: sys-utils/lscpu.c:128
msgid "horizontal"
msgstr "vodorovný"

# dispatching mode
#: sys-utils/lscpu.c:129
msgid "vertical"
msgstr "svislý"

#: sys-utils/lscpu.c:197
msgid "logical CPU number"
msgstr "číslo logického CPU"

#: sys-utils/lscpu.c:198
msgid "logical core number"
msgstr "číslo logického jádra"

#: sys-utils/lscpu.c:199
msgid "logical socket number"
msgstr "číslo logické zásuvky"

#: sys-utils/lscpu.c:200
msgid "logical NUMA node number"
msgstr "číslo logické uzlu NUMA"

#: sys-utils/lscpu.c:201
msgid "logical book number"
msgstr "číslo logické knihy"

#: sys-utils/lscpu.c:202
msgid "logical drawer number"
msgstr "číslo logické zásuvky"

#: sys-utils/lscpu.c:203
msgid "shows how caches are shared between CPUs"
msgstr "ukáže sdílení keše mezi CPU"

#: sys-utils/lscpu.c:204
msgid "CPU dispatching mode on virtual hardware"
msgstr "režim rozhodování CPU na virtuálním hardwaru"

#: sys-utils/lscpu.c:205
msgid "physical address of a CPU"
msgstr "fyzická adresa CPU"

#: sys-utils/lscpu.c:206
msgid "shows if the hypervisor has allocated the CPU"
msgstr "ukáže, zda-li hypervizor alokoval CPU"

#: sys-utils/lscpu.c:207
msgid "shows if Linux currently makes use of the CPU"
msgstr "ukáže, zda-li nyní Linux nutí používat toto CPU"

#: sys-utils/lscpu.c:208
msgid "shows the maximum MHz of the CPU"
msgstr "ukáže maximální frekvenci CPU"

#: sys-utils/lscpu.c:209
msgid "shows the minimum MHz of the CPU"
msgstr "ukáže minimální frekvenci CPU"

#: sys-utils/lscpu.c:214
msgid "size of all system caches"
msgstr "velikost všech systémových keší"

#: sys-utils/lscpu.c:215
msgid "cache level"
msgstr "úroveň keše"

#: sys-utils/lscpu.c:216
msgid "cache name"
msgstr "název keše"

#: sys-utils/lscpu.c:217
msgid "size of one cache"
msgstr "velikost jedné keše"

#: sys-utils/lscpu.c:218
msgid "cache type"
msgstr "typ keše"

#: sys-utils/lscpu.c:219
msgid "ways of associativity"
msgstr "cest asociativity"

#: sys-utils/lscpu.c:220
msgid "allocation policy"
msgstr "politika alokace"

#: sys-utils/lscpu.c:221
msgid "write policy"
msgstr "politika zápisu"

#: sys-utils/lscpu.c:222
msgid "number of physical cache line per cache t"
msgstr "počet fyzických řádků keše na keš t"

#: sys-utils/lscpu.c:223
msgid "number of sets in the cache; set lines has the same cache index"
msgstr "počet množin v keši, řádky jedné množiny mají stejný ukazatel do keše"

#: sys-utils/lscpu.c:224
msgid "minimum amount of data in bytes transferred from memory to cache"
msgstr "minimální množství dat v bajtech, které lze přesunout z paměti do keše"

#: sys-utils/lscpu.c:532
msgid "error: uname failed"
msgstr "chyba: volání uname selhalo"

#: sys-utils/lscpu.c:626
#, c-format
msgid "failed to determine number of CPUs: %s"
msgstr "nezdařilo se určit počet CPU: %s"

#: sys-utils/lscpu.c:894
msgid "cannot restore signal handler"
msgstr "obsluhu signálu nelze obnovit"

#: sys-utils/lscpu.c:1468
msgid "Failed to extract the node number"
msgstr "Získání čísla uzlu selhalo"

#: sys-utils/lscpu.c:1599 sys-utils/lscpu.c:1609
msgid "Y"
msgstr "A"

#: sys-utils/lscpu.c:1599 sys-utils/lscpu.c:1609
msgid "N"
msgstr "N"

#: sys-utils/lscpu.c:1817
#, c-format
msgid ""
"# The following is the parsable format, which can be fed to other\n"
"# programs. Each different item in every column has an unique ID\n"
"# starting from zero.\n"
msgstr ""
"# Následuje snadno rozebratelný formát, který lze poslat do jiných\n"
"# programů. Každá různá položka v každém sloupci má jedinečné ID,\n"
"# které se počítá od nuly.\n"

#: sys-utils/lscpu.c:2046
msgid "Architecture:"
msgstr "Architektura:"

# FIXME: value alignment counts bytes instead of columns
#: sys-utils/lscpu.c:2059
msgid "CPU op-mode(s):"
msgstr "Operační režim(y) CPU:"

#: sys-utils/lscpu.c:2062 sys-utils/lscpu.c:2064
msgid "Byte Order:"
msgstr "Pořadí bajtů:"

#: sys-utils/lscpu.c:2068
msgid "Address sizes:"
msgstr "Velikost adresy:"

#: sys-utils/lscpu.c:2070
msgid "CPU(s):"
msgstr "Počet CPU:"

#: sys-utils/lscpu.c:2073
msgid "On-line CPU(s) mask:"
msgstr "Maska zapnutých CPU:"

#: sys-utils/lscpu.c:2074
msgid "On-line CPU(s) list:"
msgstr "Seznam zapnutých CPU:"

#: sys-utils/lscpu.c:2086
msgid "failed to callocate cpu set"
msgstr "množinu CPU nelze alokovat"

#: sys-utils/lscpu.c:2093
msgid "Off-line CPU(s) mask:"
msgstr "Maska vypnutých CPU:"

#: sys-utils/lscpu.c:2094
msgid "Off-line CPU(s) list:"
msgstr "Seznam vypnutých CPU:"

#: sys-utils/lscpu.c:2129
msgid "Thread(s) per core:"
msgstr "Vláken na jádro:"

#: sys-utils/lscpu.c:2131
msgid "Core(s) per socket:"
msgstr "Jader na patici:"

#: sys-utils/lscpu.c:2134
msgid "Socket(s) per book:"
msgstr "Patic na knihu:"

#: sys-utils/lscpu.c:2137
msgid "Book(s) per drawer:"
msgstr "Knih na zásuvku:"

#: sys-utils/lscpu.c:2139
msgid "Drawer(s):"
msgstr "Zásuvky:"

#: sys-utils/lscpu.c:2141
msgid "Book(s):"
msgstr "Knihy:"

#: sys-utils/lscpu.c:2144
msgid "Socket(s):"
msgstr "Patic:"

#: sys-utils/lscpu.c:2148
msgid "NUMA node(s):"
msgstr "Uzly NUMA:"

#: sys-utils/lscpu.c:2150
msgid "Vendor ID:"
msgstr "ID výrobce:"

#: sys-utils/lscpu.c:2152
msgid "Machine type:"
msgstr "Typ stroje:"

#: sys-utils/lscpu.c:2154
msgid "CPU family:"
msgstr "Rodina CPU:"

#: sys-utils/lscpu.c:2156
msgid "Model:"
msgstr "Model:"

#: sys-utils/lscpu.c:2158
msgid "Model name:"
msgstr "Název modelu:"

# ???: Existuje český překlad?
#: sys-utils/lscpu.c:2160
msgid "Stepping:"
msgstr "Stepping:"

#: sys-utils/lscpu.c:2162
msgid "Frequency boost:"
msgstr "Navýšení frekvence: "

#: sys-utils/lscpu.c:2163
msgid "enabled"
msgstr "zapnuto"

#: sys-utils/lscpu.c:2163
msgid "disabled"
msgstr "vypnuto"

#: sys-utils/lscpu.c:2165
msgid "CPU MHz:"
msgstr "CPU MHz:"

#: sys-utils/lscpu.c:2167
msgid "CPU dynamic MHz:"
msgstr "CPU dynamické MHz:"

#: sys-utils/lscpu.c:2169
msgid "CPU static MHz:"
msgstr "CPU statické MHz:"

#: sys-utils/lscpu.c:2171
msgid "CPU max MHz:"
msgstr "CPU max. MHz:"

#: sys-utils/lscpu.c:2173
msgid "CPU min MHz:"
msgstr "CPU min. MHz:"

#: sys-utils/lscpu.c:2175
msgid "BogoMIPS:"
msgstr "BogoMIPS:"

#: sys-utils/lscpu.c:2178 sys-utils/lscpu.c:2180
msgid "Virtualization:"
msgstr "Virtualizace:"

#: sys-utils/lscpu.c:2183
msgid "Hypervisor:"
msgstr "Hypervizor:"

#: sys-utils/lscpu.c:2185
msgid "Hypervisor vendor:"
msgstr "Výrobce hypervizoru:"

#: sys-utils/lscpu.c:2186
msgid "Virtualization type:"
msgstr "Druh virtualizace:"

#: sys-utils/lscpu.c:2189
msgid "Dispatching mode:"
msgstr "Režim rozhodování:"

#: sys-utils/lscpu.c:2206 sys-utils/lscpu.c:2224
#, c-format
msgid "%s cache:"
msgstr "%s keš:"

#: sys-utils/lscpu.c:2231
#, c-format
msgid "NUMA node%d CPU(s):"
msgstr "CPU NUMA uzlu %d:"

#: sys-utils/lscpu.c:2236
msgid "Physical sockets:"
msgstr "Fyzické sockety:"

#: sys-utils/lscpu.c:2237
msgid "Physical chips:"
msgstr "Fyzické čipy:"

#: sys-utils/lscpu.c:2238
msgid "Physical cores/chip:"
msgstr "Fyzická jádra/čip:"

#: sys-utils/lscpu.c:2249
msgid "Flags:"
msgstr "Příznaky:"

#: sys-utils/lscpu.c:2264
msgid "Display information about the CPU architecture.\n"
msgstr "Zobrazí údaje o architektuře CPU.\n"

#: sys-utils/lscpu.c:2267
msgid " -a, --all               print both online and offline CPUs (default for -e)\n"
msgstr " -a, --all               vypíše zapnutá i vypnutá CPU (výchozí pro -e)\n"

#: sys-utils/lscpu.c:2268
msgid " -b, --online            print online CPUs only (default for -p)\n"
msgstr " -b, --online            vypíše jen zapnutá CPUs (výchozí pro -p)\n"

#: sys-utils/lscpu.c:2269
msgid " -B, --bytes             print sizes in bytes rather than in human readable format\n"
msgstr ""
" -B, --bytes             velikosti vypisuje v bajtech namísto v podobě\n"
"                         vhodné pro člověka\n"

#: sys-utils/lscpu.c:2270
msgid " -C, --caches[=<list>]   info about caches in extended readable format\n"
msgstr " -C, --caches[=<seznam>]  údaje o keších v rozšířeném čitelném formátu\n"

#: sys-utils/lscpu.c:2271
msgid " -c, --offline           print offline CPUs only\n"
msgstr " -c, --offline           vypíše jen vypnutá CPU\n"

#: sys-utils/lscpu.c:2272
msgid " -J, --json              use JSON for default or extended format\n"
msgstr " -J, --json              výchozí nebo rozšířený výstup formátuje do JSONu\n"

#: sys-utils/lscpu.c:2273
msgid " -e, --extended[=<list>] print out an extended readable format\n"
msgstr " -e, --extended[=<seznam>]  výpis v rozšířeném čitelném formátu\n"

#: sys-utils/lscpu.c:2274
msgid " -p, --parse[=<list>]    print out a parsable format\n"
msgstr " -p, --parse[=<seznam>]  výpis v rozebratelném formátu\n"

#: sys-utils/lscpu.c:2275
msgid " -s, --sysroot <dir>     use specified directory as system root\n"
msgstr " -s, --sysroot <adresář>  jako kořen systému použije <adresář>\n"

#: sys-utils/lscpu.c:2276
msgid " -x, --hex               print hexadecimal masks rather than lists of CPUs\n"
msgstr " -x, --hex               vypíše šestnáctkové masky namísto seznamů CPU\n"

#: sys-utils/lscpu.c:2277
msgid " -y, --physical          print physical instead of logical IDs\n"
msgstr " -y, --physical          vypíše fyzické identifikátory namísto logických\n"

#: sys-utils/lscpu.c:2278
msgid "     --output-all        print all available columns for -e, -p or -C\n"
msgstr "     --output-all        vypíše všechny dostupné sloupce u -e, -p a -C\n"

#: sys-utils/lscpu.c:2282
msgid ""
"\n"
"Available output columns for -e or -p:\n"
msgstr ""
"\n"
"Dostupné sloupce pro výstup u -e a -p:\n"

#: sys-utils/lscpu.c:2286
msgid ""
"\n"
"Available output columns for -C:\n"
msgstr ""
"\n"
"Dostupné sloupce pro výstup u -C:\n"

#: sys-utils/lscpu.c:2419
#, c-format
msgid "%s: options --all, --online and --offline may only be used with options --extended or --parse.\n"
msgstr ""
"%s: přepínače --all, --online a --offline lze použít jen\n"
"s přepínači --extended nebo --parse.\n"

#: sys-utils/lscpu.c:2441
msgid "failed to initialize CPUs sysfs handler"
msgstr "nepodařilo inicializovat deskriptor sysfs pro CPU"

#: sys-utils/lscpu.c:2448
msgid "failed to initialize procfs handler"
msgstr "nepodařilo inicializovat deskriptor procfs"

#: sys-utils/lsipc.c:149
msgid "Resource key"
msgstr "Název zdroje"

#: sys-utils/lsipc.c:149
msgid "Key"
msgstr "Klíč"

#: sys-utils/lsipc.c:150
msgid "Resource ID"
msgstr "ID zdroje"

#: sys-utils/lsipc.c:150
msgid "ID"
msgstr "ID"

#: sys-utils/lsipc.c:151
msgid "Owner's username or UID"
msgstr "Jméno nebo UID vlastníka"

#: sys-utils/lsipc.c:151
msgid "Owner"
msgstr "Vlastník"

#: sys-utils/lsipc.c:152
msgid "Permissions"
msgstr "Práva"

#: sys-utils/lsipc.c:153
msgid "Creator UID"
msgstr "UID původce"

#: sys-utils/lsipc.c:154
msgid "Creator user"
msgstr "Jméno původce"

#: sys-utils/lsipc.c:155
msgid "Creator GID"
msgstr "GID původce"

#: sys-utils/lsipc.c:156
msgid "Creator group"
msgstr "Skupina původce"

#: sys-utils/lsipc.c:157
msgid "User ID"
msgstr "ID uživatele"

#: sys-utils/lsipc.c:157
msgid "UID"
msgstr "UID"

#: sys-utils/lsipc.c:158
msgid "User name"
msgstr "Uživatelské jméno"

#: sys-utils/lsipc.c:159
msgid "Group ID"
msgstr "ID skupiny"

#: sys-utils/lsipc.c:159
msgid "GID"
msgstr "GID"

#: sys-utils/lsipc.c:160
msgid "Group name"
msgstr "Název skupiny"

#: sys-utils/lsipc.c:161
msgid "Time of the last change"
msgstr "Čas poslední změny"

#: sys-utils/lsipc.c:161
msgid "Last change"
msgstr "Poslední změna"

#: sys-utils/lsipc.c:164
msgid "Bytes used"
msgstr "Použito bajtů"

#: sys-utils/lsipc.c:165
msgid "Number of messages"
msgstr "Počet zpráv"

#: sys-utils/lsipc.c:165
msgid "Messages"
msgstr "Zprávy"

#: sys-utils/lsipc.c:166
msgid "Time of last msg sent"
msgstr "Čas odeslání poslední zprávy"

#: sys-utils/lsipc.c:166
msgid "Msg sent"
msgstr "Zpráv odesláno"

#: sys-utils/lsipc.c:167
msgid "Time of last msg received"
msgstr "Čas přijetí poslední zprávy"

#: sys-utils/lsipc.c:167
msgid "Msg received"
msgstr "Zpráv přijato"

#: sys-utils/lsipc.c:168
msgid "PID of the last msg sender"
msgstr "PID odesílatele poslední zprávy"

#: sys-utils/lsipc.c:168
msgid "Msg sender"
msgstr "Odesílatel zprávy"

#: sys-utils/lsipc.c:169
msgid "PID of the last msg receiver"
msgstr "PID příjemce poslední zprávy"

#: sys-utils/lsipc.c:169
msgid "Msg receiver"
msgstr "Příjemce zprávy"

#: sys-utils/lsipc.c:172
msgid "Segment size"
msgstr "Velikost bloku"

#: sys-utils/lsipc.c:173
msgid "Number of attached processes"
msgstr "Počet připojených procesů"

#: sys-utils/lsipc.c:173
msgid "Attached processes"
msgstr "Připojené procesy"

#: sys-utils/lsipc.c:174
msgid "Status"
msgstr "Stav"

#: sys-utils/lsipc.c:175
msgid "Attach time"
msgstr "Čas připojení"

#: sys-utils/lsipc.c:176
msgid "Detach time"
msgstr "Čas odpojení"

#: sys-utils/lsipc.c:177
msgid "Creator command line"
msgstr "Příkazový řádek původce"

#: sys-utils/lsipc.c:177
msgid "Creator command"
msgstr "Příkaz původce"

#: sys-utils/lsipc.c:178
msgid "PID of the creator"
msgstr "PID původce"

#: sys-utils/lsipc.c:178
msgid "Creator PID"
msgstr "PID původce"

#: sys-utils/lsipc.c:179
msgid "PID of last user"
msgstr "PID posledního uživatele"

#: sys-utils/lsipc.c:179
msgid "Last user PID"
msgstr "PID posledního uživatele"

#: sys-utils/lsipc.c:182
msgid "Number of semaphores"
msgstr "Počet semaforů"

#: sys-utils/lsipc.c:182
msgid "Semaphores"
msgstr "Semafory"

#: sys-utils/lsipc.c:183
msgid "Time of the last operation"
msgstr "Čas poslední operace"

#: sys-utils/lsipc.c:183
msgid "Last operation"
msgstr "Poslední operace"

#: sys-utils/lsipc.c:186
msgid "Resource name"
msgstr "Název zdroje"

#: sys-utils/lsipc.c:186
msgid "Resource"
msgstr "Zdroj"

#: sys-utils/lsipc.c:187
msgid "Resource description"
msgstr "Popis zdroje"

#: sys-utils/lsipc.c:187
msgid "Description"
msgstr "Popis"

#: sys-utils/lsipc.c:188
msgid "Currently used"
msgstr "Právě využito"

#: sys-utils/lsipc.c:188
msgid "Used"
msgstr "Využito"

#: sys-utils/lsipc.c:189
msgid "Currently use percentage"
msgstr "Využití v procentech"

#: sys-utils/lsipc.c:189
msgid "Use"
msgstr "Užito"

#: sys-utils/lsipc.c:190
msgid "System-wide limit"
msgstr "Omezení systému"

#: sys-utils/lsipc.c:190
msgid "Limit"
msgstr "Omezení"

#: sys-utils/lsipc.c:225
#, c-format
msgid "column %s does not apply to the specified IPC"
msgstr "sloupec %s se nevztahuje na uvedené IPC"

#: sys-utils/lsipc.c:301
msgid " -g, --global      info about system-wide usage (may be used with -m, -q and -s)\n"
msgstr " -g, --global      údaje o využití systému (lze použít s -m, -q a -s)\n"

#: sys-utils/lsipc.c:302
msgid " -i, --id <id>     print details on resource identified by <id>\n"
msgstr " -i, --id <ID>     zobrazí podrobnosti o prostředku určeném dle <ID>\n"

#: sys-utils/lsipc.c:308
msgid " -b, --bytes              print SIZE in bytes rather than in human readable format\n"
msgstr ""
" -b, --bytes              velikosti vypisuje v bajtech namísto podobě vhodné\n"
"                          pro člověka\n"

#: sys-utils/lsipc.c:309
msgid " -c, --creator            show creator and owner\n"
msgstr " -c, --creator            zobrazí tvůrce a vlastníka\n"

#: sys-utils/lsipc.c:311
msgid " -J, --json               use the JSON output format\n"
msgstr " -J, --json               formátuje výstup do JSONu\n"

#: sys-utils/lsipc.c:313
msgid " -l, --list               force list output format (for example with --id)\n"
msgstr " -l, --list               vynutí výstup jako seznam (například s --id)\n"

#: sys-utils/lsipc.c:315
msgid " -P, --numeric-perms      print numeric permissions (PERMS column)\n"
msgstr " -P, --numeric-perms      vypisuje číselná práva (sloupec PERMS)\n"

#: sys-utils/lsipc.c:317
msgid " -t, --time               show attach, detach and change times\n"
msgstr " -t, --time               zobrazí časy připojení, odpojení a změny\n"

#: sys-utils/lsipc.c:322
#, c-format
msgid ""
"\n"
"Generic columns:\n"
msgstr ""
"\n"
"Obecné slupce:\n"

#: sys-utils/lsipc.c:326
#, c-format
msgid ""
"\n"
"Shared-memory columns (--shmems):\n"
msgstr ""
"\n"
"Sloupce sdílené paměti (--shmems):\n"

#: sys-utils/lsipc.c:330
#, c-format
msgid ""
"\n"
"Message-queue columns (--queues):\n"
msgstr ""
"\n"
"Slupce fronty zpráv (--queues):\n"

#: sys-utils/lsipc.c:334
#, c-format
msgid ""
"\n"
"Semaphore columns (--semaphores):\n"
msgstr ""
"\n"
"Slupce semaforů (--semaphores):\n"

#: sys-utils/lsipc.c:338
#, c-format
msgid ""
"\n"
"Summary columns (--global):\n"
msgstr ""
"\n"
"Sloupce souhrnu (--global):\n"

#: sys-utils/lsipc.c:424
#, c-format
msgid ""
"Elements:\n"
"\n"
msgstr ""
"Prvky:\n"
"\n"

#: sys-utils/lsipc.c:697 sys-utils/lsipc.c:858 sys-utils/lsipc.c:1057
msgid "failed to set data"
msgstr "data se nepodařilo nastavit"

#: sys-utils/lsipc.c:722
msgid "Number of semaphore identifiers"
msgstr "Počet identifikátorů semaforů"

#: sys-utils/lsipc.c:723
msgid "Total number of semaphores"
msgstr "Celkový počet semaforů"

#: sys-utils/lsipc.c:724
msgid "Max semaphores per semaphore set."
msgstr "Maximum semaforů na množinu semaforů."

#: sys-utils/lsipc.c:725
msgid "Max number of operations per semop(2)"
msgstr "Maximální počet operací na semop(2)"

#: sys-utils/lsipc.c:726
msgid "Semaphore max value"
msgstr "Maximální hodnota semaforu"

#: sys-utils/lsipc.c:883
msgid "Number of message queues"
msgstr "Počet front zpráv"

#: sys-utils/lsipc.c:884
msgid "Max size of message (bytes)"
msgstr "Maximální velikost zprávy (bajty)"

#: sys-utils/lsipc.c:885
msgid "Default max size of queue (bytes)"
msgstr "Výchozí maximální velikost fronty (bajty)"

#: sys-utils/lsipc.c:999 sys-utils/lsipc.c:1018
msgid "hugetlb"
msgstr "hugetlb"

#: sys-utils/lsipc.c:1000 sys-utils/lsipc.c:1025
msgid "noreserve"
msgstr "nerezervováno"

#: sys-utils/lsipc.c:1082
msgid "Shared memory segments"
msgstr "Segmenty sdílené paměti"

#: sys-utils/lsipc.c:1083
msgid "Shared memory pages"
msgstr "Stránky sdílené paměti"

#: sys-utils/lsipc.c:1084
msgid "Max size of shared memory segment (bytes)"
msgstr "Maximální velikost segmentu sdílené paměti (bajty)"

#: sys-utils/lsipc.c:1085
msgid "Min size of shared memory segment (bytes)"
msgstr "Minimální velikost segmentu sdílené paměti (bajty)"

#: sys-utils/lsipc.c:1155
msgid "failed to parse IPC identifier"
msgstr "nezdařilo rozebrat identifikátor IPC"

#: sys-utils/lsipc.c:1249
msgid "--global is mutually exclusive with --creator, --id and --time"
msgstr "--global se vzájemně vylučuje s --creator, --id a --time"

#: sys-utils/lsirq.c:60
#, fuzzy
msgid "Utility to display kernel interrupt information."
msgstr "Zobrazí údaje z profilování jádra.\n"

#: sys-utils/lsmem.c:126
msgid "start and end address of the memory range"
msgstr "počáteční a koncová adresa rozsahu paměti"

#: sys-utils/lsmem.c:127
msgid "size of the memory range"
msgstr "velikost rozsahu paměti"

#: sys-utils/lsmem.c:128
msgid "online status of the memory range"
msgstr "stav zapojení rozsahu paměti"

#: sys-utils/lsmem.c:129
msgid "memory is removable"
msgstr "paměť je odebíratelná"

#: sys-utils/lsmem.c:130
msgid "memory block number or blocks range"
msgstr "číslo bloku paměti nebo rozsah bloků"

#: sys-utils/lsmem.c:131
msgid "numa node of memory"
msgstr "uzel NUMA paměti"

#: sys-utils/lsmem.c:132
msgid "valid zones for the memory range"
msgstr "platné zóny pro rozsahu paměti"

#: sys-utils/lsmem.c:259
msgid "online"
msgstr "připojeno"

#: sys-utils/lsmem.c:260
msgid "offline"
msgstr "odpojeno"

#: sys-utils/lsmem.c:261
msgid "on->off"
msgstr "připojeno → odpojeno"

#: sys-utils/lsmem.c:315 sys-utils/lsmem.c:322
msgid "Memory block size:"
msgstr "Velikost paměťového bloku:"

#: sys-utils/lsmem.c:316 sys-utils/lsmem.c:326
msgid "Total online memory:"
msgstr "Celkem připojené paměti"

#: sys-utils/lsmem.c:317 sys-utils/lsmem.c:330
msgid "Total offline memory:"
msgstr "Celkem odpojené paměti:"

#: sys-utils/lsmem.c:343
#, c-format
msgid "Failed to open %s"
msgstr "%s se nepodařilo otevřít"

#: sys-utils/lsmem.c:453
msgid "failed to read memory block size"
msgstr "přečtení velikosti bloku paměti se nepodařilo"

#: sys-utils/lsmem.c:484
msgid "This system does not support memory blocks"
msgstr "Tento systém nepodporuje paměťové bloky"

#: sys-utils/lsmem.c:509
msgid "List the ranges of available memory with their online status.\n"
msgstr "Vypíše rozsahy dostupné paměti spolu s jejich stavem připojení.\n"

#: sys-utils/lsmem.c:514
msgid " -a, --all            list each individual memory block\n"
msgstr " -a, --all            vypíše každý jednotlivý paměťový blok\n"

#: sys-utils/lsmem.c:520
msgid " -S, --split <list>   split ranges by specified columns\n"
msgstr " -S, --split <seznam> rozsahy rozdělí zadanými sloupci\n"

#: sys-utils/lsmem.c:521
msgid " -s, --sysroot <dir>  use the specified directory as system root\n"
msgstr ""
" -s, --sysroot <adresář>\n"
"                      jako kořen systému použije zadaný <adresář>\n"

#: sys-utils/lsmem.c:522
msgid "     --summary[=when] print summary information (never,always or only)\n"
msgstr ""
"     --summary[=kdy]  vypíše souhrnné údaje (never [nikdy], always [vždy]\n"
"                      nebo only [pouze]\n"

#: sys-utils/lsmem.c:628
msgid "unsupported --summary argument"
msgstr "nepodporovaný argument --summary"

#: sys-utils/lsmem.c:648
msgid "options --{raw,json,pairs} and --summary=only are mutually exclusive"
msgstr "přepínače --{raw,json,pairs} a --summary=only se vzájemně vylučují"

#: sys-utils/lsmem.c:656
msgid "invalid argument to --sysroot"
msgstr "neplatný argument za --sysroot"

#: sys-utils/lsmem.c:704
msgid "Failed to initialize output column"
msgstr "Výstupní sloupec se nepodařilo inicializovat"

#: sys-utils/lsns.c:99
msgid "namespace identifier (inode number)"
msgstr "identifikátor jmenného prostoru (číslo i-uzlu)"

#: sys-utils/lsns.c:100
msgid "kind of namespace"
msgstr "druh jmenného prostoru"

#: sys-utils/lsns.c:101
msgid "path to the namespace"
msgstr "cesta ke jmennému prostoru"

#: sys-utils/lsns.c:102
msgid "number of processes in the namespace"
msgstr "počet procesů ve jmenném prostoru"

#: sys-utils/lsns.c:103
msgid "lowest PID in the namespace"
msgstr "nejnižší PID ve jmenném prostoru"

#: sys-utils/lsns.c:104
msgid "PPID of the PID"
msgstr "PPID procesu"

#: sys-utils/lsns.c:105
msgid "command line of the PID"
msgstr "příkazová řádka procesu"

#: sys-utils/lsns.c:106
msgid "UID of the PID"
msgstr "UID procesu"

#: sys-utils/lsns.c:107
msgid "username of the PID"
msgstr "jméno uživatele procesu"

#: sys-utils/lsns.c:108
msgid "namespace ID as used by network subsystem"
msgstr "ID jmenného prostoru, jak jej používá síťový podsystém"

#: sys-utils/lsns.c:109
msgid "nsfs mountpoint (usually used network subsystem)"
msgstr "bod připojení jmenného prostoru souborového systému (obvykle použitý síťový podsystém)"

#: sys-utils/lsns.c:899
#, c-format
msgid " %s [options] [<namespace>]\n"
msgstr " %s [přepínače] [<jmenný prostor>]\n"

#: sys-utils/lsns.c:902
msgid "List system namespaces.\n"
msgstr "Vypíše jmenné prostory na systému.\n"

#: sys-utils/lsns.c:910
msgid " -p, --task <pid>       print process namespaces\n"
msgstr " -p, --task <PID>       vypíše jmenný prostor procesu\n"

#: sys-utils/lsns.c:913
msgid " -W, --nowrap           don't use multi-line representation\n"
msgstr " -W, --nowrap           nepoužije víceřádkový formát\n"

#: sys-utils/lsns.c:914
#, fuzzy
msgid " -t, --type <name>      namespace type (mnt, net, ipc, user, pid, uts, cgroup, time)\n"
msgstr ""
" -t, --type <název>     druh jmenného prostoru (mnt, net, ipc, user, pid, uts,\n"
"                        cgroup)\n"

#: sys-utils/lsns.c:1008
#, c-format
msgid "unknown namespace type: %s"
msgstr "druh jmenného prostoru není znám: %s"

#: sys-utils/lsns.c:1037
msgid "--task is mutually exclusive with <namespace>"
msgstr "přepínač --task a <jmenný prostor> se vzájemně vylučují"

#: sys-utils/lsns.c:1038
msgid "invalid namespace argument"
msgstr "neplatný argument se jmenným prostorem"

#: sys-utils/lsns.c:1090
#, c-format
msgid "not found namespace: %ju"
msgstr "jmenný prostor nenalezen: %ju"

#: sys-utils/mount.c:65 sys-utils/umount.c:130
msgid "drop permissions failed."
msgstr "zbavení se oprávnění selhalo."

#: sys-utils/mount.c:78 sys-utils/umount.c:64
#, c-format
msgid "%s from %s (libmount %s"
msgstr "%s z %s (libmount %s"

#: sys-utils/mount.c:123
msgid "failed to read mtab"
msgstr "čtení mtab selhalo"

#: sys-utils/mount.c:185 sys-utils/mount.c:252 sys-utils/umount.c:197
#, c-format
msgid "%-25s: ignored\n"
msgstr "%-25s: ignoruje se\n"

#: sys-utils/mount.c:186
#, c-format
msgid "%-25s: already mounted\n"
msgstr "%-25s: již připojeno\n"

#: sys-utils/mount.c:293
#, c-format
msgid "%s: %s moved to %s.\n"
msgstr "%s: %s přesunuto do %s.\n"

#: sys-utils/mount.c:295
#, c-format
msgid "%s: %s bound on %s.\n"
msgstr "%s: %s připojeno způsobem bind do %s.\n"

#: sys-utils/mount.c:298 sys-utils/mount.c:302
#, c-format
msgid "%s: %s mounted on %s.\n"
msgstr "%s: %s připojeno do %s.\n"

#: sys-utils/mount.c:300
#, c-format
msgid "%s: %s propagation flags changed.\n"
msgstr "%s: Příznaky propagace %s změněny.\n"

#: sys-utils/mount.c:320
#, c-format
msgid ""
"mount: %s does not contain SELinux labels.\n"
"       You just mounted an file system that supports labels which does not\n"
"       contain labels, onto an SELinux box. It is likely that confined\n"
"       applications will generate AVC messages and not be allowed access to\n"
"       this file system.  For more details see restorecon(8) and mount(8).\n"
msgstr ""
"mount: %s neobsahuje značky SELinuxu.\n"
"       Právě jste připojili souborový systém, který značky podporuje, ale\n"
"       neobsahuje ani jednu, do stroje s podporou SELinuxu. Je pravděpodobné,\n"
"       že omezené aplikace budou generovat zprávy AVC a nebude jim dovoleno\n"
"       přistoupit na tento systém souborů. Další rady lze nalézt\n"
"       v restorecon(8) a mount(8).\n"

#: sys-utils/mount.c:378
#, c-format
msgid "%s: failed to parse"
msgstr "%s: rozbor se nezdařil"

#: sys-utils/mount.c:418
#, c-format
msgid "unsupported option format: %s"
msgstr "nepodporovaný formát parametru: %s"

# XXX: Nepřekládat „append“ jako „připojit“, hrozí záměna s „mount“
#: sys-utils/mount.c:420
#, c-format
msgid "failed to append option '%s'"
msgstr "nepodařilo se přiřetězit volby „%s“"

#: sys-utils/mount.c:438
#, c-format
msgid ""
" %1$s [-lhV]\n"
" %1$s -a [options]\n"
" %1$s [options] [--source] <source> | [--target] <directory>\n"
" %1$s [options] <source> <directory>\n"
" %1$s <operation> <mountpoint> [<target>]\n"
msgstr ""
" %1$s [-lhV]\n"
" %1$s -a [přepínače]\n"
" %1$s [přepínače] [--source] <zdroj> | [--target] <adresář>\n"
" %1$s [přepínače] <zdroj> <adresář>\n"
" %1$s <operace> <bod_připojení> [<cíl>]\n"

#: sys-utils/mount.c:446
msgid "Mount a filesystem.\n"
msgstr "Připojí souborový systém.\n"

#: sys-utils/mount.c:450
#, c-format
msgid ""
" -a, --all               mount all filesystems mentioned in fstab\n"
" -c, --no-canonicalize   don't canonicalize paths\n"
" -f, --fake              dry run; skip the mount(2) syscall\n"
" -F, --fork              fork off for each device (use with -a)\n"
" -T, --fstab <path>      alternative file to /etc/fstab\n"
msgstr ""
" -a, --all               připojí veškeré souborové systémy uvedené ve fstab\n"
" -c, --no-canonicalize   nenormalizuje cesty\n"
" -f, --fake              zkušební režim, přeskočí systémové volání mount(2)\n"
" -F, --fork              pro každé zařízení vytvoří potomka (použijte s -a)\n"
" -T, --fstab <cesta>     náhrada za /etc/fstab\n"

#: sys-utils/mount.c:456
#, c-format
msgid " -i, --internal-only     don't call the mount.<type> helpers\n"
msgstr " -i, --internal-only     nevolá pomocné programy mount.<typ>\n"

#: sys-utils/mount.c:458
#, c-format
msgid " -l, --show-labels       show also filesystem labels\n"
msgstr " -l, --show-labels       ukáže rovněž jmenovky souborových systémů\n"

#: sys-utils/mount.c:460 sys-utils/umount.c:98
#, c-format
msgid " -n, --no-mtab           don't write to /etc/mtab\n"
msgstr " -n, --no-mtab           nezapíše do /etc/mtab\n"

#: sys-utils/mount.c:462
#, c-format
msgid ""
"     --options-mode <mode>\n"
"                         what to do with options loaded from fstab\n"
"     --options-source <source>\n"
"                         mount options source\n"
"     --options-source-force\n"
"                         force use of options from fstab/mtab\n"
msgstr ""
"     --options-mode <režim>\n"
"                         co dělat s volbami načtenými ze souboru fstab\n"
"     --options-source <zdroj>\n"
"                         zdroj voleb pro připojení\n"
"     --options-source-force\n"
"                         vynutí použití voleb ze souborů fstab/mtab\n"

#: sys-utils/mount.c:469
#, c-format
msgid ""
" -o, --options <list>    comma-separated list of mount options\n"
" -O, --test-opts <list>  limit the set of filesystems (use with -a)\n"
" -r, --read-only         mount the filesystem read-only (same as -o ro)\n"
" -t, --types <list>      limit the set of filesystem types\n"
msgstr ""
" -o, --options <seznam>  čárkou oddělený seznam parametrů připojení\n"
" -O, --test-opts <seznam>\n"
"                         omezí množinu souborových systémů (použijte s -a)\n"
" -r, --read-only         souborový systém připojí jen pro čtení\n"
"                         (stejné jako -o ro)\n"
" -t, --types <seznam>    omezí množinu typů souborových systémů\n"

#: sys-utils/mount.c:474
#, c-format
msgid ""
"     --source <src>      explicitly specifies source (path, label, uuid)\n"
"     --target <target>   explicitly specifies mountpoint\n"
msgstr ""
"     --source <zdroj>    výslovně určí zdroj (cesta, jmenovka, UUID)\n"
"     --target <cíl>      výslovně určí bod připojení\n"

#: sys-utils/mount.c:477
#, c-format
msgid ""
"     --target-prefix <path>\n"
"                         specifies path use for all mountpoints\n"
msgstr ""
"     --target-prefix <cesta>\n"
"                         určuje cestu pro všechny body připojení\n"

#: sys-utils/mount.c:480 sys-utils/umount.c:104
#, c-format
msgid " -v, --verbose           say what is being done\n"
msgstr " -v, --verbose           vysvětlí, co se děje\n"

#: sys-utils/mount.c:482
#, c-format
msgid " -w, --rw, --read-write  mount the filesystem read-write (default)\n"
msgstr " -w, --rw, --read-write  připojí souborový systém pro čtení i zápis (výchozí)\n"

#: sys-utils/mount.c:484
#, c-format
msgid " -N, --namespace <ns>    perform mount in another namespace\n"
msgstr " -N, --namespace <jp>    připojí souborový systém v jiném jmenném prostoru\n"

#: sys-utils/mount.c:490
#, fuzzy, c-format
msgid ""
"\n"
"Source:\n"
" -L, --label <label>     synonym for LABEL=<label>\n"
" -U, --uuid <uuid>       synonym for UUID=<uuid>\n"
" LABEL=<label>           specifies device by filesystem label\n"
" UUID=<uuid>             specifies device by filesystem UUID\n"
" PARTLABEL=<label>       specifies device by partition label\n"
" PARTUUID=<uuid>         specifies device by partition UUID\n"
" ID=<id>                 specifies device by udev hardware ID\n"
msgstr ""
"\n"
"Zdroj:\n"
" -L, --label <jmenovka>  synonymum pro LABEL=<jmenovka>\n"
" -U, --uuid <UUID>       synonymum pro UUID=<UUID>\n"
" LABEL=<jmenovka>        určí zařízení podle jmenovky souborového systému\n"
" UUID=<UUID>             určí zařízení podle UUID souborového systému\n"
" PARTLABEL=<jmenovka>    určí zařízení podle jmenovky oddílu\n"
" PARTUUID=<uuid>         určí zařízení podle UUID oddílu\n"

#: sys-utils/mount.c:500
#, c-format
msgid ""
" <device>                specifies device by path\n"
" <directory>             mountpoint for bind mounts (see --bind/rbind)\n"
" <file>                  regular file for loopdev setup\n"
msgstr ""
" <zařízení>              určí zařízení podle cesty\n"
" <adresář>               bod připojení pro vázaná připojení\n"
"                         (vizte --bind/rbind)\n"
" <soubor>                běžný soubor pro sestavení loop zařízení\n"

#: sys-utils/mount.c:505
#, c-format
msgid ""
"\n"
"Operations:\n"
" -B, --bind              mount a subtree somewhere else (same as -o bind)\n"
" -M, --move              move a subtree to some other place\n"
" -R, --rbind             mount a subtree and all submounts somewhere else\n"
msgstr ""
"\n"
"Operace:\n"
" -B, --bind              připojí podstrom někam jinam (stejné jako -o bind)\n"
" -M, --move              přesune podstrom na jiné místo\n"
" -R, --rbind             připojí podstrom a všechna podřízená připojení jinam\n"

#: sys-utils/mount.c:510
#, c-format
msgid ""
" --make-shared           mark a subtree as shared\n"
" --make-slave            mark a subtree as slave\n"
" --make-private          mark a subtree as private\n"
" --make-unbindable       mark a subtree as unbindable\n"
msgstr ""
" --make-shared           označí podstrom za sdílený\n"
" --make-slave            označí podstrom za podřízený\n"
" --make-private          označí podstrom za soukromý\n"
" --make-unbindable       označí podstrom za nevázatelný\n"

#: sys-utils/mount.c:515
#, c-format
msgid ""
" --make-rshared          recursively mark a whole subtree as shared\n"
" --make-rslave           recursively mark a whole subtree as slave\n"
" --make-rprivate         recursively mark a whole subtree as private\n"
" --make-runbindable      recursively mark a whole subtree as unbindable\n"
msgstr ""
" --make-rshared          rekurzivně označí celý podstrom za sdílený\n"
" --make-rslave           rekurzivně označí celý podstrom za podřízený\n"
" --make-rprivate         rekurzivně označí celý podstrom za soukromý\n"
" --make-runbindable      rekurzivně označí celý podstrom za nevázatelný\n"

#: sys-utils/mount.c:666 sys-utils/umount.c:498
msgid "libmount context allocation failed"
msgstr "alokace kontextu libmount se nezdařila"

#: sys-utils/mount.c:728 sys-utils/umount.c:551
msgid "failed to set options pattern"
msgstr "nepodařilo se nastavit vzorek voleb"

#: sys-utils/mount.c:775 sys-utils/umount.c:568
#, c-format
msgid "failed to set target namespace to %s"
msgstr "nastavení cílového jmenného prostoru na %s selhalo"

#: sys-utils/mount.c:941
msgid "source specified more than once"
msgstr "zdroj zadán více než jednou"

#: sys-utils/mountpoint.c:119
#, c-format
msgid ""
" %1$s [-qd] /path/to/directory\n"
" %1$s -x /dev/device\n"
msgstr ""
" %1$s [-qd] /CESTA/K/ADRESÁŘI\n"
" %1$s -x /dev/ZAŘÍZENÍ\n"

#: sys-utils/mountpoint.c:123
msgid "Check whether a directory or file is a mountpoint.\n"
msgstr "Zjistí, jestli adresář nebo soubor je bodem připojení.\n"

#: sys-utils/mountpoint.c:126
msgid ""
" -q, --quiet        quiet mode - don't print anything\n"
"     --nofollow     do not follow symlink\n"
" -d, --fs-devno     print maj:min device number of the filesystem\n"
" -x, --devno        print maj:min device number of the block device\n"
msgstr ""
" -q, --quiet        tichý režim – nic nevypíše\n"
"     --nofollow     nenásleduje symbolické odkazy\n"
" -d, --fs-devno     vypíše hlavní:vedlejší číslo zařízení systému souborů\n"
" -x, --devno        vypíše hlavní:vedlejší číslo blokového zařízení\n"

#: sys-utils/mountpoint.c:207
#, c-format
msgid "%s is not a mountpoint\n"
msgstr "%s není přípojným bodem\n"

#: sys-utils/mountpoint.c:213
#, c-format
msgid "%s is a mountpoint\n"
msgstr "%s je přípojným bodem\n"

#: sys-utils/nsenter.c:74 sys-utils/setarch.c:99 sys-utils/unshare.c:305
#, c-format
msgid " %s [options] [<program> [<argument>...]]\n"
msgstr " %s [přepínače] <program> [<argument>…]\n"

#: sys-utils/nsenter.c:78
msgid "Run a program with namespaces of other processes.\n"
msgstr "Spustí program se jmennými prostory jiných procesů.\n"

#: sys-utils/nsenter.c:81
msgid " -a, --all              enter all namespaces\n"
msgstr " -a, --all              vstoupí do všech jmenných prostorů\n"

#: sys-utils/nsenter.c:82
msgid " -t, --target <pid>     target process to get namespaces from\n"
msgstr " -t, --target <PID>     proces, ze kterého se má jmenný prostor získat\n"

#: sys-utils/nsenter.c:83
msgid " -m, --mount[=<file>]   enter mount namespace\n"
msgstr " -m, --mount[=<soubor>] vstoupí do jmenného prostoru přípojných bodů\n"

#: sys-utils/nsenter.c:84
msgid " -u, --uts[=<file>]     enter UTS namespace (hostname etc)\n"
msgstr ""
" -u, --uts[=<soubor>]   vstoupí do jmenného prostoru UTS (název\n"
"                        stroje atd.)\n"

#: sys-utils/nsenter.c:85
msgid " -i, --ipc[=<file>]     enter System V IPC namespace\n"
msgstr " -i, --ipc[=<soubor>]   vstoupí do jmenného prostoru System V IPC\n"

#: sys-utils/nsenter.c:86
msgid " -n, --net[=<file>]     enter network namespace\n"
msgstr " -n, --net[=<soubor>]   vstoupí do jmenného prostoru sítí\n"

#: sys-utils/nsenter.c:87
msgid " -p, --pid[=<file>]     enter pid namespace\n"
msgstr " -p, --pid[=<soubor>]   vstoupí do jmenného prostoru čísel procesů\n"

#: sys-utils/nsenter.c:88
msgid " -C, --cgroup[=<file>]  enter cgroup namespace\n"
msgstr ""
" -C, --cgroup[=<soubor>]\n"
"                        vstoupí do jmenného prostoru kontrolních skupin\n"

#: sys-utils/nsenter.c:89
msgid " -U, --user[=<file>]    enter user namespace\n"
msgstr " -U, --user[=<soubor>]  vstoupí do jmenného prostoru uživatelů\n"

#: sys-utils/nsenter.c:90
#, fuzzy
msgid " -T, --time[=<file>]    enter time namespace\n"
msgstr " -p, --pid[=<soubor>]   vstoupí do jmenného prostoru čísel procesů\n"

#: sys-utils/nsenter.c:91
msgid " -S, --setuid <uid>     set uid in entered namespace\n"
msgstr " -S, --setuid <uid>     nastaví UID ve vstoupeném jmenném prostoru\n"

#: sys-utils/nsenter.c:92
msgid " -G, --setgid <gid>     set gid in entered namespace\n"
msgstr " -G, --setgid <gid>     nastaví GID ve vstoupeném jmenném prostoru\n"

#: sys-utils/nsenter.c:93
msgid "     --preserve-credentials do not touch uids or gids\n"
msgstr "     --preserve-credentials nesahá na čísla UID a GID\n"

#: sys-utils/nsenter.c:94
msgid " -r, --root[=<dir>]     set the root directory\n"
msgstr " -r, --root[=<adresář>] nastaví kořenový adresář\n"

#: sys-utils/nsenter.c:95
msgid " -w, --wd[=<dir>]       set the working directory\n"
msgstr " -w, --wd[=<adresář>]   nastaví pracovní adresář\n"

#: sys-utils/nsenter.c:96
msgid " -F, --no-fork          do not fork before exec'ing <program>\n"
msgstr " -F, --no-fork          před spuštěním <programu> nevytvoří potomka\n"

#: sys-utils/nsenter.c:98
msgid " -Z, --follow-context   set SELinux context according to --target PID\n"
msgstr " -Z, --follow-context   nastaví selinuxový kontext podle --target PID\n"

#: sys-utils/nsenter.c:123
#, c-format
msgid "neither filename nor target pid supplied for %s"
msgstr "ani název souboru ani PID cíle nebyly pro %s zadány"

#: sys-utils/nsenter.c:313 sys-utils/unshare.c:473 sys-utils/unshare.c:510
msgid "failed to parse uid"
msgstr "UID se nezdařilo rozebrat"

#: sys-utils/nsenter.c:317 sys-utils/unshare.c:477 sys-utils/unshare.c:514
msgid "failed to parse gid"
msgstr "GID se nezdařilo rozebrat"

#: sys-utils/nsenter.c:357
msgid "no target PID specified for --follow-context"
msgstr "neuveden žádný cílový PID pro --follow-context"

#: sys-utils/nsenter.c:359
#, c-format
msgid "failed to get %d SELinux context"
msgstr "získat selinuxový kontext %d se nepodařilo"

#: sys-utils/nsenter.c:362
#, c-format
msgid "failed to set exec context to '%s'"
msgstr "selhalo nastavení kontextu spouštění na „%s“"

#: sys-utils/nsenter.c:369
msgid "no target PID specified for --all"
msgstr "neuveden žádný cílový PID pro --all"

#: sys-utils/nsenter.c:433
#, c-format
msgid "reassociate to namespace '%s' failed"
msgstr "opakované přidružení ke jmennému prostoru „%s“ selhalo"

#: sys-utils/nsenter.c:449
msgid "cannot open current working directory"
msgstr "současný pracovní adresář nelze otevřít"

#: sys-utils/nsenter.c:456
msgid "change directory by root file descriptor failed"
msgstr "nepodařilo se změnit adresář pomocí deskriptoru kořenového souboru"

#: sys-utils/nsenter.c:459
msgid "chroot failed"
msgstr "volání chroot selhalo"

#: sys-utils/nsenter.c:469
msgid "change directory by working directory file descriptor failed"
msgstr "nepodařilo se změnit adresář pomocí deskriptoru pracovního adresáře"

#: sys-utils/nsenter.c:480 sys-utils/setpriv.c:1031 sys-utils/setpriv.c:1038
#: sys-utils/unshare.c:661
msgid "setgroups failed"
msgstr "volání setgroups selhalo"

#: sys-utils/pivot_root.c:34
#, c-format
msgid " %s [options] new_root put_old\n"
msgstr " %s [přepínače] <nový_kořen> <odložit_starý>\n"

#: sys-utils/pivot_root.c:38
msgid "Change the root filesystem.\n"
msgstr "Změní kořenový souborový systém.\n"

#: sys-utils/pivot_root.c:75
#, c-format
msgid "failed to change root from `%s' to `%s'"
msgstr "výměna kořenu z „%s“ na „%s“ selhala"

#: sys-utils/prlimit.c:75
msgid "address space limit"
msgstr "omezení adresního prostoru"

#: sys-utils/prlimit.c:76
msgid "max core file size"
msgstr "maximální velikost souboru s výpisem paměti"

#: sys-utils/prlimit.c:77
msgid "CPU time"
msgstr "procesorový čas"

#: sys-utils/prlimit.c:77
msgid "seconds"
msgstr "sekundy"

#: sys-utils/prlimit.c:78
msgid "max data size"
msgstr "maximální velikost dat"

#: sys-utils/prlimit.c:79
msgid "max file size"
msgstr "maximální velikost souboru"

#: sys-utils/prlimit.c:80
msgid "max number of file locks held"
msgstr "maximální počet zámků na souborech"

#: sys-utils/prlimit.c:80
msgid "locks"
msgstr "zámky"

#: sys-utils/prlimit.c:81
msgid "max locked-in-memory address space"
msgstr "maximální množství uzamčené paměti"

#: sys-utils/prlimit.c:82
msgid "max bytes in POSIX mqueues"
msgstr "maximální počet bajtů v posixových frontách zpráv"

#: sys-utils/prlimit.c:83
msgid "max nice prio allowed to raise"
msgstr "maximální priorita nice, kterou lze zvýšit"

#: sys-utils/prlimit.c:84
msgid "max number of open files"
msgstr "maximální počet otevřených souborů"

#: sys-utils/prlimit.c:84
msgid "files"
msgstr "soubory"

#: sys-utils/prlimit.c:85
msgid "max number of processes"
msgstr "maximální počet procesů"

#: sys-utils/prlimit.c:85
msgid "processes"
msgstr "procesy"

#: sys-utils/prlimit.c:86
msgid "max resident set size"
msgstr "maximální velikost rezidentní paměti"

#: sys-utils/prlimit.c:87
msgid "max real-time priority"
msgstr "maximální priorita reálného času"

#: sys-utils/prlimit.c:88
msgid "timeout for real-time tasks"
msgstr "časový limit pro úlohy reálného času"

#: sys-utils/prlimit.c:88
msgid "microsecs"
msgstr "mikrosekundy"

#: sys-utils/prlimit.c:89
msgid "max number of pending signals"
msgstr "maximální počet čekajících signálů"

#: sys-utils/prlimit.c:89
msgid "signals"
msgstr "signály"

#: sys-utils/prlimit.c:90
msgid "max stack size"
msgstr "maximální velikost zásobníku"

#: sys-utils/prlimit.c:123
msgid "resource name"
msgstr "název zdroje"

#: sys-utils/prlimit.c:124
msgid "resource description"
msgstr "popis zdroje"

#: sys-utils/prlimit.c:125
msgid "soft limit"
msgstr "měkké omezení"

#: sys-utils/prlimit.c:126
msgid "hard limit (ceiling)"
msgstr "tvrdé omezení (zastropování)"

#: sys-utils/prlimit.c:127
msgid "units"
msgstr "jednotky"

#: sys-utils/prlimit.c:162
#, c-format
msgid " %s [options] [-p PID]\n"
msgstr " %s [přepínače] [-p PID]\n"

#: sys-utils/prlimit.c:164
#, c-format
msgid " %s [options] COMMAND\n"
msgstr " %s [přepínače] PŘÍKAZ\n"

#: sys-utils/prlimit.c:167
msgid "Show or change the resource limits of a process.\n"
msgstr "Ukáže nebo změní omezení zdrojů procesu.\n"

#: sys-utils/prlimit.c:169
msgid ""
"\n"
"General Options:\n"
msgstr ""
"\n"
"Obecné přepínače:\n"

#: sys-utils/prlimit.c:170
msgid ""
" -p, --pid <pid>        process id\n"
" -o, --output <list>    define which output columns to use\n"
"     --noheadings       don't print headings\n"
"     --raw              use the raw output format\n"
"     --verbose          verbose output\n"
msgstr ""
" -p, --pid <PID>        ID procesu\n"
" -o, --output <seznam>  určuje sloupce na výstupu\n"
"     --noheadings       nevypíše záhlaví\n"
"     --raw              výpis v syrovém formátu\n"
"     --verbose          podrobný výstup\n"

#: sys-utils/prlimit.c:178
msgid ""
"\n"
"Resources Options:\n"
msgstr ""
"\n"
"Přepínače zdrojů:\n"

#: sys-utils/prlimit.c:179
msgid ""
" -c, --core             maximum size of core files created\n"
" -d, --data             maximum size of a process's data segment\n"
" -e, --nice             maximum nice priority allowed to raise\n"
" -f, --fsize            maximum size of files written by the process\n"
" -i, --sigpending       maximum number of pending signals\n"
" -l, --memlock          maximum size a process may lock into memory\n"
" -m, --rss              maximum resident set size\n"
" -n, --nofile           maximum number of open files\n"
" -q, --msgqueue         maximum bytes in POSIX message queues\n"
" -r, --rtprio           maximum real-time scheduling priority\n"
" -s, --stack            maximum stack size\n"
" -t, --cpu              maximum amount of CPU time in seconds\n"
" -u, --nproc            maximum number of user processes\n"
" -v, --as               size of virtual memory\n"
" -x, --locks            maximum number of file locks\n"
" -y, --rttime           CPU time in microseconds a process scheduled\n"
"                        under real-time scheduling\n"
msgstr ""
" -c, --core             maximální velikost vytvářených souborů s výpisem paměti\n"
" -d, --data             maximální velikost datového segmentu procesu\n"
" -e, --nice             maximální priorita nice, kterou je dovoleno zvýšit\n"
" -f, --fsize            maximální velikost souborů zapsatelných procesem\n"
" -i, --sigpending       maximální počet čekajících signálů\n"
" -l, --memlock          maximální velikost paměti, kterou může proces zamknout\n"
" -m, --rss              maximální velikost rezidentní paměti\n"
" -n, --nofile           maximální počet otevřených souborů\n"
" -q, --msgqueue         maximální počet bajtů v posixových frontách zpráv\n"
" -r, --rtprio           maximální plánovací priorita reálného času\n"
" -s, --stack            maximální velikost zásobníku\n"
" -t, --cpu              maximální množství procesorového času v sekundách\n"
" -u, --nproc            maximální počet procesů uživatele\n"
" -v, --as               velikost virtuální paměti\n"
" -x, --locks            maximální počet souborových zámků\n"
" -y, --rttime           procesorový čas v mikrosekundách procesu plánovaného\n"
"                        plánovačem reálného času\n"

#: sys-utils/prlimit.c:243 sys-utils/prlimit.c:249 sys-utils/prlimit.c:365
#: sys-utils/prlimit.c:370
msgid "unlimited"
msgstr "neomezeno"

#: sys-utils/prlimit.c:331
#, c-format
msgid "failed to get old %s limit"
msgstr "nepodařilo se získat staré omezení na %s"

#: sys-utils/prlimit.c:355
#, c-format
msgid "the soft limit %s cannot exceed the hard limit"
msgstr "měkké omezení %s nemůže překročit tvrdé omezení"

#: sys-utils/prlimit.c:362
#, c-format
msgid "New %s limit for pid %d: "
msgstr "Nové omezení %s pro PID %d: "

#: sys-utils/prlimit.c:377
#, c-format
msgid "failed to set the %s resource limit"
msgstr "nepodařilo se nastavit omezení zdroje na %s"

#: sys-utils/prlimit.c:378
#, c-format
msgid "failed to get the %s resource limit"
msgstr "nepodařilo se zjistit omezení zdroje na %s"

#: sys-utils/prlimit.c:457
#, c-format
msgid "failed to parse %s limit"
msgstr "nezdařilo se rozebrat omezení na %s"

#: sys-utils/prlimit.c:586
msgid "option --pid may be specified only once"
msgstr "přepínač --pid lze zadat jen jednou"

#: sys-utils/prlimit.c:615
msgid "options --pid and COMMAND are mutually exclusive"
msgstr "přepínač --pid a PŘÍKAZ se vzájemně vylučují"

#: sys-utils/readprofile.c:107
msgid "Display kernel profiling information.\n"
msgstr "Zobrazí údaje z profilování jádra.\n"

#: sys-utils/readprofile.c:111
#, c-format
msgid " -m, --mapfile <mapfile>   (defaults: \"%s\" and\n"
msgstr " -m, --mapfile <mapový_soubor>  (výchozí: „%s“ a\n"

#: sys-utils/readprofile.c:113
#, c-format
msgid "                                      \"%s\")\n"
msgstr "                                      „%s“)\n"

#: sys-utils/readprofile.c:115
#, c-format
msgid " -p, --profile <pro-file>  (default:  \"%s\")\n"
msgstr " -p, --profile <soubor_profilu>  (výchozí: „%s“)\n"

#: sys-utils/readprofile.c:116
msgid " -M, --multiplier <mult>   set the profiling multiplier to <mult>\n"
msgstr " -M, --multiplier <činitel>  nastaví <činitel> profilování\n"

#: sys-utils/readprofile.c:117
msgid " -i, --info                print only info about the sampling step\n"
msgstr " -i, --info                vypíše údaje pouze o vzorkujícím kroku\n"

#: sys-utils/readprofile.c:118
msgid " -v, --verbose             print verbose data\n"
msgstr " -v, --verbose             vypíše podrobné údaje\n"

#: sys-utils/readprofile.c:119
msgid " -a, --all                 print all symbols, even if count is 0\n"
msgstr ""
" -a, --all                 vypíše všechny symboly, i když jejich\n"
"                           počítadlo je 0\n"

#: sys-utils/readprofile.c:120
msgid " -b, --histbin             print individual histogram-bin counts\n"
msgstr " -b, --histbin             vypíše jednotlivá počítadla histogramu programu\n"

#: sys-utils/readprofile.c:121
msgid " -s, --counters            print individual counters within functions\n"
msgstr " -s, --counters            vypíše jednotlivá počítadla uvnitř funkcí\n"

#: sys-utils/readprofile.c:122
msgid " -r, --reset               reset all the counters (root only)\n"
msgstr " -r, --reset               zresetuje všechny počítadla (pouze superuživatel)\n"

#: sys-utils/readprofile.c:123
msgid " -n, --no-auto             disable byte order auto-detection\n"
msgstr " -n, --no-auto             vypne automatické rozpoznávání pořadí bajtů\n"

#: sys-utils/readprofile.c:239
#, c-format
msgid "error writing %s"
msgstr "chyba při zápisu %s"

#: sys-utils/readprofile.c:250
msgid "input file is empty"
msgstr "vstupní soubor je prázdný"

#: sys-utils/readprofile.c:272
msgid "Assuming reversed byte order. Use -n to force native byte order."
msgstr "Předpokládá se opačné pořadí bajtů. Systémové pořadí lze vynutit pomocí -n."

#: sys-utils/readprofile.c:287
#, c-format
msgid "Sampling_step: %u\n"
msgstr "Profilovací_krok: %u\n"

#: sys-utils/readprofile.c:303 sys-utils/readprofile.c:324
#, c-format
msgid "%s(%i): wrong map line"
msgstr "%s(%i): chybný řádek v mapě"

#: sys-utils/readprofile.c:314
#, c-format
msgid "can't find \"_stext\" in %s"
msgstr "„_stext“ nelze v %s nalézt"

#: sys-utils/readprofile.c:347
msgid "profile address out of range. Wrong map file?"
msgstr "adresa profilu je mimo rozsah. Chybný mapovací soubor?"

#: sys-utils/readprofile.c:405
msgid "total"
msgstr "celkem"

#: sys-utils/renice.c:52
msgid "process ID"
msgstr "ID procesu"

#: sys-utils/renice.c:53
msgid "process group ID"
msgstr "ID skupiny procesů"

#: sys-utils/renice.c:62
#, c-format
msgid ""
" %1$s [-n] <priority> [-p|--pid] <pid>...\n"
" %1$s [-n] <priority>  -g|--pgrp <pgid>...\n"
" %1$s [-n] <priority>  -u|--user <user>...\n"
msgstr ""
" %1$s [-n] priorita [-p|--pid] <PID>…\n"
" %1$s [-n] priorita  -g|--pgid <PGID>…\n"
" %1$s [-n] priorita  -u|--user <uživatel>…\n"

#: sys-utils/renice.c:68
msgid "Alter the priority of running processes.\n"
msgstr "Změní prioritu běžících procesů.\n"

#: sys-utils/renice.c:71
msgid " -n, --priority <num>   specify the nice value\n"
msgstr " -n, --priority <číslo> určuje hodnotu nice\n"

#: sys-utils/renice.c:72
msgid " -p, --pid              interpret arguments as process ID (default)\n"
msgstr " -p, --pid              interpretuje argumenty jako ID procesu (výchozí)\n"

#: sys-utils/renice.c:73
msgid " -g, --pgrp             interpret arguments as process group ID\n"
msgstr " -g, --pgrp             interpretuje argumenty jako ID skupiny procesů\n"

#: sys-utils/renice.c:74
msgid " -u, --user             interpret arguments as username or user ID\n"
msgstr " -u, --user             interpretuje argumenty jako jméno nebo ID uživatele\n"

#: sys-utils/renice.c:86
#, c-format
msgid "failed to get priority for %d (%s)"
msgstr "selhalo zjištění priority %d (%s)"

#: sys-utils/renice.c:99
#, c-format
msgid "failed to set priority for %d (%s)"
msgstr "selhalo nastavení priority %d (%s)"

#: sys-utils/renice.c:104
#, c-format
msgid "%d (%s) old priority %d, new priority %d\n"
msgstr "%d (%s): původní priorita %d, nová priorita %d\n"

#: sys-utils/renice.c:150
#, c-format
msgid "invalid priority '%s'"
msgstr "neplatná priorita „%s“"

#: sys-utils/renice.c:177
#, c-format
msgid "unknown user %s"
msgstr "neznámý uživatel: %s"

#. TRANSLATORS: The first %s is one of the above
#. * three ID names. Read: "bad value for %s: %s"
#: sys-utils/renice.c:186
#, c-format
msgid "bad %s value: %s"
msgstr "chybná hodnota %s: %s"

#: sys-utils/rfkill.c:128
msgid "kernel device name"
msgstr "jaderný název zařízení"

#: sys-utils/rfkill.c:129
msgid "device identifier value"
msgstr "hodnota identifikátoru zařízení"

#: sys-utils/rfkill.c:130
msgid "device type name that can be used as identifier"
msgstr "název druhu zařízení, který lze použít jako identifikátor"

#: sys-utils/rfkill.c:131
msgid "device type description"
msgstr "popis druhu zařízení"

#: sys-utils/rfkill.c:132
msgid "status of software block"
msgstr "stav softwarového vypínače"

#: sys-utils/rfkill.c:133
msgid "status of hardware block"
msgstr "stav hardwarového vypínače"

#: sys-utils/rfkill.c:197
#, c-format
msgid "cannot set non-blocking %s"
msgstr "%s nelze přepnout do neblokující polohy"

#: sys-utils/rfkill.c:218
#, c-format
msgid "wrong size of rfkill event: %zu < %d"
msgstr "chybná velikost události rfkill: %zu < %d"

#: sys-utils/rfkill.c:248
#, c-format
msgid "failed to poll %s"
msgstr "dotazování %s selhalo"

#: sys-utils/rfkill.c:315
msgid "invalid identifier"
msgstr "neplatný identifikátor"

#: sys-utils/rfkill.c:395 sys-utils/rfkill.c:398
msgid "blocked"
msgstr "zakázáno"

#: sys-utils/rfkill.c:395 sys-utils/rfkill.c:398
msgid "unblocked"
msgstr "povoleno"

#: sys-utils/rfkill.c:417 sys-utils/rfkill.c:489 sys-utils/rfkill.c:533
#, c-format
msgid "invalid identifier: %s"
msgstr "neplatný identifikátor: %s"

#: sys-utils/rfkill.c:575
#, c-format
msgid " %s [options] command [identifier ...]\n"
msgstr " %s [přepínače] příkaz [identifikátor…]\n"

#: sys-utils/rfkill.c:578
msgid "Tool for enabling and disabling wireless devices.\n"
msgstr "Nástroj pro povolení a zakázání bezdrátového zařízení.\n"

#. TRANSLATORS: command names should not be translated, explaining
#. them as additional field after identifier is fine, for example
#. *
#. list   [identifier]   (lista [tarkenne])
#.
#: sys-utils/rfkill.c:602
msgid " help\n"
msgstr " help (nápověda)\n"

#: sys-utils/rfkill.c:603
msgid " event\n"
msgstr " event (událost)\n"

#: sys-utils/rfkill.c:604
msgid " list   [identifier]\n"
msgstr " list [identifikátor] (seznam)\n"

#: sys-utils/rfkill.c:605
msgid " block   identifier\n"
msgstr " block   identifikátor (zakázat)\n"

#: sys-utils/rfkill.c:606
msgid " unblock identifier\n"
msgstr " unblock identifikátor (povolit)\n"

#: sys-utils/rtcwake.c:102
msgid "Enter a system sleep state until a specified wakeup time.\n"
msgstr "Převede systém do spánku a probudí se v určený čas.\n"

#: sys-utils/rtcwake.c:105
msgid " -a, --auto               reads the clock mode from adjust file (default)\n"
msgstr ""
" -a, --auto               získá režim hodin ze souboru se systematickým\n"
"                          posunem (výchozí)\n"

#: sys-utils/rtcwake.c:107
#, c-format
msgid ""
" -A, --adjfile <file>     specifies the path to the adjust file\n"
"                            the default is %s\n"
msgstr ""
" -A, --adjfile <soubor>\n"
"                          určuje cestu k souboru se systematickým posunem\n"
"                          (výchozí je %s)\n"

#: sys-utils/rtcwake.c:109
msgid "     --date <timestamp>   date time of timestamp to wake\n"
msgstr "     --date <čas>         čas probuzení\n"

#: sys-utils/rtcwake.c:110
msgid " -d, --device <device>    select rtc device (rtc0|rtc1|...)\n"
msgstr " -d, --device <zařízení>  vybere RTC zařízení (rtc0|rtc1|…)\n"

#: sys-utils/rtcwake.c:111
msgid " -n, --dry-run            does everything, but suspend\n"
msgstr " -n, --dry-run            provede vše až na uspání\n"

#: sys-utils/rtcwake.c:112
msgid " -l, --local              RTC uses local timezone\n"
msgstr " -l, --local              RTC používá místní časovou zónu\n"

#: sys-utils/rtcwake.c:113
msgid "     --list-modes         list available modes\n"
msgstr "     --list-modes         vypíše dostupné režimy\n"

#: sys-utils/rtcwake.c:114
msgid " -m, --mode <mode>        standby|mem|... sleep mode\n"
msgstr " -m, --mode <režim>       režim spánku (standby|mem|…) [pohotovost|paměť|…]\n"

#: sys-utils/rtcwake.c:115
msgid " -s, --seconds <seconds>  seconds to sleep\n"
msgstr " -s, --seconds <sekundy>  kolik sekund bude spát\n"

#: sys-utils/rtcwake.c:116
msgid " -t, --time <time_t>      time to wake\n"
msgstr " -t, --time <time_t>      čas probuzení\n"

#: sys-utils/rtcwake.c:117
msgid " -u, --utc                RTC uses UTC\n"
msgstr " -u, --utc                RTC běží v UTC\n"

#: sys-utils/rtcwake.c:118
msgid " -v, --verbose            verbose messages\n"
msgstr " -v, --verbose            podrobné zprávy\n"

#: sys-utils/rtcwake.c:168
msgid "read rtc time failed"
msgstr "přečtení hodin RTC selhalo"

#: sys-utils/rtcwake.c:174
msgid "read system time failed"
msgstr "přečtení systémových hodin selhalo"

#: sys-utils/rtcwake.c:190
msgid "convert rtc time failed"
msgstr "převod času RTC selhal"

#: sys-utils/rtcwake.c:240
msgid "set rtc wake alarm failed"
msgstr "nastavení budíku RTC pro probuzení selhalo"

#: sys-utils/rtcwake.c:280
msgid "discarding stdin"
msgstr "zahazuje se standardní vstup"

#: sys-utils/rtcwake.c:331
#, c-format
msgid "unexpected third line in: %s: %s"
msgstr "neočekávaný třetí řádek v %s: %s"

#: sys-utils/rtcwake.c:345 sys-utils/rtcwake.c:673
msgid "read rtc alarm failed"
msgstr "přečtení budíku RTC selhalo"

#: sys-utils/rtcwake.c:350
#, c-format
msgid "alarm: off\n"
msgstr "budík: vypnut\n"

#: sys-utils/rtcwake.c:363
msgid "convert time failed"
msgstr "převod času selhal"

#: sys-utils/rtcwake.c:369
#, c-format
msgid "alarm: on  %s"
msgstr "budík: zapnut  %s"

#: sys-utils/rtcwake.c:402
#, c-format
msgid "%s: unable to find device"
msgstr "%s: zařízení nelze nalézt"

#: sys-utils/rtcwake.c:413
#, c-format
msgid "could not read: %s"
msgstr "nebylo možné přečíst: %s"

#: sys-utils/rtcwake.c:494
#, c-format
msgid "unrecognized suspend state '%s'"
msgstr "nerozpoznaný režim spánku „%s“"

#: sys-utils/rtcwake.c:502
msgid "invalid seconds argument"
msgstr "neplatný argument sekund"

#: sys-utils/rtcwake.c:506
msgid "invalid time argument"
msgstr "neplatný argument času"

#: sys-utils/rtcwake.c:533
#, c-format
msgid "%s: assuming RTC uses UTC ...\n"
msgstr "%s: předpokládám, že hodiny reálného času běží v UTC…\n"

#: sys-utils/rtcwake.c:538
msgid "Using UTC time.\n"
msgstr "Používám UTC čas.\n"

#: sys-utils/rtcwake.c:539
msgid "Using local time.\n"
msgstr "Používám místní čas.\n"

#: sys-utils/rtcwake.c:542
msgid "must provide wake time (see --seconds, --time and --date options)"
msgstr "je nezbytné uvést čas probuzení (vizte přepínače --seconds, --time a --date)"

#: sys-utils/rtcwake.c:548
#, c-format
msgid "%s not enabled for wakeup events"
msgstr "%s nemá dovoleno reagovat na probouzecí události"

#: sys-utils/rtcwake.c:555
#, c-format
msgid "alarm %ld, sys_time %ld, rtc_time %ld, seconds %u\n"
msgstr "budík %ld, systémový_čas %ld, reálný_čas %ld, sekund %u\n"

#: sys-utils/rtcwake.c:565
#, c-format
msgid "time doesn't go backward to %s"
msgstr "hodiny nedojdou pozpátku k %s"

#: sys-utils/rtcwake.c:578
#, c-format
msgid "%s: wakeup using %s at %s"
msgstr "%s: probuzení za pomoci %s v %s"

#: sys-utils/rtcwake.c:584
#, c-format
msgid "%s: wakeup from \"%s\" using %s at %s"
msgstr "%s: probuzení ze stavu „%s“ za pomoci %s v %s"

#: sys-utils/rtcwake.c:594
#, c-format
msgid "suspend mode: no; leaving\n"
msgstr "režim spánku: no (žádný); končí se\n"

#: sys-utils/rtcwake.c:617
#, c-format
msgid "suspend mode: off; executing %s\n"
msgstr "režim spánku: off (vypnuto); spouští se %s\n"

#: sys-utils/rtcwake.c:626
msgid "failed to find shutdown command"
msgstr "program shutdown nebylo možné nalézt"

#: sys-utils/rtcwake.c:636
#, c-format
msgid "suspend mode: on; reading rtc\n"
msgstr "režim spánky: on (zapnuto); čte se RTC\n"

#: sys-utils/rtcwake.c:641
msgid "rtc read failed"
msgstr "čtení hodin reálného času selhalo"

#: sys-utils/rtcwake.c:653
#, c-format
msgid "suspend mode: disable; disabling alarm\n"
msgstr "režim spánku: disable (zakázáno); budík se vypíná\n"

#: sys-utils/rtcwake.c:657
#, c-format
msgid "suspend mode: show; printing alarm info\n"
msgstr "režim spánku: show; zobrazí se údaje o budíku\n"

#: sys-utils/rtcwake.c:664
#, c-format
msgid "suspend mode: %s; suspending system\n"
msgstr "reži spánku: %s; systém bude uspán\n"

#: sys-utils/rtcwake.c:678
msgid "disable rtc alarm interrupt failed"
msgstr "zakázání přerušení budíku hodin reálného času selhalo"

#: sys-utils/setarch.c:48
#, c-format
msgid "Switching on %s.\n"
msgstr "Zapíná se %s.\n"

#: sys-utils/setarch.c:97
#, c-format
msgid " %s [<arch>] [options] [<program> [<argument>...]]\n"
msgstr " %s [<architektura>] [přepínače] [<program> [<argument>…]]\n"

#: sys-utils/setarch.c:102
msgid "Change the reported architecture and set personality flags.\n"
msgstr "Změní hlášenou architekturu a nastaví její charakteristiku.\n"

#: sys-utils/setarch.c:105
msgid " -B, --32bit              turns on ADDR_LIMIT_32BIT\n"
msgstr " -B, --32bit              zapne ADDR_LIMIT_32BIT\n"

#: sys-utils/setarch.c:106
msgid " -F, --fdpic-funcptrs     makes function pointers point to descriptors\n"
msgstr " -F, --fdpic-funcptrs     učiní ukazatele funkcí ukazující na deskriptory\n"

#: sys-utils/setarch.c:107
msgid " -I, --short-inode        turns on SHORT_INODE\n"
msgstr " -I, --short-inode        zapne SHORT_INODE\n"

#: sys-utils/setarch.c:108
msgid " -L, --addr-compat-layout changes the way virtual memory is allocated\n"
msgstr " -L, --addr-compat-layout změní způsob, jakým je virtuální paměť přidělována\n"

#: sys-utils/setarch.c:109
msgid " -R, --addr-no-randomize  disables randomization of the virtual address space\n"
msgstr " -R, --addr-no-randomize  vypne znáhodnění prostoru virtuálních adres\n"

#: sys-utils/setarch.c:110
msgid " -S, --whole-seconds      turns on WHOLE_SECONDS\n"
msgstr " -S, --whole-seconds      zapne WHOLE_SECONDS\n"

#: sys-utils/setarch.c:111
msgid " -T, --sticky-timeouts    turns on STICKY_TIMEOUTS\n"
msgstr " -T, --sticky-timeouts    zapne STICKY_TIMEOUTS\n"

#: sys-utils/setarch.c:112
msgid " -X, --read-implies-exec  turns on READ_IMPLIES_EXEC\n"
msgstr " -X, --read-implies-exec  zapne READ_IMPLIES_EXEC\n"

#: sys-utils/setarch.c:113
msgid " -Z, --mmap-page-zero     turns on MMAP_PAGE_ZERO\n"
msgstr " -Z, --mmap-page-zero     zapne MMAP_PAGE_ZERO\n"

#: sys-utils/setarch.c:114
msgid " -3, --3gb                limits the used address space to a maximum of 3 GB\n"
msgstr " -3, --3gb                omezí použitý adresní prostor hranicí 3 GB\n"

#: sys-utils/setarch.c:115
msgid "     --4gb                ignored (for backward compatibility only)\n"
msgstr "     --4gb                ignorováno (jen pro zpětnou kompatibilitu)\n"

#: sys-utils/setarch.c:116
msgid "     --uname-2.6          turns on UNAME26\n"
msgstr "     --uname-2.6          zapne UNAME26\n"

#: sys-utils/setarch.c:117
msgid " -v, --verbose            say what options are being switched on\n"
msgstr " -v, --verbose            vypisuje, které volby jsou zapínány\n"

#: sys-utils/setarch.c:120
msgid "     --list               list settable architectures, and exit\n"
msgstr "     --list               vypíše seznam možných architektur a skončí\n"

#: sys-utils/setarch.c:293
#, c-format
msgid "Kernel cannot set architecture to %s"
msgstr "Jádro nemůže nastavit architekturu na %s"

#: sys-utils/setarch.c:342
msgid "Not enough arguments"
msgstr "Málo argumentů"

#: sys-utils/setarch.c:410
msgid "unrecognized option '--list'"
msgstr "nerozpoznaný přepínač „--list“"

#: sys-utils/setarch.c:423
msgid "no architecture argument or personality flags specified"
msgstr "nezadán argument s architekturou nebo charakteristikou architektury"

#: sys-utils/setarch.c:435
#, c-format
msgid "%s: Unrecognized architecture"
msgstr " %s: Nerozpoznaná architektura"

# personality – charakteristika architektury
#: sys-utils/setarch.c:453
#, c-format
msgid "failed to set personality to %s"
msgstr "selhalo nastavení charakteristiky architektury na %s"

#: sys-utils/setarch.c:465
#, c-format
msgid "Execute command `%s'.\n"
msgstr "Spouští se příkaz „%s“.\n"

#: sys-utils/setpriv.c:119
#, c-format
msgid " %s [options] <program> [<argument>...]\n"
msgstr " %s [přepínače] <program> [<argument……]\n"

#: sys-utils/setpriv.c:123
msgid "Run a program with different privilege settings.\n"
msgstr "Spustí program s jiným nastavením oprávnění.\n"

#: sys-utils/setpriv.c:126
msgid " -d, --dump                  show current state (and do not exec)\n"
msgstr " -d, --dump                  zobrazí současný stav (a nic nespustí)\n"

#: sys-utils/setpriv.c:127
msgid " --nnp, --no-new-privs       disallow granting new privileges\n"
msgstr " --nnp, --no-new-privs       zakáže přidávání oprávnění\n"

#: sys-utils/setpriv.c:128
msgid " --ambient-caps <caps,...>   set ambient capabilities\n"
msgstr ""
" --ambient-caps <kvalifikace,…>\n"
"                             nastaví okolní kvalifikace\n"

#: sys-utils/setpriv.c:129
msgid " --inh-caps <caps,...>       set inheritable capabilities\n"
msgstr " --inh-caps <kvalifikace,…>  nastaví děditelné kvalifikace\n"

#: sys-utils/setpriv.c:130
msgid " --bounding-set <caps>       set capability bounding set\n"
msgstr ""
" --bounding-set <kvalifikace>\n"
"                             nastaví ohraničující množinu\n"

#: sys-utils/setpriv.c:131
msgid " --ruid <uid|user>           set real uid\n"
msgstr " --ruid <UID|uživatel>       nastaví reálné UID\n"

#: sys-utils/setpriv.c:132
msgid " --euid <uid|user>           set effective uid\n"
msgstr " --euid <UID|uživatel>       nastaví efektivní UID\n"

# FIXME user should read group
#: sys-utils/setpriv.c:133
msgid " --rgid <gid|user>           set real gid\n"
msgstr " --rgid <GID|uživatel>       nastaví reálné GID\n"

#: sys-utils/setpriv.c:134
msgid " --egid <gid|group>          set effective gid\n"
msgstr " --egid <GID|skupina>        nastaví efektivní GID\n"

#: sys-utils/setpriv.c:135
msgid " --reuid <uid|user>          set real and effective uid\n"
msgstr " --reuid <UID|uživatel>      nastaví reálné a efektivní UID\n"

#: sys-utils/setpriv.c:136
msgid " --regid <gid|group>         set real and effective gid\n"
msgstr " --regid <GID|skupina>       nastaví reálné a efektivní GID\n"

#: sys-utils/setpriv.c:137
msgid " --clear-groups              clear supplementary groups\n"
msgstr " --clear-groups              odstraní doplňkové skupiny\n"

#: sys-utils/setpriv.c:138
msgid " --keep-groups               keep supplementary groups\n"
msgstr " --keep-groups               ponechá doplňkové skupiny\n"

#: sys-utils/setpriv.c:139
msgid " --init-groups               initialize supplementary groups\n"
msgstr " --init-groups               inicializuje doplňkové skupiny\n"

#: sys-utils/setpriv.c:140
msgid " --groups <group,...>        set supplementary groups by UID or name\n"
msgstr " --groups <skupina,…>        nastaví doplňkové skupiny podle UID nebo jména\n"

#: sys-utils/setpriv.c:141
msgid " --securebits <bits>         set securebits\n"
msgstr " --securebits <bity>         nastaví bezpečnostní bity\n"

#: sys-utils/setpriv.c:142
msgid ""
" --pdeathsig keep|clear|<signame>\n"
"                             set or clear parent death signal\n"
msgstr ""
" --pdeathsig keep|clear|<signame>\n"
"                             nastaví nebo zruší signál při úmrtí rodiče\n"

#: sys-utils/setpriv.c:144
msgid " --selinux-label <label>     set SELinux label\n"
msgstr " --selinux-label <značka>    nastaví selinuxovou značku\n"

#: sys-utils/setpriv.c:145
msgid " --apparmor-profile <pr>     set AppArmor profile\n"
msgstr ""
" --apparmor-profile <profil>\n"
"                             nastaví profil AppArmoru\n"

#: sys-utils/setpriv.c:146
msgid ""
" --reset-env                 clear all environment and initialize\n"
"                               HOME, SHELL, USER, LOGNAME and PATH\n"
msgstr ""
" --reset-env                 clear all environment and initialize\n"
"                               HOME, SHELL, USER, LOGNAME and PATH\n"

#: sys-utils/setpriv.c:152
msgid " This tool can be dangerous.  Read the manpage, and be careful.\n"
msgstr ""
"Tento nástroj může být nebezpečný. Přečtěte si manuálovou stránku a\n"
"buďte opatrní.\n"

#: sys-utils/setpriv.c:170
msgid "invalid capability type"
msgstr "špatný druh kvalifikace"

#: sys-utils/setpriv.c:222 sys-utils/setpriv.c:566
msgid "getting process secure bits failed"
msgstr "nepodařilo se získat bezpečností bity procesu"

#: sys-utils/setpriv.c:226
#, c-format
msgid "Securebits: "
msgstr "Bezpečnostní bity: "

# secure bits
#: sys-utils/setpriv.c:246
#, c-format
msgid "[none]\n"
msgstr "[žádné]\n"

#: sys-utils/setpriv.c:272
#, c-format
msgid "%s: too long"
msgstr "%s: příliš dlouhé"

#: sys-utils/setpriv.c:300
#, c-format
msgid "Supplementary groups: "
msgstr "Doplňkové skupiny: "

# supplementary groups, capabilities, bounding set. Use neutral `nic'
#: sys-utils/setpriv.c:302 sys-utils/setpriv.c:368 sys-utils/setpriv.c:373
#: sys-utils/setpriv.c:379 sys-utils/setpriv.c:385 sys-utils/setpriv.c:392
#, c-format
msgid "[none]"
msgstr "[nic]"

#: sys-utils/setpriv.c:320
msgid "get pdeathsig failed"
msgstr "nepodařilo se získat hodnotu signálu při úmrtí rodiče"

#: sys-utils/setpriv.c:340
#, c-format
msgid "uid: %u\n"
msgstr "UID: %u\n"

#: sys-utils/setpriv.c:341
#, c-format
msgid "euid: %u\n"
msgstr "EUID: %u\n"

#: sys-utils/setpriv.c:344
#, c-format
msgid "suid: %u\n"
msgstr "SUID: %u\n"

#: sys-utils/setpriv.c:346 sys-utils/setpriv.c:459
msgid "getresuid failed"
msgstr "volání getresuid selhalo"

#: sys-utils/setpriv.c:355 sys-utils/setpriv.c:474
msgid "getresgid failed"
msgstr "volání getresgid selhalo"

#: sys-utils/setpriv.c:366
#, c-format
msgid "Effective capabilities: "
msgstr "Efektivní kvalifikace: "

#: sys-utils/setpriv.c:371
#, c-format
msgid "Permitted capabilities: "
msgstr "Povolené kvalifikace: "

#: sys-utils/setpriv.c:377
#, c-format
msgid "Inheritable capabilities: "
msgstr "Děditelné kvalifikace: "

#: sys-utils/setpriv.c:382
#, c-format
msgid "Ambient capabilities: "
msgstr "Okolní kvalifikace: "

#: sys-utils/setpriv.c:387
#, c-format
msgid "[unsupported]"
msgstr "[nepodporováno]"

#: sys-utils/setpriv.c:390
#, c-format
msgid "Capability bounding set: "
msgstr "Množina ohraničující kvalifikace: "

#: sys-utils/setpriv.c:399
msgid "SELinux label"
msgstr "Značka SELinuxu"

#: sys-utils/setpriv.c:402
msgid "AppArmor profile"
msgstr "Profil AppArmoru"

#: sys-utils/setpriv.c:415
#, c-format
msgid "cap %d: libcap-ng is broken"
msgstr "kvalifikace %d: knihovna libcap-ng je rozbitá"

#: sys-utils/setpriv.c:437
msgid "Invalid supplementary group id"
msgstr "Chybné číslo doplňkové skupiny"

#: sys-utils/setpriv.c:447
msgid "failed to get parent death signal"
msgstr "nezdařilo získat hodnotu signálu při úmrtí rodiče"

#: sys-utils/setpriv.c:467
msgid "setresuid failed"
msgstr "volání setresuid selhalo"

#: sys-utils/setpriv.c:482
msgid "setresgid failed"
msgstr "volání setresgid selhalo"

#: sys-utils/setpriv.c:514
msgid "unsupported capability type"
msgstr "nepodporovaný druh kvalifikace"

#: sys-utils/setpriv.c:531
msgid "bad capability string"
msgstr "špatný řetězec s kvalifikacemi"

#: sys-utils/setpriv.c:539
msgid "libcap-ng is too old for \"all\" caps"
msgstr "knihovna libcap-ng je pro kvalifikaci „all“ příliš stará"

#: sys-utils/setpriv.c:551
#, c-format
msgid "unknown capability \"%s\""
msgstr "neznámá kvalifikace „%s"

#: sys-utils/setpriv.c:575
msgid "unrecognized securebit set -- refusing to adjust"
msgstr "neznámá množina bezpečnostních bitů - změna odmítnuta"

#: sys-utils/setpriv.c:579
msgid "bad securebits string"
msgstr "špatný řetězec s bezpečnostními bity"

#: sys-utils/setpriv.c:586
msgid "+all securebits is not allowed"
msgstr "bezpečností bity „+all“ nejsou povoleny"

#: sys-utils/setpriv.c:599
msgid "adjusting keep_caps does not make sense"
msgstr "změna keep_caps nedává smysl"

#: sys-utils/setpriv.c:603
msgid "unrecognized securebit"
msgstr "nerozpoznaný bezpečnostní bit"

#: sys-utils/setpriv.c:623
msgid "SELinux is not running"
msgstr "SELinux neběží"

#: sys-utils/setpriv.c:638
#, c-format
msgid "close failed: %s"
msgstr "uzavření selhalo: %s"

#: sys-utils/setpriv.c:646
msgid "AppArmor is not running"
msgstr "AppArmor neběží"

#: sys-utils/setpriv.c:825
msgid "duplicate --no-new-privs option"
msgstr "násobný přepínač --no-new-privs"

#: sys-utils/setpriv.c:830
msgid "duplicate ruid"
msgstr "násobné efektivní UID"

#: sys-utils/setpriv.c:832
msgid "failed to parse ruid"
msgstr "reální UID se nezdařilo rozebrat"

#: sys-utils/setpriv.c:840
msgid "duplicate euid"
msgstr "násobné efektivní UID"

#: sys-utils/setpriv.c:842
msgid "failed to parse euid"
msgstr "efektivní UID se nepodařilo rozebrat"

#: sys-utils/setpriv.c:846
msgid "duplicate ruid or euid"
msgstr "násobné reálné nebo efektivní UID"

#: sys-utils/setpriv.c:848
msgid "failed to parse reuid"
msgstr "hodnotu reuid se nezdařilo rozebrat"

#: sys-utils/setpriv.c:857
msgid "duplicate rgid"
msgstr "násobné reálné GID"

#: sys-utils/setpriv.c:859
msgid "failed to parse rgid"
msgstr "reálné GID se nezdařilo rozebrat"

#: sys-utils/setpriv.c:863
msgid "duplicate egid"
msgstr "násobné efektivní GID"

#: sys-utils/setpriv.c:865
msgid "failed to parse egid"
msgstr "efektivní GID se nepodařilo rozebrat"

#: sys-utils/setpriv.c:869
msgid "duplicate rgid or egid"
msgstr "násobné reálné nebo efektivní GID"

#: sys-utils/setpriv.c:871
msgid "failed to parse regid"
msgstr "hodnotu regid se nezdařilo rozebrat"

#: sys-utils/setpriv.c:876
msgid "duplicate --clear-groups option"
msgstr "násobný přepínač --clear-groups"

#: sys-utils/setpriv.c:882
msgid "duplicate --keep-groups option"
msgstr "násobný přepínač --keep-groups"

#: sys-utils/setpriv.c:888
msgid "duplicate --init-groups option"
msgstr "násobný přepínač --init-groups"

#: sys-utils/setpriv.c:894
msgid "duplicate --groups option"
msgstr "násobný přepínač --groups"

#: sys-utils/setpriv.c:900
msgid "duplicate --keep-pdeathsig option"
msgstr "násobný přepínač --keep-pdeathsig"

#: sys-utils/setpriv.c:909
msgid "duplicate --inh-caps option"
msgstr "násobný přepínač --inh-caps"

#: sys-utils/setpriv.c:915
msgid "duplicate --ambient-caps option"
msgstr "násobný přepínač --ambient-caps"

#: sys-utils/setpriv.c:921
msgid "duplicate --bounding-set option"
msgstr "násobný přepínače --bounding-set"

#: sys-utils/setpriv.c:927
msgid "duplicate --securebits option"
msgstr "násobný přepínač --securebits"

#: sys-utils/setpriv.c:933
msgid "duplicate --selinux-label option"
msgstr "násobný přepínač --selinux-label"

#: sys-utils/setpriv.c:939
msgid "duplicate --apparmor-profile option"
msgstr "násobný přepínač --apparmor-profile"

#: sys-utils/setpriv.c:958
msgid "--dump is incompatible with all other options"
msgstr "přepínač --dump není slučitelný jakýmkoliv jiným přepínačem"

#: sys-utils/setpriv.c:966
msgid "--list-caps must be specified alone"
msgstr "přepínač --list-caps musí být zadán samostatně"

#: sys-utils/setpriv.c:972
msgid "No program specified"
msgstr "Nezadán žádný program"

#: sys-utils/setpriv.c:978
msgid "--[re]gid requires --keep-groups, --clear-groups, --init-groups, or --groups"
msgstr "přepínač --[re]gid vyžaduje --keep-groups, --clear-groups, --init-groups nebo --groups"

#: sys-utils/setpriv.c:982
msgid "--init-groups requires --ruid or --reuid"
msgstr "přepínač --init-groups vyžaduje --ruid nebo --reuid"

#: sys-utils/setpriv.c:986
#, c-format
msgid "uid %ld not found, --init-groups requires an user that can be found on the system"
msgstr "UID %ld nenalezeno, --init-groups vyžaduje uživatele, kterého lze v systému najít"

#: sys-utils/setpriv.c:1001
msgid "disallow granting new privileges failed"
msgstr "zakázání přidělování nových oprávnění selhalo"

#: sys-utils/setpriv.c:1009
msgid "keep process capabilities failed"
msgstr "ponechání kvalifikací procesu selhalo"

#: sys-utils/setpriv.c:1017
msgid "activate capabilities"
msgstr "aktivovat kvalifikace"

#: sys-utils/setpriv.c:1023
msgid "reactivate capabilities"
msgstr "reaktivovat kvalifikace"

#: sys-utils/setpriv.c:1034
msgid "initgroups failed"
msgstr "funkce initgroups selhala"

#: sys-utils/setpriv.c:1042
msgid "set process securebits failed"
msgstr "nastavení bezpečnostních bitů procesu selhalo"

#: sys-utils/setpriv.c:1048
msgid "apply bounding set"
msgstr "aplikovat ohraničující množinu"

#: sys-utils/setpriv.c:1054
msgid "apply capabilities"
msgstr "aplikovat kvalifikace"

#: sys-utils/setpriv.c:1063
msgid "set parent death signal failed"
msgstr "nastavení signálu při úmrtí rodiče selhalo"

#: sys-utils/setsid.c:33
#, c-format
msgid " %s [options] <program> [arguments ...]\n"
msgstr " %s [přepínače] <program> [argument…]\n"

#: sys-utils/setsid.c:37
msgid "Run a program in a new session.\n"
msgstr "Spustí program v nové relaci.\n"

#: sys-utils/setsid.c:40
msgid " -c, --ctty     set the controlling terminal to the current one\n"
msgstr " -c, --ctty     nastaví řídicí terminál na současný\n"

#: sys-utils/setsid.c:41
msgid " -f, --fork     always fork\n"
msgstr " -f, --fork     vždy vytvoří nový proces\n"

#: sys-utils/setsid.c:42
msgid " -w, --wait     wait program to exit, and use the same return\n"
msgstr "-w, --wait      počká na ukončení programu a vrátí jeho návratovou hodnotu\n"

#: sys-utils/setsid.c:100
msgid "fork"
msgstr "fork"

#: sys-utils/setsid.c:112
#, c-format
msgid "child %d did not exit normally"
msgstr "potomek %d neskončil normálně"

#: sys-utils/setsid.c:117
msgid "setsid failed"
msgstr "volání setsid selhalo"

#: sys-utils/setsid.c:120
msgid "failed to set the controlling terminal"
msgstr "nepodařilo se nastavit řídicí terminál"

#: sys-utils/swapoff.c:94
#, c-format
msgid "swapoff %s\n"
msgstr "vypíná se odkládání do %s\n"

#: sys-utils/swapoff.c:114
msgid "Not superuser."
msgstr "Nejste superuživatel."

#: sys-utils/swapoff.c:117 sys-utils/swapoff.c:122
#, c-format
msgid "%s: swapoff failed"
msgstr "%s: swapoff selhal"

#: sys-utils/swapoff.c:141 sys-utils/swapon.c:793
#, c-format
msgid " %s [options] [<spec>]\n"
msgstr " %s [přepínače] [<specifikace>]\n"

#: sys-utils/swapoff.c:144
msgid "Disable devices and files for paging and swapping.\n"
msgstr "Vypne stránkování a odkládání do zařízení a souborů.\n"

#: sys-utils/swapoff.c:147
msgid ""
" -a, --all              disable all swaps from /proc/swaps\n"
" -v, --verbose          verbose mode\n"
msgstr ""
" -a, --all              vypne všechny odkládací oblasti uvedené v /proc/swaps\n"
" -v, --verbose          upovídaný režim\n"

#: sys-utils/swapoff.c:153
msgid ""
"\n"
"The <spec> parameter:\n"
" -L <label>             LABEL of device to be used\n"
" -U <uuid>              UUID of device to be used\n"
" LABEL=<label>          LABEL of device to be used\n"
" UUID=<uuid>            UUID of device to be used\n"
" <device>               name of device to be used\n"
" <file>                 name of file to be used\n"
msgstr ""
"\n"
"Parametr <specifikace>:\n"
" -L JMENOVKA            vybere zařízení podle jmenovky\n"
" -U UUID                vybere zařízení podle UUID\n"
" LABEL=<jmenovka>       vybere zařízení podle jmenovky\n"
" UUID=<UUID>            vybere zařízení podle UUID\n"
" <zařízení>             vybere zařízení\n"
" <soubor>               vybere soubor\n"
"\n"

#: sys-utils/swapon.c:96
msgid "device file or partition path"
msgstr "soubor zařízení nebo cesta k oddílu"

#: sys-utils/swapon.c:97
msgid "type of the device"
msgstr "druh zařízení"

#: sys-utils/swapon.c:98
msgid "size of the swap area"
msgstr "velikost odkládací oblasti"

#: sys-utils/swapon.c:99
msgid "bytes in use"
msgstr "použito bajtů"

#: sys-utils/swapon.c:100
msgid "swap priority"
msgstr "priorita odkládací oblasti"

#: sys-utils/swapon.c:101
msgid "swap uuid"
msgstr "UUID odkládací oblasti"

#: sys-utils/swapon.c:102
msgid "swap label"
msgstr "jmenovka odkládací oblasti"

#: sys-utils/swapon.c:249
#, c-format
msgid "%s\t\t\t\tType\t\tSize\tUsed\tPriority\n"
msgstr "%s\t\t\t\tDruh\t\tVelikost\tPoužito\tPriorita\n"

#: sys-utils/swapon.c:249
msgid "Filename"
msgstr "Název souboru"

#: sys-utils/swapon.c:315
#, c-format
msgid "%s: reinitializing the swap."
msgstr "%s: odkládací oblast se znovu inicializuje."

#: sys-utils/swapon.c:379
#, c-format
msgid "%s: lseek failed"
msgstr "%s: volání lseek selhalo"

#: sys-utils/swapon.c:385
#, c-format
msgid "%s: write signature failed"
msgstr "%s: zápis vzorce selhal"

#: sys-utils/swapon.c:539
#, c-format
msgid "%s: skipping - it appears to have holes."
msgstr "%s: vynechávám – zdá se, že obsahuje díry."

#: sys-utils/swapon.c:547
#, c-format
msgid "%s: get size failed"
msgstr "%s: nepodařilo se zjistit velikost"

#: sys-utils/swapon.c:553
#, c-format
msgid "%s: read swap header failed"
msgstr "%s: nepodařilo se načíst hlavičku odkládací oblasti"

#: sys-utils/swapon.c:558
#, c-format
msgid "%s: found signature [pagesize=%d, signature=%s]"
msgstr "%s: nalezen vzorec [velikost stránky %d, vzorec %s]"

#: sys-utils/swapon.c:569
#, c-format
msgid "%s: pagesize=%d, swapsize=%llu, devsize=%llu"
msgstr "%s: velikost_stránky=%d, velikost_úložiště=%llu, velikost_zařízení=%llu"

#: sys-utils/swapon.c:574
#, c-format
msgid "%s: last_page 0x%08llx is larger than actual size of swapspace"
msgstr "%s: last_page 0x%08llx je větší než současní velikost odkládacího prostoru"

#: sys-utils/swapon.c:584
#, c-format
msgid "%s: swap format pagesize does not match."
msgstr "%s: formát odkládacího prostoru se neshoduje ve velikosti stránky."

#: sys-utils/swapon.c:590
#, c-format
msgid "%s: swap format pagesize does not match. (Use --fixpgsz to reinitialize it.)"
msgstr "%s: formát odkládacího prostoru se neshoduje ve velikosti stránky. (Lze ji znovu inicializovat pomocí --fixpgsz.)"

#: sys-utils/swapon.c:599
#, c-format
msgid "%s: software suspend data detected. Rewriting the swap signature."
msgstr "%s: nalezena data ze softwarového uspání. Přepisuje se vzorec odkládací oblasti."

#: sys-utils/swapon.c:669
#, c-format
msgid "swapon %s\n"
msgstr "zapíná se odkládání do %s\n"

#: sys-utils/swapon.c:673
#, c-format
msgid "%s: swapon failed"
msgstr "%s: swapon selhal"

#: sys-utils/swapon.c:746
#, c-format
msgid "%s: noauto option -- ignored"
msgstr "%s: volba noauto – ignoruje se"

#: sys-utils/swapon.c:768
#, c-format
msgid "%s: already active -- ignored"
msgstr "%s: již aktivní – ignoruje se"

#: sys-utils/swapon.c:774
#, c-format
msgid "%s: inaccessible -- ignored"
msgstr "%s: nepřístupný – ignoruje se"

#: sys-utils/swapon.c:796
msgid "Enable devices and files for paging and swapping.\n"
msgstr "Umožní stránkování a odkládaní do zařízení a souborů.\n"

#: sys-utils/swapon.c:799
msgid " -a, --all                enable all swaps from /etc/fstab\n"
msgstr " -a, --all                zapne všechny odkládací oblasti uvedené v /etc/fstab\n"

#: sys-utils/swapon.c:800
msgid " -d, --discard[=<policy>] enable swap discards, if supported by device\n"
msgstr ""
" -d, --discard[=<politika>]\n"
"                          zapne zahazování stránek, je-li podporováno zařízením\n"

#: sys-utils/swapon.c:801
msgid " -e, --ifexists           silently skip devices that do not exist\n"
msgstr " -e, --ifexists           v tichosti přeskočí neexistující zařízení\n"

#: sys-utils/swapon.c:802
msgid " -f, --fixpgsz            reinitialize the swap space if necessary\n"
msgstr " -f, --fixpgsz            znovu inicializuje odkládací oblast, je-li to nutné\n"

#: sys-utils/swapon.c:803
msgid " -o, --options <list>     comma-separated list of swap options\n"
msgstr " -o, --options <seznam>   čárkou oddělený seznam voleb pro odkládací oblast\n"

#: sys-utils/swapon.c:804
msgid " -p, --priority <prio>    specify the priority of the swap device\n"
msgstr ""
" -p, --priority <priorita>\n"
"                          určuje prioritu odkládacího zařízení\n"

#: sys-utils/swapon.c:805
msgid " -s, --summary            display summary about used swap devices (DEPRECATED)\n"
msgstr ""
" -s, --summary            zobrazí přehled použitých odkládacích zařízení\n"
"                          (ZASTARALÉ)\n"

#: sys-utils/swapon.c:806
msgid "     --show[=<columns>]   display summary in definable table\n"
msgstr "     --show[=<sloupce>]  zobrazí přehled v definovatelné tabulce\n"

#: sys-utils/swapon.c:807
msgid "     --noheadings         don't print table heading (with --show)\n"
msgstr "     --noheadings         nezobrazí záhlaví tabulky (při --show)\n"

#: sys-utils/swapon.c:808
msgid "     --raw                use the raw output format (with --show)\n"
msgstr "     --raw                neformátovaný výstup (při --show)\n"

#: sys-utils/swapon.c:809
msgid "     --bytes              display swap size in bytes in --show output\n"
msgstr "     --bytes              zobrazí velikosti v bajtech ve výstupu --show\n"

#: sys-utils/swapon.c:810
msgid " -v, --verbose            verbose mode\n"
msgstr " -v, --verbose            upovídaný režim\n"

#: sys-utils/swapon.c:815
msgid ""
"\n"
"The <spec> parameter:\n"
" -L <label>             synonym for LABEL=<label>\n"
" -U <uuid>              synonym for UUID=<uuid>\n"
" LABEL=<label>          specifies device by swap area label\n"
" UUID=<uuid>            specifies device by swap area UUID\n"
" PARTLABEL=<label>      specifies device by partition label\n"
" PARTUUID=<uuid>        specifies device by partition UUID\n"
" <device>               name of device to be used\n"
" <file>                 name of file to be used\n"
msgstr ""
"\n"
"Parametr <specifikace>:\n"
" -L <jmenovka>          stejné jako LABEL=<jmenovka>\n"
" -U <UUID>              stejné jako UUID=<UUID>\n"
" LABEL=<jmenovka>       vybere zařízení podle jmenovky odkládací oblasti\n"
" UUID=<UUID>            vybere zařízení podle UUID odkládací oblasti\n"
" PARTLABEL=<jmenovka>   vybere zařízení podle jmenovky oddílu\n"
" PARTUUID=<UUID>        vybere zařízení podle UUID oddílu\n"
" <zařízení>             vybere zařízení\n"
" <soubor>               vybere soubor\n"

#: sys-utils/swapon.c:825
msgid ""
"\n"
"Available discard policy types (for --discard):\n"
" once    : only single-time area discards are issued\n"
" pages   : freed pages are discarded before they are reused\n"
"If no policy is selected, both discard types are enabled (default).\n"
msgstr ""
"\n"
"Dostupné politiky zahazování (pro přepínač --discard):\n"
" once     pouze zahodí bloky celé odkládací oblasti při zapnutí (swapon).\n"
" pages    zahazuje bloky uvolněných stránek před jejich opětovným použitím.\n"
" Není-li vybrána žádná politika, oba typy zahazování budou zapnuty (výchozí).\n"

#: sys-utils/swapon.c:907
msgid "failed to parse priority"
msgstr "prioritu se nezdařilo rozebrat"

#: sys-utils/swapon.c:926
#, c-format
msgid "unsupported discard policy: %s"
msgstr "nepodporovaná politika zahazování: %s"

#: sys-utils/swapon-common.c:73
#, c-format
msgid "cannot find the device for %s"
msgstr "nelze nalézt zařízení pro %s"

#: sys-utils/switch_root.c:60
msgid "failed to open directory"
msgstr "adresář se nepodařilo otevřít"

#: sys-utils/switch_root.c:68
msgid "stat failed"
msgstr "volání stat selhalo"

#: sys-utils/switch_root.c:79
msgid "failed to read directory"
msgstr "adresáře nelze přečíst"

#: sys-utils/switch_root.c:116
#, c-format
msgid "failed to unlink %s"
msgstr "%s se nepodařilo smazat"

#: sys-utils/switch_root.c:153
#, c-format
msgid "failed to mount moving %s to %s"
msgstr "přesun přípojného bodu %s do %s se nezdařil"

#: sys-utils/switch_root.c:155
#, c-format
msgid "forcing unmount of %s"
msgstr "vynucuje se odpojení %s"

#: sys-utils/switch_root.c:161
#, c-format
msgid "failed to change directory to %s"
msgstr "nepodařilo se přejít do adresáře %s"

#: sys-utils/switch_root.c:173
#, c-format
msgid "failed to mount moving %s to /"
msgstr "přesun přípojného bodu %s do / se nezdařil"

#: sys-utils/switch_root.c:179
msgid "failed to change root"
msgstr "změna kořenu se nezdařila"

#: sys-utils/switch_root.c:192
msgid "old root filesystem is not an initramfs"
msgstr "starý kořenový souborový systém není initramfs"

#: sys-utils/switch_root.c:205
#, c-format
msgid " %s [options] <newrootdir> <init> <args to init>\n"
msgstr " %s [přepínače] <nový_kořenový_adresář> <init> <argumentu_initu>\n"

#: sys-utils/switch_root.c:209
msgid "Switch to another filesystem as the root of the mount tree.\n"
msgstr "Přepne kořen stromu připojení do jiného souborového systému.\n"

#: sys-utils/switch_root.c:254
msgid "failed. Sorry."
msgstr "neúspěch. Je nám líto."

#: sys-utils/switch_root.c:257
#, c-format
msgid "cannot access %s"
msgstr "k %s nelze přistoupit"

#: sys-utils/tunelp.c:98
msgid "Set various parameters for the line printer.\n"
msgstr "Nastaví rozličné parametry řádkové tiskárny.\n"

#: sys-utils/tunelp.c:101
msgid " -i, --irq <num>              specify parallel port irq\n"
msgstr " -i, --irq <číslo>            určuje IRQ paralelní portu\n"

#: sys-utils/tunelp.c:102
msgid " -t, --time <ms>              driver wait time in milliseconds\n"
msgstr " -t, --time <ms>              čekání na ovladač v milisekundách\n"

#: sys-utils/tunelp.c:103
msgid " -c, --chars <num>            number of output characters before sleep\n"
msgstr " -c, --chars <číslo>          počet výstupních znaků před usnutím\n"

#: sys-utils/tunelp.c:104
msgid " -w, --wait <us>              strobe wait in micro seconds\n"
msgstr " -w, --wait <µs>              čekání na signál strobe v mikrosekundách\n"

#. TRANSLATORS: do not translate <on|off> arguments. The
#. argument reader does not recognize locale, unless `on' is
#. exactly that very same string.
#: sys-utils/tunelp.c:108
msgid " -a, --abort <on|off>         abort on error\n"
msgstr " -a, --abort <on|off>         ukončí činnost při chybě (ano|ne)\n"

#: sys-utils/tunelp.c:109
msgid " -o, --check-status <on|off>  check printer status before printing\n"
msgstr " -o, --check-status <on|off>  před výpisem zkontroluje stav tiskárny (ano|ne)\n"

#: sys-utils/tunelp.c:110
msgid " -C, --careful <on|off>       extra checking to status check\n"
msgstr " -C, --careful <on|off>       doplňující kontroly stavu (ano|ne)\n"

#: sys-utils/tunelp.c:111
msgid " -s, --status                 query printer status\n"
msgstr " -s, --status                 dotáže se na stav tiskárny\n"

#: sys-utils/tunelp.c:112
msgid " -r, --reset                  reset the port\n"
msgstr " -r, --reset                  resetuje port\n"

#: sys-utils/tunelp.c:113
msgid " -q, --print-irq <on|off>     display current irq setting\n"
msgstr " -q, --print-irq <on|off>     zobrazí současné nastavení IRQ\n"

#: sys-utils/tunelp.c:258
#, c-format
msgid "%s not an lp device"
msgstr "%s není lp zařízením"

#: sys-utils/tunelp.c:277
msgid "LPGETSTATUS error"
msgstr "chyba LPGETSTATUS"

#: sys-utils/tunelp.c:282
#, c-format
msgid "%s status is %d"
msgstr "status %s je %d"

#: sys-utils/tunelp.c:284
#, c-format
msgid ", busy"
msgstr ", zaneprázdněna"

#: sys-utils/tunelp.c:286
#, c-format
msgid ", ready"
msgstr ", připravena"

#: sys-utils/tunelp.c:288
#, c-format
msgid ", out of paper"
msgstr ", došel papír"

#: sys-utils/tunelp.c:290
#, c-format
msgid ", on-line"
msgstr ", zapnuta"

#: sys-utils/tunelp.c:292
#, c-format
msgid ", error"
msgstr ", chyba"

#: sys-utils/tunelp.c:296
msgid "ioctl failed"
msgstr "volání ioctl selhalo"

#: sys-utils/tunelp.c:306
msgid "LPGETIRQ error"
msgstr "chyba LPGETIRQ"

#: sys-utils/tunelp.c:311
#, c-format
msgid "%s using IRQ %d\n"
msgstr "%s používá IRQ %d\n"

#: sys-utils/tunelp.c:313
#, c-format
msgid "%s using polling\n"
msgstr "%s používá poll\n"

#: sys-utils/umount.c:81
#, c-format
msgid ""
" %1$s [-hV]\n"
" %1$s -a [options]\n"
" %1$s [options] <source> | <directory>\n"
msgstr ""
" %1$s [-hV]\n"
" %1$s -a [přepínače]\n"
" %1$s [přepínače] <zdroj> | <adresář>\n"

#: sys-utils/umount.c:87
msgid "Unmount filesystems.\n"
msgstr "Odpojí souborové systémy.\n"

#: sys-utils/umount.c:90
msgid " -a, --all               unmount all filesystems\n"
msgstr " -a, --all               odpojí všechny souborové systémy\n"

#: sys-utils/umount.c:91
msgid ""
" -A, --all-targets       unmount all mountpoints for the given device in the\n"
"                           current namespace\n"
msgstr ""
" -A, --all-targets       odpojí všechny body přípojení pro zadané zařízení\n"
"                         v aktuálním jmenném prostoru\n"

#: sys-utils/umount.c:93
msgid " -c, --no-canonicalize   don't canonicalize paths\n"
msgstr " -c, --no-canonicalize   nenormalizuje cesty\n"

#: sys-utils/umount.c:94
msgid " -d, --detach-loop       if mounted loop device, also free this loop device\n"
msgstr " -d, --detach-loop       je-li připojeno loop zařízení, rovněž jej uvolní\n"

#: sys-utils/umount.c:95
msgid "     --fake              dry run; skip the umount(2) syscall\n"
msgstr "     --fake              zkušební režim, přeskočí systémové volání umount(2)\n"

#: sys-utils/umount.c:96
msgid " -f, --force             force unmount (in case of an unreachable NFS system)\n"
msgstr " -f, --force             vynutí odpojení (pro případ nedostupného NFS)\n"

#: sys-utils/umount.c:97
msgid " -i, --internal-only     don't call the umount.<type> helpers\n"
msgstr " -i, --internal-only     nevolá pomocné programy umount.<typ>\n"

#: sys-utils/umount.c:99
msgid " -l, --lazy              detach the filesystem now, clean up things later\n"
msgstr " -l, --lazy              souborový systém odpojí teď, uklidí později\n"

#: sys-utils/umount.c:100
msgid " -O, --test-opts <list>  limit the set of filesystems (use with -a)\n"
msgstr ""
" -O, --test-opts <seznam>\n"
"                         omezí množinu souborových systémů (použijte s -a)\n"

#: sys-utils/umount.c:101
msgid " -R, --recursive         recursively unmount a target with all its children\n"
msgstr " -R, --recursive         rekurzivně odpojí cíl včetně všech jeho potomků\n"

#: sys-utils/umount.c:102
msgid " -r, --read-only         in case unmounting fails, try to remount read-only\n"
msgstr ""
" -r, --read-only         selže-li odpojení, zkusí souborový systém přepojit\n"
"                         jen pro čtení\n"

#: sys-utils/umount.c:103
msgid " -t, --types <list>      limit the set of filesystem types\n"
msgstr " -t, --types <seznam>    omezí množinu typů souborových systémů\n"

#: sys-utils/umount.c:105
msgid " -q, --quiet             suppress 'not mounted' error messages\n"
msgstr " -q, --quiet             potlačí chybovou hlášku „nepřipojeno“\n"

#: sys-utils/umount.c:106
msgid " -N, --namespace <ns>    perform umount in another namespace\n"
msgstr " -N, --namespace <jp>    odpojí souborový systém v jiném jmenném prostoru\n"

#: sys-utils/umount.c:149
#, c-format
msgid "%s (%s) unmounted"
msgstr "%s (%s) odpojen"

#: sys-utils/umount.c:151
#, c-format
msgid "%s unmounted"
msgstr "%s odpojen"

#: sys-utils/umount.c:220
msgid "failed to set umount target"
msgstr "nezdařilo se nastavit cíl odpojení"

#: sys-utils/umount.c:253
msgid "libmount table allocation failed"
msgstr "alokace tabulky libmountu se nezdařila"

#: sys-utils/umount.c:299 sys-utils/umount.c:381
msgid "libmount iterator allocation failed"
msgstr "alokace iterátoru libmountu se nezdařila"

#: sys-utils/umount.c:305
#, c-format
msgid "failed to get child fs of %s"
msgstr "nepodařilo se získat souborový systém potomka %s"

#: sys-utils/umount.c:344 sys-utils/umount.c:368
#, c-format
msgid "%s: not found"
msgstr "%s: nenalezeno"

#: sys-utils/umount.c:375
#, c-format
msgid "%s: failed to determine source (--all-targets is unsupported on systems with regular mtab file)."
msgstr "%s: určení zdroje selhalo (--all-targets není podporováno na systémech s běžným souborem mtab)."

#: sys-utils/unshare.c:95
#, c-format
msgid "unsupported --setgroups argument '%s'"
msgstr "nepodporovaný argument --setgroups: „%s“"

#: sys-utils/unshare.c:116 sys-utils/unshare.c:131
#, c-format
msgid "write failed %s"
msgstr "zápis do %s selhal"

#: sys-utils/unshare.c:154
#, c-format
msgid "unsupported propagation mode: %s"
msgstr "nepodporovaný režim propagace: %s"

#: sys-utils/unshare.c:163
msgid "cannot change root filesystem propagation"
msgstr "propagaci kořenového souborového systému nelze změnit"

#: sys-utils/unshare.c:194
#, c-format
msgid "mount %s on %s failed"
msgstr "připojení %s do %s selhalo"

#: sys-utils/unshare.c:221
#, fuzzy
msgid "failed to open /proc/self/timens_offsets"
msgstr "nezdařilo se rozebrat začátek oblasti"

#: sys-utils/unshare.c:224
#, fuzzy
msgid "failed to write to /proc/self/timens_offsets"
msgstr "nezdařilo se rozebrat začátek oblasti"

#: sys-utils/unshare.c:236
msgid "pipe failed"
msgstr "vytvoření roury selhalo"

#: sys-utils/unshare.c:250
msgid "failed to read pipe"
msgstr "čtení z roury selhalo"

#: sys-utils/unshare.c:309
msgid "Run a program with some namespaces unshared from the parent.\n"
msgstr "Spustí program s některými jmennými prostory oddělenými od rodiče.\n"

#: sys-utils/unshare.c:312
msgid " -m, --mount[=<file>]      unshare mounts namespace\n"
msgstr " -m, --mount[=<soubor>]    oddělí jmenný prostor přípojných bodů\n"

#: sys-utils/unshare.c:313
msgid " -u, --uts[=<file>]        unshare UTS namespace (hostname etc)\n"
msgstr " -u, --uts[=<soubor>]      oddělí jmenný prostoru UTS (název stroje atd.)\n"

#: sys-utils/unshare.c:314
msgid " -i, --ipc[=<file>]        unshare System V IPC namespace\n"
msgstr " -i, --ipc[=<soubor>]      oddělí jmenný prostor System V IPC\n"

#: sys-utils/unshare.c:315
msgid " -n, --net[=<file>]        unshare network namespace\n"
msgstr " -n, --net[=<soubor>]      oddělí jmenný prostoru sítí\n"

#: sys-utils/unshare.c:316
msgid " -p, --pid[=<file>]        unshare pid namespace\n"
msgstr " -p, --pid[=<soubor>]      oddělí jmenný prostoru čísel procesů\n"

#: sys-utils/unshare.c:317
msgid " -U, --user[=<file>]       unshare user namespace\n"
msgstr " -U, --user[=<soubor>]     oddělí jmenný prostor uživatelů\n"

#: sys-utils/unshare.c:318
msgid " -C, --cgroup[=<file>]     unshare cgroup namespace\n"
msgstr " -C, --cgroup[=<soubor>]   oddělí jmenný prostor kontrolních skupin\n"

#: sys-utils/unshare.c:319
#, fuzzy
msgid " -T, --time[=<file>]       unshare time namespace\n"
msgstr " -p, --pid[=<soubor>]      oddělí jmenný prostoru čísel procesů\n"

#: sys-utils/unshare.c:321
msgid " -f, --fork                fork before launching <program>\n"
msgstr " -f, --fork                před spuštěním <programu> vytvoří potomka\n"

#: sys-utils/unshare.c:322
#, fuzzy
msgid " --map-user=<uid>|<name>   map current user to uid (implies --user)\n"
msgstr ""
" -c, --map-current-user    namapuje současného uživatele na sebe\n"
"                           (znamená --user)\n"

#: sys-utils/unshare.c:323
#, fuzzy
msgid " --map-group=<gid>|<name>  map current group to gid (implies --user)\n"
msgstr ""
" -r, --map-root-user       namapuje současného uživatele na uživatele root\n"
"                           (znamená --user)\n"

#: sys-utils/unshare.c:324
msgid " -r, --map-root-user       map current user to root (implies --user)\n"
msgstr ""
" -r, --map-root-user       namapuje současného uživatele na uživatele root\n"
"                           (znamená --user)\n"

#: sys-utils/unshare.c:325
msgid " -c, --map-current-user    map current user to itself (implies --user)\n"
msgstr ""
" -c, --map-current-user    namapuje současného uživatele na sebe\n"
"                           (znamená --user)\n"

#: sys-utils/unshare.c:327
msgid ""
" --kill-child[=<signame>]  when dying, kill the forked child (implies --fork)\n"
"                             defaults to SIGKILL\n"
msgstr ""
" --kill-child[=<název_signálu>]\n"
"                           při ukončení zabije potomky (zapne --fork);\n"
"                           výchozí je SIGKILL\n"

#: sys-utils/unshare.c:329
msgid " --mount-proc[=<dir>]      mount proc filesystem first (implies --mount)\n"
msgstr ""
" --mount-proc[=<adresář>]  nejprve připojí souborový systém proc\n"
"                           (znamená --mount)\n"

#: sys-utils/unshare.c:330
msgid ""
" --propagation slave|shared|private|unchanged\n"
"                           modify mount propagation in mount namespace\n"
msgstr ""
" --propagation slave|shared|private|unchanged\n"
"                           změní propagaci připojení ve jmenném prostoru\n"
"                           přípojných bodů („slave“ podřízená,\n"
"                           „shared“ sdílená, „private“ soukromá,\n"
"                           „unchanged“ nezměněná\n"

#: sys-utils/unshare.c:332
msgid " --setgroups allow|deny    control the setgroups syscall in user namespaces\n"
msgstr ""
" --setgroups allow|deny    řídí volání setgroups ve jmenných prostorech\n"
"                           uživatele („allow“ povolí, „deny“ zakáže)\n"

#: sys-utils/unshare.c:333
msgid " --keep-caps               retain capabilities granted in user namespaces\n"
msgstr ""
" --keep-caps               zachová kvalifikace získané ve jmenném prostoru\n"
"                           uživatelů\n"

#: sys-utils/unshare.c:335
#, fuzzy
msgid " -R, --root=<dir>          run the command with root directory set to <dir>\n"
msgstr ""
" -R, --root=<adresář>      spustí příkaz s kořenovým adresářem nastaveným na\n"
"                           <adresář>\n"

#: sys-utils/unshare.c:336
#, fuzzy
msgid " -w, --wd=<dir>            change working directory to <dir>\n"
msgstr " -w, --wd=<adresář>        změní pracovní adresář na <adresář>\n"

#: sys-utils/unshare.c:337
#, fuzzy
msgid " -S, --setuid <uid>        set uid in entered namespace\n"
msgstr " -S, --setuid <uid>     nastaví UID ve vstoupeném jmenném prostoru\n"

#: sys-utils/unshare.c:338
#, fuzzy
msgid " -G, --setgid <gid>        set gid in entered namespace\n"
msgstr " -G, --setgid <gid>     nastaví GID ve vstoupeném jmenném prostoru\n"

#: sys-utils/unshare.c:339
msgid " --monotonic <offset>      set clock monotonic offset (seconds) in time namespaces\n"
msgstr ""

#: sys-utils/unshare.c:340
msgid " --boottime <offset>       set clock boottime offset (seconds) in time namespaces\n"
msgstr ""

#: sys-utils/unshare.c:524
#, fuzzy
msgid "failed to parse monotonic offset"
msgstr "nezdařilo se rozebrat začátek zóny"

#: sys-utils/unshare.c:528
#, fuzzy
msgid "failed to parse boottime offset"
msgstr "nezdařilo se rozebrat začátek zóny"

#: sys-utils/unshare.c:542
msgid "options --monotonic and --boottime require unsharing of a time namespace (-t)"
msgstr ""

#: sys-utils/unshare.c:549
msgid "unshare failed"
msgstr "volání unshare selhalo"

#: sys-utils/unshare.c:616
msgid "child exit failed"
msgstr "ukončení potomka selhalo"

#: sys-utils/unshare.c:631
#, fuzzy
msgid "options --setgroups=allow and --map-group are mutually exclusive"
msgstr "přepínače --setgroups=allow a --map-root-user se vzájemně vylučují"

#: sys-utils/unshare.c:646
#, c-format
msgid "cannot change root directory to '%s'"
msgstr "kořenový adresáře nelze změnit na „%s“"

#: sys-utils/unshare.c:650
#, c-format
msgid "cannot chdir to '%s'"
msgstr "do adresáře „%s“ nelze přejít"

#: sys-utils/unshare.c:654
#, c-format
msgid "umount %s failed"
msgstr "odpojení %s se nezdařilo"

#: sys-utils/unshare.c:656
#, c-format
msgid "mount %s failed"
msgstr "připojení %s se nezdařilo"

#: sys-utils/unshare.c:682
msgid "capget failed"
msgstr "volání capget selhalo"

#: sys-utils/unshare.c:690
msgid "capset failed"
msgstr "volání capset selhalo"

#: sys-utils/unshare.c:702
msgid "prctl(PR_CAP_AMBIENT) failed"
msgstr "volání prctl(PR_CAP_AMBIENT) selhalo"

#: sys-utils/wdctl.c:72
msgid "Card previously reset the CPU"
msgstr "Karta naposledy resetovala CPU"

#: sys-utils/wdctl.c:73
msgid "External relay 1"
msgstr "Vnější relé 1"

#: sys-utils/wdctl.c:74
msgid "External relay 2"
msgstr "Vnější relé 2"

#: sys-utils/wdctl.c:75
msgid "Fan failed"
msgstr "Selhal větrák"

#: sys-utils/wdctl.c:76
msgid "Keep alive ping reply"
msgstr "Odpověď na keep-alive ping"

#: sys-utils/wdctl.c:77
msgid "Supports magic close char"
msgstr "Podporuje magický znak uzavření"

#: sys-utils/wdctl.c:78
msgid "Reset due to CPU overheat"
msgstr "Reset kvůli přehřátí CPU"

#: sys-utils/wdctl.c:79
msgid "Power over voltage"
msgstr "Přepětí"

#: sys-utils/wdctl.c:80
msgid "Power bad/power fault"
msgstr "Podpětí / výpadek napájení"

# ???
#: sys-utils/wdctl.c:81
msgid "Pretimeout (in seconds)"
msgstr "Prvotní časový limit (v sekundách)"

#: sys-utils/wdctl.c:82
msgid "Set timeout (in seconds)"
msgstr "Nastavení časového limitu (v sekundách)"

#: sys-utils/wdctl.c:83
msgid "Not trigger reboot"
msgstr "Nezpůsobí reboot"

#: sys-utils/wdctl.c:99
msgid "flag name"
msgstr "název příznaku"

#: sys-utils/wdctl.c:100
msgid "flag description"
msgstr "popis příznaku"

#: sys-utils/wdctl.c:101
msgid "flag status"
msgstr "stav příznaku"

#: sys-utils/wdctl.c:102
msgid "flag boot status"
msgstr "stav příznaku startu systému"

#: sys-utils/wdctl.c:103
msgid "watchdog device name"
msgstr "název hlídacího zařízení"

#: sys-utils/wdctl.c:148
#, c-format
msgid "unknown flag: %s"
msgstr "neznámý příznak: %s"

#: sys-utils/wdctl.c:210
msgid "Show the status of the hardware watchdog.\n"
msgstr "Ukáže stav hardwarového hlídacího zařízení.\n"

#: sys-utils/wdctl.c:213
msgid ""
" -f, --flags <list>     print selected flags only\n"
" -F, --noflags          don't print information about flags\n"
" -I, --noident          don't print watchdog identity information\n"
" -n, --noheadings       don't print headings for flags table\n"
" -O, --oneline          print all information on one line\n"
" -o, --output <list>    output columns of the flags\n"
" -r, --raw              use raw output format for flags table\n"
" -T, --notimeouts       don't print watchdog timeouts\n"
" -s, --settimeout <sec> set watchdog timeout\n"
" -x, --flags-only       print only flags table (same as -I -T)\n"
msgstr ""
" -f, --flags <seznam>   vypíše pouze vybrané příznaky\n"
" -F, --noflags          nevypisuje údaje o příznacích\n"
" -I, --noident          nevypisuje identifikační údaje sledovacího zařízení\n"
" -n, --noheadings       nevypisuje záhlaví tabulky příznaků\n"
" -O, --oneline          vypíše všechny údaje na jeden řádek\n"
" -o, --output <seznam>  vypíše sloupce příznaků\n"
" -r, --raw              tabulku příznaků neformátuje\n"
" -T, --notimeouts       nevypisuje časové limity hlídacího zařízení\n"
" -s, --settimeout <sekundy>\n"
"                        nastaví časový limit hlídacího zařízení\n"
" -x, --flags-only       vypíše jen tabulku příznaků (stejné jako -I -T)\n"

#: sys-utils/wdctl.c:229
#, c-format
msgid "The default device is %s.\n"
msgstr "Výchozí zařízení je %s.\n"

#: sys-utils/wdctl.c:231
#, c-format
msgid "No default device is available.\n"
msgstr "Žádné výchozí zařízení není dostupné.\n"

#: sys-utils/wdctl.c:329
#, c-format
msgid "%s: unknown flags 0x%x\n"
msgstr "%s: neznámý příznak 0x%x\n"

#: sys-utils/wdctl.c:359
#, c-format
msgid "%s: watchdog already in use, terminating."
msgstr "%s: hlídací zařízení se již používá, končí se."

#: sys-utils/wdctl.c:373 sys-utils/wdctl.c:438
#, c-format
msgid "%s: failed to disarm watchdog"
msgstr "%s: hlídací zařízení se nepodařilo vypnout"

#: sys-utils/wdctl.c:382
#, c-format
msgid "cannot set timeout for %s"
msgstr "časový limit pro %s nelze nastavit"

#: sys-utils/wdctl.c:388
#, c-format
msgid "Timeout has been set to %d second.\n"
msgid_plural "Timeout has been set to %d seconds.\n"
msgstr[0] "Časový limit je nastaven na %d sekundu.\n"
msgstr[1] "Časový limit je nastaven na %d sekundy.\n"
msgstr[2] "Časový limit je nastaven na %d sekund.\n"

#: sys-utils/wdctl.c:417
#, c-format
msgid "%s: failed to get information about watchdog"
msgstr "%s: získání údajů o hlídacím zařízení selhalo"

#: sys-utils/wdctl.c:503
#, c-format
msgid "cannot read information about %s"
msgstr "údaje o %s nelze přečíst"

#: sys-utils/wdctl.c:513 sys-utils/wdctl.c:516 sys-utils/wdctl.c:519
#, c-format
msgid "%-14s %2i second\n"
msgid_plural "%-14s %2i seconds\n"
msgstr[0] "%-14s %2i sekunda\n"
msgstr[1] "%-14s %2i sekundy\n"
msgstr[2] "%-14s %2i sekund\n"

#: sys-utils/wdctl.c:514
msgid "Timeout:"
msgstr "Časový limit:"

#: sys-utils/wdctl.c:517
msgid "Pre-timeout:"
msgstr "Prvotní časový limit"

#: sys-utils/wdctl.c:520
msgid "Timeleft:"
msgstr "Zbývá času:"

#: sys-utils/wdctl.c:576
msgid "Device:"
msgstr "Zařízení:"

#: sys-utils/wdctl.c:578
msgid "Identity:"
msgstr "Identita:"

#: sys-utils/wdctl.c:580
msgid "version"
msgstr "verze"

#: sys-utils/wdctl.c:690
msgid "No default device is available."
msgstr "Žádné výchozí zařízení není dostupné."

#: sys-utils/zramctl.c:75
msgid "zram device name"
msgstr "název zařízení zram"

#: sys-utils/zramctl.c:76
msgid "limit on the uncompressed amount of data"
msgstr "omezení na množství nekomprimovaných dat"

#: sys-utils/zramctl.c:77
msgid "uncompressed size of stored data"
msgstr "nekomprimovaná velikost uložených dat"

#: sys-utils/zramctl.c:78
msgid "compressed size of stored data"
msgstr "komprimovaná velikost uložených dat"

#: sys-utils/zramctl.c:79
msgid "the selected compression algorithm"
msgstr "vybraný kompresní algoritmus"

#: sys-utils/zramctl.c:80
msgid "number of concurrent compress operations"
msgstr "počet souběžných kompresních operací"

#: sys-utils/zramctl.c:81
msgid "empty pages with no allocated memory"
msgstr "prázdné stránky bez alokované paměti"

#: sys-utils/zramctl.c:82
msgid "all memory including allocator fragmentation and metadata overhead"
msgstr "veškerá paměť včetně fragmentace alokátoru a režie metadat"

#: sys-utils/zramctl.c:83
msgid "memory limit used to store compressed data"
msgstr "omezení paměti použito na uložení komprimovaných dat"

# ??? This is not English
#: sys-utils/zramctl.c:84
msgid "memory zram have been consumed to store compressed data"
msgstr "zram paměť vypotřebována na uložení komprimovaných dat"

#: sys-utils/zramctl.c:85
msgid "number of objects migrated by compaction"
msgstr "počet objektů přestěhovaných při slučování"

#: sys-utils/zramctl.c:378
msgid "Failed to parse mm_stat"
msgstr "Nepodařilo se rozebrat mm_stat"

#: sys-utils/zramctl.c:541
#, c-format
msgid ""
" %1$s [options] <device>\n"
" %1$s -r <device> [...]\n"
" %1$s [options] -f | <device> -s <size>\n"
msgstr ""
" %1$s [přepínače] <zařízení>\n"
" %1$s -r <zařízení> […]\n"
" %1$s [přepínače] -f | <zařízení> -s <velikost>\n"

#: sys-utils/zramctl.c:547
msgid "Set up and control zram devices.\n"
msgstr "Nastaví a ovládá zram zařízení.\n"

#: sys-utils/zramctl.c:550
msgid " -a, --algorithm lzo|lz4|lz4hc|deflate|842   compression algorithm to use\n"
msgstr ""
" -a, --algorithm lzo|lz4|lz4hc|deflate|842   použije vybraný kompresní\n"
"                                             algoritmus\n"

#: sys-utils/zramctl.c:551
msgid " -b, --bytes               print sizes in bytes rather than in human readable format\n"
msgstr ""
" -b, --bytes               velikosti vypisuje v bajtech namísto v podobě\n"
"                           vhodné pro člověka\n"

#: sys-utils/zramctl.c:552
msgid " -f, --find                find a free device\n"
msgstr " -f, --find                najde volné zařízení\n"

#: sys-utils/zramctl.c:553
msgid " -n, --noheadings          don't print headings\n"
msgstr " -n, --noheadings          nevypíše záhlaví\n"

#: sys-utils/zramctl.c:554
msgid " -o, --output <list>       columns to use for status output\n"
msgstr " -o, --output <seznam>     určuje, které výstupní sloupce se použijí\n"

#: sys-utils/zramctl.c:555
msgid "     --output-all          output all columns\n"
msgstr "     --output-all          vypíše všechny sloupce\n"

#: sys-utils/zramctl.c:556
msgid "     --raw                 use raw status output format\n"
msgstr "     --raw                 neformátovaný výstup stavu\n"

#: sys-utils/zramctl.c:557
msgid " -r, --reset               reset all specified devices\n"
msgstr " -r, --reset               resetuje všechna zadaná zařízení\n"

#: sys-utils/zramctl.c:558
msgid " -s, --size <size>         device size\n"
msgstr " -s, --size <velikost>     velikost zařízení\n"

#: sys-utils/zramctl.c:559
msgid " -t, --streams <number>    number of compression streams\n"
msgstr " -t, --streams <počet>     počet kompresních proudů\n"

#: sys-utils/zramctl.c:654
msgid "failed to parse streams"
msgstr "proudy se nepodařilo rozebrat"

#: sys-utils/zramctl.c:676
msgid "option --find is mutually exclusive with <device>"
msgstr "přepínač --find a <zařízení> se vzájemně vylučují"

#: sys-utils/zramctl.c:682
msgid "only one <device> at a time is allowed"
msgstr "současně lze zadat pouze jedno <zařízení>"

#: sys-utils/zramctl.c:685
msgid "options --algorithm and --streams must be combined with --size"
msgstr "přepínače --algorithm a --streams musí být použity se --size"

#: sys-utils/zramctl.c:718 sys-utils/zramctl.c:747
#, c-format
msgid "%s: failed to reset"
msgstr "%s: reset se nezdařil"

#: sys-utils/zramctl.c:729 sys-utils/zramctl.c:737
msgid "no free zram device found"
msgstr "nenalezeno žádné volné zram zařízení"

#: sys-utils/zramctl.c:751
#, c-format
msgid "%s: failed to set number of streams"
msgstr "%s: nezdařilo se nastavit počet proudů"

#: sys-utils/zramctl.c:755
#, c-format
msgid "%s: failed to set algorithm"
msgstr "%s: nezdařilo se nastavit algoritmus"

# TODO: pluralize
#: sys-utils/zramctl.c:758
#, c-format
msgid "%s: failed to set disksize (%ju bytes)"
msgstr "%s: nezdařilo se nastavit velikost disku (%'ju bajtů)"

#: term-utils/agetty.c:492
#, c-format
msgid "%s%s (automatic login)\n"
msgstr "%s%s (automatické přihlášení)\n"

#: term-utils/agetty.c:549
#, c-format
msgid "%s: can't change root directory %s: %m"
msgstr "%s: nelze změnit kořenový adresář %s: %m"

#: term-utils/agetty.c:552
#, c-format
msgid "%s: can't change working directory %s: %m"
msgstr "%s: nelze změnit pracovního adresáře %s: %m"

#: term-utils/agetty.c:555
#, c-format
msgid "%s: can't change process priority: %m"
msgstr "%s: nelze změnit prioritu procesu: %m"

#: term-utils/agetty.c:566
#, c-format
msgid "%s: can't exec %s: %m"
msgstr "%s: %s nelze spustit: %m"

#: term-utils/agetty.c:597 term-utils/agetty.c:935 term-utils/agetty.c:1479
#: term-utils/agetty.c:1497 term-utils/agetty.c:1534 term-utils/agetty.c:1544
#: term-utils/agetty.c:1586 term-utils/agetty.c:1947 term-utils/agetty.c:2303
#: term-utils/agetty.c:2864
#, c-format
msgid "failed to allocate memory: %m"
msgstr "paměť nelze alokovat: %m"

#: term-utils/agetty.c:774
msgid "invalid delay argument"
msgstr "neplatný argument zpoždění"

#: term-utils/agetty.c:812
msgid "invalid argument of --local-line"
msgstr "neplatný argument přepínače --local-line"

#: term-utils/agetty.c:831
msgid "invalid nice argument"
msgstr "neplatný argument přepínače --nice"

#: term-utils/agetty.c:940
#, c-format
msgid "bad speed: %s"
msgstr "chybná rychlost %s"

#: term-utils/agetty.c:942
msgid "too many alternate speeds"
msgstr "příliš mnoho alternativních rychlostí"

#: term-utils/agetty.c:1049 term-utils/agetty.c:1053 term-utils/agetty.c:1106
#, c-format
msgid "/dev/%s: cannot open as standard input: %m"
msgstr "/dev/%s nelze otevřít jako standardní vstup: %m"

#: term-utils/agetty.c:1072
#, c-format
msgid "/dev/%s: not a character device"
msgstr "/dev/%s není znakovým zařízením"

#: term-utils/agetty.c:1074
#, c-format
msgid "/dev/%s: not a tty"
msgstr "/dev/%s: není TTY"

#: term-utils/agetty.c:1078 term-utils/agetty.c:1110
#, c-format
msgid "/dev/%s: cannot get controlling tty: %m"
msgstr "/dev/%s: nelze získat řídicí TTY: %m"

#: term-utils/agetty.c:1100
#, c-format
msgid "/dev/%s: vhangup() failed: %m"
msgstr "/dev/%s: volání vhangup() selhalo: %m"

#: term-utils/agetty.c:1121
#, c-format
msgid "%s: not open for read/write"
msgstr "%s: není otevřeno pro čtení/zápis"

#: term-utils/agetty.c:1126
#, c-format
msgid "/dev/%s: cannot set process group: %m"
msgstr "/dev/%s: nelze nastavit skupinu procesu: %m"

#: term-utils/agetty.c:1140
#, c-format
msgid "%s: dup problem: %m"
msgstr "%s: volání dup selhalo: %m"

#: term-utils/agetty.c:1157
#, c-format
msgid "%s: failed to get terminal attributes: %m"
msgstr "%s: nelze zjistit vlastnosti terminálu: %m"

#: term-utils/agetty.c:1376 term-utils/agetty.c:1405
#, c-format
msgid "setting terminal attributes failed: %m"
msgstr "vlastnosti terminálu nelze nastavit: %m"

#: term-utils/agetty.c:1524
msgid "cannot open os-release file"
msgstr "soubor os-release nelze otevřít"

#: term-utils/agetty.c:1691
#, c-format
msgid "failed to create reload file: %s: %m"
msgstr "vytvoření souboru pro opětovné zavedení selhalo: %s: %m"

#: term-utils/agetty.c:2011
#, c-format
msgid "failed to get terminal attributes: %m"
msgstr "nelze zjistit vlastnosti terminálu: %m"

#: term-utils/agetty.c:2033
msgid "[press ENTER to login]"
msgstr "[pro přihlášení stiskněte ENTER]"

#: term-utils/agetty.c:2060
msgid "Num Lock off"
msgstr "Num Lock vypnut"

#: term-utils/agetty.c:2063
msgid "Num Lock on"
msgstr "Num Lock zapnut"

#: term-utils/agetty.c:2066
msgid "Caps Lock on"
msgstr "Caps Lock zapnut"

#: term-utils/agetty.c:2069
msgid "Scroll Lock on"
msgstr "Scroll Lock zapnut"

#: term-utils/agetty.c:2072
#, c-format
msgid ""
"Hint: %s\n"
"\n"
msgstr ""
"Nápověda: %s\n"
"\n"

#: term-utils/agetty.c:2214
#, c-format
msgid "%s: read: %m"
msgstr "%s: přečteno: %m"

#: term-utils/agetty.c:2279
#, c-format
msgid "%s: input overrun"
msgstr "%s: přetečení vstupu"

#: term-utils/agetty.c:2299 term-utils/agetty.c:2307
#, c-format
msgid "%s: invalid character conversion for login name"
msgstr "%s: chyba při převodu znaku v přihlašovacím jméně"

#: term-utils/agetty.c:2313
#, c-format
msgid "%s: invalid character 0x%x in login name"
msgstr "%s: neplatný znak 0x%x v přihlašovacím jméně"

#: term-utils/agetty.c:2398
#, c-format
msgid "%s: failed to set terminal attributes: %m"
msgstr "%s: vlastnosti terminálu nelze nastavit: %m"

#: term-utils/agetty.c:2436
#, c-format
msgid ""
" %1$s [options] <line> [<baud_rate>,...] [<termtype>]\n"
" %1$s [options] <baud_rate>,... <line> [<termtype>]\n"
msgstr ""
" %1$s [přepínače] <linka> [<baud_rate>,…] [<druh_terminálu>]\n"
" %1$s [přepínače] <baud_rate>,… <linka> [<druh_terminálu>]\n"

#: term-utils/agetty.c:2440
msgid "Open a terminal and set its mode.\n"
msgstr "Otevře terminál a nastaví jeho režim.\n"

#: term-utils/agetty.c:2443
msgid " -8, --8bits                assume 8-bit tty\n"
msgstr " -8, --8bits                předpokládá 8bitové TTY\n"

#: term-utils/agetty.c:2444
msgid " -a, --autologin <user>     login the specified user automatically\n"
msgstr " -a, --autologin <uživatel> automaticky přihlásí zadaného uživatele\n"

#: term-utils/agetty.c:2445
msgid " -c, --noreset              do not reset control mode\n"
msgstr " -c, --noreset              neresetuje řídicí režim\n"

#: term-utils/agetty.c:2446
msgid " -E, --remote               use -r <hostname> for login(1)\n"
msgstr " -E, --remote               programu login(1) předá -r <název_stroje>\n"

#: term-utils/agetty.c:2447
#, fuzzy
msgid " -f, --issue-file <list>    display issue files or directories\n"
msgstr " -f, --issue-file <soubor>  zobrazí soubor s vydáním\n"

#: term-utils/agetty.c:2448
msgid "     --show-issue           display issue file and exit\n"
msgstr "     --show-issue           zobrazí soubor s vydáním a skončí\n"

#: term-utils/agetty.c:2449
msgid " -h, --flow-control         enable hardware flow control\n"
msgstr " -h, --flow-control         povolí hardwarové řízení toku\n"

#: term-utils/agetty.c:2450
msgid " -H, --host <hostname>      specify login host\n"
msgstr " -H, --host <název_stroje>  určí název stroje při přihlášení\n"

#: term-utils/agetty.c:2451
msgid " -i, --noissue              do not display issue file\n"
msgstr " -i, --noissue              nezobrazí soubor s vydáním\n"

#: term-utils/agetty.c:2452
msgid " -I, --init-string <string> set init string\n"
msgstr ""
" -I, --init-string <řetězec>\n"
"                            nastaví inicializační řetězec\n"

# FIXME: Missing comma
#: term-utils/agetty.c:2453
msgid " -J  --noclear              do not clear the screen before prompt\n"
msgstr " -J, --noclear              před výzvou nesmaže obrazovku\n"

#: term-utils/agetty.c:2454
msgid " -l, --login-program <file> specify login program\n"
msgstr ""
" -l, --login-program <soubor>\n"
"                            určí program login\n"

#: term-utils/agetty.c:2455
msgid " -L, --local-line[=<mode>]  control the local line flag\n"
msgstr " -L, --local-line[=<režim>] řídí příznak místní linky\n"

#: term-utils/agetty.c:2456
msgid " -m, --extract-baud         extract baud rate during connect\n"
msgstr " -m, --extract-baud         získá baud rate z připojující se fáze\n"

#: term-utils/agetty.c:2457
msgid " -n, --skip-login           do not prompt for login\n"
msgstr " -n, --skip-login           neptá se na přihlašovací jméno\n"

# FIXME: Missing comma
#: term-utils/agetty.c:2458
msgid " -N  --nonewline            do not print a newline before issue\n"
msgstr " -N, --nonewline            neodřádkuje před výpisem vydání\n"

#: term-utils/agetty.c:2459
msgid " -o, --login-options <opts> options that are passed to login\n"
msgstr ""
" -o, --login-options <argumenty>\n"
"                            argumenty, které budou předány programu login\n"

#: term-utils/agetty.c:2460
msgid " -p, --login-pause          wait for any key before the login\n"
msgstr " -p, --login-pause          před výzvou k přihlášení počká na stisk klávesy\n"

#: term-utils/agetty.c:2461
msgid " -r, --chroot <dir>         change root to the directory\n"
msgstr " -r, --chroot <adresář>     změní kořenový adresář na zadaný\n"

#: term-utils/agetty.c:2462
msgid " -R, --hangup               do virtually hangup on the tty\n"
msgstr " -R, --hangup               provede virtuální zavěšení linky na TTY\n"

#: term-utils/agetty.c:2463
msgid " -s, --keep-baud            try to keep baud rate after break\n"
msgstr " -s, --keep-baud            pokusí se udržet baud rate i po znaku break\n"

#: term-utils/agetty.c:2464
msgid " -t, --timeout <number>     login process timeout\n"
msgstr " -t, --timeout <číslo>      časový limit pro přihlášení\n"

#: term-utils/agetty.c:2465
msgid " -U, --detect-case          detect uppercase terminal\n"
msgstr " -U, --detect-case          rozpozná terminál podporující jen velká písmena\n"

#: term-utils/agetty.c:2466
msgid " -w, --wait-cr              wait carriage-return\n"
msgstr " -w, --wait-cr              čeká na carriage-return\n"

#: term-utils/agetty.c:2467
msgid "     --nohints              do not print hints\n"
msgstr "     --nohints              nezobrazí upozornění\n"

#: term-utils/agetty.c:2468
msgid "     --nohostname           no hostname at all will be shown\n"
msgstr "     --nohostname           nezobrazí název stroje\n"

#: term-utils/agetty.c:2469
msgid "     --long-hostname        show full qualified hostname\n"
msgstr "     --long-hostname        zobrazí plně kvalifikované jméno stroje\n"

#: term-utils/agetty.c:2470
msgid "     --erase-chars <string> additional backspace chars\n"
msgstr ""
"     --erase-chars <řetězec>\n"
"                            další znaky fungující jako backspace\n"

#: term-utils/agetty.c:2471
msgid "     --kill-chars <string>  additional kill chars\n"
msgstr "     --kill-chars <řetězec> další znaky, které mažou celý řádek\n"

#: term-utils/agetty.c:2472
msgid "     --chdir <directory>    chdir before the login\n"
msgstr "     --chdir <adresář>      před spuštěním loginu změní pracovní adresář\n"

#: term-utils/agetty.c:2473
msgid "     --delay <number>       sleep seconds before prompt\n"
msgstr "     --delay <počet>        před výzvou počká počet sekund\n"

#: term-utils/agetty.c:2474
msgid "     --nice <number>        run login with this priority\n"
msgstr "     --nice <číslo>         spustí login s touto prioritou\n"

#: term-utils/agetty.c:2475
msgid "     --reload               reload prompts on running agetty instances\n"
msgstr "     --reload               běžící instance agetty znovu načtou výzvy\n"

#: term-utils/agetty.c:2476
msgid "     --list-speeds          display supported baud rates\n"
msgstr "     --list-speeds          vypíše podporované rychlosti baud rate\n"

#: term-utils/agetty.c:2821
#, c-format
msgid "%d user"
msgid_plural "%d users"
msgstr[0] "%d uživatel"
msgstr[1] "%d uživatelé"
msgstr[2] "%d uživatelů"

#: term-utils/agetty.c:2952
#, c-format
msgid "checkname failed: %m"
msgstr "kontrola jména neuspěla: %m"

#: term-utils/agetty.c:2964
#, c-format
msgid "cannot touch file %s"
msgstr "souboru %s nelze změnit časové razítko"

#: term-utils/agetty.c:2968
msgid "--reload is unsupported on your system"
msgstr "přepínač --reload není na vašem systému podporován"

#: term-utils/mesg.c:78
#, c-format
msgid " %s [options] [y | n]\n"
msgstr " %s [přepínače] [y | n]\n"

#: term-utils/mesg.c:81
msgid "Control write access of other users to your terminal.\n"
msgstr "Řídí přístup pro zápis do vašeho terminálu ostatním uživatelům.\n"

#: term-utils/mesg.c:84
msgid " -v, --verbose  explain what is being done\n"
msgstr " -v, --verbose  vysvětlí, co se děje\n"

#: term-utils/mesg.c:130
msgid "no tty"
msgstr "žádné TTY"

#: term-utils/mesg.c:139
#, c-format
msgid "ttyname() failed, attempting to go around using: %s"
msgstr "funkce ttyname() selhala, místo toho se zkusí: %s"

#: term-utils/mesg.c:150
msgid "is y"
msgstr "Příjem zpráv je zapnut"

#: term-utils/mesg.c:153
msgid "is n"
msgstr "Příjem zpráv je vypnut"

#: term-utils/mesg.c:164 term-utils/mesg.c:171
#, c-format
msgid "change %s mode failed"
msgstr "změnit režim %s se nepodařilo"

#: term-utils/mesg.c:166
msgid "write access to your terminal is allowed"
msgstr "přístup pro zápis do vašeho terminálu je povolen"

#: term-utils/mesg.c:173
msgid "write access to your terminal is denied"
msgstr "přístup pro zápis do vašeho terminálu je zakázán"

#: term-utils/script.c:190
#, c-format
msgid " %s [options] [file]\n"
msgstr " %s [přepínače] [soubor]\n"

#: term-utils/script.c:193
msgid "Make a typescript of a terminal session.\n"
msgstr "Zaznamená, co se dělo v relaci s terminálem.\n"

#: term-utils/script.c:196
msgid " -I, --log-in <file>           log stdin to file\n"
msgstr " -I, --log-in <soubor>         zaznamená obsah standardního vstupu do souboru\n"

#: term-utils/script.c:197
msgid " -O, --log-out <file>          log stdout to file (default)\n"
msgstr ""
" -O, --log-out <soubor>        zaznamená obsah standardního výstupu do souboru\n"
"                               (výchozí)\n"

#: term-utils/script.c:198
msgid " -B, --log-io <file>           log stdin and stdout to file\n"
msgstr ""
" -B, --log-io <soubor>         zaznamená obsah standardního vstupu a výstupu\n"
"                               do souboru\n"

#: term-utils/script.c:201
msgid " -T, --log-timing <file>       log timing information to file\n"
msgstr " -T, --log-timing <soubor>     zaznamená časové údaje do souboru\n"

#: term-utils/script.c:202
msgid " -t[<file>], --timing[=<file>] deprecated alias to -T (default file is stderr)\n"
msgstr ""
" -t[<soubor>], --timing[=<soubor>]\n"
"                               zastaralý alias pro -T (výchozí soubor je\n"
"                               standardní chybový výstup)\n"

#: term-utils/script.c:203
msgid " -m, --logging-format <name>   force to 'classic' or 'advanced' format\n"
msgstr ""
" -m, --logging-format <název>  vynutí „classic“ (klasický) nebo „advanced“\n"
"                               (pokročilý) formát\n"

#: term-utils/script.c:206
msgid " -a, --append                  append to the log file\n"
msgstr " -a, --append                  připojí k souboru s protokolem\n"

#: term-utils/script.c:207
msgid " -c, --command <command>       run command rather than interactive shell\n"
msgstr " -c, --command <příkaz>        spustí příkaz namísto interaktivního shellu\n"

#: term-utils/script.c:208
msgid " -e, --return                  return exit code of the child process\n"
msgstr " -e, --return                  vrátí návratový kód procesu potomka\n"

#: term-utils/script.c:209
msgid " -f, --flush                   run flush after each write\n"
msgstr " -f, --flush                   vyprázdní buffery po každém zápisu\n"

#: term-utils/script.c:210
msgid "     --force                   use output file even when it is a link\n"
msgstr "     --force                   použije výstupní soubor i když se jedná o odkaz\n"

#: term-utils/script.c:211
msgid " -E, --echo <when>             echo input (auto, always or never)\n"
msgstr ""
" -E, --echo <kdy>              opisuje výstup (auto, always [vždy],\n"
"                               never [nikdy])\n"

#: term-utils/script.c:212
msgid " -o, --output-limit <size>     terminate if output files exceed size\n"
msgstr ""
" -o, --output-limit <velikost>\n"
"                               skončí, když výstupní soubor překročí velikost\n"

#: term-utils/script.c:213
msgid " -q, --quiet                   be quiet\n"
msgstr " -q, --quiet                   je potichu\n"

#: term-utils/script.c:296
#, c-format
msgid ""
"\n"
"Script done on %s [<%s>]\n"
msgstr ""
"\n"
"Script ukončen v %s [<%s>]\n"

#: term-utils/script.c:298
#, c-format
msgid ""
"\n"
"Script done on %s [COMMAND_EXIT_CODE=\"%d\"]\n"
msgstr ""
"\n"
"Script ukončen v %s [NÁVRATOVÝ_KÓD_PŘÍKAZU=„%d“]\n"

# The argument is a full date-time
#: term-utils/script.c:394
#, c-format
msgid "Script started on %s ["
msgstr "Script spuštěn v %s ["

#: term-utils/script.c:406
#, c-format
msgid "<not executed on terminal>"
msgstr "<nespuštěn na terminálu>"

#: term-utils/script.c:680
#, c-format
msgid "Script terminated, max output files size %<PRIu64> exceeded.\n"
msgstr "Skript ukončen, překročena maximální velikost výstupního souboru %<PRIu64>.\n"

#: term-utils/script.c:682
msgid "max output size exceeded"
msgstr "maximální velikost výstupu překročena"

#: term-utils/script.c:743
#, c-format
msgid ""
"output file `%s' is a link\n"
"Use --force if you really want to use it.\n"
"Program not started."
msgstr ""
"výstupní soubor „%s“ je odkaz.\n"
"Pokud jej opravdu chcete použít, tak použije --force.\n"
"Program nebyl spuštěn."

#: term-utils/script.c:827
#, c-format
msgid "unssuported echo mode: '%s'"
msgstr "nepodporovaný režim opisování: „%s“"

#: term-utils/script.c:852
msgid "failed to parse output limit size"
msgstr "nezdařilo se rozebrat omezení velikosti výstupu"

#: term-utils/script.c:863
#, fuzzy, c-format
msgid "unsupported logging format: '%s'"
msgstr "nepodporovaný formát protokolování: „%s“"

#: term-utils/script.c:907
msgid "log multiple streams is mutually exclusive with 'classic' format"
msgstr "zaznamenávání více proudů se vylučuje s formátem „classic“"

#: term-utils/script.c:934
#, c-format
msgid "Script started"
msgstr "Script spuštěn"

#: term-utils/script.c:936
#, c-format
msgid ", output log file is '%s'"
msgstr ", protokol s výstupem je „%s“"

#: term-utils/script.c:938
#, c-format
msgid ", input log file is '%s'"
msgstr ", protokol se vstupem je „%s“"

#: term-utils/script.c:940
#, c-format
msgid ", timing file is '%s'"
msgstr ", protokol s časy je „%s“"

#: term-utils/script.c:941
#, c-format
msgid ".\n"
msgstr ".\n"

#: term-utils/script.c:1047
#, c-format
msgid "Script done.\n"
msgstr "Script ukončen.\n"

#: term-utils/scriptlive.c:60
#, c-format
msgid " %s [-t] timingfile [-I|-B] typescript\n"
msgstr "%s [-t] časový_soubor [-I|-B záznam_textu]\n"

#: term-utils/scriptlive.c:64
msgid "Execute terminal typescript.\n"
msgstr "Předvede záznam textu z terminálu.\n"

#: term-utils/scriptlive.c:67 term-utils/scriptreplay.c:56
msgid " -t, --timing <file>     script timing log file\n"
msgstr " -t, --timing <soubor>   soubor s časováním scriptu\n"

#: term-utils/scriptlive.c:68 term-utils/scriptreplay.c:57
msgid " -T, --log-timing <file> alias to -t\n"
msgstr ""
" -T, --log-timing <soubor>\n"
"                         stejné jako -t\n"

#: term-utils/scriptlive.c:69 term-utils/scriptreplay.c:58
msgid " -I, --log-in <file>     script stdin log file\n"
msgstr " -I, --log-in <soubor>   soubor scriptu se záznamem standardního vstupu\n"

#: term-utils/scriptlive.c:70 term-utils/scriptreplay.c:60
msgid " -B, --log-io <file>     script stdin and stdout log file\n"
msgstr ""
" -B, --log-io <soubor>   soubor scriptu se záznamem standardní vstupu a\n"
"                         výstupu\n"

#: term-utils/scriptlive.c:73
msgid " -c, --command <command> run command rather than interactive shell\n"
msgstr " -c, --command <příkaz>  spustí příkaz namísto interaktivního shellu\n"

#: term-utils/scriptlive.c:74 term-utils/scriptreplay.c:66
msgid " -d, --divisor <num>     speed up or slow down execution with time divisor\n"
msgstr " -d, --divisor <číslo>   zrychlí nebo zpomalí vykonávání podle dělitele času\n"

#: term-utils/scriptlive.c:75 term-utils/scriptreplay.c:67
msgid " -m, --maxdelay <num>    wait at most this many seconds between updates\n"
msgstr " -m, --maxdelay <počet>  počká nejvíce tolik sekund mezi aktualizacemi\n"

#: term-utils/scriptlive.c:226 term-utils/scriptreplay.c:212
msgid "failed to parse maximal delay argument"
msgstr "argument s maximálním zpozdění se nepodařilo rozebrat"

#: term-utils/scriptlive.c:249 term-utils/scriptreplay.c:253
msgid "timing file not specified"
msgstr "nezadán žádný soubor s časováním"

#: term-utils/scriptlive.c:251
msgid "stdin typescript file not specified"
msgstr "nezadán žádný vstupní soubor se záznamem textu"

#: term-utils/scriptlive.c:277
#, c-format
msgid ">>> scriptlive: Starting your typescript execution by %s.\n"
msgstr ">>> scriptlive: Začíná prezentace vašeho záznamu textu %s.\n"

#: term-utils/scriptlive.c:284
msgid "failed to allocate PTY handler"
msgstr "alokace deskriptoru pseudoterminálu selhala"

#: term-utils/scriptlive.c:363
#, c-format
msgid ""
"\n"
">>> scriptlive: done.\n"
msgstr ""
"\n"
">>> scriptlive: hotovo.\n"

#: term-utils/scriptreplay.c:49
#, c-format
msgid " %s [-t] timingfile [typescript] [divisor]\n"
msgstr "%s [-t] časový_soubor [záznam_vstupu] [dělitel]\n"

#: term-utils/scriptreplay.c:53
msgid "Play back terminal typescripts, using timing information.\n"
msgstr "Přehraje záznam dění na terminálu pomocí údajů o časování.\n"

#: term-utils/scriptreplay.c:59
msgid " -O, --log-out <file>    script stdout log file (default)\n"
msgstr ""
" -O, --log-out <soubor>  soubor ze záznamem standardního výstupu scriptu\n"
"                         (výchozí)\n"

#: term-utils/scriptreplay.c:62
msgid " -s, --typescript <file> deprecated alias to -O\n"
msgstr ""
" -s, --typescript <soubor>\n"
"                         zastaralý alias pro -O\n"

#: term-utils/scriptreplay.c:65
msgid "     --summary           display overview about recorded session and exit\n"
msgstr "     --summary           zobrazí údaje o zaznamenané relaci a skončí\n"

#: term-utils/scriptreplay.c:68
msgid " -x, --stream <name>     stream type (out, in, signal or info)\n"
msgstr ""
" -x, --stream <název>    druh proudu (out [výstup], in [vstup],\n"
"                         signal [signál], info)\n"

#: term-utils/scriptreplay.c:69
msgid " -c, --cr-mode <type>    CR char mode (auto, never, always)\n"
msgstr "-c, --cr-mode <druh>     režim znaku CR (auto, never [nikdy], always [vždy])\n"

#: term-utils/scriptreplay.c:191
#, c-format
msgid "unsupported mode name: '%s'"
msgstr "nepodporovaný název režimu: „%s“"

#: term-utils/scriptreplay.c:224
#, c-format
msgid "unsupported stream name: '%s'"
msgstr "nepodporovaný název proudu: %s"

#: term-utils/scriptreplay.c:255
msgid "data log file not specified"
msgstr "nezadán žádný soubor se záznamem dat"

#: term-utils/scriptreplay.c:304
#, c-format
msgid "%s: log file error"
msgstr "%s: chyba v souboru se záznamem"

#: term-utils/scriptreplay.c:306
#, c-format
msgid "%s: line %d: timing file error"
msgstr "%s: řádek %d: chyba v souboru s časováním"

#: term-utils/setterm.c:237
#, c-format
msgid "argument error: bright %s is not supported"
msgstr "chyba argumentu: světlost %s není nepodporována"

#: term-utils/setterm.c:328
msgid "too many tabs"
msgstr "příliš mnoho tabulátorů"

#: term-utils/setterm.c:384
msgid "Set the attributes of a terminal.\n"
msgstr "Nastaví vlastnosti terminálu.\n"

#: term-utils/setterm.c:387
msgid " --term <terminal_name>        override TERM environment variable\n"
msgstr " --term <název terminálu>      přebije proměnnou prostředí TERM\n"

#: term-utils/setterm.c:388
msgid " --reset                       reset terminal to power-on state\n"
msgstr " --reset                       resetuje terminál do výchozího stavu\n"

#: term-utils/setterm.c:389
msgid " --resize                      reset terminal rows and columns\n"
msgstr " --resize                      resetuje řádky a sloupce terminálu\n"

#: term-utils/setterm.c:390
msgid " --initialize                  display init string, and use default settings\n"
msgstr ""
" --initialize                  zobrazí inicializační řetězec a použije výchozí\n"
"                               nastavení\n"

#: term-utils/setterm.c:391
msgid " --default                     use default terminal settings\n"
msgstr " --default                     použije výchozí nastavení terminálu\n"

#: term-utils/setterm.c:392
msgid " --store                       save current terminal settings as default\n"
msgstr " --store                       uloží současné nastavení terminálu jako výchozí\n"

#: term-utils/setterm.c:395
msgid " --cursor on|off               display cursor\n"
msgstr " --cursor on|off               zapne (on) / vypne (off) zobrazení kurzoru\n"

#: term-utils/setterm.c:396
msgid " --repeat on|off               keyboard repeat\n"
msgstr "--repeat on|off                opakování klávesnice\n"

#: term-utils/setterm.c:397
msgid " --appcursorkeys on|off        cursor key application mode\n"
msgstr " --appcursorkeys on|off        režim aplikace kurzorových kláves\n"

#: term-utils/setterm.c:398
msgid " --linewrap on|off             continue on a new line when a line is full\n"
msgstr " --linewrap on|off             pokračuje na dalším řádku, když řádek je plný\n"

#: term-utils/setterm.c:399
msgid " --inversescreen on|off        swap colors for the whole screen\n"
msgstr " --inversescreen on|off        prohodí barvy na celé obrazovce\n"

#: term-utils/setterm.c:402
msgid " --msg on|off                  send kernel messages to console\n"
msgstr " --msg on|off                  hlášení jádra odesílá na konzolu\n"

#: term-utils/setterm.c:403
msgid " --msglevel <0-8>              kernel console log level\n"
msgstr " --msglevel <0–8>              úroveň protokolu jaderné konzole\n"

#: term-utils/setterm.c:406
msgid " --foreground default|<color>  set foreground color\n"
msgstr " --foreground default|<barva>  nastaví barvu popředí („default“ je výchozí)\n"

#: term-utils/setterm.c:407
msgid " --background default|<color>  set background color\n"
msgstr " --background default|<barva>  nastaví barvu pozadí\n"

#: term-utils/setterm.c:408
msgid " --ulcolor [bright] <color>    set underlined text color\n"
msgstr " --ulcolor [jas] <barva>       nastaví barvu podtrženého textu\n"

#: term-utils/setterm.c:409
msgid " --hbcolor [bright] <color>    set half-bright text color\n"
msgstr " --hbcolor [bright] <barva>    nastaví polojasnou barvu textu\n"

#: term-utils/setterm.c:410
msgid "        <color>: black blue cyan green grey magenta red white yellow\n"
msgstr ""
"        <barva>: black (černá), blue (modrá), cyan (azurová), green (zelená),\n"
"                 grey (šedivá), magenta (purpurová), red (červená),\n"
"                 white (bílá), yellow (žlutá)\n"

#: term-utils/setterm.c:413
msgid " --bold on|off                 bold\n"
msgstr " --bold on|off                 tučnost\n"

#: term-utils/setterm.c:414
msgid " --half-bright on|off          dim\n"
msgstr " --half-bright on|off          temnost\n"

#: term-utils/setterm.c:415
msgid " --blink on|off                blink\n"
msgstr " --blink on|off                blikání\n"

#: term-utils/setterm.c:416
msgid " --underline on|off            underline\n"
msgstr " --underline on|off            podtržení\n"

#: term-utils/setterm.c:417
msgid " --reverse  on|off             swap foreground and background colors\n"
msgstr " --reverse on|off              prohodí barvy popředí a pozadí\n"

#: term-utils/setterm.c:420
msgid " --clear[=<all|rest>]          clear screen and set cursor position\n"
msgstr ""
" --clear[=<all|rest>]          smaže obrazovku a nastaví polohu kurzoru:\n"
"                               all (vše), rest (zbytek)\n"

#: term-utils/setterm.c:421
msgid " --tabs[=<number>...]          set these tab stop positions, or show them\n"
msgstr " --tabs[=<číslo>…]             nastaví tyto tabulátorové zarážky nebo je zobrazí\n"

#: term-utils/setterm.c:422
msgid " --clrtabs[=<number>...]       clear these tab stop positions, or all\n"
msgstr " --clrtabs[=<číslo>…]          odstraní tyto nebo všechny tabulátorové zarážky\n"

#: term-utils/setterm.c:423
msgid " --regtabs[=1-160]             set a regular tab stop interval\n"
msgstr ""
" --regtabs[=1–160]             nastaví pravidelný rozestup tabulátorových\n"
"                               zarážek\n"

#: term-utils/setterm.c:424
msgid " --blank[=0-60|force|poke]     set time of inactivity before screen blanks\n"
msgstr ""
" --blank[=0–60|force|poke]     nastaví dobu nečinnosti nutnou pro potemnění\n"
"                               obrazovky\n"

#: term-utils/setterm.c:427
msgid " --dump[=<number>]             write vcsa<number> console dump to file\n"
msgstr " --dump[=<číslo>]              zapíše obsah konzoly vcsa<číslo> do souboru\n"

#: term-utils/setterm.c:428
msgid " --append <number>             append vcsa<number> console dump to file\n"
msgstr " --append [<číslo>]            připojí obsah konzoly vcsa<číslo> do souboru\n"

#: term-utils/setterm.c:429
msgid " --file <filename>             name of the dump file\n"
msgstr " --file <soubor>               název výstupního souboru\n"

#: term-utils/setterm.c:432
msgid " --powersave on|vsync|hsync|powerdown|off\n"
msgstr " --powersave on|vsync|hsync|powerdown|off\n"

#: term-utils/setterm.c:433
msgid "                               set vesa powersaving features\n"
msgstr "                               nastavení šetření energií VESA\n"

#: term-utils/setterm.c:434
msgid " --powerdown[=<0-60>]          set vesa powerdown interval in minutes\n"
msgstr ""
" --powerdown[=<0–60>]          nastaví interval v minutách pro VESA režim\n"
"                               powerdown\n"

#: term-utils/setterm.c:437
msgid " --blength[=<0-2000>]          duration of the bell in milliseconds\n"
msgstr " --blength[=<0–2000>]          délka zvonku v milisekundách\n"

#: term-utils/setterm.c:438
msgid " --bfreq[=<number>]            bell frequency in Hertz\n"
msgstr " --bfreq[=<číslo>]             frekvence zvonku v hertzích\n"

#: term-utils/setterm.c:451
msgid "duplicate use of an option"
msgstr "vícekrát použitý přepínač"

#: term-utils/setterm.c:763
msgid "cannot force blank"
msgstr "režim blank nelze vynutit"

#: term-utils/setterm.c:768
msgid "cannot force unblank"
msgstr "režim unblank nelze vynutit"

#: term-utils/setterm.c:774
msgid "cannot get blank status"
msgstr "stav režimu blank nelze zjistit"

#: term-utils/setterm.c:799
#, c-format
msgid "cannot open dump file %s for output"
msgstr "soubor s obsahem obrazovky %s nelze otevřít pro zápis"

#: term-utils/setterm.c:840
#, c-format
msgid "terminal %s does not support %s"
msgstr "terminál %s nepodporuje %s"

#: term-utils/setterm.c:878
msgid "select failed"
msgstr "volání select selhalo"

#: term-utils/setterm.c:904
msgid "stdin does not refer to a terminal"
msgstr "standardní vstup neodkazuje na terminál"

#: term-utils/setterm.c:932
#, c-format
msgid "invalid cursor position: %s"
msgstr "neplatná poloha kurzoru: %s"

#: term-utils/setterm.c:954
msgid "reset failed"
msgstr "reset selhal"

#: term-utils/setterm.c:1118
msgid "cannot (un)set powersave mode"
msgstr "šetřicí režim nelze vypnout/zapnout"

#: term-utils/setterm.c:1137 term-utils/setterm.c:1146
msgid "klogctl error"
msgstr "chyba klogctl"

#: term-utils/setterm.c:1167
msgid "$TERM is not defined."
msgstr "Proměnná TERM není nastavena."

#: term-utils/setterm.c:1174
msgid "terminfo database cannot be found"
msgstr "databázi terminfo nelze najít"

#: term-utils/setterm.c:1176
#, c-format
msgid "%s: unknown terminal type"
msgstr "%s: neznámý druh terminálu"

#: term-utils/setterm.c:1178
msgid "terminal is hardcopy"
msgstr "terminál je čistě výstupní (hardcopy)"

#: term-utils/ttymsg.c:81
#, c-format
msgid "internal error: too many iov's"
msgstr "vnitřní chyba: příliš mnoho vektorů I/O"

#: term-utils/ttymsg.c:94
#, c-format
msgid "excessively long line arg"
msgstr "příliš dlouhý řádek s argumenty"

#: term-utils/ttymsg.c:108
#, c-format
msgid "open failed"
msgstr "otevření selhalo"

#: term-utils/ttymsg.c:147
#, c-format
msgid "fork: %m"
msgstr "fork: %m"

#: term-utils/ttymsg.c:149
#, c-format
msgid "cannot fork"
msgstr "volání fork selhalo"

#: term-utils/ttymsg.c:182
#, c-format
msgid "%s: BAD ERROR, message is far too long"
msgstr "%s: OŠKLIVÁ CHYBA, zpráva je opravdu moc dlouhá"

#: term-utils/wall.c:88
#, c-format
msgid " %s [options] [<file> | <message>]\n"
msgstr " %s [přepínače] [<soubor> | <zpráva>]\n"

#: term-utils/wall.c:91
msgid "Write a message to all users.\n"
msgstr "Napíše zprávu všem uživatelům.\n"

#: term-utils/wall.c:94
msgid " -g, --group <group>     only send message to group\n"
msgstr " -g, --group <skupina>   pošle zprávu pouze skupině\n"

#: term-utils/wall.c:95
msgid " -n, --nobanner          do not print banner, works only for root\n"
msgstr " -n, --nobanner          nevypíše titulek, funguje jen pro superuživatele\n"

#: term-utils/wall.c:96
msgid " -t, --timeout <timeout> write timeout in seconds\n"
msgstr " -t, --timeout <limit>   časové omezení na zápis v sekundách\n"

#: term-utils/wall.c:124
msgid "invalid group argument"
msgstr "neplatný argument skupiny"

#: term-utils/wall.c:126
#, c-format
msgid "%s: unknown gid"
msgstr "%s: neznámý GID"

#: term-utils/wall.c:169
msgid "getgrouplist found more groups than sysconf allows"
msgstr "funkce getgrouplist nalezla více skupin než dovoluje sysconf"

#: term-utils/wall.c:215
msgid "--nobanner is available only for root"
msgstr "--nobanner je dostupný jen superuživateli"

#: term-utils/wall.c:220
#, c-format
msgid "invalid timeout argument: %s"
msgstr "chybný argument s časovým limitem: %s"

#: term-utils/wall.c:361
msgid "cannot get passwd uid"
msgstr "pro UID nelze získat záznam z databáze uživatelů"

#: term-utils/wall.c:385
#, c-format
msgid "Broadcast message from %s@%s (%s) (%s):"
msgstr "Všeobecná zpráva od %s@%s (%s) (%s):"

#: term-utils/wall.c:417
#, c-format
msgid "will not read %s - use stdin."
msgstr "nebude se číst z %s – použijte standardní vstup."

#: term-utils/write.c:87
#, c-format
msgid " %s [options] <user> [<ttyname>]\n"
msgstr " %s [přepínače] <uživatel> [<název_TTY>]\n"

#: term-utils/write.c:91
msgid "Send a message to another user.\n"
msgstr "Pošle zprávu jinému uživateli.\n"

#: term-utils/write.c:116
#, c-format
msgid "effective gid does not match group of %s"
msgstr "efektivní GID neodpovídá skupině %s"

#: term-utils/write.c:201
#, c-format
msgid "%s is not logged in"
msgstr "uživatel %s není přihlášen"

#: term-utils/write.c:206
msgid "can't find your tty's name"
msgstr "název vašeho TTY nelze zjistit"

#: term-utils/write.c:211
#, c-format
msgid "%s has messages disabled"
msgstr "uživatel %s má vypnut příjem zpráv"

#: term-utils/write.c:214
#, c-format
msgid "%s is logged in more than once; writing to %s"
msgstr "uživatel %s je přihlášen vícekrát; zapíše se na %s"

#: term-utils/write.c:237
msgid "carefulputc failed"
msgstr "funkce carefulputc selhala"

#: term-utils/write.c:279
#, c-format
msgid "Message from %s@%s (as %s) on %s at %02d:%02d ..."
msgstr "Zpráva od %s@%s (jako %s) na %s v %02d.%02d…"

#: term-utils/write.c:283
#, c-format
msgid "Message from %s@%s on %s at %02d:%02d ..."
msgstr "Zpráva od %s@%s na %s v %02d.%02d…"

#: term-utils/write.c:329
msgid "you have write permission turned off"
msgstr "máte vypnut příjem zpráv"

#: term-utils/write.c:352
#, c-format
msgid "%s is not logged in on %s"
msgstr "uživatel %s není na %s přihlášen"

#: term-utils/write.c:358
#, c-format
msgid "%s has messages disabled on %s"
msgstr "uživatel %s má na %s vypnut příjem zpráv"

#: text-utils/col.c:135
msgid "Filter out reverse line feeds.\n"
msgstr "Odstraní znaky pro zpětný posun.\n"

#: text-utils/col.c:138
#, c-format
msgid ""
"\n"
"Options:\n"
" -b, --no-backspaces    do not output backspaces\n"
" -f, --fine             permit forward half line feeds\n"
" -p, --pass             pass unknown control sequences\n"
" -h, --tabs             convert spaces to tabs\n"
" -x, --spaces           convert tabs to spaces\n"
" -l, --lines NUM        buffer at least NUM lines\n"
msgstr ""
"\n"
"Přepínače:\n"
" -b, --no-backspaces    nevypisuje znaky backspaces\n"
" -f, --fine             povolí dopředné půlřádkové posuny\n"
" -p, --pass             propustí neznámé řídicí znaky\n"
" -h, --tabs             mezery převede na tabulátory\n"
" -x, --spaces           tabulátory převede na mezery\n"
" -l, --lines POČET      bufferuje alespoň POČET řádků\n"

#: text-utils/col.c:151 text-utils/colrm.c:69
#, c-format
msgid ""
"%s reads from standard input and writes to standard output\n"
"\n"
msgstr "%s čte ze standardního vstupu a zapisuje na standardní výstup\n"

#: text-utils/col.c:215
msgid "bad -l argument"
msgstr "chybný argument přepínače -l"

#: text-utils/col.c:246
#, c-format
msgid "failed on line %d"
msgstr "selhalo na řádku %d"

#: text-utils/col.c:344
#, c-format
msgid "warning: can't back up %s."
msgstr "pozor: %s nelze zazálohovat."

#: text-utils/col.c:345
msgid "past first line"
msgstr "jsem za prvním řádkem"

#: text-utils/col.c:345
msgid "-- line already flushed"
msgstr "-- řádek již není v bufru"

#: text-utils/colcrt.c:82 text-utils/column.c:626
#, c-format
msgid " %s [options] [<file>...]\n"
msgstr " %s [přepínače] [<soubor…>]\n"

#: text-utils/colcrt.c:85
msgid "Filter nroff output for CRT previewing.\n"
msgstr "Filtruje výstup nroffu pro náhled na CRT.\n"

#: text-utils/colcrt.c:88
msgid " -,  --no-underlining    suppress all underlining\n"
msgstr " -, --no-underlining     potlačí podtrhávání\n"

#: text-utils/colcrt.c:89
msgid " -2, --half-lines        print all half-lines\n"
msgstr " -ě, --half-lines        vypíše všechny půlřádky\n"

#: text-utils/colrm.c:60
#, c-format
msgid ""
"\n"
"Usage:\n"
" %s [startcol [endcol]]\n"
msgstr ""
"\n"
"Použití:\n"
" %s [počáteční_sloupec [koncový_sloupec]]\n"

#: text-utils/colrm.c:65
msgid "Filter out the specified columns.\n"
msgstr "Odstraní zadané sloupce.\n"

#: text-utils/colrm.c:184
msgid "first argument"
msgstr "první argument"

#: text-utils/colrm.c:186
msgid "second argument"
msgstr "druhý argument"

#: text-utils/column.c:235
msgid "failed to parse column"
msgstr "nezdařilo rozebrat sloupec"

#: text-utils/column.c:245
#, c-format
msgid "undefined column name '%s'"
msgstr "název sloupce „%s“ není definován"

#: text-utils/column.c:321
msgid "failed to parse --table-order list"
msgstr "nezdařilo se rozebrat seznam --table-order"

#: text-utils/column.c:397
msgid "failed to parse --table-right list"
msgstr "nezdařilo se rozebrat seznam --table-right"

#: text-utils/column.c:401
msgid "failed to parse --table-trunc list"
msgstr "nezdařilo se rozebrat seznam --table-trunc"

#: text-utils/column.c:405
msgid "failed to parse --table-noextreme list"
msgstr "nezdařilo se rozebrat seznam --table-noextreme"

#: text-utils/column.c:409
msgid "failed to parse --table-wrap list"
msgstr "nezdařilo se rozebrat seznam --table-wrap"

#: text-utils/column.c:413
msgid "failed to parse --table-hide list"
msgstr "nezdařilo se rozebrat seznam --table-hide"

#: text-utils/column.c:444
#, c-format
msgid "line %zu: for JSON the name of the column %zu is required"
msgstr "řádek %zu: JSON vyžaduje název sloupce %zu"

#: text-utils/column.c:458
msgid "failed to allocate output data"
msgstr "výstupní data se nepodařilo alokovat"

#: text-utils/column.c:629
msgid "Columnate lists.\n"
msgstr "Vysází seznamy do sloupců.\n"

#: text-utils/column.c:632
msgid " -t, --table                      create a table\n"
msgstr " -t, --table                      vytvoří tabulku\n"

#: text-utils/column.c:633
msgid " -n, --table-name <name>          table name for JSON output\n"
msgstr " -n, --table-name <název>         název tabulky pro výstup v JSONu\n"

#: text-utils/column.c:634
msgid " -O, --table-order <columns>      specify order of output columns\n"
msgstr " -O, --table-order <sloupec>      určuje pořadí výstupních sloupců\n"

#: text-utils/column.c:635
msgid " -N, --table-columns <names>      comma separated columns names\n"
msgstr " -N, --table-columns <názvy>      čárkou oddělený seznam názvů sloupců\n"

#: text-utils/column.c:636
msgid " -E, --table-noextreme <columns>  don't count long text from the columns to column width\n"
msgstr ""
" -E, --table-noextreme <sloupce>  nepočítá dlouhý text ze sloupců do šířky\n"
"                                  sloupců\n"

#: text-utils/column.c:637
msgid " -d, --table-noheadings           don't print header\n"
msgstr " -d, --table-noheadings           nevypíše záhlaví\n"

#: text-utils/column.c:638
msgid " -e, --table-header-repeat        repeat header for each page\n"
msgstr " -e, --table-header-repeat        zopakuje záhlaví na každé stránce\n"

#: text-utils/column.c:639
msgid " -H, --table-hide <columns>       don't print the columns\n"
msgstr " -H, --table-hide <sloupce>       nevypisuje zadané sloupce\n"

#: text-utils/column.c:640
msgid " -R, --table-right <columns>      right align text in these columns\n"
msgstr " -R, --table-right <sloupce>      v těchto sloupcích zarovná text doprava\n"

#: text-utils/column.c:641
msgid " -T, --table-truncate <columns>   truncate text in the columns when necessary\n"
msgstr " -T, --table-truncate <sloupce>   v těchto sloupcích zkrátí text, bude-li třeba\n"

#: text-utils/column.c:642
msgid " -W, --table-wrap <columns>       wrap text in the columns when necessary\n"
msgstr " -W, --table-wrap <sloupce>       v těchto sloupcích zalomí text, bude-li třeba\n"

#: text-utils/column.c:643
msgid " -L, --table-empty-lines          don't ignore empty lines\n"
msgstr " -L, --table-empty-lines          neignoruje prázdné řádky\n"

#: text-utils/column.c:644
msgid " -J, --json                       use JSON output format for table\n"
msgstr " -J, --json                       formátuje výstup tabulek do JSONu\n"

#: text-utils/column.c:647
msgid " -r, --tree <column>              column to use tree-like output for the table\n"
msgstr ""
" -r, --tree <sloupec>             sloupec, kde se použije výstup tabulky do\n"
"                                  stromu\n"

#: text-utils/column.c:648
msgid " -i, --tree-id <column>           line ID to specify child-parent relation\n"
msgstr ""
" -i, --tree-id <sloupec>          identifikátor řádku, který určuje vztah\n"
"                                  potomek-rodič\n"

#: text-utils/column.c:649
msgid " -p, --tree-parent <column>       parent to specify child-parent relation\n"
msgstr " -p, --tree-parent <sloupec>      rodič, který určuje vztah potomek-rodič\n"

#: text-utils/column.c:652
msgid " -c, --output-width <width>       width of output in number of characters\n"
msgstr " -c, --output-width <šířka>       šířka výstupu v počtu znaků\n"

#: text-utils/column.c:653
msgid " -o, --output-separator <string>  columns separator for table output (default is two spaces)\n"
msgstr ""
" -o, --output-separator <řetězec>\n"
"                                  oddělovač sloupců ve výstupní tabulce\n"
"                                  (výchozí jsou dvě mezery)\n"

#: text-utils/column.c:654
msgid " -s, --separator <string>         possible table delimiters\n"
msgstr " -s, --separator <řetězec>        možné oddělovače tabulky\n"

#: text-utils/column.c:655
msgid " -x, --fillrows                   fill rows before columns\n"
msgstr " -x, --fillrows                   před sloupci vyplní řádky\n"

#: text-utils/column.c:724
msgid "invalid columns argument"
msgstr "neplatný argument sloupců"

#: text-utils/column.c:749
msgid "failed to parse column names"
msgstr "nezdařilo rozebrat názvy sloupců"

#: text-utils/column.c:804
msgid "options --tree-id and --tree-parent are required for tree formatting"
msgstr "pro výstup do stromu jsou třeba přepínače --tree-id a --tree-parent"

#: text-utils/column.c:812
msgid "option --table required for all --table-*"
msgstr "všechny přepínače --table-* vyžadují přepínač --table"

#: text-utils/column.c:815
msgid "option --table-columns required for --json"
msgstr "přepínač --table-columns je vyžadován přepínačem --json"

#: text-utils/hexdump.c:155 text-utils/more.c:234
#, c-format
msgid " %s [options] <file>...\n"
msgstr " %s [přepínače] <soubor…>\n"

#: text-utils/hexdump.c:158
msgid "Display file contents in hexadecimal, decimal, octal, or ascii.\n"
msgstr "Zobrazí obsah souboru v šestnáctkové, desítkové, osmičkové nebo ASCII podobě.\n"

#: text-utils/hexdump.c:161
msgid " -b, --one-byte-octal      one-byte octal display\n"
msgstr " -b, --one-byte-octal      výpis po bajtech osmičkově\n"

#: text-utils/hexdump.c:162
msgid " -c, --one-byte-char       one-byte character display\n"
msgstr " -c, --one-byte-char       výpis po bajtech jako znaky\n"

#: text-utils/hexdump.c:163
msgid " -C, --canonical           canonical hex+ASCII display\n"
msgstr " -C, --canonical           normovaný výpis šestnáctkově a v ASCII\n"

#: text-utils/hexdump.c:164
msgid " -d, --two-bytes-decimal   two-byte decimal display\n"
msgstr " -d, --two-bytes-decimal   výpis po dvou bajtech desítkově\n"

#: text-utils/hexdump.c:165
msgid " -o, --two-bytes-octal     two-byte octal display\n"
msgstr " -o, --two-bytes-octal     výpis po dvou bajtech osmičkově\n"

#: text-utils/hexdump.c:166
msgid " -x, --two-bytes-hex       two-byte hexadecimal display\n"
msgstr " -x, --two-bytes-hex       výpis po dvou bajtech šestnáctkově\n"

#: text-utils/hexdump.c:167
msgid " -L, --color[=<mode>]      interpret color formatting specifiers\n"
msgstr " -L, --color[=<režim>]     interpretuje formátovací sekvence barev\n"

#: text-utils/hexdump.c:170
msgid " -e, --format <format>     format string to be used for displaying data\n"
msgstr " -e, --format <formát>     formátovací řetězec použitý při výpisu dat\n"

#: text-utils/hexdump.c:171
msgid " -f, --format-file <file>  file that contains format strings\n"
msgstr ""
" -f, --format-file <soubor>\n"
"                           soubor obsahující formátovací řetězce\n"

#: text-utils/hexdump.c:172
msgid " -n, --length <length>     interpret only length bytes of input\n"
msgstr " -n, --length <délka>      interpretuje pouze délku bajtů ze vstupu\n"

#: text-utils/hexdump.c:173
msgid " -s, --skip <offset>       skip offset bytes from the beginning\n"
msgstr " -s, --skip <pozice>       přeskočí zadaný počet bajtů na začátku vstupu\n"

#: text-utils/hexdump.c:174
msgid " -v, --no-squeezing        output identical lines\n"
msgstr " -v, --no-squeezing        ve výpisu nevynechá shodné řádky\n"

#: text-utils/hexdump.c:180
msgid "<length> and <offset>"
msgstr ""

#: text-utils/hexdump-display.c:364
msgid "all input file arguments failed"
msgstr "všechny argumenty vstupního souboru selhaly"

#: text-utils/hexdump-parse.c:55
#, c-format
msgid "bad byte count for conversion character %s"
msgstr "chybný počet bajtů pro konverzní znak %s"

#: text-utils/hexdump-parse.c:60
#, c-format
msgid "%%s requires a precision or a byte count"
msgstr "%%s vyžaduje uvedení přesnosti či počtu bajtů"

#: text-utils/hexdump-parse.c:65
#, c-format
msgid "bad format {%s}"
msgstr "chybný formát {%s}"

#: text-utils/hexdump-parse.c:70
#, c-format
msgid "bad conversion character %%%s"
msgstr "chybný znak v konverzi %%%s"

#: text-utils/hexdump-parse.c:436
msgid "byte count with multiple conversion characters"
msgstr "počet bajtů s více než jedním konverzním znakem"

#: text-utils/line.c:34
msgid "Read one line.\n"
msgstr "Načte jeden řádek.\n"

#: text-utils/more.c:237
#, fuzzy
msgid "A file perusal filter for CRT viewing."
msgstr "Filter pro prohlížení souborů na CRT.\n"

#: text-utils/more.c:240
#, fuzzy
msgid " -d, --silent          display help instead of ringing bell"
msgstr " -d          zobrazí nápovědu místo zazvonění\n"

#: text-utils/more.c:241
#, fuzzy
msgid " -f, --logical         count logical rather than screen lines"
msgstr " -f          počítá logické řádky namísto řádků obrazovky\n"

#: text-utils/more.c:242
#, fuzzy
msgid " -l, --no-pause        suppress pause after form feed"
msgstr " -l          potlačí zastavení po odřádkování formuláře\n"

#: text-utils/more.c:243
#, fuzzy
msgid " -c, --print-over      do not scroll, display text and clean line ends"
msgstr " -c          neroluje, zobrazí text a vyčistí konce řádků\n"

#: text-utils/more.c:244
#, fuzzy
msgid " -p, --clean-print     do not scroll, clean screen and display text"
msgstr " -p          neroluje, smaže obrazovku a zobrazí text\n"

#: text-utils/more.c:245
#, fuzzy
msgid " -s, --squeeze         squeeze multiple blank lines into one"
msgstr " -s          srazí následující prázdné řádky do jediného\n"

#: text-utils/more.c:246
#, fuzzy
msgid " -u, --plain           suppress underlining and bold"
msgstr " -u          potlačí podtrhávání\n"

#: text-utils/more.c:247
#, fuzzy
msgid " -n, --lines <number>  the number of lines per screenful"
msgstr " -<číslo>    počet řádku na obsah obrazovky\n"

#: text-utils/more.c:248
#, fuzzy
msgid " -<number>             same as --lines"
msgstr " -<počet>               stejné jako „-n <počet>“\n"

#: text-utils/more.c:249
#, fuzzy
msgid " +<number>             display file beginning from line number"
msgstr " +<číslo>    zobrazí soubor počínaje číslem řádku\n"

#: text-utils/more.c:250
#, fuzzy
msgid " +/<pattern>           display file beginning from pattern match"
msgstr " +/<řetězec> zobrazí soubor počínaje shodou vyhledávacího řetězce\n"

#: text-utils/more.c:351
#, fuzzy
msgid "MORE environment variable"
msgstr "nepodařilo se nastavit proměnnou prostředí %s"

#: text-utils/more.c:404
#, fuzzy, c-format
msgid "magic failed: %s\n"
msgstr "volání mkdir selhalo: %s"

#: text-utils/more.c:417 text-utils/more.c:436
#, c-format
msgid ""
"\n"
"******** %s: Not a text file ********\n"
"\n"
msgstr ""
"\n"
"***** %s není textovým souborem *****\n"
"\n"

#: text-utils/more.c:465
#, c-format
msgid ""
"\n"
"*** %s: directory ***\n"
"\n"
msgstr ""
"\n"
"*** %s je adresář ***\n"
"\n"

#: text-utils/more.c:729
#, c-format
msgid "--More--"
msgstr "--Pokračování--"

#: text-utils/more.c:731
#, c-format
msgid "(Next file: %s)"
msgstr "(Další soubor: %s)"

#: text-utils/more.c:739
#, c-format
msgid "[Press space to continue, 'q' to quit.]"
msgstr "[Stiskněte mezerník pro pokračování, 'q' pro ukončení.]"

#: text-utils/more.c:938
msgid ""
"\n"
"...Skipping "
msgstr ""
"\n"
"…Vynechávám "

#: text-utils/more.c:942
msgid "...Skipping to file "
msgstr "…Přecházím na soubor "

#: text-utils/more.c:944
msgid "...Skipping back to file "
msgstr "…Vracím se na soubor "

#: text-utils/more.c:1106
msgid "Line too long"
msgstr "Řádek je příliš dlouhý"

#: text-utils/more.c:1144
msgid "No previous command to substitute for"
msgstr "Neexistuje žádný příkaz, jenž by bylo možno nahradit"

#: text-utils/more.c:1173
#, c-format
msgid "[Use q or Q to quit]"
msgstr "[Stiskněte q či Q pro ukončení]"

#: text-utils/more.c:1261
msgid "exec failed\n"
msgstr "volání exec selhalo\n"

#: text-utils/more.c:1271
msgid "can't fork\n"
msgstr "volání fork selhalo\n"

#: text-utils/more.c:1427
msgid "...skipping\n"
msgstr "…vynechávám\n"

#: text-utils/more.c:1464
msgid ""
"\n"
"Pattern not found\n"
msgstr ""
"\n"
"Vzorek nebyl nalezen\n"

#: text-utils/more.c:1468 text-utils/pg.c:1036 text-utils/pg.c:1184
msgid "Pattern not found"
msgstr "Vzorek nebyl nalezen"

#: text-utils/more.c:1486
#, fuzzy
msgid ""
"Most commands optionally preceded by integer argument k.  Defaults in brackets.\n"
"Star (*) indicates argument becomes new default.\n"
msgstr ""
"\n"
"Většině příkazů může jako argument předcházet celé číslo k. Implicitní hodnoty\n"
"jsou v hranatých závorkách. Hvězdička (*) znamená, že hodnota argumentu se\n"
"stane implicitní.\n"

#: text-utils/more.c:1492
#, fuzzy, c-format
msgid ""
"<space>                 Display next k lines of text [current screen size]\n"
"z                       Display next k lines of text [current screen size]*\n"
"<return>                Display next k lines of text [1]*\n"
"d or ctrl-D             Scroll k lines [current scroll size, initially 11]*\n"
"q or Q or <interrupt>   Exit from more\n"
"s                       Skip forward k lines of text [1]\n"
"f                       Skip forward k screenfuls of text [1]\n"
"b or ctrl-B             Skip backwards k screenfuls of text [1]\n"
"'                       Go to place where previous search started\n"
"=                       Display current line number\n"
"/<regular expression>   Search for kth occurrence of regular expression [1]\n"
"n                       Search for kth occurrence of last r.e [1]\n"
"!<cmd> or :!<cmd>       Execute <cmd> in a subshell\n"
"v                       Start up '%s' at current line\n"
"ctrl-L                  Redraw screen\n"
":n                      Go to kth next file [1]\n"
":p                      Go to kth previous file [1]\n"
":f                      Display current file name and line number\n"
".                       Repeat previous command\n"
msgstr ""
"<mezerník>              Zobrazí dalších k řádků textu. [aktuální velikost\n"
"                        obrazovky]\n"
"z                       Zobrazí dalších k řádků textu. [aktuální velikost\n"
"                        obrazovky]*\n"
"<return>                Zobrazí dalších k řádků textu. [1]*\n"
"d či ctrl-D             Posun o k řádků [aktuální velikost posunu, po spuštění\n"
"                        11]*\n"
"q či Q či <interrupt>   Ukončení programu\n"
"s                       Posun vpřed o k řádků [1]\n"
"f                       Posun vpřed o k stran [1]\n"
"b či ctrl-B             Posun vzad o k stran [1]\n"
"'                       Přeskočí na místo, kde bylo zahájeno předchozí hledání\n"
"=                       Zobrazí číslo aktuálního řádku\n"
"/<regulární výraz>      Hledá k. výskyt regulárního výrazu [1]\n"
"n                       Hledá k. výrazu posledního regulárního výrazu [1]\n"
"!<příkaz> či :!<příkaz> Spustí <příkaz> v podshellu\n"
"v                       Spustí /usr/bin/vi na aktuálním řádku\n"
"ctrl-L                  Překreslí obrazovku\n"
":n                      Přeskočí na k. následující soubor [1]\n"
":p                      Přeskočí na k. předcházející soubor [1]\n"
":f                      Vypíše jméno aktuálního souboru a číslo aktuálního řádku\n"
".                       Zopakuje předcházející příkaz\n"

#: text-utils/more.c:1558
#, c-format
msgid "...back %d page"
msgid_plural "...back %d pages"
msgstr[0] "…zpět o %d stranu"
msgstr[1] "…zpět o %d strany"
msgstr[2] "…zpět o %d stran"

#: text-utils/more.c:1582
#, c-format
msgid "...skipping %d line"
msgid_plural "...skipping %d lines"
msgstr[0] "…přeskakuje se %d řádek"
msgstr[1] "…přeskakují se %d řádky"
msgstr[2] "…přeskakuje se %d řádků"

#: text-utils/more.c:1677
msgid ""
"\n"
"***Back***\n"
"\n"
msgstr ""
"\n"
"***Zpět***\n"

#: text-utils/more.c:1696
#, c-format
msgid "\"%s\" line %d"
msgstr "„%s“ řádek %d"

#: text-utils/more.c:1699
#, c-format
msgid "[Not a file] line %d"
msgstr "[Nejedná se o soubor] řádek %d"

#: text-utils/more.c:1705
msgid "No previous regular expression"
msgstr "Žádný předchozí regulární výraz"

#: text-utils/more.c:1774
#, c-format
msgid "[Press 'h' for instructions.]"
msgstr "[Stiskněte „h“ pro nápovědu.]"

#: text-utils/pg.c:152
msgid ""
"-------------------------------------------------------\n"
"  h                       this screen\n"
"  q or Q                  quit program\n"
"  <newline>               next page\n"
"  f                       skip a page forward\n"
"  d or ^D                 next halfpage\n"
"  l                       next line\n"
"  $                       last page\n"
"  /regex/                 search forward for regex\n"
"  ?regex? or ^regex^      search backward for regex\n"
"  . or ^L                 redraw screen\n"
"  w or z                  set page size and go to next page\n"
"  s filename              save current file to filename\n"
"  !command                shell escape\n"
"  p                       go to previous file\n"
"  n                       go to next file\n"
"\n"
"Many commands accept preceding numbers, for example:\n"
"+1<newline> (next page); -1<newline> (previous page); 1<newline> (first page).\n"
"\n"
"See pg(1) for more information.\n"
"-------------------------------------------------------\n"
msgstr ""
"-------------------------------------------------------\n"
"  h                       tato obrazovka\n"
"  q nebo Q                ukončit program\n"
"  <nový řádek>            další stránka\n"
"  f                       posunout se o stránku vpřed\n"
"  d nebo ^D               další půlstránka\n"
"  l                       další řádek\n"
"  $                       poslední stránka\n"
"  /regvýr/                hledat regulárním výrazem směrem dopředu\n"
"  ?regvýr? nebo ^regvýr^  hledat regulárním výrazem směrem dozadu\n"
"  . nebo ^L               překreslit obrazovku\n"
"  w nebo z                nastavit velikost stránky a přejít na další stránku\n"
"  s název_souboru         uložit současný soubor pod jménem\n"
"  !příkaz                 utéct do shellu\n"
"  p                       přejít na předchozí soubor\n"
"  n                       přejít na další soubor\n"
"\n"
"Mnoho příkazů přijímá předcházející čísla, na příklad: +1<nový řádek> (další\n"
"stránka); -1<nový řádek> (předchozí stránka); 1<nový řádek> (první stránka).\n"
"\n"
"Podrobnosti se lze dozvědět z pg(1).\n"
"-------------------------------------------------------\n"

#: text-utils/pg.c:231
#, c-format
msgid " %s [options] [+line] [+/pattern/] [files]\n"
msgstr " %s [přepínače] [+řádek] [+/vzor/] [soubor]\n"

#: text-utils/pg.c:235
msgid "Browse pagewise through text files.\n"
msgstr "Prochází textový souboru po stránkách.\n"

#: text-utils/pg.c:238
msgid " -number      lines per page\n"
msgstr " -number      řádků na stránku\n"

#: text-utils/pg.c:239
msgid " -c           clear screen before displaying\n"
msgstr " -c           před zobrazením smazat obrazovku\n"

#: text-utils/pg.c:240
msgid " -e           do not pause at end of a file\n"
msgstr " -e           nezastavit se na konci souboru\n"

#: text-utils/pg.c:241
msgid " -f           do not split long lines\n"
msgstr " -f           nedělit dlouhé řádky\n"

#: text-utils/pg.c:242
msgid " -n           terminate command with new line\n"
msgstr " -n           ukončit příkaz novým řádkem\n"

#: text-utils/pg.c:243
msgid " -p <prompt>  specify prompt\n"
msgstr " -p <výzva>   definuje výzvu\n"

#: text-utils/pg.c:244
msgid " -r           disallow shell escape\n"
msgstr " -r           zakáže útěk do shellu\n"

#: text-utils/pg.c:245
msgid " -s           print messages to stdout\n"
msgstr " -s           zprávy vypisuje na standardní výstup\n"

#: text-utils/pg.c:246
msgid " +number      start at the given line\n"
msgstr " +číslo       začne na zadaném řádku\n"

#: text-utils/pg.c:247
msgid " +/pattern/   start at the line containing pattern\n"
msgstr " +/vzor/      začne na řádku obsahujícím vzor\n"

#: text-utils/pg.c:258
#, c-format
msgid "option requires an argument -- %s"
msgstr "přepínač vyžaduje argument – %s"

#: text-utils/pg.c:264
#, c-format
msgid "illegal option -- %s"
msgstr "neplatný přepínač – %s"

#: text-utils/pg.c:367
msgid "...skipping forward\n"
msgstr "…skok vpřed\n"

#: text-utils/pg.c:369
msgid "...skipping backward\n"
msgstr "…skok vzad\n"

#: text-utils/pg.c:385
msgid "No next file"
msgstr "Žádný následující soubor"

#: text-utils/pg.c:389
msgid "No previous file"
msgstr "Žádný předchozí soubor"

#: text-utils/pg.c:891
#, c-format
msgid "Read error from %s file"
msgstr "Chyba čtení ze souboru %s"

#: text-utils/pg.c:894
#, c-format
msgid "Unexpected EOF in %s file"
msgstr "Neočekávaná značka konce souboru v %s"

#: text-utils/pg.c:896
#, c-format
msgid "Unknown error in %s file"
msgstr "Neznámá chyba v souboru %s"

#: text-utils/pg.c:949
msgid "Cannot create temporary file"
msgstr "Nelze vytvořit dočasný soubor"

#: text-utils/pg.c:958 text-utils/pg.c:1125 text-utils/pg.c:1151
msgid "RE error: "
msgstr "Chyba regulárního výrazu: "

#: text-utils/pg.c:1108
msgid "(EOF)"
msgstr "(KONEC SOUBORU)"

#: text-utils/pg.c:1133 text-utils/pg.c:1159
msgid "No remembered search string"
msgstr "Žádný zapamatovaný řetězec pro vyhledání"

#: text-utils/pg.c:1214
msgid "cannot open "
msgstr "nelze otevřít "

#: text-utils/pg.c:1356
msgid ": !command not allowed in rflag mode.\n"
msgstr ": !příkaz není dovolen v režimu rflag.\n"

#: text-utils/pg.c:1390
msgid "fork() failed, try again later\n"
msgstr "fork() selhal, zkuste to později\n"

#: text-utils/pg.c:1478
msgid "(Next file: "
msgstr "(Další soubor: "

#: text-utils/pg.c:1544
#, c-format
msgid "%s %s Copyright (c) 2000-2001 Gunnar Ritter. All rights reserved.\n"
msgstr "%s %s Copyright © 2000–2001 Gunnar Ritter. Všechna práva vyhrazena.\n"

#: text-utils/pg.c:1597 text-utils/pg.c:1670
msgid "failed to parse number of lines per page"
msgstr "nezdařilo se rozebrat počet řádků na stránku"

#: text-utils/rev.c:75
#, c-format
msgid "Usage: %s [options] [file ...]\n"
msgstr "Použití: %s [přepínače] [soubor…]\n"

#: text-utils/rev.c:79
msgid "Reverse lines characterwise.\n"
msgstr "Obrátí pořadí znaků na řádcích.\n"

#: text-utils/ul.c:142
#, c-format
msgid " %s [options] [<file> ...]\n"
msgstr " %s [přepínače] [<soubor…>]\n"

#: text-utils/ul.c:145
msgid "Do underlining.\n"
msgstr "Podtrhává.\n"

#: text-utils/ul.c:148
msgid " -t, -T, --terminal TERMINAL  override the TERM environment variable\n"
msgstr " -t, -T, --terminal TERMINÁL  přebije proměnnou prostředí TERM\n"

#: text-utils/ul.c:149
msgid " -i, --indicated              underlining is indicated via a separate line\n"
msgstr " -i, --indicated              podtržení je vyznačeno samostatným řádkem\n"

#: text-utils/ul.c:209
msgid "trouble reading terminfo"
msgstr "chyba při čtení terminfo databáze"

#: text-utils/ul.c:214
#, c-format
msgid "terminal `%s' is not known, defaulting to `dumb'"
msgstr "terminál „%s“ není znám, použije se „dump“"

#: text-utils/ul.c:304
#, c-format
msgid "unknown escape sequence in input: %o, %o"
msgstr "neznámá posloupnost řídicích znaků na vstupu: %o, %o"

#: text-utils/ul.c:629
msgid "Input line too long."
msgstr "Vstupní řádek je příliš dlouhý."

#, c-format
#~ msgid "%s: failed to read partition start from sysfs"
#~ msgstr "%s: začátek oddílu se nepodařilo ze sysfs načíst"

#~ msgid "All logical partitions are in use. Adding a primary partition."
#~ msgstr "Všechny logické oddíly jsou obsazeny. Přidá se oddíl primární."

#, c-format
#~ msgid "%s: BLKRESETZONE ioctl failed"
#~ msgstr "%s: IOCTL volání BLKRESETZONE selhalo"

#~ msgid " -a, --all           trim all supported mounted filesystems\n"
#~ msgstr " -a, --all           uklidí všechny podporované připojené souborové systémy\n"

#, c-format
#~ msgid "Calling settimeofday(NULL, %d) "
#~ msgstr "Volá se settimeofday(NULL, %d), "

#~ msgid "to set the kernel timezone."
#~ msgstr "aby se nastavila časová zóna."

#~ msgid "to warp System time."
#~ msgstr "aby se urychlil systémový čas."

#~ msgid " -S, --setuid <uid>\t    set uid in entered namespace\n"
#~ msgstr " -S, --setuid <uid>        nastaví UID ve vstoupeném jmenném prostoru\n"

#~ msgid " -G, --setgid <gid>\t    set gid in entered namespace\n"
#~ msgstr " -G, --setgid <gid>        nastaví GID ve vstoupeném jmenném prostoru\n"

#~ msgid "options --map-root-user and --map-current-user are mutually exclusive"
#~ msgstr "přepínače --map-root-user a --map-current-user se vzájemně vylučují"

#~ msgid "options --setgroups=allow and --map-current-user are mutually exclusive"
#~ msgstr "přepínače --setgroups=allow a --map-current-user se vzájemně vylučují"

#~ msgid " -T, --log-timing <file> aliast to -t\n"
#~ msgstr ""
#~ " -T, --log-timing <soubor>\n"
#~ "                         stejné jako -t\n"

#, c-format
#~ msgid "unknown option -%s"
#~ msgstr "neznámý přepínač -%s"

#~ msgid "  Overflow\n"
#~ msgstr "  Přetečení\n"

# The %s is a file system type
#~ msgid "The old %s signature will be removed by a write command."
#~ msgstr "Starý vzorec %s bude odstraněn příkazem k zápisu."

#~ msgid ""
#~ "\n"
#~ "Do you really want to quit? "
#~ msgstr ""
#~ "\n"
#~ "Chcete opravdu skončit? "

#~ msgid ""
#~ "usage: %s [-h] [-v] [-b blksize] [-e edition] [-N endian] [-i file] [-n name] dirname outfile\n"
#~ " -v         be verbose\n"
#~ " -E         make all warnings errors (non-zero exit status)\n"
#~ " -b blksize use this blocksize, must equal page size\n"
#~ " -e edition set edition number (part of fsid)\n"
#~ " -N endian  set cramfs endianness (big|little|host), default host\n"
#~ " -i file    insert a file image into the filesystem\n"
#~ " -n name    set name of cramfs filesystem\n"
#~ " -p         pad by %d bytes for boot code\n"
#~ " -s         sort directory entries (old option, ignored)\n"
#~ " -z         make explicit holes\n"
#~ " dirname    root of the filesystem to be compressed\n"
#~ " outfile    output file\n"
#~ msgstr ""
#~ "Použití: %s [-h] [-v] [-b velikost_bloku] [-e verze] [-N endianita]\n"
#~ "            [-i soubor] [-n název] název_adresáře výstupní_soubor\n"
#~ " -v         upovídaný režim\n"
#~ " -E         varování  budou považována za chyby (nenulový návratový kód)\n"
#~ " -b velikost_bloku\n"
#~ "            použije tuto velikost_bloku, musí být rovna velikosti stránky\n"
#~ " -e verze   nastaví číslo verze [edice] (součást fsid)\n"
#~ " -N endianita\n"
#~ "            vybere endianitu cramfs („big“ [velká] | „little“ [malá] |\n"
#~ "            „host“ [jako tento stroj]), implicitně host\n"
#~ " -i soubor  vloží obraz ze souboru do souborového systému\n"
#~ " -n název   nastaví název souborového systému cramfs\n"
#~ " -p         odsadí o %d bytů kvůli kódu zavaděče\n"
#~ " -s         seřadí položky v adresářích (stará volba, ignorováno)\n"
#~ " -z         vytvoří explicitní díry\n"
#~ " název_adresáře\n"
#~ "            kořen souborového systému, který má být zkomprimován\n"
#~ " výstupní_soubor\n"
#~ "            výstupní soubor\n"

#~ msgid " old start: %ju, new start: %ju (move %ju sectors)\n"
#~ msgstr " starý začátek: %ju, nový začátek: %ju (přesune se %ju sektorů)\n"

#~ msgid "Rufus alignment"
#~ msgstr "Zarovnání Rufus"

#~ msgid "user %s does not exist"
#~ msgstr "uživatel %s neexistuje"

#~ msgid "only root can use \"--%s\" option (effective UID is %u)"
#~ msgstr "přepínač „--%s“ může použít pouze superuživatel (efektivní UID je %u)"

#~ msgid "only root can do that (effective UID is %u)"
#~ msgstr "toto může provést pouze superuživatel (efektivní UID je %u)"

#~ msgid "only root can use \"--%s\" option"
#~ msgstr "pouze superuživatel může použít přepínač „--%s“"

#~ msgid "only root can do that"
#~ msgstr "toto může provést pouze superuživatel"

#~ msgid ""
#~ " -a, --append                  append the output\n"
#~ " -c, --command <command>       run command rather than interactive shell\n"
#~ " -e, --return                  return exit code of the child process\n"
#~ " -f, --flush                   run flush after each write\n"
#~ "     --force                   use output file even when it is a link\n"
#~ " -o, --output-limit <size>     terminate if output files exceed size\n"
#~ " -q, --quiet                   be quiet\n"
#~ " -t[<file>], --timing[=<file>] output timing data to stderr or to FILE\n"
#~ msgstr ""
#~ " -a, --append                  připojí výstup\n"
#~ " -c, --command <příkaz>        spustí příkaz místo interaktivního shellu\n"
#~ " -e, --return                  vrátí návratový kód potomka\n"
#~ " -f, --flush                   po každém zápisu vyprázdní buffer\n"
#~ "     --force                   použije výstupní soubor, i když se jedná o odkaz\n"
#~ " -o, --output-limit <velikost>\n"
#~ "                               ukončí se, když výstupní soubory přesáhnou\n"
#~ "                               zadanou velikost\n"
#~ " -q, --quiet                   bude zticha\n"
#~ " -t[<soubor>], --timing[=<soubor>]\n"
#~ "                               časovací údaje vypíše na chybový výstup nebo\n"
#~ "                               do SOUBORU\n"

#~ msgid "cannot write script file"
#~ msgstr "skript soubor nelze zapsat"

#~ msgid ""
#~ "\n"
#~ "Session terminated.\n"
#~ msgstr ""
#~ "\n"
#~ "Relace ukončena.\n"

#~ msgid "openpty failed"
#~ msgstr "volání openpty selhalo"

#~ msgid "out of pty's"
#~ msgstr "nedostatek PTY"

#~ msgid "Script started, file is %s\n"
#~ msgstr "Script spuštěn. Soubor je %s.\n"

#~ msgid ""
#~ " -t, --timing <file>     script timing output file\n"
#~ " -s, --typescript <file> script terminal session output file\n"
#~ " -d, --divisor <num>     speed up or slow down execution with time divisor\n"
#~ " -m, --maxdelay <num>    wait at most this many seconds between updates\n"
#~ msgstr ""
#~ " -t, --timing <soubor>      výstupní soubor s časováním z nástroje script\n"
#~ " -s, --typescript <soubor>  výstupní soubor terminálové relace z nástroje script\n"
#~ " -d, --divisor <číslo>      zrychlí nebo zpomalí vykonávání podle dělitele času\n"
#~ " -m, --maxdelay <počet>     mezi aktualizacemi počká nejvýše tento počet sekund\n"

#~ msgid "write to stdout failed"
#~ msgstr "zápis na standardní výstup selhal"

#~ msgid "unexpected end of file on %s"
#~ msgstr "neočekávaný konec souboru %s"

#~ msgid "failed to read typescript file %s"
#~ msgstr "načtení souboru se záznamem vstupu %s selhalo"

#~ msgid "wrong number of arguments"
#~ msgstr "chybný počet argumentů"

#~ msgid "failed to read timing file %s"
#~ msgstr "čtení z časového souboru %s selhalo"

#~ msgid "timing file %s: line %lu: unexpected format"
#~ msgstr "časový soubor %s: řádek %lu: neočekávaný formát"

#~ msgid "incorrect password"
#~ msgstr "chybné heslo"

# personality – charakteristika architektury
#~ msgid "Failed to set personality to %s"
#~ msgstr "Selhalo nastavení charakteristiky architektury na %s"

#~ msgid " --reset-env                 reset environment variables\n"
#~ msgstr " --reset-env                 resetuje proměnné prostředí\n"

#~ msgid "ttyname failed"
#~ msgstr "funkce ttyname selhala"

#~ msgid "cannot get tty name"
#~ msgstr "název TTY nelze zjistit"

#~ msgid "%15s: %s"
#~ msgstr "%15s: %s"

#~ msgid "failed to parse CPU list %s"
#~ msgstr "seznam CPU %s se nezdařilo rozebrat"

#~ msgid "failed to parse CPU mask %s"
#~ msgstr "masku CPU %s se nezdařilo rozebrat"

#~ msgid "%s"
#~ msgstr "%s"

#~ msgid "%04d"
#~ msgstr "%04d"

#~ msgid "%s %04d"
#~ msgstr "%s %04d"

#~ msgid "%s: failed to compose sysfs path"
#~ msgstr "%s: nepodařilo se sestavit cestu v sysfs"

#~ msgid "%s: failed to read link"
#~ msgstr "%s: nepodařilo se přečíst odkaz"

#~ msgid "%s - No such file or directory\n"
#~ msgstr "%s – Takový soubor nebo adresář neexistuje\n"

#~ msgid "%s: %s."
#~ msgstr "%s: %s."

#~ msgid "Geometry"
#~ msgstr "Geometrie"

#~ msgid "kind of lock: FL_FLOCK or FL_POSIX."
#~ msgstr "druh zámku: FL_FLOCK nebo FL_POSIX."

#~ msgid "unable to exec /bin/umount of `%s'"
#~ msgstr "nelze spustit /bin/umount nad „%s“"

#~ msgid "sleeping ~%d usec\n"
#~ msgstr "čeká se asi %d µs\n"

#~ msgid "%ld.%06ld < %ld.%06ld (%.6f)\n"
#~ msgstr "%ld,%06ld < %ld,%06ld (%.6f)\n"

#~ msgid " -D, --debug          display more details"
#~ msgstr " -D, --debug          vypisuje více podrobností"

#~ msgid "failed to read from: %s"
#~ msgstr "selhalo čtení z: %s"

#~ msgid "cannot execute: %s"
#~ msgstr "nelze spustit: %s"

#~ msgid "unsupported algorithm: %s"
#~ msgstr "nepodporovaný algoritmus: %s"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ " %1$s -V\n"
#~ " %1$s --report [devices]\n"
#~ " %1$s [-v|-q] commands devices\n"
#~ "\n"
#~ "Available commands:\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ " %1$s -V\n"
#~ " %1$s --report [ZAŘÍZENÍ…]\n"
#~ " %1$s [-v|-q] PŘÍKAZY ZAŘÍZENÍ…\n"
#~ "\n"
#~ "Dostupné příkazy:\n"

#~ msgid ""
#~ "\n"
#~ "Available columns (for -o):\n"
#~ msgstr ""
#~ "\n"
#~ "Dostupné sloupce (pro -o):\n"

#~ msgid "seek error on %s"
#~ msgstr "chyba při pohybu v %s"

#~ msgid ""
#~ " -V, --version      display version information and exit;\n"
#~ "                      -V as --version must be the only option\n"
#~ msgstr ""
#~ " -V, --version      zobrazí údaje o verzi a skončí.\n"
#~ "                    Přepínače -V a --version musí být jedinými přepínači.\n"

#~ msgid " -h, --help         display this help text and exit\n"
#~ msgstr " -h, --help         zobrazí tuto nápovědu a skončí\n"

#~ msgid ""
#~ "\n"
#~ "Available columns (for --show, --raw or --pairs):\n"
#~ msgstr ""
#~ "\n"
#~ "Dostupné sloupce (pro přepínače --show, --raw nebo --pairs):\n"

#~ msgid " -v, --version  output version information and exit\n"
#~ msgstr " -v, --version  vypíše údaje o verzi a skončí\n"

#~ msgid "Try '%s -h' for more information.\n"
#~ msgstr "Více informací získáte příkazem „%s --help“.\n"

#~ msgid " -h, --help     display this help and exit\n"
#~ msgstr " -h, --help     zobrazí tuto nápovědu a skončí\n"

#~ msgid " -V, --version  output version information and exit\n"
#~ msgstr " -V, --version  vypíše údaje o verzi a skončí\n"

#~ msgid " -u, --help     display this help and exit\n"
#~ msgstr " -u, --help     zobrazí tuto nápovědu a skončí\n"

#~ msgid "No known shells."
#~ msgstr "Není znám žádný shell."

#~ msgid ""
#~ "\n"
#~ "Available columns:\n"
#~ msgstr ""
#~ "\n"
#~ "Dostupné sloupce:\n"

#~ msgid " %s [options] -u <user> [[--] <command>]\n"
#~ msgstr " %s [přepínače] -u <uživatel> [[--] <příkaz>]\n"

#~ msgid ""
#~ "\n"
#~ "Available columns (for --output):\n"
#~ msgstr ""
#~ "\n"
#~ "Dostupné sloupce (pro --output):\n"

#~ msgid "Try `%s --help' for more information.\n"
#~ msgstr "Více informací získáte příkazem „%s --help“.\n"

#~ msgid " -v, --verbose    explain what is being done\n"
#~ msgstr " -v, --verbose    vysvětlí, co se děje\n"

#~ msgid ""
#~ " -r, --random     generate random-based uuid\n"
#~ " -t, --time       generate time-based uuid\n"
#~ " -V, --version    output version information and exit\n"
#~ " -h, --help       display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -r, --random     vytvoří UUID založené na náhodě\n"
#~ " -t, --time       vytvoří UUID založené na čase\n"
#~ " -V, --version    zobrazí údaje o verzi a skončí\n"
#~ " -h, --help       zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid ""
#~ " -a, --all           wipe all magic strings (BE CAREFUL!)\n"
#~ " -b, --backup        create a signature backup in $HOME\n"
#~ " -f, --force         force erasure\n"
#~ " -h, --help          show this help text\n"
#~ " -n, --no-act        do everything except the actual write() call\n"
#~ " -o, --offset <num>  offset to erase, in bytes\n"
#~ " -p, --parsable      print out in parsable instead of printable format\n"
#~ " -q, --quiet         suppress output messages\n"
#~ " -t, --types <list>  limit the set of filesystem, RAIDs or partition tables\n"
#~ " -V, --version       output version information and exit\n"
#~ msgstr ""
#~ " -a, --all             zničí všechny magické řetězce (BUĎTE OPATRNÍ!)\n"
#~ " -b, --backup          vytvoří zálohu signatury v $HOME\n"
#~ " -f, --force           vynutí výmaz\n"
#~ " -h, --help            zobrazí tuto nápovědu\n"
#~ " -n, --no-act          provede vše až na samotné volání write()\n"
#~ " -o, --offset <číslo>  pozice v bajtech, na které se bude mazat\n"
#~ " -p, --parsable        vypisuje v strojově zpracovatelném formátu namísto\n"
#~ "                       v přehledné podobě\n"
#~ " -q, --quiet           potlačí zprávy\n"
#~ " -t, --types <seznam>  omezí množinu souborových systémů, diskových polí\n"
#~ "                       nebo tabulek rozdělení disku\n"
#~ " -V, --version         zobrazí údaje o verzi a skončí\n"

#~ msgid "The Hardware Clock registers contain values that are either invalid (e.g. 50th day of month) or beyond the range we can handle (e.g. Year 2095)."
#~ msgstr "Registry hodin reálného času obsahují hodnoty, které jsou buď chybné (např. 50. den v měsíci), či mimo rozsah, který lze zpracovat (např. rok 2095)."

#~ msgid "The Hardware Clock does not contain a valid time, so we cannot set the System Time from it."
#~ msgstr "Systémový čas nelze podle hodin reálného času nastavit, protože neukazují platný čas."

#~ msgid "\ttv.tv_sec = %ld, tv.tv_usec = %ld\n"
#~ msgstr "\ttv.tv_sec = %ld, tv.tv_usec = %ld\n"

#~ msgid "\ttz.tz_minuteswest = %d\n"
#~ msgstr "\ttz.tz_minuteswest = %d\n"

#~ msgid "Must be superuser to set system clock."
#~ msgstr "Nastavit systémový čas může pouze superuživatel."

#~ msgid "\tUTC: %s\n"
#~ msgstr "\tUTC: %s\n"

#~ msgid "Not adjusting drift factor because the Hardware Clock previously contained garbage.\n"
#~ msgstr ""
#~ "Míra posunu se neopraví, protože hodiny reálného času posledně obsahovaly\n"
#~ "neplatné hodnoty.\n"

#~ msgid ""
#~ "Test mode: %s was not updated with:\n"
#~ "%s"
#~ msgstr ""
#~ "Zkušební režim: %s nebylo aktualizováno pomocí:\n"
#~ "%s"

#~ msgid "Could not open file with the clock adjustment parameters in it (%s) for writing"
#~ msgstr "Soubor s parametry posunu hodin (%s) se nepodařilo otevřít pro zápis"

#~ msgid "Could not update file with the clock adjustment parameters (%s) in it"
#~ msgstr "Soubor s parametry posunu hodin (%s) se nepodařilo aktualizovat"

#~ msgid "Drift adjustment parameters not updated."
#~ msgstr "Parametry opravy posunu nezměněny."

#~ msgid "The Hardware Clock does not contain a valid time, so we cannot adjust it."
#~ msgstr "Hodiny reálného času obsahují neplatný čas, tudíž jej nelze opravit."

#~ msgid "At %ld seconds after 1969, RTC is predicted to read %ld seconds after 1969.\n"
#~ msgstr ""
#~ "Je předpovězeno, že v čase %'ld sekund po roce 1969 reálné hodiny\n"
#~ "budou ukazovat %'ld sekund od konce roku 1969.\n"

#~ msgid "Unable to get the epoch value from the kernel."
#~ msgstr "Počátek epochy nelze z jádra zjistit."

#~ msgid "Kernel is assuming an epoch value of %lu\n"
#~ msgstr "Jádro pokládá za počátek epochy %lu.\n"

#~ msgid "To set the epoch value, you must use the 'epoch' option to tell to what value to set it."
#~ msgstr "Počátek epochy nastavíte pomocí přepínače „epoch“."

#~ msgid "Not setting the epoch to %lu - testing only.\n"
#~ msgstr "Testovací režim - počátek epochy na %lu nebude nastaven.\n"

#~ msgid "Unable to set the epoch value in the kernel.\n"
#~ msgstr "Hodnotu počátku epochy v jádře nelze nastavit.\n"

#~ msgid "Query or set the hardware clock.\n"
#~ msgstr "Dotáže se na nebo nastaví hardwarové hodiny.\n"

#~ msgid ""
#~ " -h, --help           show this help text and exit\n"
#~ " -r, --show           read hardware clock and print result\n"
#~ "     --get            read hardware clock and print drift corrected result\n"
#~ "     --set            set the RTC to the time given with --date\n"
#~ msgstr ""
#~ " -h, --help           ukáže tuto nápovědu a skončí\n"
#~ " -r, --show           zjistí a vypíše aktuální stav hodin reálného času\n"
#~ "     --get            zjistí stav hodin reálného času a vypíše hodnotu\n"
#~ "                      opravenou o systematický posun\n"
#~ "     --set            nastaví RTC na hodnotu zadanou přepínačem --date\n"

#~ msgid ""
#~ " -s, --hctosys        set the system time from the hardware clock\n"
#~ " -w, --systohc        set the hardware clock from the current system time\n"
#~ "     --systz          set the system time based on the current timezone\n"
#~ "     --adjust         adjust the RTC to account for systematic drift since\n"
#~ "                        the clock was last set or adjusted\n"
#~ msgstr ""
#~ " -s, --hctosys        nastaví systémový čas podle hodin reálného času\n"
#~ " -w, --systohc        nastaví hodiny reálného času podle aktuálního systémového\n"
#~ "     --systz          nastaví systémový čas na základě současné časové zóny\n"
#~ "     --adjust         opraví RTC o systematický posun, který nastal od poslední\n"
#~ "                      opravy či nastavení hodin\n"

#~ msgid ""
#~ "     --getepoch       print out the kernel's hardware clock epoch value\n"
#~ "     --setepoch       set the kernel's hardware clock epoch value to the \n"
#~ "                        value given with --epoch\n"
#~ msgstr ""
#~ "     --getepoch       vypíše počátek epochy hodin reálného času podle jádra\n"
#~ "     --setepoch       nastaví jádru počátek epochy hodin reálného času na\n"
#~ "                      hodnotu zadanou přepínačem --epoch\n"

#~ msgid ""
#~ "     --predict        predict RTC reading at time given with --date\n"
#~ " -V, --version        display version information and exit\n"
#~ msgstr ""
#~ "     --predict        předpoví hodnotu RTC v době zadané pomocí --date\n"
#~ " -V, --version        zobrazí údaje o verzi a skončí\n"

#~ msgid ""
#~ " -u, --utc            the hardware clock is kept in UTC\n"
#~ "     --localtime      the hardware clock is kept in local time\n"
#~ msgstr ""
#~ " -u, --utc            hodiny reálného času jdou v UTC\n"
#~ "     --localtime      hodiny reálného času jdou v místním čase\n"

#~ msgid " -f, --rtc <file>     special /dev/... file to use instead of default\n"
#~ msgstr " -f, --rtc <soubor>   namísto výchozího zařízení použije z /dev/… jiné\n"

#~ msgid ""
#~ "     --directisa      access the ISA bus directly instead of %s\n"
#~ "     --date <time>    specifies the time to which to set the hardware clock\n"
#~ msgstr ""
#~ "     --directisa      místo %s přistoupí přímo ke sběrnici ISA\n"
#~ "     --date <čas>     čas, na který budou nastaveny hodiny reálného času\n"

#~ msgid ""
#~ "     --update-drift   update drift factor in %1$s (requires\n"
#~ "                        --set or --systohc)\n"
#~ "     --noadjfile      do not access %1$s; this requires the use of\n"
#~ "                        either --utc or --localtime\n"
#~ "     --adjfile <file> specifies the path to the adjust file;\n"
#~ "                        the default is %1$s\n"
#~ msgstr ""
#~ "     --update-drift   aktualizuje míru posunu v %1$s (vyžaduje\n"
#~ "                        --set nebo --systohc)\n"
#~ "     --noadjfile      nepoužije %1$s. Vyžaduje použití\n"
#~ "                      buď --utc, nebo --localtime.\n"
#~ "     --adjfile <soubor>\n"
#~ "                      určuje cestu k souboru se systematickým posunem\n"
#~ "                      (výchozí je %1$s)\n"

#~ msgid ""
#~ "     --test           do not update anything, just show what would happen\n"
#~ " -D, --debug          debugging mode\n"
#~ "\n"
#~ msgstr ""
#~ "     --test           nic nenastaví, pouze ukáže, co by se stalo\n"
#~ " -D, --debug          ladicí režim\n"
#~ "\n"

#~ msgid "invalid epoch argument"
#~ msgstr "neplatný argument epochy"

#~ msgid "root privileges may be required"
#~ msgstr "možná jsou zapotřebí práva superuživatele"

#~ msgid "%s does not have interrupt functions. "
#~ msgstr "%s nemá přerušovací funkce. "

#~ msgid "ioctl() to %s to turn on update interrupts failed unexpectedly"
#~ msgstr "Obnovovací přerušení nelze zapnout - volání ioctl() pro %s selhalo"

#~ msgid "To manipulate the epoch value in the kernel, we must access the Linux 'rtc' device driver via the device special file.  This file does not exist on this system."
#~ msgstr "Pro změnu hodnoty počátku epochy v jádře je nutné přistoupit k linuxovému ovladači zařízení „rtc“ pomocí zvláštního souboru zařízení. Tento soubor na tomto systému neexistuje."

#~ msgid "we have read epoch %lu from %s with RTC_EPOCH_READ ioctl.\n"
#~ msgstr "Z %2$s byl pomocí RTC_EPOCH_READ ioctl zjištěn počátek epochy (%1$lu).\n"

#~ msgid "The epoch value may not be less than 1900.  You requested %ld"
#~ msgstr "Hodnota počátku epochy nesmí být menší než 1900. Požadovali jste %ld."

#~ msgid "setting epoch to %lu with RTC_EPOCH_SET ioctl to %s.\n"
#~ msgstr "nastavení pomocí RTC_EPOCH_SET ioctl pro %2$s počátek epochy na %1$lu.\n"

#~ msgid "The kernel device driver for %s does not have the RTC_EPOCH_SET ioctl."
#~ msgstr "Jaderný ovladač pro zařízení %s nepodporuje IOCTL RTC_EPOCH_SET."

#~ msgid ""
#~ "%s\n"
#~ "Try `%s --help' for more information."
#~ msgstr ""
#~ "%s\n"
#~ "Více informací získáte příkazem „%s --help“."

#~ msgid "Try `%s --help' for more information."
#~ msgstr "Více informací získáte příkazem „%s --help“."

#~ msgid ""
#~ "\n"
#~ "Available columns (for --show):\n"
#~ msgstr ""
#~ "\n"
#~ "Dostupné sloupce (pro --show):\n"

#~ msgid " -T, --trust-irq <on|off>     make driver to trust irq\n"
#~ msgstr " -T, --trust-irq <on|off>     přinutí ovladač věřit IRQ (ano|ne)\n"

#~ msgid "     --version              output version information and exit\n"
#~ msgstr "     --version              zobrazí údaje o verzi a skončí\n"

#~ msgid " --version                         show version information and exit\n"
#~ msgstr " --version                         zobrazí údaje o verzi a skončí\n"

#~ msgid " --help                            display this help and exit\n"
#~ msgstr " --help                            zobrazí tuto nápovědu a skončí\n"

#~ msgid "Filesystem label:"
#~ msgstr "Jmenovka souborového systému:"

#~ msgid "Device %s already contains a %s signature."
#~ msgstr "Zařízení %s již obsahuje vzorec %s."

#~ msgid "%s: these options are mutually exclusive:"
#~ msgstr "%s: tyto přepínače se vzájemně vylučují:"

#~ msgid "failed to set PATH"
#~ msgstr "proměnnou PATH se nepodařilo nastavit"

#~ msgid "%d"
#~ msgstr "%d"

#~ msgid " -m, --mtab             search in table of mounted filesystems\n"
#~ msgstr " -m, --mtab             hledá v tabulce připojených souborových systémů\n"

#~ msgid "use of 'kill --pid' option as command name is deprecated"
#~ msgstr "použití přepínače „kill --pid“ jako názvu příkazu je zastaralé"

#~ msgid "Suspend access to a filesystem (ext3/4, ReiserFS, JFS, XFS).\n"
#~ msgstr "Pozdrží přístup na souborový systém (ext3/4, Resource, JFS, XFS).\n"

#~ msgid "Clock not changed - testing only.\n"
#~ msgstr "Testovací režim - Čas nezměněn.\n"

# This looks like an ISO format without the "T" separator. Don't localize it.
#~ msgid "%4d-%.2d-%.2d %02d:%02d:%02d.%06ld%+02d:%02d\n"
#~ msgstr "%4d-%.2d-%.2d %02d:%02d:%02d.%06ld%+02d:%02d\n"

#~ msgid "--date argument too long"
#~ msgstr "argument --date je příliš dlouhý"

#~ msgid ""
#~ "The value of the --date option is not a valid date.\n"
#~ "In particular, it contains quotation marks."
#~ msgstr ""
#~ "Argument přepínače --date není platným datem.\n"
#~ "Konkrétně obsahuje uvozovky."

#~ msgid "Issuing date command: %s\n"
#~ msgstr "Spouští se příkaz „date„: %s\n"

#~ msgid "Unable to run 'date' program in /bin/sh shell. popen() failed"
#~ msgstr "Příkaz „date“ nelze v shellu /bin/sh spustit. Volání popen() selhalo."

#~ msgid "response from date command = %s\n"
#~ msgstr "odpověď příkazu „date“ = %s\n"

#~ msgid ""
#~ "The date command issued by %s returned unexpected results.\n"
#~ "The command was:\n"
#~ "  %s\n"
#~ "The response was:\n"
#~ "  %s"
#~ msgstr ""
#~ "Od příkazu „date“ spuštěného programem %s přišla nečekaná odpověď.\n"
#~ "Příkaz byl:\n"
#~ "  %s\n"
#~ "Odpověď byla:\n"
#~ "  %s"

#~ msgid ""
#~ "The date command issued by %s returned something other than an integer where the converted time value was expected.\n"
#~ "The command was:\n"
#~ "  %s\n"
#~ "The response was:\n"
#~ " %s\n"
#~ msgstr ""
#~ "Příkaz „date“ spuštěný programem %s místo převedeného času vrátil něco,\n"
#~ "co není celým číslem.\n"
#~ "Příkaz:\n"
#~ "  %s\n"
#~ "Odpověď:\n"
#~ "  %s\n"

#~ msgid "date string %s equates to %ld seconds since 1969.\n"
#~ msgstr "Datum %s odpovídá %ld sekundám od roku 1969.\n"

#~ msgid "Not setting system clock because running in test mode.\n"
#~ msgstr "Testovací režim - systémový čas nezměněn.\n"

#~ msgid "Not updating adjtime file because of testing mode.\n"
#~ msgstr "Testovací režim - soubor adjtime nezměněn.\n"

#~ msgid ""
#~ "Would have written the following to %s:\n"
#~ "%s"
#~ msgstr ""
#~ "Do %s by bylo uloženo následující:\n"
#~ "%s"

#~ msgid ""
#~ "The kernel keeps an epoch value for the Hardware Clock only on an Alpha machine.\n"
#~ "This copy of hwclock was built for a machine other than Alpha\n"
#~ "(and thus is presumably not running on an Alpha now).  No action taken."
#~ msgstr ""
#~ "Jádro udržuje hodnotu počátku epochy pro hodiny reálného času pouze na\n"
#~ "systémech Alpha.\n"
#~ "Tento program nebyl přeložen pro systém Alpha (a tudíž pravděpodobně nyní\n"
#~ "neběží na Alphě). Žádná akce nebude provedena."

#~ msgid " -c, --compare        periodically compare the system clock with the CMOS clock\n"
#~ msgstr " -c, --compare        opakovaně porovnává systémový čas s hodinami ve CMOS\n"

#~ msgid ""
#~ "     --directisa      access the ISA bus directly instead of %s\n"
#~ "     --badyear        ignore RTC's year because the BIOS is broken\n"
#~ "     --date <time>    specifies the time to which to set the hardware clock\n"
#~ "     --epoch <year>   specifies the year which is the beginning of the\n"
#~ "                        hardware clock's epoch value\n"
#~ msgstr ""
#~ "     --directisa      místo %s použije přímo ISA sběrnici\n"
#~ "     --badyear        ignoruje rok z RTC, protože BIOS je rozbitý\n"
#~ "     --date ČAS       čas, na který budou nastaveny hodiny reálného času\n"
#~ "     --epoch ROK      určuje rok, kdy začíná epocha hodin reálného času\n"

#~ msgid ""
#~ " -J|--jensen, -A|--arc, -S|--srm, -F|--funky-toy\n"
#~ "      tell hwclock the type of Alpha you have (see hwclock(8))\n"
#~ "\n"
#~ msgstr ""
#~ " -J|--jensen, -A|--arc, -S|--srm, -F|--funky-toy\n"
#~ "                      určí typ vašeho systému Alpha (vizte hwclock(8))\n"

#~ msgid "Sorry, only the superuser can use the Hardware Clock."
#~ msgstr "Hodiny reálného času může použít pouze superuživatel."

#~ msgid "%s takes no non-option arguments.  You supplied %d.\n"
#~ msgstr "%s akceptuje pouze přepínače. Zadáno argumentů, které nejsou přepínači: %d\n"

#~ msgid "No usable set-to time.  Cannot set clock."
#~ msgstr "Nebyl zadán platný čas, který se má nastavit. Hodiny nelze nastavit."

#~ msgid "booted from MILO\n"
#~ msgstr "spuštěn pomocí MILO\n"

#~ msgid "Ruffian BCD clock\n"
#~ msgstr "hodnoty uloženy v BCD tvaru\n"

#~ msgid "clockport adjusted to 0x%x\n"
#~ msgstr "vstupně/výstupní port pro přístup k hodinám nastaven na 0x%x\n"

#~ msgid "funky TOY!\n"
#~ msgstr "funky TOY!\n"

#~ msgid "atomic %s failed for 1000 iterations!"
#~ msgstr "1000 neúspěšných pokusů o atomické provedení %s!"

#~ msgid "cmos_read(): write to control address %X failed"
#~ msgstr "cmos_read(): zápis na řídící adresu %X selhal"

#~ msgid "cmos_read(): read from data address %X failed"
#~ msgstr "cmos_read(): čtení z datové adresy %X selhalo"

#~ msgid "cmos_write(): write to control address %X failed"
#~ msgstr "cmos_write(): zápis na řídící adresu %X selhal"

#~ msgid "cmos_write(): write to data address %X failed"
#~ msgstr "cmos_write(): zápis na datovou adresu %X selhal"

#~ msgid "I failed to get permission because I didn't try."
#~ msgstr "Jelikož nebyla snaha, nepodařilo se získat práva pro přístup."

#~ msgid "unable to get I/O port access:  the iopl(3) call failed."
#~ msgstr "přístup k I/O portu nelze získat: volání iopl(3) selhalo."

#~ msgid "Probably you need root privileges.\n"
#~ msgstr "Pravděpodobně je třeba mít práva superuživatele.\n"

#~ msgid "failed to initialize output line"
#~ msgstr "výstupní řádek se nepodařilo inicializovat"

#~ msgid "error: can not set signal handler"
#~ msgstr "chyba: obsluhu signálu nelze nastavit"

#~ msgid "error: can not restore signal handler"
#~ msgstr "chyba: obsluhu signálu nelze obnovit"

#~ msgid "only root can mount %s on %s"
#~ msgstr "pouze superuživatel může připojit %s do %s"

#~ msgid ""
#~ "%s: more filesystems detected. This should not happen,\n"
#~ "       use -t <type> to explicitly specify the filesystem type or\n"
#~ "       use wipefs(8) to clean up the device."
#~ msgstr ""
#~ "%s: nalezeno více souborových systémů. To by se nemělo stát.\n"
#~ "       Explicitně uveďte druh souborového systému pomocí „-t DRUH“ nebo\n"
#~ "       vyčistěte zařízení pomocí wipefs(8)."

#~ msgid "I could not determine the filesystem type, and none was specified"
#~ msgstr "typ systému souborů nebyl zadán a ani jej nelze zjistit"

#~ msgid "you must specify the filesystem type"
#~ msgstr "musíte zadat typ systému souborů"

#~ msgid "mount source not defined"
#~ msgstr "zdroj připojení není definován"

#~ msgid "%s: mount failed"
#~ msgstr "%s: připojení se nezdařilo"

#~ msgid "%s: filesystem mounted, but mount(8) failed"
#~ msgstr "%s: souborový systém byl připojen, ale příkaz mount(8) selhal"

#~ msgid "       %s is already mounted on %s\n"
#~ msgstr "       %s je již připojeno do %s\n"

#~ msgid "%s not mounted or bad option"
#~ msgstr "%s není připojeno či chybný přepínač"

#~ msgid ""
#~ "       (for several filesystems (e.g. nfs, cifs) you might\n"
#~ "       need a /sbin/mount.<type> helper program)\n"
#~ msgstr ""
#~ "       (pro řadu souborových systémů (např. nfs, cifs) je\n"
#~ "       třeba pomocný program /sbin/mount.<typ>)\n"

#~ msgid ""
#~ "\n"
#~ "       In some cases useful info is found in syslog - try\n"
#~ "       dmesg | tail or so.\n"
#~ msgstr ""
#~ "\n"
#~ "       V jistých případech lze najít užitečné informace v systémovém\n"
#~ "       protokolu – zkuste například „dmesg | tail“\n"

#~ msgid "unrecognized option '%c'"
#~ msgstr "nerozpoznaný přepínač „%c“"

#~ msgid "%s: umount failed"
#~ msgstr "%s: odpojení se nezdařilo"

#~ msgid ""
#~ "%s: target is busy\n"
#~ "        (In some cases useful info about processes that\n"
#~ "         use the device is found by lsof(8) or fuser(1).)"
#~ msgstr ""
#~ "%s: zařízení je používáno.\n"
#~ "        (V některých případech lze získat užitečné informace o procesech,\n"
#~ "        které se zařízením pracují, pomocí nástrojů lsof(8) a fuser(1).)"

#~ msgid "%s: mountpoint not found"
#~ msgstr "%s: bod připojení nenalezen"

#~ msgid "bad timeout value: %s"
#~ msgstr "chybný časový limit: %s"

#~ msgid "expected a number, but got '%s'"
#~ msgstr "očekáváno číslo, ale obdrženo „%s“"

#~ msgid "divisor '%s'"
#~ msgstr "dělitel „%s“"

#~ msgid "argument error: %s"
#~ msgstr "chyba argumentu: %s"

#~ msgid "tty path %s too long"
#~ msgstr "cesta k TTY %s je příliš dlouhá"

#~ msgid "line %d is too long, output will be truncated"
#~ msgstr "řádek %d je příliš dlouhý, výstup bude zkrácen"

#~ msgid "incomplete write to \"%s\" (written %zd, expected %zd)\n"
#~ msgstr "neúplný zápis do „%s“ (zapsáno %zd, očekáváno %zd)\n"

#~ msgid "%s: cannot add inotify watch (limit of inotify watches was reached)."
#~ msgstr "%s: nelze přidat sledování pomocí inotify (počet sledování inotify vyčerpán)."

#~ msgid " %s [option] <file>\n"
#~ msgstr " %s [přepínače] <soubor>\n"

#~ msgid "Follow the growth of a log file.\n"
#~ msgstr "Sleduje růst souboru s protokolem.\n"

#~ msgid " -n, --lines <number>   output the last <number> lines\n"
#~ msgstr " -n, --lines <počet>    vypíše posledních <počet> řádků\n"

#~ msgid "Warning: use of 'tailf' is deprecated, use 'tail -f' instead.\n"
#~ msgstr "Pozor: použití nástroje „tailf“ je zastaralé, používejte „tail -f“.\n"

#~ msgid "cannot access file %s"
#~ msgstr "k souboru %s nelze přistoupit"

#~ msgid "%s is not a block special device"
#~ msgstr "%s není blokovým zařízením"

#~ msgid "%s: device is misaligned"
#~ msgstr "%s: zařízení není správně zarovnáno"

#~ msgid "OS/2 hidden C: drive"
#~ msgstr "OS/2 skrytý C: disk"

#~ msgid "%s: parse error at line %d"
#~ msgstr "%s: chyba rozboru na řádku %d"

#~ msgid "%s: failed to get device path"
#~ msgstr "%s: nepodařilo se získat cestu k zařízení"

#~ msgid "%s: unknown device name"
#~ msgstr "%s: neznámý název zařízení"

#~ msgid "%s: failed to get dm name"
#~ msgstr "%s: nepodařilo se získat název device mapperu"

#~ msgid "the sort column has to be among the output columns"
#~ msgstr "řadicí sloupec se musí nacházet mezi sloupci výstupu"

#~ msgid ""
#~ " -p, --pid <path>        path to pid file\n"
#~ " -s, --socket <path>     path to socket\n"
#~ " -T, --timeout <sec>     specify inactivity timeout\n"
#~ " -k, --kill              kill running daemon\n"
#~ " -r, --random            test random-based generation\n"
#~ " -t, --time              test time-based generation\n"
#~ " -n, --uuids <num>       request number of uuids\n"
#~ " -P, --no-pid            do not create pid file\n"
#~ " -F, --no-fork           do not daemonize using double-fork\n"
#~ " -S, --socket-activation do not create listening socket\n"
#~ " -d, --debug             run in debugging mode\n"
#~ " -q, --quiet             turn on quiet mode\n"
#~ " -V, --version           output version information and exit\n"
#~ " -h, --help              display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -p, --pid <cesta>        cesta k souboru s PID\n"
#~ " -s, --socket <cesta>     cesta k socketu\n"
#~ " -T, --timeout <sekundy>  určí časový limit nečinnosti\n"
#~ " -k, --kill               zabije běžícího démona\n"
#~ " -r, --random             vyzkouší generátor založený na náhodě\n"
#~ " -t, --time               vyzkouší generátor založený na čase\n"
#~ " -n, --uuids <počet>      požaduje počet UUID\n"
#~ " -P, --no-pid             nevytváří soubor PID\n"
#~ " -F, --no-fork            nedémonizuje se pomocí dvojitého forku\n"
#~ " -S, --socket-activation  nevytváří socket, na kterém by poslouchal\n"
#~ " -d, --debug              běží v ladicím režimu\n"
#~ " -q, --quiet              zapne tichý režim\n"
#~ " -V, --version            zobrazí údaje o verzi a skončí\n"
#~ " -h, --help               zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid "unknown scheduling policy"
#~ msgstr "nová politika plánování"

#~ msgid ""
#~ " -o, --offset <num>  offset in bytes to discard from\n"
#~ " -l, --length <num>  length of bytes to discard from the offset\n"
#~ " -p, --step <num>    size of the discard iterations within the offset\n"
#~ " -s, --secure        perform secure discard\n"
#~ " -v, --verbose       print aligned length and offset\n"
#~ msgstr ""
#~ " -o, --offset <číslo>   začátek oblasti k zahození v bajtech\n"
#~ " -l, --length <číslo>   délka oblasti k zahození v bajtech\n"
#~ " -p, --step <číslo>     velikost zahazovací iterace uvnitř zadané oblasti\n"
#~ " -s, --secure           provede bezpečné zahození\n"
#~ " -v, --verbose          vypíše zarovnanou délku a začátek\n"

#~ msgid "%s: parse error: ignore entry at line %d."
#~ msgstr "%s: chyba rozboru: záznam na řádku %d bude ignorován."

#~ msgid "pages"
#~ msgstr "stránky"

# Last argument of "page-size %d, %s byte order"
#~ msgid "different"
#~ msgstr "odlišné"

# Last argument of "page-size %d, %s byte order"
#~ msgid "same"
#~ msgstr "stejné"

#~ msgid "Device open in read-only mode."
#~ msgstr "Zařízení otevřeno jen pročtení."

#~ msgid " -v  be verbose\n"
#~ msgstr " -v  podrobné hlášky\n"

#~ msgid ""
#~ "Very long (%zu bytes) filename `%s' found.\n"
#~ " Please increase MAX_INPUT_NAMELEN in mkcramfs.c and recompile.  Exiting."
#~ msgstr ""
#~ "Byl nalezen velmi dlouhý (%zu bajtů) název souboru „%s“.\n"
#~ "Prosím, zvyšte MAX_INPUT_NAMELEN v mkcramfs.c a znovu přeložte. Končí se."

#~ msgid "Usage: %s [-c | -l filename] [-nXX] [-iXX] /dev/name [blocks]"
#~ msgstr "Použití: %s [-c | -l SOUBOR] [-nXX] [-iXX] /dev/NÁZEV [BLOKY]"

#~ msgid "%s: unable to allocate buffer for superblock"
#~ msgstr "%s: buffer pro superblok nelze alokovat"

#~ msgid "%s: unable to allocate buffers for maps"
#~ msgstr "%s: buffery pro mapy nelze alokovat"

#~ msgid "%s: unable to allocate buffer for inodes"
#~ msgstr "%s: buffer pro i-uzly nelze alokovat"

#~ msgid "%s: bad inode size"
#~ msgstr "%s: chybná velikost i-uzlu"

#~ msgid "disk: %.*s"
#~ msgstr "disk: %.*s"

#~ msgid "label: %.*s"
#~ msgstr "popis: %.*s"

#~ msgid "flags: %s"
#~ msgstr "příznaky: %s"

#~ msgid "bytes/sector: %ld"
#~ msgstr "bajtů/sektor: %ld"

#~ msgid "sectors/track: %ld"
#~ msgstr "sektorů/stopu: %ld"

#~ msgid "tracks/cylinder: %ld"
#~ msgstr "stop/cylindr: %ld"

#~ msgid "sectors/cylinder: %ld"
#~ msgstr "sektorů/cylindr: %ld"

#~ msgid "cylinders: %ld"
#~ msgstr "cylindrů: %ld"

#~ msgid "rpm: %d"
#~ msgstr "otáčky: %d"

#~ msgid "interleave: %d"
#~ msgstr "prokládání: %d"

#~ msgid "trackskew: %d"
#~ msgstr "zpoždění stopy: %d"

#~ msgid "cylinderskew: %d"
#~ msgstr "zpoždění cylindru: %d"

#~ msgid "headswitch: %ld (milliseconds)"
#~ msgstr "přesun hlavy: %ld (milisekundy)"

#~ msgid "track-to-track seek: %ld (milliseconds)"
#~ msgstr "zpoždění mezi stopami: %ld (milisekundy)"

#~ msgid "You cannot change a partition into an extended one or vice versa. Delete it first."
#~ msgstr "Nemůžete měnit běžný oddíl na rozšířený a zpět. Nejdříve jej smažte."

#~ msgid ""
#~ "Label geometry: %d heads, %llu sectors\n"
#~ "                %llu cylinders, %d physical cylinders\n"
#~ "                %d extra sects/cyl, interleave %d:1\n"
#~ msgstr ""
#~ "Geometrie popisu: hlav: %'d, sektorů: %'llu,\n"
#~ "                  cylindrů: %'llu, fyzických cylindrů: %'d                  extra sektorů/cylindr: %d, prokládání: %d:1\n"

#~ msgid ""
#~ "Label geometry: %d rpm, %d alternate and %d physical cylinders,\n"
#~ "                %d extra sects/cyl, interleave %d:1"
#~ msgstr ""
#~ "Geometrie popisu: otáček: %'d, náhradních cylindrů: %'d,\n"
#~ "                  fyzických cylindrů: %'d,\n"
#~ "                  extra sektorů/cylindr: %'d, prokládání: %d:1"

# Volume ID
#~ msgid "<none>"
#~ msgstr "<žádné>"

#~ msgid "gettimeofday failed"
#~ msgstr "volání gettimeofday selhalo"

#~ msgid "sysinfo failed"
#~ msgstr "volání sysinfo selhalo"

#~ msgid "usage: last [-#] [-f file] [-t tty] [-h hostname] [user ...]\n"
#~ msgstr "Použití: last [-#] [-f soubor] [-t tty] [-h název_počítače] [uživatel…]\n"

#~ msgid "%s: mmap failed"
#~ msgstr "%s: volání mmap selhalo"

#~ msgid "  still logged in"
#~ msgstr "  stále přihlášen"

#~ msgid ""
#~ "\n"
#~ "wtmp begins %s"
#~ msgstr ""
#~ "\n"
#~ "wtmp začíná %s"

#~ msgid "gethostname failed"
#~ msgstr "volání gethostname selhalo"

#~ msgid ""
#~ "\n"
#~ "interrupted %10.10s %5.5s \n"
#~ msgstr ""
#~ "\n"
#~ "přerušen %10.10s %5.5s \n"

#~ msgid ""
#~ " -p, --pid <pid>        process id\n"
#~ " -o, --output <list>    define which output columns to use\n"
#~ " -n, --noheadings       don't print headings\n"
#~ " -r, --raw              use the raw output format\n"
#~ " -u, --notruncate       don't truncate text in columns\n"
#~ " -h, --help             display this help and exit\n"
#~ " -V, --version          output version information and exit\n"
#~ msgstr ""
#~ " -p, --pid <PID>        ID procesu\n"
#~ " -o, --output <seznam>  určuje sloupce na výstupu\n"
#~ " -n, --noheadings       nevypíše záhlaví\n"
#~ " -r, --raw              výpis v syrovém formátu\n"
#~ " -u, --notruncate       nezkracuje text ve sloupcích\n"
#~ " -h, --help             zobrazí tuto nápovědu a skončí\n"
#~ " -V, --version          zobrazí údaje o verzi a skončí\n"

#~ msgid ""
#~ "\n"
#~ "Scheduling policies:\n"
#~ "  -b | --batch         set policy to SCHED_BATCH\n"
#~ "  -f | --fifo          set policy to SCHED_FIFO\n"
#~ "  -i | --idle          set policy to SCHED_IDLE\n"
#~ "  -o | --other         set policy to SCHED_OTHER\n"
#~ "  -r | --rr            set policy to SCHED_RR (default)\n"
#~ msgstr ""
#~ "\n"
#~ "Politiky plánování:\n"
#~ "  -b | --batch         nastaví politiku na SCHED_BATCH (dávka)\n"
#~ "  -f | --fifo          nastaví politiku na SCHED_FIFO (fronta)\n"
#~ "  -i | --idle          nastaví politiku na SCHED_IDLE (zahálení)\n"
#~ "  -o | --other         nastaví politiku na SCHED_OTHER (jiná)\n"
#~ "  -r | --rr            nastaví politiku na SCHED_RR (implicitní)\n"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ "  -a | --all-tasks     operate on all the tasks (threads) for a given pid\n"
#~ "  -h | --help          display this help\n"
#~ "  -m | --max           show min and max valid priorities\n"
#~ "  -p | --pid           operate on existing given pid\n"
#~ "  -v | --verbose       display status information\n"
#~ "  -V | --version       output version information\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ "  -a | --all-tasks     pracuje nad všemi úlohami (vlákny) s PID\n"
#~ "  -h | --help          zobrazí tuto nápovědu\n"
#~ "  -m | --max           zobrazí minimální a maximální platné priority\n"
#~ "  -p | --pid           pracuje nad existujícím procesem s PID\n"
#~ "  -v | --verbose       zobrazí stavové informace\n"
#~ "  -V | --version       vypíše údaje o verzi\n"
#~ "\n"

#~ msgid "invalid argument to --manualeject/-i option"
#~ msgstr "neplatný argument přepínače --manualeject/-i"

#~ msgid "Sorry, only the superuser can change the System Clock."
#~ msgstr "Systémové hodiny může nastavit pouze superuživatel."

#~ msgid "Sorry, only the superuser can change the Hardware Clock epoch in the kernel."
#~ msgstr "Hodnotu počátku epochy hodin reálného času může jádru nastavit pouze superuživatel."

#~ msgid "read() to %s to wait for clock tick failed"
#~ msgstr "tikání hodin nelze z %s číst - volání read() selhalo"

#~ msgid ""
#~ " -h, --help              display this help text and exit\n"
#~ " -i, --internal-only     don't call the mount.<type> helpers\n"
#~ " -l, --show-labels       lists all mounts with LABELs\n"
#~ " -n, --no-mtab           don't write to /etc/mtab\n"
#~ msgstr ""
#~ " -h, --help              zobrazí tuto nápovědu a skončí\n"
#~ " -i, --internal-only     nevolá podpůrné programy mount.<typ>\n"
#~ " -l, --show-labels       zobrazí všechna připojení s JMENOVKAMI\n"
#~ " -n, --no-mtab           nezapíše do /etc/mtab\n"

#~ msgid ""
#~ " -v, --verbose           say what is being done\n"
#~ " -V, --version           display version information and exit\n"
#~ " -w, --rw, --read-write  mount the filesystem read-write (default)\n"
#~ msgstr ""
#~ " -v, --verbose           vysvětlí, co prováděné úkony\n"
#~ " -V, --version           zobrazí údaje o verzi a skončí\n"
#~ " -w, --rw, --read-write  souborové systémy připojí i pro zápis (výchozí)\n"

#~ msgid "set rtc alarm failed"
#~ msgstr "nastavení budíku RTC selgalo"

#~ msgid "enable rtc alarm failed"
#~ msgstr "zapnutí budíku RTC selhalo"

#~ msgid "suspend to \"%s\" unavailable"
#~ msgstr "uspání do režimu „%s“ není dostupné"

#~ msgid " -m, --mount               unshare mounts namespace\n"
#~ msgstr " -m, --mount               oddělí jmenný prostor přípojných bodů\n"

#~ msgid " -u, --uts                 unshare UTS namespace (hostname etc)\n"
#~ msgstr " -u, --uts                 oddělí jmenný prostor UTS (název stroje atd.)\n"

#~ msgid " -i, --ipc                 unshare System V IPC namespace\n"
#~ msgstr " -i, --ipc                 oddělí jmenný prostor System V IPC\n"

#~ msgid " -n, --net                 unshare network namespace\n"
#~ msgstr " -n, --net                 oddělí síťový jmenný prostor\n"

#~ msgid "cannot open %s: %m"
#~ msgstr "nelze otevřít %s: %m"

#~ msgid "fread failed"
#~ msgstr "funkce fread selhala"

#~ msgid "Minimal size is %ju"
#~ msgstr "Nejmenší velikost je %ju"

#~ msgid "Please, select a type to create a new disk label."
#~ msgstr "Prosím, vyberte druh, aby se vytvořil nový popisu disku."

#~ msgid "Help Screen for cfdisk"
#~ msgstr "Nápověda pro cfdisk"

#~ msgid "disk drive."
#~ msgstr "na vašem pevném disku."

#~ msgid "Copyright (C) 2014 Karel Zak <kzak@redhat.com> "
#~ msgstr "Copyright © 2014 Karel Žák <kzak@redhat.com> "

#~ msgid "Based on the original cfdisk from Kevin E. Martin & aeb."
#~ msgstr "Založeno na původním cfdisku od Kevina E. Martina & aeb."

#~ msgid "             `no'"
#~ msgstr "             „no“"

#~ msgid "Device open in read-only mode"
#~ msgstr "Zařízeno je otevřeno jen pro čtení"

#~ msgid "Usage: %s [options] device\n"
#~ msgstr "Použití: %s [PŘEPÍNAČE] ZAŘÍZENÍ\n"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -n, --no-verify  disable the verification after the format\n"
#~ " -V, --version    output version information and exit\n"
#~ " -h, --help       display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -n, --no-verify  zakáže ověřování po formátování\n"
#~ " -V, --version    vypíše údaje o verzi a skončí\n"
#~ " -h, --help       vypíše tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid "stat failed %s"
#~ msgstr "volání stat selhalo %s"

#~ msgid "Usage:\n"
#~ msgstr "Použití:\n"

#~ msgid ""
#~ "\n"
#~ "For more information see mkfs(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Podrobnosti naleznete v mkfs(8).\n"

#~ msgid "%s (%s)\n"
#~ msgstr "%s: (%s)\n"

#~ msgid "Bad swap header size, no label written."
#~ msgstr "Chybná velikost hlavičky odkládacího souboru, jmenovka nezapsána."

#~ msgid "seek error on %s - cannot seek to %lu"
#~ msgstr "chyba posunu ukazovátka na %s - ukazovátko nelze posunout na %lu"

#~ msgid "seek error: wanted 0x%08x%08x, got 0x%08x%08x"
#~ msgstr "chyba při posunu ukazovátka: požadavek 0x%08x%08x, výsledek 0x%08x%08x"

#~ msgid "read error on %s - cannot read sector %llu"
#~ msgstr "chyba čtení z %s - sektor %llu nelze přečíst"

#~ msgid "write error on %s - cannot write sector %llu"
#~ msgstr "chyba zápisu na %s - sektor %llu nelze zapsat"

#~ msgid "cannot open partition sector save file (%s)"
#~ msgstr "soubor pro uložení sektorů (%s) nelze otevřít"

#~ msgid "write error on %s"
#~ msgstr "chyba zápisu na %s"

#~ msgid "cannot stat partition restore file (%s)"
#~ msgstr "volání stat pro soubor s uloženými sektory (%s) selhalo"

#~ msgid "partition restore file has wrong size - not restoring"
#~ msgstr "soubor s uloženými sektory má chybnou velikost - nebude obnoveno"

#~ msgid "cannot open partition restore file (%s)"
#~ msgstr "soubor s uloženými sektory (%s) nelze otevřít"

#~ msgid "cannot open device %s for writing"
#~ msgstr "zařízení %s nelze otevřít pro zápis"

#~ msgid "error writing sector %lu on %s"
#~ msgstr "chyba při zápisu sektoru %lu na %s"

#~ msgid "Disk %s: cannot get geometry"
#~ msgstr "Disk %s: geometrii nelze zjistit"

#~ msgid "Disk %s: cannot get size"
#~ msgstr "Disk %s: velikost nelze zjistit"

#~ msgid ""
#~ "Warning: start=%lu - this looks like a partition rather than\n"
#~ "the entire disk. Using fdisk on it is probably meaningless.\n"
#~ "[Use the --force option if you really want this]"
#~ msgstr ""
#~ "Pozor: začátek=%lu - to vypadá spíše jako oddíl nežli\n"
#~ "celý disk. Použití fdisku je v tom případě pravděpodobně zbytečné.\n"
#~ "[Použijte přepínač --force pokud to opravdu chcete.]"

#~ msgid "Warning: HDIO_GETGEO says that there are %lu heads"
#~ msgstr "Pozor: dle HDIO_GETGEO je počet hlav %lu"

#~ msgid "Warning: HDIO_GETGEO says that there are %lu sectors"
#~ msgstr "Pozor: dle HDIO_GETGEO je počet sektorů %lu"

#~ msgid "Warning: BLKGETSIZE/HDIO_GETGEO says that there are %lu cylinders"
#~ msgstr "Pozor: dle BLKGETSIZE/HDIO_GETGEO je počet cylindrů %lu"

#~ msgid ""
#~ "Warning: unlikely number of sectors (%lu) - usually at most 63\n"
#~ "This will give problems with all software that uses C/H/S addressing."
#~ msgstr ""
#~ "Pozor: neobvyklý počet sektorů (%lu) - obvykle nebývá více než 63.\n"
#~ "To způsobí problémy všem programům, které používají adresování C/H/S."

#~ msgid ""
#~ "\n"
#~ "Disk %s: %lu cylinders, %lu heads, %lu sectors/track\n"
#~ msgstr ""
#~ "\n"
#~ "Disk %s: cylindrů: %lu, hlav: %lu, sektorů/stopu: %lu\n"

#~ msgid "%s of partition %s has impossible value for head: %lu (should be in 0-%lu)"
#~ msgstr "%s oddílu %s má chybný počet hlav: %lu (mělo by být 0-%lu)"

#~ msgid "%s of partition %s has impossible value for sector: %lu (should be in 1-%lu)"
#~ msgstr "%s oddílu %s má chybný počet sektorů: %lu (mělo by být 1-%lu)"

#~ msgid "%s of partition %s has impossible value for cylinders: %lu (should be in 0-%lu)"
#~ msgstr "%s oddílu %s má chybný počet cylindrů: %lu (mělo by být 0-%lu)"

#~ msgid "Re-reading the partition table ...\n"
#~ msgstr "Načítám znovu tabulku rozdělení disku…\n"

#~ msgid ""
#~ "The command to re-read the partition table failed.\n"
#~ "Run partprobe(8), kpartx(8) or reboot your system now,\n"
#~ "before using mkfs"
#~ msgstr ""
#~ "Nepodařilo se znovu načíst tabulku rozdělení disku.\n"
#~ "Dříve než použijete mkfs, spusťte partprobe(8), kpartx(8) nebo restartujte\n"
#~ "systém"

#~ msgid "Error closing %s"
#~ msgstr "Chyba při zavírání %s"

#~ msgid "%s: no such partition\n"
#~ msgstr "%s: oddíl neexistuje\n"

#~ msgid "unrecognized format - using sectors"
#~ msgstr "neznámý formát - použijí se sektory"

#~ msgid "unimplemented format - using %s"
#~ msgstr "neimplementovaný formát - použijí se %s"

#~ msgid "sectors"
#~ msgstr "sektory"

#~ msgid ""
#~ "Units: cylinders of %lu bytes, blocks of 1024 bytes, counting from %d\n"
#~ "\n"
#~ msgstr ""
#~ "Jednotky: cylindry po %lu bajtech, bloky po 1024 bajtech, počítáno od %d\n"
#~ "\n"

#~ msgid "   Device Boot Start     End   #cyls    #blocks   Id  System\n"
#~ msgstr "Zařízení  Boot Začátek   Konec Cyldrů   Bloků     Id  Systém\n"

#~ msgid ""
#~ "Units: sectors of 512 bytes, counting from %d\n"
#~ "\n"
#~ msgstr ""
#~ "Jednotky: sektory po 512 bajtech, počítáno od %d\n"
#~ "\n"

#~ msgid "   Device Boot    Start       End   #sectors  Id  System\n"
#~ msgstr "Zařízení  Boot    Začátek     Konec Sektorů   Id  Systém\n"

#~ msgid ""
#~ "Units: blocks of 1024 bytes, counting from %d\n"
#~ "\n"
#~ msgstr ""
#~ "Jednotky: bloky po 1024 bajtech, počítáno od %d\n"
#~ "\n"

#~ msgid "   Device Boot   Start       End    #blocks   Id  System\n"
#~ msgstr "Zařízení  Boot   Začátek     Konec  Bloků     Id  Systém\n"

#~ msgid ""
#~ "Units: 1MiB = 1024*1024 bytes, blocks of 1024 bytes, counting from %d\n"
#~ "\n"
#~ msgstr ""
#~ "Jednotky: 1 MiB = 1024*1024 bajtů, bloky po 1024 bajtech, počítáno od %d\n"
#~ "\n"

#~ msgid "   Device Boot Start   End    MiB    #blocks   Id  System\n"
#~ msgstr "Zařízení  Boot Začátek Konec  MiB    Bloků     Id  Systém\n"

#~ msgid "\t\tstart: (c,h,s) expected (%ld,%ld,%ld) found (%ld,%ld,%ld)\n"
#~ msgstr "\t\tzačátek: (c,h,s) předpoklad (%ld,%ld,%ld) nalezeno (%ld,%ld,%ld)\n"

#~ msgid "\t\tend: (c,h,s) expected (%ld,%ld,%ld) found (%ld,%ld,%ld)\n"
#~ msgstr "\t\tkonec: (c,h,s) předpoklad (%ld,%ld,%ld) nalezeno (%ld,%ld,%ld)\n"

#~ msgid "partition ends on cylinder %ld, beyond the end of the disk\n"
#~ msgstr "oddíl končí na cylindru %ld, t.j. za koncem disku\n"

#~ msgid ""
#~ "Warning: The partition table looks like it was made\n"
#~ "  for C/H/S=*/%ld/%ld (instead of %ld/%ld/%ld).\n"
#~ "For this listing I'll assume that geometry."
#~ msgstr ""
#~ "Varování: Zdá se, že tabulka rozdělení disku byla vytvořena\n"
#~ "pro C/H/S=*/%ld/%ld (místo %ld/%ld/%ld).\n"
#~ "Zobrazuji za použití této geometrie."

#~ msgid "no partition table present"
#~ msgstr "není přítomna žádná tabulka rozdělení disku"

#~ msgid "strange, only %d partition defined"
#~ msgid_plural "strange, only %d partitions defined"
#~ msgstr[0] "zvláštní - pouze %d oddíl definován"
#~ msgstr[1] "zvláštní - pouze %d oddíly definovány"
#~ msgstr[2] "zvláštní - pouze %d oddílů definováno"

#~ msgid "Warning: partition %s has size 0 but is not marked Empty"
#~ msgstr "Pozor: oddíl %s má velikost 0 a není označen jako prázdný"

#~ msgid "Warning: partition %s has size 0 and is bootable"
#~ msgstr "Pozor: oddíl %s má velikost 0 a je startovací"

#~ msgid "Warning: partition %s has size 0 and nonzero start"
#~ msgstr "Pozor: oddíl %s má velikost 0 a nenulový začátek"

#~ msgid "Warning: partitions %s and %s overlap"
#~ msgstr "Pozor: oddíly %s a %s se překrývají"

#~ msgid ""
#~ "Warning: partition %s contains part of the partition table (sector %llu),\n"
#~ "and will destroy it when filled"
#~ msgstr ""
#~ "Pozor: oddíl %s obsahuje část tabulky rozdělení disku (sektor %llu)\n"
#~ "a v případě zaplnění ji zničí"

#~ msgid "Warning: partition %s starts at sector 0"
#~ msgstr "Pozor: oddíl %s začíná na sektoru 0"

#~ msgid "Warning: partition %s extends past end of disk"
#~ msgstr "Pozor: oddíl %s přesahuje za konec disku"

#~ msgid ""
#~ "Warning: partition %s has size %d.%d TB (%llu bytes),\n"
#~ "which is larger than the %llu bytes limit imposed\n"
#~ "by the DOS partition table for %d-byte sectors"
#~ msgstr ""
#~ "Pozor: oddíl %s má velikost %d,%d TB (%'llu bajtů),\n"
#~ "což je více, než omezení %'llu bajtů dané dosovou tabulkou\n"
#~ "rozdělení disku při %dbajtových sektorech"

#~ msgid ""
#~ "Warning: partition %s starts at sector %llu (%d.%d TB for %d-byte sectors),\n"
#~ "which exceeds the DOS partition table limit of %llu sectors"
#~ msgstr ""
#~ "Pozor: oddíl %s začíná na sektoru %'llu (%d,%d TB\n"
#~ "při %dbajtových sektorech), což přesahuje omezení dosové tabulky\n"
#~ "rozdělení disku %'llu sektorů"

#~ msgid ""
#~ "Among the primary partitions, at most one can be extended\n"
#~ " (although this is not a problem under Linux)"
#~ msgstr ""
#~ "Pouze jeden z primárních oddílů může být rozšířeným\n"
#~ "(ačkoliv v Linuxu to není problém)"

#~ msgid "Warning: partition %s does not start at a cylinder boundary"
#~ msgstr "Pozor: oddíl %s nezačíná na hranici cylindru"

#~ msgid "Warning: partition %s does not end at a cylinder boundary"
#~ msgstr "Pozor: oddíl %s nekončí na hranici cylindru"

#~ msgid ""
#~ "Warning: more than one primary partition is marked bootable (active)\n"
#~ "This does not matter for LILO, but the DOS MBR will not boot this disk."
#~ msgstr ""
#~ "Pozor: více než jeden primární oddíl je označen jako startovací.\n"
#~ "LILU to nečiní problémy, ale DOS MBR z tohoto disku nenastartuje."

#~ msgid ""
#~ "Warning: usually one can boot from primary partitions only\n"
#~ "LILO disregards the `bootable' flag."
#~ msgstr ""
#~ "Pozor: obyčejně je možné startovat pouze z primárních oddíl|ů.\n"
#~ "LILO nebude brát ohled na příznak „startovací“."

#~ msgid ""
#~ "Warning: no primary partition is marked bootable (active)\n"
#~ "This does not matter for LILO, but the DOS MBR will not boot this disk."
#~ msgstr ""
#~ "Pozor: žádný primární oddíl není označen jako startovací.\n"
#~ "LILU to nečiní problémy, ale DOS z tohoto disku nenastartuje."

#~ msgid "start"
#~ msgstr "začátek"

#~ msgid "partition %s: start: (c,h,s) expected (%ld,%ld,%ld) found (%ld,%ld,%ld)"
#~ msgstr "oddíl %s: začátek: (c,h,s) předpoklad (%ld,%ld,%ld), nalezeno (%ld,%ld,%ld)"

#~ msgid "end"
#~ msgstr "konec"

#~ msgid "partition %s: end: (c,h,s) expected (%ld,%ld,%ld) found (%ld,%ld,%ld)"
#~ msgstr "oddíl %s: konec: (c,h,s) předpoklad (%ld,%ld,%ld), nalezeno (%ld,%ld,%ld)"

#~ msgid "partition %s ends on cylinder %ld, beyond the end of the disk"
#~ msgstr "oddíl %s končí na cylindru %ld, to jest za koncem disku"

#~ msgid ""
#~ "Warning: shifted start of the extd partition from %lld to %lld\n"
#~ "(For listing purposes only. Do not change its contents.)"
#~ msgstr ""
#~ "Pozor: začátek rozšířeného oddílu posunut z %lld na %lld.\n"
#~ "(Pouze pro účely výpisu. Neměňte jeho obsah.)"

#~ msgid ""
#~ "Warning: extended partition does not start at a cylinder boundary.\n"
#~ "DOS and Linux will interpret the contents differently."
#~ msgstr ""
#~ "Varování: rozšířený oddíl nezačíná na hranici cylindru.\n"
#~ "DOS a Linux budou jeho obsah interpretovat rozdílně."

#~ msgid "ERROR: sector %llu does not have an msdos signature"
#~ msgstr "CHYBA: sektor %llu nenese stopy MS-DOSu"

#~ msgid "too many partitions - ignoring those past nr (%zu)"
#~ msgstr "příliš mnoho oddílů - ty za číslem %zu budou ignorovány"

#~ msgid "tree of partitions?"
#~ msgstr "strom oddílů?"

#~ msgid "detected Disk Manager - unable to handle that"
#~ msgstr "nalezen Disk Manager - s tím neumím pracovat"

#~ msgid "DM6 signature found - giving up"
#~ msgstr "nalezen DM6 podpis - končí se"

#~ msgid "strange..., an extended partition of size 0?"
#~ msgstr "zvláštní…, rozšířený oddíl o velikosti 0?"

#~ msgid "strange..., a BSD partition of size 0?"
#~ msgstr "zvláštní…, BSD oddíl o velikosti 0?"

#~ msgid "-n flag was given: Nothing changed"
#~ msgstr "byl zadán přepínač -n: Nic nebylo změněno"

#~ msgid "Failed saving the old sectors - aborting\n"
#~ msgstr "Chyba při ukládání starých sektorů - končím\n"

#~ msgid "Failed writing the partition on %s"
#~ msgstr "Chyba při zápisu oddílu na %s"

#~ msgid "long or incomplete input line - quitting"
#~ msgstr "příliš dlouhý či neúplný řádek - končím"

#~ msgid "input error: `=' expected after %s field"
#~ msgstr "chyba vstupu: po položce %s je očekáván znak „=“"

#~ msgid "input error: unexpected character %c after %s field"
#~ msgstr "chyba vstupu: neočekávaný znak %c po položce %s"

#~ msgid "unrecognized input: %s"
#~ msgstr "nerozpoznaný vstup: %s"

#~ msgid "number too big"
#~ msgstr "číslo je příliš veliké"

#~ msgid "trailing junk after number"
#~ msgstr "nesmysly za číslem"

#~ msgid "no room for partition descriptor"
#~ msgstr "není místo pro popis oddílu"

#~ msgid "cannot build surrounding extended partition"
#~ msgstr "okolní rozšiřující oddíl nelze vytvořit"

#~ msgid "too many input fields"
#~ msgstr "příliš mnoho vstupních položek"

#~ msgid "No room for more"
#~ msgstr "Již nejsou volné bloky"

#~ msgid "Illegal type"
#~ msgstr "Chybný typ"

#~ msgid "Warning: given size (%llu) exceeds max allowable size (%llu)"
#~ msgstr "Pozor: zadaná velikost (%llu) překračuje maximální povolenou velikost (%llu)"

#~ msgid "Warning: empty partition"
#~ msgstr "Pozor: prázdný oddíl"

#~ msgid "Warning: bad partition start (earliest %llu)"
#~ msgstr "Pozor: chybný začátek oddílu (dřívější %llu)"

#~ msgid "unrecognized bootable flag - choose - or *"
#~ msgstr "nerozpoznaný příznak „startovací“ - zvolte - či *"

#~ msgid "partial c,h,s specification?"
#~ msgstr "neúplná c,h,s specifikace?"

#~ msgid "Extended partition not where expected"
#~ msgstr "Rozšířený oddíl na neočekávaném místě"

#~ msgid "bad input"
#~ msgstr "chybný vstup"

#~ msgid "too many partitions"
#~ msgstr "příliš mnoho oddílů"

#~ msgid ""
#~ "Input in the following format; absent fields get a default value.\n"
#~ "<start> <size> <type [E,S,L,X,hex]> <bootable [-,*]> <c,h,s> <c,h,s>\n"
#~ "Usually you only need to specify <start> and <size> (and perhaps <type>)."
#~ msgstr ""
#~ "Vstup v následujícím formátu; chybějící položky budou nahrazeny implicitními\n"
#~ "hodnotami.\n"
#~ "<začátek> <velikost> <typ [E,S,L,X,hex]> <startovací [-,*]> <c,h,s> <c,h,s>\n"
#~ "Obvykle je třeba zadat pouze <začátek> a <velikost> (a možná <typ>)."

#~ msgid " %s [options] <device>...\n"
#~ msgstr " %s [přepínače] <zařízení>…\n"

#~ msgid ""
#~ " -s, --show-size           list size of a partition\n"
#~ " -c, --id                  change or print partition Id\n"
#~ "     --change-id           change Id\n"
#~ "     --print-id            print Id\n"
#~ msgstr ""
#~ " -s, --show-size           vypíše velikost oddílu\n"
#~ " -c, --id                  vypíše či změní ID oddílu\n"
#~ "     --change-id           změní ID\n"
#~ "     --print-id            vypíše ID\n"

#~ msgid ""
#~ " -l, --list                list partitions of each device\n"
#~ " -d, --dump                idem, but in a format suitable for later input\n"
#~ " -i, --increment           number cylinders etc. from 1 instead of from 0\n"
#~ " -u, --unit <letter>       units to be used; <letter> can be one of\n"
#~ "                             S (sectors), C (cylinders), B (blocks), or M (MB)\n"
#~ msgstr ""
#~ " -l, --list                ke každému zařízení vypíše oddíly\n"
#~ " -d, --dump                taktéž, ale ve formátu vhodném k dalšímu zpracování\n"
#~ " -i, --increment           čísluje cylindry atd. od 1 místo od 0\n"
#~ " -u, --unit <písmeno>      jako jednotky použije; <písmeno> může být jedno z\n"
#~ "                             S (sektory), C (cylindry), B (bloky) nebo M (MB)\n"

#~ msgid ""
#~ " -1, --one-only            reserved option that does nothing currently\n"
#~ " -T, --list-types          list the known partition types\n"
#~ " -D, --DOS                 for DOS-compatibility: waste a little space\n"
#~ " -E, --DOS-extended        DOS extended partition compatibility\n"
#~ " -R, --re-read             make the kernel reread the partition table\n"
#~ msgstr ""
#~ " -1, --one-only            vyhrazený přepínač, který nyní nic nedělá\n"
#~ " -T, --list-types          vypíše známé typy oddílů\n"
#~ " -D, --DOS                 pro kompatibilitu s DOSem: ubere trochu místa\n"
#~ " -E, --DOS-extended        kompatibilita s dosovými rozšířenými oddíly\n"
#~ " -R, --re-read             požádá jádro o nové načtení tabulky rozdělení disku\n"

#~ msgid ""
#~ " -N <number>               change only the partition with this <number>\n"
#~ " -n                        do not actually write to disk\n"
#~ " -O <file>                 save the sectors that will be overwritten to <file>\n"
#~ " -I <file>                 restore sectors from <file>\n"
#~ msgstr ""
#~ " -N <číslo>                změní pouze oddíl s tímto <číslem>\n"
#~ " -n                        na disk nebudou uloženy žádné změny\n"
#~ " -O <soubor>               uloží změněné sektory do <souboru>\n"
#~ " -I <soubor>               obnoví sektory ze <souboru>\n"

#~ msgid ""
#~ " -V, --verify              check that the listed partitions are reasonable\n"
#~ " -v, --version             display version information and exit\n"
#~ " -h, --help                display this help text and exit\n"
#~ msgstr ""
#~ " -V, --verify              ověří, že vyjmenované oddíly dávají smysl\n"
#~ " -v, --version             zobrazí údaje o verzi a skončí\n"
#~ " -h, --help                zobrazí tuto nápovědu a skončí\n"

#~ msgid ""
#~ "\n"
#~ "Dangerous options:\n"
#~ msgstr ""
#~ "\n"
#~ "Nebezpečné přepínače:\n"

#~ msgid ""
#~ " -f, --force               disable all consistency checking\n"
#~ "     --no-reread           do not check whether the partition is in use\n"
#~ " -q, --quiet               suppress warning messages\n"
#~ " -L, --Linux               do not complain about things irrelevant for Linux\n"
#~ msgstr ""
#~ " -f, --force               vypne všechny kontroly konzistence\n"
#~ "     --no-reread           neověřuje, zda-li se oddíl právě používá\n"
#~ " -q, --quiet               nebude vypisovat varovné hlášky\n"
#~ " -L, --Linux               nebude si stěžovat na věci nepodstatné pro Linux\n"

#~ msgid ""
#~ " -g, --show-geometry       print the kernel's idea of the geometry\n"
#~ " -G, --show-pt-geometry    print geometry guessed from the partition table\n"
#~ msgstr ""
#~ " -g, --show-geometry       vypíše geometrii, jak ji vidí jádro\n"
#~ " -G, --show-pt-geometry    vypíše geometrii, která byla odhadnuta\n"
#~ "                           z tabulky rozdělení disku\n"

#~ msgid ""
#~ " -A, --activate[=<device>] activate the bootable flag\n"
#~ " -U, --unhide[=<device>]   set partition as unhidden\n"
#~ " -x, --show-extended       also list extended partitions in the output,\n"
#~ "                             or expect descriptors for them in the input\n"
#~ msgstr ""
#~ " -A, --activate[=<zařízení>]\n"
#~ "                           zapne příznak zaveditelnosti\n"
#~ " -U, --unhide[=<zařízení>] zviditelní oddíl\n"
#~ " -x, --show-extended       rovněž vypíše rozšířené oddíly nebo\n"
#~ "                           na vstupu očekává jejich popis\n"

#~ msgid ""
#~ "     --leave-last          do not allocate the last cylinder\n"
#~ "     --IBM                 same as --leave-last\n"
#~ msgstr ""
#~ "     --leave-last          nealokuje poslední cylindr\n"
#~ "     --IBM                 stejné jako --leave-last\n"

#~ msgid ""
#~ "     --in-order            partitions are in order\n"
#~ "     --not-in-order        partitions are not in order\n"
#~ "     --inside-outer        all logicals inside outermost extended\n"
#~ "     --not-inside-outer    not all logicals inside outermost extended\n"
#~ msgstr ""
#~ "     --in-order            oddíly jsou seřazeny\n"
#~ "     --not-in-order        oddíly nejsou seřazeny\n"
#~ "     --inside-outer        všechny logické oddíly jsou uvnitř nejvnějšejších\n"
#~ "                           rozšířených oddílů\n"
#~ "     --not-inside-outer    ne všechny logické oddíly jsou uvnitř nejvnějšejších\n"
#~ "                           rozšířených oddílů\n"

# I do not understand difference between --nested and --onesector.
#~ msgid ""
#~ "     --nested              every partition is disjoint from all others\n"
#~ "     --chained             like nested, but extended partitions may lie outside\n"
#~ "     --onesector           partitions are mutually disjoint\n"
#~ msgstr ""
#~ "     --nested              každý oddíl se nepřekrývá se všemi zbývajícími\n"
#~ "     --chained             jako --nested, ale rozšířené oddíly mohou ležet mimo\n"
#~ "     --onesector           oddíly se vzájemně nepřekrývají\n"

#~ msgid ""
#~ "\n"
#~ "Override the detected geometry using:\n"
#~ " -C, --cylinders <number>  set the number of cylinders to use\n"
#~ " -H, --heads <number>      set the number of heads to use\n"
#~ " -S, --sectors <number>    set the number of sectors to use\n"
#~ msgstr ""
#~ "\n"
#~ "Přebije zjištěnou geometrii takto:\n"
#~ " -C, --cylinders <číslo>   nastaví počet cylindrů\n"
#~ " -H, --heads <číslo>       nastaví počet hlav\n"
#~ " -S, --sectors <číslo>     nastaví počet sektorů\n"

#~ msgid " %s%sdevice            list active partitions on device\n"
#~ msgstr " %s%szařízení          vypíše aktivní oddíly na daném zařízení\n"

#~ msgid " %s%sdevice n1 n2 ...  activate partitions n1 ..., inactivate the rest\n"
#~ msgstr " %s%szařízení n1 n2 …  aktivuje oddíly n1, …, deaktivuje ostatní\n"

#~ msgid "invalid number of partitions argument"
#~ msgstr "neplatný argument počtu oddílů"

#~ msgid "cannot open %s\n"
#~ msgstr "%s nelze otevřít.\n"

#~ msgid "usage: sfdisk --print-id device partition-number"
#~ msgstr "Použití: sfdisk --print-id zařízení číslo_oddílu"

#~ msgid "usage: sfdisk --change-id device partition-number Id"
#~ msgstr "Použití: sfdisk --change-id zařízení číslo_oddílu ID"

#~ msgid "usage: sfdisk --id device partition-number [Id]"
#~ msgstr "Použití: sfdisk --id zařízení číslo_oddílu [ID]"

#~ msgid "can specify only one device (except with -l or -s)"
#~ msgstr "můžete zadat pouze jedno zařízení (výjimkou jsou přepínače -l a -s)"

#~ msgid "cannot open %s read-write"
#~ msgstr "%s nelze otevřít pro čtení i zápis"

#~ msgid "cannot open %s for reading"
#~ msgstr "%s nelze otevřít pro čtení"

#~ msgid "%s: OK"
#~ msgstr "%s: OK"

#~ msgid "%s: %ld cylinders, %ld heads, %ld sectors/track\n"
#~ msgstr "%s: %ld cylindrů, %ld hlav, %ld sektorů/stopu\n"

#~ msgid "bad active byte: 0x%x instead of 0x80"
#~ msgstr "chybný aktivní bajt: 0x%x místo 0x80"

#~ msgid "Done"
#~ msgstr "Hotovo"

#~ msgid ""
#~ "You have %d active primary partitions. This does not matter for LILO,\n"
#~ "but the DOS MBR will only boot a disk with 1 active partition."
#~ msgstr ""
#~ "Počet aktivních oddílů je %d. LILU to nečiní problémy, ale DOS MBR\n"
#~ "nastartuje pouze z disku s jedním aktivním oddílem."

#~ msgid "partition %s has id %x and is not hidden"
#~ msgstr "oddíl %s má id %x a není skrytý"

#~ msgid "Bad Id %lx"
#~ msgstr "ID %lx je chybné"

#~ msgid "This disk is currently in use."
#~ msgstr "Tento disk je právě používán."

#~ msgid "Fatal error: cannot find %s"
#~ msgstr "Fatální chyba: %s nelze nalézt"

#~ msgid "Warning: %s is not a block device"
#~ msgstr "Pozor: %s není blokovým zařízením"

#~ msgid "Partition %d does not exist, cannot change it"
#~ msgstr "Diskový oddíl %d neexistuje. Nelze jej změnit"

#~ msgid ""
#~ "I don't like these partitions - nothing changed.\n"
#~ "(If you really want this, use the --force option.)"
#~ msgstr ""
#~ "Toto rozložení oddílů se mi nelíbí - nic nebude změněno.\n"
#~ "(Pokud jej opravdu chcete použít, pak zadejte přepínač --force.)"

#~ msgid "I don't like this - probably you should answer No"
#~ msgstr "Toto se mi nelíbí - měli byste odpovědět Ne"

#~ msgid "Are you satisfied with this? [ynq] "
#~ msgstr "Vyhovuje vám to? [anq] "

#~ msgid "Quitting - nothing changed"
#~ msgstr "Končí se – nebyly učiněny žádné změny"

#~ msgid "Please answer one of y,n,q\n"
#~ msgstr "Odpovězte prosím a, n či q\n"

#~ msgid ""
#~ "Successfully wrote the new partition table\n"
#~ "\n"
#~ msgstr ""
#~ "Nová tabulka rozdělení disku byla úspěšně uložena.\n"
#~ "\n"

#~ msgid ""
#~ "If you created or changed a DOS partition, /dev/foo7, say, then use dd(1)\n"
#~ "to zero the first 512 bytes:  dd if=/dev/zero of=/dev/foo7 bs=512 count=1\n"
#~ "(See fdisk(8).)"
#~ msgstr ""
#~ "Pokud jste vytvořili či změnili nějaké DOSOVÉ oddíly - např. /dev/bla7,\n"
#~ "použijte dd(1) k vynulování prvních 512 bajtů: 'dd if=/dev/zero of=/dev/bla7\n"
#~ "bs=512 count=1' (viz fdisk(8))."

#~ msgid "If you have created or modified any DOS 6.x partitions, please see the fdisk documentation for additional information."
#~ msgstr "Pokud jste vytvořili či změnili nějaké DOS 6.x oddíly, přečtěte si prosím návod k programu fdisk, abyste získali další informace."

#~ msgid "field is too long"
#~ msgstr "položka je příliš dlouhá"

#~ msgid "%s: '%c' is not allowed"
#~ msgstr "%s: „%c“ není povoleno"

#~ msgid "'%c' is not allowed"
#~ msgstr "„%c“ není povoleno"

#~ msgid "%s: control characters are not allowed"
#~ msgstr "%s: řídicí znaky nejsou povoleny"

#~ msgid "control characters are not allowed"
#~ msgstr "kontrolní znaky nejsou povoleny"

#~ msgid " -m, --supp-groups        display supplementary groups as well\n"
#~ msgstr " -m, --supp-groups        zobrazí rovněž doplňkové skupiny\n"

#~ msgid ""
#~ "\n"
#~ "For more details see lslogins(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Podrobnosti naleznete v lslogins(1).\n"

#~ msgid "crypt() failed"
#~ msgstr "volání crypt() selhalo"

#~ msgid "%s: stat failed"
#~ msgstr "%s: volání stat selhalo"

#~ msgid " -h, --help                   This small usage guide\n"
#~ msgstr " -h, --help                   Tato malý průvodce použitím\n"

#~ msgid " -V, --version                Output version information\n"
#~ msgstr " -V, --version                Vypíše údaje o verzi\n"

#~ msgid ""
#~ " -a, --alternative      use alternative dictionary\n"
#~ " -d, --alphanum         compare only alphanumeric characters\n"
#~ " -f, --ignore-case      ignore case differences when comparing\n"
#~ " -t, --terminate <char> define string termination character\n"
#~ " -V, --version          output version information and exit\n"
#~ " -h, --help             display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -a, --alternative      použije náhradní slovník\n"
#~ " -d, --alphanum         porovnává pouze písmena a číslice\n"
#~ " -f, --ignore-case      ignoruje velikost znaků při porovnávání\n"
#~ " -t, --terminate <znak> určuje znak zakončující řádek\n"
#~ " -V, --version          zobrazí údaje o verzi a skončí\n"
#~ " -h, --help             zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid ""
#~ "\n"
#~ "For more information see namei(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v namei(1).\n"

#~ msgid "%s: lstat failed"
#~ msgstr "%s: volání lstat selhalo"

#~ msgid ""
#~ "\n"
#~ "For more information see wipefs(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete ve wipefs(8).\n"

#~ msgid ""
#~ "\n"
#~ "For more information see taskset(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v taskset(1).\n"

#~ msgid "%s: is removable device"
#~ msgstr "%s: jedná se o výměnné zařízení"

#~ msgid "%s: connected by hotplug subsystem: %s"
#~ msgstr "%s: připojeno podsystémem hotplug: %s"

#~ msgid "timeout cannot be zero"
#~ msgstr "časový limit nemůže být nula"

#~ msgid "Need to insert %d second and refer time back %.6f seconds ago\n"
#~ msgid_plural "Need to insert %d seconds and refer time back %.6f seconds ago\n"
#~ msgstr[0] "Je třeba vložit %d sekundu a čas vrátit zpět o %.6f sekund\n"
#~ msgstr[1] "Je třeba vložit %d sekundy a čas vrátit zpět o %.6f sekund\n"
#~ msgstr[2] "Je třeba vložit %d sekund a čas vrátit zpět o %.6f sekund\n"

#~ msgid "Waiting in loop for time from KDGHWCLK to change\n"
#~ msgstr "Ve smyčce se pokouším zjistit čas pomocí KDGHWCLK.\n"

#~ msgid "KDGHWCLK ioctl to read time failed"
#~ msgstr "volání KDGHWCLK ioctl selhalo."

#~ msgid "KDGHWCLK ioctl to read time failed in loop"
#~ msgstr "volání KDGHWCLK ioctl ve smyčce selhalo."

#~ msgid "ioctl() failed to read time from %s"
#~ msgstr "čas se pomocí volání ioctl() pro %s nepodařilo zjistit"

#~ msgid "ioctl KDSHWCLK failed"
#~ msgstr "volání ioctl KDSHWCLK selhalo"

#~ msgid "Using the KDGHWCLK interface to m68k clock."
#~ msgstr "Pro hodiny m68k se použije rozhraní KDGHWCLK."

#~ msgid "Can't open /dev/tty1 or /dev/vc/1"
#~ msgstr "/dev/tty1 ani /dev/vc/1 nelze otevřít"

#~ msgid "KDGHWCLK ioctl failed"
#~ msgstr "volání ioctl KDGHWCLK selhalo"

#~ msgid ""
#~ "\n"
#~ "For more details see lscpu(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Podrobnosti naleznete v lscpu(1).\n"

#~ msgid " %s [options] <program> [args...]\n"
#~ msgstr " %s [přepínače] <program> [argument…]\n"

#~ msgid ""
#~ " -g, --pgrp <id>        interpret argument as process group ID\n"
#~ " -n, --priority <num>   specify the nice increment value\n"
#~ " -p, --pid <id>         interpret argument as process ID (default)\n"
#~ " -u, --user <name|id>   interpret argument as username or user ID\n"
#~ " -h, --help             display help text and exit\n"
#~ " -V, --version          display version information and exit\n"
#~ msgstr ""
#~ " -g, --pgrp <ID>        interpretuje argument jako ID skupiny procesů\n"
#~ " -n, --priority <číslo> nastaví přírůstek hodnoty nice\n"
#~ " -p, --pid <ID>         interpretuje argument jako ID procesu (výchozí)\n"
#~ " -u, --user <jméno|ID>  interpretuje argument jako uživatelské jméno nebo ID\n"
#~ " -h, --help             zobrazí nápovědu a skončí\n"
#~ " -v, --version          zobrazí údaje o verzi a skončí\n"

#~ msgid ""
#~ "\n"
#~ "For more information see renice(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v reince(1).\n"

#~ msgid " %s%s [options] [program [program arguments]]\n"
#~ msgstr "%s%s [přepínače] [program [argumenty_programu]]\n"

#~ msgid ""
#~ " -a, --all                enable all swaps from /etc/fstab\n"
#~ " -d, --discard[=<policy>] enable swap discards, if supported by device\n"
#~ " -e, --ifexists           silently skip devices that do not exist\n"
#~ " -f, --fixpgsz            reinitialize the swap space if necessary\n"
#~ " -p, --priority <prio>    specify the priority of the swap device\n"
#~ " -s, --summary            display summary about used swap devices (DEPRECATED)\n"
#~ "     --show[=<columns>]   display summary in definable table\n"
#~ "     --noheadings         don't print headings, use with --show\n"
#~ "     --raw                use the raw output format, use with --show\n"
#~ "     --bytes              display swap size in bytes in --show output\n"
#~ " -v, --verbose            verbose mode\n"
#~ msgstr ""
#~ " -a, --all               zapne všechny odkládací oblasti uvedené v /etc/fstab\n"
#~ " -d, --discard[=<politika>]\n"
#~ "                         zapne zahazování stránek, je-li podporováno zařízením\n"
#~ " -e, --ifexists          v tichosti přeskočí neexistující zařízení\n"
#~ " -f, --fixpgsz           znovu inicializuje odkládací oblast, je-li to nutné\n"
#~ " -p, --priority <priorita>\n"
#~ "                         určí prioritu odkládacího zařízení\n"
#~ " -s, --summary           zobrazí přehled o použitých odkládacích zařízeních\n"
#~ "                         (ZASTARALÉ)\n"
#~ "     --show[=<sloupce>]  zobrazí přehled podle definice\n"
#~ "     --noheadings        nezobrazí záhlaví, použijte s --show\n"
#~ "     --raw               neformátovaný výstup, použijte s --show\n"
#~ "     --bytes             zobrazí velikosti v bajtech ve výstupu --show\n"
#~ " -v, --verbose           upovídaný režim\n"

#~ msgid ""
#~ " -V, --version    output version information and exit\n"
#~ " -h, --help       display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -V, --version    zobrazí údaje o verzi a skončí\n"
#~ " -h, --help       zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ " %s [options] [file ...]\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ " %s [PŘEPÍNAČE] [SOUBOR…]\n"

#~ msgid ""
#~ " -,  --no-underlining  suppress all underlining\n"
#~ " -2, --half-lines      print all half-lines\n"
#~ " -V, --version         output version information and exit\n"
#~ " -h, --help            display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -,  --no-underlining  potlačí všechna podtržení\n"
#~ " -2, --half-lines      zobrazí všechny půlřádky\n"
#~ " -V, --version         zobrazí údaje o verzi a skončí\n"
#~ " -h, --help            zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -V, --version   output version information and exit\n"
#~ " -h, --help      display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -V, --version   zobrazí údaje o verzi a skončí\n"
#~ " -h, --help      zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid "calling hexdump as od has been deprecated in favor of GNU coreutils od"
#~ msgstr "Volání hexdump ve stylu od bylo prohlášeno za zastaralé ve prospěch „od“ z GNU coreutils"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -V, --version   output version information and exit\n"
#~ " -h, --help      display this help and exit\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -V, --version   zobrazí údaje o verzi a skončí\n"
#~ " -h, --help      zobrazí tuto nápovědu a skončí\n"

#~ msgid ""
#~ "\n"
#~ "For more information see rev(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v rev(1).\n"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ " %s [option] file\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ " %s [PŘEPÍNAČ] SOUBOR\n"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -n, --lines NUMBER  output the last NUMBER lines\n"
#~ " -NUMBER             same as `-n NUMBER'\n"
#~ " -V, --version       output version information and exit\n"
#~ " -h, --help          display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínač:\n"
#~ " -n, --lines POČET   vypíše posledních POČET řádků\n"
#~ " -ČÍSLO              stejné jako „-n ČÍSLO“\n"
#~ " -V, --version       zobrazí údaje o verzi a skončí\n"
#~ " -h, --help          zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid " %s [options] file\n"
#~ msgstr " %s [přepínače] soubor\n"

#~ msgid "can only change local entries."
#~ msgstr "měnit lze pouze místní záznamy."

#~ msgid "     --time-format <format>  show time stamp using format:\n"
#~ msgstr "     --time-format <formát>  zobrazuje časové údaje podle daného formátu:\n"

#~ msgid "                               [notime|short|full|iso]\n"
#~ msgstr ""
#~ "                               [notime|short|full|iso]\n"
#~ "                               (bez času, zkrácený, celý, ISO)\n"

#~ msgid " %s [options] pathname [pathname ...]\n"
#~ msgstr " %s [PŘEPÍNAČE] NÁZEV_CESTY [NÁZEV_CESTY…]\n"

#~ msgid "no filename specified."
#~ msgstr "nezadán název souboru."

#~ msgid "...back 1 page"
#~ msgstr "…přeskakuji zpět o 1 stranu"

#~ msgid "...skipping one line"
#~ msgstr "‥přeskakuji o jeden řádek"

#~ msgid "waidpid failed"
#~ msgstr "volání waitpid selhalo"

#~ msgid " -x, --destination <dir>  extract into directory\n"
#~ msgstr " -x, --destination <adresář>  vybalí do adresáře\n"

#~ msgid "compiled without -x support"
#~ msgstr "přeloženo bez podpory pro -x"

#~ msgid "%s: Out of memory!\n"
#~ msgstr "%s: Nedostatek paměti!\n"

#~ msgid "Unusable"
#~ msgstr "Nepoužitelné"

#~ msgid "write failed\n"
#~ msgstr "zápis selhal\n"

#~ msgid "Disk has been changed.\n"
#~ msgstr "Na disku byly provedeny změny.\n"

#~ msgid "Reboot the system to ensure the partition table is correctly updated.\n"
#~ msgstr ""
#~ "Restartujte systém, aby byla jistota, že tabulka rozdělení disku byla\n"
#~ "korektně změněna.\n"

#~ msgid ""
#~ "\n"
#~ "WARNING: If you have created or modified any\n"
#~ "DOS 6.x partitions, please see the cfdisk manual\n"
#~ "page for additional information.\n"
#~ msgstr ""
#~ "\n"
#~ "VAROVÁNÍ: Pokud jste vytvořili či změnili nějaké\n"
#~ "DOS 6.x oddíly, přečtěte si prosím návod k programu\n"
#~ "cfdisk, abyste získali další informace.\n"

#~ msgid "FATAL ERROR"
#~ msgstr "NEPŘEKONATELNÁ CHYBA"

#~ msgid "Press any key to exit cfdisk"
#~ msgstr "Stiskněte jakoukoliv klávesu pro ukončení programu cfdisk"

#~ msgid "Cannot seek on disk drive"
#~ msgstr "Po diskové mechanice se nelze pohybovat"

#~ msgid "Cannot read disk drive"
#~ msgstr "Z diskové mechaniky nelze číst"

#~ msgid "Cannot write disk drive"
#~ msgstr "Do diskové mechaniky nelze zapisovat"

#~ msgid "Too many partitions"
#~ msgstr "Příliš mnoho oddílů"

#~ msgid "Partition begins before sector 0"
#~ msgstr "Oddíl začíná před sektorem 0"

#~ msgid "Partition ends before sector 0"
#~ msgstr "Oddíl končí před sektorem 0"

#~ msgid "Partition begins after end-of-disk"
#~ msgstr "Oddíl začíná za koncem disku"

#~ msgid "Partition ends after end-of-disk"
#~ msgstr "Oddíl končí za koncem disku"

#~ msgid "logical partitions not in disk order"
#~ msgstr "logické oddíly neodpovídají pořadí na disku"

#~ msgid "logical partitions overlap"
#~ msgstr "logické oddíly se překrývají"

#~ msgid "enlarged logical partitions overlap"
#~ msgstr "zvětšené logické oddíly se překrývají"

#~ msgid "!!!! Internal error creating logical drive with no extended partition !!!!"
#~ msgstr "!!!! Vnitřní chyba při vytváření logického disku bez rozšířených oddílů !!!!"

#~ msgid "Cannot create logical drive here -- would create two extended partitions"
#~ msgstr "Zde nelze vytvořit logický disk – vznikly by dva rozšířené oddíly"

#~ msgid "Menu item too long. Menu may look odd."
#~ msgstr "Položka nabídky je příliš dlouhá. Nabídka může vypadat podivně."

#~ msgid "Illegal key"
#~ msgstr "Chybná klávesa"

#~ msgid "Create a new primary partition"
#~ msgstr "Vytvořit nový primární oddíl"

#~ msgid "Create a new logical partition"
#~ msgstr "Vytvořit nový logický oddíl"

#~ msgid "Cancel"
#~ msgstr "Zrušit"

#~ msgid "Don't create a partition"
#~ msgstr "Nevytvářet oddíl"

#~ msgid "!!! Internal error !!!"
#~ msgstr "!!! Vnitřní chyba !!!"

#~ msgid "Size (in MB): "
#~ msgstr "Velikost (v MB): "

#~ msgid "Beginning"
#~ msgstr "Začátek"

#~ msgid "Add partition at beginning of free space"
#~ msgstr "Přidat oddíl na začátek volného prostoru"

#~ msgid "Add partition at end of free space"
#~ msgstr "Přidat oddíl na konec volného prostoru"

#~ msgid "No room to create the extended partition"
#~ msgstr "Pro rozšířený oddíl není dostatek místa"

#~ msgid "No partition table. Starting with zero table."
#~ msgstr "Chybí tabulka rozdělení disku. Začínám s prázdnou tabulkou."

#~ msgid "Bad signature on partition table"
#~ msgstr "Chybná signatura tabulky rozdělení disku"

#~ msgid "Do you wish to start with a zero table [y/N] ?"
#~ msgstr "Přejete si začít s prázdnou tabulkou [a/N]?"

#~ msgid "Cannot open disk drive"
#~ msgstr "Disk nelze otevřít"

#~ msgid "Opened disk read-only - you have no permission to write"
#~ msgstr "Disk byl otevřen pouze pro čtení - nemáte práva pro zápis"

#~ msgid "Cannot get disk size"
#~ msgstr "Velikost disku nelze zjistit"

#~ msgid "Bad primary partition"
#~ msgstr "Chybný primární oddíl"

#~ msgid "Warning!!  This may destroy data on your disk!"
#~ msgstr "Varování!! Toto může vést ke zničení dat na Vašem disku!"

#~ msgid "Please enter `yes' or `no'"
#~ msgstr "Zadejte „ano“ či „ne“"

#~ msgid "Writing partition table to disk..."
#~ msgstr "Ukládám tabulku rozdělení disku na disk…"

#~ msgid "Wrote partition table to disk"
#~ msgstr "Tabulka rozdělení disku byla uložena na disk"

#~ msgid "Wrote partition table, but re-read table failed.  Run partprobe(8), kpartx(8) or reboot to update table."
#~ msgstr ""
#~ "Tabulka rozdělení disku byla uložena, ale nepodařilo se ji znovu načíst.\n"
#~ "Aby se tabulka aktualizovala, spusťte partprobe(8), kpartx(8) nebo\n"
#~ "restartujte systém."

#~ msgid "No primary partitions are marked bootable. DOS MBR cannot boot this."
#~ msgstr "Žádný primární oddíl není startovací. DOS MBR takto nenastartuje."

#~ msgid "More than one primary partition is marked bootable. DOS MBR cannot boot this."
#~ msgstr "Více než jeden primární oddíl je startovací. DOS MBR takto nenastartuje."

#~ msgid "Enter filename or press RETURN to display on screen: "
#~ msgstr "Zadejte název souboru či stiskněte RETURN pro zobrazení: "

#~ msgid "Disk Drive: %s\n"
#~ msgstr "Disk: %s\n"

#~ msgid "Sector 0:\n"
#~ msgstr "Sektor 0:\n"

#~ msgid "Sector %d:\n"
#~ msgstr "Sektor %d:\n"

#~ msgid "   None   "
#~ msgstr "  Žádný  "

#~ msgid "   Pri/Log"
#~ msgstr "  Pri/Log"

#~ msgid "   Primary"
#~ msgstr "  Primární"

#~ msgid "   Logical"
#~ msgstr "  Logický"

#~ msgid "(%02X)"
#~ msgstr "(%02X)"

#~ msgid "None"
#~ msgstr "Nic"

#~ msgid "Partition Table for %s\n"
#~ msgstr "Tabulka rozdělení disku pro %s\n"

#~ msgid "               First       Last\n"
#~ msgstr "             První       Poslední\n"

#~ msgid " # Type       Sector      Sector   Offset    Length   Filesystem Type (ID) Flag\n"
#~ msgstr " # Typ       sektor      sektor    Posun     Délka    ID systému souborů   Příz\n"

#~ msgid "-- ------- ----------- ----------- ------ ----------- -------------------- ----\n"
#~ msgstr "-- ------- ----------- ----------- ------ ----------- -------------------- ----\n"

#~ msgid "         ---Starting----      ----Ending-----    Start     Number of\n"
#~ msgstr "         ----Počátek----      -----Konec-----  Počáteční    Počet\n"

#~ msgid " # Flags Head Sect  Cyl   ID  Head Sect  Cyl     Sector    Sectors\n"
#~ msgstr " # Příz. Hlav Sekt Cyl.   ID  Hlav Sekt Cyl.     Sektor    Sektorů\n"

#~ msgid "-- ----- ---- ---- ----- ---- ---- ---- ----- ----------- -----------\n"
#~ msgstr "-- ----- ---- ---- ----- ---- ---- ---- ----- ----------- -----------\n"

#~ msgid "Raw"
#~ msgstr "Přímý"

#~ msgid "Print the table using raw data format"
#~ msgstr "Vytisknout tabulku v přímém datovém formátu"

#~ msgid "Print the table ordered by sectors"
#~ msgstr "Vytisknout tabulku seřazenou dle sektorů"

#~ msgid "Table"
#~ msgstr "Tabulka"

#~ msgid "Just print the partition table"
#~ msgstr "Vytisknout pouze tabulku rozdělení disku"

#~ msgid "Don't print the table"
#~ msgstr "Netisknout tabulku"

#~ msgid "Copyright (C) 1994-1999 Kevin E. Martin & aeb"
#~ msgstr "Copyright © 1994–1999 Kevin E. Martin & aeb"

#~ msgid "  g          Change cylinders, heads, sectors-per-track parameters"
#~ msgstr "  g          Změní geometrii"

#~ msgid "             WARNING: This option should only be used by people who"
#~ msgstr "             VAROVÁNÍ: Tato volba by měla být používána pouze lidmi,"

#~ msgid "             know what they are doing."
#~ msgstr "             kteří vědí, co činí."

#~ msgid "  m          Maximize disk usage of the current partition"
#~ msgstr "  m          Maximálně zvětší aktuální oddíl "

#~ msgid "             Note: This may make the partition incompatible with"
#~ msgstr "             Poznámka: Toto může učinit oddíl nekompatibilní"

#~ msgid "             DOS, OS/2, ..."
#~ msgstr "             s DOS, OS/2, …"

#~ msgid "  p          Print partition table to the screen or to a file"
#~ msgstr "  p          Vypíše tabulku rozdělení disku na obrazovku či do souboru"

#~ msgid "             There are several different formats for the partition"
#~ msgstr "             Při výpisu tabulky rozdělení disku si můžete zvolit"

#~ msgid "             that you can choose from:"
#~ msgstr "             z několika formátů:"

#~ msgid "                r - Raw data (exactly what would be written to disk)"
#~ msgstr "                r - Přímý (přesně to, co by bylo zapsáno na disk)"

#~ msgid "                s - Table ordered by sectors"
#~ msgstr "                s - Tabulka seřazená dle sektorů"

#~ msgid "  u          Change units of the partition size display"
#~ msgstr "  u          Změní jednotky pro zobrazení velikosti oddílu"

#~ msgid "             Rotates through MB, sectors and cylinders"
#~ msgstr "             Cykluje mezi MB, sektory a cylindry"

#~ msgid "CTRL-L       Redraws the screen"
#~ msgstr "CTRL-L       Překreslí obrazovku"

#~ msgid "  ?          Print this screen"
#~ msgstr "  ?          Vypíše tuto nápovědu"

#~ msgid "Change cylinder geometry"
#~ msgstr "Změní geometrii cylindrů"

#~ msgid "Change head geometry"
#~ msgstr "Změní geometrii hlav"

#~ msgid "Change sector geometry"
#~ msgstr "Změní geometrii sektorů"

#~ msgid "Done with changing geometry"
#~ msgstr "Geometrie změněna"

#~ msgid "Enter the number of cylinders: "
#~ msgstr "Zadejte počet cylindrů: "

#~ msgid "Illegal cylinders value"
#~ msgstr "Chybný počet cylindrů"

#~ msgid "Enter the number of heads: "
#~ msgstr "Zadejte počet hlav: "

#~ msgid "Illegal heads value"
#~ msgstr "Chybný počet hlav"

#~ msgid "Enter the number of sectors per track: "
#~ msgstr "Zadejte počet sektorů na stopu: "

#~ msgid "Illegal sectors value"
#~ msgstr "Chybný počet sektorů"

#~ msgid "Enter filesystem type: "
#~ msgstr "Zadejte typ systému souborů: "

#~ msgid "Cannot change FS Type to empty"
#~ msgstr "Nelze nastavit typ SS na prázdný"

#~ msgid "Cannot change FS Type to extended"
#~ msgstr "Nelze nastavit typ SS na rozšířený"

#~ msgid "Unk(%02X)"
#~ msgstr "Nez(%02X)"

#~ msgid ", NC"
#~ msgstr ", NC"

#~ msgid "NC"
#~ msgstr "NC"

#~ msgid "Pri/Log"
#~ msgstr "Pri/Log"

#~ msgid "Unknown (%02X)"
#~ msgstr "Neznámý (%02X)"

#~ msgid "Disk Drive: %s"
#~ msgstr "Disk: %s"

#~ msgid "Size: %lld bytes, %lld MB"
#~ msgstr "Velikost %'lld bajtů, %'lld MB"

#~ msgid "Size: %lld bytes, %lld.%lld GB"
#~ msgstr "Velikost %'lld bajtů, %'lld,%lld GB"

#~ msgid "Heads: %d   Sectors per Track: %d   Cylinders: %lld"
#~ msgstr "Hlav: %d   Sektorů na stopu: %d    Cylindrů: %'lld"

#~ msgid "Part Type"
#~ msgstr "Typ oddílu"

#~ msgid "FS Type"
#~ msgstr "Typ SS"

#~ msgid "[Label]"
#~ msgstr "[Popis]"

#~ msgid "    Sectors"
#~ msgstr "    Sektorů"

#~ msgid "  Cylinders"
#~ msgstr "  Cylindrů"

#~ msgid "  Size (MB)"
#~ msgstr "Velik. (MB)"

#~ msgid "  Size (GB)"
#~ msgstr "Velik. (GB)"

#~ msgid "No more partitions"
#~ msgstr "Žádné další oddíly"

#~ msgid "Change disk geometry (experts only)"
#~ msgstr "Změní geometrii disku (pouze pro odborníky)"

#~ msgid "Maximize"
#~ msgstr "Zvětšit"

#~ msgid "Maximize disk usage of the current partition (experts only)"
#~ msgstr "Zvětší velikost aktuálního oddílu na maximum (pouze pro odborníky)"

#~ msgid "Print"
#~ msgstr "Tisk"

#~ msgid "Change the filesystem type (DOS, Linux, OS/2 and so on)"
#~ msgstr "Změní typ systému souborů (DOS, Linux, OS/2 atd.)"

#~ msgid "Units"
#~ msgstr "Jednotky"

#~ msgid "Change units of the partition size display (MB, sect, cyl)"
#~ msgstr "Změní jednotky, ve kterých je udávána velikost oddílu (MB, sekt., cyl.)"

#~ msgid "Cannot make this partition bootable"
#~ msgstr "Tento oddíl nelze nastavit jako zaveditelný."

#~ msgid "Cannot delete an empty partition"
#~ msgstr "Prázdný oddíl nelze smazat."

#~ msgid "Cannot maximize this partition"
#~ msgstr "Tento oddíl nelze zvětšit."

#~ msgid "This partition is unusable"
#~ msgstr "Tento oddíl je nepoužitelný."

#~ msgid "This partition is already in use"
#~ msgstr "Tento oddíl je již používán."

#~ msgid "Cannot change the type of an empty partition"
#~ msgstr "Typ prázdného oddílu nelze změnit."

#~ msgid "Illegal command"
#~ msgstr "Chybný příkaz"

#~ msgid "Copyright (C) 1994-2002 Kevin E. Martin & aeb\n"
#~ msgstr "Copyright © 1994–2002 Kevin E. Martin & aeb\n"

#~ msgid " -h, --heads <number>      set the number of heads to use\n"
#~ msgstr " -h, --heads <počet>       nastaví počet hlav\n"

#~ msgid " -g, --guess               guess a geometry from partition table\n"
#~ msgstr " -g, --guess               odhadne geometrii z tabulky rozdělení disku\n"

#~ msgid " -P, --print <r|s|t>       print partition table in specified format\n"
#~ msgstr " -P, --print <r|s|t>       vypíše tabulku rozdělení disku v určené podobě\n"

#~ msgid " -a, --arrow               use arrow for highlighting the current partition\n"
#~ msgstr " -a, --arrow               současný oddíl zvýrazní šipkou\n"

#~ msgid "cannot parse number of cylinders"
#~ msgstr "počet cylindrů nelze rozebrat"

#~ msgid "cannot parse number of heads"
#~ msgstr "počet hlav nelze rozebrat"

#~ msgid "cannot parse number of sectors"
#~ msgstr "počet sektorů nelze rozebrat"

#~ msgid ": "
#~ msgstr ": "

#~ msgid " -b <size>         sector size (512, 1024, 2048 or 4096)\n"
#~ msgstr " -b <velikost>     velikost sektoru (512, 1024, 2048 nebo 4096)\n"

#~ msgid " -h                print this help text\n"
#~ msgstr " -h                vypíše tuto nápovědu\n"

#~ msgid "#"
#~ msgstr "č."

#~ msgid "fsize"
#~ msgstr "fragment"

#~ msgid "bsize"
#~ msgstr "blok"

#~ msgid "Partition %d is already defined.  Delete it before re-adding it."
#~ msgstr "Oddíl %d je již definován. Před opětovným vytvořením jej musíte nejprve smazat."

#~ msgid ""
#~ "Partition type:\n"
#~ "   p   primary (%zd primary, %d extended, %zd free)\n"
#~ "%s\n"
#~ "Select (default %c)"
#~ msgstr ""
#~ "Druh oddílu:\n"
#~ "   p   primární (primárních: %zd, rozšířených: %d, volných: %zd)\n"
#~ "%s\n"
#~ "Vyberte (výchozí %c):"

#~ msgid "   e   extended"
#~ msgstr "   e   rozšířený"

#~ msgid "Nr"
#~ msgstr "Č."

#~ msgid "AF"
#~ msgstr "AF"

#~ msgid "Hd"
#~ msgstr "Hl"

#~ msgid "Sec"
#~ msgstr "Sek"

#~ msgid "Cyl"
#~ msgstr "Cyl"

#~ msgid "This doesn't look like a partition table. Probably you selected the wrong device."
#~ msgstr "Toto nevypadá jako tabulka rozdělení disku. Pravděpodobně jste zvolili špatné zařízení."

#~ msgid "Blocks "
#~ msgstr "Bloky "

#~ msgid "System"
#~ msgstr "Systém"

#~ msgid "Partition %zd is already defined. Delete it before re-adding it."
#~ msgstr "Oddíl %zd je již definován. Před opětovným vytvořením jej musíte nejprve smazat."

#~ msgid "Pt#"
#~ msgstr "ČO"

#~ msgid "Info"
#~ msgstr "Údaje"

#~ msgid "Sector"
#~ msgstr "Sektor"

#~ msgid "You will get a partition overlap on the disk. Fix it first!"
#~ msgstr "Takto se oddíly budou navzájem překrývat. Nejprve to opravte!"

#~ msgid "Warning:  BLKGETSIZE ioctl failed on %s. Using geometry cylinder value of %llu. This value may be truncated for devices > 33.8 GB."
#~ msgstr "Pozor: Ioctl BLKGETSIZE selhalo na %s. Pro geometrii se použije %llu cylindrů. Tato hodnota může být zkrácena pro zařízení > 33,8 GB."

#~ msgid "Flag"
#~ msgstr "Příznak"

#~ msgid ""
#~ " %1$s [options] LABEL=<label>\n"
#~ " %1$s [options] UUID=<uuid>\n"
#~ msgstr ""
#~ " %1$s [přepínače] LABEL=<jmenovka>\n"
#~ " %1$s [přepínače] UUID=<UUID>\n"

#~ msgid ""
#~ " -A, --all              disable all built-in filters, print all filesystems\n"
#~ " -a, --ascii            use ASCII chars for tree formatting\n"
#~ " -c, --canonicalize     canonicalize printed paths\n"
#~ " -D, --df               imitate the output of df(1)\n"
#~ " -d, --direction <word> direction of search, 'forward' or 'backward'\n"
#~ " -e, --evaluate         convert tags (LABEL,UUID,PARTUUID,PARTLABEL) \n"
#~ "                          to device names\n"
#~ " -F, --tab-file <path>  alternative file for --fstab, --mtab or --kernel options\n"
#~ " -f, --first-only       print the first found filesystem only\n"
#~ msgstr ""
#~ " -A, --all              vypne všechny vestavěné filtry, vypíše všechny\n"
#~ "                        souborové systémy\n"
#~ " -a, --ascii            pro vykreslení stromu použije znaky ASCII\n"
#~ " -c, --canonicalize     cesty vypisuje v kanonickém tvaru\n"
#~ " -D, --df               napodobí výstup df(1)\n"
#~ " -d, --direction <směr> směr hledání: „forward“ (dopředné) nebo\n"
#~ "                        „backward“ (zpětné)\n"
#~ " -e, --evaluate         převede značky (jmenovky, UUID, UUID oddílů,\n"
#~ "                        jmenovky oddílů) na názvy zařízení\n"
#~ " -F, --tab-file <cesta> jiný soubor pro přepínače --fstab, --mtab nebo --kernel\n"
#~ " -f, --first-only       vypíše pouze první nalezený souborový systém\n"

#~ msgid ""
#~ " -i, --invert           invert the sense of matching\n"
#~ " -l, --list             use list format output\n"
#~ " -N, --task <tid>       use alternative namespace (/proc/<tid>/mountinfo file)\n"
#~ " -n, --noheadings       don't print column headings\n"
#~ " -u, --notruncate       don't truncate text in columns\n"
#~ msgstr ""
#~ " -i, --invert           obrátí smysl vyhledávacích pravidel\n"
#~ " -l, --list             výstup ve formátu seznamu\n"
#~ " -N, --task <tid>       použije jiný jmenný prostor (/proc/<tid>/mountinfo)\n"
#~ " -n, --noheadings       nezobrazí záhlaví sloupců\n"
#~ " -u, --notruncate       nezkracuje text ve sloupcích\n"

#~ msgid ""
#~ " -v, --nofsroot         don't print [/dir] for bind or btrfs mounts\n"
#~ " -R, --submounts        print all submounts for the matching filesystems\n"
#~ " -S, --source <string>  the device to mount (by name, maj:min, \n"
#~ "                          LABEL=, UUID=, PARTUUID=, PARTLABEL=)\n"
#~ " -T, --target <string>  the mountpoint to use\n"
#~ msgstr ""
#~ " -v, --nofsroot         u vázaných nebo btrfs připojení nevypisuje [/adresář]\n"
#~ " -R, --submounts        u odpovídajících souborových systémů vypisuje všechny\n"
#~ "                        podřízené body přípojení\n"
#~ " -S, --source <řetězec> připojené zařízení (název, hlavní:vedlejší,\n"
#~ "                        LABEL= (jmenovka), UUID=, PARTUUID= (UUID oddílu),\n"
#~ "                        PARTLABEL= (jmenovka oddílu))\n"
#~ " -T, --target <řetězec> bod připojení\n"

#~ msgid ""
#~ " -f, --file <file> use file as a cookie seed\n"
#~ " -v, --verbose     explain what is being done\n"
#~ " -V, --version     output version information and exit\n"
#~ " -h, --help        display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -f, --file SOUBOR  použije soubor jako inicializátor (seed) cookie\n"
#~ " -v, --verbose      vysvětlí, co se právě provádí\n"
#~ " -V, --version      zobrazí údaje o verzi a skončí\n"
#~ " -h, --help         zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid "Both --pid and --no-pid specified. Ignoring --no-pid."
#~ msgstr "Zadány přepínače --pid i --no-pid. Ignoruje se --no-pid."

#~ msgid "warning: error reading %s: %s"
#~ msgstr "varování: chyba při čtení %s: %s"

#~ msgid "warning: can't open %s: %s"
#~ msgstr "pozor: %s nelze otevřít: %s"

#~ msgid "mount: could not open %s - using %s instead\n"
#~ msgstr "mount: %s nelze otevřít – použije se %s\n"

#~ msgid "can't create lock file %s: %s (use -n flag to override)"
#~ msgstr ""
#~ "zamykací soubor %s nelze vytvořit: %s\n"
#~ "(použijte přepínač -n pro vynechání zápisu do mtab)"

#~ msgid "can't link lock file %s: %s (use -n flag to override)"
#~ msgstr ""
#~ "volání link pro zamykací soubor %s selhalo: %s\n"
#~ "(použijte přepínač -n pro vynechání zápisu do mtab)"

#~ msgid "can't open lock file %s: %s (use -n flag to override)"
#~ msgstr ""
#~ "zamykací soubor %s nelze otevřít: %s\n"
#~ "(použijte přepínač -n pro vynechání zápisu do mtab)"

#~ msgid "Can't lock lock file %s: %s\n"
#~ msgstr "Zamykací soubor %s nelze zamknout: %s\n"

#~ msgid "can't lock lock file %s: %s"
#~ msgstr "Zamykací soubor %s nelze zamknout: %s"

#~ msgid ""
#~ "Cannot create link %s\n"
#~ "Perhaps there is a stale lock file?\n"
#~ msgstr ""
#~ "Odkaz %s nelze vytvořit.\n"
#~ "Není někde zastaralý zamykací soubor?\n"

#~ msgid "cannot open %s (%s) - mtab not updated"
#~ msgstr "nelze otevřít %s (%s) - mtab nebyl aktualizován"

#~ msgid "error writing %s: %s"
#~ msgstr "chyba při zápisu %s: %s"

#~ msgid "%s: cannot fflush changes: %s"
#~ msgstr "%s: změny nelze zapsat pomocí fflush: %s"

#~ msgid "error changing mode of %s: %s\n"
#~ msgstr "chyba při změně módu %s: %s\n"

#~ msgid "error changing owner of %s: %s\n"
#~ msgstr "chyba při změně vlastníka %s: %s\n"

#~ msgid "can't rename %s to %s: %s\n"
#~ msgstr "%s nelze přejmenovat na %s: %s\n"

#~ msgid ""
#~ "\n"
#~ "mount: warning: /etc/mtab is not writable (e.g. read-only filesystem).\n"
#~ "       It's possible that information reported by mount(8) is not\n"
#~ "       up to date. For actual information about system mount points\n"
#~ "       check the /proc/mounts file.\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "mount: pozor: Do /etc/mtab nelze zapsat (například systém souborů je pouze\n"
#~ "       pro čtení). Je možné, že údaje hlášené nástrojem mount(8) nebudou\n"
#~ "       aktuální. Aktuální informace o přípojných bodech lze zjistit\n"
#~ "       v souboru /proc/mounts.\n"

#~ msgid "mount: improperly quoted option string '%s'"
#~ msgstr "mount: řetězec přepínačů „%s“ je nesprávně uzavřen do uvozovek"

#~ msgid "mount: translated %s '%s' to '%s'\n"
#~ msgstr "mount: %s přeloženo z „%s“ na „%s“\n"

#~ msgid "mount: SELinux *context= options are ignore on remount.\n"
#~ msgstr "mount: Při přepojení se volby SELinuxu *context= ignorují.\n"

#~ msgid "mount: according to mtab, %s is already mounted on %s"
#~ msgstr "mount: podle mtab je %s již připojeno na %s"

#~ msgid "mount: according to mtab, %s is mounted on %s"
#~ msgstr "mount: podle mtab je %s připojeno na %s"

#~ msgid "mount: can't open %s for writing: %s"
#~ msgstr "mount: %s nelze otevřít pro zápis: %s"

#~ msgid "mount: error writing %s: %s"
#~ msgstr "mount: chyba při zápisu %s: %s"

#~ msgid "mount: error changing mode of %s: %s"
#~ msgstr "mount: chyba při změně módu %s: %s"

#~ msgid "mount: cannot set group id: %m"
#~ msgstr "mount: číslo skupiny (GID) nelze nastavit: %m"

#~ msgid "mount: cannot set user id: %m"
#~ msgstr "mount: číslo uživatele (UID) nelze nastavit: %m"

#~ msgid "mount: cannot fork: %s"
#~ msgstr "mount: volání fork selhalo: %s"

#~ msgid "Trying %s\n"
#~ msgstr "Používám %s.\n"

#~ msgid "mount: you didn't specify a filesystem type for %s\n"
#~ msgstr "mount: nezadal jste typ systému souborů pro %s\n"

#~ msgid "       I will try all types mentioned in %s or %s\n"
#~ msgstr "       Vyzkouším všechny typy v %s či %s\n"

#~ msgid "       and it looks like this is swapspace\n"
#~ msgstr "       a vypadá to, že se jedná o odkládací prostor\n"

#~ msgid "       I will try type %s\n"
#~ msgstr "       Vyzkouším typ %s\n"

#~ msgid "%s looks like swapspace - not mounted"
#~ msgstr "%s vypadá jako odkládací prostor - nepřipojeno"

#~ msgid ""
#~ "mount: %s: more filesystems detected. This should not happen,\n"
#~ "       use -t <type> to explicitly specify the filesystem type or\n"
#~ "       use wipefs(8) to clean up the device.\n"
#~ msgstr ""
#~ "mount: %s: nalezeno více souborových systémů. To by se nemělo stát.\n"
#~ "       Explicitně uveďte druh souborového systému pomocí „-t DRUH“ nebo\n"
#~ "       vyčistěte zařízení pomocí wipefs(8).\n"

#~ msgid "mount: only root can mount %s on %s"
#~ msgstr "mount: pouze superuživatel může připojit %s na %s"

#~ msgid "mount: loop device specified twice"
#~ msgstr "mount: zařízení loop bylo zadáno dvakrát"

#~ msgid "mount: type specified twice"
#~ msgstr "mount: typ byl zadán dvakrát"

#~ msgid "mount: skipping the setup of a loop device\n"
#~ msgstr "mount: přeskakuji nastavení loop zařízení\n"

#~ msgid "mount: enabling autoclear loopdev flag\n"
#~ msgstr "mount: zapíná se automatické odstranění příznaku loopdev\n"

#~ msgid "mount: invalid offset '%s' specified"
#~ msgstr "mount: zadán neplatná pozice „%s“"

#~ msgid "mount: invalid sizelimit '%s' specified"
#~ msgstr "mount: zadáno neplatné omezení délky „%s“"

#~ msgid "mount: according to mtab %s is already mounted on %s as loop"
#~ msgstr "mount: podle mtab je %s již připojeno na %s jako loop"

#~ msgid "encryption not supported, use cryptsetup(8) instead"
#~ msgstr "šifrování není podporováno, použijte cryptsetup(8)"

#~ msgid "mount: failed to initialize loopdev context"
#~ msgstr "mount: kontext zařízení loop se nepodařilo inicializovat"

#~ msgid "mount: failed to use %s device"
#~ msgstr "mount: zařízení %s nebylo možné použít"

#~ msgid "mount: failed to found free loop device"
#~ msgstr "mount: nepodařilo se najít volné zařízení loop"

#~ msgid "mount: going to use the loop device %s\n"
#~ msgstr "mount: chystám se použít zařízení loop %s\n"

#~ msgid "mount: %s: failed to set loopdev attributes"
#~ msgstr "mount: %s: nepodařilo se nastavit vlastnosti zařízení loop"

#~ msgid "mount: %s: failed setting up loop device: %m"
#~ msgstr "mount: %s: nepodařilo se nastavit zařízení loop: %m"

#~ msgid "mount: stolen loop=%s ...trying again\n"
#~ msgstr "mount: ukradený loop=%s … zkusí se znovu\n"

#~ msgid "mount: stolen loop=%s"
#~ msgstr "umount: ukradený loop=%s"

#~ msgid "mount: setup loop device successfully\n"
#~ msgstr "mount: zařízení loop bylo korektně nastaveno\n"

#~ msgid "mount: no %s found - creating it..\n"
#~ msgstr "mount: %s nebylo nalezeno - vytvářím jej..\n"

#~ msgid "mount: cannot open %s for setting speed"
#~ msgstr "mount: %s nelze otevřít za účelem nastavení rychlosti"

#~ msgid "mount: cannot set speed: %m"
#~ msgstr "mount: rychlost nelze nastavit: %m"

#~ msgid "mount: according to mtab, %s is already mounted on %s\n"
#~ msgstr "mount: podle mtab je %s již připojeno do %s\n"

#~ msgid "mount: warning: %s seems to be mounted read-write.\n"
#~ msgstr "mount: pozor: %s se zdá být připojen pro čtení i zápis.\n"

#~ msgid "mount: warning: %s seems to be mounted read-only.\n"
#~ msgstr "mount: pozor: %s se zdá být připojen jen pro čtení.\n"

#~ msgid "mount: I could not determine the filesystem type, and none was specified"
#~ msgstr "mount: typ systému souborů nebyl zadán a ani jej nelze zjistit"

#~ msgid "mount: you must specify the filesystem type"
#~ msgstr "mount: musíte zadat typ systému souborů"

#~ msgid "mount: mount failed"
#~ msgstr "mount: připojení se nezdařilo"

#~ msgid "mount: mount point %s is not a directory"
#~ msgstr "mount: přípojný bod %s není adresářem"

#~ msgid "mount: permission denied"
#~ msgstr "mount: přístup odmítnut"

#~ msgid "mount: must be superuser to use mount"
#~ msgstr "mount: mount může používat pouze superuživatel"

#~ msgid "mount: proc already mounted"
#~ msgstr "mount: proc je již připojeno"

#~ msgid "mount: %s already mounted or %s busy"
#~ msgstr "mount: %s je již připojeno, či je %s již používáno"

#~ msgid "mount: mount point %s does not exist"
#~ msgstr "mount: přípojný bod %s neexistuje"

#~ msgid "mount: mount point %s is a symbolic link to nowhere"
#~ msgstr "mount: přípojný bod %s je symbolickým odkazem, jenž nikam neukazuje"

#~ msgid "mount: special device %s does not exist"
#~ msgstr "mount: speciální zařízení %s neexistuje"

#~ msgid ""
#~ "mount: special device %s does not exist\n"
#~ "       (a path prefix is not a directory)\n"
#~ msgstr ""
#~ "mount: speciální zařízení %s neexistuje\n"
#~ "              (název cesty nezačíná adresářem)\n"

#~ msgid ""
#~ "mount: wrong fs type, bad option, bad superblock on %s,\n"
#~ "       missing codepage or helper program, or other error"
#~ msgstr ""
#~ "mount: chybný typ SS, chybný přepínač, chybný superblok na %s,\n"
#~ "       chybí kódová stránka nebo pomocný program nebo jiná chyba"

#~ msgid ""
#~ "       (could this be the IDE device where you in fact use\n"
#~ "       ide-scsi so that sr0 or sda or so is needed?)"
#~ msgstr ""
#~ "       (mohlo by se jednat o IDE zařízení, kde ve skutečnosti používáte\n"
#~ "       ide-scsi, takže je potřeba sr0 nebo sda nebo něco na ten způsob?)"

#~ msgid ""
#~ "       (aren't you trying to mount an extended partition,\n"
#~ "       instead of some logical partition inside?)"
#~ msgstr "       (nepokoušíte se připojit rozšířený oddíl namísto logického?)"

#~ msgid ""
#~ "       In some cases useful info is found in syslog - try\n"
#~ "       dmesg | tail  or so\n"
#~ msgstr ""
#~ "       V jistých případech lze najít potřebné informace v systémovém\n"
#~ "       protokolu – zkuste například „dmesg | tail“ \n"

#~ msgid "mount: %s: can't read superblock"
#~ msgstr "mount: %s: superblok nelze přečíst"

#~ msgid "mount: %s: unknown device"
#~ msgstr "umount: blokové zařízení %s je neznámé"

#~ msgid "mount: unknown filesystem type '%s'"
#~ msgstr "mount: neznámý systém souborů „%s“"

#~ msgid "mount: probably you meant %s"
#~ msgstr "mount: pravděpodobně jste myslel %s"

#~ msgid "mount: maybe you meant 'iso9660'?"
#~ msgstr "mount: možná jste myslel „iso9660“?"

#~ msgid "mount: maybe you meant 'vfat'?"
#~ msgstr "mount: možná jste myslel „vfat“?"

#~ msgid "mount: %s has wrong device number or fs type %s not supported"
#~ msgstr "mount: %s má chybné číslo zařízení, či ss typ %s není podporován"

#~ msgid "mount: %s is not a block device, and stat fails?"
#~ msgstr "mount: %s není blokovým zařízením a volání stat selhalo?"

#~ msgid ""
#~ "mount: the kernel does not recognize %s as a block device\n"
#~ "       (maybe `modprobe driver'?)"
#~ msgstr ""
#~ "mount: jádro nerozpoznalo %s jako blokové zařízení\n"
#~ "       (možná „modprobe ovladač“?)"

#~ msgid "mount: %s is not a block device (maybe try `-o loop'?)"
#~ msgstr "mount: %s není blokovým zařízením (možná pomůže „-o loop“?)"

#~ msgid "mount: %s is not a block device"
#~ msgstr "mount: %s není blokovým zařízením"

#~ msgid "mount: %s is not a valid block device"
#~ msgstr "mount: %s není platným blokovým zařízením"

#~ msgid "mount: cannot mount %s%s read-only"
#~ msgstr "umount: %s%s nelze připojit v režimu pouze pro čtení"

#~ msgid "mount: %s%s is write-protected but explicit `-w' flag given"
#~ msgstr "mount: %s%s je chráněno proti zápisu, připojuji pouze pro čtení"

#~ msgid "mount: cannot remount %s%s read-write, is write-protected"
#~ msgstr "umount: %s%s nelze znovu připojit pro čtení i zápis, protože je chráněn proti zápisu"

#~ msgid "mount: %s%s is write-protected, mounting read-only"
#~ msgstr "mount: %s%s je chráněno proti zápisu, připojuji pouze pro čtení"

#~ msgid "mount: no medium found on %s"
#~ msgstr "mount: v %s nenalezeno žádné médium"

#~ msgid "mount: no type was given - I'll assume nfs because of the colon\n"
#~ msgstr "mount: nebyl zadán typ - budu používat nfs kvůli dvojtečce\n"

#~ msgid "mount: no type was given - I'll assume cifs because of the // prefix\n"
#~ msgstr "mount: nebyl zadán typ - budu předpokládat cifs kvůli předponě //\n"

#~ msgid "mount: ignore %s (unparsable offset= option)\n"
#~ msgstr "mount: %s se ignoruje (nerozebratelná volba offset=)\n"

#~ msgid ""
#~ "Usage: mount -V                 : print version\n"
#~ "       mount -h                 : print this help\n"
#~ "       mount                    : list mounted filesystems\n"
#~ "       mount -l                 : idem, including volume labels\n"
#~ "So far the informational part. Next the mounting.\n"
#~ "The command is `mount [-t fstype] something somewhere'.\n"
#~ "Details found in /etc/fstab may be omitted.\n"
#~ "       mount -a [-t|-O] ...     : mount all stuff from /etc/fstab\n"
#~ "       mount device             : mount device at the known place\n"
#~ "       mount directory          : mount known device here\n"
#~ "       mount -t type dev dir    : ordinary mount command\n"
#~ "Note that one does not really mount a device, one mounts\n"
#~ "a filesystem (of the given type) found on the device.\n"
#~ "One can also mount an already visible directory tree elsewhere:\n"
#~ "       mount --bind olddir newdir\n"
#~ "or move a subtree:\n"
#~ "       mount --move olddir newdir\n"
#~ "One can change the type of mount containing the directory dir:\n"
#~ "       mount --make-shared dir\n"
#~ "       mount --make-slave dir\n"
#~ "       mount --make-private dir\n"
#~ "       mount --make-unbindable dir\n"
#~ "One can change the type of all the mounts in a mount subtree\n"
#~ "containing the directory dir:\n"
#~ "       mount --make-rshared dir\n"
#~ "       mount --make-rslave dir\n"
#~ "       mount --make-rprivate dir\n"
#~ "       mount --make-runbindable dir\n"
#~ "A device can be given by name, say /dev/hda1 or /dev/cdrom,\n"
#~ "or by label, using  -L label  or by uuid, using  -U uuid .\n"
#~ "Other options: [-nfFrsvw] [-o options] [-p passwdfd].\n"
#~ "For many more details, say  man 8 mount .\n"
#~ msgstr ""
#~ "Použití: mount -V               : vypíše informace o verzi\n"
#~ "         mount -h               : vypíše tuto nápovědu\n"
#~ "         mount                  : zobrazí seznam připojených systémů souborů\n"
#~ "         mount -l               : totéž plus jmenovky svazků\n"
#~ "Toto byly přepínače sloužící k získání informací. Nyní k přepínačům sloužícím\n"
#~ "k připojování systémů souborů.\n"
#~ "Syntaxe je „mount [-t SSTYP] NĚCO NĚKAM“.\n"
#~ "Údaje obsažené v /etc/fstab mohou být vynechány.\n"
#~ "         mount -a [-t|-O] …     : připojí veškeré položky z /etc/fstab\n"
#~ "         mount ZAŘÍZENÍ         : připojí ZAŘÍZENÍ na známé místo\n"
#~ "         mount ADRESÁŘ          : připojí známé zařízení k ADRESÁŘI\n"
#~ "         mount -t TYP ZAŘ ADR   : běžná podoba příkazu pro připojení\n"
#~ "Uvědomte si, že tím, co se připojuje, ve skutečnosti není zařízení, ale systém\n"
#~ "souborů (daného typu), který se na tomto zařízení nachází.\n"
#~ "Můžete také připojit již přístupný adresářový strom na jiné místo:\n"
#~ "         mount --bind STARÝ_ADRESÁŘ NOVÝ_ADRESÁŘ\n"
#~ "nebo přesunout podstrom:\n"
#~ "         mount --move STARÝ_ADRESÁŘ NOVÝ_ADRESÁŘ\n"
#~ "Můžete změnit typ připojení obsahující adresář ADR:\n"
#~ "       mount --make-shared ADR\n"
#~ "       mount --make-slave ADR\n"
#~ "       mount --make-private ADR\n"
#~ "       mount --make-unbindable ADR\n"
#~ "Můžete změnit typ všech připojení v podstromu připojení\n"
#~ "obsahující adresář ADR:\n"
#~ "       mount --make-rshared ADR\n"
#~ "       mount --make-rslave ADR\n"
#~ "       mount --make-rprivate ADR\n"
#~ "       mount --make-runbindable ADR\n"
#~ "Zařízení může být udáno jménem (např. /dev/hda1 či /dev/cdrom), jmenovkou\n"
#~ "(pomocí přepínače -L JMENOVKA) nebo UUID (pomocí přepínače -U UUID).\n"
#~ "Další přepínače: [-nfFrsvw] [-o VOLBY] [-p DESKRIPTOR_S_HESLEM].\n"
#~ "Mnoho dalších informací získáte příkazem „man 8 mount“.\n"

#~ msgid "--pass-fd is no longer supported"
#~ msgstr "přepínač --pass-fd již není podporován"

#~ msgid "mount: only root can do that (effective UID is %u)"
#~ msgstr "mount: toto může provést pouze superuživatel (efektivní UID je %u)"

#~ msgid "mount: only root can do that"
#~ msgstr "mount: toto může provést pouze superuživatel"

#~ msgid "nothing was mounted"
#~ msgstr "nebyl připojen žádný oddíl"

#~ msgid "mount: no such partition found"
#~ msgstr "mount: žádný odpovídající oddíl nebyl nalezen"

#~ msgid "mount: can't find %s in %s or %s"
#~ msgstr "mount: %s nelze nalézt v %s ani %s"

#~ msgid "[mntent]: warning: no final newline at the end of %s\n"
#~ msgstr "[mntent]: varování: %s není ukončeno novou řádkou\n"

#~ msgid "[mntent]: line %d in %s is bad%s\n"
#~ msgstr "[mntent]: řádek %d v %s je chybný%s\n"

#~ msgid "; rest of file ignored"
#~ msgstr "; ignoruji zbytek souboru"

#~ msgid "not enough memory"
#~ msgstr "Nedostatek paměti"

#~ msgid "umount: compiled without support for -f\n"
#~ msgstr "umount byl přeložen bez podpory pro -f\n"

#~ msgid "umount: cannot set group id: %m"
#~ msgstr "umount: číslo skupiny (GID) nelze nastavit: %m"

#~ msgid "umount: cannot set user id: %m"
#~ msgstr "umount: číslo uživatele (UID) nelze nastavit: %m"

#~ msgid "umount: cannot fork: %s"
#~ msgstr "umount: volání fork selhalo: %s"

#~ msgid "umount: %s: invalid block device"
#~ msgstr "umount: blokové zařízení %s je chybné"

#~ msgid "umount: %s: not mounted"
#~ msgstr "umount: %s není připojeno"

#~ msgid "umount: %s: can't write superblock"
#~ msgstr "umount: superblok nelze na %s zapsat"

#~ msgid ""
#~ "umount: %s: device is busy.\n"
#~ "        (In some cases useful info about processes that use\n"
#~ "         the device is found by lsof(8) or fuser(1))"
#~ msgstr ""
#~ "umount: %s: zařízení je používáno.\n"
#~ "        (V některých případech lze získat užitečné informace o procesech,\n"
#~ "        které se zařízením pracují, pomocí nástrojů lsof(8) a fuser(1).)"

#~ msgid "umount: %s: not found"
#~ msgstr "umount: %s nelze najít"

#~ msgid "umount: %s: must be superuser to umount"
#~ msgstr "umount: musíte být superuživatelem, abyste mohl odpojit %s"

#~ msgid "umount: %s: block devices not permitted on fs"
#~ msgstr "umount: %s: bloková zařízení nejsou na systému souborů povolena"

#~ msgid "umount: %s: %s"
#~ msgstr "umount: %s: %s"

#~ msgid "umount: internal error: invalid abs path: %s"
#~ msgstr "umount: vnitřní chyba: nepatní absolutní cesta: %s"

#~ msgid "umount: failed to chdir to %s: %m"
#~ msgstr "umount: do adresáře %s nelze přejít: %m"

#~ msgid "umount: failed to obtain current directory: %m"
#~ msgstr "umount: aktuální adresář nelze zjistit: %m"

#~ msgid "umount: mountpoint moved (%s -> %s)"
#~ msgstr "umount: přípojný bod přemístěn (%s → %s)"

#~ msgid "current directory moved to %s\n"
#~ msgstr "aktuální adresář přemístěn do %s\n"

#~ msgid "no umount2, trying umount...\n"
#~ msgstr "nenalezl jsem umount2, zkouším umount…\n"

#~ msgid "umount: %s busy - remounted read-only\n"
#~ msgstr "umount: %s je právě používáno - znovu připojeno v režimu pro pouze čtení\n"

#~ msgid "umount: could not remount %s read-only\n"
#~ msgstr "umount: %s nelze znovu připojit v režimu pouze pro čtení\n"

#~ msgid "%s has been unmounted\n"
#~ msgstr "%s bylo odpojeno\n"

#~ msgid "umount: cannot find list of filesystems to unmount"
#~ msgstr "umount: seznam systémů souborů na odpojení nelze nalézt"

#~ msgid ""
#~ "Usage: umount -h | -V\n"
#~ "       umount -a [-d] [-f] [-r] [-n] [-v] [-t vfstypes] [-O opts]\n"
#~ "       umount [-d] [-f] [-r] [-n] [-v] special | node...\n"
#~ msgstr ""
#~ "Použití: umount -h | -V\n"
#~ "         umount -a [-d] [-f] [-r] [-n] [-v] [-t TYPY_VFS] [-O VOLBY]\n"
#~ "         umount [-d] [-f] [-r] [-n] [-v] SPECIÁLNÍ_SOUBOR | UZEL…\n"

#~ msgid "failed to parse 'offset=%s' options\n"
#~ msgstr "nezdařilo rozebrat volby „offset=%s“\n"

#~ msgid "device %s is associated with %s\n"
#~ msgstr "zařízení %s je spojeno s %s\n"

#~ msgid "Cannot unmount \"\"\n"
#~ msgstr "„“ nelze odpojit\n"

#~ msgid "umount: confused when analyzing mtab"
#~ msgstr "umount: analýza mtab dává matoucí výsledky"

#~ msgid "umount: cannot unmount %s -- %s is mounted over it on the same point"
#~ msgstr "umount: %s nelze odpojit – na stejné místo je přes něj připojeno %s"

#~ msgid "Could not find %s in mtab\n"
#~ msgstr "%s nelze v mtab najít\n"

#~ msgid "umount: warning: %s is associated with more than one loop device\n"
#~ msgstr "umount: pozor: %s je spojeno s více jak jedním loop zařízením\n"

#~ msgid "umount: %s is not mounted (according to mtab)"
#~ msgstr "umount: podle mtab není %s připojeno"

#~ msgid "umount: it seems %s is mounted multiple times"
#~ msgstr "umount: zdá se, že %s je připojeno více než jednou"

#~ msgid "umount: %s is not in the fstab (and you are not root)"
#~ msgstr "umount: %s není ve fstab (a vy nejste root)"

#~ msgid "umount: %s mount disagrees with the fstab"
#~ msgstr "umount: připojení %s neodpovídá fstab"

#~ msgid "umount: only %s can unmount %s from %s"
#~ msgstr "unmount: pouze uživatel %s může odpojit %s ze %s"

#~ msgid "umount: only root can do that"
#~ msgstr "umount: toto může provést pouze uživatel root"

#~ msgid ""
#~ "\n"
#~ "%1$s - sets or gets process io scheduling class and priority.\n"
#~ "\n"
#~ "Usage:\n"
#~ "  %1$s [OPTION] -p PID [PID...]\n"
#~ "  %1$s [OPTION] COMMAND\n"
#~ "\n"
#~ "Options:\n"
#~ "  -c, --class <class>   scheduling class name or number\n"
#~ "                           0: none, 1: realtime, 2: best-effort, 3: idle\n"
#~ "  -n, --classdata <num> scheduling class data\n"
#~ "                           0-7 for realtime and best-effort classes\n"
#~ "  -p, --pid=PID         view or modify already running process\n"
#~ "  -t, --ignore          ignore failures\n"
#~ "  -V, --version         output version information and exit\n"
#~ "  -h, --help            display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "%1$s – zjistí nebo nastaví plánovací třídu nebo prioritu I/O.\n"
#~ "\n"
#~ "Použití:\n"
#~ "  %1$s [PŘEPÍNAČ] -p PID [PID…]\n"
#~ "  %1$s [PŘEPÍNAČ] PŘÍKAZ\n"
#~ "\n"
#~ "Přepínače:\n"
#~ "  -c, --class TŘÍDA      název nebo číslo plánovací třídy\n"
#~ "                         0: none [žádná], 1: realtime [reálný čas],\n"
#~ "                         2: best-effort, 3: idle [zahálení]\n"
#~ "  -n, --classdata ČÍSLO  data plánovací třídy\n"
#~ "                         0-7 přo třídy reálného času a best-effort\n"
#~ "  -p, --pid=PID          zobrazí nebo změní již běžící proces\n"
#~ "  -t, --ignore           ignoruje selhání\n"
#~ "  -V, --version          zobrazí údaje o verzi a skončí\n"
#~ "  -h, --help             zobrazí tuto nápovědu\n"
#~ "\n"

#~ msgid " %s [options] <tty> [...]\n"
#~ msgstr " %s [přepínače] <TTY> […]\n"

#~ msgid " -s, --set-threshold <num>          set interruption threshold value\n"
#~ msgstr " -s, --set-threshold <číslo>        nastaví prahovou hodnotu přerušení\n"

#~ msgid " -S, --set-default-threshold <num>  set default threshold value\n"
#~ msgstr " -S, --set-default-threshold <číslo> nastaví výchozí prahovou hodnotu\n"

#~ msgid " -t, --set-flush <num>              set flush timeout to value\n"
#~ msgstr " -t, --set-flush <číslo>            nastaví časový limit pro vyprázdnění\n"

#~ msgid " -T, --set-default-flush <num>      set the default flush timeout to value\n"
#~ msgstr ""
#~ " -T, --set-default-flush <číslo>    nastaví výchozí výchozí časový limit\n"
#~ "                                    pro vyprázdnění\n"

#~ msgid " -i, --interval <seconds>           gather statistics every <seconds> interval\n"
#~ msgstr " -i, --interval <sekundy>           sebere statistické údaje každých <sekund>\n"

#~ msgid ""
#~ "File %s, For threshold value %lu, Maximum characters in fifo were %d,\n"
#~ "and the maximum transfer rate in characters/second was %f"
#~ msgstr ""
#~ "Soubor %s, pro prahovou hodnotu %lu, maximální počet znaků ve frontě\n"
#~ "byl %d a maximální přenosová rychlost ve znacích za sekundu byla %f"

#~ msgid ""
#~ "File %s, For threshold value %lu and timeout value %lu, Maximum characters in fifo were %d,\n"
#~ "and the maximum transfer rate in characters/second was %f"
#~ msgstr ""
#~ "Soubor %s, pro prahovou hodnotu %lu a časový limit %lu, maximální počet znaků\n"
#~ "ve frontě byl %d a maximální přenosová rychlost ve znacích za sekundu\n"
#~ "byla %f"

#~ msgid "cannot issue CYGETMON on %s"
#~ msgstr "CYGETMON nelze na %s provést"

#~ msgid "cannot get threshold for %s"
#~ msgstr "prahovou hodnotu pro %s nelze zjistit"

#~ msgid "cannot get timeout for %s"
#~ msgstr "časový limit pro %s nelze zjistit"

#~ msgid "%s: %lu ints, %lu/%lu chars; fifo: %lu thresh, %lu tmout, %lu max, %lu now\n"
#~ msgstr "%s: %lu přerušení, %lu/%lu znaků; fifo: %lu práh, %lu časový limit, %lu max, %lu nyní\n"

#~ msgid "   %f int/sec; %f rec, %f send (char/sec)\n"
#~ msgstr "   %f přer./s; %f příj., %f odesl. (znak/s)\n"

#~ msgid "%s: %lu ints, %lu chars; fifo: %lu thresh, %lu tmout, %lu max, %lu now\n"
#~ msgstr "%s: %lu přerušení, %lu znaků; fifo: %lu práh, %lu časový limit, %lu max, %lu nyní\n"

#~ msgid "   %f int/sec; %f rec (char/sec)\n"
#~ msgstr "   %f přer./s; %f příj. (znak/s)\n"

#~ msgid "Invalid interval value"
#~ msgstr "Chybná hodnota rozpětí"

#~ msgid "Invalid interval value: %d"
#~ msgstr "Chybná hodnota rozpětí: %d"

#~ msgid "Invalid set value"
#~ msgstr "Chybná hodnota k nastavení"

#~ msgid "Invalid set value: %d"
#~ msgstr "Chybná hodnota k nastavení: %d"

#~ msgid "Invalid default value"
#~ msgstr "Chybná výchozí hodnota"

#~ msgid "Invalid default value: %d"
#~ msgstr "Chybná výchozí hodnota: %d"

#~ msgid "Invalid set time value"
#~ msgstr "Chybný časový údaj k nastavení"

#~ msgid "Invalid set time value: %d"
#~ msgstr "Chybný časový údaj k nastavení: %d"

#~ msgid "Invalid default time value"
#~ msgstr "Chybný výchozí časový údaj"

#~ msgid "Invalid default time value: %d"
#~ msgstr "Chybný výchozí časový údaj: %d"

#~ msgid "cannot set %s to threshold %d"
#~ msgstr "%s nelze nastavit na prahovou hodnotu %d"

#~ msgid "cannot set %s to time threshold %d"
#~ msgstr "%s nelze nastavit na časový limit %d"

#~ msgid "%s: %ld current threshold and %ld current timeout\n"
#~ msgstr "%s: %ld současná prahová hodnota a %ld současný časový limit\n"

#~ msgid "%s: %ld default threshold and %ld default timeout\n"
#~ msgstr "%s: %ld výchozí prahová hodnota a %ld výchozí časový limit\n"

#~ msgid ""
#~ " -n, --keep-size     don't modify the length of the file\n"
#~ " -p, --punch-hole    punch holes in the file\n"
#~ " -o, --offset <num>  offset of the allocation, in bytes\n"
#~ " -l, --length <num>  length of the allocation, in bytes\n"
#~ msgstr ""
#~ " -n, --keep-size       nemění délku souboru\n"
#~ " -p, --punch-hole      vyrazí do souboru díry\n"
#~ " -o, --offset <číslo>  pozice alokace v bajtech\n"
#~ " -l, --length <číslo>  délka alokace v bajtech\n"

#~ msgid ""
#~ " -o, --offset <num>  offset in bytes to discard from\n"
#~ " -l, --length <num>  length of bytes to discard from the offset\n"
#~ " -m, --minimum <num> minimum extent length to discard\n"
#~ " -v, --verbose       print number of discarded bytes\n"
#~ msgstr ""
#~ " -o, --offset <číslo>   začátek zahoditelné oblasti v bajtech\n"
#~ " -l, --length <číslo>   délka zahoditelné oblasti v bajtech\n"
#~ " -m, --minimum <číslo>  délka nejmenšího zahoditelného rozsahu\n"
#~ " -v, --verbose          vypíše počet zahozených bajtů\n"

#~ msgid ""
#~ "Time elapsed since reference time has been %.6f seconds.\n"
#~ "Delaying further to reach the new time.\n"
#~ msgstr ""
#~ "Počet sekund uplynulých od referenčního času: %.6f.\n"
#~ "Čekám, dokud nebude dosažen nový čas.\n"

#~ msgid " -term <terminal_name>\n"
#~ msgstr " -term <název_terminálu>\n"

#~ msgid " -reset\n"
#~ msgstr " -reset\n"

#~ msgid " -initialize\n"
#~ msgstr " -initialize\n"

#~ msgid " -cursor <on|off>\n"
#~ msgstr " -cursor <on|off>\n"

#~ msgid " -repeat <on|off>\n"
#~ msgstr " -repeat <on|off>\n"

#~ msgid " -appcursorkeys <on|off>\n"
#~ msgstr " -appcursorkeys <on|off>\n"

#~ msgid " -linewrap <on|off>\n"
#~ msgstr " -linewrap <on|off>\n"

#~ msgid " -default\n"
#~ msgstr " -default\n"

#~ msgid " -foreground <default|black|blue|cyan|green|magenta|red|white|yellow>\n"
#~ msgstr " -foreground <default|black|blue|cyan|green|magenta|red|white|yellow>\n"

#~ msgid " -background <default|black|blue|cyan|green|magenta|red|white|yellow>\n"
#~ msgstr " -background <default|black|blue|cyan|green|magenta|red|white|yellow>\n"

#~ msgid " -hbcolor <black|blue|bright|cyan|green|grey|magenta|red|white|yellow>\n"
#~ msgstr " -hbcolor <black|blue|bright|cyan|green|grey|magenta|red|white|yellow>\n"

#~ msgid " -inversescreen <on|off>\n"
#~ msgstr " -inversescreen <on|off>\n"

#~ msgid " -bold <on|off>\n"
#~ msgstr " -bold <on|off>\n"

#~ msgid " -blink <on|off>\n"
#~ msgstr " -blink <on|off>\n"

#~ msgid " -reverse <on|off>\n"
#~ msgstr " -reverse <on|off>\n"

#~ msgid " -underline <on|off>\n"
#~ msgstr " -underline <on|off>\n"

#~ msgid " -store\n"
#~ msgstr " -store\n"

#~ msgid " -clear <all|rest>\n"
#~ msgstr " -clear <all|rest>\n"

#~ msgid " -tabs <tab1 tab2 tab3 ...>      (tabn = 1-160)\n"
#~ msgstr " -tabs <tab1 tab2 tab3…>      (index tabulátoru = 1-160)\n"

#~ msgid " -clrtabs <tab1 tab2 tab3 ...>   (tabn = 1-160)\n"
#~ msgstr " -clrtabs <tab1 tab2 tab3…>      (index tabulátoru = 1-160)\n"

#~ msgid " -regtabs <1-160>\n"
#~ msgstr " -regtabs <1-160>\n"

#~ msgid " -blank <0-60|force|poke>\n"
#~ msgstr " -blank <0-60|force|poke>\n"

#~ msgid " -dump   <1-NR_CONSOLES>\n"
#~ msgstr " -dump   <1-POČET_KONZOLÍ]>\n"

#~ msgid " -append <1-NR_CONSOLES>\n"
#~ msgstr " -append <1-POČET_KONZOLÍ>\n"

#~ msgid " -file dumpfilename\n"
#~ msgstr " -file výstupní_soubor\n"

#~ msgid " -msg <on|off>\n"
#~ msgstr " -msg <on|off>\n"

#~ msgid " -msglevel <0-8>\n"
#~ msgstr " -msglevel <0-8>\n"

#~ msgid " -powerdown <0-60>\n"
#~ msgstr " -powerdown <0-60>\n"

#~ msgid " -blength <0-2000>\n"
#~ msgstr " -blength <0-2000>\n"

#~ msgid " -bfreq freqnumber\n"
#~ msgstr " -bfreq frekvence\n"

#~ msgid "Error writing screendump"
#~ msgstr "Chyba při ukládání obsahu obrazovky"

#~ msgid "Couldn't read neither /dev/vcsa0 nor /dev/vcsa"
#~ msgstr "Ani /dev/vcs0 ani /dev/vcsa nebylo možné přečíst"

#~ msgid ""
#~ "Usage: %s [options] file...\n"
#~ "\n"
#~ msgstr ""
#~ "Použití: %s [přepínače] soubor…\n"
#~ "\n"

#~ msgid ""
#~ "Options:\n"
#~ "  -d        display help instead of ring bell\n"
#~ "  -f        count logical, rather than screen lines\n"
#~ "  -l        suppress pause after form feed\n"
#~ "  -p        do not scroll, clean screen and display text\n"
#~ "  -c        do not scroll, display text and clean line ends\n"
#~ "  -u        suppress underlining\n"
#~ "  -s        squeeze multiple blank lines into one\n"
#~ "  -NUM      specify the number of lines per screenful\n"
#~ "  +NUM      display file beginning from line number NUM\n"
#~ "  +/STRING  display file beginning from search string match\n"
#~ "  -V        output version information and exit\n"
#~ msgstr ""
#~ "Přepínače:\n"
#~ "  -d        zobrazí nápovědu namísto zvonku\n"
#~ "  -f        počítá logicky namísto řádků obrazovky\n"
#~ "  -l        potlačí pauzu po posunu (po form feed)\n"
#~ "  -p        neposunuje obrazovku, smaže obrazovku a zobrazí text\n"
#~ "  -c        neposunuje obrazovku, zobrazí text a odstraní konce řádků\n"
#~ "  -u        potlačí podtržení\n"
#~ "  -s        opakující se prázdné řádky srazí do jednoho\n"
#~ "  -ČÍSLO    určuje počet řádků na obrazovku\n"
#~ "  +ČÍSLO    zobrazí soubor počínaje řádkem ČÍSLO\n"
#~ "  +/ŘETĚZEC zobrazí soubor počínaje řádkem shodujícím se s ŘÁDKEM\n"
#~ "  -V        zobrazí údaje o verzi a skončí\n"

#~ msgid "line too long"
#~ msgstr "řádek je příliš dlouhý"

#~ msgid "set blocksize"
#~ msgstr "nastaví velikost bloku"

#~ msgid "one bad block\n"
#~ msgstr "chybných bloků: 1\n"

#~ msgid "partition type hex or uuid"
#~ msgstr "druh oddílu šestnáctkově nebo UUID"

#~ msgid " %s [options] device\n"
#~ msgstr " %s [přepínače] zařízení\n"

#~ msgid "read failed %s"
#~ msgstr "čtení z %s selhalo"

#~ msgid "seek failed %s"
#~ msgstr "chyba při pohybu v souboru %s"

#~ msgid "seek failed: %d"
#~ msgstr "chyba při pohybu v souboru: %d"

#~ msgid "No partitions defined"
#~ msgstr "Nejsou definovány žádné oddíly"

#~ msgid ""
#~ " -a, --all                     list all used devices\n"
#~ " -d, --detach <loopdev> [...]  detach one or more devices\n"
#~ " -D, --detach-all              detach all used devices\n"
#~ " -f, --find                    find first unused device\n"
#~ " -c, --set-capacity <loopdev>  resize device\n"
#~ " -j, --associated <file>       list all devices associated with <file>\n"
#~ msgstr ""
#~ " -a, --all                     vypíše všechna použitá zařízení\n"
#~ " -d, --detach <loop_zařízení> […]\n"
#~ "                               odpojí jedno nebo více zařízení\n"
#~ " -D, --detach-all              odpojí všechna používaná zařízení\n"
#~ " -f, --find                    najde první nepoužité zařízení\n"
#~ " -c, --set-capacity <loop_zařízení>\n"
#~ "                               změní velikost\n"
#~ " -j, --associated <soubor>     vypíše všechna zařízení spojená se <souborem>\n"

#~ msgid "%s: failed to set up loop device, offset is not 512-byte aligned."
#~ msgstr "%s: zařízení loop se nepodařilo nastavit, pozice není zarovnána na 512 bajtů."

#~ msgid "unssuported --local-line mode argument"
#~ msgstr "nepodporovaný argument s režimem --local-line"

#~ msgid "usage:\n"
#~ msgstr "Použití:\n"

#~ msgid "\tNOTE: elvtune only works with 2.4 kernels\n"
#~ msgstr "\tPOZNÁMKA: elvtune funguje jen s jádry řady 2.4\n"

#~ msgid "missing blockdevice, use -h for help\n"
#~ msgstr "chybí blokové zařízení, nápovědu získáte pomocí -h\n"

#~ msgid ""
#~ "\n"
#~ "elvtune is only useful on older kernels;\n"
#~ "for 2.6 use IO scheduler sysfs tunables instead..\n"
#~ msgstr ""
#~ "\n"
#~ "elvtune se hodí jen pro starší jádra;\n"
#~ "pro řadu 2.6 použijte sysfs rozhraní pro ladění plánovače I/O.\n"

#~ msgid "fsync failed"
#~ msgstr "volání fsync selhalo"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ "Print version:\n"
#~ "        %s -v\n"
#~ "Print partition table:\n"
#~ "        %s -P {r|s|t} [options] device\n"
#~ "Interactive use:\n"
#~ "        %s [options] device\n"
#~ "\n"
#~ "Options:\n"
#~ "-a: Use arrow instead of highlighting;\n"
#~ "-z: Start with a zero partition table, instead of reading the pt from disk;\n"
#~ "-c C -h H -s S: Override the kernel's idea of the number of cylinders,\n"
#~ "                the number of heads and the number of sectors/track.\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ "Vypíše informace o verzi:\n"
#~ "        %s -v\n"
#~ "Vypíše tabulku rozdělení disku:\n"
#~ "        %s -P {r|s|t} [přepínače] zařízení\n"
#~ "Interaktivní režim:\n"
#~ "        %s [přepínače] zařízení\n"
#~ "\n"
#~ "Přepínače:\n"
#~ "-a: Namísto zvýrazňování použije šipku;\n"
#~ "-z: Začne s nulovou tabulkou rozdělení disku místo, aby ji četl z disku;\n"
#~ "-c C -h H -s S: Zadání geometrie disku (má přednost před údaji, které udržuje\n"
#~ "                jádro.\n"
#~ "\n"

#~ msgid "Writing disklabel to %s.\n"
#~ msgstr "Ukládám popis disku na %s.\n"

#~ msgid "Last %s or +size or +sizeM or +sizeK"
#~ msgstr "Poslední %s či +velikost či +velikostM či +velikostK"

#~ msgid "Reading disklabel of %s at sector %d.\n"
#~ msgstr "Čtu popis disku %s v sektoru %d.\n"

#~ msgid "BSD disklabel command (m for help): "
#~ msgstr "Příkaz pro BSD popis disku (m pro nápovědu): "

#~ msgid "drivedata: "
#~ msgstr "diskdata: "

#~ msgid "#       start       end      size     fstype   [fsize bsize   cpg]\n"
#~ msgstr "#       velik       konec    velikost sstyp    [fveli bveli   cpg]\n"

#~ msgid "Must be <= sectors/track * tracks/cylinder (default).\n"
#~ msgstr "Musí být <= sektorů/stopu * stop/cylindr (implicitní).\n"

#~ msgid "Partition (a-%c): "
#~ msgstr "Diskový oddíl (a-%c): "

#~ msgid "Warning: too many partitions (%d, maximum is %d).\n"
#~ msgstr "Varování: příliš mnoho oddílů (%d, maximum %d).\n"

#~ msgid ""
#~ "\n"
#~ "Syncing disks.\n"
#~ msgstr ""
#~ "\n"
#~ "Synchronizují se disky.\n"

#~ msgid ""
#~ "Usage:\n"
#~ " %1$s [options] <disk>    change partition table\n"
#~ " %1$s [options] -l <disk> list partition table(s)\n"
#~ " %1$s -s <partition>      give partition size(s) in blocks\n"
#~ "\n"
#~ "Options:\n"
#~ " -b <size>             sector size (512, 1024, 2048 or 4096)\n"
#~ " -c[=<mode>]           compatible mode: 'dos' or 'nondos' (default)\n"
#~ " -h                    print this help text\n"
#~ " -u[=<unit>]           display units: 'cylinders' or 'sectors' (default)\n"
#~ " -v                    print program version\n"
#~ " -C <number>           specify the number of cylinders\n"
#~ " -H <number>           specify the number of heads\n"
#~ " -S <number>           specify the number of sectors per track\n"
#~ "\n"
#~ msgstr ""
#~ "Použití:\n"
#~ " %1$s [PŘEPÍNAČE] <DISK>    změní tabulku rozdělení disku\n"
#~ " %1$s [PŘEPÍNAČE] -l <DISK> vypíše tabulku(y) rozdělení disku\n"
#~ " %1$s -s <ODDÍL>            vypíše velikost(i) oddílu v blocích\n"
#~ "\n"
#~ "Přepínače:\n"
#~ " -b <VELIKOST>               velikost sektoru (512, 1024, 2048 nebo 4096)\n"
#~ " -c[=<REŽIM>]                režim kompatibility: „dos“ nebo „nondos“ (implic.)\n"
#~ " -h                          vypíše tuto nápovědu\n"
#~ " -u=[<JEDNOTKA>]             zobrazuje v jednotkách: „cylinders“ (cylindry)\n"
#~ "                             nebo „sectors“ (sektory)\n"
#~ " -v                          vypíše verzi programu\n"
#~ " -C <POČET>                  určuje počet cylindrů\n"
#~ " -H <POČET>                  určuje počet hlav\n"
#~ " -S <POČET>                  určuje počet sektorů na stopu\n"
#~ "\n"

#~ msgid "unable to seek on %s"
#~ msgstr "nelze se posunout na %s"

#~ msgid "unable to write %s"
#~ msgstr "%s nelze zapsat"

#~ msgid "fatal error"
#~ msgstr "fatální chyba"

#~ msgid "Command action"
#~ msgstr "Příkazy"

#~ msgid "You must set"
#~ msgstr "Musíte nastavit"

#~ msgid "heads"
#~ msgstr "hlavy"

#~ msgid " and "
#~ msgstr " a "

#~ msgid "Unsupported suffix: '%s'.\n"
#~ msgstr "Nepodporovaná přípona: „%s“.\n"

#~ msgid ""
#~ "Supported: 10^N: KB (KiloByte), MB (MegaByte), GB (GigaByte)\n"
#~ "            2^N: K  (KibiByte), M  (MebiByte), G  (GibiByte)\n"
#~ msgstr ""
#~ "Podporované: 10^N: KB (kilobajt), MB (megabajt), GB (gigabajt)\n"
#~ "              2^N: K  (kibibajt), M  (mebibajt), G  (gibibajt)\n"

#~ msgid "Using default value %u\n"
#~ msgstr "Používám implicitní hodnotu %u\n"

#~ msgid ""
#~ "\n"
#~ "Disk %s: %ld MB, %lld bytes"
#~ msgstr ""
#~ "\n"
#~ "Disk %s: %'ld MB, %'lld bajtů"

#~ msgid ""
#~ "\n"
#~ "Disk %s: %ld.%ld GB, %llu bytes"
#~ msgstr ""
#~ "\n"
#~ "Disk %s: %'ld,%ld GB, %'llu bajtů"

#~ msgid "cannot write disk label"
#~ msgstr "popis disku nelze zapsat"

#~ msgid ""
#~ "\n"
#~ "Error closing file\n"
#~ msgstr ""
#~ "\n"
#~ "Chyba při zavírání souboru\n"

#~ msgid "Warning: setting sector offset for DOS compatibility\n"
#~ msgstr "Pozor: nastaven posun sektoru kvůli kompatibilitě s DOSem\n"

#~ msgid "Detected an OSF/1 disklabel on %s, entering disklabel mode.\n"
#~ msgstr "Na %s nalezen OSF/1 popis disku. Spouštím režim popisu disku.\n"

#~ msgid ""
#~ "\n"
#~ "WARNING: DOS-compatible mode is deprecated. It's strongly recommended to\n"
#~ "         switch off the mode (with command 'c')."
#~ msgstr ""
#~ "\n"
#~ "POZOR: Režim kompatibility s DOSem je zastaralý. Důrazně se doporučuje tento\n"
#~ "       režim vypnout (příkaz „c“)."

#~ msgid ""
#~ "\n"
#~ "WARNING: cylinders as display units are deprecated. Use command 'u' to\n"
#~ "         change units to sectors.\n"
#~ msgstr ""
#~ "\n"
#~ "POZOR: cylindry jakožto jednotky výpisů jsou zastaralé. Jednotky lze změnit\n"
#~ "         na sektory pomocí příkazu „u“.\n"

#~ msgid "New disk identifier (current 0x%08x): "
#~ msgstr "Nový identifikátor disku (současný 0x%08x): "

#~ msgid "No free sectors available\n"
#~ msgstr "Nejsou žádné volné sektory.\n"

#~ msgid "Last %1$s, +%2$s or +size{K,M,G}"
#~ msgstr "Poslední %1$s, +%2$s nebo +velikost{K,M,G}"

#~ msgid "     phys=(%d, %d, %d) "
#~ msgstr "     fyz=(%d, %d, %d) "

#~ msgid "logical=(%d, %d, %d)\n"
#~ msgstr "logický=(%d, %d, %d)\n"

#~ msgid "Warning: bad start-of-data in partition %zd\n"
#~ msgstr "Pozor: chybný počátek dat v oddíle %zd\n"

#~ msgid "Adding a primary partition\n"
#~ msgstr "Přidává se primární oddíl\n"

#~ msgid "%*s Boot      Start         End      Blocks   Id  System\n"
#~ msgstr "%*s Zavádět   Začátek       Konec    Bloky    Id  Systém\n"

#~ msgid ""
#~ "\n"
#~ "Disk %s: %d heads, %llu sectors, %llu cylinders\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Disk %s: hlav: %'d, sektorů: %'llu, cylindrů: %'llu\n"
#~ "\n"

#~ msgid "Nr AF  Hd Sec  Cyl  Hd Sec  Cyl     Start      Size ID\n"
#~ msgstr "Č. AF  Hd Sek  Cyl  Hd Sek  Cyl    Začátek     Vel. Id\n"

#~ msgid ""
#~ "\n"
#~ "\tThere is a valid Mac label on this disk.\n"
#~ "\tUnfortunately fdisk(1) cannot handle these disks.\n"
#~ "\tUse either pdisk or parted to modify the partition table.\n"
#~ "\tNevertheless some advice:\n"
#~ "\t1. fdisk will destroy its contents on write.\n"
#~ "\t2. Be sure that this disk is NOT a still vital\n"
#~ "\t   part of a volume group. (Otherwise you may\n"
#~ "\t   erase the other disks as well, if unmirrored.)\n"
#~ msgstr ""
#~ "\n"
#~ "\tNa tomto disku je macovská tabulka rozdělení disku.\n"
#~ "\tNaneštěstí fdisk(1) s těmito disky neumí pracovat.\n"
#~ "\tTuto tabulku rozdělení disku můžete upravit programem\n"
#~ "„pdisk“ nebo „parted“.\n"
#~ "\tNicméně několik rad pro Vás:\n"
#~ "\t1. Při zápisu fdisk zničí jeho obsah\n"
#~ "\t2. Ujistěte se, že tento disk NENÍ důležitou součástí\n"
#~ "\t   skupiny svazků. (Jinak můžete smazat, pokud nejsou\n"
#~ "\t   zrcadleny, i ostatní disky.)\n"

#~ msgid ""
#~ "\tSorry - this fdisk cannot handle Mac disk labels.\n"
#~ "\tIf you want to add DOS-type partitions, create\n"
#~ "\ta new empty DOS partition table first. (Use o.)\n"
#~ "\tWARNING: This will destroy the present disk contents.\n"
#~ msgstr ""
#~ "\tPromiňte, ale tento fdisk neumí zacházet s macovskými diskovými\n"
#~ "\tjmenovkami. Chcete-li přidat oddíl typu DOS, nejprve vytvořte\n"
#~ "\t novu prázdnou DOSOVOU tabulku rozdělení disku (příkaz „o“).\n"
#~ "\tVAROVÁNÍ: Tímto přijdete o současný obsah disku.\n"

#~ msgid "According to MIPS Computer Systems, Inc the Label must not contain more than 512 bytes\n"
#~ msgstr "Popis nesmí podle MIPS Computer Systems, Inc obsahovat více než 512 bajtů\n"

#~ msgid ""
#~ "\n"
#~ "Disk %s (SGI disk label): %d heads, %llu sectors, %llu cylinders\n"
#~ "Units = %s of %d * %ld bytes\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Disk %s (SGI tabulka rozdělení disku): hlav: %'d, sektorů: %'llu,\n"
#~ "cylindrů: %'llu\n"
#~ "Jednotky = %s po %d * %ld bajtech\n"
#~ "\n"

#~ msgid ""
#~ "----- partitions -----\n"
#~ "Pt# %*s  Info     Start       End   Sectors  Id  System\n"
#~ msgstr ""
#~ "----- oddíly -----\n"
#~ "Od# %*s  Info      Začátek     Konec Sektory  Id  Systém\n"

#~ msgid ""
#~ "----- Bootinfo -----\n"
#~ "Bootfile: %s\n"
#~ "----- Directory Entries -----\n"
#~ msgstr ""
#~ "----- bootinfo -----\n"
#~ "Startovací soubor: %s\n"
#~ "----- adresářové položky -----\n"

#~ msgid "%2zd: %-10s sector%5u size%8u\n"
#~ msgstr "%2zd: %-10s sektor%5u velikost%8u\n"

#~ msgid "No partitions defined\n"
#~ msgstr "Nejsou definovány žádné oddíly\n"

#~ msgid ""
#~ "The entire disk partition is only %d diskblock large,\n"
#~ "but the disk is %d diskblocks long.\n"
#~ msgstr ""
#~ "Diskový oddíl zaujímající celý disk má velikost  v blocích pouze %d,\n"
#~ "ale velikost disku v blocích je %d.\n"

#~ msgid "Partition %d does not start on cylinder boundary.\n"
#~ msgstr "Diskový oddíl %d nezačíná na hranici cylindru.\n"

#~ msgid "Partition %d does not end on cylinder boundary.\n"
#~ msgstr "Diskový oddíl %d nekončí na hranici cylindru.\n"

#~ msgid "Partition %zd is already defined.  Delete it before re-adding it.\n"
#~ msgstr ""
#~ "Oddíl %zd je již definován. Před opětovným vytvořením jej musíte\n"
#~ "nejprve smazat.\n"

#~ msgid " Last %s"
#~ msgstr " Poslední %s"

#~ msgid "Building a new SGI disklabel.\n"
#~ msgstr "Sestavuje se nová tabulka rozdělení disku typu SGI.\n"

#~ msgid "HDIO_GETGEO ioctl failed on %s"
#~ msgstr "Volání ioctl HDIO_GETGEO nad %s selhalo"

#~ msgid ""
#~ "Warning:  BLKGETSIZE ioctl failed on %s.  Using geometry cylinder value of %llu.\n"
#~ "This value may be truncated for devices > 33.8 GB.\n"
#~ msgstr ""
#~ "Pozor: ioctl BLKGETSIZE selhalo na %s. Pro geometrii se použije %llu\n"
#~ "cylindrů.\n"
#~ "Tato hodnota může být zkrácena pro zařízení > 33,8 GB.\n"

#~ msgid "ID=%02x\tSTART=%d\tLENGTH=%d\n"
#~ msgstr "ID=%02x\tZAČÁTEK=%d\tDÉLKA=%d\n"

#~ msgid "Trying to keep parameters of partitions already set.\n"
#~ msgstr "Pokouším se zachovat parametry již nastavených oddílů.\n"

#~ msgid "YES\n"
#~ msgstr "ANO\n"

#~ msgid "Building a new Sun disklabel."
#~ msgstr "Vytváří se nový sunový popis disku."

#~ msgid ""
#~ "\n"
#~ "Disk %s (Sun disk label): %u heads, %llu sectors, %d rpm\n"
#~ "%llu cylinders, %d alternate cylinders, %d physical cylinders\n"
#~ "%d extra sects/cyl, interleave %d:1\n"
#~ "Label ID: %s\n"
#~ "Volume ID: %s\n"
#~ "Units = %s of %d * 512 bytes\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Disk %s (sunovská tabulka rozdělení disku): hlav: %'u, sektorů: %'llu,\n"
#~ "o/m: %'d, cylindrů: %'llu, náhradních cylindrů: %'d,\n"
#~ "fyzických cylindrů: %'d, extra sektorů/cylindr: %'d, prokládání: %d:1\n"
#~ "ID jmenovky: %s\n"
#~ "ID svazku: %s\n"
#~ "Jednotky = %s po %d * 512 bajtech\n"
#~ "\n"

#~ msgid ""
#~ "\n"
#~ "Disk %s (Sun disk label): %u heads, %llu sectors, %llu cylinders\n"
#~ "Units = %s of %d * 512 bytes\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Disk %s (sunovská tabulka rozdělení disku): hlav: %'u, sektorů: %'llu,\n"
#~ "cylindrů: %'llu\n"
#~ "Jednotky = %s po %d * 512 bajtech\n"
#~ "\n"

#~ msgid "%*s Flag    Start       End    Blocks   Id  System\n"
#~ msgstr "%*s Příznak Začátek     Konec  Bloky    Id  Systém\n"

#~ msgid "%s -An device\t activate partition n, inactivate the other ones\n"
#~ msgstr "%s -An zařízení\t aktivuje oddíl n, deaktivuje ostatní\n"

#~ msgid ""
#~ "Done\n"
#~ "\n"
#~ msgstr ""
#~ "Hotovo\n"
#~ "\n"

#~ msgid "WARNING: fdisk GPT support is currently new, and therefore in an experimental phase. Use at your own discretion."
#~ msgstr "POZOR: Podpora GPT v fdisku je nová, a tudíž ve stádiu pokusu. Použití je na vlastní nebezpečí."

#~ msgid "Created partition %zd\n"
#~ msgstr "Vytvořen oddíl %zd\n"

#~ msgid "Building a new GPT disklabel (GUID: %08X-%04X-%04X-%02X%02X-%02X%02X%02X%02X%02X%02X)\n"
#~ msgstr "Sestavuje se nový popis GPT (GUID: %08X-%04X-%04X-%02X%02X-%02X%02X%02X%02X%02X%02X)\n"

#~ msgid " %s [options] -u <USER> COMMAND\n"
#~ msgstr " %s [přepínače] -u <UŽIVATEL> PŘÍKAZ\n"

#~ msgid " %s [options] [-] [USER [arg]...]\n"
#~ msgstr " %s [přepínače] [-] [UŽIVATEL [argument…]\n"

#~ msgid "                                 and do not create a new session\n"
#~ msgstr "                                 a nevytvoří novou relaci\n"

#~ msgid ""
#~ " -1, --one        show only current month (default)\n"
#~ " -3, --three      show previous, current and next month\n"
#~ " -s, --sunday     Sunday as first day of week\n"
#~ " -m, --monday     Monday as first day of week\n"
#~ " -j, --julian     output Julian dates\n"
#~ " -y, --year       show whole current year\n"
#~ " -V, --version    display version information and exit\n"
#~ " -h, --help       display this help text and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -1, --one        zobrazí pouze současný měsíc (výchozí)\n"
#~ " -3, --three      zobrazí předchozí, současný a následující měsíc\n"
#~ " -s, --sunday     neděle jako první den týdne\n"
#~ " -m, --monday     pondělí jako první den týdne\n"
#~ " -j, --julian     vypíše juliánská data\n"
#~ " -y, --year       zobrazí celý současný rok\n"
#~ " -V, --version    vypíše údaje o verzi a skončí\n"
#~ " -h, --help       vypíše tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid "getaddrinfo %s:%s: %s"
#~ msgstr "getaddrinfo %s:%s: %s"

#~ msgid ""
#~ " -d, --udp             use UDP only\n"
#~ " -i, --id              log the process ID too\n"
#~ " -f, --file <file>     log the contents of this file\n"
#~ " -h, --help            display this help text and exit\n"
#~ msgstr ""
#~ " -d, --udp             použije pouze UDP\n"
#~ " -i, --id              zaznamená rovněž ID procesu\n"
#~ " -f, --file <soubor>   zaznamená obsah SOUBORU\n"
#~ " -h, --help            zobrazí tuto nápovědu a skončí\n"

#~ msgid ""
#~ " -n, --server <name>   write to this remote syslog server\n"
#~ " -P, --port <number>   use this UDP port\n"
#~ " -p, --priority <prio> mark given message with this priority\n"
#~ " -s, --stderr          output message to standard error as well\n"
#~ msgstr ""
#~ " -n, --server <název>  zapíše do tohoto vzdáleného syslogového serveru\n"
#~ " -P, --port <číslo>    použije tento UDP port\n"
#~ " -p, --priority <priorita>\n"
#~ "                       označí zadanou zprávu touto prioritou\n"
#~ " -s, --stderr          zprávu vypíše rovněž na standardní chybový výstup\n"

#~ msgid ""
#~ " -t, --tag <tag>       mark every line with this tag\n"
#~ " -u, --socket <socket> write to this Unix socket\n"
#~ " -V, --version         output version information and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -t, --tag <značka>    každému řádku přidá tuto značku\n"
#~ " -u, --socket <socket> zapíše do tohoto unixového socketu\n"
#~ " -V, --version         zobrazí údaje o verzi a skončí\n"
#~ "\n"

#~ msgid "Failed to open/create %s: %m\n"
#~ msgstr "Nezdařilo se otevřít/vytvořit %s: %m\n"

#~ msgid "Failed to lock %s: %m\n"
#~ msgstr "Nezdařilo se zamknout %s: %m\n"

#~ msgid "Bad number: %s\n"
#~ msgstr "Chybné číslo: %s\n"

#~ msgid ""
#~ " -T, --ctime                 show human readable timestamp (could be \n"
#~ "                               inaccurate if you have used SUSPEND/RESUME)\n"
#~ msgstr ""
#~ " -T, --ctime                 ukáže časové údaje v podobně vhodné pro člověka\n"
#~ "                             (může být nepřesné, pokud jste použili uspání\n"
#~ "                             a probuzení)\n"

#~ msgid "--notime can't be used together with --ctime or --reltime"
#~ msgstr "přepínač --noatime nelze použít spolu s --ctime nebo --reltime"

#~ msgid "find unused loop device failed"
#~ msgstr "hledání nepoužitého loop zařízení selhalo"

#~ msgid ""
#~ " -v, --verbose      explain what is being done\n"
#~ " -V, --version      output version information and exit\n"
#~ " -h, --help         output help screen and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -v, --verbose      vysvětlí, co se právě provádí\n"
#~ " -V, --version      zobrazí údaje o verzi a skončí\n"
#~ " -h, --help         zobrazí nápovědu a skončí\n"
#~ "\n"

#~ msgid ""
#~ " -n, --nobanner          do not print banner, works only for root\n"
#~ " -t, --timeout <timeout> write timeout in seconds\n"
#~ " -V, --version           output version information and exit\n"
#~ " -h, --help              display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -n, --nobanner          nevypíše hlavičku, funguje je pro superuživatele\n"
#~ " -t, --timeout LIMIT     časový limit na zápis v sekundách\n"
#~ " -V, --version           zobrazí údaje o verzi a skončí\n"
#~ " -h, --help              zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid " -o, --output-separator <string>\n"
#~ msgstr " -o, --output-separator <řetězec>\n"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ " %s [options] file...\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ " %s [PŘEPÍNAČE] SOUBOR…\n"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -b              one-byte octal display\n"
#~ " -c              one-byte character display\n"
#~ " -C              canonical hex+ASCII display\n"
#~ " -d              two-byte decimal display\n"
#~ " -o              two-byte octal display\n"
#~ " -x              two-byte hexadecimal display\n"
#~ " -e format       format string to be used for displaying data\n"
#~ " -f format_file  file that contains format strings\n"
#~ " -n length       interpret only length bytes of input\n"
#~ " -s offset       skip offset bytes from the beginning\n"
#~ " -v              display without squeezing similar lines\n"
#~ " -V              output version information and exit\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -b              výpis po bajtech osmičkově\n"
#~ " -c              výpis po bajtech jako znaky\n"
#~ " -C              normovaný výpis šestnáctkově a v ASCII\n"
#~ " -d              výpis po dvou bajtech desítkově\n"
#~ " -o              výpis po dvou bajtech osmičkově\n"
#~ " -x              výpis po dvou bajtech šestnáctkově\n"
#~ " -e FORMÁT       formátovací řetězec použitý při výpisu dat\n"
#~ " -f FORMÁTOVACÍ_SOUBOR\n"
#~ "                 soubor obsahující formátovací řetězce\n"
#~ " -n DÉLKA        interpretuje pouze DÉLKU bajtů ze vstupu\n"
#~ " -s POZICE       přeskočí zadaný počet bajtů na začátku vstupu\n"
#~ " -v              ve výpisu nevynechá podobné řádky\n"
#~ " -V              zobrazí údaje o verzi a skončí\n"
#~ "\n"

#~ msgid "crypt failed: %m\n"
#~ msgstr "volání crypt selhalo: %m\n"

#~ msgid "Can not fork: %m\n"
#~ msgstr "Vytvoření potomka voláním fork selhalo: %m\n"

#~ msgid "bug in xstrndup call"
#~ msgstr "chyba ve volání xstrndup"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -A         check all filesystems\n"
#~ " -R         skip root filesystem; useful only with `-A'\n"
#~ " -M         do not check mounted filesystems\n"
#~ " -t <type>  specify filesystem types to be checked;\n"
#~ "              type is allowed to be comma-separated list\n"
#~ " -P         check filesystems in parallel, including root\n"
#~ " -r         report statistics for each device fsck\n"
#~ " -s         serialize fsck operations\n"
#~ " -l         lock the device using flock()\n"
#~ " -N         do not execute, just show what would be done\n"
#~ " -T         do not show the title on startup\n"
#~ " -C <fd>    display progress bar; file descriptor is for GUIs\n"
#~ " -V         explain what is being done\n"
#~ " -?         display this help and exit\n"
#~ "\n"
#~ "See fsck.* commands for fs-options."
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -A         zkontroluje všechny souborové systémy\n"
#~ " -R         vynechá kořenový souborový systém; užitečné je s „-A“\n"
#~ " -M         nekontroluje připojené souborové systémy\n"
#~ " -t <typ>   určuje druhy souborových systémů, které se mají zkontrolovat;\n"
#~ "            typ smí být čárkou oddělený seznam\n"
#~ " -P         souborové systémy kontroluje paralelně, včetně kořenového\n"
#~ " -r         hlásí statistické údaje pro každé kontrolované zařízení\n"
#~ " -s         serializuje operace fsck\n"
#~ " -l         zamkne zařízení pomocí flock()\n"
#~ " -N         nic nevykoná, pouze zobrazí, co by se udělalo\n"
#~ " -T         při spuštění nezobrazí nadpis\n"
#~ " -C <fd>    zobrazí indikátor postupu; deskriptor souboru je pro GUI\n"
#~ " -V         vysvětlí, co se provádí\n"
#~ " -?         zobrazí tuto nápovědu a skončí\n"
#~ "\n"
#~ "přepínače_ss jsou popsány u jednotlivých příkazů fsck.*."

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -d, --divisor=NUM      divide bytes NUM\n"
#~ " -x, --sectors          show sector count and size\n"
#~ " -V, --version          output version information and exit\n"
#~ " -H, --help             display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -d, --divisor=ČÍSLO    vydělí bajty ČÍSLEM\n"
#~ " -x, --sectors          zobrazí počet a velikost sektorů\n"
#~ " -V, --version          zobrazí údaje o verzi a skončí\n"
#~ " -H, --help             zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -t, --type=TYPE  file system type, when undefined ext2 is used\n"
#~ "     fs-options   parameters to real file system builder\n"
#~ "     device       path to a device\n"
#~ "     size         number of blocks on the device\n"
#~ " -V, --verbose    explain what is done\n"
#~ "                  defining -V more than once will cause a dry-run\n"
#~ " -V, --version    output version information and exit\n"
#~ "                  -V as version must be only option\n"
#~ " -h, --help       display this help and exit\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -t, --type=TYP   druh systému souborů, není-li zadáno, použije se ext2\n"
#~ "     VOLBY_SS     parametry pro tvořítko konkrétního souborového systému\n"
#~ "     ZAŘÍZENÍ     cesta k zařízení\n"
#~ "     VELIKOST     počet bloků na zařízení\n"
#~ " -V, --verbose    vysvětlí prováděné úkony\n"
#~ "                  násobné použití -V způsobí bezzápisový běh\n"
#~ " -V, --version    vypíše údaje o verzi a skončí\n"
#~ "                  -V jako verze musí být jediným přepínačem\n"
#~ " -h, --help       zobrazí tuto nápovědu a skončí\n"

#~ msgid "mkfs (%s)\n"
#~ msgstr "mkfs (%s)\n"

#~ msgid "strtol error: number of blocks not specified"
#~ msgstr "chyba strtol: počet bloků nebyl zadán"

#~ msgid "one bad page\n"
#~ msgstr "chybných stránek: 1\n"

# Alternate continuation of previous message
#~ msgid "        on whole disk. "
#~ msgstr "        na celém disku. "

#~ msgid "does not support swapspace version %d."
#~ msgstr "nepodporuje odkládací prostor verze %d."

#~ msgid ""
#~ " -a, --add            add specified partitions or all of them\n"
#~ " -d, --delete         delete specified partitions or all of them\n"
#~ " -l, --list           list partitions (DEPRECATED)\n"
#~ " -s, --show           list partitions\n"
#~ "\n"
#~ " -b, --bytes          print SIZE in bytes rather than in human readable format\n"
#~ " -g, --noheadings     don't print headings for --show\n"
#~ " -n, --nr <n:m>       specify the range of partitions (e.g. --nr 2:4)\n"
#~ " -o, --output <type>  define which output columns to use\n"
#~ " -P, --pairs          use key=\"value\" output format\n"
#~ " -r, --raw            use raw output format\n"
#~ " -t, --type <type>    specify the partition type (dos, bsd, solaris, etc.)\n"
#~ " -v, --verbose        verbose mode\n"
#~ msgstr ""
#~ " -a, --add            přidá zadané oddíly nebo všechny oddíly\n"
#~ " -d, --delete         smaže zadané oddíly nebo všechny oddíly\n"
#~ " -l, --list           vypíše seznam oddílů (ZASTARALÉ)\n"
#~ " -s, --show           vypíše seznam oddílů\n"
#~ "\n"
#~ " -b, --bytes          velikosti vypisuje v bajtech namísto podobě vhodné\n"
#~ "                      pro člověka\n"
#~ " -g, --noheadings     nezobrazuje záhlaví ve výpisu --show\n"
#~ " -n, --nr <m:n>       určuje rozsah oddílů (--nr 2:4)\n"
#~ " -o, --output <druh>  zobrazí vybrané sloupce\n"
#~ " -P, --pairs          výstup ve formátu klíč=\"hodnota\"\n"
#~ " -r, --raw            neformátovaný výstup\n"
#~ " -t, --type <druh>    určuje druh oddílu (dos, bsd, solaris, atd.)\n"
#~ " -v, --verbose        podrobný režim\n"

#~ msgid "Warning!!  Unsupported GPT (GUID Partition Table) detected. Use GNU Parted."
#~ msgstr "Varování!! Detekována nepodporovaná GPT (GUID tabulka rozdělení disku). Použijte GNU Parted."

#~ msgid ""
#~ "\n"
#~ "\tThere is a valid AIX label on this disk.\n"
#~ "\tUnfortunately Linux cannot handle these\n"
#~ "\tdisks at the moment.  Nevertheless some\n"
#~ "\tadvice:\n"
#~ "\t1. fdisk will destroy its contents on write.\n"
#~ "\t2. Be sure that this disk is NOT a still vital\n"
#~ "\t   part of a volume group. (Otherwise you may\n"
#~ "\t   erase the other disks as well, if unmirrored.)\n"
#~ "\t3. Before deleting this physical volume be sure\n"
#~ "\t   to remove the disk logically from your AIX\n"
#~ "\t   machine.  (Otherwise you become an AIXpert)."
#~ msgstr ""
#~ "\n"
#~ "\tNa tomto disku je AIX tabulka rozdělení disku.\n"
#~ "\tLinux s těmito disky v současné době neumí pracovat.\n"
#~ "\tNicméně několik rad pro Vás:\n"
#~ "\t1. při zápisu fdisk zničí jejich obsah\n"
#~ "\t2. Ujistěte se, že tento disk NENÍ důležitou součástí\n"
#~ "\t   skupiny svazků. (Jinak můžete smazat, pokud nejsou\n"
#~ "\t   zrcadleny, i ostatní disky.)\n"
#~ "\t3. Předtím, než smažete fyzický svazek, se ujistěte, že\n"
#~ "\t   již není logickou součástí Vašeho AIX systému. (Jinak\n"
#~ "\t   se z Vás stává AIXpert)."

#~ msgid ""
#~ "\tSorry - this fdisk cannot handle AIX disk labels.\n"
#~ "\tIf you want to add DOS-type partitions, create\n"
#~ "\ta new empty DOS partition table first. (Use o.)\n"
#~ "\tWARNING: This will destroy the present disk contents.\n"
#~ msgstr ""
#~ "\tPromiňte, ale tento program neumí zacházet s AIXovými diskovými\n"
#~ "\tjmenovkami. Chcete-li přidat oddíl typu DOS, nejprve vytvořte\n"
#~ "\t novu prázdnou DOSOVOU tabulku rozdělení disku (příkaz „o“).\n"
#~ "\tVAROVÁNÍ: Tímto přijdete o současný obsah disku.\n"

#~ msgid ""
#~ "\n"
#~ "BSD label for device: %s\n"
#~ msgstr ""
#~ "\n"
#~ "BSD tabulka rozdělení disku pro zařízení: %s\n"

#~ msgid "Warning: partition %d has empty type\n"
#~ msgstr "Varování: oddíl %d nemá určen typ\n"

#~ msgid "Partition %i does not end on cylinder boundary.\n"
#~ msgstr "Diskový oddíl %i nekončí na hranici cylindru.\n"

#~ msgid ""
#~ "\n"
#~ "WARNING: GPT (GUID Partition Table) detected on '%s'! The util fdisk doesn't support GPT. Use GNU Parted.\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "VAROVÁNÍ: Na „%s“ nalezena GPT (GUID tabulka rozdělení disku)! Nástroj fdisk nepodporuje GPT. Použijte GNU Parted.\n"
#~ "\n"

#~ msgid "Note: sector size is %ld (not %d)\n"
#~ msgstr "Pozor: velikost sektoru je %ld (nikoliv %d)\n"

#~ msgid ""
#~ "\n"
#~ "WARNING: GPT (GUID Partition Table) detected on '%s'! The util sfdisk doesn't support GPT. Use GNU Parted.\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "VAROVÁNÍ: Na „%s“ nalezena GPT (GUID tabulka rozdělení disku)! Nástroj sfdisk nepodporuje GPT. Použijte GNU Parted.\n"
#~ "\n"

#~ msgid "Use the --force flag to overrule this check.\n"
#~ msgstr "K potlačení této kontroly použijte přepínač --force.\n"

#~ msgid "exec %s failed"
#~ msgstr "spuštění %s selhalo"

#~ msgid ""
#~ " -, -l, --login               make the shell a login shell\n"
#~ " -c, --command <command>      pass a single command to the shell with -c\n"
#~ " --session-command <command>  pass a single command to the shell with -c\n"
#~ "                              and do not create a new session\n"
#~ " -f, --fast                   pass -f to the shell (for csh or tcsh)\n"
#~ " -m, --preserve-environment   do not reset environment variables\n"
#~ " -p                           same as -m\n"
#~ " -s, --shell <shell>          run shell if /etc/shells allows it\n"
#~ msgstr ""
#~ " -, -l, --login               nastaví shell jako přihlašovací\n"
#~ " -c, --command <příkaz>       vyvolanému shellu předá jeden příkaz pomocí -c\n"
#~ " --session-command <příkaz>   vyvolanému shellu předá jeden příkaz pomocí -c\n"
#~ "                              a nevytvoří novou relaci\n"
#~ " -f, --fast                   shellu předá -f (pro csh nebo tcsh)\n"
#~ " -m, --preserve-environment   zachová proměnné prostředí\n"
#~ " -p                           stejné jako -m\n"
#~ " -s, --shell <shell>          spustí shell, pokud to /etc/shells dovolí\n"

#~ msgid "%s: exec failed"
#~ msgstr "%s: volání exec selhalo"

#~ msgid "TIOCSCTTY: ioctl failed"
#~ msgstr "TIOCSCTTY: volání ioctl selhalo"

#~ msgid "usage: %s [+format] [day month year]\n"
#~ msgstr "Použití: %s [+FORMÁT] [DEN MĚSÍC ROK]\n"

#~ msgid "St. Tib's Day"
#~ msgstr "Den svatého Tiba"

#~ msgid ""
#~ " -O, --options <list>   limit the set of filesystems by mount options\n"
#~ " -o, --output <list>    the output columns to be shown\n"
#~ " -P, --pairs            use key=\"value\" output format\n"
#~ " -r, --raw              use raw output format\n"
#~ " -t, --types <list>     limit the set of filesystems by FS types\n"
#~ msgstr ""
#~ " -O, --options <seznam> omezí množinu souborových systémů podle voleb připojení\n"
#~ " -o, --output <seznam>  zobrazí dané sloupce\n"
#~ " -P, --pairs            výstup ve formátu klíč=\"hodnota\"\n"
#~ " -r, --raw              neformátovaný výstup\n"
#~ " -t, --types <seznam>   omezí množinu souborových systémů podle jejich druhu\n"

#~ msgid "usage: %s [ -s signal | -p ] [ -a ] pid ...\n"
#~ msgstr "Použití: %s [ -s signál | -p ] [ -a ] PID…\n"

#~ msgid "       %s -l [ signal ]\n"
#~ msgstr "         %s -l [ signál ]\n"

# connect is function name
#~ msgid "connect %s"
#~ msgstr "connect %s"

#~ msgid "invalid port number argument"
#~ msgstr "neplatný argument čísla portu"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ " %s [options] [<device> ...]\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ " %s [přepínače] [zařízení…]\n"

# ???: WTF is holder?
# ???: Překládat jako „obálka“?
#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -a, --all            print all devices\n"
#~ " -b, --bytes          print SIZE in bytes rather than in human readable format\n"
#~ " -d, --nodeps         don't print slaves or holders\n"
#~ " -D, --discard        print discard capabilities\n"
#~ " -e, --exclude <list> exclude devices by major number (default: RAM disks)\n"
#~ " -I, --include <list> show only devices with specified major numbers\n"
#~ " -f, --fs             output info about filesystems\n"
#~ " -h, --help           usage information (this)\n"
#~ " -i, --ascii          use ascii characters only\n"
#~ " -m, --perms          output info about permissions\n"
#~ " -l, --list           use list format ouput\n"
#~ " -n, --noheadings     don't print headings\n"
#~ " -o, --output <list>  output columns\n"
#~ " -P, --pairs          use key=\"value\" output format\n"
#~ " -r, --raw            use raw output format\n"
#~ " -s, --inverse        inverse dependencies\n"
#~ " -t, --topology       output info about topology\n"
#~ " -V, --version        output version information and exit\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -a, --all            vypíše všechna zařízení\n"
#~ " -b, --bytes          velikosti vypíše v bajtech namísto v podobě vhodné\n"
#~ "                      pro člověka\n"
#~ " -d, --nodeps         nevypíše podřízená (slave) a nadřízená (holder) zařízení\n"
#~ " -D, --discard        popíše schopnost zahazovat data (discard)\n"
#~ " -e, --exclude <seznam>\n"
#~ "                      vynechá zařízení podle hlavního čísla (výchozí: RAM disky)\n"
#~ " -I, --include <seznam>\n"
#~ "                      zobrazí pouze zařízení se zadanými hlavními čísly\n"
#~ " -f, --fs             vypíše údaje o souborovém systému\n"
#~ " -h, --help           návod k použití (tento)\n"
#~ " -i, --ascii          použije pouze ASCII znaky\n"
#~ " -m, --perms          vypíše údaje o přístupových právech\n"
#~ " -l, --list           výstup formátuje jako seznam\n"
#~ " -n, --noheadings     nevypíše záhlaví\n"
#~ " -o, --output <seznam>\n"
#~ "                      zobrazí dané sloupce\n"
#~ " -P, --pairs          výstup ve formátu klíč=\"hodnota\"\n"
#~ " -r, --raw            neformátovaný výstup\n"
#~ " -s, --inverse        obrátí závislosti\n"
#~ " -t, --topology       vypíše údaje o topologii\n"
#~ " -V, --version        vypíše údaje o verzi a skončí\n"

#~ msgid ""
#~ " -v, --verbose    explain what is being done\n"
#~ " -V, --version    output version information and exit\n"
#~ " -h, --help       display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -v, --verbose    vysvětlí, co se právě vykonává\n"
#~ " -V, --version    zobrazí údaje o verzi a skončí\n"
#~ " -h, --help       zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid ""
#~ " -f <file>  define search scope\n"
#~ " -b         search only binaries\n"
#~ " -B <dirs>  define binaries lookup path\n"
#~ " -m         search only manual paths\n"
#~ " -M <dirs>  define man lookup path\n"
#~ " -s         search only sources path\n"
#~ " -S <dirs>  define sources lookup path\n"
#~ " -u         search from unusual entities\n"
#~ " -V         output version information and exit\n"
#~ " -h         display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ " -f <soubor>    určuje rozsah hledání\n"
#~ " -b             prohledává pouze binární soubory\n"
#~ " -B <adresáře>  určuje cestu pro hledání binárních souborů\n"
#~ " -m             prohledává pouze cesty manuálových stránek\n"
#~ " -M <adresáře>  určuje cestu pro hledání manuálových stránek\n"
#~ " -s             prohledává pouze cesty se zdroji\n"
#~ " -S <adresáře>  určuje cestu pro hledání zdrojů\n"
#~ " -u             hledá neobvyklé entity\n"
#~ " -V             zobrazí údaje o verzi a skončí\n"
#~ " -h             zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid "See how to use file and dirs arguments from whereis(1) manual.\n"
#~ msgstr ""
#~ "Jak se používají argumenty souborů a adresářů se lze dozvědět v manuálu\n"
#~ "whereis(1).\n"

#~ msgid "mount: couldn't lock into memory"
#~ msgstr "mount: nebylo možné zamknout v paměti"

#~ msgid "mount: argument to -p or --pass-fd must be a number"
#~ msgstr "mount: argument přepínačů -p a --pass-fd musí být číslo"

#~ msgid "executing %s failed"
#~ msgstr "spuštění %s selhalo"

#~ msgid ""
#~ " -C, --clear                 clear the kernel ring buffer\n"
#~ " -c, --read-clear            read and clear all messages\n"
#~ " -D, --console-off           disable printing messages to console\n"
#~ " -d, --show-delta            show time delta between printed messages\n"
#~ " -e, --reltime               show local time and time delta in readable format\n"
#~ " -E, --console-on            enable printing messages to console\n"
#~ " -F, --file <file>           use the file instead of the kernel log buffer\n"
#~ " -f, --facility <list>       restrict output to defined facilities\n"
#~ " -h, --help                  display this help and exit\n"
#~ " -k, --kernel                display kernel messages\n"
#~ " -l, --level <list>          restrict output to defined levels\n"
#~ " -n, --console-level <level> set level of messages printed to console\n"
#~ " -r, --raw                   print the raw message buffer\n"
#~ " -S, --syslog                force to use syslog(2) rather than /dev/kmsg\n"
#~ " -s, --buffer-size <size>    buffer size to query the kernel ring buffer\n"
#~ " -T, --ctime                 show human readable timestamp (could be \n"
#~ "                             inaccurate if you have used SUSPEND/RESUME)\n"
#~ " -t, --notime                don't print messages timestamp\n"
#~ " -u, --userspace             display userspace messages\n"
#~ " -V, --version               output version information and exit\n"
#~ " -w, --follow                wait for new messages\n"
#~ " -x, --decode                decode facility and level to readable string\n"
#~ msgstr ""
#~ " -C, --clear                  vyprázdní kruhový buffer v jádře\n"
#~ " -c, --read-clear             přečte a vyprázdní zprávy\n"
#~ " -D, --console-off            vypne vypisování zpráv do konzoly\n"
#~ " -d, --show-delta             ukáže časové rozdíly mezi hláškami\n"
#~ " -e, --reltime                ukáže místní čas a časový rozdíl v čitelné podobě\n"
#~ " -E, --console-on             zapne vypisování zpráv do konzoly\n"
#~ " -F, --file <soubor>          použije zadaný soubor místo jaderného bufferu\n"
#~ " -f, --facility <seznam>      výstup omezí na zadané obory\n"
#~ " -h, --help                   zobrazí tuto nápovědu a skončí\n"
#~ " -k, --kernel                 zobrazí jaderné zprávy\n"
#~ " -l, --level <seznam>         výstup omezí na zadané úrovně\n"
#~ " -n, --console-level <úroveň> nastaví úroveň zpráv vypisovaných do konzoly\n"
#~ " -r, --raw                    vypíše buffer zpráv v neopracované podobě\n"
#~ " -S, --syslog                 vynutí použití syslog(2) místo /dev/kmsg\n"
#~ " -s, --buffer-size <velikost> velikost bufferu, na který se zeptat jaderného\n"
#~ "                              kruhové bufferu\n"
#~ " -T, --ctime                  ukáže časové údaje v podobně vhodné pro člověka\n"
#~ "                              (může být nepřesné, použili-li jste uspání/\n"
#~ "                              probuzení)\n"
#~ " -t, --notime                 nevypisuje časy zpráv\n"
#~ " -u, --userspace              vypíše zprávy z uživatelského prostoru\n"
#~ " -V, --version                zobrazí údaje o verzi a skončí\n"
#~ " -w, --follow                 čeká na nové zprávy\n"
#~ " -x, --decode                 obory a úrovně převede na čitelné řetězce\n"

#~ msgid "eject: cannot set user id"
#~ msgstr "eject: číslo uživatele (UID) nelze nastavit"

#~ msgid ""
#~ " -h, --help        this help\n"
#~ " -f, --freeze      freeze the filesystem\n"
#~ " -u, --unfreeze    unfreeze the filesystem\n"
#~ msgstr ""
#~ " -h, --help        tato nápověda\n"
#~ " -f, --freeze      zmrazí systém souborů\n"
#~ " -u, --unfreeze    rozmrazí systém souborů\n"

#~ msgid ""
#~ "\n"
#~ "For more information see fsfreeze(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete ve fsfreeze(8).\n"

#~ msgid "min seg size (bytes) = %lu\n"
#~ msgstr "minimální velikost segmentu (v bajtech) = %lu\n"

#~ msgid "shmctl failed"
#~ msgstr "volání shmctl selhalo"

#~ msgid "msgctl failed"
#~ msgstr "volání msgctl selhalo"

#~ msgid "cbytes=%ld\tqbytes=%ld\tqnum=%ld\tlspid=%d\tlrpid=%d\n"
#~ msgstr "cbytes=%ld\tqbytes=%ld\tqnum=%ld\tlspid=%d\tlrpid=%d\n"

#~ msgid ""
#~ " -e, --encryption <type>       enable encryption with specified <name/num>\n"
#~ " -o, --offset <num>            start at offset <num> into file\n"
#~ "     --sizelimit <num>         device limited to <num> bytes of the file\n"
#~ " -p, --pass-fd <num>           read passphrase from file descriptor <num>\n"
#~ " -P, --partscan                create partitioned loop device\n"
#~ " -r, --read-only               setup read-only loop device\n"
#~ "     --show                    print device name after setup (with -f)\n"
#~ " -v, --verbose                 verbose mode\n"
#~ msgstr ""
#~ " -e, --encryption <typ>        zapne šifrování pomocí zadaného <názvu>/<čísla>\n"
#~ " -o, --offset <číslo>          v souboru začne na pozici <číslo>\n"
#~ "     --sizelimit <počet>       omezí délku loopu na <počet> bajtů souboru\n"
#~ " -p, --pass-fd <číslo>         načte heslo z deskriptoru souboru <číslo>\n"
#~ " -P, --partscan                vytvoří loop zařízení rozdělené na oddíly\n"
#~ " -r, --read-only               nastaví loop zařízení jen pro čtení\n"
#~ " -s, --show                    vypíše název zařízení po nastavení (spolu s -f)\n"
#~ " -v, --verbose                 upovídaný režim\n"

#~ msgid "invalid passphrase file descriptor"
#~ msgstr "neplatný deskriptor souboru s heslem"

#~ msgid "%s failed to use device"
#~ msgstr "%s nemohlo použít zařízení"

#~ msgid "couldn't lock into memory"
#~ msgstr "nebylo možné zamknout v paměti"

#~ msgid ""
#~ " -a, --all               print online and offline CPUs (default for -e)\n"
#~ " -b, --online            print online CPUs only (default for -p)\n"
#~ " -c, --offline           print offline CPUs only\n"
#~ " -e, --extended[=<list>] print out an extended readable format\n"
#~ " -h, --help              print this help\n"
#~ " -p, --parse[=<list>]    print out a parsable format\n"
#~ " -s, --sysroot <dir>     use directory DIR as system root\n"
#~ " -V, --version           print version information and exit\n"
#~ " -x, --hex               print hexadecimal masks rather than lists of CPUs\n"
#~ msgstr ""
#~ " -a, --all                  vypíše zapnutá a vypnutá CPU (výchozí pro -e)\n"
#~ " -b, --online               vypíše jen zapnutá CPUs (výchozí pro -p)\n"
#~ " -c, --offline              vypíše jen vypnutá CPU\n"
#~ " -e, --extended[=<seznam>]  výpis v rozšířeném čitelném formátu\n"
#~ " -h, --help                 zobrazí tuto nápovědu\n"
#~ " -p, --parse[=<seznam>]     výpis v rozebratelném formátu\n"
#~ " -s, --sysroot <adresář>    jako kořen systému použije <adresář>\n"
#~ " -V, --version              vypíše údaje o verzi a skončí\n"
#~ " -x, --hex                  vypíše šestnáctkové masky namísto seznamů CPU\n"

#~ msgid "%s: failed to setup loop device (probably unknown encryption type)"
#~ msgstr "%s: zařízení loop se nepodařilo nastavit (zřejmě neznámý druh šifrování)"

#~ msgid "renice from %s\n"
#~ msgstr "renice z %s\n"

#~ msgid ""
#~ " -d, --device <device>    select rtc device (rtc0|rtc1|...)\n"
#~ " -n, --dry-run            does everything, but suspend\n"
#~ " -l, --local              RTC uses local timezone\n"
#~ " -m, --mode <mode>        standby|mem|... sleep mode\n"
#~ " -s, --seconds <seconds>  seconds to sleep\n"
#~ " -t, --time <time_t>      time to wake\n"
#~ " -u, --utc                RTC uses UTC\n"
#~ " -v, --verbose            verbose messages\n"
#~ msgstr ""
#~ " -d, --device <zařízení>  vybere RTC zařízení (rtc0|rtc1|…)\n"
#~ " -n, --dry-run            provede vše až na uspání\n"
#~ " -l, --local              RTC používá místní časovou zónu\n"
#~ " -m, --mode <režim>       režim spánku (standby|mem|…)\n"
#~ "                          [pohotovost|paměť|…]\n"
#~ " -s, --seconds <sekundy>  kolik sekund bude spát\n"
#~ " -t, --time time_t        čas probuzení\n"
#~ " -u, --utc                RTC běží v UTC\n"
#~ " -v, --verbose            podrobné zprávy\n"

#~ msgid "unable to execute %s"
#~ msgstr "%s nelze spustit"

#~ msgid ""
#~ " -v, --verbose            says what options are being switched on\n"
#~ " -R, --addr-no-randomize  disables randomization of the virtual address space\n"
#~ " -F, --fdpic-funcptrs     makes function pointers point to descriptors\n"
#~ " -Z, --mmap-page-zero     turns on MMAP_PAGE_ZERO\n"
#~ " -L, --addr-compat-layout changes the way virtual memory is allocated\n"
#~ " -X, --read-implies-exec  turns on READ_IMPLIES_EXEC\n"
#~ " -B, --32bit              turns on ADDR_LIMIT_32BIT\n"
#~ " -I, --short-inode        turns on SHORT_INODE\n"
#~ " -S, --whole-seconds      turns on WHOLE_SECONDS\n"
#~ " -T, --sticky-timeouts    turns on STICKY_TIMEOUTS\n"
#~ " -3, --3gb                limits the used address space to a maximum of 3 GB\n"
#~ "     --4gb                ignored (for backward compatibility only)\n"
#~ "     --uname-2.6          turns on UNAME26\n"
#~ msgstr ""
#~ " -v, --verbose            vypisuje, které volby jsou zapínány\n"
#~ " -R, --addr-no-randomize  vypne znáhodnění prostoru virtuálních adres\n"
#~ " -F, --fdpic-funcptrs     učiní ukazatele funkcí ukazující na deskriptory\n"
#~ " -Z, --mmap-page-zero     zapne MMAP_PAGE_ZERO\n"
#~ " -L, --addr-compat-layout změní způsob, jakým je virtuální paměť přidělována\n"
#~ " -X, --read-implies-exec  zapne READ_IMPLIES_EXEC\n"
#~ " -B, --32bit              zapne ADDR_LIMIT_32BIT\n"
#~ " -I, --short-inode        zapne SHORT_INODE\n"
#~ " -S, --whole-seconds      zapne WHOLE_SECONDS\n"
#~ " -T, --sticky-timeouts    zapne STICKY_TIMEOUTS\n"
#~ " -3, --3gb                omezí použitý adresní prostor hranicí 3 GB\n"
#~ "     --4gb                ignorováno (jen pro zpětnou kompatibilitu)\n"
#~ "     --uname-2.6          zapne UNAME26\n"

#~ msgid "execvp failed"
#~ msgstr "funkce execvp selhala"

#~ msgid "execv failed"
#~ msgstr "funkce execv selhala"

#~ msgid ""
#~ " -a, --all               umount all filesystems\n"
#~ " -c, --no-canonicalize   don't canonicalize paths\n"
#~ " -d, --detach-loop       if mounted loop device, also free this loop device\n"
#~ "     --fake              dry run; skip the umount(2) syscall\n"
#~ " -f, --force             force unmount (in case of an unreachable NFS system)\n"
#~ msgstr ""
#~ " -a, --all               odpojí veškeré souborové systémy\n"
#~ " -c, --no-canonicalize   nenormalizuje cesty\n"
#~ " -d, --detach-loop       je-li připojeno loop zařízení, rovněž jej uvolní\n"
#~ "     --fake              zkušební režim, přeskočí systémové volání umount(2)\n"
#~ " -f, --force             vynutí odpojení (pro případ nedostupného NFS)\n"

#~ msgid ""
#~ " -i, --internal-only     don't call the umount.<type> helpers\n"
#~ " -n, --no-mtab           don't write to /etc/mtab\n"
#~ " -l, --lazy              detach the filesystem now, and cleanup all later\n"
#~ msgstr ""
#~ " -i, --internal-only     nevolá pomocné programy umount.<typ>\n"
#~ " -n, --no-mtab           nezapíše do /etc/mtab\n"
#~ " -l, --lazy              souborový systém odpojí teď, zbytek uklidí později\n"

#~ msgid ""
#~ " -O, --test-opts <list>  limit the set of filesystems (use with -a)\n"
#~ " -r, --read-only         In case unmounting fails, try to remount read-only\n"
#~ " -t, --types <list>      limit the set of filesystem types\n"
#~ " -v, --verbose           say what is being done\n"
#~ msgstr ""
#~ " -O, --test-opts <seznam>\n"
#~ "                         omezí množinu souborových systémů (použije s -a)\n"
#~ " -r, --read-only         selže-li odpojení, zkusí souborový systém přepojit\n"
#~ "                         jen pro čtení\n"
#~ " -t, --types <seznam>    omezí množinu typů souborových systémů\n"
#~ " -v, --verbose           popisuje, co se děje\n"

#~ msgid ""
#~ " -m, --mount       unshare mounts namespace\n"
#~ " -u, --uts         unshare UTS namespace (hostname etc)\n"
#~ " -i, --ipc         unshare System V IPC namespace\n"
#~ " -n, --net         unshare network namespace\n"
#~ msgstr ""
#~ " -m, --mount       oddělí jmenný prostor přípojných bodů\n"
#~ " -u, --uts         oddělí jmenný prostor UTS (název stroje atd.)\n"
#~ " -i, --ipc         oddělí jmenný prostor System V IPC\n"
#~ " -n, --net         oddělí síťový jmenný prostor\n"

#~ msgid "%-15s%s [version %x]\n"
#~ msgstr "%-15s%s [verze %x]\n"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -8, --8bits                assume 8-bit tty\n"
#~ " -a, --autologin <user>     login the specified user automatically\n"
#~ " -c, --noreset              do not reset control mode\n"
#~ " -f, --issue-file <file>    display issue file\n"
#~ " -h, --flow-control         enable hardware flow control\n"
#~ " -H, --host <hostname>      specify login host\n"
#~ " -i, --noissue              do not display issue file\n"
#~ " -I, --init-string <string> set init string\n"
#~ " -l, --login-program <file> specify login program\n"
#~ " -L, --local-line           force local line\n"
#~ " -m, --extract-baud         extract baud rate during connect\n"
#~ " -n, --skip-login           do not prompt for login\n"
#~ " -o, --login-options <opts> options that are passed to login\n"
#~ " -p, --loginpause           wait for any key before the login\n"
#~ " -R, --hangup               do virtually hangup on the tty\n"
#~ " -s, --keep-baud            try to keep baud rate after break\n"
#~ " -t, --timeout <number>     login process timeout\n"
#~ " -U, --detect-case          detect uppercase terminal\n"
#~ " -w, --wait-cr              wait carriage-return\n"
#~ "     --noclear              do not clear the screen before prompt\n"
#~ "     --nohints              do not print hints\n"
#~ "     --nonewline            do not print a newline before issue\n"
#~ "     --no-hostname          no hostname at all will be shown\n"
#~ "     --long-hostname        show full qualified hostname\n"
#~ "     --version              output version information and exit\n"
#~ "     --help                 display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -8, --8bits                předpokládat 8bitové TTY\n"
#~ " -a, --autologin <uživatel> automaticky přihlásí zadaného uživatele\n"
#~ " -c, --noreset              neresetuje řídicí režim\n"
#~ " -f, --issue-file <soubor>  zobrazí soubor s vydáním\n"
#~ " -h, --flow-control         povolí hardwarové řízení toku\n"
#~ " -H, --host <název_stroje>  určí název stroje při přihlášení\n"
#~ " -i, --noissue              nezobrazí soubor s vydáním\n"
#~ " -I, --init-string <řetězec>\n"
#~ "                            nastaví inicializační řetězec\n"
#~ " -l, --login-program <soubor>\n"
#~ "                            určí program login\n"
#~ " -L, --local-line           vynutí místní linku\n"
#~ " -m, --extract-baud         získá baud rate z připojující se fáze\n"
#~ " -n, --skip-login           neptá se na přihlašovací jméno\n"
#~ " -o, --login-options <argumenty>\n"
#~ "                            argumenty, které budou předány programu login\n"
#~ " -p, --loginpause           před výzvou k přihlášení počká na stisk klávesy\n"
#~ " -R, --hangup               provede virtuální zavěšení linky na TTY\n"
#~ " -s, --keep-baud            pokusí se udržet baud rate i po znaku break\n"
#~ " -t, --timeout <číslo>      časový limit pro přihlášení\n"
#~ " -U, --detect-case          rozpozná terminál podporující jen velká písmena\n"
#~ " -w, --wait-cr              čeká na carriage-return\n"
#~ "     --noclear              před výzvou nesmaže obrazovku\n"
#~ "     --nohints              nezobrazí upozornění\n"
#~ "     --nonewline            neodřádkuje před výpisem vydání\n"
#~ "     --no-hostname          nezobrazí název stroje\n"
#~ "     --long-hostname        zobrazí plně kvalifikované jméno stroje\n"
#~ "     --version              zobrazí údaje o verzi a skončí\n"
#~ "     --help                 zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid "users"
#~ msgstr "uživatelé"

#~ msgid ""
#~ " -term <terminal_name>\n"
#~ " -reset\n"
#~ " -initialize\n"
#~ " -cursor <on|off>\n"
#~ " -repeat <on|off>\n"
#~ " -appcursorkeys <on|off>\n"
#~ " -linewrap <on|off>\n"
#~ " -default\n"
#~ " -foreground <black|blue|green|cyan|red|magenta|yellow|white|default>\n"
#~ " -background <black|blue|green|cyan|red|magenta|yellow|white|default>\n"
#~ " -ulcolor <black|grey|blue|green|cyan|red|magenta|yellow|white>\n"
#~ " -ulcolor <bright blue|green|cyan|red|magenta|yellow|white>\n"
#~ " -hbcolor <black|grey|blue|green|cyan|red|magenta|yellow|white>\n"
#~ " -hbcolor <bright blue|green|cyan|red|magenta|yellow|white>\n"
#~ " -inversescreen <on|off>\n"
#~ " -bold <on|off>\n"
#~ " -half-bright <on|off>\n"
#~ " -blink <on|off>\n"
#~ " -reverse <on|off>\n"
#~ " -underline <on|off>\n"
#~ " -store >\n"
#~ " -clear <all|rest>\n"
#~ " -tabs < tab1 tab2 tab3 ... >      (tabn = 1-160)\n"
#~ " -clrtabs < tab1 tab2 tab3 ... >   (tabn = 1-160)\n"
#~ " -regtabs <1-160>\n"
#~ " -blank <0-60|force|poke>\n"
#~ " -dump   <1-NR_CONSOLES>\n"
#~ " -append <1-NR_CONSOLES>\n"
#~ " -file dumpfilename\n"
#~ " -msg <on|off>\n"
#~ " -msglevel <0-8>\n"
#~ " -powersave <on|vsync|hsync|powerdown|off>\n"
#~ " -powerdown <0-60>\n"
#~ " -blength <0-2000>\n"
#~ " -bfreq freqnumber\n"
#~ " -version\n"
#~ " -help\n"
#~ msgstr ""
#~ " -term NÁZEV_TERMINÁLU\n"
#~ " -reset\n"
#~ " -initialize\n"
#~ " -cursor <on|off>\n"
#~ " -repeat <on|off>\n"
#~ " -appcursorkeys <on|off>\n"
#~ " -linewrap <on|off>\n"
#~ " -default\n"
#~ " -foreground <black|blue|green|cyan|red|magenta|yellow|white|default>\n"
#~ " -background <black|blue|green|cyan|red|magenta|yellow|white|default>\n"
#~ " -ulcolor <black|grey|blue|green|cyan|red|magenta|yellow|white>\n"
#~ " -ulcolor <bright blue|green|cyan|red|magenta|yellow|white>\n"
#~ " -hbcolor <black|grey|blue|green|cyan|red|magenta|yellow|white>\n"
#~ " -hbcolor <bright blue|green|cyan|red|magenta|yellow|white>\n"
#~ " -inversescreen <on|off>\n"
#~ " -bold <on|off>\n"
#~ " -half-bright <on|off>\n"
#~ " -blink <on|off>\n"
#~ " -reverse <on|off>\n"
#~ " -underline <on|off>\n"
#~ " -store >\n"
#~ " -clear <all|rest>\n"
#~ " -tabs <tab1 tab2 tab3…>      (index tabulátoru = 1–160)\n"
#~ " -clrtabs <tab1 tab2 tab3…>   (index tabulátoru = 1–160)\n"
#~ " -regtabs <1–160>\n"
#~ " -blank <0–60|force|poke>\n"
#~ " -dump   <1–POČET_KONZOL>\n"
#~ " -append <1–POČET_KONZOL>\n"
#~ " -file dumpfilename\n"
#~ " -msg <on|off>\n"
#~ " -msglevel <0–8>\n"
#~ " -powersave <on|vsync|hsync|powerdown|off>\n"
#~ " -powerdown <0–60>\n"
#~ " -blength <0–2000>\n"
#~ " -bfreq ČÍSLO_FREKVENCE\n"
#~ " -version\n"
#~ " -help\n"

#~ msgid "too many iov's (change code in wall/ttymsg.c)"
#~ msgstr "příliš mnoho iov (změňte kód ve wall/ttymsg.c)"

#~ msgid "write error."
#~ msgstr "chyba při zápisu."

#~ msgid ""
#~ "\n"
#~ "Usage: %s [options] [file ...]\n"
#~ msgstr ""
#~ "\n"
#~ "Použití: %s [PŘEPÍNAČE] [SOUBOR…]\n"

#~ msgid ""
#~ " -h, --help               displays this help text\n"
#~ " -V, --version            output version information and exit\n"
#~ " -c, --columns <width>    width of output in number of characters\n"
#~ " -t, --table              create a table\n"
#~ " -s, --separator <string> table delimeter\n"
#~ " -x, --fillrows           fill rows before columns\n"
#~ msgstr ""
#~ " -h, --help               zobrazí tento nápovědný text\n"
#~ " -V, --version            zobrazí údaje o verzi a skončí\n"
#~ " -c, --columns ŠÍŘKA      šířka výstupu ve znacích\n"
#~ " -t, --table              vytvoří tabulku\n"
#~ " -s, --separator ŘETĚZEC  oddělovač tabulky\n"
#~ " -x, --fillrows           před sloupci vyplní řádky\n"

#~ msgid ""
#~ "\n"
#~ "For more information see column(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v column(1).\n"

# more is literal name of the tool
#~ msgid "more (%s)\n"
#~ msgstr "more (%s)\n"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ " %s [options] [file...]\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ " %s [PŘEPÍNAČE] [SOUBOR…]\n"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -t, --terminal TERMINAL    override the TERM environment variable\n"
#~ " -i, --indicated            underlining is indicated via a separate line\n"
#~ " -V, --version              output version information and exit\n"
#~ " -h, --help                 display this help and exit\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Options:\n"
#~ " -t, --terminal TERMINÁL    přebije proměnnou prostředí TERM\n"
#~ " -i, --indicated            podtržení je vyznačeno samostatným řádkem\n"
#~ " -V, --version              zobrazí údaje o verzi a skončí\n"
#~ " -h, --help                 zobrazí tuto nápovědu a skončí\n"
#~ "\n"

#~ msgid "cannot stat file %s"
#~ msgstr "volání stat na souboru %s selhalo"

#~ msgid ""
#~ "usage: %s [-hv] [-x dir] file\n"
#~ " -h         print this help\n"
#~ " -x dir     extract into dir\n"
#~ " -v         be more verbose\n"
#~ " file       file to test\n"
#~ msgstr ""
#~ "Použití: %s [-hv] [-x ADRESÁŘ] SOUBOR\n"
#~ " -h          vypíše tuto nápovědu\n"
#~ " -x ADRESÁŘ  extrahuje do ADRESÁŘE\n"
#~ " -v          podrobnější hlášky\n"
#~ " SOUBOR      kontrolovaný soubor\n"

#~ msgid "Usage: %s [-larvsmf] /dev/name\n"
#~ msgstr "Použití: %s [-larvsmf] NÁZEV_ZAŘÍZENÍ\n"

#~ msgid "cannot stat device %s"
#~ msgstr "volání stat pro zařízení %s selhalo"

#~ msgid "failed to parse blocksize argument"
#~ msgstr "nezdařilo se rozebrat argument velikosti bloku"

#~ msgid "error: will not try to make swapdevice on '%s'"
#~ msgstr "chyba: nebude se zkoušet vytvořit odkládací zařízení na „%s“"

#~ msgid "Cannot open master raw device '%s' (%s)\n"
#~ msgstr "Řídicí syrové zařízení „%s“ nelze otevřít (%s)\n"

#~ msgid ""
#~ "Usage: %s [options] <device>\n"
#~ "\n"
#~ "Options:\n"
#~ msgstr ""
#~ "Použití: %s [PŘEPÍNAČE] <ZAŘÍZENÍ>\n"
#~ "\n"
#~ "Přepínače:\n"

#~ msgid ""
#~ "\n"
#~ "For more information see swaplabel(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete ve swaplabel(8).\n"

#~ msgid "Cannot open file '%s'"
#~ msgstr "Soubor „%s“ nelze otevřít"

#~ msgid ""
#~ "This disk has both DOS and BSD magic.\n"
#~ "Give the 'b' command to go to BSD mode.\n"
#~ msgstr ""
#~ "Tento disk má magické signatury DOSU i BSD.\n"
#~ "Pro vstup do BSD režimu použijte příkaz „b“.\n"

#~ msgid "Partition %i does not start on cylinder boundary:\n"
#~ msgstr "Diskový oddíl %i nezačíná na hranici cylindru:\n"

#~ msgid "should be (%d, %d, 1)\n"
#~ msgstr "mělo by být (%d, %d, 1)\n"

#~ msgid "should be (%d, %d, %d)\n"
#~ msgstr "mělo by být (%d, %d, %d)\n"

#~ msgid "This kernel finds the sector size itself - -b option ignored\n"
#~ msgstr "Toto jádro detekuje velikost sektoru automaticky - přepínač -b ignorován\n"

#~ msgid "out of memory?\n"
#~ msgstr "nedostatek paměti?\n"

#~ msgid ""
#~ "\n"
#~ "sfdisk: premature end of input\n"
#~ msgstr ""
#~ "\n"
#~ "sfdisk: předčasný konec vstupu\n"

#~ msgid "WARNING: couldn't open %s"
#~ msgstr "VAROVÁNÍ: %s se nepodařilo otevřít"

#~ msgid "WARNING: bad format on line %d of %s"
#~ msgstr "VAROVÁNÍ: chybný formát na řádku %d souboru %s"

#~ msgid ""
#~ "WARNING: Your /etc/fstab does not contain the fsck passno\n"
#~ "\tfield.  I will kludge around things for you, but you\n"
#~ "\tshould fix your /etc/fstab file as soon as you can.\n"
#~ msgstr ""
#~ "VAROVÁNÍ: Váš /etc/fstab neobsahuje položku s pořadím kontroly [passno].\n"
#~ "\tNějak se s tím poperu, ale vy byste měli /etc/fstab opravit\n"
#~ "\tco nejdříve.\n"

#~ msgid "couldn't open %s"
#~ msgstr "%s nelze otevřít"

#~ msgid "Cannot open /dev/port"
#~ msgstr "/dev/port nelze otevřít"

#~ msgid "failed to parse epoch"
#~ msgstr "epochu se nezdařilo rozebrat"

#~ msgid ""
#~ "You have specified multiple functions.\n"
#~ "You can only perform one function at a time."
#~ msgstr ""
#~ "Zadal jste vícero funkčních přepínačů.\n"
#~ "Program může provést v jeden okamžik právě jednu funkci."

#~ msgid "The --utc and --localtime options are mutually exclusive.  You specified both."
#~ msgstr "Přepínače --utc a --localtime se vzájemně vylučují. Zadali jste oba."

#~ msgid "The --adjust and --noadjfile options are mutually exclusive.  You specified both."
#~ msgstr "Přepínače --adjust a --noadjfile se vzájemně vylučují. Zadali jste oba."

#~ msgid "The --adjfile and --noadjfile options are mutually exclusive.  You specified both."
#~ msgstr "Přepínače --adjfile a --noadjfile se vzájemně vylučují. Zadali jste oba."

#~ msgid "Open of %s failed"
#~ msgstr "%s nebylo možné otevřít."

#~ msgid "Unable to open %s"
#~ msgstr "%s nelze otevřít"

#~ msgid "error: cannot open %s"
#~ msgstr "chyba: nelze otevřít %s"

#~ msgid "Failed to open %s for reading, exiting."
#~ msgstr "%s nelze otevřít pro čtení, končím."

#~ msgid "cannot lock group file"
#~ msgstr "soubor se skupinami nelze zamknout"

#~ msgid "the %s file is busy (%s present)"
#~ msgstr "%s soubor se právě používá (nalezen %s)"

#~ msgid "Usage: %s LABEL=<label>|UUID=<uuid>\n"
#~ msgstr "Použití: %s LABEL=<JMENOVKA>|UUID=<UUID>\n"

#~ msgid ""
#~ "\n"
#~ "For more information see findmnt(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete ve findmnt(1).\n"

#~ msgid ""
#~ "\n"
#~ "For more information see lsblk(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v lsblk(8).\n"

#~ msgid "invalid offset value '%s' specified"
#~ msgstr "zadána neplatná hodnota pozice „%s“"

#~ msgid "warning: failed to read mtab"
#~ msgstr "pozor: mtab se nepodařilo načíst"

#~ msgid "failed to parse class data"
#~ msgstr "nezdařilo rozebrat data třídy"

#~ msgid "configure, deconfigure, disable, dispatch, enable and rescan are mutually exclusive"
#~ msgstr "nastavení, odnastavení, vypnutí, režim rozhodování, zapnutí a zahájení hledání se vzájemně vylučují"

#~ msgid "clear, read-clear, console-level, console-on, and console-off options are mutually exclusive"
#~ msgstr "přepínače clear, read-clear, console-level, console-on and console-off se vzájemně vylučují"

#~ msgid "failed to parse buffer size"
#~ msgstr "nezdařilo se rozebrat velikost bufferu"

#~ msgid ""
#~ "\n"
#~ "For more information see fallocate(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete ve fallocate(1).\n"

#~ msgid "%s: fstat failed"
#~ msgstr "%s: volání fstat selhalo"

#~ msgid ""
#~ "\n"
#~ "For more information see fstrim(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v fstrim(8).\n"

#~ msgid "invalid speed"
#~ msgstr "neplatná rychlost"

#~ msgid "invalid offset '%s' specified"
#~ msgstr "zadána neplatná pozice „%s“"

#~ msgid "invalid size '%s' specified"
#~ msgstr "zadána neplatná velikost „%s“"

#~ msgid "extended and parsable formats are mutually exclusive"
#~ msgstr "rozšířený a rozebratelný formát se vzájemně vylučují"

#~ msgid "--all, --online and --offline options are mutually exclusive"
#~ msgstr "argumenty --all, --online a --offline se vzájemně vylučují"

#~ msgid "only one <source> may be specified"
#~ msgstr "pouze jeden <zdroj> smí být zadán"

#~ msgid "failed to allocate source buffer"
#~ msgstr "paměť pro zdroj nelze alokovat"

#~ msgid ""
#~ "\n"
#~ "For more information see mountpoint(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Podrobnosti naleznete v mountpoint(1).\n"

#~ msgid "only use one PID at a time"
#~ msgstr "najednou lze použít pouze jeden PID"

#~ msgid "cannot parse PID"
#~ msgstr "PID nelze rozebrat"

#~ msgid "failed to parse time_t value"
#~ msgstr "nezdařilo se rozebrat hodnotu time_t"

#~ msgid "'%s' is unsupported program name (must be 'swapon' or 'swapoff')."
#~ msgstr "„%s“ není název podporovaného programu (musí být „swapon“ nebo „swapoff“)."

#~ msgid "failed to stat directory"
#~ msgstr "volání stat nad adresářem selhalo"

#~ msgid ""
#~ "\n"
#~ "For more information see lsblk(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Podrobnosti naleznete v lsblk(1).\n"

#~ msgid "argument %lu is too large"
#~ msgstr "argument %lu je příliš velký"

#~ msgid "bad columns width value"
#~ msgstr "chybná hodnota počtu sloupců"

#~ msgid "-%c positive integer expected as an argument"
#~ msgstr "-%c: jako argument se očekává kladné celé číslo"

#~ msgid "bad length value"
#~ msgstr "chybná hodnota délky"

#~ msgid "bad skip value"
#~ msgstr "chybná hodnota přeskočení začátku"

#~ msgid "%s: Usage: %s [-number] [-p string] [-cefnrs] [+line] [+/pattern/] [files]\n"
#~ msgstr "%s: Použití: %s [-ČÍSLO] [-p ŘETĚZEC] [-cefnrs] [+ŘÁDEK] [+/VZOREK/] [SOUBOR…]\n"

#~ msgid "Cannot open "
#~ msgstr "Nelze otevřít "

#~ msgid "cannot open \"%s\" for read"
#~ msgstr "„%s“  nelze otevřít pro čtení"

#~ msgid "cannot stat \"%s\""
#~ msgstr "o „%s“ nelze získat podrobnosti"

#~ msgid "   d   delete a BSD partition"
#~ msgstr "   d   smazat BSD oddíl"

#~ msgid "   n   add a new BSD partition"
#~ msgstr "   n   vytvořit nový BSD oddíl"

#~ msgid "   t   change a partition's filesystem id"
#~ msgstr "   t   změní ID systému souborů daného oddílu"

#~ msgid "   u   change units (cylinders/sectors)"
#~ msgstr "   u   změní jednotky (cylindry/sektory)"

#~ msgid "   p   print the partition table"
#~ msgstr "   p   vypíše tabulku rozdělení disku"

#~ msgid ""
#~ "Building a new DOS disklabel with disk identifier 0x%08x.\n"
#~ "Changes will remain in memory only, until you decide to write them.\n"
#~ "After that, of course, the previous content won't be recoverable.\n"
#~ "\n"
#~ msgstr ""
#~ "Vytvářím novou DOSOVOU tabulku rozdělení disku s identifikátorem 0x%08x.\n"
#~ "Změny budou uloženy pouze v paměti, dokud se nerozhodnete je uložit na disk.\n"
#~ "Poté již nebudou stará data pochopitelně dostupná.\n"

#~ msgid "Device contains neither a valid DOS partition table, nor Sun, SGI or OSF disklabel\n"
#~ msgstr ""
#~ "Zařízení neobsahuje ani DOSOVOU tabulku rozdělení disku, ani SUN či SGI popis\n"
#~ "disku\n"

#~ msgid "Internal error\n"
#~ msgstr "Vnitřní chyba\n"

#~ msgid ""
#~ "\n"
#~ "\tSorry, no experts menu for SGI partition tables available.\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "\tPro SGI oddíly nejsou k dispozici žádné rozšiřující funkce.\n"
#~ "\n"

#~ msgid "Do You know, You got a partition overlap on the disk?\n"
#~ msgstr "Víte, že na vašem disku se oddíly překrývají?\n"

#~ msgid ""
#~ "Building a new SGI disklabel. Changes will remain in memory only,\n"
#~ "until you decide to write them. After that, of course, the previous\n"
#~ "content will be unrecoverably lost.\n"
#~ "\n"
#~ msgstr ""
#~ "Vytvářím nový SGI popis disku. Změny budou uloženy pouze do paměti,\n"
#~ "dokud se nerozhodnete je uložit na disk. Poté již nebudou stará data\n"
#~ "pochopitelně dostupná.\n"
#~ "\n"

#~ msgid "out of memory - giving up\n"
#~ msgstr "nedostatek paměti - končím\n"

#~ msgid "%-20s: failed: %s\n"
#~ msgstr "%-20s: neúspěch: %s\n"

#~ msgid "%-20s: failed\n"
#~ msgstr "%-20s: neúspěch\n"

#~ msgid ""
#~ "\n"
#~ "For more information see mount(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v mount(8).\n"

#~ msgid "login: memory low, login may fail\n"
#~ msgstr "login: nedostatek paměti, přihlášení se nemusí zdařit\n"

#~ msgid "can't malloc for ttyclass"
#~ msgstr "paměť pro ttyclass nelze alokovat"

#~ msgid "can't malloc for grplist"
#~ msgstr "paměť pro grplist nelze alokovat"

#~ msgid "Login on %s from %s denied.\n"
#~ msgstr "Přihlášení z $2%s na $1%s odmítnuto.\n"

#~ msgid "Usage: %s [ -f full-name ] [ -o office ] "
#~ msgstr "Použití: %s [ -f plné-jméno ] [ -o kancelář ] "

#~ msgid "[ --help ] [ --version ]\n"
#~ msgstr "[ --help ] [ -- version ]\n"

#~ msgid "%s: PAM failure, aborting: %s"
#~ msgstr "%s: chyba PAM, končí se: %s"

#~ msgid ""
#~ "Usage: %1$s [-s shell] [username]\n"
#~ "   or: %1$s (--list-shells | --help | --version)\n"
#~ msgstr ""
#~ "Použití: %1$s [-s SHELL] [UŽIVATELSKÉ_JMÉNO]\n"
#~ "   nebo: %1$s (--list-shells | --help | --version)\n"

#~ msgid "%s: can only change local entries."
#~ msgstr "%s: měnit lze pouze místní záznamy."

#~ msgid "%s: can't set default context for /etc/passwd"
#~ msgstr "%s: nelze nastavit výchozí kontext pro /etc/passwd"

#~ msgid "setpwnam failed"
#~ msgstr "funkce setpwnam selhala"

#~ msgid "%s: Use -l option to see list.\n"
#~ msgstr "%s: Seznam vypíšete přepínačem -l.\n"

#~ msgid "Use %s -l to see list.\n"
#~ msgstr "Použijte %s -l pro vypsání seznamu\n"

#~ msgid "usage: login [-fp] [username]\n"
#~ msgstr "Použití: login [fp] [uživatelské jméno]\n"

#~ msgid "Illegal username"
#~ msgstr "Chybné uživatelské jméno"

#~ msgid "LOGIN %s REFUSED FROM %s ON TTY %s"
#~ msgstr "PŘIHLÁŠENÍ UŽIVATELE %s Z %s NA TTY %s ODMÍTNUTO"

#~ msgid "LOGIN %s REFUSED ON TTY %s"
#~ msgstr "PŘIHLÁŠENÍ UŽIVATELE %s NA TTY %s ODMÍTNUTO"

#~ msgid "Login incorrect\n"
#~ msgstr "Chybné přihlášení\n"

#~ msgid "change terminal owner failed"
#~ msgstr "nepodařilo se změnit vlastníka terminálu"

#~ msgid "failure forking"
#~ msgstr "volání fork selhalo"

#~ msgid ""
#~ "\n"
#~ "%s login: "
#~ msgstr ""
#~ "\n"
#~ "Přihlašovací jméno na %s: "

#~ msgid "NAME too long"
#~ msgstr "JMÉNO je příliš dlouhé"

#~ msgid "login name much too long."
#~ msgstr "přihlašovací jméno je příliš dlouhé."

#~ msgid "login names may not start with '-'."
#~ msgstr "přihlašovací jména nesmí začínat na „-“."

#~ msgid "EXCESSIVE linefeeds"
#~ msgstr "PŘÍLIŠ mnoho znaků odřádkování"

#~ msgid "too many bare linefeeds."
#~ msgstr "příliš mnoho znaků odřádkování."

#~ msgid "LOGIN FAILURE FROM %s, %s"
#~ msgstr "CHYBNÉ PŘIHLÁŠENÍ UŽIVATELE %2$s Z %1$s"

#~ msgid "LOGIN FAILURE ON %s, %s"
#~ msgstr "CHYBNÉ PŘIHLÁŠENÍ UŽIVATELE %2$s NA TTY %1$s"

#~ msgid "%d LOGIN FAILURES FROM %s, %s"
#~ msgstr "POČET CHYBNÝCH PŘIHLÁŠENÍ UŽIVATELE %3$s Z %2$s: %1$d"

#~ msgid "%d LOGIN FAILURES ON %s, %s"
#~ msgstr "POČET CHYBNÝCH PŘIHLÁŠENÍ UŽIVATELE %3$s NA TTY %2$s: %1$d"

#~ msgid "%s: the group file is busy.\n"
#~ msgstr "%s: soubor se skupinami se právě používá.\n"

#~ msgid "%s: can't unlock %s: %s (your changes are still in %s)\n"
#~ msgstr "%s: %s nelze odemknout: %s (Vaše změny jsou stále v %s)\n"

#~ msgid "calloc failed"
#~ msgstr "funkce calloc selhala"

#~ msgid "WARNING: %s: appears to contain '%s' partition table"
#~ msgstr "POZOR: %s: zdá se, že obsahuje tabulku rozdělení disku „%s“"

#~ msgid "no magic string found at offset 0x%jx -- ignored"
#~ msgstr "na pozici 0x%jx nebyl nalezen žádný magický řetězec – ignoruje se"

#~ msgid "%s: write failed"
#~ msgstr "%s: zápis se nezdařil"

#~ msgid "%s: /dev directory does not exist."
#~ msgstr "%s: adresář /dev neexistuje."

#~ msgid "loop: can't set capacity on device %s: %s\n"
#~ msgstr "loop: zařízení %s nelze nastavit kapacitu: %s\n"

#~ msgid ", offset %<PRIu64>"
#~ msgstr ", odsazení %<PRIu64>"

#~ msgid ", encryption type %d\n"
#~ msgstr ", šifrovací typ %d\n"

#~ msgid "loop: can't get info on device %s: %s\n"
#~ msgstr "loop: informace o zařízení %s nelze získat: %s\n"

#~ msgid "loop: can't open device %s: %s\n"
#~ msgstr "loop: zařízení %s nelze otevřít: %s\n"

#~ msgid "%s: no permission to look at /dev/loop%s<N>"
#~ msgstr "%s: chybí oprávnění na prohlédnutí /dev/loop%s<N>"

#~ msgid ""
#~ "%s: Could not find any loop device. Maybe this kernel does not know\n"
#~ "       about the loop device? (If so, recompile or `modprobe loop'.)"
#~ msgstr ""
#~ "%s: Žádné loop zařízení nelze nalézt Toto jádro možná\n"
#~ "       nezná loop zařízení? (Pokud je tomu tak, pak jej znovu přeložte,\n"
#~ "       či zkuste „modprobe loop“.)"

#~ msgid "Out of memory while reading passphrase"
#~ msgstr "Během čtení hesla došla paměť"

#~ msgid "warning: %s is already associated with %s\n"
#~ msgstr "varování: %s je již spojeno s %s\n"

#~ msgid "warning: %s: is write-protected, using read-only.\n"
#~ msgstr "varování: %s: je chráněno proti zápisu, připojuji pouze pro čtení.\n"

#~ msgid "ioctl LOOP_SET_FD failed: %s\n"
#~ msgstr "selhalo ioctl LOOP_SET_FD: %s\n"

#~ msgid "set_loop(%s,%s,%llu,%llu): success\n"
#~ msgstr "set_loop(%s,%s,%llu,%llu): úspěch\n"

#~ msgid "del_loop(%s): success\n"
#~ msgstr "del_loop(%s): úspěch\n"

#~ msgid "loop: can't delete device %s: %s\n"
#~ msgstr "loop: zařízení %s nelze smazat: %s\n"

#~ msgid "This mount was compiled without loop support. Please recompile.\n"
#~ msgstr "Tento program byl přeložen bez podpory pro loop. Přeložte jej znovu.\n"

#~ msgid "stolen loop=%s...trying again\n"
#~ msgstr "ukradený loop=%s… zkouším znovu\n"

#~ msgid "No loop support was available at compile time. Please recompile.\n"
#~ msgstr "Podpora pro loop nebyla při překladu zadána. Přeložte program znovu.\n"

#~ msgid ""
#~ "\n"
#~ "For more information see partx(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v partx(8).\n"

#~ msgid "Usage: %s [-q [-i interval]] ([-s value]|[-S value]) ([-t value]|[-T value]) [-g|-G] file [file...]\n"
#~ msgstr "Použití: %s [-q [-i interval]] ([-s hodnota]|[-S hodnota]) ([-t hodnota]|[-T hodnota]) [-g|-G] soubor [soubor…]\n"

#~ msgid "Can't open %s: %s\n"
#~ msgstr "%s nelze otevřít: %s\n"

#~ msgid ""
#~ " -s  --shared     Get a shared lock\n"
#~ " -x  --exclusive  Get an exclusive lock\n"
#~ " -u  --unlock     Remove a lock\n"
#~ " -n  --nonblock   Fail rather than wait\n"
#~ " -w  --timeout    Wait for a limited amount of time\n"
#~ " -o  --close      Close file descriptor before running command\n"
#~ " -c  --command    Run a single command string through the shell\n"
#~ " -h  --help       Display this text\n"
#~ " -V  --version    Display version\n"
#~ "\n"
#~ msgstr ""
#~ "  -s  --shared     Získá sdílený zámek\n"
#~ "  -x  --exclusive  Získá výlučný zámek\n"
#~ "  -u  --unlock     Odstraní zámek\n"
#~ "  -n  --nonblock   Místo čekání selže\n"
#~ "  -w  --timeout    Čeká nejvýše zadanou dobu\n"
#~ "  -o  --close      Před spuštěním příkazu uzavře deskriptor souboru\n"
#~ "  -c  --command    Spustí řetězec jako jediný příkaz shellu\n"
#~ "  -h  --help       Zobrazí tento text\n"
#~ "  -V  --version    Zobrazí verzi\n"

#~ msgid "%s: cannot open lock file %s: %s\n"
#~ msgstr "%s: soubor zámku %s nelze otevřít: %s\n"

#~ msgid "%s: bad number: %s\n"
#~ msgstr "%s: chybné číslo: %s\n"

#~ msgid "%s: fork failed: %s\n"
#~ msgstr "%s: volání fork selhalo: %s\n"

#~ msgid ""
#~ " -M <size>     create shared memory segment of size <size>\n"
#~ " -S <nsems>    create semaphore array with <nsems> elements\n"
#~ " -Q            create message queue\n"
#~ " -p <mode>     permission for the resource (default is 0644)\n"
#~ msgstr ""
#~ " -M VELIKOST   vytvoří sdílený paměťový segment o velikost VELIKOST\n"
#~ " -S POČET      vytvoří pole semaforu s POČTEM prvků\n"
#~ " -Q            vytvoří frontu zpráv\n"
#~ " -p MÓD        práva pro zdroj (výchozí jsou 0644)\n"

#~ msgid ""
#~ "\n"
#~ "For more information see ipcmk(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Podrobnosti naleznete v ipcmk(1).\n"

#~ msgid "cannot remove id %s (%s)\n"
#~ msgstr "id %s nelze odstranit (%s)\n"

#~ msgid "deprecated usage: %s {shm | msg | sem} id ...\n"
#~ msgstr "Zavrhovaný způsob použití: %s [shm | msg | sem] id…\n"

#~ msgid ""
#~ "usage: %s [ [-q msqid] [-m shmid] [-s semid]\n"
#~ "          [-Q msgkey] [-M shmkey] [-S semkey] ... ]\n"
#~ msgstr ""
#~ "Použití: %s [ [-q ID_ZPRÁVY] [-m ID_SDÍLENÉ_PAMĚTI] [-s ID_SEMAFORU]\n"
#~ "            [-Q KLÍČ_ZPRÁVY] [-M KLÍČ_SDÍLENÉ_PAMĚTI] [-S KLÍČ_SEMAFORU] … ]\n"

#~ msgid "unknown error in key"
#~ msgstr "neznámá chyba v klíči"

#~ msgid "unknown error in id"
#~ msgstr "neznámá chyba v id"

#~ msgid "%s: %s (%s)\n"
#~ msgstr "%s: %s (%s)\n"

#~ msgid ""
#~ "Usage: %1$s [-asmq] [-t|-c|-l|-u|-p]\n"
#~ "       %1$s [-s|-m|-q] -i id\n"
#~ "       %1$s -h for help\n"
#~ msgstr ""
#~ "Použití: %1$s [-asmq] [-t|-c|-l|-u|-p]\n"
#~ "         %1$s [-s|-m|-q] -i id\n"
#~ "         %1$s -h pro nápovědu\n"

#~ msgid ""
#~ "Resource options:\n"
#~ "    -m      shared memory segments\n"
#~ "    -q      message queues\n"
#~ "    -s      semaphores\n"
#~ "    -a      all (default)\n"
#~ "\n"
#~ msgstr ""
#~ "Volby prostředků:\n"
#~ "    -m      sdílené segmenty paměti\n"
#~ "    -q      fronty zpráv\n"
#~ "    -s      semafory\n"
#~ "    -a      vše (implicitní)\n"
#~ "\n"

#~ msgid ""
#~ "Output format:\n"
#~ "    -t      time\n"
#~ "    -p      pid\n"
#~ "    -c      creator\n"
#~ "    -l      limits\n"
#~ "    -u      summary\n"
#~ msgstr ""
#~ "Výstupní formát:\n"
#~ "    -t      čas\n"
#~ "    -p      PID\n"
#~ "    -c      tvůrce\n"
#~ "    -l      omezení\n"
#~ "    -u      souhrn\n"

#~ msgid " %s [ -dhV78neo12 ] [ -s <speed> ] [ -i [-]<iflag> ] <ldisc> <device>\n"
#~ msgstr " %s [-dhV78neo12] [-s RYCHLOST] [-i [-]IFLAG] LDISC ZAŘÍZENÍ\n"

#~ msgid "ldattach from %s\n"
#~ msgstr "ldattach z %s\n"

#~ msgid ""
#~ "%s: Usage: \"%s [options]\n"
#~ "\t -m <mapfile>  (defaults: \"%s\" and\n"
#~ "\t\t\t\t  \"%s\")\n"
#~ "\t -p <pro-file> (default: \"%s\")\n"
#~ "\t -M <mult>     set the profiling multiplier to <mult>\n"
#~ "\t -i            print only info about the sampling step\n"
#~ "\t -v            print verbose data\n"
#~ "\t -a            print all symbols, even if count is 0\n"
#~ "\t -b            print individual histogram-bin counts\n"
#~ "\t -s            print individual counters within functions\n"
#~ "\t -r            reset all the counters (root only)\n"
#~ "\t -n            disable byte order auto-detection\n"
#~ "\t -V            print version and exit\n"
#~ msgstr ""
#~ "%s: Použití: \"%s [VOLBY]\n"
#~ "\t -m <MAPSOUBOR>  (implicitní: „%s“ a\n"
#~ "\t\t\t\t  „%s“)\n"
#~ "\t -p <PRO-SOUBOR> (implicitní: „%s“)\n"
#~ "\t -M <HODNOTA>  nastaví HODNOTU profilovacího multiplikátoru\n"
#~ "\t -i            vypíše pouze informace o profilovacím kroku\n"
#~ "\t -v            vypíše podrobné informace\n"
#~ "\t -a            vypíše veškeré symboly i pokud je hodnota čítače 0\n"
#~ "\t -b            vypíše jednotlivé histogram-bin čítače\n"
#~ "\t -s            vypíše jednotlivé čítače uvnitř funkcí\n"
#~ "\t -r            vynuluje veškeré čítače (pouze root)\n"
#~ "\t -n            zakáže autodetekci pořadí bytů\n"
#~ "\t -V            vypíše informace o verzi a skončí\n"

#~ msgid "readprofile: error writing %s: %s\n"
#~ msgstr "readprofile: chyba při zápisu %s: %s\n"

#~ msgid ""
#~ "\n"
#~ "For more information see rtcwake(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v rtcwake(8).\n"

#~ msgid ""
#~ "\n"
#~ "For more information see setarch(8).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v setarch(8).\n"

#~ msgid ""
#~ "%s: %s\n"
#~ "Try `%s --help' for more information.\n"
#~ msgstr ""
#~ "%s: %s\n"
#~ "Více informací získáte příkazem „%s --help“.\n"

#~ msgid "usage: %s program [arg ...]\n"
#~ msgstr "Použití: %s PROGRAM [ARGUMENT…]\n"

#~ msgid ""
#~ "Usage: %s <device> [ -i <IRQ> | -t <TIME> | -c <CHARS> | -w <WAIT> | \n"
#~ "          -a [on|off] | -o [on|off] | -C [on|off] | -q [on|off] | -s | \n"
#~ "          -T [on|off] ]\n"
#~ msgstr ""
#~ "Použití: %s <zařízení> [ -i <IRQ> | -t <ČAS> | -c <ZNAKY> | -w <ČEKÁNÍ> | \n"
#~ "            -a [on|off] | -o [on|off] | -C [on|off] | -q [on|off] | -s |\n"
#~ "            -T [on|off] ]\n"

#~ msgid "%s: bad value\n"
#~ msgstr "%s: chybná hodnota\n"

#~ msgid ""
#~ "\n"
#~ "For more information see unshare(1).\n"
#~ msgstr ""
#~ "\n"
#~ "Více informací naleznete v unshare(1).\n"

#~ msgid "  %s -V\n"
#~ msgstr "  %s -V\n"

#~ msgid "  %s --report [devices]\n"
#~ msgstr "  %s --report [ZAŘÍZENÍ…]\n"

#~ msgid "  %s [-v|-q] commands devices\n"
#~ msgstr "  %s  [-v|-q] PŘÍKAZ… ZAŘÍZENÍ…\n"

#~ msgid "%s: cannot open %s\n"
#~ msgstr "%s: nelze otevřít: %s\n"

#~ msgid "usage: %s [ -n ] device\n"
#~ msgstr "Použití: %s [-n] ZAŘÍZENÍ\n"

#~ msgid "malloc failed"
#~ msgstr "volání malloc selhalo"

#~ msgid "%s: option parse error\n"
#~ msgstr "%s: chyba při analýze přepínačů\n"

#~ msgid "Usage: %s [-x] [-d <num>] iso9660-image\n"
#~ msgstr "Použití: %s [-x] [-d <num>] iso9660-obraz\n"

#~ msgid ""
#~ "Usage: %s [-v] [-N nr-of-inodes] [-V volume-name]\n"
#~ "       [-F fsname] device [block-count]\n"
#~ msgstr ""
#~ "Použití: %s [-v] [-N počet i-uzlů] [-V název svazku]\n"
#~ "       [-F název ss] zařízení [počet bloků]\n"

#~ msgid "unable to stat %s"
#~ msgstr "o %s nelze získat informace"

#~ msgid "cannot determine sector size for %s"
#~ msgstr "nelze zjistit velikost sektoru %s"

#~ msgid "Usage: %s [-c] [-pPAGESZ] [-L label] [-U UUID] /dev/name [blocks]\n"
#~ msgstr "Použití: %s [-c] [-pVELIKOST_STRÁNKY] [-L JMENOVKA] [-U UUID] ZAŘÍZENÍ [BLOKY]\n"

#~ msgid "Out of memory"
#~ msgstr "Nedostatek paměti"

#~ msgid ""
#~ "Usage:\n"
#~ "  %s "
#~ msgstr ""
#~ "Použití:\n"
#~ "  %s "

#~ msgid "Menu without direction. Defaulting to horizontal."
#~ msgstr "Nabídka beze směru. Používám vodorovný."

#~ msgid "You must delete some partition and add an extended partition first\n"
#~ msgstr "Musíte nejprve některé oddíly smazat a přidat rozšířený oddíl.\n"

#~ msgid ""
#~ "Command action\n"
#~ "   %s\n"
#~ "   p   primary partition (1-4)\n"
#~ msgstr ""
#~ "Příkaz\n"
#~ "   %s\n"
#~ "   p   primární oddíl (1-4)\n"

#~ msgid "Sorry You may change the Tag of non-empty partitions.\n"
#~ msgstr "Lituji, můžete měnit značku neprázdných oddílů.\n"

#~ msgid "Warning: partitions %s "
#~ msgstr "Varování: oddíly %s "

#~ msgid "and %s overlap\n"
#~ msgstr "a %s se navzájem překrývají.\n"

#~ msgid "device: something like /dev/hda or /dev/sda"
#~ msgstr "Zařízení: něco jako /dev/hda či /dev/sda"

#~ msgid "    -s [or --show-size]: list size of a partition"
#~ msgstr "    -s [či --show-size]: vypíše velikost oddílu"

#~ msgid "    -d [or --dump]:      idem, but in a format suitable for later input"
#~ msgstr "    -d [či --dump]:      taktéž, ale ve formátu vhodném k dalšímu zpracování"

#~ msgid "    -i [or --increment]: number cylinders etc. from 1 instead of from 0"
#~ msgstr "    -i [či --increment]: čísluje cylindry etc. od 1 místo od 0"

#~ msgid "    -uS, -uB, -uC, -uM:  accept/report in units of sectors/blocks/cylinders/MB"
#~ msgstr "    -uS, -uB, -uC, -uM:  jako jednotky použije Sektory/Bloky/Cylindry či MB"

#~ msgid "    -D [or --DOS]:       for DOS-compatibility: waste a little space"
#~ msgstr "    -D [či --DOS]:       pro kompatibilitu s DOSEM: ubírá trochu místa"

#~ msgid "    -R [or --re-read]:   make kernel reread partition table"
#~ msgstr "    -R [či --re-read]:   donutí jádro znovu načíst tabulku rozdělení disku"

#~ msgid "    -O file :            save the sectors that will be overwritten to file"
#~ msgstr "    -O SOUBOR :          uloží změněné sektory do SOUBORU"

#~ msgid "    -I file :            restore these sectors again"
#~ msgstr "    -I SOUBOR :          obnoví tyto sektory ze SOUBORU"

#~ msgid "    -v [or --version]:   print version"
#~ msgstr "    -v [či --version]:   vypíše informace o verzi"

#~ msgid "    -? [or --help]:      print this message"
#~ msgstr "    -? [či --help]:      vypíše tuto nápovědu"

#~ msgid "    -g [or --show-geometry]: print the kernel's idea of the geometry"
#~ msgstr ""
#~ "    -g [či --show-geometry]:\n"
#~ "                         vypíše informace o geometrii, které udržuje jádro"

#~ msgid "    -L  [or --Linux]:      do not complain about things irrelevant for Linux"
#~ msgstr "    -L  [či --Linux]:    problémy nepodstatné pro Linux budou ignorovány"

#~ msgid "    You can override the detected geometry using:"
#~ msgstr "    Nalezenou geometrii můžete přepsat pomocí:"

#~ msgid "    -f  [or --force]:      do what I say, even if it is stupid"
#~ msgstr "    -f  [či --force]:    akceptuje veškeré - i nesmyslné - požadavky"

#~ msgid "success"
#~ msgstr "úspěch"

#~ msgid "Couldn't allocate memory for filesystem types\n"
#~ msgstr "Pro typy souborových systémů nebylo možné alokovat paměť\n"

#~ msgid "Usage: fsck [-AMNPRTV] [ -C [ fd ] ] [-t fstype] [fs-options] [filesys ...]\n"
#~ msgstr "Použití: fsck [-AMNPRTV] [-C [fd]][-t typ_ss] [volby_ss] [systém_souborů…]\n"

#~ msgid "fsck from %s\n"
#~ msgstr "fsck z %s\n"

#~ msgid "%s: Unable to allocate memory for fsck_path\n"
#~ msgstr "%s: Paměť pro fsck_path nelze alokovat\n"

#~ msgid "Try `getopt --help' for more information.\n"
#~ msgstr "Více informací získáte příkazem ?getopt --help“.\n"

#~ msgid "Usage: getopt optstring parameters\n"
#~ msgstr "Použití: getopt řetězec-s-volbami přepínače\n"

#~ msgid "       getopt [options] [--] optstring parameters\n"
#~ msgstr "       getopt [volby] [--] řetězec-s-volbami přepínače\n"

#~ msgid "              parameters\n"
#~ msgstr "              argumenty\n"

#~ msgid "getopt (enhanced) 1.1.4\n"
#~ msgstr "getopt (rozšířené) 1.1.4\n"

#~ msgid "(Expected: `UTC' or `LOCAL' or nothing.)\n"
#~ msgstr "(Očekáváno „UTC“, „LOCAL“ či nic.)\n"

#~ msgid ""
#~ "hwclock - query and set the hardware clock (RTC)\n"
#~ "\n"
#~ "Usage: hwclock [function] [options...]\n"
#~ "\n"
#~ "Functions:\n"
#~ "  -h | --help         show this help\n"
#~ "  -r | --show         read hardware clock and print result\n"
#~ "       --set          set the rtc to the time given with --date\n"
#~ "  -s | --hctosys      set the system time from the hardware clock\n"
#~ "  -w | --systohc      set the hardware clock to the current system time\n"
#~ "       --systz        set the system time based on the current timezone\n"
#~ "       --adjust       adjust the rtc to account for systematic drift since\n"
#~ "                      the clock was last set or adjusted\n"
#~ "       --getepoch     print out the kernel's hardware clock epoch value\n"
#~ "       --setepoch     set the kernel's hardware clock epoch value to the \n"
#~ "                      value given with --epoch\n"
#~ "       --predict      predict rtc reading at time given with --date\n"
#~ "  -v | --version      print out the version of hwclock to stdout\n"
#~ "\n"
#~ "Options: \n"
#~ "  -u | --utc          the hardware clock is kept in UTC\n"
#~ "       --localtime    the hardware clock is kept in local time\n"
#~ "  -f | --rtc=path     special /dev/... file to use instead of default\n"
#~ "       --directisa    access the ISA bus directly instead of %s\n"
#~ "       --badyear      ignore rtc's year because the bios is broken\n"
#~ "       --date         specifies the time to which to set the hardware clock\n"
#~ "       --epoch=year   specifies the year which is the beginning of the \n"
#~ "                      hardware clock's epoch value\n"
#~ "       --noadjfile    do not access /etc/adjtime. Requires the use of\n"
#~ "                      either --utc or --localtime\n"
#~ "       --adjfile=path specifies the path to the adjust file (default is\n"
#~ "                      /etc/adjtime)\n"
#~ "       --test         do everything except actually updating the hardware\n"
#~ "                      clock or anything else\n"
#~ "  -D | --debug        debug mode\n"
#~ "\n"
#~ msgstr ""
#~ "hwclock – zjišťuje a nastavuje čas hardwarových hodin (RTC)\n"
#~ "\n"
#~ "Použití: hwclock [FUNKCE] [VOLBY…]\n"
#~ "\n"
#~ "Funkce:\n"
#~ "  -h | --help         ukáže tuto nápovědu\n"
#~ "  -r | --show         zjistí a vypíše aktuální stav hodin reálného času\n"
#~ "       --set          nastaví RTC na hodnotu zadanou volbou --date\n"
#~ "  -s | --hctosys      nastaví systémový čas podle hodin reálného času\n"
#~ "  -w | --systohc      nastaví RTC podle aktuálního systémového času\n"
#~ "       --systz        nastaví systémový čas na základě současné časové zóny\n"
#~ "       --adjust       opraví RTC o systematický posun, který nastal od poslední\n"
#~ "                      opravy či nastavení RTC\n"
#~ "       --getepoch     vypíše počátek epochy hodin reálného času podle jádra\n"
#~ "       --setepoch     nastaví jádru počátek epochy hodin reálného času na\n"
#~ "                      hodnotu zadanou volbou --epoch\n"
#~ "       --predict      předpoví hodnotu RTC v době zadané pomocí --date\n"
#~ "  -v | --version      vypíše verzi hwclocku na standardní výstup\n"
#~ "\n"
#~ "Volby: \n"
#~ "  -u | --utc          hodiny reálného času jdou v UTC\n"
#~ "       --localtime    hodiny reálného času jdou v místním čase\n"
#~ "  -f | --rtc=CESTA    namísto výchozího zařízení použije z /dev/… jiné\n"
#~ "       --directisa    místo %s použije přímo ISA sběrnici\n"
#~ "       --badyear      ignoruje rok z RTC, protože BIOS je rozbitý\n"
#~ "       --date         čas, na který budou nastaveny hodiny reálného času\n"
#~ "       --epoch=ROK    určuje rok, kdy začíná epocha hodin reálného času\n"
#~ "       --noadjfile    nepoužije /etc/adjtime. Vyžaduje použití buď --utc,\n"
#~ "                      nebo --localtime\n"
#~ "       --adjfile=CESTA\n"
#~ "                      určuje cestu k souboru se systematickým posunem\n"
#~ "                      (implicitní je /etc/adjtime)\n"
#~ "       --test         provede vše kromě vlastního nastavení hodin reálného\n"
#~ "                      času nebo čehokoliv jiného\n"
#~ "  -D | --debug        ladicí režim\n"
#~ "\n"

#~ msgid "can't malloc initstring"
#~ msgstr "paměť pro inicializační řetězec nelze alokovat"

#~ msgid ""
#~ "Usage: %s [-8hiLmsUw] [-l login_program] [-t timeout] [-I initstring] [-H login_host] baud_rate,... line [termtype]\n"
#~ "or\t[-hiLmw] [-l login_program] [-t timeout] [-I initstring] [-H login_host] line baud_rate,... [termtype]\n"
#~ msgstr ""
#~ "Použití: %s [-8hiLmsUw] [-l LOGIN_PROGRAM] [-t ČASOVÝ_LIMIT] [-I INICIALIZAČNÍ_ŘETĚZEC] [-H POČÍTAČ] BAUD_RATE,… LINKA [TYP_TERMINÁLU]\n"
#~ "či\t[-hiLmw] [-l LOGIN_PROGRAM] [-t ČASOVÝ_LIMIT] [-I INICIALIZAČNÍ_ŘETĚZEC] [-H POČÍTAČ] LINKA BAUD_RATE,… [TYP_TERMINÁLU]\n"

#~ msgid "Usage: %s [y | n]"
#~ msgstr "Použití: %s [y | n]"

#~ msgid "%s: BAD ERROR"
#~ msgstr "%s: ZÁVAŽNÁ CHYBA"

#~ msgid "usage: %s [-n] [file]\n"
#~ msgstr "Použití: %s [-n] [SOUBOR]\n"

#~ msgid "can't read: %s"
#~ msgstr "nelze přečíst: %s"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -s, --fstab            search in static table of filesystems\n"
#~ " -m, --mtab             search in table of mounted filesystems\n"
#~ " -k, --kernel           search in kernel table of mounted \n"
#~ "                        filesystems (default)\n"
#~ "\n"
#~ " -c, --canonicalize     canonicalize printed paths\n"
#~ " -d, --direction <word> search direction - 'forward' or 'backward'\n"
#~ " -e, --evaluate         print all TAGs (LABEL/UUID) evaluated\n"
#~ " -f, --first-only       print the first found filesystem only\n"
#~ " -h, --help             print this help\n"
#~ " -i, --invert           invert sense of matching\n"
#~ " -l, --list             use list format output\n"
#~ " -n, --noheadings       don't print headings\n"
#~ " -u, --notruncate       don't truncate text in columns\n"
#~ " -O, --options <list>   limit the set of filesystems by mount options\n"
#~ " -o, --output <list>    output columns\n"
#~ " -r, --raw              use raw format output\n"
#~ " -a, --ascii            use ascii chars for tree formatting\n"
#~ " -t, --types <list>     limit the set of filesystem by FS types\n"
#~ " -v, --nofsroot         don't print [/dir] for bind or btrfs mounts\n"
#~ " -R, --submounts        print all submount for the matching filesystems\n"
#~ " -S, --source <string>  device, LABEL= or UUID=device\n"
#~ " -T, --target <string>  mountpoint\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Volby:\n"
#~ " -s, --fstab            hledá ve statické tabulce souborových systémů\n"
#~ " -m, --mtab             hledá v tabulce připojených souborových systémů\n"
#~ " -k, --kernel           hledá v jaderné tabulce připojených souborových\n"
#~ "                        systémů (implicitní)\n"
#~ "\n"
#~ " -c, --canonicalize     cesty vypisuje v kanonickém tvaru\n"
#~ " -d, --direction <SMĚR> směr hledání – „forward“ (dopředné) nebo\n"
#~ "                        „backward“ (zpětné)\n"
#~ " -e, --evaluate         všechny značky (jmenovky/UUID) před zobrazením\n"
#~ "                        vyhodnotí\n"
#~ " -f, --first-only       vypíše pouze první nalezený souborový systém\n"
#~ " -h, --help             zobrazí tuto nápovědu\n"
#~ " -i, --invert           obrátí smysl vyhledávacích pravidel\n"
#~ " -l, --list             výstup ve formátu seznamu\n"
#~ " -n, --noheadings       nezobrazí záhlaví\n"
#~ " -u, --notruncate       nezkracuje text ve sloupcích\n"
#~ " -O, --options <SEZNAM> omezí množinu souborových systémů podle voleb\n"
#~ "                        připojení\n"
#~ " -o, --output <SEZNAM>  zobrazí dané sloupce\n"
#~ " -r, --raw              neformátovaný výstup\n"
#~ " -a, --ascii            pro vykreslení stromu použije znaky ASCII\n"
#~ " -t, --types <SEZNAM>   omezí množinu souborových systémů podle jejich druhu\n"
#~ " -v, --nofsroot         u vázaných nebo btrfs připojení nevypisuje [/adresář]\n"
#~ " -R, --submounts        u odpovídajících souborových systémů vypisuje všechny\n"
#~ "                        podřízené body přípojení\n"
#~ " -S, --source <ŘETĚZEC> zařízení, LABEL= (jmenovka) nebo UUID=\n"
#~ " -T, --target <ŘETĚZEC> bod připojení\n"
#~ "\n"

#~ msgid "logger: %s: %s.\n"
#~ msgstr "logger: %s: %s.\n"

#~ msgid "usage: logger [-is] [-f file] [-p pri] [-t tag] [-u socket] [ message ... ]\n"
#~ msgstr "Použití: logger [-is] [-f soubor] [-p pri] [-t značka] [-u soket] [zpráva…]\n"

#~ msgid "usage: look [-dfa] [-t char] string [file]\n"
#~ msgstr "Použití: look [-dfa] [-t znak] řetězec [soubor]\n"

#~ msgid "out of memory?"
#~ msgstr "nedostatek paměti?"

#~ msgid "call: %s from to files...\n"
#~ msgstr "Použití: %s Z NA SOUBOR…\n"

#~ msgid "usage: script [-a] [-e] [-f] [-q] [-t] [file]\n"
#~ msgstr "použití: script [-a] [-f] [-q] [-t] [SOUBOR]\n"

#~ msgid "%s: write error %d: %s\n"
#~ msgstr "%s: chyba zápisu %d: %s\n"

#~ msgid "  [ -snow [on|off] ]\n"
#~ msgstr "  [ -snow [on|off] ]\n"

#~ msgid "  [ -softscroll [on|off] ]\n"
#~ msgstr "  [ -softscroll [on|off] ]\n"

#~ msgid "  [ -foreground black|blue|green|cyan"
#~ msgstr "  [ -foreground black|blue|green|cyan"

#~ msgid "|red|magenta|yellow|white|default ]\n"
#~ msgstr "|red|magenta|yellow|white|default ]\n"

#~ msgid "  [ -background black|blue|green|cyan"
#~ msgstr "  [ -background black|blue|green|cyan"

#~ msgid "  [ -ulcolor black|grey|blue|green|cyan"
#~ msgstr "  [ -ulcolor black|grey|blue|green|cyan"

#~ msgid "|red|magenta|yellow|white ]\n"
#~ msgstr "|red|magenta|yellow|white ]\n"

#~ msgid "  [ -ulcolor bright blue|green|cyan"
#~ msgstr "  [ -ulcolor bright blue|green|cyan"

#~ msgid "  [ -hbcolor black|grey|blue|green|cyan"
#~ msgstr "  [ -hbcolor black|grey|blue|green|cyan"

#~ msgid "  [ -hbcolor bright blue|green|cyan"
#~ msgstr "  [ -hbcolor bright blue|green|cyan"

#~ msgid "  [ -standout [ attr ] ]\n"
#~ msgstr "  [ -standout [ atribut ] ]\n"

#~ msgid "Usage: %s [-d] [-p pidfile] [-s socketpath] [-T timeout]\n"
#~ msgstr "Použití: %s [-d] [-p PID_SOUBOR] [-s CESTA_K_SOCKETU] [-t LIMIT]\n"

#~ msgid "       %s [-r|t] [-n num] [-s socketpath]\n"
#~ msgstr "       %s [-r|t] [-n POČ] [-s CESTA_K_SOCKETU]\n"

#~ msgid "       %s -k\n"
#~ msgstr "       %s -k\n"

#~ msgid "Usage: %s [-r] [-t]\n"
#~ msgstr "Použití: %s [-r] [-t]\n"

#~ msgid "whereis [ -sbmu ] [ -SBM dir ... -f ] name...\n"
#~ msgstr "whereis [ -sbmu ] [ -SBM adresář ... -f ] název...\n"

#~ msgid "usage: write user [tty]\n"
#~ msgstr "Použití: write uživatel [tty]\n"

#~ msgid "mount: can't open %s: %s"
#~ msgstr "mount: %s nelze otevřít: %s"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ " %1$s -a [-e] [-v] [-f]             enable all swaps from /etc/fstab\n"
#~ " %1$s [-p priority] [-d] [-v] [-f] <special>  enable given swap\n"
#~ " %1$s -s                            display swap usage summary\n"
#~ " %1$s -h                            display help\n"
#~ " %1$s -V                            display version\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ " %1$s -a [-e] [-v] [-f]             zapne všechny odkládací oblasti\n"
#~ "                                    uvedené v /etc/fstab\n"
#~ " %1$s [-p PRIORITA] [-d] [-v] [-f] ZVLÁŠTNÍ\n"
#~ "                                    zapne vybranou odkládací oblast\n"
#~ " %1$s -s                            vypíše souhrnné informace o využití\n"
#~ "                                    odkládacích oblastí\n"
#~ " %1$s -h                            vypíše nápovědu\n"
#~ " %1$s -V                            vypíše verzi\n"
#~ "\n"

#~ msgid ""
#~ "\n"
#~ "Usage:\n"
#~ " %1$s -a [-v]                      disable all swaps\n"
#~ " %1$s [-v] <special>               disable given swap\n"
#~ " %1$s -h                           display help\n"
#~ " %1$s -V                           display version\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "Použití:\n"
#~ " %1$s -a [-v]                      vypne všechny odkládací oblasti\n"
#~ " %1$s [-v] ZVLÁŠTNÍ                vypne vybranou odkládací oblast\n"
#~ " %1$s -h                           vypíše nápovědu\n"
#~ " %1$s -V                           vypíše verzi\n"
#~ "\n"

# unknown policy
#~ msgid "unknown\n"
#~ msgstr "neznámá\n"

#~ msgid ""
#~ "\n"
#~ "ionice - sets or gets process io scheduling class and priority.\n"
#~ "\n"
#~ "Usage:\n"
#~ "  ionice [ options ] -p <pid> [<pid> ...]\n"
#~ "  ionice [ options ] <command> [<arg> ...]\n"
#~ "\n"
#~ "Options:\n"
#~ "  -n <classdata>      class data (0-7, lower being higher prio)\n"
#~ "  -c <class>          scheduling class\n"
#~ "                      0: none, 1: realtime, 2: best-effort, 3: idle\n"
#~ "  -t                  ignore failures\n"
#~ "  -h                  this help\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "ionice – zjistí nebo nastaví plánovací třídu nebo prioritu I/O.\n"
#~ "\n"
#~ "Použití:\n"
#~ "  ionice [PŘEPÍNAČE] -p <PID> [<PID>…]\n"
#~ "  ionice [PŘEPÍNAČE] <PŘÍKAZ> [<ARGUMENT>…]\n"
#~ "\n"
#~ "Přepínače:\n"
#~ "  -n <DATA_TŘÍDY>     data třídy (0–7, menší číslo znamená vyšší prioritu)\n"
#~ "  -c <TŘÍDA>          plánovací třída: 0 – žádná, 1 – reálný čas, \n"
#~ "                      2 – best-effort, 3 – zahálení [idle]\n"
#~ "  -t                  ignorovat selhání\n"
#~ "  -h                  tato nápověda\n"
#~ "\n"

#~ msgid "CPU mask"
#~ msgstr "masku CPU"

#~ msgid ""
#~ "\n"
#~ "Options:\n"
#~ " -a, --all               mount all filesystems mentioned in fstab\n"
#~ " -f, --fake              dry run, skip mount(2) syscall\n"
#~ " -F, --fork              fork off for each device (use with -a)\n"
#~ " -h, --help              this help\n"
#~ " -n, --no-mtab           don't write to /etc/mtab\n"
#~ " -r, --read-only         mount the filesystem read-only (same as -o ro)\n"
#~ " -v, --verbose           verbose mode\n"
#~ " -V, --version           print version string\n"
#~ " -w, --read-write        mount the filesystem read-write (default)\n"
#~ " -o, --options <list>    comma separated string of mount options\n"
#~ " -O, --test-opts <list>  limit the set of filesystems (use with -a)\n"
#~ " -t, --types <list>      indicate the filesystem type\n"
#~ " -c, --no-canonicalize   don't canonicalize paths\n"
#~ " -i, --internal-only     don't call the mount.<type> helpers\n"
#~ " -l, --show-labels       lists all mounts with LABELs\n"
#~ "\n"
#~ "Source:\n"
#~ " -L, --label <label>     synonym for LABEL=<label>\n"
#~ " -U, --uuid <uuid>       synonym for UUID=<uuid>\n"
#~ " LABEL=<label>           specifies device by filesystem label\n"
#~ " UUID=<uuid>             specifies device by filesystem UUID\n"
#~ " <device>                specifies device by path\n"
#~ " <directory>             mountpoint for bind mounts (see --bind/rbind)\n"
#~ " <file>                  regular file for loopdev setup\n"
#~ "\n"
#~ "Operations:\n"
#~ " -B, --bind              mount a subtree somewhere else (same as -o bind)\n"
#~ " -M, --move              move a subtree to some other place\n"
#~ " -R, --rbind             mount a subtree and all submounts somewhere else\n"
#~ " --make-shared           mark a subtree as shared\n"
#~ " --make-slave            mark a subtree as slave\n"
#~ " --make-private          mark a subtree as private\n"
#~ " --make-unbindable       mark a subtree as unbindable\n"
#~ " --make-rshared          recursively mark a whole subtree as shared\n"
#~ " --make-rslave           recursively mark a whole subtree as slave\n"
#~ " --make-rprivate         recursively mark a whole subtree as private\n"
#~ " --make-runbindable      recursively mark a whole subtree as unbindable\n"
#~ msgstr ""
#~ "\n"
#~ "Přepínače:\n"
#~ " -a, --all               připojí veškeré souborové systémy uvedené ve fstab\n"
#~ " -f, --fake              zkušební režim, vynechá volání systému mount(2)\n"
#~ " -F, --fork              pro každé zařízení vytvoří potomka (použít s -a)\n"
#~ " -h, --help              tato nápověda\n"
#~ " -n, --no-mtab           nezapíše do /etc/mtab\n"
#~ " -r, --read-only         souborový systém připojí jen pro čtení (stejné jako\n"
#~ "                         -o ro)\n"
#~ " -v, --verbose           sdílný režim\n"
#~ " -V, --version           vypíše verzi programu\n"
#~ " -w, --read-write        souborový systém připojí pro čtení i zápis (výchozí)\n"
#~ " -o, --options SEZNAM    volby připojení oddělené čárkou\n"
#~ " -O, --test-opts SEZNAM  omezí množinu souborových systémů (použít s -a)\n"
#~ " -t, --types SEZNAM      určí druh souborového systému\n"
#~ " -c, --no-canonicalize   cesty nepřevede na kanonický tvar\n"
#~ " -i, --internal-only     nezavolá pomocný program mount.DRUH\n"
#~ " -l, --show-labels       vypíše všechny připojené systémy a jejich jmenovky\n"
#~ "\n"
#~ "Zdroj:\n"
#~ " -L, --label JMENOVKA    synonymum pro LABEL=JMENOVKA\n"
#~ " -U, --uuid UUID         synonymum pro UUID=UUID\n"
#~ " LABEL=JMENOVKA          určí zařízené podle jmenovky systému souborů\n"
#~ " UUID=UUID               určí zařízení podle UUID systému souborů\n"
#~ " ZAŘÍZENÍ                určí zařízení podle cesty\n"
#~ " ADRESÁŘ                 bod připojení pro vázaná připojení (vizte --bind/rbind)\n"
#~ " SOUBOR                  obyčejný soubor pro připojení přes loop zařízení\n"
#~ "\n"
#~ "Operace:\n"
#~ " -B, --bind              připojí podstrom někam jinam (stejné jako -o bind)\n"
#~ " -M, --move              přesune podstrom na jiné místo\n"
#~ " -R, --rbind             připojí podstrom a všechny podřízené systémy jinam\n"
#~ " --make-shared           označí podstrom jako sdílený\n"
#~ " --make-slave            označí podstrom jako podřízený\n"
#~ " --make-private          označí podstrom jako soukromý\n"
#~ " --make-unbindable       označí podstrom jako vázaně nepřipojitelný\n"
#~ " --make-rshared          rekurzivně označí celý podstrom jako sdílený\n"
#~ " --make-rslave           rekurzivně označí celý podstrom jako podřízený\n"
#~ " --make-rprivate         rekurzivně označí celý podstrom jako soukromý\n"
#~ " --make-runbindable      rekurzivně označí celý podstrom jako vázaně\n"
#~ "                         nepřipojitelný\n"

#~ msgid "Usage: shutdown [-h|-r] [-fqs] [now|hh:ss|+mins]\n"
#~ msgstr "Použití: shutdown [-h|-r] [-fqs] [now|hh:ss|+minuty]\n"

#~ msgid "Shutdown process aborted"
#~ msgstr "Proces shutdown ukončen"

#~ msgid "only root can shut a system down."
#~ msgstr "pouze root může vypnout systém."

#~ msgid "that must be tomorrow, can't you wait till then?"
#~ msgstr "To musí být zítra. To do té doby nemůžete počkat?"

#~ msgid "for maintenance; bounce, bounce"
#~ msgstr "kvůli údržbě"

#~ msgid "The system is being shut down within 5 minutes"
#~ msgstr "Systém bude za 5 minut vypnut"

#~ msgid "Login is therefore prohibited."
#~ msgstr "Přihlašování je tudíž zakázáno."

#~ msgid "rebooted by %s: %s"
#~ msgstr "restartováno uživatelem %s: %s"

#~ msgid "halted by %s: %s"
#~ msgstr "zastaveno uživatelem %s: %s"

#~ msgid ""
#~ "\n"
#~ "Why am I still alive after reboot?"
#~ msgstr ""
#~ "\n"
#~ "Proč jsem po restartu stále naživu?"

#~ msgid ""
#~ "\n"
#~ "Now you can turn off the power..."
#~ msgstr ""
#~ "\n"
#~ "Nyní můžete vypnout proud…"

#~ msgid "Calling kernel power-off facility...\n"
#~ msgstr "Volám zařízení jádra pro vypínání proudu…\n"

#~ msgid "Error powering off\t%s\n"
#~ msgstr "Chyba při vypínání proudu\t%s\n"

#~ msgid "Executing the program \"%s\" ...\n"
#~ msgstr "Spouštím program „%s“…\n"

#~ msgid "URGENT: broadcast message from %s:"
#~ msgstr "NALÉHAVÉ: zpráva pro všechny od %s:"

#~ msgid "System going down in %d hours %d minutes"
#~ msgstr "Systém bude vypnut za %dh %dmin"

#~ msgid "System going down in 1 hour %d minutes"
#~ msgstr "Systém bude vypnut za 1h %dmin"

#~ msgid "System going down in %d minutes\n"
#~ msgstr "Systém bude vypnut za %dmin\n"

#~ msgid "System going down in 1 minute\n"
#~ msgstr "Systém bude vypnut za 1min\n"

#~ msgid "System going down IMMEDIATELY!\n"
#~ msgstr "Systém bude OKAMŽITĚ vypnut!\n"

#~ msgid "\t... %s ...\n"
#~ msgstr "\t... %s ...\n"

#~ msgid "Cannot fork for swapoff. Shrug!"
#~ msgstr "Swapoff nelze spustit - volání fork selhalo."

#~ msgid "Cannot exec swapoff, hoping umount will do the trick."
#~ msgstr "Swapoff nelze spustit - volání exec selhalo. Snad pomůže umount."

#~ msgid "Cannot fork for umount, trying manually."
#~ msgstr "Umount nelze spustit - volání fork selhalo, zkouším to ručně."

#~ msgid "Cannot exec %s, trying umount.\n"
#~ msgstr "%s nelze spustit - volání exec selhalo, zkouším umount.\n"

#~ msgid "Cannot exec umount, giving up on umount."
#~ msgstr "Umount nelze spustit - volání exec selhalo, vzdávám snahu o spuštění umount."

#~ msgid "Unmounting any remaining filesystems..."
#~ msgstr "Odpojuji všechny zbývající systémy souborů…"

#~ msgid "shutdown: Couldn't umount %s: %s\n"
#~ msgstr "shutdown: %s nelze odpojit: %s\n"

#~ msgid "Booting to single user mode.\n"
#~ msgstr "Startuji do režimu pro jednoho uživatele.\n"

#~ msgid "exec of single user shell failed\n"
#~ msgstr "Spuštění shellu pro jednoho uživatele se nezdařilo - volání exec selhalo.\n"

#~ msgid "fork of single user shell failed\n"
#~ msgstr "Spuštění shellu pro jednoho uživatele se nezdařilo - volání fork selhalo.\n"

#~ msgid "error opening fifo\n"
#~ msgstr "Chyba při otevírání pojmenované roury\n"

#~ msgid "error setting close-on-exec on /dev/initctl"
#~ msgstr "chyba během nastavování zavřít-při-spuštění příznaku na /dev/initctl"

#~ msgid "error running finalprog\n"
#~ msgstr "chyba při běhu závěrečného programu\n"

#~ msgid "error forking finalprog\n"
#~ msgstr "volání fork pro závěrečný program selhalo\n"

#~ msgid ""
#~ "\n"
#~ "Wrong password.\n"
#~ msgstr ""
#~ "\n"
#~ "Chybné heslo.\n"

#~ msgid "lstat of path failed\n"
#~ msgstr "volání lstat pro cestu selhalo\n"

#~ msgid "respawning: \"%s\" too fast: quenching entry\n"
#~ msgstr "obnovování: „%s“ příliš rychle: tlumím záznam\n"

#~ msgid "fork failed\n"
#~ msgstr "volání fork selhalo\n"

#~ msgid "cannot open inittab\n"
#~ msgstr "inittab nelze otevřít\n"

#~ msgid "no TERM or cannot stat tty\n"
#~ msgstr "žádný TERM nebo selhalo volání stat pro tty\n"

#~ msgid "error at stopping service \"%s\"\n"
#~ msgstr "chyba při zastavování služby „%s“\n"

#~ msgid "Stopped service: %s\n"
#~ msgstr "Zastavená služby: %s\n"

#~ msgid "error at starting service \"%s\"\n"
#~ msgstr "chyba při spouštění služby „%s“\n"

#~ msgid "Usage: %s [-c] [-n level] [-r] [-s bufsize]\n"
#~ msgstr "Použití: %s [-c] [-n úroveň] [-r] [-s velikost_bufferu]\n"

#~ msgid "error: strdup failed"
#~ msgstr "chyba: funkce strdup selhala"

#~ msgid "error: calloc failed"
#~ msgstr "chyba: funkce calloc selhala"

#~ msgid ""
#~ "Usage: %s [options]\n"
#~ "\n"
#~ "Options:\n"
#~ msgstr ""
#~ "Použití: %s [PŘEPÍNAČE]\n"
#~ "\n"
#~ "Přepínače:\n"

#~ msgid "usage: %s [-bfpx] [-l nline]"
#~ msgstr "Použití: %s [-bfpx] [-l POČET_ŘÁDKŮ]"

#~ msgid "usage: %s [ - ] [ -2 ] [ file ... ]\n"
#~ msgstr "Použití: %s [-] [-2] [SOUBOR…]\n"

#~ msgid "hexdump: [-bcCdovx] [-e fmt] [-f fmt_file] [-n length] [-s skip] [file ...]\n"
#~ msgstr "hexdump: [-bcCdovx] [-e FMT] [-f FMT_SOUBOR] [-n DÉLKA] [-s VZDÁLENOST] [SOUBOR…]\n"

#~ msgid "usage: %s [-dflpcsu] [+linenum | +/pattern] name1 name2 ...\n"
#~ msgstr "Použití: %s [-dflpcsu] [+ČÍSLO_ŘÁDKU | +/VZOREK] NÁZEV1 NÁZEV2…\n"

#~ msgid "failed to initialize line buffer\n"
#~ msgstr "řádkový buffer se nepodařilo inicializovat\n"

#~ msgid "hexdump: can't read %s.\n"
#~ msgstr "hexdump: %s nelze číst.\n"

#~ msgid "hexdump: line too long.\n"
#~ msgstr "hexdump: řádek je příliš dlouhý.\n"

#~ msgid "realloc failed"
#~ msgstr "volání realloc selhalo"

#~ msgid "usage: tailf [-n N | -N] logfile"
#~ msgstr "Použití: tailf [-n N | -N] SOUBOR_S_PROTOKOLEM"

#~ msgid "Usage: %s [ -i ] [ -tTerm ] file...\n"
#~ msgstr "Použití: %s [-i] [-tTERMINÁL] SOUBOR…\n"

#~ msgid "Partition ends in the final partial cylinder"
#~ msgstr "Diskový oddíl končí v posledním částečném cylindru"

#~ msgid "Unable to open %s\n"
#~ msgstr "%s nelze otevřít\n"

#~ msgid "Unable to allocate any more memory\n"
#~ msgstr "Nelze alokovat více paměti\n"

#~ msgid ""
#~ "\n"
#~ "got EOF thrice - exiting..\n"
#~ msgstr ""
#~ "\n"
#~ "třikrát jsem nalezl EOF - končím..\n"

#~ msgid "last: malloc failure.\n"
#~ msgstr "last: volání malloc selhalo.\n"

#~ msgid "login: Out of memory\n"
#~ msgstr "login: Nedostatek paměti\n"

#~ msgid "login: no shell: %s.\n"
#~ msgstr "login: žádný shell: %s.\n"

#~ msgid "newgrp: setgid"
#~ msgstr "newgrp: setgid"

#~ msgid "newgrp: Permission denied"
#~ msgstr "newgrp: Přístup odmítnut"

#~ msgid "newgrp: setuid"
#~ msgstr "newgrp: setuid"

#~ msgid "%s: Cannot fork\n"
#~ msgstr "%s: volání fork selhalo\n"

#~ msgid "%s: can't read %s.\n"
#~ msgstr "%s: %s nelze číst.\n"

#~ msgid "%s: can't stat temporary file.\n"
#~ msgstr "%s: volání stat pro dočasný soubor selhalo.\n"

#~ msgid "%s: can't read temporary file.\n"
#~ msgstr "%s: dočasný soubor nelze číst.\n"

#~ msgid "%s: parse error: %s"
#~ msgstr "%s: chyba rozboru: %s"

#~ msgid "%s: out of memory\n"
#~ msgstr "%s: nedostatek paměti\n"

#~ msgid " and %d."
#~ msgstr " a %d."

#~ msgid "%s: illegal option -- %c\n"
#~ msgstr "%s: nepovolená volba – %c\n"

#~ msgid "segments allocated %d\n"
#~ msgstr "alokované segmenty %d\n"

#~ msgid "pages allocated %ld\n"
#~ msgstr "alokované stránky %ld\n"

#~ msgid "pages resident  %ld\n"
#~ msgstr "rezidentní stránky %ld\n"

#~ msgid "Swap performance: %ld attempts\t %ld successes\n"
#~ msgstr "Statistika pro odkládání: pokusů: %ld\t, z toho úspěšných: %ld\n"

#~ msgid "renice: %s: unknown user\n"
#~ msgstr "renice: %s: neznámý uživatel\n"

#~ msgid "renice: %s: bad value\n"
#~ msgstr "renice: %s: chybná hodnota\n"

#~ msgid "%s: illegal interval %s seconds\n"
#~ msgstr "%s: nepovolený interval %s sekund\n"

#~ msgid "%s: illegal time_t value %s\n"
#~ msgstr "%s: %s není povolená hodnota time_t\n"

#~ msgid "%s: unable to execute %s: %s\n"
#~ msgstr "%s: %s nelze spustit: %s\n"

#~ msgid "rtc read"
#~ msgstr "odečtení hodin reálného času"

#~ msgid "malloc error"
#~ msgstr "chyba malloc"

#~ msgid "usage: column [-tx] [-c columns] [file ...]\n"
#~ msgstr "Použití: column [-tx] [-c SLOUPCE] [SOUBOR…]\n"

#~ msgid "od: od(1) has been deprecated for hexdump(1).\n"
#~ msgstr "od: program od(1) je zastaralý, místo něj použijte hexdump(1).\n"

#~ msgid "od: hexdump(1) compatibility doesn't support the -%c option%s\n"
#~ msgstr "od: režim kompatibility s hexdump(1) nepodporuje -%c volbu%s\n"

#~ msgid "; see strings(1)."
#~ msgstr "; viz strings(1)."

#~ msgid "Out of memory\n"
#~ msgstr "Nedostatek paměti\n"

#~ msgid "unable to allocate bufferspace"
#~ msgstr "místo pro buffer nelze přidělit"

#~ msgid "usage: rev [file ...]\n"
#~ msgstr "Použití: rev [SOUBOR…]\n"

#~ msgid "Unable to allocate buffer.\n"
#~ msgstr "Buffer nelze naalokovat.\n"

#~ msgid "Out of memory when growing buffer.\n"
#~ msgstr "Nedostatek paměti pro rostoucí buffer.\n"

# Dodržet zarovnání se zprávou „POZOR: Režim kompatibility…“
#~ msgid ""
#~ " and change display units to\n"
#~ "         sectors (command 'u').\n"
#~ msgstr ""
#~ " a změnit jednotky výpisů na sektory\n"
#~ "       (příkaz „u“).\n"

#~ msgid "error running programme: \"%s\"\n"
#~ msgstr "chyba při spouštění programu: „%s“\n"

#~ msgid "invalid offset '%s' value specified"
#~ msgstr "zadána neplatná hodnota pozice „%s“"

#~ msgid ""
#~ "\n"
#~ "chrt - manipulate real-time attributes of a process.\n"
#~ "\n"
#~ "Set policy:\n"
#~ "  chrt [options] <policy> <priority> {<pid> | <command> [<arg> ...]}\n"
#~ "\n"
#~ "Get policy:\n"
#~ "  chrt [options] {<pid> | <command> [<arg> ...]}\n"
#~ "\n"
#~ "\n"
#~ "Scheduling policies:\n"
#~ "  -b | --batch         set policy to SCHED_BATCH\n"
#~ "  -f | --fifo          set policy to SCHED_FIFO\n"
#~ "  -i | --idle          set policy to SCHED_IDLE\n"
#~ "  -o | --other         set policy to SCHED_OTHER\n"
#~ "  -r | --rr            set policy to SCHED_RR (default)\n"
#~ "\n"
#~ "Scheduling flags:\n"
#~ "  -R | --reset-on-fork set SCHED_RESET_ON_FORK for FIFO or RR\n"
#~ "\n"
#~ "Options:\n"
#~ "  -h | --help          display this help\n"
#~ "  -p | --pid           operate on existing given pid\n"
#~ "  -m | --max           show min and max valid priorities\n"
#~ "  -v | --verbose       display status information\n"
#~ "  -V | --version       output version information\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "chrt – zachází s vlastnostmi procesu týkajícími se plánování v reálném čase.\n"
#~ "\n"
#~ "Nastaví politiku:\n"
#~ "  chrt [PŘEPÍNAČE] <POLITIKA> <PRIORITA> {<PID> | <PŘÍKAZ> [<ARGUMENT>…]}\n"
#~ "\n"
#~ "Získá politiku:\n"
#~ "  chrt [PŘEPÍNAČE] {<PID> | <PŘÍKAZ> [<ARGUMENT>…]}\n"
#~ "\n"
#~ "\n"
#~ "Politiky plánování:\n"
#~ "  -b | --batch         nastaví politiku na SCHED_BATCH (dávka)\n"
#~ "  -f | --fifo          nastaví politiku na SCHED_FIFO (fronta)\n"
#~ "  -i | --idle          nastaví politiku na SCHED_IDLE (zahálení)\n"
#~ "  -o | --other         nastaví politiku na SCHED_OTHER (jiná)\n"
#~ "  -r | --rr            nastaví politiku na SCHED_RR (implicitní)\n"
#~ "\n"
#~ "Příznaky plánování:\n"
#~ "  -R | --reset-on-fork u FIFO nebo RR nastaví SCHED_RESET_ON_FORK\n"
#~ "\n"
#~ "Přepínače:\n"
#~ "  -h | --help          zobrazí tuto nápovědu\n"
#~ "  -p | --pid           pracuje nad existujícím procesem s PID\n"
#~ "  -m | --max           zobrazí minimální a maximální platné priority\n"
#~ "  -v | --verbose       zobrazí stavové informace\n"
#~ "  -V | --version       vypíše informace o verzi\n"
#~ "\n"

# current policy/priority
#~ msgid "current"
#~ msgstr "současná"

# pid %d's _new_ scheduling policy 
#~ msgid "new"
#~ msgstr "nová"

#~ msgid "Linux ext2"
#~ msgstr "Linux ext2"

#~ msgid "Linux ext3"
#~ msgstr "Linux ext3"

#~ msgid "Linux XFS"
#~ msgstr "Linux XFS"

#~ msgid "Linux JFS"
#~ msgstr "Linux JFS"

#~ msgid "Linux ReiserFS"
#~ msgstr "Linux ReiserFS"

#~ msgid "OS/2 HPFS"
#~ msgstr "OS/2 HPFS"

#~ msgid "OS/2 IFS"
#~ msgstr "OS/2 IFS"

#~ msgid "NTFS"
#~ msgstr "NTFS"

#~ msgid "mount: no medium found on %s ...trying again\n"
#~ msgstr "mount: v %s nenalezeno žádné médium… zkouším znovu\n"

#~ msgid "usage : %s -asmq -tclup \n"
#~ msgstr "Použití: %s -asmq -tclup \n"

#~ msgid "\t%s [-s -m -q] -i id\n"
#~ msgstr "\t%s [-s -m -q] -i id\n"

#~ msgid "\t%s -h for help.\n"
#~ msgstr "\t%s -h pro nápovědu.\n"

#~ msgid ""
#~ "Resource Specification:\n"
#~ "\t-m : shared_mem\n"
#~ "\t-q : messages\n"
#~ msgstr ""
#~ "Zadání prostředku:\n"
#~ "\t-m : sdílená paměť\n"
#~ "\t-q : zprávy\n"

#~ msgid ""
#~ "\t-s : semaphores\n"
#~ "\t-a : all (default)\n"
#~ msgstr ""
#~ "\t-s : semafory\n"
#~ "\t-a : vše (implicitní)\n"

#~ msgid ""
#~ "Output Format:\n"
#~ "\t-t : time\n"
#~ "\t-p : pid\n"
#~ "\t-c : creator\n"
#~ msgstr ""
#~ "Výstupní formát:\n"
#~ "\t-t : čas\n"
#~ "\t-p : pid\n"
#~ "\t-c : tvůrce\n"

#~ msgid ""
#~ "\t-l : limits\n"
#~ "\t-u : summary\n"
#~ msgstr ""
#~ "\t-l : omezení\n"
#~ "\t-u : shrnutí\n"

#~ msgid "error parse: %s"
#~ msgstr "chyba při rozebírání: %s"

#~ msgid "error: /sys filesystem is not accessable."
#~ msgstr "chyba: souborový systém /sys není přístupný."

#~ msgid "usage: rdev [ -rv ] [ -o OFFSET ] [ IMAGE [ VALUE [ OFFSET ] ] ]"
#~ msgstr "Použití: rdev [ -rv ] [ -o POSUN ] [ OBRAZ [ HODNOTA [ POSUN ] ] ]"

#~ msgid "  rdev /dev/fd0  (or rdev /linux, etc.) displays the current ROOT device"
#~ msgstr "  rdev /dev/fd0  (či rdev /linux, etc.) vypíše aktuální ROOT zařízení"

#~ msgid "  rdev /dev/fd0 /dev/hda2         sets ROOT to /dev/hda2"
#~ msgstr "  rdev /dev/fd0 /dev/hda2         nastaví ROOT na /dev/hda2"

#~ msgid "  rdev -R /dev/fd0 1              set the ROOTFLAGS (readonly status)"
#~ msgstr "  rdev -R /dev/fd0 1              nastaví PŘÍZNAKY ROOT (pouze pro čtení)"

#~ msgid "  rdev -r /dev/fd0 627            set the RAMDISK size"
#~ msgstr "  rdev -r /dev/fd0 627            nastaví velikost RAMDISKU"

#~ msgid "  rdev -v /dev/fd0 1              set the bootup VIDEOMODE"
#~ msgstr "  rdev -v /dev/fd0 1              nastaví startovací VIDEOMÓD"

#~ msgid "  rootflags ...                   same as rdev -R"
#~ msgstr "  root příznaky ...               stejné jako rdev -R"

#~ msgid "  ramsize ...                     same as rdev -r"
#~ msgstr "  velikost ram ...                stejné jako rdev -r"

#~ msgid "  vidmode ...                     same as rdev -v"
#~ msgstr "  vidmód ...                      stejné jako rdev -v"

#~ msgid "Note: video modes are: -3=Ask, -2=Extended, -1=NormalVga, 1=key1, 2=key2,..."
#~ msgstr "Poznámka: video módy: -3=Ask, -2=Extended, -1=NormalVga, 1=kláv1, 2=kláv2,..."

#~ msgid "      use -R 1 to mount root readonly, -R 0 for read/write."
#~ msgstr "          Pomocí -R 1 připojíte pouze pro čtení, -R 0 umožní zápis."

#~ msgid "missing comma"
#~ msgstr "chybí čárka"

#~ msgid ""
#~ "Usage: fdisk [-b SSZ] [-u] DISK     Change partition table\n"
#~ "       fdisk -l [-b SSZ] [-u] DISK  List partition table(s)\n"
#~ "       fdisk -s PARTITION           Give partition size(s) in blocks\n"
#~ "       fdisk -v                     Give fdisk version\n"
#~ "Here DISK is something like /dev/hdb or /dev/sda\n"
#~ "and PARTITION is something like /dev/hda7\n"
#~ "-u: give Start and End in sector (instead of cylinder) units\n"
#~ "-b 2048: (for certain MO disks) use 2048-byte sectors\n"
#~ msgstr ""
#~ "Použití: fdisk [-b SSZ] [-u] DISK     Změní tabulku rozdělení disku\n"
#~ "         fdisk -l [-b SSZ] [-u] DISK  Vypíše tabulku rozdělení disku\n"
#~ "         fdisk -s ODDÍL               Vypíše velikost oddílu\n"
#~ "                                      v blocích\n"
#~ "         fdisk -v                     Vypíše informace o verzi\n"
#~ "DISK je něco jako /dev/hdb či /dev/sda a ODDÍL je něco jako /dev/hda7\n"
#~ "-u: vrací Začátek a Konec v sektorech (místo cylindrech)\n"
#~ "-b 2048: (pro některé MO jednotky) použije 2048bajtové sektory\n"

#~ msgid ""
#~ "Usage: fdisk [-l] [-b SSZ] [-u] device\n"
#~ "E.g.: fdisk /dev/hda  (for the first IDE disk)\n"
#~ "  or: fdisk /dev/sdc  (for the third SCSI disk)\n"
#~ "  or: fdisk /dev/eda  (for the first PS/2 ESDI drive)\n"
#~ "  or: fdisk /dev/rd/c0d0  or: fdisk /dev/ida/c0d0  (for RAID devices)\n"
#~ "  ...\n"
#~ msgstr ""
#~ "Použití: fdisk [-l] [-b SSZ] [-u] zařízení\n"
#~ "Např: fdisk /dev/hda  (pro první IDE disk)\n"
#~ "  či: fdisk /dev/sdc  (pro třetí SCSI disk)\n"
#~ "  či: fdisk /dev/eda  (pro první PS/2 ESDI disk)\n"
#~ "  či: fdisk /dev/rd/c0d0  či: fdisk /dev/ida/c0d0  (pro RAID zařízení)\n"
#~ "  …\n"

#~ msgid ""
#~ "\n"
#~ "The number of cylinders for this disk is set to %d.\n"
#~ "There is nothing wrong with that, but this is larger than 1024,\n"
#~ "and could in certain setups cause problems with:\n"
#~ "1) software that runs at boot time (e.g., old versions of LILO)\n"
#~ "2) booting and partitioning software from other OSs\n"
#~ "   (e.g., DOS FDISK, OS/2 FDISK)\n"
#~ msgstr ""
#~ "\n"
#~ "Počet cylindrů tohoto disku je nastaven na %d.\n"
#~ "Na tom není nic špatného, ale jelikož je to více než 1024,\n"
#~ "může za určitých okolností dojít k problémům:\n"
#~ "1) s programy spouštěnými při startu (např. staré verze LILA)\n"
#~ "2) s programy pro správu diskových oddílů z jiných OS\n"
#~ "   (např. DOS FDISK, OS/2 FDISK)\n"

#~ msgid ""
#~ "WARNING: The device does not provide compensation (alignment_offset)\n"
#~ "for DOS-compatible partitioning, but DOS-compatible mode is enabled.\n"
#~ "Use command 'c' to switch-off DOS mode.\n"
#~ "\n"
#~ msgstr ""
#~ "POZOR: Zařízení neposkytuje vyrovnání (alignment_offset) při dělení disku\n"
#~ "podle DOSu, avšak režim kompatibility s DOSem je zapnut.\n"
#~ "Použijte příkaz „c“ na vypnutí režimu DOSu.\n"

#~ msgid ""
#~ "\n"
#~ "WARNING: the device provides alignment_offset, but the offset does not\n"
#~ "match with device geometry.\n"
#~ "\n"
#~ msgstr ""
#~ "\n"
#~ "POZOR: Zařízení poskytuje alignment_offset (zarovnávací posun), ale posun\n"
#~ "neodpovídá geometrii zařízení.\n"
#~ "\n"

#~ msgid "# partition table of %s\n"
#~ msgstr "# tabulka rozdělení disku pro %s\n"

#~ msgid ""
#~ "unit: sectors\n"
#~ "\n"
#~ msgstr ""
#~ "jednotka: sektory\n"
#~ "\n"

#~ msgid " start=%9lu"
#~ msgstr " začátek=%9lu"

#~ msgid ", bootable"
#~ msgstr ", startovací"

#~ msgid "Clock in UTC, not changed.\n"
#~ msgstr "Hodiny v UTC, nezměněno.\n"

#~ msgid "%s: error: label only with v1 swap area\n"
#~ msgstr "%s: chyba: jmenovku lze použít pouze u verze 1\n"

#~ msgid "fatal: first page unreadable"
#~ msgstr "nepřekonatelná chyba: první stránka je nečitelná"

#~ msgid ""
#~ "%s: Device '%s' contains a valid Sun disklabel.\n"
#~ "This probably means creating v0 swap would destroy your partition table.\n"
#~ "No swap was created. If you really want to create v0 swap on that device,\n"
#~ "use the -f option to force it.\n"
#~ msgstr ""
#~ "%s: Zařízení „%s“ obsahuje korektní Sun popis disku.\n"
#~ "To znamená, že vytvoření odkládacího prostoru v0 by pravděpodobně zničilo\n"
#~ "tabulku rozdělení disku. Odkládací prostor nebyl vytvořen. Pokud opravdu\n"
#~ "chcete na tomto zařízení vytvořit odkládací prostor v0, vynuťte si to\n"
#~ "přepínačem -f.\n"

#~ msgid "namei: could not chdir to root!\n"
#~ msgstr "namei: do adresáře root nelze přejít!\n"

#~ msgid "namei: could not stat root!\n"
#~ msgstr "namei: volání stat pro adresář root selhalo!\n"

#~ msgid " ? could not chdir into %s - %s (%d)\n"
#~ msgstr " ? do adresáře %s nelze přejít - %s (%d)\n"

#~ msgid " ? problems reading symlink %s - %s (%d)\n"
#~ msgstr " ? problémy při čtení symbolického odkazu %s - %s (%d)\n"

#~ msgid "  *** EXCEEDED UNIX LIMIT OF SYMLINKS ***\n"
#~ msgstr "  *** PŘEKROČEN UNIXOVÝ LIMIT PRO SYMBOLICKÉ ODKAZY ***\n"

#~ msgid "namei: unknown file type 0%06o on file %s\n"
#~ msgstr "namei: typ 0%06o souboru %s je neznámý\n"

#~ msgid "mount: going to mount %s by %s\n"
#~ msgstr "mount: chystám se připojit %s podle %s\n"

#~ msgid "mount: no LABEL=, no UUID=, going to mount %s by path\n"
#~ msgstr "mount: žádný LABEL=, žádný UUID=, chystám se připojit %s podle cesty\n"

#~ msgid "%s: waitpid: %s\n"
#~ msgstr "%s: waitpid: %s\n"

#~ msgid "could not umount %s - trying %s instead\n"
#~ msgstr "%s nelze odpojit - zkouším %s\n"

#~ msgid "%-10s %-10s %-10s %-10s %-10s %-10s\n"
#~ msgstr "%-10s %-10s %-10s %-10s %-10s %-10s\n"

#~ msgid "%-10s %-10s %-20s %-20s %-20s\n"
#~ msgstr "%-10s %-10s %-20s %-20s %-20s\n"

#~ msgid "%-10s %-10s %-10s %-10s\n"
#~ msgstr "%-10s %-10s %-10s %-10s\n"

#~ msgid "%-10s %-10s %-10s %-10s %-10s %-10s %-12s\n"
#~ msgstr "%-10s %-10s %-10s %-10s %-10s %-10s %-12s\n"

#~ msgid "%-8s %-10s %-26.24s %-26.24s\n"
#~ msgstr "%-8s %-10s %-26.24s %-26.24s\n"

#~ msgid "%-10s %-10s %-10s %-10s %-10s\n"
#~ msgstr "%-10s %-10s %-10s %-10s %-10s\n"

#~ msgid "%-8s %-10s %-20s %-20s %-20s\n"
#~ msgstr "%-8s %-10s %-20s %-20s %-20s\n"

#~ msgid "%-10s %-10s %-10s %-10s %-12s %-12s\n"
#~ msgstr "%-10s %-10s %-10s %-10s %-12s %-12s\n"

#~ msgid "calling open_tty\n"
#~ msgstr "volám open_tty\n"

#~ msgid "calling termio_init\n"
#~ msgstr "volám termio_init\n"

#~ msgid "writing init string\n"
#~ msgstr "zapisuji inicializační řetězec\n"

#~ msgid "before autobaud\n"
#~ msgstr "před autobaud\n"

#~ msgid "waiting for cr-lf\n"
#~ msgstr "čekám na cr-lf\n"

#~ msgid "reading login name\n"
#~ msgstr "čtu přihlašovací jméno\n"

#~ msgid "after getopt loop\n"
#~ msgstr "po zpracování argumentů příkazové řádky\n"

#~ msgid "exiting parseargs\n"
#~ msgstr "opouštím funkci parseargs\n"

#~ msgid "entered parse_speeds\n"
#~ msgstr "vstupuji do funkce parse_speeds\n"

#~ msgid "exiting parsespeeds\n"
#~ msgstr "opouštím funkci parsespeeds\n"

#~ msgid "open(2)\n"
#~ msgstr "open(2)\n"

#~ msgid "duping\n"
#~ msgstr "volám dup\n"

#~ msgid "term_io 2\n"
#~ msgstr "term_io 2\n"

#~ msgid "chfn: PAM Failure, aborting: %s\n"
#~ msgstr "chfn: chyba PAM, končím: %s\n"

#~ msgid "Warning: \"%s\" is not listed in /etc/shells\n"
#~ msgstr "Varování: „%s“ není v /etc/shells\n"

#~ msgid "Can't read %s, exiting."
#~ msgstr "%s nelze číst, končím."

#~ msgid "login: PAM Failure, aborting: %s\n"
#~ msgstr "login: chyba PAM, končím: %s\n"

#~ msgid "timeout = %d, quiet = %d, reboot = %d\n"
#~ msgstr "časový limit = %d, klid = %d, restart = %d\n"

#~ msgid "couldn't read %s, and cannot ioctl dump\n"
#~ msgstr "nelze číst %s a nelze provést dump pomocí volání ioctl\n"

#~ msgid ", offset %lld"
#~ msgstr ", odsazení %'lld"

#~ msgid "%s: could not find any device /dev/loop#"
#~ msgstr "%s: žádné zařízení /dev/loop# nelze nalézt"

#~ msgid "mount: backgrounding \"%s\"\n"
#~ msgstr "mount: pracuji na pozadí „%s“\n"

#~ msgid "mount: giving up \"%s\"\n"
#~ msgstr "mount: končím „%s“\n"

#~ msgid ""
#~ "usage: %s [-hV]\n"
#~ "       %s -a [-e] [-v]\n"
#~ "       %s [-v] [-p priority] special|LABEL=volume_name ...\n"
#~ "       %s [-s]\n"
#~ msgstr ""
#~ "Použití: %s [-hV]\n"
#~ "         %s -a [-e] [-v]\n"
#~ "         %s [-v] [-p PRIORITA] ZVLÁŠTNÍ_SOUBOR|LABEL=NÁZEV_SVAZKU…\n"
#~ "         %s [-s]\n"

#~ msgid ""
#~ "usage: %s [-hV]\n"
#~ "       %s -a [-v]\n"
#~ "       %s [-v] special ...\n"
#~ msgstr ""
#~ "Použití: %s [-hV]\n"
#~ "         %s -a [-v]\n"
#~ "         %s [-v] ZVLÁŠTNÍ_SOUBOR…\n"

#~ msgid "%s: cannot canonicalize %s: %s\n"
#~ msgstr "%s: %s nelze převést na kanonický tvar: %s\n"

#~ msgid "usage: renice priority [ [ -p ] pids ] [ [ -g ] pgrps ] [ [ -u ] users ]\n"
#~ msgstr "Použití: renice priorita [ [ -p ] pid ] [[ -g ] pgrp ] [ [ -u ] uživatel ]\n"

#~ msgid "\t-%c\tEnable %s\n"
#~ msgstr "\t-%c\tPovolí %s\n"

#~ msgid "`%s': bad directory: '.' isn't first\n"
#~ msgstr "„%s“: chybný adresář: „.“ není první\n"

#~ msgid "`%s': bad directory: '..' isn't second\n"
#~ msgstr "„%s“: chybný adresář: „..“ není druhý\n"

#~ msgid "Exceeded MAXENTRIES.  Raise this value in mkcramfs.c and recompile.  Exiting.\n"
#~ msgstr ""
#~ "Překročeno MAXENTRIES. Zvětšete tuto hodnotu v mkcramfs.c a znovu přeložte.\n"
#~ "Končím.\n"

#~ msgid "Assuming pages of size %d (not %d)\n"
#~ msgstr "Předpokládám velikost stránek %d (nikoliv %d)\n"

#~ msgid "Autoconfigure found a %s%s%s\n"
#~ msgstr "Automatická konfigurace nalezla %s%s%s\n"

#~ msgid ""
#~ "Drive type\n"
#~ "   ?   auto configure\n"
#~ "   0   custom (with hardware detected defaults)"
#~ msgstr ""
#~ "Typ disku\n"
#~ "   ?   automatická konfigurace\n"
#~ "   0   uživatelská konfigurace (s detekovaným implicitním nastavením)"

#~ msgid "Select type (? for auto, 0 for custom): "
#~ msgstr "Zadejte typ (? pro auto, 0 pro uživatelský): "

#~ msgid "You may change all the disk params from the x menu"
#~ msgstr "Všechny parametry disku můžete změnit z nabídky x"

#~ msgid "3,5\" floppy"
#~ msgstr "3,5\" pružný disk"

#~ msgid "%s from util-linux-%s\n"
#~ msgstr "%s z util-linux-%s\n"

#~ msgid "%s: error: the label %s occurs on both %s and %s\n"
#~ msgstr "%s: chyba: jmenovka %s se nachází jak na %s tak i na %s\n"

#~ msgid "%s: could not open %s, so UUID and LABEL conversion cannot be done.\n"
#~ msgstr "%s: nelze otevřít %s, takže konverze UUID a JMENOVEK nebude provedena.\n"

#~ msgid "%s: bad UUID"
#~ msgstr "%s: chybné UUID"

#~ msgid "mount: failed with nfs mount version 4, trying 3..\n"
#~ msgstr "mount: chyba s připojováním NFS verze 4, zkouším verzi 3…\n"

#~ msgid "mount: mounting %s\n"
#~ msgstr "mount: připojuji %s\n"

#~ msgid "mount: error while guessing filesystem type\n"
#~ msgstr "mount: během hádání typu systému souborů došlo k chybě\n"

#~ msgid "mount: excessively long host:dir argument\n"
#~ msgstr "mount: příliš dlouhý argument pro počítač:adresář\n"

#~ msgid "mount: warning: multiple hostnames not supported\n"
#~ msgstr "mount: varování: vícenásobné názvy počítačů nejsou podporovány\n"

#~ msgid "mount: directory to mount not in host:dir format\n"
#~ msgstr "mount: adresář pro připojení není ve tvaru počítač:adresář\n"

#~ msgid "mount: got bad hp->h_length\n"
#~ msgstr "mount: špatné hp->h_length\n"

#~ msgid "mount: excessively long option argument\n"
#~ msgstr "mount: příliš dlouhý argument pro volbu\n"

#~ msgid "Warning: Unrecognized proto= option.\n"
#~ msgstr "Varování: neznámá volba pro proto=.\n"

#~ msgid "Warning: Option namlen is not supported.\n"
#~ msgstr "Varování: volba namlen není podporována.\n"

#~ msgid "unknown nfs mount parameter: %s=%d\n"
#~ msgstr "parametr %s=%d pro připojení nfs není znám\n"

#~ msgid "unknown nfs mount option: %s%s\n"
#~ msgstr "volba %s%s pro připojení nfs je neznámá\n"

#~ msgid "mount: got bad hp->h_length?\n"
#~ msgstr "mount: špatné hp->h_length?\n"

#~ msgid "nfs bindresvport"
#~ msgstr "nfs bindresvport"

#~ msgid "nfs server reported service unavailable"
#~ msgstr "tato služba je na tomto nfs serveru nedostupná"

#~ msgid "used portmapper to find NFS port\n"
#~ msgstr "pro nalezení NFS portu jsem použil portmapper\n"

#~ msgid "using port %d for nfs deamon\n"
#~ msgstr "používám port %d pro nfs server\n"

#~ msgid "unknown nfs status return value: %d"
#~ msgstr "návratová hodnota nfs status %d je neznámá"

#~ msgid "host: %s, directory: %s\n"
#~ msgstr "počítač: %s, adresář: %s\n"

#~ msgid "umount: can't get address for %s\n"
#~ msgstr "umount: adresu %s nelze zjistit\n"

#~ msgid "umount: got bad hostp->h_length\n"
#~ msgstr "umount: chybná hodnota hostp->h_length\n"

#~ msgid "unable to open %s"
#~ msgstr "%s nelze otevřít"

#~ msgid "Loop device is %s\n"
#~ msgstr "Loop zařízení je %s\n"

#~ msgid "open of directory failed\n"
#~ msgstr "adresář nelze otevřít\n"

#~ msgid "Too small partition size specified."
#~ msgstr "Zadána příliš malá velikost oddílu."

#~ msgid "faild to allocate iterator"
#~ msgstr "alokace iterátoru selhala"

#~ msgid "cannot open: %s"
#~ msgstr "nelze otevřít: %s"

#~ msgid ""
#~ "   <start>  begin of the partition in sectors. The default is the first\n"
#~ "            free space.\n"
#~ msgstr "   <začátek>      začátek oddílu v sektorech. Výchozí je první volné místo.\n"

#~ msgid "     --rfc5424[=<notime,notq,nohost>]\n"
#~ msgstr "     --rfc5424[=<notime,notq,nohost>]\n"

#~ msgid ""
#~ "\n"
#~ "Sets or gets the IO scheduling class and priority of processes.\n"
#~ msgstr ""
#~ "\n"
#~ "Nastaví nebo zjistí plánovací I/O třídu a prioritu procesu.\n"

#~ msgid "Warning: partition %s is not contained in partition %s"
#~ msgstr "Pozor: oddíl %s není obsažen v oddílu %s"

#~ msgid "Type of the partition %zu is unchanged."
#~ msgstr "Druh oddílu %zu je nezměněn."