""" GDB Python customization auto-loader for js shell """

import os.path
sys.path[0:0] = [os.path.join('c:/builds/moz2_slave/rel-m-rel-34.1-xr_w32_bld-0000/build/js/src', 'gdb')]

import mozilla.autoload
mozilla.autoload.register(gdb.current_objfile())
