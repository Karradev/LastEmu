using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EditHavenBagFinishedMessage : NetworkMessage
	{
		public const uint Id = 6628;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6628;
			}
		}

		public EditHavenBagFinishedMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}