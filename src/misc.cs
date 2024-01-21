﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Overlay.src {
    public static class Misc {

        public static void GetProcess( string windowTitle, out Process proc ) =>
            proc = Process.GetProcessesByName( windowTitle ).First( );
        public static void GetProcess( int pID, out Process proc ) =>
            proc = Process.GetProcessById( pID );

        public static double Lerp( double start, double end, double t ) =>
            start + Math.Max( 0, Math.Min( 1, t ) ) * ( end - start );
    }

    public static class Imports {

        [DllImport( "Gdi32.dll", EntryPoint = "CreateRoundRectRgn" )]
        public static extern IntPtr CreateRoundRectRgn( int L, int T, int R, int B, int W, int H );

        [DllImport( "user32.dll" )]
        public static extern short GetAsyncKeyState( Keys vKey );

        [DllImport( "user32.dll", SetLastError = true )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool SetWindowLong( IntPtr hWnd, int nIndex, uint dwNewLong );

        [DllImport( "user32.dll", SetLastError = true )]
        public static extern uint GetWindowLong( IntPtr hWnd, int nIndex );

        [DllImport( "user32.dll", SetLastError = true )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool GetWindowRect( IntPtr hWnd, out RECT lpRect );

        [DllImport( "user32.dll", SetLastError = true )]
        static extern bool SetLayeredWindowAttributes( IntPtr hWnd, uint crKey, byte bAlpha, uint dwFlags );

        [StructLayout( LayoutKind.Sequential )]
        public struct RECT {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
    }

    public struct WindowProperties {

        public bool open { get; set; } = true;
        public double currentFade { get; set; } = 1.0;
        public overlayWindow? runningWindow { get; set; } = null!;
        
        public WindowProperties() {

            open = true;
            currentFade = 1.0;
            runningWindow = null!;
        }
    }
}
