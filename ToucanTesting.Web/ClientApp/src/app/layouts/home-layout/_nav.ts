interface NavAttributes {
    [propName: string]: any;
}
interface NavWrapper {
    attributes: NavAttributes;
    element: string;
}
interface NavBadge {
    text: string;
    variant: string;
}
interface NavLabel {
    class?: string;
    variant: string;
}

export interface NavData {
    name?: string;
    url?: string;
    icon?: string;
    badge?: NavBadge;
    title?: boolean;
    children?: NavData[];
    variant?: string;
    attributes?: NavAttributes;
    divider?: boolean;
    class?: string;
    label?: NavLabel;
    wrapper?: NavWrapper;
}

export const navItems: NavData[] = [
    {
        name: 'Dashboard',
        url: '/dashboard',
        icon: 'icon-speedometer'
    },
    {
        name: 'Records',
        url: '/records',
        icon: 'cui-file',
        children: [
            {
                name: 'Document Query',
                url: '/records/documentquery',
                icon: 'fa fa-file-text'
            },
            {
                name: 'Request Records',
                url: '/records/request',
                icon: 'fa fa-external-link'
            }
        ]
    },
    {
        name: 'My Intake',
        url: '/intake',
        icon: 'fa fa-download'
    },
    {
        name: 'Release',
        url: '/release',
        icon: 'fa fa-upload'
    },
    {
        name: 'Find Provider',
        url: '/provider',
        icon: 'icon-magnifier'
    },
];
