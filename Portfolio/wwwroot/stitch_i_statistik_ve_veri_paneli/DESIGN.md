---
name: Executive Precision
colors:
  surface: '#f7f9fb'
  surface-dim: '#d8dadc'
  surface-bright: '#f7f9fb'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f2f4f6'
  surface-container: '#eceef0'
  surface-container-high: '#e6e8ea'
  surface-container-highest: '#e0e3e5'
  on-surface: '#191c1e'
  on-surface-variant: '#434655'
  inverse-surface: '#2d3133'
  inverse-on-surface: '#eff1f3'
  outline: '#737686'
  outline-variant: '#c3c6d7'
  surface-tint: '#0053db'
  primary: '#004ac6'
  on-primary: '#ffffff'
  primary-container: '#2563eb'
  on-primary-container: '#eeefff'
  inverse-primary: '#b4c5ff'
  secondary: '#505f76'
  on-secondary: '#ffffff'
  secondary-container: '#d0e1fb'
  on-secondary-container: '#54647a'
  tertiary: '#943700'
  on-tertiary: '#ffffff'
  tertiary-container: '#bc4800'
  on-tertiary-container: '#ffede6'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#dbe1ff'
  primary-fixed-dim: '#b4c5ff'
  on-primary-fixed: '#00174b'
  on-primary-fixed-variant: '#003ea8'
  secondary-fixed: '#d3e4fe'
  secondary-fixed-dim: '#b7c8e1'
  on-secondary-fixed: '#0b1c30'
  on-secondary-fixed-variant: '#38485d'
  tertiary-fixed: '#ffdbcd'
  tertiary-fixed-dim: '#ffb596'
  on-tertiary-fixed: '#360f00'
  on-tertiary-fixed-variant: '#7d2d00'
  background: '#f7f9fb'
  on-background: '#191c1e'
  surface-variant: '#e0e3e5'
typography:
  display-sm:
    fontFamily: Inter
    fontSize: 30px
    fontWeight: '700'
    lineHeight: 38px
    letterSpacing: -0.02em
  headline-lg:
    fontFamily: Inter
    fontSize: 24px
    fontWeight: '600'
    lineHeight: 32px
    letterSpacing: -0.01em
  headline-md:
    fontFamily: Inter
    fontSize: 20px
    fontWeight: '600'
    lineHeight: 28px
  title-lg:
    fontFamily: Inter
    fontSize: 18px
    fontWeight: '600'
    lineHeight: 26px
  body-lg:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '400'
    lineHeight: 24px
  body-md:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '400'
    lineHeight: 20px
  label-md:
    fontFamily: Inter
    fontSize: 12px
    fontWeight: '500'
    lineHeight: 16px
    letterSpacing: 0.02em
  label-sm:
    fontFamily: Inter
    fontSize: 11px
    fontWeight: '600'
    lineHeight: 14px
rounded:
  sm: 0.125rem
  DEFAULT: 0.25rem
  md: 0.375rem
  lg: 0.5rem
  xl: 0.75rem
  full: 9999px
spacing:
  base: 4px
  xs: 4px
  sm: 8px
  md: 16px
  lg: 24px
  xl: 32px
  sidebar_width: 260px
  container_max_width: 1440px
---

## Brand & Style
The design system is engineered for high-density data environments where clarity, speed of cognition, and professional trust are paramount. It follows a **Corporate / Modern** aesthetic, prioritizing a systematic arrangement of information over decorative flair. 

The target audience consists of analysts, managers, and stakeholders who require an organized, "no-noise" interface to make data-driven decisions. The emotional response is one of calm control and reliability. The visual language is defined by structured grids, purposeful whitespace, and a restrained use of color to highlight actionable insights.

## Colors
This design system utilizes a "Cool Professional" palette. 
- **Primary (Indigo-Blue):** Used exclusively for primary actions, active states, and critical data points. 
- **Neutral Scale:** A rigorous range of slate grays is used to establish hierarchy. The background is a very light tint (`#F8FAFC`) to differentiate from white surface containers (`#FFFFFF`).
- **Semantic Colors:** Success (Emerald), Warning (Amber), and Error (Rose) should be used with low saturation for badges and high saturation for icons to ensure accessibility without overwhelming the dashboard.

## Typography
The system relies on **Inter**, a typeface designed for screens, utilizing its variable weights to create clear information density. 
- **Headlines:** Use Semi-Bold (`600`) for section titles to anchor the user's eye.
- **Body:** Standardized at `14px` (`body-md`) for most dashboard content to maximize data visibility while maintaining readability.
- **Data Labels:** Small caps or uppercase labels (`label-sm`) are used for table headers and chart legends to provide a distinct stylistic break from dynamic data.

## Layout & Spacing
The layout employs a **Fixed Sidebar + Fluid Content** model. 
- **Sidebar:** A constant `260px` vertical navigation provides a persistent anchor.
- **Grid:** A 12-column fluid grid system is used within the main content area, with a `24px` gutter (`spacing.lg`).
- **Margins:** A global page margin of `32px` on desktop ensures the content doesn't feel cramped against the screen edges.
- **Responsive:** On tablet, the sidebar collapses to an icon-only rail (`72px`). On mobile, the sidebar becomes a hidden drawer, and page margins reduce to `16px`.

## Elevation & Depth
This design system uses **Tonal Layers** and **Low-Contrast Outlines** rather than heavy shadows to maintain a clean, professional look.
- **Level 0 (Background):** Slate-50 (`#F8FAFC`) acts as the canvas.
- **Level 1 (Cards/Surface):** White surfaces with a `1px` solid border in Slate-200 (`#E2E8F0`). 
- **Level 2 (Dropdowns/Modals):** These use a soft ambient shadow (Blur: 12px, Y: 4px, Color: `rgba(15, 23, 42, 0.08)`) to lift them above the content.
- **Interactive States:** Hovering over a card should not increase shadow, but rather subtly darken the border color to the primary brand color at `20%` opacity.

## Shapes
The shape language is **Soft** and precise. 
- **Buttons and Inputs:** Use a `4px` (0.25rem) radius to feel modern but structured.
- **Statistic Cards:** Use a `8px` (0.5rem) radius (`rounded-lg`) to distinguish large layout blocks from smaller UI components.
- **Avatars:** Strictly circular to provide a geometric counterpoint to the otherwise rectangular grid.

## Components
- **Statistic Cards:** Features a `24px` icon in a colored circle (10% opacity of the primary/semantic color), a `label-sm` title, and a `display-sm` value. A small "trend" indicator (up/down arrow) should be positioned in the bottom right.
- **Data Tables:** Headers use `label-sm` with a light gray background (`#F1F5F9`). Rows have a height of `52px` with a subtle bottom border. High-priority cells (e.g., Status) use a "Pill" style badge with low-contrast background colors.
- **Sidebar Navigation:** Vertical list of items. Active state uses a `2px` vertical indigo line on the left edge and a subtle blue tint for the background.
- **Buttons:** Primary buttons are solid Indigo with white text. Secondary buttons are ghost-style with a Slate-200 border. No gradients or heavy rounding.
- **Input Fields:** Use a white background, Slate-300 border, and `14px` text. The focus state is a `2px` indigo ring with `20%` opacity.