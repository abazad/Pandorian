Imports System.Collections.Generic
Imports System.Text
Imports Pandorian.Engine.Encryption
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Namespace Data
	Public Class PandoraSong
		Inherits PandoraData
		Public Class AudioUrlInfo
			<JsonProperty(PropertyName := "bitrate")> _
			Public Property Bitrate() As String
				Get
					Return m_Bitrate
				End Get
				Friend Set
					m_Bitrate = Value
				End Set
			End Property
			Private m_Bitrate As String

			<JsonProperty(PropertyName := "encoding")> _
			Public Property Encoding() As String
				Get
					Return m_Encoding
				End Get
				Friend Set
					m_Encoding = Value
				End Set
			End Property
			Private m_Encoding As String

			<JsonProperty(PropertyName := "audioUrl")> _
			Public Property Url() As String
				Get
					Return m_Url
				End Get
				Friend Set
					m_Url = Value
				End Set
			End Property
			Private m_Url As String

			<JsonProperty(PropertyName := "protocol")> _
			Public Property Protocol() As String
				Get
					Return m_Protocol
				End Get
				Set
					m_Protocol = Value
				End Set
			End Property
			Private m_Protocol As String
		End Class

		Public Property IsAdvertisement() As Boolean
			Get
				Return m_IsAdvertisement
			End Get
			Friend Set
				m_IsAdvertisement = Value
			End Set
		End Property
		Private m_IsAdvertisement As Boolean

		<JsonProperty(PropertyName := "trackToken")> _
		Public Property Token() As String
			Get
				Return m_Token
			End Get
			Friend Set
				m_Token = Value
			End Set
		End Property
		Private m_Token As String


		<JsonProperty(PropertyName := "artistName")> _
		Public Property Artist() As String
			Get
				Return m_Artist
			End Get
			Friend Set
				m_Artist = Value
			End Set
		End Property
		Private m_Artist As String

		<JsonProperty(PropertyName := "albumName")> _
		Public Property Album() As String
			Get
				Return m_Album
			End Get
			Friend Set
				m_Album = Value
			End Set
		End Property
		Private m_Album As String

		<JsonProperty(PropertyName := "songName")> _
		Public Property Title() As String
			Get
				Return m_Title
			End Get
			Friend Set
				m_Title = Value
			End Set
		End Property
		Private m_Title As String

		Public ReadOnly Property AudioInfo() As AudioUrlInfo
			Get
				If AudioUrlMap Is Nothing OrElse AudioUrlMap.Count = 0 Then
					Return Nothing
				End If

				If AudioUrlMap.ContainsKey("highQuality") Then
					Return AudioUrlMap("highQuality")
				End If
				If AudioUrlMap.ContainsKey("mediumQuality") Then
					Return AudioUrlMap("mediumQuality")
				End If
				If AudioUrlMap.ContainsKey("lowQuality") Then
					Return AudioUrlMap("lowQuality")
				End If

				Return Nothing
			End Get
		End Property

		Public ReadOnly Property AudioURL() As String
			Get
				If AudioInfo Is Nothing Then
					Return Nothing
				End If
				Return AudioInfo.Url.Trim()
			End Get
		End Property

		<JsonProperty(PropertyName := "audioUrlMap")> _
		Public Property AudioUrlMap() As Dictionary(Of String, AudioUrlInfo)
			Get
				Return m_AudioUrlMap
			End Get
			Friend Set
				m_AudioUrlMap = Value
			End Set
		End Property
		Private m_AudioUrlMap As Dictionary(Of String, AudioUrlInfo)

		<JsonProperty(PropertyName := "albumArtUrl")> _
		Public Property AlbumArtLargeURL() As String
			Get
				Return m_AlbumArtLargeURL
			End Get
			Friend Set
				m_AlbumArtLargeURL = Value
			End Set
		End Property
		Private m_AlbumArtLargeURL As String

		<JsonProperty(PropertyName := "albumDetailUrl")> _
		Public Property AlbumDetailsURL() As String
			Get
				Return m_AlbumDetailsURL
			End Get
			Friend Set
				m_AlbumDetailsURL = Value
			End Set
		End Property
		Private m_AlbumDetailsURL As String

		<JsonProperty(PropertyName := "songRating")> _
		Private Property NumericRating() As Integer
			Get
				Select Case Rating
					Case PandoraRating.Love
						Return 1
					Case PandoraRating.Unrated
						Return 0
					Case PandoraRating.Hate
						Return -1
					Case Else
						Return 0
				End Select
			End Get
			Set
				If value = 1 Then
					Rating = PandoraRating.Love
				Else
					Rating = PandoraRating.Unrated
				End If
			End Set
		End Property

		Public Property Rating() As PandoraRating
			Get
				Return m_Rating
			End Get
			Friend Set
				m_Rating = Value
			End Set
		End Property
		Private m_Rating As PandoraRating

		<JsonProperty(PropertyName := "trackGain")> _
		Private Property TrackGainStr() As String
			Get
				Return m_TrackGainStr
			End Get
			Set
				m_TrackGainStr = Value
			End Set
		End Property
		Private m_TrackGainStr As String

		Public ReadOnly Property TrackGain() As Single
			Get
				Dim rtn As Single = 0
				Single.TryParse(TrackGainStr, rtn)
				Return rtn
			End Get
		End Property

		Public Property TemporarilyBanned() As Boolean
			Get
				Return m_TemporarilyBanned
			End Get
			Friend Set
				m_TemporarilyBanned = Value
			End Set
		End Property
		Private m_TemporarilyBanned As Boolean

        Public Property PlayingStartTime() As Date
            Get
                Return _playStartTime
            End Get
            Set(value As Date)
                If _playStartTime = Date.MinValue Then ' only set play start time if it hasn't been set before
                    _playStartTime = value
                End If
            End Set
        End Property
        Private _playStartTime As Date

        Public Property AudioDurationSecs() As Double
            Get
                Return _audioDuration
            End Get
            Set(value As Double)
                _audioDuration = value
            End Set
        End Property
        Private _audioDuration As Double = 0

        Public ReadOnly Property DurationElapsed As Boolean
            Get
                If PlayingStartTime.AddSeconds(AudioDurationSecs) < Now Then
                    Return True
                Else
                    Return False
                End If
            End Get
        End Property


    End Class
End Namespace
