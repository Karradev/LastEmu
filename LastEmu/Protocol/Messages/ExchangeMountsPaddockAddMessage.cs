using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeMountsPaddockAddMessage : NetworkMessage
	{
		public const uint Id = 6561;

		public MountClientData[] mountDescription;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6561;
			}
		}

		public ExchangeMountsPaddockAddMessage()
		{
		}

		public ExchangeMountsPaddockAddMessage(MountClientData[] mountDescription)
		{
			this.mountDescription = mountDescription;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.mountDescription = new MountClientData[num];
			for (int i = 0; i < num; i++)
			{
				this.mountDescription[i] = new MountClientData();
				this.mountDescription[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.mountDescription.Length));
			MountClientData[] mountClientDataArray = this.mountDescription;
			for (int i = 0; i < (int)mountClientDataArray.Length; i++)
			{
				mountClientDataArray[i].Serialize(writer);
			}
		}
	}
}