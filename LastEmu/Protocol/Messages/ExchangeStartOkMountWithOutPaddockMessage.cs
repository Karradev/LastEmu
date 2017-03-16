using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeStartOkMountWithOutPaddockMessage : NetworkMessage
	{
		public const uint Id = 5991;

		public MountClientData[] stabledMountsDescription;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5991;
			}
		}

		public ExchangeStartOkMountWithOutPaddockMessage()
		{
		}

		public ExchangeStartOkMountWithOutPaddockMessage(MountClientData[] stabledMountsDescription)
		{
			this.stabledMountsDescription = stabledMountsDescription;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.stabledMountsDescription = new MountClientData[num];
			for (int i = 0; i < num; i++)
			{
				this.stabledMountsDescription[i] = new MountClientData();
				this.stabledMountsDescription[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.stabledMountsDescription.Length));
			MountClientData[] mountClientDataArray = this.stabledMountsDescription;
			for (int i = 0; i < (int)mountClientDataArray.Length; i++)
			{
				mountClientDataArray[i].Serialize(writer);
			}
		}
	}
}